echo off

set CleanZTools=rmdir %ZTools% /s/q
echo CleanZTools:%CleanToolsCmd%

echo on

call %CleanZTools%
