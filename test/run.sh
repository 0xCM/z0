Cmd=$ZDev/test/run-test.sh

export ProjectId=bits
bash $Cmd

export ProjectId=bitsvc
bash $Cmd

export ProjectId=core
bash $Cmd
