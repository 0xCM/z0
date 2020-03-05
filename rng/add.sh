export ProjectId=rng
bash $ZDev/.scripts/add-project.sh

AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=core
bash $AddCmd
