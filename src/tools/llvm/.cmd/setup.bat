echo off

set VarsCmdPath=.cmd\vars.cmd
echo VarsCmdPath:%VarsCmdPath%

call %VarsCmdPath%

set LinkCmdPath=%ScriptRoot%\link.cmd
echo LinkCmdPath:%LinkCmdPath%

set LinkSrc=%LlvmNav%
set LinkDst=%LlvmRoot%
call %LinkCmdPath%

set LinkSrc=%LlvmNavBin%
set LinkDst=%LlvmBin%
call %LinkCmdPath%

set LinkSrc=%LlvmNavInclude%
set LinkDst=%LlvmInclude%
call %LinkCmdPath%
