﻿Get-ChildItem .. | Where-Object{$_.PsIsContainer} | ForEach-Object{
    if(($_.GetFiles(".nuspec").Count -eq 1) -and ($_.GetFiles("*.csproj").Count -eq 1)){
        .\nuget.exe pack $_.GetFiles("*.csproj")[0].FullName -IncludeReferencedProjects
    }
}

Get-ChildItem | Where-Object{$_.Extension -eq ".nupkg"} | ForEach-Object{.\nuget.exe push -Source 'http://localhost:8090/' -apikey 111111 $_}