Cmd=$ZDev/test/run-test.sh

export ProjectId=core
bash $Cmd

export ProjectId=fixed
bash $Cmd

export ProjectId=nats
bash $Cmd
