export ProjectRoot=test
Cmd=$ZDev/.scripts/add-test.sh

export ProjectId=asm
bash $Cmd

export ProjectId=asmd
bash $Cmd

export ProjectId=bits
bash $Cmd

export ProjectId=dynamic
bash $Cmd

export ProjectId=gvec
bash $Cmd

export ProjectId=identity
bash $Cmd

export ProjectId=logix
bash $Cmd

export ProjectId=machines
bash $Cmd

export ProjectId=math
bash $Cmd

export ProjectId=symbolic
bash $Cmd
