export GitLog=$ZDev/git-log-append.sh

git add -A | $GitLog
git commit -am "."  | $GitLog
git push | $GitLog
 
