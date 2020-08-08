set WfRoot=%ZDev%\wf
set Tool=dumpbin
set DstDir="%ZLogs%/tools/%Tool%"

rmdir %DstDir% /q /s
mkdir %DstDir%
mkdir %DstDir%/%ArchiveMembers%
mkdir %DstDir%/%ClrHeader%
mkdir %DstDir%/%Dependents%
mkdir %DstDir%/%Disasm%
mkdir %DstDir%/%Directives%
mkdir %DstDir%/%Exports%
mkdir %DstDir%/%Fpo%
mkdir %DstDir%/%Headers%
mkdir %DstDir%/%Imports%
mkdir %DstDir%/%LinkerMember%
mkdir %DstDir%/%LoadConfig%
mkdir %DstDir%/%RawData%
mkdir %DstDir%/%Relocations%
mkdir %DstDir%/%Summary%
mkdir %DstDir%/%Symbols%
mkdir %DstDir%/%Tls% 