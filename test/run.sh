Cmd=$ZDev/test/run-test.sh

export ProjectId=core
bash $Cmd

export ProjectId=nats
bash $Cmd

bash $ZDev/test/dynamic.sh