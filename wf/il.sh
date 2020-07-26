export ToolDir="C:/Program Files (x86)/Microsoft SDKs/Windows/v10.0A/bin/NETFX 4.8 Tools/x64"
export ToolName="ildasm.exe"
export ToolPath=$ToolDir/$ToolName
export SrcDllName=z0.sys.dll
export DstIlName=z0.sys.il
export SrcDir=$ZDev/bin/lib/netcoreapp3.0
export DstDir=$ZLogs/builds/il
export SrcPath=$SrcDir/$SrcDllName
export DstPath=$DstDir/$DstIlName
export Options="/BYTES /TOKENS /SOURCE /LINENUM /NOBAR /TYPELIST /HEADERS /STATS /CLASSLIST /METADATA=MDHEADER /METADATA=HEX /METADATA=SCHEMA /METADATA=HEAPS /METADATA=RAW "
export ToolInput="/out=$DstPath"
bash $ToolPath "$Options $SrcPath $ToolInput"