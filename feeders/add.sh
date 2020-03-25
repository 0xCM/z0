export ProjectRoot="$(dirname "$0")"
AddCmd=$ZDev/$ProjectRoot/add-project.sh

export ProjectId=canonical
bash $AddCmd

export ProjectId=collective
bash $AddCmd

export ProjectId=components
bash $AddCmd

export ProjectId=custom
bash $AddCmd

export ProjectId=identify
bash $AddCmd

export ProjectId=kinds
bash $AddCmd

export ProjectId=memories
bash $AddCmd

export ProjectId=monadic
bash $AddCmd

export ProjectId=reflective
bash $AddCmd

export ProjectId=symbolic
bash $AddCmd

export ProjectId=sfuncs
bash $AddCmd

export ProjectId=texting
bash $AddCmd

export ProjectId=time
bash $AddCmd

dotnet sln add $ProjectRoot/test/z0.feeders.test.csproj