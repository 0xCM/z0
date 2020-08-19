echo off

set ToolPath=J:\lang\net\runtime\artifacts\toolset\ilasm\ildasm.exe
set SrcRoot=j:\dev\projects\z0
set SrcDir=%SrcRoot%\bin\lib\netcoreapp3.0
set DstRoot=j:\dev\projects\z0-logs


set SrcName=z0.asm.models.dll
set Tool=ildasm
set MdOptionName=mdheader
set MdOptions=-METADATA=%MdOptionName%
set DefaultOptions=-bytes -raweh -tokens -linenum -forward -typelist -headers -stats -classlist
set Options=%DefaultOptions% %MdOptions%
set DstExt=%MdOptionName%.il

set DstDir=%DstRoot%\tools\%Tool%
set LogPath=%DstDir%\%Tool%.log

set Cmd=del %DstDir%\%SrcName% /Q
echo %Cmd% >> %LogPath%

echo on
call %Cmd%
echo off

set DstName=%SrcName%.%DstExt%
set SrcPath="%SrcDir%\%SrcName%"
set DstPath=%DstDir%\%DstName%
set DstSpec=-OUT="%DstPath%"

set Cmd=%ToolPath% %Options% %SrcPath% %DstSpec%

echo %Cmd%
echo %Cmd% >> %LogPath%
call %Cmd%

set Cmd=del %DstDir%\*.res /Q
call %Cmd%

rem set UsagePath=%SrcRoot%\src\tools\specs\%Tool%.doc
rem set Cmd=%ToolPath% > %UsagePath%
rem echo %Cmd% >> %LogPath%
rem call %Cmd% > %UsagePath%


REM   /BYTES              Show actual bytes (in hex) as instruction comments.
REM   /RAWEH              Show exception handling clauses in raw form.
REM   /TOKENS             Show metadata tokens of classes and members.
REM   /SOURCE             Show original source lines as comments.
REM   /LINENUM            Include references to original source lines.
REM   /PUBONLY            Only disassemble the public items (same as /VIS=PUB).
REM   /QUOTEALLNAMES      Include all names into single quotes.
REM   /NOCA               Suppress output of custom attributes.
REM   /CAVERBAL           Output CA blobs in verbal form (default - in binary form).
REM   /UTF8               Use UTF-8 encoding for output (default - ANSI).
REM   /UNICODE            Use UNICODE encoding for output.
REM   /NOIL               Suppress IL assembler code output.
REM   /FORWARD            Use forward class declaration.
REM   /TYPELIST           Output full list of types (to preserve type ordering in round-trip).
REM   /PROJECT            Display .NET projection view if input is a .winmd file.
REM   /HEADERS            Include file headers information in the output.
REM   /STATS              Include statistics on the image.
REM   /CLASSLIST          Include list of classes defined in the module.
REM   /ALL                Combination of /HEADER,/BYTES,/STATS,/CLASSLIST,/TOKENS
REM   /METADATA[=<specifier>] Show MetaData, where <specifier> is:
REM           MDHEADER    Show MetaData header information and sizes.
REM           HEX         Show more things in hex as well as words.
REM           CSV         Show the record counts and heap sizes.
REM           UNREX       Show unresolved externals.
REM           SCHEMA      Show the MetaData header and schema information.
REM           RAW         Show the raw MetaData tables.
REM           HEAPS       Show the raw heaps.
REM           VALIDATE    Validate the consistency of the metadata.
