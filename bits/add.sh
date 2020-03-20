export ProjectId="$(dirname "$0")"
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=strings
bash $AddCmd

export Kind=core
bash $AddCmd

export Kind=fields
bash $AddCmd

export Kind=grids
bash $AddCmd

export Kind=spans
bash $AddCmd

export Kind=vectors
bash $AddCmd

export Kind=vbits
bash $AddCmd

export Kind=bitpack
bash $AddCmd

export Kind=test
bash $AddCmd
