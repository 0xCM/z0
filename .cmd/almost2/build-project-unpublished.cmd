echo off

set ProjectPath=%ZDev%\src\%ProjectId%\z0.%ProjectId%.csproj
echo ProjectPath:%ProjectPath%

dotnet build %ProjectPath% -c Release