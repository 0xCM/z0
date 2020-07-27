set DstDir=%ZLogs%\builds
set DstFile=z0.needs.json
set DstPath="%DstDir%\%DstFile%"

set Cmd=msbuild z0.sln /t:GenerateRestoreGraphFile /p:RestoreGraphOutputPath=%DstPath% -m /noAutoResponse /detailedSummary
call %Cmd%