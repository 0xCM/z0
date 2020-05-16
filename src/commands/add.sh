source $(dirname $0)/id.sh
Cmd=$ScriptDir/add-project.sh

export ProjectId=zasm
bash $Cmd 

export ProjectId=zxed
bash $Cmd 

export ProjectId=zice
bash $Cmd 

