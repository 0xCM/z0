export CreateLog=$ZDev/git-log-create.sh
export AppendLog=$ZDev/git-log-append.sh
git add -A | $CreateLog
git commit -am "."  | $AppendLog
git push | $AppendLog

# git clone --progress XYZ &> git_clone.file
# cd /k/z0/archives
# git add -A
# git commit -am "."

# cd $ZDev