#!/bin/bash

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
NC='\033[0m' # No Color

# Configuration
DB_HOST="localhost"
DB_PORT="5432"
DB_NAME="vault"
DB_USER="u_vault"
DB_PASS=""

# Generate connection string
CONN_STRING="Server=$DB_HOST;Port=$DB_PORT;Database=$DB_NAME;User Id=$DB_USER;Password=$DB_PASS"

# Function to update service file
update_service_file() {
    local service_file=$1
    local service_name=$2
    local working_dir=$3
    local exec_path=$4
    local port=$5
    
    echo -e "\n${YELLOW}Updating $service_file...${NC}"
    
    # Create service file content
    cat > "$service_file" << EOF
[Unit]
Description=TW Vault $service_name
After=network.target

[Service]
Type=simple
User=root
WorkingDirectory=$working_dir
ExecStart=/usr/bin/dotnet $exec_path
Restart=always
RestartSec=10
Environment="ASPNETCORE_ENVIRONMENT=Production"
Environment="ConnectionStrings__Vault=$CONN_STRING"
Environment="ASPNETCORE_URLS=http://localhost:$port"
Environment="Translation__BaseTranslationId=2"

[Install]
WantedBy=multi-user.target
EOF

    echo -e "${GREEN}✓ Created $service_file${NC}"
}

# Main script
echo -e "${YELLOW}Updating systemd service files...${NC}"

# Update each service
SERVICES=(
    "/etc/systemd/system/twvault-app.service:TW Vault Web App:/vault/bin/webapp:TW.Vault.App.dll:5000"
    "/etc/systemd/system/twvault-manage.service:TW Vault Management:/vault/bin/manage:TW.Vault.Manage.dll:5001"
    "/etc/systemd/system/twvault-mapdatafetcher.service:TW Vault Map Data Fetcher:/vault/bin/fetcher:TW.Vault.MapDataFetcher.dll:5002"
)

for service in "${SERVICES[@]}"; do
    IFS=':' read -r file name dir exec port <<< "$service"
    update_service_file "$file" "$name" "$dir" "$exec" "$port"
done

# Reload systemd
echo -e "\n${YELLOW}Reloading systemd...${NC}"
systemctl daemon-reload

echo -e "\n${GREEN}Service files updated successfully!${NC}"
echo -e "${YELLOW}To start the services, run:${NC}"
echo "systemctl start twvault-app twvault-manage twvault-mapdatafetcher"
echo -e "${YELLOW}To enable them on boot:${NC}"
echo "systemctl enable twvault-app twvault-manage twvault-mapdatafetcher" 