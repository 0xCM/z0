SlnName=z0.sln
SlnPath=$ZDev/$SlnName

export ProjectRoot=native
Cmd=$ZDev/.scripts/add-native.sh

export ProjectId=mkl
bash $Cmd

Project=z0.mkl.test.csproj
ProjectPath=$ZDev/native/mkl/test/$Project

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath

Project=z0.libm.csproj
ProjectPath=$ZDev/native/libm/$Project

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath


Project=z0.libm.test.csproj
ProjectPath=$ZDev/native/libm.test/$Project

echo Adding $Project to $SlnName solution
dotnet sln $SlnPath add $ProjectPath
