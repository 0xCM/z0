set SlnName="z0.res.sln"
set Archive="K:\z0\archives"
set SrcDir="%Archive%/res"
set SlnPath="%SrcDir%/%SlnName%"
call dotnet.exe build %SlnPath%