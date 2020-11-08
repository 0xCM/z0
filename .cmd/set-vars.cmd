set SrcRoot=%ZDev%\src
set ProjectName=z0.%PartId%
set ProjectFile=%ProjectName%.csproj
set ProjectDir=%SrcRoot%\%PartId%
set ProjectPath=%ProjectDir%\%ProjectFile%
set SlnName=z0.%PartId%
set SlnFile=%SlnName%.sln
set SlnDir=%ProjectDir%
set SlnPath=%ProjectDir%\%SlnFile%

set Scripts=%ZDev%\.setup
set set-vars-cmd=%Scripts%\set-vars.cmd
set show-vars-cmd=%Scripts%\show-vars.cmd
set add-project-cmd=%Scripts%\add-project.cmd
set new-sln-cmd=%Scripts%\new-sln.cmd
