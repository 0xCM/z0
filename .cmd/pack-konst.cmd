@echo off

set ProjectId=part
call .cmd\pack.cmd

set ProjectId=external
call .cmd\pack.cmd

set ProjectId=refs
call .cmd\pack.cmd

set ProjectId=res
call .cmd\pack.cmd

set ProjectId=konst
call .cmd\pack.cmd

