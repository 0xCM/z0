set WfRoot=%ZDev%\wf
call %WfRoot%\vars.cmd

set Tool=dumpbin
set ToolDstDir=%ZLogs%\tools\%Tool%
set ToolLogPath=%ZLogs%\tools\logs\%Tool%.log

set n1=1
set n2=2
set n3=3
set n4=4
set n5=5
set n8=8
set n16=16
set n32=32
set n64=64

set w1=%n1%
set w2=%n2%
set w4=%n4%
set w8=%n8%
set w16=%n16%
set w32=%n32%
set w64=%n64%

set Hex8=%n1%
set Hex16=%n2%
set Hex32=%n4%
set Hex64=%n8%

set ArchiveMembers=archivemembers
set ClrHeader=clrheader
set Dependents=dependents
set Directives=directives
set Disasm=disasm
set Exports=exports
set Fpo=fpo
set Headers=headers
set Imports=imports
set LineNumbers=linenumbers
set LinkerMember=linkermember
set LoadConfig=loadconfig
set RawData=rawdata
set Relocations=relocations
set Summary=summary
set Symbols=symbols
set Tls=tls

set DefaultFlags=/NoLogo

set Hex8x8=%Hex8%,%w8%
set Hex8x16=%Hex8%,%w16%
set Hex8x32=%Hex8%,%w32%
set Hex8x64=%Hex8%,%w64%

set Hex16x8=%Hex16%,%w8%
set Hex16x16=%Hex16%,%w16%
set Hex16x32=%Hex16%,%w32%
set Hex16x64=%Hex16%,%w64%

set Hex32x8=%Hex32%,%w8%
set Hex32x16=%Hex32%,%w16%
set Hex32x32=%Hex32%,%w32%
set Hex32x64=%Hex32%,%w64%

set Hex64x8=%Hex64%,%w8%
set Hex64x16=%Hex64%,%w16%
set Hex64x32=%Hex64%,%w32%
set Hex64x64=%Hex64%,%w64%