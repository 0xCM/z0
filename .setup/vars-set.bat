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
set SetCmd=%Scripts%\vars-set.bat
set ShowCmd=%Scripts%\vars-show.bat
set AddCmd=%Scripts%\sln-add.bat
