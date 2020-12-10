set DstPath=%ZDb%\logs\git\git-actions.log
git add -A >> %DstPath%
git commit -am "."  >> %DstPath%
git push  >> %DstPath%