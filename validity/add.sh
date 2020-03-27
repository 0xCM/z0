export ProjectId="$(dirname "$0")"
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=core
bash $AddCmd

export Kind=vectors
bash $AddCmd

export Kind=src
bash $AddCmd