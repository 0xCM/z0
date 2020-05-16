Project=z0.$ProjectId.csproj
ProjectDir=$ZDev/src/$AreaId/$ProjectId
ProjectPath=$ProjectDir/$Project

cd $ProjectDir
echo building $Project
dotnet build

