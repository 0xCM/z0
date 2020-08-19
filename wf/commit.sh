export GitLog=$ZDev/wf/git-log.sh

git add -A | $GitLog
git commit -am "."  | $GitLog
git push | $GitLog