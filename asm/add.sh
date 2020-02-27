export ProjectId=asm
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=src
bash $AddCmd

export Kind=core
bash $AddCmd

export Kind=decode
bash $AddCmd

export Kind=test
bash $AddCmd

