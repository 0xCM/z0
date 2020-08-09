set FileName=z0.binlog
set Src="%DevBuildRoot%\%FileName%"
set Dst="%StageBuildRoot%\%FileName%"
copy %Src% /A %Dst% /Y

set FileName=z0.ProjectImports.zip
set Src="%DevBuildRoot%\%FileName%"
set Dst="%StageBuildRoot%\%FileName%"
copy %Src% /A %Dst% /Y

set Src=%DevLib%
set Dst=%StageLib%
set Log="%EtlLogDir%\stage-lib.log"
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR 

set Src=%DevObj%
set Dst=%StageObj%
set Log="%EtlLogDir%\stage-obj.log"
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR 