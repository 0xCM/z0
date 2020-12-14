@REM @echo off

@REM set GitLogPath=%ZDb%\logs\git\z0-git.log
@REM echo GitLogPath:%GitLogPath%

@REM set Sep=--------------------------------------------------------------------------------------
@REM echo %Sep% >> %GitLogPath%

@REM git add -A >> %GitLogPath%
@REM git commit -am "." >> %GitLogPath%
@REM git push >> %GitLogPath%