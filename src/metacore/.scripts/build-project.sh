RootDir=$ZDev/src/$SlnId
ProjectDir=$RootDir/$ProjectId
ProjectFile=z0.$ProjectId.csproj
ProjectPath=$ProjectDir/$ProjectFile

cd $ProjectDir
echo building $Project
dotnet build

