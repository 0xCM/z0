source $(dirname $0)/id.sh
Needs=$ScriptDir/local-add-needed.sh

export NeededId=seed
$Needs $NeededId

export NeededId=math
$Needs $NeededId

export NeededId=tuples
$Needs $NeededId

export NeededId=bitcore
$Needs $NeededId
