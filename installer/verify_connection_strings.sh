#!/bin/bash

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
NC='\033[0m' # No Color

# Configuration
VAULT_DB_HOST="localhost"
VAULT_DB_PORT="5432"
VAULT_DB_NAME="vault"
VAULT_DB_USER="u_vault"
VAULT_DB_PASS=""

# Function to check if a connection string is set
check_connection_string() {
    local service=$1
    local config_file=$2
    local env_var="ConnectionStrings__Vault"
    
    echo -e "\n${YELLOW}Checking $service...${NC}"
    
    # Check environment variable
    if [ -n "${!env_var}" ]; then
        echo -e "${GREEN}✓ Connection string found in environment variable${NC}"
        return 0
    fi
    
    # Check production config
    if [ -f "$config_file" ]; then
        if grep -q '"Vault":' "$config_file"; then
            if grep -q '"Vault": ""' "$config_file"; then
                echo -e "${RED}✗ Empty connection string in $config_file${NC}"
                return 1
            else
                echo -e "${GREEN}✓ Connection string found in $config_file${NC}"
                return 0
            fi
        fi
    fi
    
    echo -e "${RED}✗ No connection string found for $service${NC}"
    return 1
}

# Function to set connection string
set_connection_string() {
    local service=$1
    local config_file=$2
    
    echo -e "\n${YELLOW}Setting connection string for $service...${NC}"
    
    # Create production config if it doesn't exist
    if [ ! -f "$config_file" ]; then
        echo "Creating $config_file..."
        mkdir -p "$(dirname "$config_file")"
        echo "{}" > "$config_file"
    fi
    
    # Generate connection string
    local conn_string="Server=$VAULT_DB_HOST;Port=$VAULT_DB_PORT;Database=$VAULT_DB_NAME;User Id=$VAULT_DB_USER;Password=$VAULT_DB_PASS"
    
    # Update config file
    if command -v jq >/dev/null 2>&1; then
        # Use jq if available
        jq --arg conn "$conn_string" '.ConnectionStrings.Vault = $conn' "$config_file" > "${config_file}.tmp"
        mv "${config_file}.tmp" "$config_file"
    else
        # Fallback to sed
        sed -i "s/\"Vault\": \"\"/\"Vault\": \"$conn_string\"/" "$config_file"
    fi
    
    echo -e "${GREEN}✓ Connection string set in $config_file${NC}"
}

# Main script
echo -e "${YELLOW}Verifying connection strings...${NC}"

# Check each service
SERVICES=(
    "TW.Vault.App:/vault/bin/webapp/appsettings.Production.json"
    "TW.Vault.Manage:/vault/bin/manage/appsettings.Production.json"
    "TW.Vault.MapDataFetcher:/vault/bin/fetcher/appsettings.Production.json"
)

failed=0
for service in "${SERVICES[@]}"; do
    IFS=':' read -r name config <<< "$service"
    if ! check_connection_string "$name" "$config"; then
        failed=$((failed + 1))
        read -p "Set connection string for $name? (y/N) " -n 1 -r
        echo
        if [[ $REPLY =~ ^[Yy]$ ]]; then
            set_connection_string "$name" "$config"
        fi
    fi
done

# Summary
if [ $failed -eq 0 ]; then
    echo -e "\n${GREEN}All connection strings are properly configured!${NC}"
else
    echo -e "\n${RED}$failed services have missing or empty connection strings${NC}"
    echo -e "${YELLOW}Please ensure all services have valid connection strings before starting the application${NC}"
fi

# Instructions for systemd
echo -e "\n${YELLOW}For systemd services, you can also set the connection string via environment:${NC}"
echo "Environment=ConnectionStrings__Vault=\"Server=$VAULT_DB_HOST;Port=$VAULT_DB_PORT;Database=$VAULT_DB_NAME;User Id=$VAULT_DB_USER;Password=$VAULT_DB_PASS\"" 