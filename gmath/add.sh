export ProjectId="$(dirname "$0")"
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=svc
bash $AddCmd

export Kind=test
bash $AddCmd

