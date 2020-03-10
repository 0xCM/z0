export ProjectId="$(dirname "$0")"

AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=core
bash $AddCmd

export Kind=runtime
bash $AddCmd

export Kind=test
bash $AddCmd
