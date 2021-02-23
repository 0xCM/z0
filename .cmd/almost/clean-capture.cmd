@echo off

set CleanDir=%ZDb%\capture
echo CleanDir:%CleanDir%

set CleanCmd=rmdir %CleanDir% /s/q
echo CleanCmd:%CleanCmd%

echo on

call %CleanCmd%

