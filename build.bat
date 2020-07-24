echo off
REM  See https://www.jerriepelser.com/blog/analyze-dotnet-project-dependencies-part-1/
msbuild z0.sln /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=needs.json -m
dotnet build -bl:bin/z0.binlog
echo on