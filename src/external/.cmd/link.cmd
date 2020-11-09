set SrcRoot=%ZDev%\src\external\sources

set SrcDir=%SrcRoot%\runtime
set DstDir=J:\lang\net\runtime

mklink /D %SrcDir% %DstDir%
