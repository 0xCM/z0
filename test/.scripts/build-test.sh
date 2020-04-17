RootDir=$ZDev/test
ProjectDir=$RootDir/$ProjectId
ProjectFile=z0.$ProjectId.test.csproj
ProjectPath=$ProjectDir/$ProjectFile

cd $ProjectDir
echo building $Project
dotnet build

