export ProjectRoot="$(dirname "$0")"
RemoveCmd=$ZDev/$ProjectRoot/remove-project.sh

export ProjectId=canonical
bash $RemoveCmd

export ProjectId=collective
bash $RemoveCmd

export ProjectId=components
bash $RemoveCmd

export ProjectId=memories
bash $RemoveCmd

export ProjectId=monadic
bash $RemoveCmd

export ProjectId=reflections
bash $RemoveCmd

export ProjectId=texting
bash $RemoveCmd

export ProjectId=sfuncs
bash $RemoveCmd

export ProjectId=time
bash $RemoveCmd

export ProjectId=test
bash $RemoveCmd

