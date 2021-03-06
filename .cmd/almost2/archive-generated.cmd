@echo off
set Archive=%ZArchive%
set BinDstDir=%Archive%\bin\source
set RepoDir=J:\dev\projects\z0.generated
set ZipDst=%BinDstDir%\z0.generated.zip
set ArchiveLog=%ZDb%\etl\archive-source-generated.log

cd %RepoDir%
git add -A -v
git commit -am "." -v
git archive -v -o %ZipDst% HEAD 2> %ArchiveLog%
