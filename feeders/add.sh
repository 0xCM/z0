export ProjectId="$(dirname "$0")"
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=collective
bash $AddCmd

export Kind=monadic
bash $AddCmd

export Kind=texting
bash $AddCmd

export Kind=reflections
bash $AddCmd

export Kind=components
bash $AddCmd

export Kind=canonical
bash $AddCmd

export Kind=memories
bash $AddCmd

export Kind=test
bash $AddCmd

