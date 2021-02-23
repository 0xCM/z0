echo off

set Control=%ZControl%
set CmdRoot=%Control%\.cmd

set CleanDir=%ZDev%\.build
echo CleanDir:%CleanDir%

set CleanDirCmd=rmdir %CleanDir% /s/q
echo CleanDirCmd:%CleanDirCmd%

echo on
call %CleanDirCmd%


