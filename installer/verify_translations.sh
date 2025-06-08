#!/bin/bash

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
NC='\033[0m' # No Color

# Database connection
DB_HOST="localhost"
DB_PORT="5432"
DB_NAME="vault"
DB_USER="u_vault"
DB_PASS=""

# Function to run SQL query
run_query() {
    local query=$1
    PGPASSWORD="$DB_PASS" psql -h "$DB_HOST" -p "$DB_PORT" -d "$DB_NAME" -U "$DB_USER" -t -c "$query"
}

# Function to check table exists
check_table() {
    local table=$1
    local schema=$2
    local result=$(run_query "SELECT EXISTS (SELECT FROM information_schema.tables WHERE table_schema = '$schema' AND table_name = '$table');")
    [ "$result" = " t" ]
}

# Function to check translation data
check_translation_data() {
    echo -e "\n${YELLOW}Checking translation data...${NC}"
    
    # Check languages
    echo "Checking languages..."
    local languages=$(run_query "SELECT id, name FROM feature.translation_language ORDER BY id;")
    if echo "$languages" | grep -q "2.*Hungarian"; then
        echo -e "${GREEN}✓ Hungarian language (ID=2) exists${NC}"
    else
        echo -e "${RED}✗ Hungarian language not found${NC}"
    fi
    
    # Check registries
    echo "Checking translation registries..."
    local registries=$(run_query "SELECT id, name, language_id FROM feature.translation_registry ORDER BY id;")
    if echo "$registries" | grep -q "2.*Hungarian.*2"; then
        echo -e "${GREEN}✓ Hungarian registry (ID=2) exists${NC}"
    else
        echo -e "${RED}✗ Hungarian registry not found${NC}"
    fi
    
    # Check entries
    echo "Checking translation entries..."
    local entries=$(run_query "SELECT COUNT(*) FROM feature.translation WHERE registry_id = 2;")
    if [ "$entries" -gt 0 ]; then
        echo -e "${GREEN}✓ Found $entries Hungarian translations${NC}"
    else
        echo -e "${RED}✗ No Hungarian translations found${NC}"
    fi
    
    # Check world settings
    echo "Checking world settings..."
    local worlds=$(run_query "SELECT COUNT(*) FROM feature.world_settings WHERE default_translation_id = 2;")
    if [ "$worlds" -gt 0 ]; then
        echo -e "${GREEN}✓ Found $worlds worlds using Hungarian translation${NC}"
    else
        echo -e "${RED}✗ No worlds configured for Hungarian translation${NC}"
    fi
}

# Main script
echo -e "${YELLOW}Verifying translation system...${NC}"

# Check required tables
TABLES=(
    "feature:translation_language"
    "feature:translation_registry"
    "feature:translation_key"
    "feature:translation"
    "feature:translation_parameter"
    "feature:world_settings"
)

missing_tables=0
for table in "${TABLES[@]}"; do
    IFS=':' read -r schema name <<< "$table"
    if check_table "$name" "$schema"; then
        echo -e "${GREEN}✓ Table $schema.$name exists${NC}"
    else
        echo -e "${RED}✗ Table $schema.$name missing${NC}"
        missing_tables=$((missing_tables + 1))
    fi
done

if [ $missing_tables -eq 0 ]; then
    check_translation_data
else
    echo -e "\n${RED}$missing_tables required tables are missing${NC}"
    echo -e "${YELLOW}Please run the database migrations before checking translations${NC}"
fi

# Summary
echo -e "\n${YELLOW}Translation System Status:${NC}"
echo "1. Database Tables: $([ $missing_tables -eq 0 ] && echo "OK" || echo "Missing Tables")"
echo "2. Hungarian Language: $(echo "$languages" | grep -q "2.*Hungarian" && echo "OK" || echo "Missing")"
echo "3. Hungarian Registry: $(echo "$registries" | grep -q "2.*Hungarian.*2" && echo "OK" || echo "Missing")"
echo "4. Translation Entries: $([ "$entries" -gt 0 ] && echo "OK ($entries entries)" || echo "Missing")"
echo "5. World Settings: $([ "$worlds" -gt 0 ] && echo "OK ($worlds worlds)" || echo "Missing")" 