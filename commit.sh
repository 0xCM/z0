export LogCmd=$ZDev/git-log.sh
git add -A | $LogCmd
git commit -am "."  | $LogCmd
#git push | $LogCmd

# git clone --progress XYZ &> git_clone.file
# cd /k/z0/archives
# git add -A
# git commit -am "."

# cd $ZDev