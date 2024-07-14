$currentFolder = $PSScriptRoot
$slnFolder = Join-Path $currentFolder "../../../"
$composeFolder = Join-Path $slnFolder "build/Dev/docker"

Set-Location $slnFolder

docker-compose -f $composeFolder/docker-compose.infrastructure -p abp-infrastructure down --remove-orphans