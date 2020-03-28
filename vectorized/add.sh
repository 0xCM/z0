export ProjectId="$(dirname "$0")"
bash $ZDev/.scripts/add-project.sh

AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=vdata
bash $AddCmd

export Kind=dvec
bash $AddCmd

export Kind=gvec
bash $AddCmd

export Kind=fvec
bash $AddCmd

export Kind=circuits
bash $AddCmd

export Kind=vsvc
bash $AddCmd
