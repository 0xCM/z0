@echo off

set BinDir=%ZDev%\.build\bin\%BuildConfig%\z0.%ProjectId%
echo BinDir:%BinDir%

set ObjDir=%ZDev%\.build\obj\%BuildConfig%\z0.%ProjectId%
echo ObjDir:%ObjDir%

set CleanBinCmd=rmdir %BinDir% /s/q
echo CleanBinCmd:%CleanBinCmd%

set CleanObjCmd=rmdir %ObjDir% /s/q
echo CleanObjCmd:%CleanObjCmd%

echo on

call %CleanBinCmd%
call %CleanObjCmd%