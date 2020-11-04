echo off

set ProjectId=z0.llvm
echo ProjectId:%ProjectId%

set SlnRoot=j:\dev\projects\%ProjectId%
echo SlnRoot:%SlnRoot%

set LlvmRoot=j:\lang\tools\llvm-project
echo LlvmRoot:%LlvmRoot%

set LlvmBin=%LlvmRoot%\build\release\bin
echo LlvmBin:%LlvmBin%

set NavRoot=%SlnRoot%\nav
echo NavRoot:%NavRoot%

set ScriptRoot=%SlnRoot%\.cmd
echo ScriptRoot:%ScriptRoot%

set LlvmNav=%NavRoot%\llvm
echo LlvmNav:%LlvmNav%

set LlvmNavBin=%NavRoot%\llvm-bin
echo LlvmNavBin:%LlvmNavBin%

set LlvmNavInclude=%NavRoot%\llvm-include
echo LlvmNavInclude:%LlvmNavInclude%
