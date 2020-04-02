# export ProjectId=vectorized
# AddCmd=$ZDev/.scripts/sln-add.sh

export ProjectRoot=vectorized
Cmd=$ZDev/.scripts/add-rooted.sh

export ProjectId=circuits
bash $Cmd

export ProjectId=dvec
bash $Cmd

export ProjectId=fvec
bash $Cmd

export ProjectId=gvec
bash $Cmd

export ProjectId=vcore
bash $Cmd

export ProjectId=vdata
bash $Cmd

export ProjectId=vsvc
bash $Cmd

Cmd=$ZDev/.scripts/sln-add.sh
export ProjectId=vectorized
export Kind=test
bash $Cmd
