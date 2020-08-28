set SrcDir=J:\dev\projects\z0\bin\lib\netcoreapp3.1\win-x64
set DstDir=J:\dev\projects\z0-bin
set LogPath="%ZLogs%\etl\publish-bin.log"
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR
