set SrcDllName=z0.sys.dll
set DstIlName=z0.sys.il
set SrcDir=%ZDev%\bin\lib\netcoreapp3.0
set DstDir=%ZLogs%\builds\il
set SrcPath=%SrcDir%\%SrcDllName%
set DstPath=%DstDir%\%DstIlName%
set Options="/BYTES /TOKENS /SOURCE /LINENUM /NOBAR /TYPELIST /HEADERS /STATS /CLASSLIST /METADATA=MDHEADER /METADATA=HEX /METADATA=SCHEMA /METADATA=HEAPS /METADATA=RAW"
ildasm %Options% %SrcPath% /out=%DstPath%