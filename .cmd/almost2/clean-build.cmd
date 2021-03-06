echo off

set CleanDir=%ZDev%\.build
echo CleanDir:%CleanDir%

set CleanCmd=rmdir %CleanDir% /s/q
echo CleanCmd:%CleanCmd%

echo on
call %CleanDirCmd%