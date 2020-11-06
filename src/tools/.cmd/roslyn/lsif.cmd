echo off
set LsifCmd=J:\lang\net\roslyn\artifacts\bin\Microsoft.CodeAnalysis.LanguageServerIndexFormat.Generator\Release\net472\Microsoft.CodeAnalysis.LanguageServerIndexFormat.Generator.exe

call %LsifCmd% --solution j:\dev\projects\z0\z0.sln --output z0.lsif --log z0.lsif.log

