Project=z0.$ProjectId.$Kind.csproj
ProjectDir=$ZDev/$ProjectId/$Kind
ProjectPath=$ProjectDir/$Project

cd $ProjectDir
echo building $Project
dotnet build -bl:$ZDev/bin/z0.$ProjectId.binlog

