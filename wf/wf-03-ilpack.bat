set SrcDir=%ZDev%\bin\lib\netcoreapp3.0
set DstDir=%StageIl%
set Options="/NOBAR /BYTES /TOKENS /RAWEH /SOURCE /LINENUM /NOBAR /TYPELIST /HEADERS /STATS /CLASSLIST /METADATA=MDHEADER /METADATA=HEX /METADATA=SCHEMA /METADATA=HEAPS /METADATA=RAW /METADATA=UNREX"

set SrcDllName=z0.sys.dll
set DstIlName=z0.sys.il
set SrcPath=%SrcDir%\%SrcDllName%
set DstPath=%DstDir%\%DstIlName%

ildasm %Options% %SrcPath% /out=%DstPath%

set SrcDllName=z0.konst.dll
set DstIlName=z0.konst.il
set SrcPath=%SrcDir%\%SrcDllName%
set DstPath=%DstDir%\%DstIlName%

ildasm %Options% %SrcPath% /out=%DstPath%

set SrcDllName=z0.part.dll
set DstIlName=z0.part.il
set SrcPath=%SrcDir%\%SrcDllName%
set DstPath=%DstDir%\%DstIlName%
ildasm %Options% %SrcPath% /out=%DstPath%

set SrcDllName=z0.domain.dll
set DstIlName=z0.domain.il
set SrcPath=%SrcDir%\%SrcDllName%
set DstPath=%DstDir%\%DstIlName%
ildasm %Options% %SrcPath% /out=%DstPath%
