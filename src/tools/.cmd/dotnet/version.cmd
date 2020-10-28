echo off

set CmdRootName=netsdk
echo CmdRootName:%CmdRootName%

set CmdName=dotnet
echo CmdName:%CmdName%

set ArgDelimiter=--
echo ArgDelimiter:%ArgDelimiter%

set CmdArgName=version
echo CmdArgName:%CmdArgName%

set CmdRoot=%ztools%\%CmdRootName%
echo CmdRoot:%CmdRoot%

set CmdPath=%CmdRoot%\%CmdName%
echo CmdPath:%CmdPath%

set CmdArgs=%ArgDelimiter%%CmdArgName%
echo CmdArgs:%CmdArgs%

set CmdSpec=%CmdPath% %CmdArgs%
echo CmdSpec:%CmdSpec%

set CmdOutName=%CmdName%.%CmdArgName%.log
echo CmdOutName:%CmdOutName%

set CmdOutDir=%ZDb%\tools\%CmdName%
echo CmdOutDir:%CmdOutDir%

mkdir %CmdOutDir%

set CmdOutPath=%CmdOutDir%\%CmdOutName%
echo CmdOutPath:%CmdOutPath%

echo on
call %CmdSpec% > %CmdOutPath%