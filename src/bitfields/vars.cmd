set RootDir=%ZDev%\src\%ProjectId%
set LibPath=%RootDir%\z0.%ProjectId%.csproj
set RunPath=%RootDir%\z0.%ProjectId%.run.csproj
set BuildCmd=dotnet build %RunPath%
set RunCmd=dotnet run --project %RunPath%