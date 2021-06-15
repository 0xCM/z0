//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Root;

    partial struct Prototypes
    {
        [ApiHost(prototypes + calls)]
        public readonly struct Calls
        {
            [Op, Size(18)]
            public static MemoryAddress call(N0 n)
                => target(n);

            [Op, Size(18)]
            public static MemoryAddress call(N1 n)
                => target(n);

            [Op, Size(18)]
            public static MemoryAddress call(N2 n)
                => target(n);

            [Op, Size(18)]
            public static MemoryAddress call(N3 n)
                => target(n);

            [Op, MethodImpl(NotInline)]
            static MemoryAddress target(N0 n)
                => (MemoryAddress)MethodInfo.GetCurrentMethod().MethodHandle.GetFunctionPointer();

            [Op, MethodImpl(NotInline)]
            static MemoryAddress target(N1 n)
                => (MemoryAddress)MethodInfo.GetCurrentMethod().MethodHandle.GetFunctionPointer();

            [Op, MethodImpl(NotInline)]
            static MemoryAddress target(N2 n)
                => (MemoryAddress)MethodInfo.GetCurrentMethod().MethodHandle.GetFunctionPointer();

            [Op, MethodImpl(NotInline)]
            static MemoryAddress target(N3 n)
                => (MemoryAddress)MethodInfo.GetCurrentMethod().MethodHandle.GetFunctionPointer();
        }
    }

    /*
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress call(N0 n)::located://asmcases/prototypes.calls?call#call_(n0)
        ; public static ReadOnlySpan<byte> call_ᐤn0ᐤ => new byte[24]{0x48,0x89,0x4c,0x24,0x08,0x48,0x0f,0xbe,0x4c,0x24,0x08,0x48,0xb8,0x90,0xdc,0xbf,0xa4,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0};
        ; BaseAddress = 7ffaa6f94320h
        ; TermCode = CTC_JMP_RAX
        0000h mov [rsp+8],rcx                               ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 4c 24 08
        0005h movsx rcx,byte ptr [rsp+8]                    ; MOVSX r64, r/m8                  | REX.W 0F BE /r                   | 6   | 48 0f be 4c 24 08
        000bh mov rax,7ffaa4bfdc90h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b8 90 dc bf a4 fa 7f 00 00
        0015h jmp rax                                       ; JMP r/m64                        | FF /4                            | 3   | 48 ff e0

        ; 00007FFAA6F9432B 48 B8 90 DC BF A4 FA 7F 00 00 mov         rax,offset CLRStub[MethodDescPrestub]@7ffaa4bfdc90 (07FFAA4BFDC90h)

        ; 00007FFAA4BFDC90 E8 8B 85 60 5D       call        PrecodeFixupThunk (07FFB02206220h)
        ; 00007FFAA4BFDC95 5E                   pop         rsi
        ; 00007FFAA4BFDC96 08 03                or          byte ptr [rbx],al
        ; 00007FFAA4BFDC98 E8 83 85 60 5D       call        PrecodeFixupThunk (07FFB02206220h)
        ; 00007FFAA4BFDC9D 5E                   pop         rsi
        ; 00007FFAA4BFDC9E 0A 02                or          al,byte ptr [rdx]
        ; 00007FFAA4BFDCA0 E8 7B 85 60 5D       call        PrecodeFixupThunk (07FFB02206220h)
        ; 00007FFAA4BFDCA5 5E                   pop         rsi
        ; 00007FFAA4BFDCA6 0C 01                or          al,1
        ; 00007FFAA4BFDCA8 E8 73 85 60 5D       call        PrecodeFixupThunk (07FFB02206220h)
        ; 00007FFAA4BFDCAD 5E                   pop         rsi

        ; 00007FFB02206220 58                   pop         rax
        ; 00007FFB02206221 4C 0F B6 50 02       movzx       r10,byte ptr [rax+2]
        ; 00007FFB02206226 4C 0F B6 58 01       movzx       r11,byte ptr [rax+1]
        ; 00007FFB0220622B 4A 8B 44 D0 03       mov         rax,qword ptr [rax+r10*8+3]
        ; 00007FFB02206230 4E 8D 14 D8          lea         r10,[rax+r11*8]
        ; 00007FFB02206234 E9 47 03 00 00       jmp         ThePreStub (07FFB02206580h)

        ; --- D:\workspace\_work\1\s\src\vm\amd64\ThePreStubAMD64.asm --------------------
        ; 00007FFB02206580 41 57                push        r15
        ; 00007FFB02206582 41 56                push        r14
        ; 00007FFB02206584 41 55                push        r13
        ; 00007FFB02206586 41 54                push        r12
        ; 00007FFB02206588 55                   push        rbp
        ; 00007FFB02206589 53                   push        rbx
        ; 00007FFB0220658A 56                   push        rsi
        ; 00007FFB0220658B 57                   push        rdi
        ; 00007FFB0220658C 48 83 EC 68          sub         rsp,68h
        ; 00007FFB02206590 48 89 8C 24 B0 00 00 00 mov         qword ptr [rsp+0B0h],rcx
        ; 00007FFB02206598 48 89 94 24 B8 00 00 00 mov         qword ptr [rsp+0B8h],rdx
        ; 00007FFB022065A0 4C 89 84 24 C0 00 00 00 mov         qword ptr [rsp+0C0h],r8
        ; 00007FFB022065A8 4C 89 8C 24 C8 00 00 00 mov         qword ptr [rsp+0C8h],r9
        ; 00007FFB022065B0 66 0F 7F 44 24 20    movdqa      xmmword ptr [rsp+20h],xmm0
        ; 00007FFB022065B6 66 0F 7F 4C 24 30    movdqa      xmmword ptr [rsp+30h],xmm1
        ; 00007FFB022065BC 66 0F 7F 54 24 40    movdqa      xmmword ptr [rsp+40h],xmm2
        ; 00007FFB022065C2 66 0F 7F 5C 24 50    movdqa      xmmword ptr [rsp+50h],xmm3
        ; 00007FFB022065C8 48 8D 4C 24 68       lea         rcx,[rsp+68h]
        ; 00007FFB022065CD 49 8B D2             mov         rdx,r10
        ; 00007FFB022065D0 E8 3B FC F1 FF       call        PreStubWorker (07FFB02126210h)
        ; 00007FFB022065D5 66 0F 6F 44 24 20    movdqa      xmm0,xmmword ptr [rsp+20h]
        ; 00007FFB022065DB 66 0F 6F 4C 24 30    movdqa      xmm1,xmmword ptr [rsp+30h]
        ; 00007FFB022065E1 66 0F 6F 54 24 40    movdqa      xmm2,xmmword ptr [rsp+40h]
        ; 00007FFB022065E7 66 0F 6F 5C 24 50    movdqa      xmm3,xmmword ptr [rsp+50h]
        ; 00007FFB022065ED 48 8B 8C 24 B0 00 00 00 mov         rcx,qword ptr [rsp+0B0h]
        ; 00007FFB022065F5 48 8B 94 24 B8 00 00 00 mov         rdx,qword ptr [rsp+0B8h]
        ; 00007FFB022065FD 4C 8B 84 24 C0 00 00 00 mov         r8,qword ptr [rsp+0C0h]
        ; 00007FFB02206605 4C 8B 8C 24 C8 00 00 00 mov         r9,qword ptr [rsp+0C8h]
        ; 00007FFB0220660D 48 83 C4 68          add         rsp,68h
        ; 00007FFB02206611 5F                   pop         rdi
        ; 00007FFB02206612 5E                   pop         rsi
        ; 00007FFB02206613 5B                   pop         rbx
        ; 00007FFB02206614 5D                   pop         rbp
        ; 00007FFB02206615 41 5C                pop         r12
        ; 00007FFB02206617 41 5D                pop         r13
        ; 00007FFB02206619 41 5E                pop         r14
        ; 00007FFB0220661B 41 5F                pop         r15
        ; 00007FFB0220661D 48 FF E0             jmp         rax
        ; 00007FFB02206620 A9 22 00 00 00       test        eax,22h
        ; 00007FFB02206625 C3                   ret

        ; 00007FFB02206220 58                   pop         rax
        ; 00007FFB02206221 4C 0F B6 50 02       movzx       r10,byte ptr [rax+2]
        ; 00007FFB02206226 4C 0F B6 58 01       movzx       r11,byte ptr [rax+1]
        ; 00007FFB0220622B 4A 8B 44 D0 03       mov         rax,qword ptr [rax+r10*8+3]
        ; 00007FFB02206230 4E 8D 14 D8          lea         r10,[rax+r11*8]
        ; 00007FFB02206234 E9 47 03 00 00       jmp         ThePreStub (07FFB02206580h)
        ; 00007FFB02206239 0F 1F 80 00 00 00 00 nop         dword ptr [rax]
        ; 00007FFB02206240 83 F9 04             cmp         ecx,4
        ; 00007FFB02206243 74 12                je          setFPReturnNot8+2h (07FFB02206257h)
        ; 00007FFB02206245 83 F9 08             cmp         ecx,8
        ; 00007FFB02206248 75 0B                jne         setFPReturnNot8 (07FFB02206255h)
        ; 00007FFB0220624A 48 89 54 24 10       mov         qword ptr [rsp+10h],rdx
        ; 00007FFB0220624F F2 0F 10 44 24 10    movsd       xmm0,mmword ptr [rsp+10h]
        ; setFPReturnNot8:
        ; 00007FFB02206255 F3 C3                rep ret
        ; 00007FFB02206257 48 89 54 24 10       mov         qword ptr [rsp+10h],rdx
        ; 00007FFB0220625C F3 0F 10 44 24 10    movss       xmm0,dword ptr [rsp+10h]
        ; 00007FFB02206262 C3                   ret
        ; 00007FFB02206263 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
        ; 00007FFB02206270 83 F9 04             cmp         ecx,4
        ; 00007FFB02206273 74 0B                je          getFPReturnNot8+2h (07FFB02206280h)
        ; 00007FFB02206275 83 F9 08             cmp         ecx,8
        ; 00007FFB02206278 75 04                jne         getFPReturnNot8 (07FFB0220627Eh)
        ; 00007FFB0220627A F2 0F 11 02          movsd       mmword ptr [rdx],xmm0
        ; getFPReturnNot8:
        ; 00007FFB0220627E F3 C3                rep ret
        ; 00007FFB02206280 F3 0F 11 02          movss       dword ptr [rdx],xmm0
        ; 00007FFB02206284 C3                   ret
        ; 00007FFB02206285 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
        ; 00007FFB02206290 50                   push        rax
        ; 00007FFB02206291 41 57                push        r15
        ; 00007FFB02206293 41 56                push        r14
        ; 00007FFB02206295 41 55                push        r13
        ; 00007FFB02206297 41 54                push        r12
        ; 00007FFB02206299 55                   push        rbp
        ; 00007FFB0220629A 53                   push        rbx
        ; 00007FFB0220629B 56                   push        rsi
        ; 00007FFB0220629C 57                   push        rdi
        ; 00007FFB0220629D 50                   push        rax
        ; 00007FFB0220629E 48 8B CC             mov         rcx,rsp
        ; 00007FFB022062A1 48 83 EC 30          sub         rsp,30h
        ; 00007FFB022062A5 66 0F 7F 44 24 20    movdqa      xmmword ptr [rsp+20h],xmm0
        ; 00007FFB022062AB E8 90 68 0C 00       call        OnHijackWorker (07FFB022CCB40h)
        ; 00007FFB022062B0 66 0F 6F 44 24 20    movdqa      xmm0,xmmword ptr [rsp+20h]
        ; 00007FFB022062B6 48 83 C4 30          add         rsp,30h
        ; 00007FFB022062BA 58                   pop         rax
        ; 00007FFB022062BB 5F                   pop         rdi
        ; 00007FFB022062BC 5E                   pop         rsi
        ; 00007FFB022062BD 5B                   pop         rbx
        00007FFB022062BE 5D                   pop         rbp
        00007FFB022062BF 41 5C                pop         r12
        00007FFB022062C1 41 5D                pop         r13
        00007FFB022062C3 41 5E                pop         r14
        00007FFB022062C5 41 5F                pop         r15
        00007FFB022062C7 C3                   ret
        00007FFB022062C8 0F 1F 84 00 00 00 00 00 nop         dword ptr [rax+rax]
        00007FFB022062D0 F3 C3                rep ret
        00007FFB022062D2 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
        00007FFB022062E0 50                   push        rax
        00007FFB022062E1 48 8D 44 24 10       lea         rax,[rsp+10h]
        00007FFB022062E6 4C 8B 50 F8          mov         r10,qword ptr [rax-8]
        00007FFB022062EA 48 81 EC C0 00 00 00 sub         rsp,0C0h
        00007FFB022062F1 4D 33 C0             xor         r8,r8
        00007FFB022062F4 4C 89 44 24 20       mov         qword ptr [rsp+20h],r8
        00007FFB022062F9 48 89 6C 24 28       mov         qword ptr [rsp+28h],rbp
        00007FFB022062FE 48 89 44 24 30       mov         qword ptr [rsp+30h],rax
        00007FFB02206303 4C 89 54 24 38       mov         qword ptr [rsp+38h],r10
        00007FFB02206308 48 89 54 24 40       mov         qword ptr [rsp+40h],rdx
        00007FFB0220630D 4C 89 44 24 48       mov         qword ptr [rsp+48h],r8
        00007FFB02206312 4C 89 44 24 50       mov         qword ptr [rsp+50h],r8
        00007FFB02206317 F2 0F 11 44 24 58    movsd       mmword ptr [rsp+58h],xmm0
        00007FFB0220631D F2 0F 11 4C 24 60    movsd       mmword ptr [rsp+60h],xmm1
        00007FFB02206323 F2 0F 11 54 24 68    movsd       mmword ptr [rsp+68h],xmm2
        00007FFB02206329 F2 0F 11 5C 24 70    movsd       mmword ptr [rsp+70h],xmm3
        00007FFB0220632F 49 C7 C2 01 00 00 00 mov         r10,1
        00007FFB02206336 44 89 54 24 78       mov         dword ptr [rsp+78h],r10d
        00007FFB0220633B 66 0F 7F 84 24 80 00 00 00 movdqa      xmmword ptr [rsp+80h],xmm0
        00007FFB02206344 48 8D 54 24 20       lea         rdx,[rsp+20h]
        00007FFB02206349 E8 92 13 18 00       call        ProfileEnter (07FFB023876E0h)
        00007FFB0220634E 66 0F 6F 84 24 80 00 00 00 movdqa      xmm0,xmmword ptr [rsp+80h]
        00007FFB02206357 48 81 C4 C0 00 00 00 add         rsp,0C0h
        00007FFB0220635E 58                   pop         rax
        00007FFB0220635F C3                   ret
        00007FFB02206360 50                   push        rax
        00007FFB02206361 4C 8D 54 24 10       lea         r10,[rsp+10h]
        00007FFB02206366 4D 8B 5A F8          mov         r11,qword ptr [r10-8]
        00007FFB0220636A 48 81 EC C0 00 00 00 sub         rsp,0C0h
        00007FFB02206371 4D 33 C0             xor         r8,r8
        00007FFB02206374 4C 89 44 24 20       mov         qword ptr [rsp+20h],r8
        00007FFB02206379 48 89 6C 24 28       mov         qword ptr [rsp+28h],rbp
        00007FFB0220637E 4C 89 54 24 30       mov         qword ptr [rsp+30h],r10
        00007FFB02206383 4C 89 5C 24 38       mov         qword ptr [rsp+38h],r11
        00007FFB02206388 48 89 54 24 40       mov         qword ptr [rsp+40h],rdx
        00007FFB0220638D 48 89 44 24 48       mov         qword ptr [rsp+48h],rax
        00007FFB02206392 4C 89 44 24 50       mov         qword ptr [rsp+50h],r8
        00007FFB02206397 F2 0F 11 44 24 58    movsd       mmword ptr [rsp+58h],xmm0
        00007FFB0220639D F2 0F 11 4C 24 60    movsd       mmword ptr [rsp+60h],xmm1
        00007FFB022063A3 F2 0F 11 54 24 68    movsd       mmword ptr [rsp+68h],xmm2
        00007FFB022063A9 F2 0F 11 5C 24 70    movsd       mmword ptr [rsp+70h],xmm3
        00007FFB022063AF 49 C7 C2 02 00 00 00 mov         r10,2
        00007FFB022063B6 44 89 54 24 78       mov         dword ptr [rsp+78h],r10d
        00007FFB022063BB 66 0F 7F 84 24 80 00 00 00 movdqa      xmmword ptr [rsp+80h],xmm0
        00007FFB022063C4 48 8D 54 24 20       lea         rdx,[rsp+20h]
        00007FFB022063C9 E8 52 17 18 00       call        ProfileLeave (07FFB02387B20h)
        00007FFB022063CE 66 0F 6F 84 24 80 00 00 00 movdqa      xmm0,xmmword ptr [rsp+80h]
        00007FFB022063D7 48 81 C4 C0 00 00 00 add         rsp,0C0h
        00007FFB022063DE 58                   pop         rax
        00007FFB022063DF C3                   ret
        00007FFB022063E0 50                   push        rax
        00007FFB022063E1 48 8D 44 24 10       lea         rax,[rsp+10h]
        00007FFB022063E6 4C 8B 58 F8          mov         r11,qword ptr [rax-8]
        00007FFB022063EA 48 81 EC C0 00 00 00 sub         rsp,0C0h
        00007FFB022063F1 4D 33 C0             xor         r8,r8
        00007FFB022063F4 4C 89 44 24 20       mov         qword ptr [rsp+20h],r8
        00007FFB022063F9 48 89 6C 24 28       mov         qword ptr [rsp+28h],rbp
        00007FFB022063FE 48 89 44 24 30       mov         qword ptr [rsp+30h],rax
        00007FFB02206403 4C 89 5C 24 38       mov         qword ptr [rsp+38h],r11
        00007FFB02206408 48 89 54 24 40       mov         qword ptr [rsp+40h],rdx
        00007FFB0220640D 4C 89 44 24 48       mov         qword ptr [rsp+48h],r8
        00007FFB02206412 4C 89 44 24 50       mov         qword ptr [rsp+50h],r8
        00007FFB02206417 4C 89 44 24 58       mov         qword ptr [rsp+58h],r8
        00007FFB0220641C 4C 89 44 24 60       mov         qword ptr [rsp+60h],r8
        00007FFB02206421 4C 89 44 24 68       mov         qword ptr [rsp+68h],r8
        00007FFB02206426 4C 89 44 24 70       mov         qword ptr [rsp+70h],r8
        00007FFB0220642B 49 C7 C2 04 00 00 00 mov         r10,4
        00007FFB02206432 44 89 54 24 78       mov         dword ptr [rsp+78h],r10d
        00007FFB02206437 66 0F 7F 84 24 80 00 00 00 movdqa      xmmword ptr [rsp+80h],xmm0
        00007FFB02206440 48 8D 54 24 20       lea         rdx,[rsp+20h]
        00007FFB02206445 E8 C6 19 18 00       call        ProfileTailcall (07FFB02387E10h)
        00007FFB0220644A 66 0F 6F 84 24 80 00 00 00 movdqa      xmm0,xmmword ptr [rsp+80h]
        00007FFB02206453 48 81 C4 C0 00 00 00 add         rsp,0C0h
        00007FFB0220645A 58                   pop         rax
        00007FFB0220645B C3                   ret
        00007FFB0220645C 0F 1F 40 00          nop         dword ptr [rax]
        00007FFB02206460 53                   push        rbx
        00007FFB02206461 56                   push        rsi
        00007FFB02206462 8B C1                mov         eax,ecx
        00007FFB02206464 48 8B F2             mov         rsi,rdx
        00007FFB02206467 33 C9                xor         ecx,ecx
        00007FFB02206469 0F A2                cpuid
        00007FFB0220646B 89 06                mov         dword ptr [rsi],eax
        00007FFB0220646D 89 5E 04             mov         dword ptr [rsi+4],ebx
        00007FFB02206470 89 4E 08             mov         dword ptr [rsi+8],ecx
        00007FFB02206473 89 56 0C             mov         dword ptr [rsi+0Ch],edx
        00007FFB02206476 5E                   pop         rsi
        00007FFB02206477 5B                   pop         rbx
        00007FFB02206478 C3                   ret
        00007FFB02206479 0F 1F 80 00 00 00 00 nop         dword ptr [rax]
        00007FFB02206480 B9 00 00 00 00       mov         ecx,0
        00007FFB02206485 0F 01 D0             xgetbv
        00007FFB02206488 83 E0 06             and         eax,6
        00007FFB0220648B 83 F8 06             cmp         eax,6
        00007FFB0220648E 75 07                jne         not_supported (07FFB02206497h)
        00007FFB02206490 B8 01 00 00 00       mov         eax,1
        00007FFB02206495 EB 05                jmp         not_supported+5h (07FFB0220649Ch)
        00007FFB02206497 B8 00 00 00 00       mov         eax,0
        00007FFB0220649C C3                   ret
        00007FFB0220649D 0F 1F 00             nop         dword ptr [rax]
        00007FFB022064A0 53                   push        rbx
        00007FFB022064A1 56                   push        rsi
        00007FFB022064A2 8B C2                mov         eax,edx
        00007FFB022064A4 49 8B F0             mov         rsi,r8
        00007FFB022064A7 0F A2                cpuid
        00007FFB022064A9 89 06                mov         dword ptr [rsi],eax
        00007FFB022064AB 89 5E 04             mov         dword ptr [rsi+4],ebx
        00007FFB022064AE 89 4E 08             mov         dword ptr [rsi+8],ecx
        00007FFB022064B1 89 56 0C             mov         dword ptr [rsi+0Ch],edx
        00007FFB022064B4 5E                   pop         rsi
        00007FFB022064B5 5B                   pop         rbx
        00007FFB022064B6 C3                   ret
        00007FFB022064B7 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
        00007FFB022064C0 66 0F 6F 01          movdqa      xmm0,xmmword ptr [rcx]
        00007FFB022064C4 66 0F 7F 02          movdqa      xmmword ptr [rdx],xmm0
        00007FFB022064C8 C3                   ret
        00007FFB022064C9 0F 1F 80 00 00 00 00 nop         dword ptr [rax]
        00007FFB022064D0 48 85 C9             test        rcx,rcx
        00007FFB022064D3 74 0A                je          NullObject (07FFB022064DFh)
        00007FFB022064D5 48 8B 41 18          mov         rax,qword ptr [rcx+18h]
        00007FFB022064D9 48 8B 49 08          mov         rcx,qword ptr [rcx+8]
        00007FFB022064DD FF E0                jmp         rax
        00007FFB022064DF 48 C7 C1 00 00 00 00 mov         rcx,0
        00007FFB022064E6 E9 85 B2 12 00       jmp         JIT_InternalThrow (07FFB02331770h)

        --- d:\workspace\_work\1\s\src\vm\prestub.cpp ----------------------------------
        00007FFB02126210 40 53                push        rbx
        00007FFB02126212 56                   push        rsi
        00007FFB02126213 57                   push        rdi
        00007FFB02126214 41 54                push        r12
        00007FFB02126216 41 55                push        r13
        00007FFB02126218 41 56                push        r14
        00007FFB0212621A 41 57                push        r15
        00007FFB0212621C 48 81 EC E0 01 00 00 sub         rsp,1E0h
        00007FFB02126223 48 C7 84 24 B0 00 00 00 FE FF FF FF mov         qword ptr [rsp+0B0h],0FFFFFFFFFFFFFFFEh
        00007FFB0212622F 48 8B F2             mov         rsi,rdx
        00007FFB02126232 48 8B F9             mov         rdi,rcx
        00007FFB02126235 FF 15 F5 E3 37 00    call        qword ptr [__imp_GetLastError (07FFB024A4630h)]
        00007FFB0212623B 44 8B F8             mov         r15d,eax
        00007FFB0212623E 44 8B 0D 33 8F 4B 00 mov         r9d,dword ptr [_tls_index (07FFB025DF178h)]
        00007FFB02126245 65 4C 8B 04 25 58 00 00 00 mov         r8,qword ptr gs:[58h]
        00007FFB0212624E B8 08 00 00 00       mov         eax,8
        00007FFB02126253 4F 8B 24 C8          mov         r12,qword ptr [r8+r9*8]
        00007FFB02126257 4C 03 E0             add         r12,rax
        00007FFB0212625A 49 8B 1C 24          mov         rbx,qword ptr [r12]
        00007FFB0212625E 4C 8B 05 13 DC 3C 00 mov         r8,qword ptr [s_gsCookie (07FFB024F3E78h)]
        00007FFB02126265 4C 89 44 24 58       mov         qword ptr [frame],r8
        00007FFB0212626A 45 33 ED             xor         r13d,r13d
        00007FFB0212626D 4C 89 6C 24 68       mov         qword ptr [rsp+68h],r13
        00007FFB02126272 48 89 7C 24 70       mov         qword ptr [rsp+70h],rdi
        00007FFB02126277 48 89 74 24 78       mov         qword ptr [rsp+78h],rsi
        00007FFB0212627C 48 8D 05 7D 04 3E 00 lea         rax,[PrestubMethodFrame::`vftable' (07FFB02506700h)]
        00007FFB02126283 48 89 44 24 60       mov         qword ptr [rsp+60h],rax
        00007FFB02126288 48 8B 43 10          mov         rax,qword ptr [rbx+10h]
        00007FFB0212628C 48 89 44 24 68       mov         qword ptr [rsp+68h],rax
        00007FFB02126291 48 8D 44 24 60       lea         rax,[rsp+60h]
        00007FFB02126296 48 89 43 10          mov         qword ptr [rbx+10h],rax
        00007FFB0212629A 48 8D 44 24 60       lea         rax,[rsp+60h]
        00007FFB0212629F 48 89 84 24 98 00 00 00 mov         qword ptr [__pUnCEntryFrame],rax
        00007FFB021262A7 48 8B 05 D2 73 4B 00 mov         rax,qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_Context (07FFB025DD680h)]
        00007FFB021262AE 48 89 84 24 B8 00 00 00 mov         qword ptr [rsp+0B8h],rax
        00007FFB021262B6 48 89 84 24 38 01 00 00 mov         qword ptr [tracePrestubWorker_V1],rax
        00007FFB021262BE 4C 8D 15 6B 55 38 00 lea         r10,[PrestubWorker_V1 (07FFB024AB830h)]
        00007FFB021262C5 4C 89 94 24 40 01 00 00 mov         qword ptr [rsp+140h],r10
        00007FFB021262CD 48 8D 3D 6C 55 38 00 lea         rdi,[PrestubWorkerEnd_V1 (07FFB024AB840h)]
        00007FFB021262D4 48 89 BC 24 50 01 00 00 mov         qword ptr [rsp+150h],rdi
        00007FFB021262DC 48 8D 05 6D 55 38 00 lea         rax,[StartupId (07FFB024AB850h)]
        00007FFB021262E3 48 89 84 24 48 01 00 00 mov         qword ptr [rsp+148h],rax
        00007FFB021262EB 48 89 84 24 58 01 00 00 mov         qword ptr [rsp+158h],rax
        00007FFB021262F3 0F 10 05 36 55 38 00 movups      xmm0,xmmword ptr [PrestubWorker_V1 (07FFB024AB830h)]
        00007FFB021262FA 0F 11 44 24 28       movups      xmmword ptr [rsp+28h],xmm0
        00007FFB021262FF 48 8B 0D F2 74 4B 00 mov         rcx,qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context (07FFB025DD7F8h)]
        00007FFB02126306 44 39 69 24          cmp         dword ptr [rcx+24h],r13d
        00007FFB0212630A 0F 85 CE 56 13 00    jne         WinMDInternalImportRO::Release+3E9BEh (07FFB0225B9DEh)
        00007FFB02126310 4C 8B 44 24 30       mov         r8,qword ptr [rsp+30h]
        00007FFB02126315 0F 10 0D EC 74 4B 00 movups      xmm1,xmmword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context+10h (07FFB025DD808h)]
        00007FFB0212631C 0F 10 05 D5 74 4B 00 movups      xmm0,xmmword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context (07FFB025DD7F8h)]
        00007FFB02126323 0F 29 84 24 A0 01 00 00 movaps      xmmword ptr [rsp+1A0h],xmm0
        00007FFB0212632B 0F 29 8C 24 B0 01 00 00 movaps      xmmword ptr [rsp+1B0h],xmm1
        00007FFB02126333 66 0F 7E C8          movd        eax,xmm1
        00007FFB02126337 38 44 24 2C          cmp         byte ptr [rsp+2Ch],al
        00007FFB0212633B 76 04                jbe         PreStubWorker+131h (07FFB02126341h)
        00007FFB0212633D 84 C0                test        al,al
        00007FFB0212633F 75 16                jne         PreStubWorker+147h (07FFB02126357h)
        00007FFB02126341 4D 85 C0             test        r8,r8
        00007FFB02126344 0F 84 55 02 00 00    je          PreStubWorker+38Fh (07FFB0212659Fh)
        00007FFB0212634A 4C 85 05 BF 74 4B 00 test        qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context+18h (07FFB025DD810h)],r8
        00007FFB02126351 0F 85 48 02 00 00    jne         PreStubWorker+38Fh (07FFB0212659Fh)
        00007FFB02126357 0F B6 46 02          movzx       eax,byte ptr [rsi+2]
        00007FFB0212635B 48 8D 04 C5 18 00 00 00 lea         rax,[rax*8+18h]
        00007FFB02126363 48 8B CE             mov         rcx,rsi
        00007FFB02126366 48 2B C8             sub         rcx,rax
        00007FFB02126369 48 89 8C 24 C0 00 00 00 mov         qword ptr [rsp+0C0h],rcx
        00007FFB02126371 4C 8B 01             mov         r8,qword ptr [rcx]
        00007FFB02126374 4C 89 84 24 C8 00 00 00 mov         qword ptr [rsp+0C8h],r8
        00007FFB0212637C 41 F6 40 08 40       test        byte ptr [r8+8],40h
        00007FFB02126381 75 15                jne         PreStubWorker+188h (07FFB02126398h)
        00007FFB02126383 49 8B 40 20          mov         rax,qword ptr [r8+20h]
        00007FFB02126387 48 89 84 24 D0 00 00 00 mov         qword ptr [rsp+0D0h],rax
        00007FFB0212638F F6 00 40             test        byte ptr [rax],40h
        00007FFB02126392 0F 85 E9 56 13 00    jne         WinMDInternalImportRO::Release+3EA61h (07FFB0225BA81h)
        00007FFB02126398 4C 89 6C 24 20       mov         qword ptr [pDispatchingMT],r13
        00007FFB0212639D 0F B6 46 02          movzx       eax,byte ptr [rsi+2]
        00007FFB021263A1 48 8D 04 C5 18 00 00 00 lea         rax,[rax*8+18h]
        00007FFB021263A9 48 8B CE             mov         rcx,rsi
        00007FFB021263AC 48 2B C8             sub         rcx,rax
        00007FFB021263AF 48 89 8C 24 F0 00 00 00 mov         qword ptr [rsp+0F0h],rcx
        00007FFB021263B7 48 8B 11             mov         rdx,qword ptr [rcx]
        00007FFB021263BA 48 89 94 24 F8 00 00 00 mov         qword ptr [rsp+0F8h],rdx
        00007FFB021263C2 0F B7 4E 06          movzx       ecx,word ptr [rsi+6]
        00007FFB021263C6 0F B6 C1             movzx       eax,cl
        00007FFB021263C9 24 07                and         al,7
        00007FFB021263CB 3C 05                cmp         al,5
        00007FFB021263CD 0F 84 B9 01 00 00    je          PreStubWorker+37Ch (07FFB0212658Ch)
        00007FFB021263D3 8B 02                mov         eax,dword ptr [rdx]
        00007FFB021263D5 25 00 00 0C 00       and         eax,0C0000h
        00007FFB021263DA 3D 00 00 04 00       cmp         eax,40000h
        00007FFB021263DF 0F 84 8F 01 00 00    je          PreStubWorker+364h (07FFB02126574h)
        00007FFB021263E5 66 85 C9             test        cx,cx
        00007FFB021263E8 0F B7 4E 04          movzx       ecx,word ptr [rsi+4]
        00007FFB021263EC 78 08                js          PreStubWorker+1E6h (07FFB021263F6h)
        00007FFB021263EE B8 FF 03 00 00       mov         eax,3FFh
        00007FFB021263F3 66 23 C8             and         cx,ax
        00007FFB021263F6 66 89 8C 24 20 02 00 00 mov         word ptr [rsp+220h],cx
        00007FFB021263FE 0F B7 42 0C          movzx       eax,word ptr [rdx+0Ch]
        00007FFB02126402 66 89 84 24 28 02 00 00 mov         word ptr [rsp+228h],ax
        00007FFB0212640A 66 3B C8             cmp         cx,ax
        00007FFB0212640D 0F 82 19 01 00 00    jb          PreStubWorker+31Ch (07FFB0212652Ch)
        00007FFB02126413 48 89 9C 24 A0 00 00 00 mov         qword ptr [__gcHolder],rbx
        00007FFB0212641B 8B 43 0C             mov         eax,dword ptr [rbx+0Ch]
        00007FFB0212641E 89 84 24 A8 00 00 00 mov         dword ptr [rsp+0A8h],eax
        00007FFB02126425 85 C0                test        eax,eax
        00007FFB02126427 74 26                je          PreStubWorker+23Fh (07FFB0212644Fh)
        00007FFB02126429 44 89 6B 0C          mov         dword ptr [rbx+0Ch],r13d
        00007FFB0212642D 48 8D 43 08          lea         rax,[rbx+8]
        00007FFB02126431 48 89 84 24 18 01 00 00 mov         qword ptr [rsp+118h],rax
        00007FFB02126439 8B 00                mov         eax,dword ptr [rax]
        00007FFB0212643B 89 84 24 38 02 00 00 mov         dword ptr [rsp+238h],eax
        00007FFB02126442 A8 1F                test        al,1Fh
        00007FFB02126444 74 09                je          PreStubWorker+23Fh (07FFB0212644Fh)
        00007FFB02126446 48 8B CB             mov         rcx,rbx
        00007FFB02126449 E8 1E E7 FD FF       call        Thread::RareEnablePreemptiveGC (07FFB02104B6Ch)
        00007FFB0212644E 90                   nop
        00007FFB0212644F 48 8B 54 24 20       mov         rdx,qword ptr [pDispatchingMT]
        00007FFB02126454 48 8B CE             mov         rcx,rsi
        00007FFB02126457 E8 84 01 00 00       call        MethodDesc::DoPrestub (07FFB021265E0h)
        00007FFB0212645C 48 89 84 24 90 00 00 00 mov         qword ptr [pbRetVal],rax
        00007FFB02126464 83 BC 24 A8 00 00 00 00 cmp         dword ptr [rsp+0A8h],0
        00007FFB0212646C 8B 43 0C             mov         eax,dword ptr [rbx+0Ch]
        00007FFB0212646F 0F 84 7A 57 13 00    je          WinMDInternalImportRO::Release+3EBCFh (07FFB0225BBEFh)
        00007FFB02126475 85 C0                test        eax,eax
        00007FFB02126477 75 1A                jne         PreStubWorker+283h (07FFB02126493h)
        00007FFB02126479 C7 43 0C 01 00 00 00 mov         dword ptr [rbx+0Ch],1
        00007FFB02126480 8B 05 52 17 4C 00    mov         eax,dword ptr [g_TrapReturningThreads (07FFB025E7BD8h)]
        00007FFB02126486 85 C0                test        eax,eax
        00007FFB02126488 74 09                je          PreStubWorker+283h (07FFB02126493h)
        00007FFB0212648A 48 8B CB             mov         rcx,rbx
        00007FFB0212648D E8 62 00 FE FF       call        Thread::RareDisablePreemptiveGC (07FFB021064F4h)
        00007FFB02126492 90                   nop
        00007FFB02126493 0F 10 05 A6 53 38 00 movups      xmm0,xmmword ptr [PrestubWorkerEnd_V1 (07FFB024AB840h)]
        00007FFB0212649A 0F 11 44 24 40       movups      xmmword ptr [rsp+40h],xmm0
        00007FFB0212649F 48 8B 0D 52 73 4B 00 mov         rcx,qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context (07FFB025DD7F8h)]
        00007FFB021264A6 83 79 24 00          cmp         dword ptr [rcx+24h],0
        00007FFB021264AA 0F 85 68 57 13 00    jne         WinMDInternalImportRO::Release+3EBF8h (07FFB0225BC18h)
        00007FFB021264B0 0F 10 05 51 73 4B 00 movups      xmm0,xmmword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context+10h (07FFB025DD808h)]
        00007FFB021264B7 0F 10 0D 3A 73 4B 00 movups      xmm1,xmmword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context (07FFB025DD7F8h)]
        00007FFB021264BE 4C 8B 44 24 48       mov         r8,qword ptr [rsp+48h]
        00007FFB021264C3 0F B6 54 24 44       movzx       edx,byte ptr [rsp+44h]
        00007FFB021264C8 0F 29 8C 24 C0 01 00 00 movaps      xmmword ptr [rsp+1C0h],xmm1
        00007FFB021264D0 0F 29 84 24 D0 01 00 00 movaps      xmmword ptr [rsp+1D0h],xmm0
        00007FFB021264D8 66 0F 7E C0          movd        eax,xmm0
        00007FFB021264DC 3A D0                cmp         dl,al
        00007FFB021264DE 76 04                jbe         PreStubWorker+2D4h (07FFB021264E4h)
        00007FFB021264E0 84 C0                test        al,al
        00007FFB021264E2 75 16                jne         PreStubWorker+2EAh (07FFB021264FAh)
        00007FFB021264E4 4D 85 C0             test        r8,r8
        00007FFB021264E7 0F 84 CE 00 00 00    je          PreStubWorker+3ABh (07FFB021265BBh)
        00007FFB021264ED 4C 85 05 1C 73 4B 00 test        qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_DOTNET_Context+18h (07FFB025DD810h)],r8
        00007FFB021264F4 0F 85 C1 00 00 00    jne         PreStubWorker+3ABh (07FFB021265BBh)
        00007FFB021264FA E8 21 01 0E 00       call        ThePreStubPatch (07FFB02206620h)
        00007FFB021264FF 48 8B 44 24 68       mov         rax,qword ptr [rsp+68h]
        00007FFB02126504 48 89 43 10          mov         qword ptr [rbx+10h],rax
        00007FFB02126508 41 8B CF             mov         ecx,r15d
        00007FFB0212650B FF 15 FF E0 37 00    call        qword ptr [__imp_SetLastError (07FFB024A4610h)]
        00007FFB02126511 48 8B 84 24 90 00 00 00 mov         rax,qword ptr [pbRetVal]
        00007FFB02126519 48 81 C4 E0 01 00 00 add         rsp,1E0h
        00007FFB02126520 41 5F                pop         r15
        00007FFB02126522 41 5E                pop         r14
        00007FFB02126524 41 5D                pop         r13
        00007FFB02126526 41 5C                pop         r12
        00007FFB02126528 5F                   pop         rdi
        00007FFB02126529 5E                   pop         rsi
        00007FFB0212652A 5B                   pop         rbx
        00007FFB0212652B C3                   ret
        00007FFB0212652C 48 8B 44 24 60       mov         rax,qword ptr [rsp+60h]
        00007FFB02126531 48 8D 4C 24 60       lea         rcx,[rsp+60h]
        00007FFB02126536 48 8B 80 90 00 00 00 mov         rax,qword ptr [rax+90h]
        00007FFB0212653D FF 15 4D E7 37 00    call        qword ptr [__guard_dispatch_icall_fptr (07FFB024A4C90h)]
        00007FFB02126543 48 8B 78 48          mov         rdi,qword ptr [rax+48h]
        00007FFB02126547 48 89 BC 24 00 01 00 00 mov         qword ptr [rsp+100h],rdi
        00007FFB0212654F 48 85 FF             test        rdi,rdi
        00007FFB02126552 74 14                je          PreStubWorker+358h (07FFB02126568h)
        00007FFB02126554 48 8B 3F             mov         rdi,qword ptr [rdi]
        00007FFB02126557 48 89 7C 24 20       mov         qword ptr [pDispatchingMT],rdi
        00007FFB0212655C F7 07 00 00 40 00    test        dword ptr [rdi],400000h
        00007FFB02126562 0F 85 DE 55 13 00    jne         WinMDInternalImportRO::Release+3EB26h (07FFB0225BB46h)
        00007FFB02126568 48 8D 3D D1 52 38 00 lea         rdi,[PrestubWorkerEnd_V1 (07FFB024AB840h)]
        00007FFB0212656F E9 9F FE FF FF       jmp         PreStubWorker+203h (07FFB02126413h)
        00007FFB02126574 F6 C1 20             test        cl,20h
        00007FFB02126577 0F 85 68 FE FF FF    jne         PreStubWorker+1D5h (07FFB021263E5h)
        00007FFB0212657D F6 46 03 04          test        byte ptr [rsi+3],4
        00007FFB02126581 0F 84 8C FE FF FF    je          PreStubWorker+203h (07FFB02126413h)
        00007FFB02126587 E9 59 FE FF FF       jmp         PreStubWorker+1D5h (07FFB021263E5h)
        00007FFB0212658C 0F B6 46 18          movzx       eax,byte ptr [rsi+18h]
        00007FFB02126590 24 07                and         al,7
        00007FFB02126592 3C 07                cmp         al,7
        00007FFB02126594 0F 85 39 FE FF FF    jne         PreStubWorker+1C3h (07FFB021263D3h)
        00007FFB0212659A E9 74 FE FF FF       jmp         PreStubWorker+203h (07FFB02126413h)
        00007FFB0212659F 44 0F B7 0D E1 8E 4B 00 movzx       r9d,word ptr [g_nClrInstanceId (07FFB025DF488h)]
        00007FFB021265A7 49 8B D2             mov         rdx,r10
        00007FFB021265AA 48 8B 0D CF 70 4B 00 mov         rcx,qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_Context (07FFB025DD680h)]
        00007FFB021265B1 E8 1A 63 19 00       call        CoMofTemplate_h (07FFB022BC8D0h)
        00007FFB021265B6 E9 9C FD FF FF       jmp         PreStubWorker+147h (07FFB02126357h)
        00007FFB021265BB 44 0F B7 0D C5 8E 4B 00 movzx       r9d,word ptr [g_nClrInstanceId (07FFB025DF488h)]
        00007FFB021265C3 48 8B D7             mov         rdx,rdi
        00007FFB021265C6 48 8B 0D B3 70 4B 00 mov         rcx,qword ptr [MICROSOFT_WINDOWS_DOTNETRUNTIME_PRIVATE_PROVIDER_Context (07FFB025DD680h)]
        00007FFB021265CD E8 FE 62 19 00       call        CoMofTemplate_h (07FFB022BC8D0h)
        00007FFB021265D2 E9 23 FF FF FF       jmp         PreStubWorker+2EAh (07FFB021264FAh)
        00007FFB021265D7 CC                   int         3

        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress call(N1 n)::located://asmcases/prototypes.calls?call#call_(n1)
        ; public static ReadOnlySpan<byte> call_ᐤn1ᐤ => new byte[24]{0x48,0x89,0x4c,0x24,0x08,0x48,0x0f,0xbe,0x4c,0x24,0x08,0x48,0xb8,0x98,0xdc,0xbf,0xa4,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0};
        ; BaseAddress = 7ffaa6f94350h
        ; TermCode = CTC_JMP_RAX
        0000h mov [rsp+8],rcx                               ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 4c 24 08
        0005h movsx rcx,byte ptr [rsp+8]                    ; MOVSX r64, r/m8                  | REX.W 0F BE /r                   | 6   | 48 0f be 4c 24 08
        000bh mov rax,7ffaa4bfdc98h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b8 98 dc bf a4 fa 7f 00 00
        0015h jmp rax                                       ; JMP r/m64                        | FF /4                            | 3   | 48 ff e0
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress call(N2 n)::located://asmcases/prototypes.calls?call#call_(n2)
        ; public static ReadOnlySpan<byte> call_ᐤn2ᐤ => new byte[24]{0x48,0x89,0x4c,0x24,0x08,0x48,0x0f,0xbe,0x4c,0x24,0x08,0x48,0xb8,0xa0,0xdc,0xbf,0xa4,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0};
        ; BaseAddress = 7ffaa6f94380h
        ; TermCode = CTC_JMP_RAX
        0000h mov [rsp+8],rcx                               ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 4c 24 08
        0005h movsx rcx,byte ptr [rsp+8]                    ; MOVSX r64, r/m8                  | REX.W 0F BE /r                   | 6   | 48 0f be 4c 24 08
        000bh mov rax,7ffaa4bfdca0h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b8 a0 dc bf a4 fa 7f 00 00
        0015h jmp rax                                       ; JMP r/m64                        | FF /4                            | 3   | 48 ff e0
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress call(N3 n)::located://asmcases/prototypes.calls?call#call_(n3)
        ; public static ReadOnlySpan<byte> call_ᐤn3ᐤ => new byte[24]{0x48,0x89,0x4c,0x24,0x08,0x48,0x0f,0xbe,0x4c,0x24,0x08,0x48,0xb8,0xa8,0xdc,0xbf,0xa4,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0};
        ; BaseAddress = 7ffaa6f943b0h
        ; TermCode = CTC_JMP_RAX
        0000h mov [rsp+8],rcx                               ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 4c 24 08
        0005h movsx rcx,byte ptr [rsp+8]                    ; MOVSX r64, r/m8                  | REX.W 0F BE /r                   | 6   | 48 0f be 4c 24 08
        000bh mov rax,7ffaa4bfdca8h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b8 a8 dc bf a4 fa 7f 00 00
        0015h jmp rax                                       ; JMP r/m64                        | FF /4                            | 3   | 48 ff e0
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress target(N0 n)::located://asmcases/prototypes.calls?target#target_(n0)
        ; public static ReadOnlySpan<byte> target_ᐤn0ᐤ => new byte[49]{0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0xe8,0x98,0x3b,0x78,0xfb,0x48,0x8b,0xc8,0x48,0x8b,0x00,0x48,0x8b,0x40,0x60,0xff,0x10,0x48,0x89,0x44,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0xd5,0x3f,0x78,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};
        ; BaseAddress = 7ffaa6f943e0h
        ; TermCode = CTC_RET_Zx3
        0000h sub rsp,28h                                   ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
        0004h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
        0006h mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        000bh call 7ffaa2717f88h                            ; CALL rel32                       | E8 cd                            | 5   | e8 98 3b 78 fb
        0010h mov rcx,rax                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c8
        0013h mov rax,[rax]                                 ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 00
        0016h mov rax,[rax+60h]                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 4   | 48 8b 40 60
        001ah call qword ptr [rax]                          ; CALL r/m64                       | FF /2                            | 2   | ff 10
        001ch mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        0021h lea rcx,[rsp+20h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 4c 24 20
        0026h call 7ffaa27183e0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 d5 3f 78 fb
        002bh nop                                           ; NOP                              | 90                               | 1   | 90
        002ch add rsp,28h                                   ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
        0030h ret                                           ; RET                              | C3                               | 1   | c3
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress target(N1 n)::located://asmcases/prototypes.calls?target#target_(n1)
        ; public static ReadOnlySpan<byte> target_ᐤn1ᐤ => new byte[49]{0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0xe8,0x48,0x3b,0x78,0xfb,0x48,0x8b,0xc8,0x48,0x8b,0x00,0x48,0x8b,0x40,0x60,0xff,0x10,0x48,0x89,0x44,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x85,0x3f,0x78,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};
        ; BaseAddress = 7ffaa6f94430h
        ; TermCode = CTC_RET_Zx3
        0000h sub rsp,28h                                   ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
        0004h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
        0006h mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        000bh call 7ffaa2717f88h                            ; CALL rel32                       | E8 cd                            | 5   | e8 48 3b 78 fb
        0010h mov rcx,rax                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c8
        0013h mov rax,[rax]                                 ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 00
        0016h mov rax,[rax+60h]                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 4   | 48 8b 40 60
        001ah call qword ptr [rax]                          ; CALL r/m64                       | FF /2                            | 2   | ff 10
        001ch mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        0021h lea rcx,[rsp+20h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 4c 24 20
        0026h call 7ffaa27183e0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 85 3f 78 fb
        002bh nop                                           ; NOP                              | 90                               | 1   | 90
        002ch add rsp,28h                                   ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
        0030h ret                                           ; RET                              | C3                               | 1   | c3
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress target(N2 n)::located://asmcases/prototypes.calls?target#target_(n2)
        ; public static ReadOnlySpan<byte> target_ᐤn2ᐤ => new byte[49]{0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0xe8,0xf8,0x3a,0x78,0xfb,0x48,0x8b,0xc8,0x48,0x8b,0x00,0x48,0x8b,0x40,0x60,0xff,0x10,0x48,0x89,0x44,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0x35,0x3f,0x78,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};
        ; BaseAddress = 7ffaa6f94480h
        ; TermCode = CTC_RET_Zx3
        0000h sub rsp,28h                                   ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
        0004h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
        0006h mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        000bh call 7ffaa2717f88h                            ; CALL rel32                       | E8 cd                            | 5   | e8 f8 3a 78 fb
        0010h mov rcx,rax                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c8
        0013h mov rax,[rax]                                 ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 00
        0016h mov rax,[rax+60h]                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 4   | 48 8b 40 60
        001ah call qword ptr [rax]                          ; CALL r/m64                       | FF /2                            | 2   | ff 10
        001ch mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        0021h lea rcx,[rsp+20h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 4c 24 20
        0026h call 7ffaa27183e0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 35 3f 78 fb
        002bh nop                                           ; NOP                              | 90                               | 1   | 90
        002ch add rsp,28h                                   ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
        0030h ret                                           ; RET                              | C3                               | 1   | c3
        ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        ; MemoryAddress target(N3 n)::located://asmcases/prototypes.calls?target#target_(n3)
        ; public static ReadOnlySpan<byte> target_ᐤn3ᐤ => new byte[49]{0x48,0x83,0xec,0x28,0x33,0xc0,0x48,0x89,0x44,0x24,0x20,0xe8,0xa8,0x3a,0x78,0xfb,0x48,0x8b,0xc8,0x48,0x8b,0x00,0x48,0x8b,0x40,0x60,0xff,0x10,0x48,0x89,0x44,0x24,0x20,0x48,0x8d,0x4c,0x24,0x20,0xe8,0xe5,0x3e,0x78,0xfb,0x90,0x48,0x83,0xc4,0x28,0xc3};
        ; BaseAddress = 7ffaa6f944d0h
        ; TermCode = CTC_RET_Zx3
        0000h sub rsp,28h                                   ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
        0004h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
        0006h mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        000bh call 7ffaa2717f88h                            ; CALL rel32                       | E8 cd                            | 5   | e8 a8 3a 78 fb
        0010h mov rcx,rax                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c8
        0013h mov rax,[rax]                                 ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 00
        0016h mov rax,[rax+60h]                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 4   | 48 8b 40 60
        001ah call qword ptr [rax]                          ; CALL r/m64                       | FF /2                            | 2   | ff 10
        001ch mov [rsp+20h],rax                             ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
        0021h lea rcx,[rsp+20h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 4c 24 20
        0026h call 7ffaa27183e0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 e5 3e 78 fb
        002bh nop                                           ; NOP                              | 90                               | 1   | 90
        002ch add rsp,28h                                   ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
        0030h ret                                           ; RET                              | C3                               | 1   | c3

    */
}