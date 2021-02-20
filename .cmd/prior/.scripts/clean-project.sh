DevRootDir=$ZDev
SrcRootDir=$DevRootDir/src
ProjectDir=$SrcRootDir/$ProjectId
ProjectSrcDir=$ProjectDir
ProjectFile=z0.$ProjectId.csproj
ProjectPath=$ProjectSrcDir/$ProjectFile

cd $ProjectSrcDir
echo cleaning $Project
dotnet clean