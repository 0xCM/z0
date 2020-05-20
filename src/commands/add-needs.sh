source $(dirname $0)/id.sh
Cmd=$ScriptDir/add-need.sh

export ProjectId=seed
bash $Cmd

export ProjectId=math
bash $Cmd

export ProjectId=tuples
bash $Cmd

export ProjectId=bitcore
bash $Cmd

export ProjectId=asmd
bash $Cmd