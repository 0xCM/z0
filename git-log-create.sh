[ $# -ge 1 -a -f "$1" ] && input="$1" || input="-"
cat $input > .logs/git-log.log