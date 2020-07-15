REM dotnet clean
msbuild z0.sln /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=bin/needs.json -m
dotnet build -bl:bin/z0.binlog