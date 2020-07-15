robocopy "%ZLogs%\apps\control\capture" K:\z0\archives\capture /MIR /log:"%ZLogs%\etl\capture-archive.log" /tee /TS /BYTES /V
robocopy "%ZDev%\data" K:\z0\archives\z0-data /MIR /log:"%ZLogs%\etl\data-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\apps\machine" K:\z0\archives\semantic /MIR /log:"%ZLogs%\etl\machine-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\apps\gen" K:\z0\archives\gen /MIR /log:"%ZLogs%\etl\gen-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\test" K:\z0\archives\test /MIR /log:"%ZLogs%\etl\test-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\apps\xed" K:\z0\archives\xed /MIR /log:"%ZLogs%\etl\xed-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\res" K:\z0\archives\res /MIR /log:"%ZLogs%\etl\res-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\etl" K:\z0\archives\etl /MIR /log:"%ZLogs%\etl\etl-archive.log" /tee /TS /BYTES /V

REM J:\tools\git\bin\bash.exe J:\dev\projects\z0\archive.sh