--- D:\workspace\_work\1\s\src\vm\amd64\JitHelpers_Fast.asm --------------------
00007FFB0220685D 32 48 8B             xor         cl,byte ptr [rax-75h]
00007FFB02206860 52                   push        rdx
00007FFB02206861 10 48 3B             adc         byte ptr [rax+3Bh],cl
00007FFB02206864 CA 74 39             retf        3974h
00007FFB02206867 48 85 D2             test        rdx,rdx
00007FFB0220686A 74 24                je          CheckParent+40h (07FFB02206890h)
00007FFB0220686C 48 8B 52 10          mov         rdx,qword ptr [rdx+10h]
00007FFB02206870 48 3B CA             cmp         rcx,rdx
00007FFB02206873 74 2B                je          CheckParent+50h (07FFB022068A0h)
00007FFB02206875 48 85 D2             test        rdx,rdx
00007FFB02206878 74 16                je          CheckParent+40h (07FFB02206890h)
00007FFB0220687A 48 8B 52 10          mov         rdx,qword ptr [rdx+10h]
00007FFB0220687E 48 3B CA             cmp         rcx,rdx
00007FFB02206881 74 1D                je          CheckParent+50h (07FFB022068A0h)
00007FFB02206883 48 85 D2             test        rdx,rdx
00007FFB02206886 75 C8                jne         CheckParent (07FFB02206850h)
00007FFB02206888 0F 1F 84 00 00 00 00 00 nop         dword ptr [rax+rax]
00007FFB02206890 48 8B D0             mov         rdx,rax
00007FFB02206893 E9 28 3E F1 FF       jmp         JITutil_ChkCastAny (07FFB0211A6C0h)
00007FFB02206898 0F 1F 84 00 00 00 00 00 nop         dword ptr [rax+rax]
IsInst:
00007FFB022068A0 F3 C3                rep ret
00007FFB022068A2 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB022068B0 48 85 D2             test        rdx,rdx
00007FFB022068B3 74 6B                je          Top+50h (07FFB02206920h)
00007FFB022068B5 48 8B 02             mov         rax,qword ptr [rdx]
00007FFB022068B8 66 44 8B 58 0E       mov         r11w,word ptr [rax+0Eh]
00007FFB022068BD 66 45 85 DB          test        r11w,r11w
00007FFB022068C1 74 42                je          Top+35h (07FFB02206905h)
00007FFB022068C3 48 8B 40 38          mov         rax,qword ptr [rax+38h]
00007FFB022068C7 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB022068D0 48 3B 08             cmp         rcx,qword ptr [rax]
00007FFB022068D3 74 4B                je          Top+50h (07FFB02206920h)
00007FFB022068D5 66 41 FF CB          dec         r11w
00007FFB022068D9 74 2A                je          Top+35h (07FFB02206905h)
00007FFB022068DB 48 3B 48 08          cmp         rcx,qword ptr [rax+8]
00007FFB022068DF 74 3F                je          Top+50h (07FFB02206920h)
00007FFB022068E1 66 41 FF CB          dec         r11w
00007FFB022068E5 74 1E                je          Top+35h (07FFB02206905h)
00007FFB022068E7 48 3B 48 10          cmp         rcx,qword ptr [rax+10h]
00007FFB022068EB 74 33                je          Top+50h (07FFB02206920h)
00007FFB022068ED 66 41 FF CB          dec         r11w
00007FFB022068F1 74 12                je          Top+35h (07FFB02206905h)
00007FFB022068F3 48 3B 48 18          cmp         rcx,qword ptr [rax+18h]
00007FFB022068F7 74 27                je          Top+50h (07FFB02206920h)
00007FFB022068F9 66 41 FF CB          dec         r11w
00007FFB022068FD 74 06                je          Top+35h (07FFB02206905h)
00007FFB022068FF 48 83 C0 20          add         rax,20h
00007FFB02206903 EB CB                jmp         Top (07FFB022068D0h)
00007FFB02206905 48 8B 02             mov         rax,qword ptr [rdx]
00007FFB02206908 F7 00 00 00 48 40    test        dword ptr [rax],40480000h
00007FFB0220690E 75 14                jne         Top+54h (07FFB02206924h)
00007FFB02206910 48 33 C0             xor         rax,rax
00007FFB02206913 C3                   ret
00007FFB02206914 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206920 48 8B C2             mov         rax,rdx
00007FFB02206923 C3                   ret
00007FFB02206924 E9 E7 CD F1 FF       jmp         JITutil_IsInstanceOfInterface (07FFB02123710h)
00007FFB02206929 0F 1F 80 00 00 00 00 nop         dword ptr [rax]
00007FFB02206930 48 85 D2             test        rdx,rdx
00007FFB02206933 74 5B                je          Top+40h (07FFB02206990h)
00007FFB02206935 48 8B 02             mov         rax,qword ptr [rdx]
00007FFB02206938 66 44 8B 58 0E       mov         r11w,word ptr [rax+0Eh]
00007FFB0220693D 48 8B 40 38          mov         rax,qword ptr [rax+38h]
00007FFB02206941 66 45 85 DB          test        r11w,r11w
00007FFB02206945 74 3E                je          Top+35h (07FFB02206985h)
00007FFB02206947 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206950 48 3B 08             cmp         rcx,qword ptr [rax]
00007FFB02206953 74 3B                je          Top+40h (07FFB02206990h)
00007FFB02206955 66 41 FF CB          dec         r11w
00007FFB02206959 74 2A                je          Top+35h (07FFB02206985h)
00007FFB0220695B 48 3B 48 08          cmp         rcx,qword ptr [rax+8]
00007FFB0220695F 74 2F                je          Top+40h (07FFB02206990h)
00007FFB02206961 66 41 FF CB          dec         r11w
00007FFB02206965 74 1E                je          Top+35h (07FFB02206985h)
00007FFB02206967 48 3B 48 10          cmp         rcx,qword ptr [rax+10h]
00007FFB0220696B 74 23                je          Top+40h (07FFB02206990h)
00007FFB0220696D 66 41 FF CB          dec         r11w
00007FFB02206971 74 12                je          Top+35h (07FFB02206985h)
00007FFB02206973 48 3B 48 18          cmp         rcx,qword ptr [rax+18h]
00007FFB02206977 74 17                je          Top+40h (07FFB02206990h)
00007FFB02206979 66 41 FF CB          dec         r11w
00007FFB0220697D 74 06                je          Top+35h (07FFB02206985h)
00007FFB0220697F 48 83 C0 20          add         rax,20h
00007FFB02206983 EB CB                jmp         Top (07FFB02206950h)
00007FFB02206985 E9 86 9C FF FF       jmp         JITutil_ChkCastInterface (07FFB02200610h)
00007FFB0220698A 66 0F 1F 44 00 00    nop         word ptr [rax+rax]
00007FFB02206990 48 8B C2             mov         rax,rdx
00007FFB02206993 C3                   ret
00007FFB02206994 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB022069A0 48 3B 0D B9 98 3D 00 cmp         rcx,qword ptr [g_lowest_address (07FFB025E0260h)]
00007FFB022069A7 72 0B                jb          NotInHeap (07FFB022069B4h)
00007FFB022069A9 48 3B 0D B8 98 3D 00 cmp         rcx,qword ptr [g_highest_address (07FFB025E0268h)]
00007FFB022069B0 73 02                jae         NotInHeap (07FFB022069B4h)
00007FFB022069B2 EB 1C                jmp         JIT_WriteBarrier (07FFB022069D0h)
00007FFB022069B4 48 89 11             mov         qword ptr [rcx],rdx
00007FFB022069B7 C3                   ret
00007FFB022069B8 90                   nop
00007FFB022069B9 0F 1F 80 00 00 00 00 nop         dword ptr [rax]
00007FFB022069C0 C3                   ret
00007FFB022069C1 66 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB022069D0 48 89 11             mov         qword ptr [rcx],rdx
00007FFB022069D3 0F 1F 00             nop         dword ptr [rax]
00007FFB022069D6 48 B8 58 45 88 57 BF 01 00 00 mov         rax,1BF57884558h
00007FFB022069E0 48 3B D0             cmp         rdx,rax
00007FFB022069E3 72 2B                jb          CheckCardTable+12h (07FFB02206A10h)
00007FFB022069E5 90                   nop
00007FFB022069E6 48 B8 80 16 FA 24 BF 01 00 00 mov         rax,1BF24FA1680h
00007FFB022069F0 48 C1 E9 0B          shr         rcx,0Bh
00007FFB022069F4 80 3C 01 FF          cmp         byte ptr [rcx+rax],0FFh
00007FFB022069F8 75 02                jne         JIT_WriteBarrier+2Ch (07FFB022069FCh)
00007FFB022069FA F3 C3                rep ret
00007FFB022069FC C6 04 01 FF          mov         byte ptr [rcx+rax],0FFh
00007FFB02206A00 C3                   ret
00007FFB02206A01 66 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206A10 F3 C3                rep ret
00007FFB02206A12 01 FF                add         edi,edi
00007FFB02206A14 75 02                jne         CheckCardTable+1Ah (07FFB02206A18h)
00007FFB02206A16 F3 C3                rep ret
00007FFB02206A18 C6 04 01 FF          mov         byte ptr [rcx+rax],0FFh
00007FFB02206A1C C3                   ret
00007FFB02206A1D 0F 1F 00             nop         dword ptr [rax]
00007FFB02206A20 F3 C3                rep ret
00007FFB02206A22 E9 0B 80 3C 01       jmp         00007FFB035CEA32
00007FFB02206A27 FF 75 02             push        qword ptr [rbp+2]
00007FFB02206A2A F3 C3                rep ret
00007FFB02206A2C C6 04 01 FF          mov         byte ptr [rcx+rax],0FFh
00007FFB02206A30 C3                   ret
00007FFB02206A31 66 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
Exit:
00007FFB02206A40 F3 C3                rep ret
00007FFB02206A42 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206A50 90                   nop
00007FFB02206A51 90                   nop
00007FFB02206A52 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206A60 C3                   ret
00007FFB02206A61 66 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]

BAD:
00007FFB02206A70 48 8B 0E             mov         rcx,qword ptr [rsi]
00007FFB02206A73 48 89 0F             mov         qword ptr [rdi],rcx
00007FFB02206A76 48 3B 3D E3 97 3D 00 cmp         rdi,qword ptr [g_lowest_address (07FFB025E0260h)]
00007FFB02206A7D 72 61                jb          CheckCardTable+39h (07FFB02206AE0h)
00007FFB02206A7F 48 3B 3D E2 97 3D 00 cmp         rdi,qword ptr [g_highest_address (07FFB025E0268h)]
00007FFB02206A86 73 58                jae         CheckCardTable+39h (07FFB02206AE0h)
00007FFB02206A88 80 3D BD 97 3D 00 00 cmp         byte ptr [g_sw_ww_enabled_for_gc_heap (07FFB025E024Ch)],0
00007FFB02206A8F 74 16                je          CheckCardTable (07FFB02206AA7h)
00007FFB02206A91 48 8B C7             mov         rax,rdi
00007FFB02206A94 48 C1 E8 0C          shr         rax,0Ch
00007FFB02206A98 48 03 05 B9 97 3D 00 add         rax,qword ptr [g_sw_ww_table (07FFB025E0258h)]
00007FFB02206A9F 80 38 00             cmp         byte ptr [rax],0
00007FFB02206AA2 75 03                jne         CheckCardTable (07FFB02206AA7h)
00007FFB02206AA4 C6 00 FF             mov         byte ptr [rax],0FFh
00007FFB02206AA7 48 3B 0D 02 47 3D 00 cmp         rcx,qword ptr [g_ephemeral_low (07FFB025DB1B0h)]
00007FFB02206AAE 72 30                jb          CheckCardTable+39h (07FFB02206AE0h)
00007FFB02206AB0 48 3B 0D F1 46 3D 00 cmp         rcx,qword ptr [g_ephemeral_high (07FFB025DB1A8h)]
00007FFB02206AB7 73 27                jae         CheckCardTable+39h (07FFB02206AE0h)
00007FFB02206AB9 48 8B CF             mov         rcx,rdi
00007FFB02206ABC 48 83 C6 08          add         rsi,8
00007FFB02206AC0 48 83 C7 08          add         rdi,8
00007FFB02206AC4 48 C1 E9 0B          shr         rcx,0Bh
00007FFB02206AC8 48 03 0D 81 97 3D 00 add         rcx,qword ptr [g_card_table (07FFB025E0250h)]
00007FFB02206ACF 80 39 FF             cmp         byte ptr [rcx],0FFh
00007FFB02206AD2 75 02                jne         CheckCardTable+2Fh (07FFB02206AD6h)
00007FFB02206AD4 F3 C3                rep ret
00007FFB02206AD6 C6 01 FF             mov         byte ptr [rcx],0FFh
00007FFB02206AD9 C3                   ret
00007FFB02206ADA 66 0F 1F 44 00 00    nop         word ptr [rax+rax]
00007FFB02206AE0 48 83 C7 08          add         rdi,8
00007FFB02206AE4 48 83 C6 08          add         rsi,8
00007FFB02206AE8 C3                   ret
00007FFB02206AE9 90                   nop
00007FFB02206AEA 66 0F 1F 44 00 00    nop         word ptr [rax+rax]
00007FFB02206AF0 48 85 C9             test        rcx,rcx
00007FFB02206AF3 74 36                je          DoWrite+1Eh (07FFB02206B2Bh)
00007FFB02206AF5 0B D2                or          edx,edx
00007FFB02206AF7 3B 51 08             cmp         edx,dword ptr [rcx+8]
00007FFB02206AFA 73 3B                jae         DoWrite+2Ah (07FFB02206B37h)
00007FFB02206AFC 4C 8B 11             mov         r10,qword ptr [rcx]
00007FFB02206AFF 4D 85 C0             test        r8,r8
00007FFB02206B02 74 16                je          DoWrite+0Dh (07FFB02206B1Ah)
00007FFB02206B04 4D 8B 4A 30          mov         r9,qword ptr [r10+30h]
00007FFB02206B08 4D 3B 08             cmp         r9,qword ptr [r8]
00007FFB02206B0B 75 13                jne         DoWrite+13h (07FFB02206B20h)
00007FFB02206B0D 48 8D 4C D1 10       lea         rcx,[rcx+rdx*8+10h]
00007FFB02206B12 49 8B D0             mov         rdx,r8
00007FFB02206B15 E9 B6 FE FF FF       jmp         JIT_WriteBarrier (07FFB022069D0h)
00007FFB02206B1A 4C 89 44 D1 10       mov         qword ptr [rcx+rdx*8+10h],r8
00007FFB02206B1F C3                   ret
00007FFB02206B20 4C 3B 0D 01 8B 3D 00 cmp         r9,qword ptr [g_pObjectClass (07FFB025DF628h)]
00007FFB02206B27 74 E4                je          DoWrite (07FFB02206B0Dh)
00007FFB02206B29 EB 25                jmp         JIT_Stelem_Ref__ObjIsInstanceOfNoGC_Helper (07FFB02206B50h)
00007FFB02206B2B 48 C7 C1 00 00 00 00 mov         rcx,0
00007FFB02206B32 E9 39 AC 12 00       jmp         JIT_InternalThrow (07FFB02331770h)
00007FFB02206B37 48 C7 C1 03 00 00 00 mov         rcx,3
00007FFB02206B3E E9 2D AC 12 00       jmp         JIT_InternalThrow (07FFB02331770h)
00007FFB02206B43 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206B50 48 83 EC 28          sub         rsp,28h
00007FFB02206B54 48 89 4C 24 30       mov         qword ptr [rsp+30h],rcx
00007FFB02206B59 48 89 54 24 38       mov         qword ptr [rsp+38h],rdx
00007FFB02206B5E 4C 89 44 24 40       mov         qword ptr [rsp+40h],r8
00007FFB02206B63 49 8B D1             mov         rdx,r9
00007FFB02206B66 49 8B C8             mov         rcx,r8
00007FFB02206B69 E8 B2 FC F4 FF       call        ObjIsInstanceOfNoGC (07FFB02156820h)
00007FFB02206B6E 48 8B 4C 24 30       mov         rcx,qword ptr [rsp+30h]
00007FFB02206B73 48 8B 54 24 38       mov         rdx,qword ptr [rsp+38h]
00007FFB02206B78 4C 8B 44 24 40       mov         r8,qword ptr [rsp+40h]
00007FFB02206B7D 83 F8 01             cmp         eax,1
00007FFB02206B80 75 11                jne         NeedCheck (07FFB02206B93h)
00007FFB02206B82 48 8D 4C D1 10       lea         rcx,[rcx+rdx*8+10h]
00007FFB02206B87 49 8B D0             mov         rdx,r8
00007FFB02206B8A 48 83 C4 28          add         rsp,28h
00007FFB02206B8E E9 3D FE FF FF       jmp         JIT_WriteBarrier (07FFB022069D0h)
00007FFB02206B93 48 83 C4 28          add         rsp,28h
00007FFB02206B97 EB 07                jmp         JIT_Stelem_Ref__ArrayStoreCheck_Helper (07FFB02206BA0h)
00007FFB02206B99 0F 1F 80 00 00 00 00 nop         dword ptr [rax]
00007FFB02206BA0 48 83 EC 28          sub         rsp,28h
00007FFB02206BA4 48 89 4C 24 30       mov         qword ptr [rsp+30h],rcx
00007FFB02206BA9 48 89 54 24 38       mov         qword ptr [rsp+38h],rdx
00007FFB02206BAE 4C 89 44 24 40       mov         qword ptr [rsp+40h],r8
00007FFB02206BB3 48 8D 4C 24 40       lea         rcx,[rsp+40h]
00007FFB02206BB8 48 8D 54 24 30       lea         rdx,[rsp+30h]
00007FFB02206BBD E8 BE 7B F4 FF       call        ArrayStoreCheck (07FFB0214E780h)
00007FFB02206BC2 48 8B 4C 24 30       mov         rcx,qword ptr [rsp+30h]
00007FFB02206BC7 48 8B 54 24 38       mov         rdx,qword ptr [rsp+38h]
00007FFB02206BCC 4C 8B 44 24 40       mov         r8,qword ptr [rsp+40h]
00007FFB02206BD1 48 8D 4C D1 10       lea         rcx,[rcx+rdx*8+10h]
00007FFB02206BD6 49 8B D0             mov         rdx,r8
00007FFB02206BD9 48 83 C4 28          add         rsp,28h
00007FFB02206BDD E9 EE FD FF FF       jmp         JIT_WriteBarrier (07FFB022069D0h)
00007FFB02206BE2 66 66 66 66 66 66 0F 1F 84 00 00 00 00 00 nop         word ptr [rax+rax]
00007FFB02206BF0 41 57                push        r15
00007FFB02206BF2 41 56                push        r14
00007FFB02206BF4 41 55                push        r13
00007FFB02206BF6 41 54                push        r12
00007FFB02206BF8 55                   push        rbp
00007FFB02206BF9 53                   push        rbx
00007FFB02206BFA 56                   push        rsi
00007FFB02206BFB 57                   push        rdi
00007FFB02206BFC 48 83 EC 48          sub         rsp,48h
00007FFB02206C00 4C 8D 6C 24 20       lea         r13,[rsp+20h]
00007FFB02206C05 CC                   int         3
00007FFB02206C06 4D 89 7E 10          mov         qword ptr [r14+10h],r15
00007FFB02206C0A 49 8D 65 28          lea         rsp,[r13+28h]
00007FFB02206C0E 5F                   pop         rdi
00007FFB02206C0F 5E                   pop         rsi
00007FFB02206C10 5B                   pop         rbx
00007FFB02206C11 5D                   pop         rbp
00007FFB02206C12 41 5C                pop         r12
00007FFB02206C14 41 5D                pop         r13
00007FFB02206C16 41 5E                pop         r14
00007FFB02206C18 41 5F                pop         r15
00007FFB02206C1A C3                   ret
