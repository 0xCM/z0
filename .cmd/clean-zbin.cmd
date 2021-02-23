echo off

set CleanDir=%ZTools%\z
echo CleanDir:%CleanDir%

set CleanCmd=rmdir %CleanDir% /s/q
echo CleanCmd:%CleanCmd%

echo on

call %CleanCmd%
