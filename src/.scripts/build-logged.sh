DevRootDir=$ZDev
SrcRootDir=$DevRootDir/src
ProjectDir=$SrcRootDir/$ProjectId
ProjectSrcDir=$ProjectDir
ProjectFile=z0.$ProjectId.csproj
ProjectPath=$ProjectSrcDir/$ProjectFile
BuildLogDir=$DevRootDir/bin

cd $ProjectSrcDir
echo building $Project
dotnet build -bl:$BuildLogDir/z0.$ProjectId.binlog

