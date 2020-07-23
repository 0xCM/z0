echo off
call build.bat
call unbuild.bat
call emit.bat
call respack.bat
call deposit.bat
call emit.bat
REM version bump
call respack.bat
call deposit.bat
call commit.bat
echo on