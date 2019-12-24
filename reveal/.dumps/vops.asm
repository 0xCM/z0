; 2019-12-23 19:01:28:771
; function: void add_blocks_zip(Block128<uint> left, Block128<uint> right, Block128<uint> dst)
; location: [7FF7C7E82D10h, 7FF7C7E82D7Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,2                     ; SAR(Sar_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 f8 02
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 006fh               ; JLE(Jle_rel8_64) [6Fh:jmp64]                         encoding(2 bytes) = 7e 4e
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh lea r10,[r10+r11*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,R10:br,:sr)]         encoding(4 bytes) = 4f 8d 14 9a
0032h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0037h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003ah mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
003dh shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
0041h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0044h lea r10,[r10+r11*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,R10:br,:sr)]         encoding(4 bytes) = 4f 8d 14 9a
0048h vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
004dh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0051h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0054h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0057h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
005bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
005eh lea r10,[r10+r11*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,R10:br,:sr)]         encoding(4 bytes) = 4f 8d 14 9a
0062h vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0067h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
006ah cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
006dh jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c b2
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_blocks_zipBytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x41,0x03,0xC1,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x4E,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x4F,0x8D,0x14,0x9A,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x4F,0x8D,0x14,0x9A,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xFE,0xC1,0x4D,0x8B,0x10,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x4F,0x8D,0x14,0x9A,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xB2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void add_blocksp(ConstBlock128<uint> left, ConstBlock128<uint> right, Block128<uint> dst)
; location: [7FF7C7E82DA0h, 7FF7C7E82DFCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,2                     ; SAR(Sar_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 f8 02
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005ch               ; JLE(Jle_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 7e 3b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,2                     ; SHL(Shl_rm64_imm8) [R11,2h:imm8]                     encoding(4 bytes) = 49 c1 e3 02
0032h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0035h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
003ah mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003dh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0040h vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
0045h vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_blockspBytes => new byte[93]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x41,0x03,0xC1,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xFE,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> op_shift_specific(Vector256<uint> src)
; location: [7FF7C7E83220h, 7FF7C7E83246h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh vpslld ymm0,ymm0,3            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM0,YMM0,3h:imm8]  encoding(VEX, 5 bytes) = c5 fd 72 f0 03
0010h vpsrld ymm0,ymm0,3            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM0,YMM0,3h:imm8]  encoding(VEX, 5 bytes) = c5 fd 72 d0 03
0015h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0017h cmp eax,14h                   ; CMP(Cmp_rm32_imm8) [EAX,14h:imm32]                   encoding(3 bytes) = 83 f8 14
001ah jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c ef
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> op_shift_specificBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x33,0xC0,0xC5,0xFD,0x72,0xF0,0x03,0xC5,0xFD,0x72,0xD0,0x03,0xFF,0xC0,0x83,0xF8,0x14,0x7C,0xEF,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> op_shift(Vector256<uint> src, byte amount)
; location: [7FF7C7E83260h, 7FF7C7E83290h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000fh vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
0013h vpslld ymm0,ymm0,xmm1         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f2 c1
0017h vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
001bh vpsrld ymm0,ymm0,xmm1         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd d2 c1
001fh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0021h cmp eax,14h                   ; CMP(Cmp_rm32_imm8) [EAX,14h:imm32]                   encoding(3 bytes) = 83 f8 14
0024h jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c e9
0026h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> op_shiftBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x33,0xC0,0x41,0x0F,0xB6,0xD0,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xF2,0xC1,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xD2,0xC1,0xFF,0xC0,0x83,0xF8,0x14,0x7C,0xE9,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
