REM msbuild z0.sln /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=bin/needs.json -m
call needs.bat
dotnet build -bl:bin/z0.binlog