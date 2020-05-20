source $(dirname $0)/id.sh
Cmd=$ScriptDir/remove-project.sh

export ProjectId=zasm
bash $Cmd

export ProjectId=zice
bash $Cmd

export ProjectId=zxed
bash $Cmd
