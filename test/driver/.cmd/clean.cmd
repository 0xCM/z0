echo off

call .cmd\config.cmd

echo on

rmdir %ProjectBinDir% /s/q
rmdir %ProjectObjDir% /s/q