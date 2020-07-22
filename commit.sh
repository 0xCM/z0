export CreateLog=$ZDev/git-log-create.sh
export AppendLog=$ZDev/git-log-append.sh
export ArchiveDir=/k/z0/archives

git add -A | $CreateLog
git commit -am "."  | $AppendLog
git push | $AppendLog

cd $ArchiveDir
git add -A | $AppendLog
git commit -am "."  | $AppendLog
cd $ZDev