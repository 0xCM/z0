; 2020-01-01 04:39:45:140
; function: void unpack_64x32(ulong src, Span<uint> dst)
; location: [7FF7C7ABCD40h, 7FF7C7ABCE82h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(4 bytes) = 48 89 14 24
000eh mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(4 bytes) = 48 89 14 24
0012h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 14 24
0016h movzx r8d,cl                  ; MOVZX(Movzx_r32_rm8) [R8D,CL]                        encoding(4 bytes) = 44 0f b6 c1
001ah mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0024h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0029h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
002ch mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
002fh vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
0034h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0037h vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
003ch mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
003fh shr r8,8                      ; SHR(Shr_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e8 08
0043h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0047h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
004ch mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
004fh mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0052h vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
0057h lea r8,[rax+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 20
005bh vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
0060h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0063h shr r8,10h                    ; SHR(Shr_rm64_imm8) [R8,10h:imm8]                     encoding(4 bytes) = 49 c1 e8 10
0067h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
006bh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0070h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0073h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0076h vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
007bh lea r8,[rax+40h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 40
007fh vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
0084h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0087h shr r8,18h                    ; SHR(Shr_rm64_imm8) [R8,18h:imm8]                     encoding(4 bytes) = 49 c1 e8 18
008bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
008fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0094h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0097h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
009ah vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
009fh lea r8,[rax+60h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 60
00a3h vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
00a8h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
00abh shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
00afh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00b3h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
00b8h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
00bbh mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
00beh vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
00c3h lea r8,[rax+80h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(7 bytes) = 4c 8d 80 80 00 00 00
00cah vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
00cfh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
00d2h shr r8,28h                    ; SHR(Shr_rm64_imm8) [R8,28h:imm8]                     encoding(4 bytes) = 49 c1 e8 28
00d6h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00dah pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
00dfh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
00e2h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
00e5h vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
00eah lea r8,[rax+0A0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(7 bytes) = 4c 8d 80 a0 00 00 00
00f1h vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
00f6h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
00f9h shr r8,30h                    ; SHR(Shr_rm64_imm8) [R8,30h:imm8]                     encoding(4 bytes) = 49 c1 e8 30
00fdh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0101h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0106h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0109h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
010ch vpmovzxbd ymm0,qword ptr [r8] ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c2 7d 31 00
0111h lea r8,[rax+0C0h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(7 bytes) = 4c 8d 80 c0 00 00 00
0118h vmovdqu ymmword ptr [r8],ymm0 ; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 00
011dh shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
0121h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0124h pdep rcx,rcx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R9]             encoding(VEX, 5 bytes) = c4 c2 f3 f5 c9
0129h mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
012ch vpmovzxbd ymm0,qword ptr [rdx]; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,RDX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 31 02
0131h add rax,0E0h                  ; ADD(Add_RAX_imm32) [RAX,e0h:imm64]                   encoding(6 bytes) = 48 05 e0 00 00 00
0137h vmovdqu ymmword ptr [rax],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RAX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 00
013bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
013eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0142h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> unpack_64x32Bytes => new byte[323]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0x33,0xD2,0x48,0x89,0x14,0x24,0x48,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0x44,0x0F,0xB6,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8B,0xC0,0xC4,0xC1,0x7E,0x7F,0x00,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x08,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8D,0x40,0x20,0xC4,0xC1,0x7E,0x7F,0x00,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x10,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8D,0x40,0x40,0xC4,0xC1,0x7E,0x7F,0x00,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x18,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8D,0x40,0x60,0xC4,0xC1,0x7E,0x7F,0x00,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8D,0x80,0x80,0x00,0x00,0x00,0xC4,0xC1,0x7E,0x7F,0x00,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x28,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8D,0x80,0xA0,0x00,0x00,0x00,0xC4,0xC1,0x7E,0x7F,0x00,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x30,0x45,0x0F,0xB6,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0xC2,0xC4,0xC2,0x7D,0x31,0x00,0x4C,0x8D,0x80,0xC0,0x00,0x00,0x00,0xC4,0xC1,0x7E,0x7F,0x00,0x48,0xC1,0xE9,0x38,0x0F,0xB6,0xC9,0xC4,0xC2,0xF3,0xF5,0xC9,0x48,0x89,0x0A,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x05,0xE0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x00,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
