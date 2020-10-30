set TestRunner=%TestSubject%Tests.exe
set TestRunnerPath=%TestRoot%\%TestSubject%\release\%TestRunner%
set TestLogPath=%TestLogRoot%\test-run.%TestSubject%.xml
set TestCmd=%TestRunnerPath% --gtest_output=xml:%TestLogPath%
call %TestCmd%