@echo off
set _path_git=%%path_git%%
set _path_zbin=%%path_zbin%%
set _path_vscode=%%path_vscode%%
set _path_netsdk=%%path_netsdk%%
set _path_winptk=%%path_winptk%%
set _path_windebug=%%path_windebug%%
set _path_llvm=%%path_llvm%%

set path_vars=%_path_vscode%;%_path_git%;%_path_zbin%;%_path_netsdk%;%_path_winptk%;%_path_windebug%;%_path_llvm%
echo path_vars:%path_vars%