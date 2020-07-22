[ $# -ge 1 -a -f "$1" ] && input="$1" || input="-"
cat $input > git-log.log