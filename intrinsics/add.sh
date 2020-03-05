export ProjectId="$(dirname "$0")"
bash $ZDev/.scripts/add-project.sh

AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=svc
bash $AddCmd
