export ProjectId="$(dirname "$0")"
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=monadic
bash $AddCmd

export Kind=texting
bash $AddCmd

export Kind=reflections
bash $AddCmd

export Kind=test
bash $AddCmd

