set RootDir=../
dotnet sln add %RootDir%nats/src/z0.nats.csproj
dotnet sln add %RootDir%base/corefunc/src/z0.corefunc.csproj
dotnet sln add %RootDir%base/corefunc/test/z0.corefunc.test.csproj

dotnet sln add nats/src/z0.nats.csproj
dotnet sln add nats/test/z0.nats.test.csproj