export ProjectId=rng

AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=core
bash $AddCmd

export Kind=test
bash $AddCmd

export ParentId=rng
AddCmd=$ZDev/$ParentId/sources/add.sh
bash $AddCmd
