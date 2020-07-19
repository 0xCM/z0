robocopy "%ZLogs%\apps\control\capture" K:\z0\archives\capture /MIR /log:"%ZLogs%\etl\capture-archive.log" /tee /TS /BYTES /V
robocopy "%ZDev%\src\zdata\content" K:\z0\archives\zdata /MIR /log:"%ZLogs%\etl\zdata-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\apps\machine" K:\z0\archives\machine /MIR /log:"%ZLogs%\etl\machine-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\apps\gen" K:\z0\archives\gen /MIR /log:"%ZLogs%\etl\gen-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\test" K:\z0\archives\test /MIR /log:"%ZLogs%\etl\test-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\apps\xed" K:\z0\archives\xed /MIR /log:"%ZLogs%\etl\xed-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\res" K:\z0\archives\res /MIR /log:"%ZLogs%\etl\res-archive.log" /tee /TS /BYTES /V
robocopy "%ZLogs%\exports" K:\z0\archives\exports /MIR /log:"%ZLogs%\etl\exports-archive.log" /tee /TS /BYTES /V

robocopy "%ZLogs%\etl" K:\z0\archives\etl /MIR /log:"%ZLogs%\etl\etl-archive.log" /tee /TS /BYTES /V
copy "%ZDev%\version" /A  K:\z0\archives /Y