export ProjectRoot=vectorized
Cmd=$ZDev/.scripts/remove-rooted.sh

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

