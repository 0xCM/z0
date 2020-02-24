export ProjectId=rng
AddCmd=$ZDev/.scripts/sln-add.sh

export Kind=src
bash $AddCmd

export Kind=test
bash $AddCmd

# export Kind=svc
# bash $AddCmd


