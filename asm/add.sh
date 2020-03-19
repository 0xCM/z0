export ProjectId="$(dirname "$0")"
bash $ZDev/.scripts/add-project.sh

AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=core
bash $AddCmd

export Kind=encode
bash $AddCmd

export Kind=decode
bash $AddCmd

export Kind=app
bash $AddCmd

export Kind=test
bash $AddCmd

