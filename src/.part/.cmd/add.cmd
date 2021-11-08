@echo off

set Project=%SrcRoot%\%ProjectId%\z0.%ProjectId%.csproj
dotnet sln %Sln% add %Project%