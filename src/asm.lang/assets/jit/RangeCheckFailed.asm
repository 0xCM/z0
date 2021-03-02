;--- f:\workspace\_work\1\s\src\vm\jithelpers.cpp -------------------------------
00007FFEBD72FD20 48 81 EC 28 01 00 00 sub         rsp,128h
00007FFEBD72FD27 48 C7 44 24 20 FE FF FF FF mov         qword ptr [rsp+20h],0FFFFFFFFFFFFFFFEh
00007FFEBD72FD30 48 8B 05 D1 B2 2A 00 mov         rax,qword ptr [__security_cookie (07FFEBD9DB008h)]
00007FFEBD72FD37 48 33 C4             xor         rax,rsp
00007FFEBD72FD3A 48 89 84 24 10 01 00 00 mov         qword ptr [rsp+110h],rax
00007FFEBD72FD42 48 83 64 24 40 00    and         qword ptr [rsp+40h],0
00007FFEBD72FD48 48 8D 05 01 68 1D 00 lea         rax,[HelperMethodFrame::`vftable' (07FFEBD906550h)]
00007FFEBD72FD4F 48 89 44 24 38       mov         qword ptr [rsp+38h],rax
00007FFEBD72FD54 C7 44 24 50 01 00 00 00 mov         dword ptr [rsp+50h],1
00007FFEBD72FD5C 48 83 64 24 60 00    and         qword ptr [rsp+60h],0
00007FFEBD72FD62 48 8D 4C 24 68       lea         rcx,[rsp+68h]
00007FFEBD72FD67 E8 A4 66 ED FF       call        LazyMachStateCaptureState (07FFEBD606410h)
00007FFEBD72FD6C 48 8D 4C 24 38       lea         rcx,[rsp+38h]
00007FFEBD72FD71 E8 12 5E E9 FF       call        HelperMethodFrame::Push (07FFEBD5C5B88h)
00007FFEBD72FD76 90                   nop
00007FFEBD72FD77 B9 17 00 00 00       mov         ecx,17h
00007FFEBD72FD7C E8 FF 86 FC FF       call        RealCOMPlusThrow (07FFEBD6F8480h)
00007FFEBD72FD81 90                   nop
00007FFEBD72FD82 48 8B 54 24 28       mov         rdx,qword ptr [__pException]
00007FFEBD72FD87 E8 E4 B4 FC FF       call        UnwindAndContinueRethrowHelperAfterCatch (07FFEBD6FB270h)
00007FFEBD72FD8C CC                   int         3
$LN67:
00007FFEBD72FD8D 48 89 54 24 10       mov         qword ptr [rsp+10h],rdx
00007FFEBD72FD92 55                   push        rbp
00007FFEBD72FD93 48 83 EC 20          sub         rsp,20h
00007FFEBD72FD97 48 8B EA             mov         rbp,rdx
00007FFEBD72FD9A 48 8D 4D 38          lea         rcx,[rbp+38h]
00007FFEBD72FD9E E8 1D B5 FC FF       call        UnwindAndContinueRethrowHelperInsideCatch (07FFEBD6FB2C0h)
00007FFEBD72FDA3 90                   nop
00007FFEBD72FDA4 48 8D 05 D7 FF FF FF lea         rax,[JIT_RngChkFail+62h (07FFEBD72FD82h)]
00007FFEBD72FDAB 48 83 C4 20          add         rsp,20h
00007FFEBD72FDAF 5D                   pop         rbp
00007FFEBD72FDB0 C3                   ret
00007FFEBD72FDB1 CC                   int         3
