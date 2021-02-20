DevRootDir=$ZDev
SrcRootDir=$DevRootDir/src
ProjectDir=$SrcRootDir/$ProjectId
ProjectSrcDir=$ProjectDir/src
ProjectFile=z0.$ProjectId.csproj
ProjectPath=$ProjectSrcDir/$ProjectFile

cd $ProjectSrcDir
echo building $Project
dotnet build

