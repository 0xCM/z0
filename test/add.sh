Cmd=$ZDev/test/add-test.sh

export ProjectId=core
bash $Cmd

export ProjectId=fixed
bash $Cmd

export ProjectId=nats
bash $Cmd

