# This script is used for testing the template locally.
# It will uninstall the template, clean the template engine user directory, and reinstall the template.

dotnet new --uninstall $PSScriptRoot/src/templates
$templateEngineUserDir = (Join-Path -Path $env:USERPROFILE -ChildPath .templateengine)
Get-ChildItem -path $templateEngineUserDir -directory | Select-Object -ExpandProperty FullName | Remove-Item -recurse -force
dotnet new --install $PSScriptRoot/src/templates