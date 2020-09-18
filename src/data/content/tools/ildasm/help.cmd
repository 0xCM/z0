echo off
set Cmd=%tool-ildasm% -?
echo %Cmd%
call %Cmd% > ildasm.log