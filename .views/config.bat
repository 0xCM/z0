echo off
set Part=konst
set Subject=reflective
set ViewSpace=%ZDev%\.views
set Log=%ViewSpace%\config.log
set Data=%ZDev%\src\%Part%\src\%Subject%
set View=%ViewSpace%\%Subject%
set Cmd=mklink /D %View% %Data%
echo %Cmd% >> %Log%
del %View%
call %Cmd% >> %Log%