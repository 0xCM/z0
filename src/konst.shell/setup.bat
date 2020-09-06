echo off

set PartId=konst.shell
call %ZDev%\.setup\set-vars.cmd
call %set-vars-cmd%

set sln_name=%SlnName%
set sln_dir=%SlnDir%
:: call %new-sln-cmd%

set sln_file=%SlnPath%
set project_path=%ProjectPath%
call %add-project-cmd%

set PartId=part
call %set-vars-cmd%
set project_path=%ProjectPath%
call %add-project-cmd%

set PartId=sys
call %set-vars-cmd%
set project_path=%ProjectPath%
call %add-project-cmd%

set PartId=konst
call %set-vars-cmd%
set project_path=%ProjectPath%
call %add-project-cmd%
