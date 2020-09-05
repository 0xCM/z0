echo off

set PartId=konst
call %SetCmd%
set sln_file=%SlnPath%

set PartId=part
call %SetCmd%
set project_path=%ProjectPath%
call %AddCmd%

set PartId=sys
call %SetCmd%
set project_path=%ProjectPath%
call %AddCmd%

