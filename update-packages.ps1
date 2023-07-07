# Updates all packages in all *.csproj files in src/templates

$packagesToUpdate = @("ArtemisRGB.UI.Shared", "ArtemisRGB.Plugins.BuildTask")
$templatesDir = Join-Path -Path $PSScriptRoot -ChildPath "src/templates"
$templates = Get-ChildItem -Path $templatesDir -Filter *.csproj -Recurse

foreach ($template in $templates) {
    $templatePath = $template.FullName
    Write-Host "Updating packages in $templatePath"
    foreach ($package in $packagesToUpdate) {
        dotnet add $templatePath package $package
    }
}