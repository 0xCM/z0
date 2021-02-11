@echo off

set ZC=%ZControl%
echo ZC:%ZC%

set ZCmd=%ZC%\.cmd
echo ZCmd=%ZCmd%

call %ZCmd%\update-dev-scripts.cmd
call %ZCmd%\archive-capture.cmd
call %ZCmd%\archive-build.cmd
call %ZCmd%\archive-tables.cmd
call %ZCmd%\archive-generated.cmd
call %ZCmd%\archive-source.cmd
call %ZCmd%\archive-app-logs.cmd
call %ZCmd%\archive-dumps.cmd
call %ZCmd%\archive-tools.cmd
call %ZCmd%\archive-etl-logs.cmd

