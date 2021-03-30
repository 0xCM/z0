00007FFAF8C66A70 48 8B 0E             mov         rcx,qword ptr [rsi]
00007FFAF8C66A73 48 89 0F             mov         qword ptr [rdi],rcx
00007FFAF8C66A76 48 3B 3D E3 97 3D 00 cmp         rdi,qword ptr [g_lowest_address (07FFAF9040260h)]
00007FFAF8C66A7D 72 61                jb          CheckCardTable+39h (07FFAF8C66AE0h)
00007FFAF8C66A7F 48 3B 3D E2 97 3D 00 cmp         rdi,qword ptr [g_highest_address (07FFAF9040268h)]
00007FFAF8C66A86 73 58                jae         CheckCardTable+39h (07FFAF8C66AE0h)
00007FFAF8C66A88 80 3D BD 97 3D 00 00 cmp         byte ptr [g_sw_ww_enabled_for_gc_heap (07FFAF904024Ch)],0
00007FFAF8C66A8F 74 16                je          CheckCardTable (07FFAF8C66AA7h)
00007FFAF8C66A91 48 8B C7             mov         rax,rdi
00007FFAF8C66A94 48 C1 E8 0C          shr         rax,0Ch
00007FFAF8C66A98 48 03 05 B9 97 3D 00 add         rax,qword ptr [g_sw_ww_table (07FFAF9040258h)]
00007FFAF8C66A9F 80 38 00             cmp         byte ptr [rax],0
00007FFAF8C66AA2 75 03                jne         CheckCardTable (07FFAF8C66AA7h)
00007FFAF8C66AA4 C6 00 FF             mov         byte ptr [rax],0FFh
00007FFAF8C66AA7 48 3B 0D 02 47 3D 00 cmp         rcx,qword ptr [g_ephemeral_low (07FFAF903B1B0h)]
00007FFAF8C66AAE 72 30                jb          CheckCardTable+39h (07FFAF8C66AE0h)
00007FFAF8C66AB0 48 3B 0D F1 46 3D 00 cmp         rcx,qword ptr [g_ephemeral_high (07FFAF903B1A8h)]
00007FFAF8C66AB7 73 27                jae         CheckCardTable+39h (07FFAF8C66AE0h)
00007FFAF8C66AB9 48 8B CF             mov         rcx,rdi
00007FFAF8C66ABC 48 83 C6 08          add         rsi,8
00007FFAF8C66AC0 48 83 C7 08          add         rdi,8
00007FFAF8C66AC4 48 C1 E9 0B          shr         rcx,0Bh
00007FFAF8C66AC8 48 03 0D 81 97 3D 00 add         rcx,qword ptr [g_card_table (07FFAF9040250h)]
00007FFAF8C66ACF 80 39 FF             cmp         byte ptr [rcx],0FFh
00007FFAF8C66AD2 75 02                jne         CheckCardTable+2Fh (07FFAF8C66AD6h)
00007FFAF8C66AD4 F3 C3                rep ret
00007FFAF8C66AD6 C6 01 FF             mov         byte ptr [rcx],0FFh
00007FFAF8C66AD9 C3                   ret
00007FFAF8C66ADA 66 0F 1F 44 00 00    nop         word ptr [rax+rax]
00007FFAF8C66AE0 48 83 C7 08          add         rdi,8
00007FFAF8C66AE4 48 83 C6 08          add         rsi,8
00007FFAF8C66AE8 C3                   ret
