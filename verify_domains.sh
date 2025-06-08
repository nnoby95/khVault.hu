#!/bin/bash
echo "Searching for any remaining old domains..."
echo "=================================="

echo "Searching for khvault.hu:"
grep -r "khvault\.hu" . --exclude-dir=.git --exclude-dir=bin --exclude-dir=obj --exclude="*.dll" | grep -v "khvault.nnorbert.xyz"

echo -e "\nSearching for v.tylercamp.me:"
grep -r "v\.tylercamp\.me" . --exclude-dir=.git --exclude-dir=bin --exclude-dir=obj --exclude="*.dll" | grep -v "khvault.nnorbert.xyz"

echo -e "\nTotal occurrences:"
echo "khvault.hu: $(grep -r "khvault\.hu" . --exclude-dir=.git --exclude-dir=bin --exclude-dir=obj | wc -l)"
echo "v.tylercamp.me: $(grep -r "v\.tylercamp\.me" . --exclude-dir=.git --exclude-dir=bin --exclude-dir=obj | wc -l)" 