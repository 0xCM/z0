; 2019-10-15 01:38:29:079
; function: void part30x3(uint src, Span<byte> dst)
; location: [7FFDDBEB9030h, 7FFDDBEB91A6h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 5d 01 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 37 01 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 0d 01 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 e9 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0E00h                 ; MOV(Mov_r32_imm32) [R9D,e00h:imm32]                  encoding(6 bytes) = 41 b9 00 0e 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,7000h                 ; MOV(Mov_r32_imm32) [R9D,7000h:imm32]                 encoding(6 bytes) = 41 b9 00 70 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
00d0h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d4h mov r9d,38000h                ; MOV(Mov_r32_imm32) [R9D,38000h:imm32]                encoding(6 bytes) = 41 b9 00 80 03 00
00dah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dfh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e4h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e8h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00ebh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eeh jbe near ptr 0171h            ; JBE(Jbe_rel32_64) [171h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00f4h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f8h mov r9d,1C0000h               ; MOV(Mov_r32_imm32) [R9D,1c0000h:imm32]               encoding(6 bytes) = 41 b9 00 00 1c 00
00feh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0103h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0108h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
010ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
010fh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0112h jbe short 0171h               ; JBE(Jbe_rel8_64) [171h:jmp64]                        encoding(2 bytes) = 76 5d
0114h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 07
0118h mov r9d,0E00000h              ; MOV(Mov_r32_imm32) [R9D,e00000h:imm32]               encoding(6 bytes) = 41 b9 00 00 e0 00
011eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0123h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0128h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
012ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
012fh cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0132h jbe short 0171h               ; JBE(Jbe_rel8_64) [171h:jmp64]                        encoding(2 bytes) = 76 3d
0134h lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 08
0138h mov r9d,7000000h              ; MOV(Mov_r32_imm32) [R9D,7000000h:imm32]              encoding(6 bytes) = 41 b9 00 00 00 07
013eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0143h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0148h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
014ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
014fh cmp edx,9                     ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]                    encoding(3 bytes) = 83 fa 09
0152h jbe short 0171h               ; JBE(Jbe_rel8_64) [171h:jmp64]                        encoding(2 bytes) = 76 1d
0154h add rax,9                     ; ADD(Add_rm64_imm8) [RAX,9h:imm64]                    encoding(4 bytes) = 48 83 c0 09
0158h mov edx,38000000h             ; MOV(Mov_r32_imm32) [EDX,38000000h:imm32]             encoding(5 bytes) = ba 00 00 00 38
015dh pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0162h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
0167h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
016ah mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
016ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0170h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0171h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375ED0h:jmp64]                encoding(5 bytes) = e8 5a 5d 37 5f
0176h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part30x3Bytes => new byte[375]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x5D,0x01,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x37,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x0D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x1C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x5D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x00,0x00,0xE0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x3D,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0x00,0x00,0x07,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x09,0x76,0x1D,0x48,0x83,0xC0,0x09,0xBA,0x00,0x00,0x00,0x38,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x5A,0x5D,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x3:uint part)
; location: [7FFDDBEB91C0h, 7FFDDBEB91CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x3:uint part)
; location: [7FFDDBEB91E0h, 7FFDDBEB91EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x3:uint part)
; location: [7FFDDBEB9200h, 7FFDDBEB920Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x3:uint part)
; location: [7FFDDBEB9220h, 7FFDDBEB922Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part18x3:uint part)
; location: [7FFDDBEB9240h, 7FFDDBEB924Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part21x3:uint part)
; location: [7FFDDBEB9260h, 7FFDDBEB926Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part24x3:uint part)
; location: [7FFDDBEB9280h, 7FFDDBEB928Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part27x3:uint part)
; location: [7FFDDBEB92A0h, 7FFDDBEB92AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x3:uint part)
; location: [7FFDDBEB92C0h, 7FFDDBEB92CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x3:uint part)
; location: [7FFDDBEB92E0h, 7FFDDBEB92EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x3:uint part)
; location: [7FFDDBEB9300h, 7FFDDBEB930Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x3:uint part)
; location: [7FFDDBEB9320h, 7FFDDBEB932Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part15x3:uint part)
; location: [7FFDDBEB9340h, 7FFDDBEB934Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part18x3:uint part)
; location: [7FFDDBEB9360h, 7FFDDBEB936Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part21x3:uint part)
; location: [7FFDDBEB9380h, 7FFDDBEB938Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x3:uint part)
; location: [7FFDDBEB93A0h, 7FFDDBEB93AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part27x3:uint part)
; location: [7FFDDBEB93C0h, 7FFDDBEB93CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x3:uint part)
; location: [7FFDDBEB93E0h, 7FFDDBEB93EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x4(uint src, Span<byte> dst)
; location: [7FFDDBEB9400h, 7FFDDBEB9453h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 004eh               ; JBE(Jbe_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 76 3e
0010h mov r8d,0Fh                   ; MOV(Mov_r32_imm32) [R8D,fh:imm32]                    encoding(6 bytes) = 41 b8 0f 00 00 00
0016h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001bh mov r9d,0Fh                   ; MOV(Mov_r32_imm32) [R9D,fh:imm32]                    encoding(6 bytes) = 41 b9 0f 00 00 00
0021h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
002dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0030h jbe short 004eh               ; JBE(Jbe_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 76 1c
0032h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0035h mov edx,0F0h                  ; MOV(Mov_r32_imm32) [EDX,f0h:imm32]                   encoding(5 bytes) = ba f0 00 00 00
003ah pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
003fh pdep edx,edx,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R9D]            encoding(VEX, 5 bytes) = c4 c2 6b f5 d1
0044h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0047h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0049h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004eh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375B00h:jmp64]                encoding(5 bytes) = e8 ad 5a 37 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part8x4Bytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x3E,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x1C,0x48,0xFF,0xC0,0xBA,0xF0,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xAD,0x5A,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x4(uint src, Span<byte> dst)
; location: [7FFDDBEB9470h, 7FFDDBEB94EAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 0075h               ; JBE(Jbe_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 76 65
0010h mov r8d,0Fh                   ; MOV(Mov_r32_imm32) [R8D,fh:imm32]                    encoding(6 bytes) = 41 b8 0f 00 00 00
0016h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001bh mov r9d,0Fh                   ; MOV(Mov_r32_imm32) [R9D,fh:imm32]                    encoding(6 bytes) = 41 b9 0f 00 00 00
0021h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
002dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0030h jbe short 0075h               ; JBE(Jbe_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 76 43
0032h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
0036h mov r9d,0F0h                  ; MOV(Mov_r32_imm32) [R9D,f0h:imm32]                   encoding(6 bytes) = 41 b9 f0 00 00 00
003ch pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0041h mov r10d,0Fh                  ; MOV(Mov_r32_imm32) [R10D,fh:imm32]                   encoding(6 bytes) = 41 ba 0f 00 00 00
0047h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
004ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0050h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0053h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0056h jbe short 0075h               ; JBE(Jbe_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 76 1d
0058h add rax,2                     ; ADD(Add_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 c0 02
005ch mov edx,0F00h                 ; MOV(Mov_r32_imm32) [EDX,f00h:imm32]                  encoding(5 bytes) = ba 00 0f 00 00
0061h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0066h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
006bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
006eh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0070h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0074h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0075h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375A90h:jmp64]                encoding(5 bytes) = e8 16 5a 37 5f
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part12x4Bytes => new byte[123]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x65,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x43,0x4C,0x8D,0x40,0x01,0x41,0xB9,0xF0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x0F,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x1D,0x48,0x83,0xC0,0x02,0xBA,0x00,0x0F,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x16,0x5A,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x4(uint src, Span<byte> dst)
; location: [7FFDDBEB9500h, 7FFDDBEB959Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0099h            ; JBE(Jbe_rel32_64) [99h:jmp64]                        encoding(6 bytes) = 0f 86 85 00 00 00
0014h mov r8d,0Fh                   ; MOV(Mov_r32_imm32) [R8D,fh:imm32]                    encoding(6 bytes) = 41 b8 0f 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,0Fh                   ; MOV(Mov_r32_imm32) [R9D,fh:imm32]                    encoding(6 bytes) = 41 b9 0f 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 63
0036h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003ah mov r9d,0F0h                  ; MOV(Mov_r32_imm32) [R9D,f0h:imm32]                   encoding(6 bytes) = 41 b9 f0 00 00 00
0040h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0045h mov r10d,0Fh                  ; MOV(Mov_r32_imm32) [R10D,fh:imm32]                   encoding(6 bytes) = 41 ba 0f 00 00 00
004bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0050h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0054h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0057h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 3d
005ch lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0060h mov r9d,0F00h                 ; MOV(Mov_r32_imm32) [R9D,f00h:imm32]                  encoding(6 bytes) = 41 b9 00 0f 00 00
0066h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
006bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0070h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0074h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0077h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
007ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 1d
007ch add rax,3                     ; ADD(Add_rm64_imm8) [RAX,3h:imm64]                    encoding(4 bytes) = 48 83 c0 03
0080h mov edx,0F000h                ; MOV(Mov_r32_imm32) [EDX,f000h:imm32]                 encoding(5 bytes) = ba 00 f0 00 00
0085h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
008ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
008fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0092h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0094h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0098h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0099h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375A00h:jmp64]                encoding(5 bytes) = e8 62 59 37 5f
009eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x4Bytes => new byte[159]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x85,0x00,0x00,0x00,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x63,0x4C,0x8D,0x40,0x01,0x41,0xB9,0xF0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x0F,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x3D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x00,0x0F,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x1D,0x48,0x83,0xC0,0x03,0xBA,0x00,0xF0,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x62,0x59,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x4(uint src, Span<byte> dst)
; location: [7FFDDBEB95C0h, 7FFDDBEB96EEh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 15 01 00 00
0014h mov r8d,0Fh                   ; MOV(Mov_r32_imm32) [R8D,fh:imm32]                    encoding(6 bytes) = 41 b8 0f 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,0Fh                   ; MOV(Mov_r32_imm32) [R9D,fh:imm32]                    encoding(6 bytes) = 41 b9 0f 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 ef 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,0F0h                  ; MOV(Mov_r32_imm32) [R9D,f0h:imm32]                   encoding(6 bytes) = 41 b9 f0 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,0Fh                  ; MOV(Mov_r32_imm32) [R10D,fh:imm32]                   encoding(6 bytes) = 41 ba 0f 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,0F00h                 ; MOV(Mov_r32_imm32) [R9D,f00h:imm32]                  encoding(6 bytes) = 41 b9 00 0f 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0F000h                ; MOV(Mov_r32_imm32) [R9D,f000h:imm32]                 encoding(6 bytes) = 41 b9 00 f0 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,0F0000h               ; MOV(Mov_r32_imm32) [R9D,f0000h:imm32]                encoding(6 bytes) = 41 b9 00 00 0f 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 5d
00cch lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d0h mov r9d,0F00000h              ; MOV(Mov_r32_imm32) [R9D,f00000h:imm32]               encoding(6 bytes) = 41 b9 00 00 f0 00
00d6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00e7h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 3d
00ech lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f0h mov r9d,0F000000h             ; MOV(Mov_r32_imm32) [R9D,f000000h:imm32]              encoding(6 bytes) = 41 b9 00 00 00 0f
00f6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00fbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0100h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0104h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0107h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
010ah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 1d
010ch add rax,7                     ; ADD(Add_rm64_imm8) [RAX,7h:imm64]                    encoding(4 bytes) = 48 83 c0 07
0110h mov edx,0F0000000h            ; MOV(Mov_r32_imm32) [EDX,f0000000h:imm32]             encoding(5 bytes) = ba 00 00 00 f0
0115h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
011ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
011fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0122h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0124h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0128h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0129h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375940h:jmp64]                encoding(5 bytes) = e8 12 58 37 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x4Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0xF0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x0F,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x00,0x0F,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0xF0,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x00,0x0F,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x00,0xF0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x00,0x0F,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x00,0x00,0x00,0xF0,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x12,0x58,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x4:uint part)
; location: [7FFDDBEB9710h, 7FFDDBEB971Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x4:uint part)
; location: [7FFDDBEB9730h, 7FFDDBEB973Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x4:uint part)
; location: [7FFDDBEB9750h, 7FFDDBEB975Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x4:uint part)
; location: [7FFDDBEB9770h, 7FFDDBEB977Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x4:uint part)
; location: [7FFDDBEB9790h, 7FFDDBEB979Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x4:uint part)
; location: [7FFDDBEB97B0h, 7FFDDBEB97BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x4:uint part)
; location: [7FFDDBEB97D0h, 7FFDDBEB97DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part20x4:uint part)
; location: [7FFDDBEB97F0h, 7FFDDBEB97FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x4:uint part)
; location: [7FFDDBEB9810h, 7FFDDBEB981Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x4:uint part)
; location: [7FFDDBEB9830h, 7FFDDBEB983Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x5:uint part)
; location: [7FFDDBEB9850h, 7FFDDBEB985Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x5:uint part)
; location: [7FFDDBEB9870h, 7FFDDBEB987Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part20x5:uint part)
; location: [7FFDDBEB9890h, 7FFDDBEB989Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part25x5:uint part)
; location: [7FFDDBEB98B0h, 7FFDDBEB98BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x5:uint part)
; location: [7FFDDBEB98D0h, 7FFDDBEB98DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part10x5:uint part)
; location: [7FFDDBEB98F0h, 7FFDDBEB98FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part15x5:uint part)
; location: [7FFDDBEB9910h, 7FFDDBEB991Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x6:uint part)
; location: [7FFDDBEB9930h, 7FFDDBEB993Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x6:uint part)
; location: [7FFDDBEB9950h, 7FFDDBEB995Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x8(uint src, Span<byte> dst)
; location: [7FFDDBEB9970h, 7FFDDBEB99C3h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 004eh               ; JBE(Jbe_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 76 3e
0010h mov r8d,0FFh                  ; MOV(Mov_r32_imm32) [R8D,ffh:imm32]                   encoding(6 bytes) = 41 b8 ff 00 00 00
0016h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001bh mov r9d,0FFh                  ; MOV(Mov_r32_imm32) [R9D,ffh:imm32]                   encoding(6 bytes) = 41 b9 ff 00 00 00
0021h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
002dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0030h jbe short 004eh               ; JBE(Jbe_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 76 1c
0032h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0035h mov edx,0FF00h                ; MOV(Mov_r32_imm32) [EDX,ff00h:imm32]                 encoding(5 bytes) = ba 00 ff 00 00
003ah pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
003fh pdep edx,edx,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R9D]            encoding(VEX, 5 bytes) = c4 c2 6b f5 d1
0044h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0047h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0049h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004eh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375590h:jmp64]                encoding(5 bytes) = e8 3d 55 37 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x8Bytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x3E,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0xFF,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x1C,0x48,0xFF,0xC0,0xBA,0x00,0xFF,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x3D,0x55,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x8(uint src, Span<byte> dst)
; location: [7FFDDBEB99E0h, 7FFDDBEB9A8Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 00a8h            ; JBE(Jbe_rel32_64) [A8h:jmp64]                        encoding(6 bytes) = 0f 86 94 00 00 00
0014h mov r8d,0FFh                  ; MOV(Mov_r32_imm32) [R8D,ffh:imm32]                   encoding(6 bytes) = 41 b8 ff 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0023h mov r9d,0FFh                  ; MOV(Mov_r32_imm32) [R9D,ffh:imm32]                   encoding(6 bytes) = 41 b9 ff 00 00 00
0029h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0032h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0035h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0038h jbe short 00a8h               ; JBE(Jbe_rel8_64) [A8h:jmp64]                         encoding(2 bytes) = 76 6e
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,0FF00h                ; MOV(Mov_r32_imm32) [R9D,ff00h:imm32]                 encoding(6 bytes) = 41 b9 00 ff 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
004dh mov r10d,0FFh                 ; MOV(Mov_r32_imm32) [R10D,ffh:imm32]                  encoding(6 bytes) = 41 ba ff 00 00 00
0053h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0058h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
005ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005fh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0062h jbe short 00a8h               ; JBE(Jbe_rel8_64) [A8h:jmp64]                         encoding(2 bytes) = 76 44
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,0FF0000h              ; MOV(Mov_r32_imm32) [R9D,ff0000h:imm32]               encoding(6 bytes) = 41 b9 00 00 ff 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0077h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
007ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0080h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0083h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0086h jbe short 00a8h               ; JBE(Jbe_rel8_64) [A8h:jmp64]                         encoding(2 bytes) = 76 20
0088h add rax,3                     ; ADD(Add_rm64_imm8) [RAX,3h:imm64]                    encoding(4 bytes) = 48 83 c0 03
008ch mov edx,0FF000000h            ; MOV(Mov_r32_imm32) [EDX,ff000000h:imm32]             encoding(5 bytes) = ba 00 00 00 ff
0091h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0096h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0099h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
009eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00a1h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
00a3h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00a7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a8h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375520h:jmp64]                encoding(5 bytes) = e8 73 54 37 5f
00adh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x8Bytes => new byte[174]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x94,0x00,0x00,0x00,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0xFF,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x6E,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x41,0xBA,0xFF,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x44,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x20,0x48,0x83,0xC0,0x03,0xBA,0x00,0x00,0x00,0xFF,0xC4,0xE2,0x72,0xF5,0xD2,0x0F,0xB6,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x73,0x54,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x8:uint part)
; location: [7FFDDBEB9AB0h, 7FFDDBEB9ABAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x8:uint part)
; location: [7FFDDBEB9AD0h, 7FFDDBEB9ADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x8:ulong part)
; location: [7FFDDBEB9AF0h, 7FFDDBEB9AFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x8:uint part)
; location: [7FFDDBEB9B10h, 7FFDDBEB9B1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part32x8:uint part)
; location: [7FFDDBEB9B30h, 7FFDDBEB9B3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x8:uint part)
; location: [7FFDDBEB9B50h, 7FFDDBEB9B5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(ulong src, Part64x8:ulong part)
; location: [7FFDDBEB9B70h, 7FFDDBEB9B7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part64x8:ulong part)
; location: [7FFDDBEB9B90h, 7FFDDBEB9B9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort pack16x1(ReadOnlySpan<byte> src, ref ushort dst)
; location: [7FFDDBEB9BB0h, 7FFDDBEB9D46h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
000eh jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 7d 01 00 00
0014h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
0018h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
001ch cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001fh jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 6c 01 00 00
0025h movzx r8d,byte ptr [rax+1]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 01
002ah shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
002dh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0031h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0035h cmp ecx,2                     ; CMP(Cmp_rm32_imm8) [ECX,2h:imm32]                    encoding(3 bytes) = 83 f9 02
0038h jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 53 01 00 00
003eh movzx r8d,byte ptr [rax+2]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 02
0043h shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
0047h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
004bh or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
004fh cmp ecx,3                     ; CMP(Cmp_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 f9 03
0052h jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 39 01 00 00
0058h movzx r8d,byte ptr [rax+3]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 03
005dh shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
0061h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0065h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0069h cmp ecx,4                     ; CMP(Cmp_rm32_imm8) [ECX,4h:imm32]                    encoding(3 bytes) = 83 f9 04
006ch jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 1f 01 00 00
0072h movzx r8d,byte ptr [rax+4]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 04
0077h shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
007bh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
007fh or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0083h cmp ecx,5                     ; CMP(Cmp_rm32_imm8) [ECX,5h:imm32]                    encoding(3 bytes) = 83 f9 05
0086h jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 05 01 00 00
008ch movzx r8d,byte ptr [rax+5]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 05
0091h shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
0095h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0099h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
009dh cmp ecx,6                     ; CMP(Cmp_rm32_imm8) [ECX,6h:imm32]                    encoding(3 bytes) = 83 f9 06
00a0h jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 eb 00 00 00
00a6h movzx r8d,byte ptr [rax+6]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 06
00abh shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
00afh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
00b3h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
00b7h cmp ecx,7                     ; CMP(Cmp_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 f9 07
00bah jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 d1 00 00 00
00c0h movzx r8d,byte ptr [rax+7]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 07
00c5h shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
00c9h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
00cdh or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
00d1h cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
00d4h jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 b7 00 00 00
00dah movzx r8d,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 08
00dfh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
00e3h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
00e7h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
00ebh cmp ecx,9                     ; CMP(Cmp_rm32_imm8) [ECX,9h:imm32]                    encoding(3 bytes) = 83 f9 09
00eeh jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 9d 00 00 00
00f4h movzx r8d,byte ptr [rax+9]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 09
00f9h shl r8d,9                     ; SHL(Shl_rm32_imm8) [R8D,9h:imm8]                     encoding(4 bytes) = 41 c1 e0 09
00fdh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0101h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0105h cmp ecx,0Ah                   ; CMP(Cmp_rm32_imm8) [ECX,ah:imm32]                    encoding(3 bytes) = 83 f9 0a
0108h jbe near ptr 0191h            ; JBE(Jbe_rel32_64) [191h:jmp64]                       encoding(6 bytes) = 0f 86 83 00 00 00
010eh movzx r8d,byte ptr [rax+0Ah]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 0a
0113h shl r8d,0Ah                   ; SHL(Shl_rm32_imm8) [R8D,ah:imm8]                     encoding(4 bytes) = 41 c1 e0 0a
0117h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
011bh or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
011fh cmp ecx,0Bh                   ; CMP(Cmp_rm32_imm8) [ECX,bh:imm32]                    encoding(3 bytes) = 83 f9 0b
0122h jbe short 0191h               ; JBE(Jbe_rel8_64) [191h:jmp64]                        encoding(2 bytes) = 76 6d
0124h movzx r8d,byte ptr [rax+0Bh]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 0b
0129h shl r8d,0Bh                   ; SHL(Shl_rm32_imm8) [R8D,bh:imm8]                     encoding(4 bytes) = 41 c1 e0 0b
012dh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0131h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0135h cmp ecx,0Ch                   ; CMP(Cmp_rm32_imm8) [ECX,ch:imm32]                    encoding(3 bytes) = 83 f9 0c
0138h jbe short 0191h               ; JBE(Jbe_rel8_64) [191h:jmp64]                        encoding(2 bytes) = 76 57
013ah movzx r8d,byte ptr [rax+0Ch]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 0c
013fh shl r8d,0Ch                   ; SHL(Shl_rm32_imm8) [R8D,ch:imm8]                     encoding(4 bytes) = 41 c1 e0 0c
0143h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0147h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
014bh cmp ecx,0Dh                   ; CMP(Cmp_rm32_imm8) [ECX,dh:imm32]                    encoding(3 bytes) = 83 f9 0d
014eh jbe short 0191h               ; JBE(Jbe_rel8_64) [191h:jmp64]                        encoding(2 bytes) = 76 41
0150h movzx r8d,byte ptr [rax+0Dh]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 0d
0155h shl r8d,0Dh                   ; SHL(Shl_rm32_imm8) [R8D,dh:imm8]                     encoding(4 bytes) = 41 c1 e0 0d
0159h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
015dh or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0161h cmp ecx,0Eh                   ; CMP(Cmp_rm32_imm8) [ECX,eh:imm32]                    encoding(3 bytes) = 83 f9 0e
0164h jbe short 0191h               ; JBE(Jbe_rel8_64) [191h:jmp64]                        encoding(2 bytes) = 76 2b
0166h movzx r8d,byte ptr [rax+0Eh]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(5 bytes) = 44 0f b6 40 0e
016bh shl r8d,0Eh                   ; SHL(Shl_rm32_imm8) [R8D,eh:imm8]                     encoding(4 bytes) = 41 c1 e0 0e
016fh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0173h or [rdx],r8w                  ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),R8W]          encoding(4 bytes) = 66 44 09 02
0177h cmp ecx,0Fh                   ; CMP(Cmp_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 f9 0f
017ah jbe short 0191h               ; JBE(Jbe_rel8_64) [191h:jmp64]                        encoding(2 bytes) = 76 15
017ch movzx eax,byte ptr [rax+0Fh]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 0f
0180h shl eax,0Fh                   ; SHL(Shl_rm32_imm8) [EAX,fh:imm8]                     encoding(3 bytes) = c1 e0 0f
0183h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0186h or [rdx],ax                   ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 02
0189h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
018ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0190h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0191h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375350h:jmp64]                encoding(5 bytes) = e8 ba 51 37 5f
0196h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16x1Bytes => new byte[407]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x83,0xF9,0x00,0x0F,0x86,0x7D,0x01,0x00,0x00,0x44,0x0F,0xB6,0x00,0x66,0x44,0x09,0x02,0x83,0xF9,0x01,0x0F,0x86,0x6C,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x01,0x41,0xD1,0xE0,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x02,0x0F,0x86,0x53,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x02,0x41,0xC1,0xE0,0x02,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x03,0x0F,0x86,0x39,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x03,0x41,0xC1,0xE0,0x03,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x04,0x0F,0x86,0x1F,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x04,0x41,0xC1,0xE0,0x04,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x05,0x0F,0x86,0x05,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x05,0x41,0xC1,0xE0,0x05,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x06,0x0F,0x86,0xEB,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x06,0x41,0xC1,0xE0,0x06,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x07,0x0F,0x86,0xD1,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x07,0x41,0xC1,0xE0,0x07,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x08,0x0F,0x86,0xB7,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x08,0x41,0xC1,0xE0,0x08,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x09,0x0F,0x86,0x9D,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x09,0x41,0xC1,0xE0,0x09,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0A,0x0F,0x86,0x83,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x0A,0x41,0xC1,0xE0,0x0A,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0B,0x76,0x6D,0x44,0x0F,0xB6,0x40,0x0B,0x41,0xC1,0xE0,0x0B,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0C,0x76,0x57,0x44,0x0F,0xB6,0x40,0x0C,0x41,0xC1,0xE0,0x0C,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0D,0x76,0x41,0x44,0x0F,0xB6,0x40,0x0D,0x41,0xC1,0xE0,0x0D,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0E,0x76,0x2B,0x44,0x0F,0xB6,0x40,0x0E,0x41,0xC1,0xE0,0x0E,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0F,0x76,0x15,0x0F,0xB6,0x40,0x0F,0xC1,0xE0,0x0F,0x0F,0xB7,0xC0,0x66,0x09,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xBA,0x51,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, ulong mask)
; location: [7FFDDBEB9D60h, 7FFDDBEB9D6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(byte src, BitMask8:byte spec)
; location: [7FFDDBEB9D80h, 7FFDDBEB9D93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort select(ushort src, BitMask16:ushort spec)
; location: [7FFDDBEB9DB0h, 7FFDDBEB9DC3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, BitMask32:uint spec)
; location: [7FFDDBEB9DE0h, 7FFDDBEB9DEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, BitMask64:ulong spec)
; location: [7FFDDBEB9E00h, 7FFDDBEB9E0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x16(uint src, Span<ushort> dst)
; location: [7FFDDBEB9E20h, 7FFDDBEB9E76h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 0051h               ; JBE(Jbe_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 76 41
0010h mov r8d,0FFFFh                ; MOV(Mov_r32_imm32) [R8D,ffffh:imm32]                 encoding(6 bytes) = 41 b8 ff ff 00 00
0016h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001bh mov r9d,0FFFFh                ; MOV(Mov_r32_imm32) [R9D,ffffh:imm32]                 encoding(6 bytes) = 41 b9 ff ff 00 00
0021h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0026h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
002ah mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
002eh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0031h jbe short 0051h               ; JBE(Jbe_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 76 1e
0033h add rax,2                     ; ADD(Add_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 c0 02
0037h mov edx,0FFFF0000h            ; MOV(Mov_r32_imm32) [EDX,ffff0000h:imm32]             encoding(5 bytes) = ba 00 00 ff ff
003ch pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0041h pdep edx,edx,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R9D]            encoding(VEX, 5 bytes) = c4 c2 6b f5 d1
0046h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0049h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
004ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0051h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3750E0h:jmp64]                encoding(5 bytes) = e8 8a 50 37 5f
0056h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x16Bytes => new byte[87]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x41,0x41,0xB8,0xFF,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0xFF,0xFF,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x89,0x00,0x83,0xFA,0x01,0x76,0x1E,0x48,0x83,0xC0,0x02,0xBA,0x00,0x00,0xFF,0xFF,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB7,0xD2,0x66,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8A,0x50,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x16:uint part)
; location: [7FFDDBEB9E90h, 7FFDDBEB9E9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x16:uint part)
; location: [7FFDDBEB9EB0h, 7FFDDBEB9EBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort pack16x1(Span<byte> src, ref ushort dst)
; location: [7FFDDBEB9ED0h, 7FFDDBEB9F66h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0008h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
000bh mov r9d,[rcx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 08
000fh cmp r9,8                      ; CMP(Cmp_rm64_imm8) [R9,8h:imm64]                     encoding(4 bytes) = 49 83 f9 08
0013h jb short 0085h                ; JB(Jb_rel8_64) [85h:jmp64]                           encoding(2 bytes) = 72 70
0015h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001bh cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
001fh jbe short 0091h               ; JBE(Jbe_rel8_64) [91h:jmp64]                         encoding(2 bytes) = 76 70
0021h mov r8,[r8]                   ; MOV(Mov_r64_rm64) [R8,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 00
0024h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
002eh pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
0033h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0037h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
003ah mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
003dh movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0040h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0043h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
0046h cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
004ah jb short 008bh                ; JB(Jb_rel8_64) [8Bh:jmp64]                           encoding(2 bytes) = 72 3f
004ch add r8,8                      ; ADD(Add_rm64_imm8) [R8,8h:imm64]                     encoding(4 bytes) = 49 83 c0 08
0050h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0055h cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
0058h jbe short 0091h               ; JBE(Jbe_rel8_64) [91h:jmp64]                         encoding(2 bytes) = 76 37
005ah mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 08
005dh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0067h pext rcx,rcx,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f2 f5 c8
006ch shl rcx,8                     ; SHL(Shl_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e1 08
0070h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0073h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0075h mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
0078h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
007bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
007fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0080h call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F374E80h:jmp64]                encoding(5 bytes) = e8 fb 4d 37 5f
0085h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759B90h:jmp64]        encoding(5 bytes) = e8 06 9b 75 ff
008ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
008bh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759B90h:jmp64]        encoding(5 bytes) = e8 00 9b 75 ff
0090h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0091h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F375030h:jmp64]                encoding(5 bytes) = e8 9a 4f 37 5f
0096h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16x1Bytes => new byte[151]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0x02,0x4C,0x8B,0x01,0x44,0x8B,0x49,0x08,0x49,0x83,0xF9,0x08,0x72,0x70,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x76,0x70,0x4D,0x8B,0x00,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBA,0xF5,0xC1,0x45,0x0F,0xB7,0xC0,0x41,0x0B,0xC0,0x66,0x89,0x02,0x0F,0xB7,0x02,0x4C,0x8B,0x01,0x8B,0x49,0x08,0x48,0x83,0xF9,0x10,0x72,0x3F,0x49,0x83,0xC0,0x08,0xB9,0x01,0x00,0x00,0x00,0x83,0xF9,0x00,0x76,0x37,0x49,0x8B,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0xC1,0xE1,0x08,0x0F,0xB7,0xC9,0x0B,0xC1,0x66,0x89,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFB,0x4D,0x37,0x5F,0xE8,0x06,0x9B,0x75,0xFF,0xCC,0xE8,0x00,0x9B,0x75,0xFF,0xCC,0xE8,0x9A,0x4F,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack32x1(Span<byte> src, ref uint dst)
; location: [7FFDDBEB9F80h, 7FFDDBEBA08Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
000eh mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0010h cmp rcx,8                     ; CMP(Cmp_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 f9 08
0014h jb near ptr 00f2h             ; JB(Jb_rel32_64) [F2h:jmp64]                          encoding(6 bytes) = 0f 82 d8 00 00 00
001ah mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0020h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
0024h jbe near ptr 010ah            ; JBE(Jbe_rel32_64) [10Ah:jmp64]                       encoding(6 bytes) = 0f 86 e0 00 00 00
002ah mov r9,[rax]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 08
002dh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0037h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
003ch or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
003fh mov [rdx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 02
0042h mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
0045h cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
0049h jb near ptr 00f8h             ; JB(Jb_rel32_64) [F8h:jmp64]                          encoding(6 bytes) = 0f 82 a9 00 00 00
004fh lea r9,[rax+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 08
0053h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0059h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
005dh jbe near ptr 010ah            ; JBE(Jbe_rel32_64) [10Ah:jmp64]                       encoding(6 bytes) = 0f 86 a7 00 00 00
0063h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0066h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0070h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0075h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
0079h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
007ch mov [rdx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 02
007fh mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
0082h cmp rcx,18h                   ; CMP(Cmp_rm64_imm8) [RCX,18h:imm64]                   encoding(4 bytes) = 48 83 f9 18
0086h jb short 00feh                ; JB(Jb_rel8_64) [FEh:jmp64]                           encoding(2 bytes) = 72 76
0088h lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 10
008ch mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0092h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
0096h jbe short 010ah               ; JBE(Jbe_rel8_64) [10Ah:jmp64]                        encoding(2 bytes) = 76 72
0098h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
009bh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00a5h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
00aah shl r9d,10h                   ; SHL(Shl_rm32_imm8) [R9D,10h:imm8]                    encoding(4 bytes) = 41 c1 e1 10
00aeh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00b1h mov [rdx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 02
00b4h mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
00b7h cmp rcx,20h                   ; CMP(Cmp_rm64_imm8) [RCX,20h:imm64]                   encoding(4 bytes) = 48 83 f9 20
00bbh jb short 0104h                ; JB(Jb_rel8_64) [104h:jmp64]                          encoding(2 bytes) = 72 47
00bdh add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
00c1h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
00c6h cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
00c9h jbe short 010ah               ; JBE(Jbe_rel8_64) [10Ah:jmp64]                        encoding(2 bytes) = 76 3f
00cbh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00ceh mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
00d8h pext rax,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c1
00ddh shl eax,18h                   ; SHL(Shl_rm32_imm8) [EAX,18h:imm8]                    encoding(3 bytes) = c1 e0 18
00e0h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
00e3h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
00e5h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
00e8h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00ech ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00edh call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F374DD0h:jmp64]                encoding(5 bytes) = e8 de 4c 37 5f
00f2h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759AE0h:jmp64]        encoding(5 bytes) = e8 e9 99 75 ff
00f7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00f8h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759AE0h:jmp64]        encoding(5 bytes) = e8 e3 99 75 ff
00fdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00feh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759AE0h:jmp64]        encoding(5 bytes) = e8 dd 99 75 ff
0103h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0104h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759AE0h:jmp64]        encoding(5 bytes) = e8 d7 99 75 ff
0109h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
010ah call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F374F80h:jmp64]                encoding(5 bytes) = e8 71 4e 37 5f
010fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack32x1Bytes => new byte[272]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x44,0x8B,0x02,0x8B,0xC9,0x48,0x83,0xF9,0x08,0x0F,0x82,0xD8,0x00,0x00,0x00,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0xE0,0x00,0x00,0x00,0x4C,0x8B,0x08,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x45,0x0B,0xC1,0x44,0x89,0x02,0x44,0x8B,0x02,0x48,0x83,0xF9,0x10,0x0F,0x82,0xA9,0x00,0x00,0x00,0x4C,0x8D,0x48,0x08,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0xA7,0x00,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x41,0xC1,0xE1,0x08,0x45,0x0B,0xC1,0x44,0x89,0x02,0x44,0x8B,0x02,0x48,0x83,0xF9,0x18,0x72,0x76,0x4C,0x8D,0x48,0x10,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x76,0x72,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x41,0xC1,0xE1,0x10,0x45,0x0B,0xC1,0x44,0x89,0x02,0x44,0x8B,0x02,0x48,0x83,0xF9,0x20,0x72,0x47,0x48,0x83,0xC0,0x18,0xB9,0x01,0x00,0x00,0x00,0x83,0xF9,0x00,0x76,0x3F,0x48,0x8B,0x00,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xFA,0xF5,0xC1,0xC1,0xE0,0x18,0x41,0x0B,0xC0,0x89,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xDE,0x4C,0x37,0x5F,0xE8,0xE9,0x99,0x75,0xFF,0xCC,0xE8,0xE3,0x99,0x75,0xFF,0xCC,0xE8,0xDD,0x99,0x75,0xFF,0xCC,0xE8,0xD7,0x99,0x75,0xFF,0xCC,0xE8,0x71,0x4E,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong pack64x1(Span<byte> src, ref ulong dst)
; location: [7FFDDBEBA0B0h, 7FFDDBEBA2D5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
000eh mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0010h cmp rcx,8                     ; CMP(Cmp_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 f9 08
0014h jb near ptr 01f0h             ; JB(Jb_rel32_64) [1F0h:jmp64]                         encoding(6 bytes) = 0f 82 d6 01 00 00
001ah mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0020h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
0024h jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 f6 01 00 00
002ah mov r9,[rax]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 08
002dh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0037h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
003ch or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
003fh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
0042h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0045h cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
0049h jb near ptr 01f6h             ; JB(Jb_rel32_64) [1F6h:jmp64]                         encoding(6 bytes) = 0f 82 a7 01 00 00
004fh lea r9,[rax+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 08
0053h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0059h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
005dh jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 bd 01 00 00
0063h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0066h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0070h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0075h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
0079h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
007ch mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
007fh mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0082h cmp rcx,18h                   ; CMP(Cmp_rm64_imm8) [RCX,18h:imm64]                   encoding(4 bytes) = 48 83 f9 18
0086h jb near ptr 01fch             ; JB(Jb_rel32_64) [1FCh:jmp64]                         encoding(6 bytes) = 0f 82 70 01 00 00
008ch lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 10
0090h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0096h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
009ah jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 80 01 00 00
00a0h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
00a3h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00adh pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
00b2h shl r9,10h                    ; SHL(Shl_rm64_imm8) [R9,10h:imm8]                     encoding(4 bytes) = 49 c1 e1 10
00b6h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
00b9h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
00bch mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
00bfh cmp rcx,20h                   ; CMP(Cmp_rm64_imm8) [RCX,20h:imm64]                   encoding(4 bytes) = 48 83 f9 20
00c3h jb near ptr 0202h             ; JB(Jb_rel32_64) [202h:jmp64]                         encoding(6 bytes) = 0f 82 39 01 00 00
00c9h lea r9,[rax+18h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 18
00cdh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
00d3h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
00d7h jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 43 01 00 00
00ddh mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
00e0h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00eah pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
00efh shl r9,18h                    ; SHL(Shl_rm64_imm8) [R9,18h:imm8]                     encoding(4 bytes) = 49 c1 e1 18
00f3h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
00f6h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
00f9h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
00fch cmp rcx,28h                   ; CMP(Cmp_rm64_imm8) [RCX,28h:imm64]                   encoding(4 bytes) = 48 83 f9 28
0100h jb near ptr 0208h             ; JB(Jb_rel32_64) [208h:jmp64]                         encoding(6 bytes) = 0f 82 02 01 00 00
0106h lea r9,[rax+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 20
010ah mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0110h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
0114h jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 06 01 00 00
011ah mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
011dh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0127h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
012ch shl r9,20h                    ; SHL(Shl_rm64_imm8) [R9,20h:imm8]                     encoding(4 bytes) = 49 c1 e1 20
0130h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0133h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
0136h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0139h cmp rcx,30h                   ; CMP(Cmp_rm64_imm8) [RCX,30h:imm64]                   encoding(4 bytes) = 48 83 f9 30
013dh jb near ptr 020eh             ; JB(Jb_rel32_64) [20Eh:jmp64]                         encoding(6 bytes) = 0f 82 cb 00 00 00
0143h lea r9,[rax+28h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 28
0147h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
014dh cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
0151h jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 c9 00 00 00
0157h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
015ah mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0164h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0169h shl r9,28h                    ; SHL(Shl_rm64_imm8) [R9,28h:imm8]                     encoding(4 bytes) = 49 c1 e1 28
016dh or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0170h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
0173h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0176h cmp rcx,38h                   ; CMP(Cmp_rm64_imm8) [RCX,38h:imm64]                   encoding(4 bytes) = 48 83 f9 38
017ah jb near ptr 0214h             ; JB(Jb_rel32_64) [214h:jmp64]                         encoding(6 bytes) = 0f 82 94 00 00 00
0180h lea r9,[rax+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 30
0184h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
018ah cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
018eh jbe near ptr 0220h            ; JBE(Jbe_rel32_64) [220h:jmp64]                       encoding(6 bytes) = 0f 86 8c 00 00 00
0194h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0197h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
01a1h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
01a6h shl r9,30h                    ; SHL(Shl_rm64_imm8) [R9,30h:imm8]                     encoding(4 bytes) = 49 c1 e1 30
01aah or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
01adh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
01b0h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
01b3h cmp rcx,40h                   ; CMP(Cmp_rm64_imm8) [RCX,40h:imm64]                   encoding(4 bytes) = 48 83 f9 40
01b7h jb short 021ah                ; JB(Jb_rel8_64) [21Ah:jmp64]                          encoding(2 bytes) = 72 61
01b9h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
01bdh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
01c2h cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
01c5h jbe short 0220h               ; JBE(Jbe_rel8_64) [220h:jmp64]                        encoding(2 bytes) = 76 59
01c7h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
01cah mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
01d4h pext rax,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c1
01d9h shl rax,38h                   ; SHL(Shl_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e0 38
01ddh or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
01e0h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
01e3h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
01e6h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
01eah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
01ebh call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F374CA0h:jmp64]                encoding(5 bytes) = e8 b0 4a 37 5f
01f0h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 bb 97 75 ff
01f5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01f6h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 b5 97 75 ff
01fbh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01fch call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 af 97 75 ff
0201h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0202h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 a9 97 75 ff
0207h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0208h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 a3 97 75 ff
020dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
020eh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 9d 97 75 ff
0213h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0214h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 97 97 75 ff
0219h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
021ah call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7599B0h:jmp64]        encoding(5 bytes) = e8 91 97 75 ff
021fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0220h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F374E50h:jmp64]                encoding(5 bytes) = e8 2b 4c 37 5f
0225h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack64x1Bytes => new byte[550]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x4C,0x8B,0x02,0x8B,0xC9,0x48,0x83,0xF9,0x08,0x0F,0x82,0xD6,0x01,0x00,0x00,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0xF6,0x01,0x00,0x00,0x4C,0x8B,0x08,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x10,0x0F,0x82,0xA7,0x01,0x00,0x00,0x4C,0x8D,0x48,0x08,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0xBD,0x01,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x08,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x18,0x0F,0x82,0x70,0x01,0x00,0x00,0x4C,0x8D,0x48,0x10,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0x80,0x01,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x10,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x20,0x0F,0x82,0x39,0x01,0x00,0x00,0x4C,0x8D,0x48,0x18,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0x43,0x01,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x18,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x28,0x0F,0x82,0x02,0x01,0x00,0x00,0x4C,0x8D,0x48,0x20,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0x06,0x01,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x20,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x30,0x0F,0x82,0xCB,0x00,0x00,0x00,0x4C,0x8D,0x48,0x28,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0xC9,0x00,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x28,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x38,0x0F,0x82,0x94,0x00,0x00,0x00,0x4C,0x8D,0x48,0x30,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0x8C,0x00,0x00,0x00,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x30,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x40,0x72,0x61,0x48,0x83,0xC0,0x38,0xB9,0x01,0x00,0x00,0x00,0x83,0xF9,0x00,0x76,0x59,0x48,0x8B,0x00,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xFA,0xF5,0xC1,0x48,0xC1,0xE0,0x38,0x49,0x0B,0xC0,0x48,0x89,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB0,0x4A,0x37,0x5F,0xE8,0xBB,0x97,0x75,0xFF,0xCC,0xE8,0xB5,0x97,0x75,0xFF,0xCC,0xE8,0xAF,0x97,0x75,0xFF,0xCC,0xE8,0xA9,0x97,0x75,0xFF,0xCC,0xE8,0xA3,0x97,0x75,0xFF,0xCC,0xE8,0x9D,0x97,0x75,0xFF,0xCC,0xE8,0x97,0x97,0x75,0xFF,0xCC,0xE8,0x91,0x97,0x75,0xFF,0xCC,0xE8,0x2B,0x4C,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> unpack8x1(byte src)
; location: [7FFDDBEBA2F0h, 7FFDDBEBA331h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
000bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0011h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0018h ja short 003ch                ; JA(Ja_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 77 22
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh mov rdx,2CFF96E5655h          ; MOV(Mov_r64_imm64) [RDX,2cff96e5655h:imm64]          encoding(10 bytes) = 48 ba 55 56 6e f9 cf 02 00 00
0027h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
002ah mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
002dh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,DS:sr),8h:imm32] encoding(7 bytes) = c7 41 08 08 00 00 00
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ch call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759770h:jmp64]        encoding(5 bytes) = e8 2f 97 75 ff
0041h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[66]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x8B,0xD0,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x22,0x48,0x63,0xC0,0x48,0xBA,0x55,0x56,0x6E,0xF9,0xCF,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x2F,0x97,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack8x1(byte src, Span<byte> dst)
; location: [7FFDDBEBA750h, 7FFDDBEBA7A6h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0008h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000bh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0015h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
001ah call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF7432A8h:jmp64]        encoding(5 bytes) = e8 89 32 74 ff
001fh mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
0022h mov edx,[rsi+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 56 08
0025h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0028h jne short 0032h               ; JNE(Jne_rel8_64) [32h:jmp64]                         encoding(2 bytes) = 75 08
002ah xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
002dh xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0030h jmp short 003ah               ; JMP(Jmp_rel8_64) [3Ah:jmp64]                         encoding(2 bytes) = eb 08
0032h lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 10
0036h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
003ah cmp r9d,edx                   ; CMP(Cmp_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 3b ca
003dh ja short 0051h                ; JA(Ja_rel8_64) [51h:jmp64]                           encoding(2 bytes) = 77 12
003fh mov rdx,r8                    ; MOV(Mov_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 8b d0
0042h movsxd r8,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R9D]                     encoding(3 bytes) = 4d 63 c1
0045h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE7B0h:jmp64]                encoding(5 bytes) = e8 66 e7 0e 54
004ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
004bh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
004fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0051h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759318h:jmp64]        encoding(5 bytes) = e8 c2 92 75 ff
0056h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[87]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF2,0x0F,0xB6,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x89,0x32,0x74,0xFF,0x48,0x8B,0x0E,0x8B,0x56,0x08,0x48,0x85,0xC0,0x75,0x08,0x45,0x33,0xC0,0x45,0x33,0xC9,0xEB,0x08,0x4C,0x8D,0x40,0x10,0x44,0x8B,0x48,0x08,0x44,0x3B,0xCA,0x77,0x12,0x49,0x8B,0xD0,0x4D,0x63,0xC1,0xE8,0x66,0xE7,0x0E,0x54,0x90,0x48,0x83,0xC4,0x20,0x5E,0xC3,0xE8,0xC2,0x92,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack16x1(ushort src, Span<byte> dst)
; location: [7FFDDBEBA7C0h, 7FFDDBEBA8B4h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0005h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0006h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0007h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0008h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0012h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0016h mov byte ptr [rsp+28h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 28 00
001bh mov byte ptr [rsp+29h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 29 00
0020h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
0023h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0026h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
002ah movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
002dh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0030h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0033h mov [rsp+29h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 29
0037h movsx rcx,word ptr [rsp+28h]  ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 28
003dh mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
0042h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
0046h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0049h mov eax,[rsp+31h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 31
004dh movzx ebp,al                  ; MOVZX(Movzx_r32_rm8) [EBP,AL]                        encoding(4 bytes) = 40 0f b6 e8
0051h mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0053h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
005dh pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
0062h call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF743238h:jmp64]        encoding(5 bytes) = e8 d1 31 74 ff
0067h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
006ah jne short 0072h               ; JNE(Jne_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 75 06
006ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006eh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0070h jmp short 0079h               ; JMP(Jmp_rel8_64) [79h:jmp64]                         encoding(2 bytes) = eb 07
0072h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0076h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0079h cmp ecx,ebx                   ; CMP(Cmp_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 3b cb
007bh ja short 00e3h                ; JA(Ja_rel8_64) [E3h:jmp64]                           encoding(2 bytes) = 77 66
007dh movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0080h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0083h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE740h:jmp64]                encoding(5 bytes) = e8 b8 e6 0e 54
0088h cmp ebx,8                     ; CMP(Cmp_rm32_imm8) [EBX,8h:imm32]                    encoding(3 bytes) = 83 fb 08
008bh jb short 00e9h                ; JB(Jb_rel8_64) [E9h:jmp64]                           encoding(2 bytes) = 72 5c
008dh lea r14d,[rbx-8]              ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f8
0091h lea r15,[rdi+8]               ; LEA(Lea_r64_m) [R15,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 4c 8d 7f 08
0095h mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
0097h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00a1h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
00a6h call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF743238h:jmp64]        encoding(5 bytes) = e8 8d 31 74 ff
00abh test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
00aeh jne short 00b6h               ; JNE(Jne_rel8_64) [B6h:jmp64]                         encoding(2 bytes) = 75 06
00b0h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00b2h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00b4h jmp short 00bdh               ; JMP(Jmp_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = eb 07
00b6h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
00bah mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
00bdh cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
00c0h ja short 00efh                ; JA(Ja_rel8_64) [EFh:jmp64]                           encoding(2 bytes) = 77 2d
00c2h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
00c5h mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
00c8h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE740h:jmp64]                encoding(5 bytes) = e8 73 e6 0e 54
00cdh mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
00d0h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
00d3h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00d6h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00dah pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00dbh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00dch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00ddh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00deh pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00e0h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00e2h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00e3h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF7592A8h:jmp64]        encoding(5 bytes) = e8 c0 91 75 ff
00e8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00e9h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF7592A0h:jmp64]        encoding(5 bytes) = e8 b2 91 75 ff
00eeh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00efh call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF7592A8h:jmp64]        encoding(5 bytes) = e8 b4 91 75 ff
00f4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[245]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x38,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0xC6,0x44,0x24,0x28,0x00,0xC6,0x44,0x24,0x29,0x00,0x0F,0xB7,0xCA,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB7,0xCA,0xC1,0xF9,0x08,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x29,0x48,0x0F,0xBF,0x4C,0x24,0x28,0x66,0x89,0x4C,0x24,0x30,0x8B,0x4C,0x24,0x30,0x0F,0xB6,0xC9,0x8B,0x44,0x24,0x31,0x40,0x0F,0xB6,0xE8,0x8B,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0xD1,0x31,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x3B,0xCB,0x77,0x66,0x4C,0x63,0xC1,0x48,0x8B,0xCF,0xE8,0xB8,0xE6,0x0E,0x54,0x83,0xFB,0x08,0x72,0x5C,0x44,0x8D,0x73,0xF8,0x4C,0x8D,0x7F,0x08,0x8B,0xCD,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x8D,0x31,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x77,0x2D,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0x73,0xE6,0x0E,0x54,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x38,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0xC0,0x91,0x75,0xFF,0xCC,0xE8,0xB2,0x91,0x75,0xFF,0xCC,0xE8,0xB4,0x91,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack16x1(ushort src)
; location: [7FFDDBEBA8E0h, 7FFDDBEBA9EFh]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0005h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0006h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0007h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0008h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
0011h mov rcx,7FFDDB5CEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb5cea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 5c db fd 7f 00 00
001bh mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
0020h call 7FFE3B1045E0h            ; CALL(Call_rel32_64) [5F249D00h:jmp64]                encoding(5 bytes) = e8 db 9c 24 5f
0025h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0029h mov ebx,10h                   ; MOV(Mov_r32_imm32) [EBX,10h:imm32]                   encoding(5 bytes) = bb 10 00 00 00
002eh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0031h mov byte ptr [rsp+28h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 28 00
0036h mov byte ptr [rsp+29h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 29 00
003bh movzx ecx,di                  ; MOVZX(Movzx_r32_rm16) [ECX,DI]                       encoding(3 bytes) = 0f b7 cf
003eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0041h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
0045h movzx ecx,di                  ; MOVZX(Movzx_r32_rm16) [ECX,DI]                       encoding(3 bytes) = 0f b7 cf
0048h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
004bh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004eh mov [rsp+29h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 29
0052h movsx rcx,word ptr [rsp+28h]  ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 28
0058h mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
005dh mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
0061h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0064h mov eax,[rsp+31h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 31
0068h movzx edi,al                  ; MOVZX(Movzx_r32_rm8) [EDI,AL]                        encoding(4 bytes) = 40 0f b6 f8
006ch mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
006eh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0078h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
007dh call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF743118h:jmp64]        encoding(5 bytes) = e8 96 30 74 ff
0082h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0085h jne short 008dh               ; JNE(Jne_rel8_64) [8Dh:jmp64]                         encoding(2 bytes) = 75 06
0087h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0089h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
008bh jmp short 0094h               ; JMP(Jmp_rel8_64) [94h:jmp64]                         encoding(2 bytes) = eb 07
008dh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0091h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0094h cmp ecx,ebx                   ; CMP(Cmp_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 3b cb
0096h ja short 00feh                ; JA(Ja_rel8_64) [FEh:jmp64]                           encoding(2 bytes) = 77 66
0098h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
009bh mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
009eh call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE620h:jmp64]                encoding(5 bytes) = e8 7d e5 0e 54
00a3h cmp ebx,8                     ; CMP(Cmp_rm32_imm8) [EBX,8h:imm32]                    encoding(3 bytes) = 83 fb 08
00a6h jb short 0104h                ; JB(Jb_rel8_64) [104h:jmp64]                          encoding(2 bytes) = 72 5c
00a8h lea r14d,[rbx-8]              ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f8
00ach lea r15,[rbp+8]               ; LEA(Lea_r64_m) [R15,mem(Unknown,RBP:br,SS:sr)]       encoding(4 bytes) = 4c 8d 7d 08
00b0h mov ecx,edi                   ; MOV(Mov_r32_rm32) [ECX,EDI]                          encoding(2 bytes) = 8b cf
00b2h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00bch pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
00c1h call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF743118h:jmp64]        encoding(5 bytes) = e8 52 30 74 ff
00c6h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
00c9h jne short 00d1h               ; JNE(Jne_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = 75 06
00cbh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00cdh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00cfh jmp short 00d8h               ; JMP(Jmp_rel8_64) [D8h:jmp64]                         encoding(2 bytes) = eb 07
00d1h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
00d5h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
00d8h cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
00dbh ja short 010ah                ; JA(Ja_rel8_64) [10Ah:jmp64]                          encoding(2 bytes) = 77 2d
00ddh movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
00e0h mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
00e3h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE620h:jmp64]                encoding(5 bytes) = e8 38 e5 0e 54
00e8h mov [rsi],rbp                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RBP]        encoding(3 bytes) = 48 89 2e
00ebh mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
00eeh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00f1h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00f5h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00f6h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00f7h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00f8h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00f9h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00fbh pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00fdh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00feh call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759188h:jmp64]        encoding(5 bytes) = e8 85 90 75 ff
0103h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0104h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759180h:jmp64]        encoding(5 bytes) = e8 77 90 75 ff
0109h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
010ah call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759188h:jmp64]        encoding(5 bytes) = e8 79 90 75 ff
010fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[272]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x38,0x48,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0x5C,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0xDB,0x9C,0x24,0x5F,0x48,0x83,0xC0,0x10,0xBB,0x10,0x00,0x00,0x00,0x48,0x8B,0xE8,0xC6,0x44,0x24,0x28,0x00,0xC6,0x44,0x24,0x29,0x00,0x0F,0xB7,0xCF,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB7,0xCF,0xC1,0xF9,0x08,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x29,0x48,0x0F,0xBF,0x4C,0x24,0x28,0x66,0x89,0x4C,0x24,0x30,0x8B,0x4C,0x24,0x30,0x0F,0xB6,0xC9,0x8B,0x44,0x24,0x31,0x40,0x0F,0xB6,0xF8,0x8B,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x96,0x30,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x3B,0xCB,0x77,0x66,0x4C,0x63,0xC1,0x48,0x8B,0xCD,0xE8,0x7D,0xE5,0x0E,0x54,0x83,0xFB,0x08,0x72,0x5C,0x44,0x8D,0x73,0xF8,0x4C,0x8D,0x7D,0x08,0x8B,0xCF,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x52,0x30,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x77,0x2D,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0x38,0xE5,0x0E,0x54,0x48,0x89,0x2E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x38,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x85,0x90,0x75,0xFF,0xCC,0xE8,0x77,0x90,0x75,0xFF,0xCC,0xE8,0x79,0x90,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack32x1(uint src, Span<byte> dst)
; location: [7FFDDBEBAA10h, 7FFDDBEBABD4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,[rdx]                 ; MOV(Mov_r64_rm64) [RSI,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 32
000bh mov edi,[rdx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 7a 08
000eh call 7FFDDB5FD9E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF742FD8h:jmp64]        encoding(5 bytes) = e8 c5 2f 74 ff
0013h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0016h mov ebp,[rbx+8]               ; MOV(Mov_r32_rm32) [EBP,mem(32u,RBX:br,DS:sr)]        encoding(3 bytes) = 8b 6b 08
0019h cmp ebp,0                     ; CMP(Cmp_rm32_imm8) [EBP,0h:imm32]                    encoding(3 bytes) = 83 fd 00
001ch jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 9d 01 00 00
0022h movzx ecx,byte ptr [rbx+10h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 10
0026h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0029h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
002bh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
002fh cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0036h ja near ptr 0177h             ; JA(Ja_rel32_64) [177h:jmp64]                         encoding(6 bytes) = 0f 87 3b 01 00 00
003ch movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
003fh mov rcx,2CFF96E5655h          ; MOV(Mov_r64_imm64) [RCX,2cff96e5655h:imm64]          encoding(10 bytes) = 48 b9 55 56 6e f9 cf 02 00 00
0049h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
004ch test edi,edi                  ; TEST(Test_rm32_r32) [EDI,EDI]                        encoding(2 bytes) = 85 ff
004eh jb near ptr 017dh             ; JB(Jb_rel32_64) [17Dh:jmp64]                         encoding(6 bytes) = 0f 82 29 01 00 00
0054h cmp edi,8                     ; CMP(Cmp_rm32_imm8) [EDI,8h:imm32]                    encoding(3 bytes) = 83 ff 08
0057h jb near ptr 0183h             ; JB(Jb_rel32_64) [183h:jmp64]                         encoding(6 bytes) = 0f 82 26 01 00 00
005dh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0060h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
0066h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE4F0h:jmp64]                encoding(5 bytes) = e8 85 e4 0e 54
006bh cmp ebp,1                     ; CMP(Cmp_rm32_imm8) [EBP,1h:imm32]                    encoding(3 bytes) = 83 fd 01
006eh jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 4b 01 00 00
0074h movzx ecx,byte ptr [rbx+11h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 11
0078h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
007bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
007dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0081h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0088h ja near ptr 0189h             ; JA(Ja_rel32_64) [189h:jmp64]                         encoding(6 bytes) = 0f 87 fb 00 00 00
008eh movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0091h mov rcx,2CFF96E5655h          ; MOV(Mov_r64_imm64) [RCX,2cff96e5655h:imm64]          encoding(10 bytes) = 48 b9 55 56 6e f9 cf 02 00 00
009bh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
009eh cmp edi,8                     ; CMP(Cmp_rm32_imm8) [EDI,8h:imm32]                    encoding(3 bytes) = 83 ff 08
00a1h jb near ptr 018fh             ; JB(Jb_rel32_64) [18Fh:jmp64]                         encoding(6 bytes) = 0f 82 e8 00 00 00
00a7h lea ecx,[rdi-8]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDI:br,DS:sr)]       encoding(3 bytes) = 8d 4f f8
00aah lea r8,[rsi+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RSI:br,DS:sr)]        encoding(4 bytes) = 4c 8d 46 08
00aeh cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
00b1h jb near ptr 0195h             ; JB(Jb_rel32_64) [195h:jmp64]                         encoding(6 bytes) = 0f 82 de 00 00 00
00b7h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
00bah mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
00c0h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE4F0h:jmp64]                encoding(5 bytes) = e8 2b e4 0e 54
00c5h cmp ebp,2                     ; CMP(Cmp_rm32_imm8) [EBP,2h:imm32]                    encoding(3 bytes) = 83 fd 02
00c8h jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 f1 00 00 00
00ceh movzx ecx,byte ptr [rbx+12h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 12
00d2h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
00d5h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00d7h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
00dbh cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
00e2h ja near ptr 019bh             ; JA(Ja_rel32_64) [19Bh:jmp64]                         encoding(6 bytes) = 0f 87 b3 00 00 00
00e8h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
00ebh mov rcx,2CFF96E5655h          ; MOV(Mov_r64_imm64) [RCX,2cff96e5655h:imm64]          encoding(10 bytes) = 48 b9 55 56 6e f9 cf 02 00 00
00f5h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
00f8h cmp edi,10h                   ; CMP(Cmp_rm32_imm8) [EDI,10h:imm32]                   encoding(3 bytes) = 83 ff 10
00fbh jb near ptr 01a1h             ; JB(Jb_rel32_64) [1A1h:jmp64]                         encoding(6 bytes) = 0f 82 a0 00 00 00
0101h lea ecx,[rdi-10h]             ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDI:br,DS:sr)]       encoding(3 bytes) = 8d 4f f0
0104h lea r8,[rsi+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSI:br,DS:sr)]        encoding(4 bytes) = 4c 8d 46 10
0108h cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
010bh jb near ptr 01a7h             ; JB(Jb_rel32_64) [1A7h:jmp64]                         encoding(6 bytes) = 0f 82 96 00 00 00
0111h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0114h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
011ah call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE4F0h:jmp64]                encoding(5 bytes) = e8 d1 e3 0e 54
011fh cmp ebp,3                     ; CMP(Cmp_rm32_imm8) [EBP,3h:imm32]                    encoding(3 bytes) = 83 fd 03
0122h jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 97 00 00 00
0128h movzx ecx,byte ptr [rbx+13h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 13
012ch shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
012fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0131h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0135h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
013ch ja short 01adh                ; JA(Ja_rel8_64) [1ADh:jmp64]                          encoding(2 bytes) = 77 6f
013eh movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0141h mov rcx,2CFF96E5655h          ; MOV(Mov_r64_imm64) [RCX,2cff96e5655h:imm64]          encoding(10 bytes) = 48 b9 55 56 6e f9 cf 02 00 00
014bh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
014eh cmp edi,18h                   ; CMP(Cmp_rm32_imm8) [EDI,18h:imm32]                   encoding(3 bytes) = 83 ff 18
0151h jb short 01b3h                ; JB(Jb_rel8_64) [1B3h:jmp64]                          encoding(2 bytes) = 72 60
0153h add edi,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EDI,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c7 e8
0156h add rsi,18h                   ; ADD(Add_rm64_imm8) [RSI,18h:imm64]                   encoding(4 bytes) = 48 83 c6 18
015ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
015dh cmp edi,8                     ; CMP(Cmp_rm32_imm8) [EDI,8h:imm32]                    encoding(3 bytes) = 83 ff 08
0160h jb short 01b9h                ; JB(Jb_rel8_64) [1B9h:jmp64]                          encoding(2 bytes) = 72 57
0162h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
0168h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE4F0h:jmp64]                encoding(5 bytes) = e8 83 e3 0e 54
016dh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
016eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0172h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0173h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0174h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0175h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0176h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0177h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 d4 8e 75 ff
017ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
017dh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 ce 8e 75 ff
0182h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0183h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759058h:jmp64]        encoding(5 bytes) = e8 d0 8e 75 ff
0188h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0189h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 c2 8e 75 ff
018eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
018fh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 bc 8e 75 ff
0194h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0195h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759058h:jmp64]        encoding(5 bytes) = e8 be 8e 75 ff
019ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
019bh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 b0 8e 75 ff
01a0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01a1h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 aa 8e 75 ff
01a6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01a7h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759058h:jmp64]        encoding(5 bytes) = e8 ac 8e 75 ff
01ach int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01adh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 9e 8e 75 ff
01b2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b3h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF759050h:jmp64]        encoding(5 bytes) = e8 98 8e 75 ff
01b8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b9h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF759058h:jmp64]        encoding(5 bytes) = e8 9a 8e 75 ff
01beh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01bfh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3744F0h:jmp64]                encoding(5 bytes) = e8 2c 43 37 5f
01c4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1Bytes => new byte[453]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0x32,0x8B,0x7A,0x08,0xE8,0xC5,0x2F,0x74,0xFF,0x48,0x8B,0xD8,0x8B,0x6B,0x08,0x83,0xFD,0x00,0x0F,0x86,0x9D,0x01,0x00,0x00,0x0F,0xB6,0x4B,0x10,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x0F,0x87,0x3B,0x01,0x00,0x00,0x48,0x63,0xD1,0x48,0xB9,0x55,0x56,0x6E,0xF9,0xCF,0x02,0x00,0x00,0x48,0x03,0xD1,0x85,0xFF,0x0F,0x82,0x29,0x01,0x00,0x00,0x83,0xFF,0x08,0x0F,0x82,0x26,0x01,0x00,0x00,0x48,0x8B,0xCE,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x85,0xE4,0x0E,0x54,0x83,0xFD,0x01,0x0F,0x86,0x4B,0x01,0x00,0x00,0x0F,0xB6,0x4B,0x11,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x0F,0x87,0xFB,0x00,0x00,0x00,0x48,0x63,0xD1,0x48,0xB9,0x55,0x56,0x6E,0xF9,0xCF,0x02,0x00,0x00,0x48,0x03,0xD1,0x83,0xFF,0x08,0x0F,0x82,0xE8,0x00,0x00,0x00,0x8D,0x4F,0xF8,0x4C,0x8D,0x46,0x08,0x83,0xF9,0x08,0x0F,0x82,0xDE,0x00,0x00,0x00,0x49,0x8B,0xC8,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x2B,0xE4,0x0E,0x54,0x83,0xFD,0x02,0x0F,0x86,0xF1,0x00,0x00,0x00,0x0F,0xB6,0x4B,0x12,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x0F,0x87,0xB3,0x00,0x00,0x00,0x48,0x63,0xD1,0x48,0xB9,0x55,0x56,0x6E,0xF9,0xCF,0x02,0x00,0x00,0x48,0x03,0xD1,0x83,0xFF,0x10,0x0F,0x82,0xA0,0x00,0x00,0x00,0x8D,0x4F,0xF0,0x4C,0x8D,0x46,0x10,0x83,0xF9,0x08,0x0F,0x82,0x96,0x00,0x00,0x00,0x49,0x8B,0xC8,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0xD1,0xE3,0x0E,0x54,0x83,0xFD,0x03,0x0F,0x86,0x97,0x00,0x00,0x00,0x0F,0xB6,0x4B,0x13,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x6F,0x48,0x63,0xD1,0x48,0xB9,0x55,0x56,0x6E,0xF9,0xCF,0x02,0x00,0x00,0x48,0x03,0xD1,0x83,0xFF,0x18,0x72,0x60,0x83,0xC7,0xE8,0x48,0x83,0xC6,0x18,0x48,0x8B,0xCE,0x83,0xFF,0x08,0x72,0x57,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x83,0xE3,0x0E,0x54,0x90,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0xD4,0x8E,0x75,0xFF,0xCC,0xE8,0xCE,0x8E,0x75,0xFF,0xCC,0xE8,0xD0,0x8E,0x75,0xFF,0xCC,0xE8,0xC2,0x8E,0x75,0xFF,0xCC,0xE8,0xBC,0x8E,0x75,0xFF,0xCC,0xE8,0xBE,0x8E,0x75,0xFF,0xCC,0xE8,0xB0,0x8E,0x75,0xFF,0xCC,0xE8,0xAA,0x8E,0x75,0xFF,0xCC,0xE8,0xAC,0x8E,0x75,0xFF,0xCC,0xE8,0x9E,0x8E,0x75,0xFF,0xCC,0xE8,0x98,0x8E,0x75,0xFF,0xCC,0xE8,0x9A,0x8E,0x75,0xFF,0xCC,0xE8,0x2C,0x43,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack32x1_bmi(uint src, Span<byte> dst)
; location: [7FFDDBEBAC00h, 7FFDDBEBAE50h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r13                      ; PUSH(Push_r64) [R13]                                 encoding(2 bytes) = 41 55
0006h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0008h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0009h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
000ah push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
000bh push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ch sub rsp,78h                   ; SUB(Sub_rm64_imm8) [RSP,78h:imm64]                   encoding(4 bytes) = 48 83 ec 78
0010h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0012h mov [rsp+60h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 60
0017h mov [rsp+68h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 68
001ch mov [rsp+50h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 50
0021h mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 58
0026h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0029h mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
002ch mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0030h mov word ptr [rsp+48h],0      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,SS:sr),0h:imm16] encoding(7 bytes) = 66 c7 44 24 48 00 00
0037h mov word ptr [rsp+4Ah],0      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,SS:sr),0h:imm16] encoding(7 bytes) = 66 c7 44 24 4a 00 00
003eh movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
0041h mov [rsp+48h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 48
0046h shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0049h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
004ch mov [rsp+4Ah],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 4a
0051h mov ecx,[rsp+48h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 48
0055h mov [rsp+70h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 70
0059h mov ecx,[rsp+70h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 70
005dh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0060h mov eax,[rsp+72h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 72
0064h movzx ebp,ax                  ; MOVZX(Movzx_r32_rm16) [EBP,AX]                       encoding(3 bytes) = 0f b7 e8
0067h mov r14,rdi                   ; MOV(Mov_r64_rm64) [R14,RDI]                          encoding(3 bytes) = 4c 8b f7
006ah mov r15d,ebx                  ; MOV(Mov_r32_rm32) [R15D,EBX]                         encoding(3 bytes) = 44 8b fb
006dh mov byte ptr [rsp+38h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 38 00
0072h mov byte ptr [rsp+39h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 39 00
0077h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
007ah mov [rsp+38h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 38
007eh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0081h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0084h mov [rsp+39h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 39
0088h movsx rcx,word ptr [rsp+38h]  ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 38
008eh mov [rsp+40h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 40
0093h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 40
0097h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
009ah mov eax,[rsp+41h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 41
009eh movzx r12d,al                 ; MOVZX(Movzx_r32_rm8) [R12D,AL]                       encoding(4 bytes) = 44 0f b6 e0
00a2h mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
00a4h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00aeh pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
00b3h call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF742DF8h:jmp64]        encoding(5 bytes) = e8 40 2d 74 ff
00b8h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
00bbh jne short 00c3h               ; JNE(Jne_rel8_64) [C3h:jmp64]                         encoding(2 bytes) = 75 06
00bdh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00bfh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00c1h jmp short 00cah               ; JMP(Jmp_rel8_64) [CAh:jmp64]                         encoding(2 bytes) = eb 07
00c3h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
00c7h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
00cah cmp ecx,r15d                  ; CMP(Cmp_r32_rm32) [ECX,R15D]                         encoding(3 bytes) = 41 3b cf
00cdh ja near ptr 0227h             ; JA(Ja_rel32_64) [227h:jmp64]                         encoding(6 bytes) = 0f 87 54 01 00 00
00d3h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
00d6h mov rcx,r14                   ; MOV(Mov_r64_rm64) [RCX,R14]                          encoding(3 bytes) = 49 8b ce
00d9h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE300h:jmp64]                encoding(5 bytes) = e8 22 e2 0e 54
00deh cmp ebx,8                     ; CMP(Cmp_rm32_imm8) [EBX,8h:imm32]                    encoding(3 bytes) = 83 fb 08
00e1h jb near ptr 022dh             ; JB(Jb_rel32_64) [22Dh:jmp64]                         encoding(6 bytes) = 0f 82 46 01 00 00
00e7h lea r14d,[rbx-8]              ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f8
00ebh lea r15,[rdi+8]               ; LEA(Lea_r64_m) [R15,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 4c 8d 7f 08
00efh mov ecx,r12d                  ; MOV(Mov_r32_rm32) [ECX,R12D]                         encoding(3 bytes) = 41 8b cc
00f2h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00fch pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
0101h call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF742DF8h:jmp64]        encoding(5 bytes) = e8 f2 2c 74 ff
0106h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0109h jne short 0111h               ; JNE(Jne_rel8_64) [111h:jmp64]                        encoding(2 bytes) = 75 06
010bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
010dh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
010fh jmp short 0118h               ; JMP(Jmp_rel8_64) [118h:jmp64]                        encoding(2 bytes) = eb 07
0111h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0115h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0118h cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
011bh ja near ptr 0233h             ; JA(Ja_rel32_64) [233h:jmp64]                         encoding(6 bytes) = 0f 87 12 01 00 00
0121h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0124h mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
0127h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE300h:jmp64]                encoding(5 bytes) = e8 d4 e1 0e 54
012ch mov [rsp+60h],rdi             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDI]        encoding(5 bytes) = 48 89 7c 24 60
0131h mov [rsp+68h],ebx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EBX]        encoding(4 bytes) = 89 5c 24 68
0135h cmp ebx,10h                   ; CMP(Cmp_rm32_imm8) [EBX,10h:imm32]                   encoding(3 bytes) = 83 fb 10
0138h jb near ptr 0239h             ; JB(Jb_rel32_64) [239h:jmp64]                         encoding(6 bytes) = 0f 82 fb 00 00 00
013eh lea r14d,[rbx-10h]            ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f0
0142h lea r15,[rdi+10h]             ; LEA(Lea_r64_m) [R15,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 4c 8d 7f 10
0146h mov byte ptr [rsp+28h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 28 00
014bh mov byte ptr [rsp+29h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 29 00
0150h movzx ecx,bpl                 ; MOVZX(Movzx_r32_rm8) [ECX,BPL]                       encoding(4 bytes) = 40 0f b6 cd
0154h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
0158h sar ebp,8                     ; SAR(Sar_rm32_imm8) [EBP,8h:imm8]                     encoding(3 bytes) = c1 fd 08
015bh movzx ecx,bpl                 ; MOVZX(Movzx_r32_rm8) [ECX,BPL]                       encoding(4 bytes) = 40 0f b6 cd
015fh mov [rsp+29h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 29
0163h movsx rcx,word ptr [rsp+28h]  ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 28
0169h mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
016eh mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
0172h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0175h mov eax,[rsp+31h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 31
0179h movzx ebp,al                  ; MOVZX(Movzx_r32_rm8) [EBP,AL]                        encoding(4 bytes) = 40 0f b6 e8
017dh mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
017fh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0189h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
018eh call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF742DF8h:jmp64]        encoding(5 bytes) = e8 65 2c 74 ff
0193h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0196h jne short 019eh               ; JNE(Jne_rel8_64) [19Eh:jmp64]                        encoding(2 bytes) = 75 06
0198h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
019ah xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
019ch jmp short 01a5h               ; JMP(Jmp_rel8_64) [1A5h:jmp64]                        encoding(2 bytes) = eb 07
019eh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
01a2h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
01a5h cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
01a8h ja near ptr 023fh             ; JA(Ja_rel32_64) [23Fh:jmp64]                         encoding(6 bytes) = 0f 87 91 00 00 00
01aeh movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
01b1h mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
01b4h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE300h:jmp64]                encoding(5 bytes) = e8 47 e1 0e 54
01b9h cmp r14d,8                    ; CMP(Cmp_rm32_imm8) [R14D,8h:imm32]                   encoding(4 bytes) = 41 83 fe 08
01bdh jb near ptr 0245h             ; JB(Jb_rel32_64) [245h:jmp64]                         encoding(6 bytes) = 0f 82 82 00 00 00
01c3h lea r12d,[r14-8]              ; LEA(Lea_r32_m) [R12D,mem(Unknown,R14:br,DS:sr)]      encoding(4 bytes) = 45 8d 66 f8
01c7h lea r13,[r15+8]               ; LEA(Lea_r64_m) [R13,mem(Unknown,R15:br,DS:sr)]       encoding(4 bytes) = 4d 8d 6f 08
01cbh mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
01cdh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
01d7h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
01dch call 7FFDDB5FD9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF742DF8h:jmp64]        encoding(5 bytes) = e8 17 2c 74 ff
01e1h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
01e4h jne short 01ech               ; JNE(Jne_rel8_64) [1ECh:jmp64]                        encoding(2 bytes) = 75 06
01e6h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
01e8h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
01eah jmp short 01f3h               ; JMP(Jmp_rel8_64) [1F3h:jmp64]                        encoding(2 bytes) = eb 07
01ech lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
01f0h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
01f3h cmp ecx,r12d                  ; CMP(Cmp_r32_rm32) [ECX,R12D]                         encoding(3 bytes) = 41 3b cc
01f6h ja short 024bh                ; JA(Ja_rel8_64) [24Bh:jmp64]                          encoding(2 bytes) = 77 53
01f8h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
01fbh mov rcx,r13                   ; MOV(Mov_r64_rm64) [RCX,R13]                          encoding(3 bytes) = 49 8b cd
01feh call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EE300h:jmp64]                encoding(5 bytes) = e8 fd e0 0e 54
0203h mov [rsp+50h],r15             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R15]        encoding(5 bytes) = 4c 89 7c 24 50
0208h mov [rsp+58h],r14d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R14D]       encoding(5 bytes) = 44 89 74 24 58
020dh mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
0210h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
0213h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0216h add rsp,78h                   ; ADD(Add_rm64_imm8) [RSP,78h:imm64]                   encoding(4 bytes) = 48 83 c4 78
021ah pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
021bh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
021ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
021dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
021eh pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
0220h pop r13                       ; POP(Pop_r64) [R13]                                   encoding(2 bytes) = 41 5d
0222h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0224h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
0226h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0227h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E68h:jmp64]        encoding(5 bytes) = e8 3c 8c 75 ff
022ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
022dh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E60h:jmp64]        encoding(5 bytes) = e8 2e 8c 75 ff
0232h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0233h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E68h:jmp64]        encoding(5 bytes) = e8 30 8c 75 ff
0238h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0239h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E60h:jmp64]        encoding(5 bytes) = e8 22 8c 75 ff
023eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
023fh call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E68h:jmp64]        encoding(5 bytes) = e8 24 8c 75 ff
0244h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0245h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E60h:jmp64]        encoding(5 bytes) = e8 16 8c 75 ff
024ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
024bh call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF758E68h:jmp64]        encoding(5 bytes) = e8 18 8c 75 ff
0250h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1_bmiBytes => new byte[593]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x78,0x33,0xC0,0x48,0x89,0x44,0x24,0x60,0x48,0x89,0x44,0x24,0x68,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x58,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x66,0xC7,0x44,0x24,0x48,0x00,0x00,0x66,0xC7,0x44,0x24,0x4A,0x00,0x00,0x0F,0xB7,0xCA,0x66,0x89,0x4C,0x24,0x48,0xC1,0xEA,0x10,0x0F,0xB7,0xCA,0x66,0x89,0x4C,0x24,0x4A,0x8B,0x4C,0x24,0x48,0x89,0x4C,0x24,0x70,0x8B,0x4C,0x24,0x70,0x0F,0xB7,0xC9,0x8B,0x44,0x24,0x72,0x0F,0xB7,0xE8,0x4C,0x8B,0xF7,0x44,0x8B,0xFB,0xC6,0x44,0x24,0x38,0x00,0xC6,0x44,0x24,0x39,0x00,0x0F,0xB6,0xC1,0x88,0x44,0x24,0x38,0xC1,0xF9,0x08,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x39,0x48,0x0F,0xBF,0x4C,0x24,0x38,0x66,0x89,0x4C,0x24,0x40,0x8B,0x4C,0x24,0x40,0x0F,0xB6,0xC9,0x8B,0x44,0x24,0x41,0x44,0x0F,0xB6,0xE0,0x8B,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x40,0x2D,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCF,0x0F,0x87,0x54,0x01,0x00,0x00,0x4C,0x63,0xC1,0x49,0x8B,0xCE,0xE8,0x22,0xE2,0x0E,0x54,0x83,0xFB,0x08,0x0F,0x82,0x46,0x01,0x00,0x00,0x44,0x8D,0x73,0xF8,0x4C,0x8D,0x7F,0x08,0x41,0x8B,0xCC,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0xF2,0x2C,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x0F,0x87,0x12,0x01,0x00,0x00,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0xD4,0xE1,0x0E,0x54,0x48,0x89,0x7C,0x24,0x60,0x89,0x5C,0x24,0x68,0x83,0xFB,0x10,0x0F,0x82,0xFB,0x00,0x00,0x00,0x44,0x8D,0x73,0xF0,0x4C,0x8D,0x7F,0x10,0xC6,0x44,0x24,0x28,0x00,0xC6,0x44,0x24,0x29,0x00,0x40,0x0F,0xB6,0xCD,0x88,0x4C,0x24,0x28,0xC1,0xFD,0x08,0x40,0x0F,0xB6,0xCD,0x88,0x4C,0x24,0x29,0x48,0x0F,0xBF,0x4C,0x24,0x28,0x66,0x89,0x4C,0x24,0x30,0x8B,0x4C,0x24,0x30,0x0F,0xB6,0xC9,0x8B,0x44,0x24,0x31,0x40,0x0F,0xB6,0xE8,0x8B,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x65,0x2C,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x0F,0x87,0x91,0x00,0x00,0x00,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0x47,0xE1,0x0E,0x54,0x41,0x83,0xFE,0x08,0x0F,0x82,0x82,0x00,0x00,0x00,0x45,0x8D,0x66,0xF8,0x4D,0x8D,0x6F,0x08,0x8B,0xCD,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x17,0x2C,0x74,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCC,0x77,0x53,0x4C,0x63,0xC1,0x49,0x8B,0xCD,0xE8,0xFD,0xE0,0x0E,0x54,0x4C,0x89,0x7C,0x24,0x50,0x44,0x89,0x74,0x24,0x58,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x78,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5D,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x3C,0x8C,0x75,0xFF,0xCC,0xE8,0x2E,0x8C,0x75,0xFF,0xCC,0xE8,0x30,0x8C,0x75,0xFF,0xCC,0xE8,0x22,0x8C,0x75,0xFF,0xCC,0xE8,0x24,0x8C,0x75,0xFF,0xCC,0xE8,0x16,0x8C,0x75,0xFF,0xCC,0xE8,0x18,0x8C,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack64x1(ulong src, Span<byte> dst)
; location: [7FFDDBEBAE80h, 7FFDDBEBAF2Dh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh lea rdi,[rsp+28h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 28
0010h mov ecx,0Eh                   ; MOV(Mov_r32_imm32) [ECX,eh:imm32]                    encoding(5 bytes) = b9 0e 00 00 00
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0019h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
001fh mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0022h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0026h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0028h mov [rsp+38h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 38
002ch mov [rsp+3Ch],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 3c
0030h mov [rsp+38h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 38
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
003ah mov [rsp+3Ch],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 3c
003eh mov rcx,[rsp+38h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 38
0043h mov [rsp+60h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 60
0048h mov ebp,[rsp+64h]             ; MOV(Mov_r32_rm32) [EBP,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 6c 24 64
004ch lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 50
0051h mov edx,[rsp+60h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 60
0055h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
005ah mov [r8],rdi                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RDI]         encoding(3 bytes) = 49 89 38
005dh mov [r8+8],ebx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EBX]         encoding(4 bytes) = 41 89 58 08
0061h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0066h call 7FFDDBEBAC00h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFD80h:jmp64]        encoding(5 bytes) = e8 15 fd ff ff
006bh cmp ebx,20h                   ; CMP(Cmp_rm32_imm8) [EBX,20h:imm32]                   encoding(3 bytes) = 83 fb 20
006eh jb short 00a8h                ; JB(Jb_rel8_64) [A8h:jmp64]                           encoding(2 bytes) = 72 38
0070h lea ecx,[rbx-20h]             ; LEA(Lea_r32_m) [ECX,mem(Unknown,RBX:br,DS:sr)]       encoding(3 bytes) = 8d 4b e0
0073h lea rdx,[rdi+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 48 8d 57 20
0077h lea r8,[rsp+40h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 40
007ch lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0081h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0084h mov [rax+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(3 bytes) = 89 48 08
0087h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
008ah mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
008ch lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0091h call 7FFDDBEBAC00h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFD80h:jmp64]        encoding(5 bytes) = e8 ea fc ff ff
0096h mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
0099h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
009ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
009fh add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
00a3h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a4h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00a5h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a6h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a8h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF758BE0h:jmp64]        encoding(5 bytes) = e8 33 8b 75 ff
00adh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack64x1Bytes => new byte[174]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x68,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x28,0xB9,0x0E,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x33,0xC9,0x89,0x4C,0x24,0x38,0x89,0x4C,0x24,0x3C,0x89,0x54,0x24,0x38,0x48,0xC1,0xEA,0x20,0x8B,0xCA,0x89,0x4C,0x24,0x3C,0x48,0x8B,0x4C,0x24,0x38,0x48,0x89,0x4C,0x24,0x60,0x8B,0x6C,0x24,0x64,0x48,0x8D,0x4C,0x24,0x50,0x8B,0x54,0x24,0x60,0x4C,0x8D,0x44,0x24,0x28,0x49,0x89,0x38,0x41,0x89,0x58,0x08,0x4C,0x8D,0x44,0x24,0x28,0xE8,0x15,0xFD,0xFF,0xFF,0x83,0xFB,0x20,0x72,0x38,0x8D,0x4B,0xE0,0x48,0x8D,0x57,0x20,0x4C,0x8D,0x44,0x24,0x40,0x48,0x8D,0x44,0x24,0x28,0x48,0x89,0x10,0x89,0x48,0x08,0x49,0x8B,0xC8,0x8B,0xD5,0x4C,0x8D,0x44,0x24,0x28,0xE8,0xEA,0xFC,0xFF,0xFF,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x68,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x33,0x8B,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack8x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDBEBAF50h, 7FFDDBEBAFFBh]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0006h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0007h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0008h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0009h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ah sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
000eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0011h mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0014h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0018h mov rbp,[rdx]                 ; MOV(Mov_r64_rm64) [RBP,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 2a
001bh mov r14d,[rdx+8]              ; MOV(Mov_r32_rm32) [R14D,mem(32u,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8b 72 08
001fh xor r15d,r15d                 ; XOR(Xor_r32_rm32) [R15D,R15D]                        encoding(3 bytes) = 45 33 ff
0022h xor r12d,r12d                 ; XOR(Xor_r32_rm32) [R12D,R12D]                        encoding(3 bytes) = 45 33 e4
0025h test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0028h jle short 0082h               ; JLE(Jle_rel8_64) [82h:jmp64]                         encoding(2 bytes) = 7e 58
002ah movsxd rcx,r12d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R12D]                   encoding(3 bytes) = 49 63 cc
002dh movzx ecx,byte ptr [rcx+rbp]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,DS:sr)]      encoding(4 bytes) = 0f b6 0c 29
0031h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0034h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0036h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
003ah cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0041h ja short 009ah                ; JA(Ja_rel8_64) [9Ah:jmp64]                           encoding(2 bytes) = 77 57
0043h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0046h mov rcx,2CFF96E5655h          ; MOV(Mov_r64_imm64) [RCX,2cff96e5655h:imm64]          encoding(10 bytes) = 48 b9 55 56 6e f9 cf 02 00 00
0050h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0053h cmp r15d,ebx                  ; CMP(Cmp_r32_rm32) [R15D,EBX]                         encoding(3 bytes) = 44 3b fb
0056h ja short 00a0h                ; JA(Ja_rel8_64) [A0h:jmp64]                           encoding(2 bytes) = 77 48
0058h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
005ah sub ecx,r15d                  ; SUB(Sub_r32_rm32) [ECX,R15D]                         encoding(3 bytes) = 41 2b cf
005dh movsxd r8,r15d                ; MOVSXD(Movsxd_r64_rm32) [R8,R15D]                    encoding(3 bytes) = 4d 63 c7
0060h add r8,rdi                    ; ADD(Add_r64_rm64) [R8,RDI]                           encoding(3 bytes) = 4c 03 c7
0063h cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
0066h jb short 00a6h                ; JB(Jb_rel8_64) [A6h:jmp64]                           encoding(2 bytes) = 72 3e
0068h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
006bh mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
0071h call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [540EDFB0h:jmp64]                encoding(5 bytes) = e8 3a df 0e 54
0076h inc r12d                      ; INC(Inc_rm32) [R12D]                                 encoding(3 bytes) = 41 ff c4
0079h add r15d,8                    ; ADD(Add_rm32_imm8) [R15D,8h:imm32]                   encoding(4 bytes) = 41 83 c7 08
007dh cmp r12d,r14d                 ; CMP(Cmp_r32_rm32) [R12D,R14D]                        encoding(3 bytes) = 45 3b e6
0080h jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c a8
0082h mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
0085h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
0088h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
008bh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
008fh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0090h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0091h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0092h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0093h pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
0095h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0097h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
0099h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
009ah call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF758B10h:jmp64]        encoding(5 bytes) = e8 71 8a 75 ff
009fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00a0h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF758B10h:jmp64]        encoding(5 bytes) = e8 6b 8a 75 ff
00a5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00a6h call 7FFDDB613A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF758B18h:jmp64]        encoding(5 bytes) = e8 6d 8a 75 ff
00abh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[172]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x48,0x8B,0x2A,0x44,0x8B,0x72,0x08,0x45,0x33,0xFF,0x45,0x33,0xE4,0x45,0x85,0xF6,0x7E,0x58,0x49,0x63,0xCC,0x0F,0xB6,0x0C,0x29,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x57,0x48,0x63,0xD1,0x48,0xB9,0x55,0x56,0x6E,0xF9,0xCF,0x02,0x00,0x00,0x48,0x03,0xD1,0x44,0x3B,0xFB,0x77,0x48,0x8B,0xCB,0x41,0x2B,0xCF,0x4D,0x63,0xC7,0x4C,0x03,0xC7,0x83,0xF9,0x08,0x72,0x3E,0x49,0x8B,0xC8,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x3A,0xDF,0x0E,0x54,0x41,0xFF,0xC4,0x41,0x83,0xC7,0x08,0x45,0x3B,0xE6,0x7C,0xA8,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x71,0x8A,0x75,0xFF,0xCC,0xE8,0x6B,0x8A,0x75,0xFF,0xCC,0xE8,0x6D,0x8A,0x75,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack16x1(ReadOnlySpan<ushort> src, Span<byte> dst)
; location: [7FFDDBEBB430h, 7FFDDBEBB474h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
0012h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0015h imul edx,2                    ; IMUL(Imul_r32_rm32_imm8) [EDX,EDX,2h:imm32]          encoding(3 bytes) = 6b d2 02
0018h jo short 003fh                ; JO(Jo_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 70 25
001ah mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001dh lea r9,[rsp+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 20
0022h mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 09
0025h mov [r9+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EDX]         encoding(4 bytes) = 41 89 51 08
0029h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
002ch lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0031h call 7FFDDBEBAF50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB20h:jmp64]        encoding(5 bytes) = e8 ea fa ff ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F373920h:jmp64]                encoding(5 bytes) = e8 dc 38 37 5f
0044h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[69]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x6B,0xD2,0x02,0x70,0x25,0x48,0x8B,0xC6,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x20,0xE8,0xEA,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xE8,0xDC,0x38,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack32x1(ReadOnlySpan<uint> src, Span<byte> dst)
; location: [7FFDDBEBB490h, 7FFDDBEBB4D4h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
0012h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0015h imul edx,4                    ; IMUL(Imul_r32_rm32_imm8) [EDX,EDX,4h:imm32]          encoding(3 bytes) = 6b d2 04
0018h jo short 003fh                ; JO(Jo_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 70 25
001ah mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001dh lea r9,[rsp+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 20
0022h mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 09
0025h mov [r9+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EDX]         encoding(4 bytes) = 41 89 51 08
0029h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
002ch lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0031h call 7FFDDBEBAF50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFAC0h:jmp64]        encoding(5 bytes) = e8 8a fa ff ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F3738C0h:jmp64]                encoding(5 bytes) = e8 7c 38 37 5f
0044h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1Bytes => new byte[69]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x6B,0xD2,0x04,0x70,0x25,0x48,0x8B,0xC6,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x20,0xE8,0x8A,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xE8,0x7C,0x38,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack64x1(ReadOnlySpan<ulong> src, Span<byte> dst)
; location: [7FFDDBEBB4F0h, 7FFDDBEBB534h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
0012h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0015h imul edx,8                    ; IMUL(Imul_r32_rm32_imm8) [EDX,EDX,8h:imm32]          encoding(3 bytes) = 6b d2 08
0018h jo short 003fh                ; JO(Jo_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 70 25
001ah mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001dh lea r9,[rsp+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 20
0022h mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 09
0025h mov [r9+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EDX]         encoding(4 bytes) = 41 89 51 08
0029h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
002ch lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0031h call 7FFDDBEBAF50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFA60h:jmp64]        encoding(5 bytes) = e8 2a fa ff ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F373860h:jmp64]                encoding(5 bytes) = e8 1c 38 37 5f
0044h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack64x1Bytes => new byte[69]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x6B,0xD2,0x08,0x70,0x25,0x48,0x8B,0xC6,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x20,0xE8,0x2A,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xE8,0x1C,0x38,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x1(byte src, Span<byte> dst)
; location: [7FFDDBEBB550h, 7FFDDBEBB650h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 00fbh            ; JBE(Jbe_rel32_64) [FBh:jmp64]                        encoding(6 bytes) = 0f 86 e7 00 00 00
0014h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0017h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001dh pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
002ch pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0031h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0035h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0038h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
003bh jbe near ptr 00fbh            ; JBE(Jbe_rel32_64) [FBh:jmp64]                        encoding(6 bytes) = 0f 86 ba 00 00 00
0041h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
0045h mov r9d,2                     ; MOV(Mov_r32_imm32) [R9D,2h:imm32]                    encoding(6 bytes) = 41 b9 02 00 00 00
004bh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0050h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0054h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
005ah pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
005fh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0063h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0066h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0069h jbe near ptr 00fbh            ; JBE(Jbe_rel32_64) [FBh:jmp64]                        encoding(6 bytes) = 0f 86 8c 00 00 00
006fh lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0073h mov r9d,4                     ; MOV(Mov_r32_imm32) [R9D,4h:imm32]                    encoding(6 bytes) = 41 b9 04 00 00 00
0079h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
007eh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0082h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0087h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
008bh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
008eh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0091h jbe short 00fbh               ; JBE(Jbe_rel8_64) [FBh:jmp64]                         encoding(2 bytes) = 76 68
0093h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
0097h mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
009dh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00a2h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a6h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00abh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00afh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00b2h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00b5h jbe short 00fbh               ; JBE(Jbe_rel8_64) [FBh:jmp64]                         encoding(2 bytes) = 76 44
00b7h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00bbh mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
00c1h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00c6h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00cah pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00cfh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00d3h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00d6h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00d9h jbe short 00fbh               ; JBE(Jbe_rel8_64) [FBh:jmp64]                         encoding(2 bytes) = 76 20
00dbh add rax,5                     ; ADD(Add_rm64_imm8) [RAX,5h:imm64]                    encoding(4 bytes) = 48 83 c0 05
00dfh mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
00e4h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
00e9h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00ech pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
00f1h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00f4h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
00f6h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00fah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00fbh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3739B0h:jmp64]                encoding(5 bytes) = e8 b0 38 37 5f
0100h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part6x1Bytes => new byte[257]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xE7,0x00,0x00,0x00,0x0F,0xB6,0xC9,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xBA,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x8C,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x68,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x44,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x20,0x48,0x83,0xC0,0x05,0xBA,0x20,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0x0F,0xB6,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB0,0x38,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part7x1(uint src, Span<byte> dst)
; location: [7FFDDBEBB670h, 7FFDDBEBB77Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 f1 00 00 00
0014h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 cb 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,2                     ; MOV(Mov_r32_imm32) [R9D,2h:imm32]                    encoding(6 bytes) = 41 b9 02 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,4                     ; MOV(Mov_r32_imm32) [R9D,4h:imm32]                    encoding(6 bytes) = 41 b9 04 00 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe short 0105h               ; JBE(Jbe_rel8_64) [105h:jmp64]                        encoding(2 bytes) = 76 5d
00a8h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00ach mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
00b2h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00b7h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00bch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c3h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00c6h jbe short 0105h               ; JBE(Jbe_rel8_64) [105h:jmp64]                        encoding(2 bytes) = 76 3d
00c8h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00cch mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
00d2h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00d7h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00dch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00e3h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00e6h jbe short 0105h               ; JBE(Jbe_rel8_64) [105h:jmp64]                        encoding(2 bytes) = 76 1d
00e8h add rax,6                     ; ADD(Add_rm64_imm8) [RAX,6h:imm64]                    encoding(4 bytes) = 48 83 c0 06
00ech mov edx,40h                   ; MOV(Mov_r32_imm32) [EDX,40h:imm32]                   encoding(5 bytes) = ba 40 00 00 00
00f1h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
00f6h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
00fbh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00feh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0100h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0104h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0105h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F373890h:jmp64]                encoding(5 bytes) = e8 86 37 37 5f
010ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part7x1Bytes => new byte[267]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xF1,0x00,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xCB,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x5D,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x3D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x1D,0x48,0x83,0xC0,0x06,0xBA,0x40,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x86,0x37,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x1(uint src, Span<byte> dst)
; location: [7FFDDBEBB790h, 7FFDDBEBB8BEh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 15 01 00 00
0014h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 ef 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,2                     ; MOV(Mov_r32_imm32) [R9D,2h:imm32]                    encoding(6 bytes) = 41 b9 02 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,4                     ; MOV(Mov_r32_imm32) [R9D,4h:imm32]                    encoding(6 bytes) = 41 b9 04 00 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 5d
00cch lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d0h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
00d6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00e7h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 3d
00ech lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f0h mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
00f6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00fbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0100h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0104h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0107h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
010ah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 1d
010ch add rax,7                     ; ADD(Add_rm64_imm8) [RAX,7h:imm64]                    encoding(4 bytes) = 48 83 c0 07
0110h mov edx,80h                   ; MOV(Mov_r32_imm32) [EDX,80h:imm32]                   encoding(5 bytes) = ba 80 00 00 00
0115h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
011ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
011fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0122h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0124h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0128h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0129h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F373770h:jmp64]                encoding(5 bytes) = e8 42 36 37 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part8x1Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x80,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x42,0x36,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part9x1(uint src, Span<byte> dst)
; location: [7FFDDBEBB8E0h, 7FFDDBEBBA32h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 39 01 00 00
0014h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 13 01 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,2                     ; MOV(Mov_r32_imm32) [R9D,2h:imm32]                    encoding(6 bytes) = 41 b9 02 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 e9 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,4                     ; MOV(Mov_r32_imm32) [R9D,4h:imm32]                    encoding(6 bytes) = 41 b9 04 00 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00d0h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d4h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
00dah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dfh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e4h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e8h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00ebh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eeh jbe short 014dh               ; JBE(Jbe_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = 76 5d
00f0h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f4h mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
00fah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00ffh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0104h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0108h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
010bh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
010eh jbe short 014dh               ; JBE(Jbe_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = 76 3d
0110h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 07
0114h mov r9d,80h                   ; MOV(Mov_r32_imm32) [R9D,80h:imm32]                   encoding(6 bytes) = 41 b9 80 00 00 00
011ah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
011fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0124h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0128h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
012bh cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
012eh jbe short 014dh               ; JBE(Jbe_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = 76 1d
0130h add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
0134h mov edx,100h                  ; MOV(Mov_r32_imm32) [EDX,100h:imm32]                  encoding(5 bytes) = ba 00 01 00 00
0139h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
013eh pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
0143h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0146h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0148h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
014ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
014dh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F373620h:jmp64]                encoding(5 bytes) = e8 ce 34 37 5f
0152h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part9x1Bytes => new byte[339]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x39,0x01,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x13,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x5D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x3D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x80,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x1D,0x48,0x83,0xC0,0x08,0xBA,0x00,0x01,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xCE,0x34,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part10x1(ushort src, Span<byte> dst)
; location: [7FFDDBEBBA50h, 7FFDDBEBBBC9h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 60 01 00 00
0014h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0017h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001dh pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0022h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0028h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0031h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0034h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0037h jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 37 01 00 00
003dh lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
0041h mov r9d,2                     ; MOV(Mov_r32_imm32) [R9D,2h:imm32]                    encoding(6 bytes) = 41 b9 02 00 00 00
0047h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
004ch mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0052h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0057h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
005bh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005eh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0061h jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 0d 01 00 00
0067h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
006bh mov r9d,4                     ; MOV(Mov_r32_imm32) [R9D,4h:imm32]                    encoding(6 bytes) = 41 b9 04 00 00 00
0071h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0076h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
007bh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007fh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0082h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0085h jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 e9 00 00 00
008bh lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008fh mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0095h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
009ah pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009fh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a3h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a6h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a9h jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
00afh lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b3h mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
00b9h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00beh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c3h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c7h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00cah cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cdh jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
00d3h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d7h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
00ddh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00e2h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e7h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00ebh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00eeh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00f1h jbe near ptr 0174h            ; JBE(Jbe_rel32_64) [174h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00f7h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00fbh mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
0101h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0106h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
010bh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
010fh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0112h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0115h jbe short 0174h               ; JBE(Jbe_rel8_64) [174h:jmp64]                        encoding(2 bytes) = 76 5d
0117h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 07
011bh mov r9d,80h                   ; MOV(Mov_r32_imm32) [R9D,80h:imm32]                   encoding(6 bytes) = 41 b9 80 00 00 00
0121h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0126h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
012bh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
012fh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0132h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0135h jbe short 0174h               ; JBE(Jbe_rel8_64) [174h:jmp64]                        encoding(2 bytes) = 76 3d
0137h lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 08
013bh mov r9d,100h                  ; MOV(Mov_r32_imm32) [R9D,100h:imm32]                  encoding(6 bytes) = 41 b9 00 01 00 00
0141h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0146h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
014bh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
014fh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0152h cmp edx,9                     ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]                    encoding(3 bytes) = 83 fa 09
0155h jbe short 0174h               ; JBE(Jbe_rel8_64) [174h:jmp64]                        encoding(2 bytes) = 76 1d
0157h add rax,9                     ; ADD(Add_rm64_imm8) [RAX,9h:imm64]                    encoding(4 bytes) = 48 83 c0 09
015bh mov edx,200h                  ; MOV(Mov_r32_imm32) [EDX,200h:imm32]                  encoding(5 bytes) = ba 00 02 00 00
0160h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0165h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
016ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
016dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
016fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0173h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0174h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3734B0h:jmp64]                encoding(5 bytes) = e8 37 33 37 5f
0179h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part10x1Bytes => new byte[378]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x60,0x01,0x00,0x00,0x0F,0xB7,0xC9,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x37,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x0D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x5D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x80,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x3D,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x09,0x76,0x1D,0x48,0x83,0xC0,0x09,0xBA,0x00,0x02,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x37,0x33,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong project8x64(byte src, ref ulong dst)
; location: [7FFDDBEBBBE0h, 7FFDDBEBBBFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0012h pdep rax,rax,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c1
0017h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
001ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> project8x64Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xFB,0xF5,0xC1,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x1(uint src, Span<byte> dst)
; location: [7FFDDBEBBC10h, 7FFDDBEBBD41h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh mov r8d,0FFh                  ; MOV(Mov_r32_imm32) [R8D,ffh:imm32]                   encoding(6 bytes) = 41 b8 ff 00 00 00
0011h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0016h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ah mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
001dh cmp r9,8                      ; CMP(Cmp_rm64_imm8) [R9,8h:imm64]                     encoding(4 bytes) = 49 83 f9 08
0021h jb near ptr 0114h             ; JB(Jb_rel32_64) [114h:jmp64]                         encoding(6 bytes) = 0f 82 ed 00 00 00
0027h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
002dh cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
0031h jbe near ptr 012ch            ; JBE(Jbe_rel32_64) [12Ch:jmp64]                       encoding(6 bytes) = 0f 86 f5 00 00 00
0037h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
003bh mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0045h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
004ah mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
004dh mov r8d,0FF00h                ; MOV(Mov_r32_imm32) [R8D,ff00h:imm32]                 encoding(6 bytes) = 41 b8 00 ff 00 00
0053h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0058h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
005ch mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
005fh cmp r9,10h                    ; CMP(Cmp_rm64_imm8) [R9,10h:imm64]                    encoding(4 bytes) = 49 83 f9 10
0063h jb near ptr 011ah             ; JB(Jb_rel32_64) [11Ah:jmp64]                         encoding(6 bytes) = 0f 82 b1 00 00 00
0069h lea r9,[rax+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 08
006dh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0073h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
0077h jbe near ptr 012ch            ; JBE(Jbe_rel32_64) [12Ch:jmp64]                       encoding(6 bytes) = 0f 86 af 00 00 00
007dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0081h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
008bh pdep r8,r8,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R10]              encoding(VEX, 5 bytes) = c4 42 bb f5 c2
0090h mov [r9],r8                   ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),R8]          encoding(3 bytes) = 4d 89 01
0093h mov r8d,0FF0000h              ; MOV(Mov_r32_imm32) [R8D,ff0000h:imm32]               encoding(6 bytes) = 41 b8 00 00 ff 00
0099h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
009eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00a2h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
00a5h cmp r9,18h                    ; CMP(Cmp_rm64_imm8) [R9,18h:imm64]                    encoding(4 bytes) = 49 83 f9 18
00a9h jb short 0120h                ; JB(Jb_rel8_64) [120h:jmp64]                          encoding(2 bytes) = 72 75
00abh lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 10
00afh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
00b5h cmp r10d,0                    ; CMP(Cmp_rm32_imm8) [R10D,0h:imm32]                   encoding(4 bytes) = 41 83 fa 00
00b9h jbe short 012ch               ; JBE(Jbe_rel8_64) [12Ch:jmp64]                        encoding(2 bytes) = 76 71
00bbh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00bfh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00c9h pdep r8,r8,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R10]              encoding(VEX, 5 bytes) = c4 42 bb f5 c2
00ceh mov [r9],r8                   ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),R8]          encoding(3 bytes) = 4d 89 01
00d1h mov r8d,0FF000000h            ; MOV(Mov_r32_imm32) [R8D,ff000000h:imm32]             encoding(6 bytes) = 41 b8 00 00 00 ff
00d7h pext ecx,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [ECX,ECX,R8D]            encoding(VEX, 5 bytes) = c4 c2 72 f5 c8
00dch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00dfh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
00e1h cmp rdx,20h                   ; CMP(Cmp_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 fa 20
00e5h jb short 0126h                ; JB(Jb_rel8_64) [126h:jmp64]                          encoding(2 bytes) = 72 3f
00e7h add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
00ebh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00f0h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
00f3h jbe short 012ch               ; JBE(Jbe_rel8_64) [12Ch:jmp64]                        encoding(2 bytes) = 76 37
00f5h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
00f8h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0102h pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0107h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
010ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
010eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
010fh call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F373140h:jmp64]                encoding(5 bytes) = e8 2c 30 37 5f
0114h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757E50h:jmp64]        encoding(5 bytes) = e8 37 7d 75 ff
0119h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
011ah call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757E50h:jmp64]        encoding(5 bytes) = e8 31 7d 75 ff
011fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0120h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757E50h:jmp64]        encoding(5 bytes) = e8 2b 7d 75 ff
0125h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0126h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757E50h:jmp64]        encoding(5 bytes) = e8 25 7d 75 ff
012bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
012ch call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3732F0h:jmp64]                encoding(5 bytes) = e8 bf 31 37 5f
0131h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x1Bytes => new byte[306]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x8B,0xCA,0x49,0x83,0xF9,0x08,0x0F,0x82,0xED,0x00,0x00,0x00,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0xF5,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x8B,0xCA,0x49,0x83,0xF9,0x10,0x0F,0x82,0xB1,0x00,0x00,0x00,0x4C,0x8D,0x48,0x08,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0xAF,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC2,0x4D,0x89,0x01,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x8B,0xCA,0x49,0x83,0xF9,0x18,0x72,0x75,0x4C,0x8D,0x48,0x10,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x76,0x71,0x45,0x0F,0xB6,0xC0,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC2,0x4D,0x89,0x01,0x41,0xB8,0x00,0x00,0x00,0xFF,0xC4,0xC2,0x72,0xF5,0xC8,0x0F,0xB6,0xC9,0x8B,0xD2,0x48,0x83,0xFA,0x20,0x72,0x3F,0x48,0x83,0xC0,0x18,0xBA,0x01,0x00,0x00,0x00,0x83,0xFA,0x00,0x76,0x37,0x0F,0xB6,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x2C,0x30,0x37,0x5F,0xE8,0x37,0x7D,0x75,0xFF,0xCC,0xE8,0x31,0x7D,0x75,0xFF,0xCC,0xE8,0x2B,0x7D,0x75,0xFF,0xCC,0xE8,0x25,0x7D,0x75,0xFF,0xCC,0xE8,0xBF,0x31,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, Span<byte> dst)
; location: [7FFDDBEBBD60h, 7FFDDBEBBFA3h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp rdx,8                     ; CMP(Cmp_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 fa 08
000fh jb near ptr 020eh             ; JB(Jb_rel32_64) [20Eh:jmp64]                         encoding(6 bytes) = 0f 82 f9 01 00 00
0015h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
001bh cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
001fh jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 19 02 00 00
0025h mov r8d,0FFh                  ; MOV(Mov_r32_imm32) [R8D,ffh:imm32]                   encoding(6 bytes) = 41 b8 ff 00 00 00
002bh pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0030h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0034h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
003eh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0043h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0046h cmp rdx,10h                   ; CMP(Cmp_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 fa 10
004ah jb near ptr 0214h             ; JB(Jb_rel32_64) [214h:jmp64]                         encoding(6 bytes) = 0f 82 c4 01 00 00
0050h lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 08
0054h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
005ah cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
005eh jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 da 01 00 00
0064h mov r9d,0FF00h                ; MOV(Mov_r32_imm32) [R9D,ff00h:imm32]                 encoding(6 bytes) = 41 b9 00 ff 00 00
006ah pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
006fh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0073h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
007dh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0082h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0085h cmp rdx,18h                   ; CMP(Cmp_rm64_imm8) [RDX,18h:imm64]                   encoding(4 bytes) = 48 83 fa 18
0089h jb near ptr 021ah             ; JB(Jb_rel32_64) [21Ah:jmp64]                         encoding(6 bytes) = 0f 82 8b 01 00 00
008fh lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 10
0093h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0099h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
009dh jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 9b 01 00 00
00a3h mov r9d,0FF0000h              ; MOV(Mov_r32_imm32) [R9D,ff0000h:imm32]               encoding(6 bytes) = 41 b9 00 00 ff 00
00a9h pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
00aeh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00b2h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00bch pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
00c1h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
00c4h cmp rdx,20h                   ; CMP(Cmp_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 fa 20
00c8h jb near ptr 0220h             ; JB(Jb_rel32_64) [220h:jmp64]                         encoding(6 bytes) = 0f 82 52 01 00 00
00ceh lea r8,[rax+18h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 18
00d2h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
00d8h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
00dch jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 5c 01 00 00
00e2h mov r9d,0FF000000h            ; MOV(Mov_r32_imm32) [R9D,ff000000h:imm32]             encoding(6 bytes) = 41 b9 00 00 00 ff
00e8h pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
00edh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00f1h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00fbh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0100h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0103h cmp rdx,28h                   ; CMP(Cmp_rm64_imm8) [RDX,28h:imm64]                   encoding(4 bytes) = 48 83 fa 28
0107h jb near ptr 0226h             ; JB(Jb_rel32_64) [226h:jmp64]                         encoding(6 bytes) = 0f 82 19 01 00 00
010dh lea r8,[rax+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 20
0111h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0117h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
011bh jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 1d 01 00 00
0121h mov r9,0FF00000000h           ; MOV(Mov_r64_imm64) [R9,ff00000000h:imm64]            encoding(10 bytes) = 49 b9 00 00 00 00 ff 00 00 00
012bh pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
0130h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0134h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
013eh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0143h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0146h cmp rdx,30h                   ; CMP(Cmp_rm64_imm8) [RDX,30h:imm64]                   encoding(4 bytes) = 48 83 fa 30
014ah jb near ptr 022ch             ; JB(Jb_rel32_64) [22Ch:jmp64]                         encoding(6 bytes) = 0f 82 dc 00 00 00
0150h lea r8,[rax+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 28
0154h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
015ah cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
015eh jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 da 00 00 00
0164h mov r9,0FF0000000000h         ; MOV(Mov_r64_imm64) [R9,ff0000000000h:imm64]          encoding(10 bytes) = 49 b9 00 00 00 00 00 ff 00 00
016eh pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
0173h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0177h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0181h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0186h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0189h cmp rdx,38h                   ; CMP(Cmp_rm64_imm8) [RDX,38h:imm64]                   encoding(4 bytes) = 48 83 fa 38
018dh jb near ptr 0232h             ; JB(Jb_rel32_64) [232h:jmp64]                         encoding(6 bytes) = 0f 82 9f 00 00 00
0193h lea r8,[rax+30h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 30
0197h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
019dh cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
01a1h jbe near ptr 023eh            ; JBE(Jbe_rel32_64) [23Eh:jmp64]                       encoding(6 bytes) = 0f 86 97 00 00 00
01a7h mov r9,0FF000000000000h       ; MOV(Mov_r64_imm64) [R9,ff000000000000h:imm64]        encoding(10 bytes) = 49 b9 00 00 00 00 00 00 ff 00
01b1h pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
01b6h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
01bah mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
01c4h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
01c9h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
01cch cmp rdx,40h                   ; CMP(Cmp_rm64_imm8) [RDX,40h:imm64]                   encoding(4 bytes) = 48 83 fa 40
01d0h jb short 0238h                ; JB(Jb_rel8_64) [238h:jmp64]                          encoding(2 bytes) = 72 66
01d2h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
01d6h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
01dbh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
01deh jbe short 023eh               ; JBE(Jbe_rel8_64) [23Eh:jmp64]                        encoding(2 bytes) = 76 5e
01e0h mov rdx,0FF00000000000000h    ; MOV(Mov_r64_imm64) [RDX,ff00000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 ff
01eah pext rdx,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 d2
01efh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
01f2h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
01fch pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0201h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0204h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0208h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0209h call 7FFE3B22ED50h            ; CALL(Call_rel32_64) [5F372FF0h:jmp64]                encoding(5 bytes) = e8 e2 2d 37 5f
020eh call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 ed 7a 75 ff
0213h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0214h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 e7 7a 75 ff
0219h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
021ah call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 e1 7a 75 ff
021fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0220h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 db 7a 75 ff
0225h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0226h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 d5 7a 75 ff
022bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
022ch call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 cf 7a 75 ff
0231h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0232h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 c9 7a 75 ff
0237h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0238h call 7FFDDB613A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF757D00h:jmp64]        encoding(5 bytes) = e8 c3 7a 75 ff
023dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
023eh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3731A0h:jmp64]                encoding(5 bytes) = e8 5d 2f 37 5f
0243h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1Bytes => new byte[580]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x83,0xFA,0x08,0x0F,0x82,0xF9,0x01,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x83,0xF8,0x00,0x0F,0x86,0x19,0x02,0x00,0x00,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x83,0xFA,0x10,0x0F,0x82,0xC4,0x01,0x00,0x00,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0xDA,0x01,0x00,0x00,0x41,0xB9,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x18,0x0F,0x82,0x8B,0x01,0x00,0x00,0x4C,0x8D,0x40,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0x9B,0x01,0x00,0x00,0x41,0xB9,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x20,0x0F,0x82,0x52,0x01,0x00,0x00,0x4C,0x8D,0x40,0x18,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0x5C,0x01,0x00,0x00,0x41,0xB9,0x00,0x00,0x00,0xFF,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x28,0x0F,0x82,0x19,0x01,0x00,0x00,0x4C,0x8D,0x40,0x20,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0x1D,0x01,0x00,0x00,0x49,0xB9,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x30,0x0F,0x82,0xDC,0x00,0x00,0x00,0x4C,0x8D,0x40,0x28,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0xDA,0x00,0x00,0x00,0x49,0xB9,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x38,0x0F,0x82,0x9F,0x00,0x00,0x00,0x4C,0x8D,0x40,0x30,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0x97,0x00,0x00,0x00,0x49,0xB9,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x40,0x72,0x66,0x48,0x83,0xC0,0x38,0xBA,0x01,0x00,0x00,0x00,0x83,0xFA,0x00,0x76,0x5E,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xC4,0xE2,0xF2,0xF5,0xD2,0x0F,0xB6,0xD2,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE2,0x2D,0x37,0x5F,0xE8,0xED,0x7A,0x75,0xFF,0xCC,0xE8,0xE7,0x7A,0x75,0xFF,0xCC,0xE8,0xE1,0x7A,0x75,0xFF,0xCC,0xE8,0xDB,0x7A,0x75,0xFF,0xCC,0xE8,0xD5,0x7A,0x75,0xFF,0xCC,0xE8,0xCF,0x7A,0x75,0xFF,0xCC,0xE8,0xC9,0x7A,0x75,0xFF,0xCC,0xE8,0xC3,0x7A,0x75,0xFF,0xCC,0xE8,0x5D,0x2F,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part1x1:uint part)
; location: [7FFDDBEBBFC0h, 7FFDDBEBBFCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part2x1:uint part)
; location: [7FFDDBEBBFE0h, 7FFDDBEBBFEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part3x1:uint part)
; location: [7FFDDBEBC000h, 7FFDDBEBC00Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part4x1:uint part)
; location: [7FFDDBEBC020h, 7FFDDBEBC02Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part5x1:uint part)
; location: [7FFDDBEBC040h, 7FFDDBEBC04Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x1:uint part)
; location: [7FFDDBEBC060h, 7FFDDBEBC06Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part7x1:uint part)
; location: [7FFDDBEBC080h, 7FFDDBEBC08Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x1:uint part)
; location: [7FFDDBEBC0A0h, 7FFDDBEBC0AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x1:uint part)
; location: [7FFDDBEBC0C0h, 7FFDDBEBC0CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x1:uint part)
; location: [7FFDDBEBC0E0h, 7FFDDBEBC0EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part11x1:uint part)
; location: [7FFDDBEBC100h, 7FFDDBEBC10Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x1:uint part)
; location: [7FFDDBEBC120h, 7FFDDBEBC12Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part13x1:uint part)
; location: [7FFDDBEBC140h, 7FFDDBEBC14Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x1:uint part)
; location: [7FFDDBEBC160h, 7FFDDBEBC16Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x1:uint part)
; location: [7FFDDBEBC180h, 7FFDDBEBC18Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x1:ulong part)
; location: [7FFDDBEBC1A0h, 7FFDDBEBC1AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part1x1:uint part)
; location: [7FFDDBEBC1C0h, 7FFDDBEBC1CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part2x1:uint part)
; location: [7FFDDBEBC1E0h, 7FFDDBEBC1EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part3x1:uint part)
; location: [7FFDDBEBC200h, 7FFDDBEBC20Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part4x1:uint part)
; location: [7FFDDBEBC220h, 7FFDDBEBC22Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part5x1:uint part)
; location: [7FFDDBEBC240h, 7FFDDBEBC24Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part6x1:uint part)
; location: [7FFDDBEBC260h, 7FFDDBEBC26Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part7x1:uint part)
; location: [7FFDDBEBC280h, 7FFDDBEBC28Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x1:uint part)
; location: [7FFDDBEBC2A0h, 7FFDDBEBC2AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x1:uint part)
; location: [7FFDDBEBC2C0h, 7FFDDBEBC2CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x1:uint part)
; location: [7FFDDBEBC2E0h, 7FFDDBEBC2EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part11x1:uint part)
; location: [7FFDDBEBC300h, 7FFDDBEBC30Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x1:uint part)
; location: [7FFDDBEBC320h, 7FFDDBEBC32Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part13x1:uint part)
; location: [7FFDDBEBC340h, 7FFDDBEBC34Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x1:uint part)
; location: [7FFDDBEBC360h, 7FFDDBEBC36Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x1:uint part)
; location: [7FFDDBEBC380h, 7FFDDBEBC38Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x1:ulong part)
; location: [7FFDDBEBC3A0h, 7FFDDBEBC3AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x2(uint src, Span<byte> dst)
; location: [7FFDDBEBC3C0h, 7FFDDBEBC45Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0099h            ; JBE(Jbe_rel32_64) [99h:jmp64]                        encoding(6 bytes) = 0f 86 85 00 00 00
0014h mov r8d,3                     ; MOV(Mov_r32_imm32) [R8D,3h:imm32]                    encoding(6 bytes) = 41 b8 03 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,3                     ; MOV(Mov_r32_imm32) [R9D,3h:imm32]                    encoding(6 bytes) = 41 b9 03 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 63
0036h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003ah mov r9d,0Ch                   ; MOV(Mov_r32_imm32) [R9D,ch:imm32]                    encoding(6 bytes) = 41 b9 0c 00 00 00
0040h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0045h mov r10d,3                    ; MOV(Mov_r32_imm32) [R10D,3h:imm32]                   encoding(6 bytes) = 41 ba 03 00 00 00
004bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0050h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0054h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0057h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 3d
005ch lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0060h mov r9d,30h                   ; MOV(Mov_r32_imm32) [R9D,30h:imm32]                   encoding(6 bytes) = 41 b9 30 00 00 00
0066h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
006bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0070h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0074h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0077h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
007ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 1d
007ch add rax,3                     ; ADD(Add_rm64_imm8) [RAX,3h:imm64]                    encoding(4 bytes) = 48 83 c0 03
0080h mov edx,0C0h                  ; MOV(Mov_r32_imm32) [EDX,c0h:imm32]                   encoding(5 bytes) = ba c0 00 00 00
0085h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
008ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
008fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0092h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0094h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0098h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0099h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F372B40h:jmp64]                encoding(5 bytes) = e8 a2 2a 37 5f
009eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part8x2Bytes => new byte[159]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x85,0x00,0x00,0x00,0x41,0xB8,0x03,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x03,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x63,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x0C,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x03,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x3D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x30,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x1D,0x48,0x83,0xC0,0x03,0xBA,0xC0,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA2,0x2A,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x2(uint src, Span<byte> dst)
; location: [7FFDDBEBC480h, 7FFDDBEBC5AEh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 15 01 00 00
0014h mov r8d,3                     ; MOV(Mov_r32_imm32) [R8D,3h:imm32]                    encoding(6 bytes) = 41 b8 03 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,3                     ; MOV(Mov_r32_imm32) [R9D,3h:imm32]                    encoding(6 bytes) = 41 b9 03 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 ef 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,0Ch                   ; MOV(Mov_r32_imm32) [R9D,ch:imm32]                    encoding(6 bytes) = 41 b9 0c 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,3                    ; MOV(Mov_r32_imm32) [R10D,3h:imm32]                   encoding(6 bytes) = 41 ba 03 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,30h                   ; MOV(Mov_r32_imm32) [R9D,30h:imm32]                   encoding(6 bytes) = 41 b9 30 00 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0C0h                  ; MOV(Mov_r32_imm32) [R9D,c0h:imm32]                   encoding(6 bytes) = 41 b9 c0 00 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,300h                  ; MOV(Mov_r32_imm32) [R9D,300h:imm32]                  encoding(6 bytes) = 41 b9 00 03 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 5d
00cch lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d0h mov r9d,0C00h                 ; MOV(Mov_r32_imm32) [R9D,c00h:imm32]                  encoding(6 bytes) = 41 b9 00 0c 00 00
00d6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00e7h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 3d
00ech lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f0h mov r9d,3000h                 ; MOV(Mov_r32_imm32) [R9D,3000h:imm32]                 encoding(6 bytes) = 41 b9 00 30 00 00
00f6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00fbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0100h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0104h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0107h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
010ah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 1d
010ch add rax,7                     ; ADD(Add_rm64_imm8) [RAX,7h:imm64]                    encoding(4 bytes) = 48 83 c0 07
0110h mov edx,0C000h                ; MOV(Mov_r32_imm32) [EDX,c000h:imm32]                 encoding(5 bytes) = ba 00 c0 00 00
0115h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
011ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
011fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0122h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0124h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0128h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0129h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F372A80h:jmp64]                encoding(5 bytes) = e8 52 29 37 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x2Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x03,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x03,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x0C,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x03,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x30,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0xC0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x03,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x0C,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x30,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x00,0xC0,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x52,0x29,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x2(uint src, Span<byte> dst)
; location: [7FFDDBEBC5D0h, 7FFDDBEBC81Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 35 02 00 00
0014h mov r8d,3                     ; MOV(Mov_r32_imm32) [R8D,3h:imm32]                    encoding(6 bytes) = 41 b8 03 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,3                     ; MOV(Mov_r32_imm32) [R9D,3h:imm32]                    encoding(6 bytes) = 41 b9 03 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 0f 02 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,0Ch                   ; MOV(Mov_r32_imm32) [R9D,ch:imm32]                    encoding(6 bytes) = 41 b9 0c 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,3                    ; MOV(Mov_r32_imm32) [R10D,3h:imm32]                   encoding(6 bytes) = 41 ba 03 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 e5 01 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,30h                   ; MOV(Mov_r32_imm32) [R9D,30h:imm32]                   encoding(6 bytes) = 41 b9 30 00 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 c1 01 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0C0h                  ; MOV(Mov_r32_imm32) [R9D,c0h:imm32]                   encoding(6 bytes) = 41 b9 c0 00 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 9d 01 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,300h                  ; MOV(Mov_r32_imm32) [R9D,300h:imm32]                  encoding(6 bytes) = 41 b9 00 03 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 79 01 00 00
00d0h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d4h mov r9d,0C00h                 ; MOV(Mov_r32_imm32) [R9D,c00h:imm32]                  encoding(6 bytes) = 41 b9 00 0c 00 00
00dah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dfh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e4h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e8h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00ebh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eeh jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 55 01 00 00
00f4h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f8h mov r9d,3000h                 ; MOV(Mov_r32_imm32) [R9D,3000h:imm32]                 encoding(6 bytes) = 41 b9 00 30 00 00
00feh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0103h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0108h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
010ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
010fh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0112h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 31 01 00 00
0118h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 07
011ch mov r9d,0C000h                ; MOV(Mov_r32_imm32) [R9D,c000h:imm32]                 encoding(6 bytes) = 41 b9 00 c0 00 00
0122h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0127h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
012ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0130h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0133h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0136h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 0d 01 00 00
013ch lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 08
0140h mov r9d,30000h                ; MOV(Mov_r32_imm32) [R9D,30000h:imm32]                encoding(6 bytes) = 41 b9 00 00 03 00
0146h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
014bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0150h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0154h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0157h cmp edx,9                     ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]                    encoding(3 bytes) = 83 fa 09
015ah jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 e9 00 00 00
0160h lea r8,[rax+9]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 09
0164h mov r9d,0C0000h               ; MOV(Mov_r32_imm32) [R9D,c0000h:imm32]                encoding(6 bytes) = 41 b9 00 00 0c 00
016ah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
016fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0174h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0178h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
017bh cmp edx,0Ah                   ; CMP(Cmp_rm32_imm8) [EDX,ah:imm32]                    encoding(3 bytes) = 83 fa 0a
017eh jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0184h lea r8,[rax+0Ah]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 0a
0188h mov r9d,300000h               ; MOV(Mov_r32_imm32) [R9D,300000h:imm32]               encoding(6 bytes) = 41 b9 00 00 30 00
018eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0193h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0198h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
019ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
019fh cmp edx,0Bh                   ; CMP(Cmp_rm32_imm8) [EDX,bh:imm32]                    encoding(3 bytes) = 83 fa 0b
01a2h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
01a8h lea r8,[rax+0Bh]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 0b
01ach mov r9d,0C00000h              ; MOV(Mov_r32_imm32) [R9D,c00000h:imm32]               encoding(6 bytes) = 41 b9 00 00 c0 00
01b2h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
01b7h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
01bch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
01c0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
01c3h cmp edx,0Ch                   ; CMP(Cmp_rm32_imm8) [EDX,ch:imm32]                    encoding(3 bytes) = 83 fa 0c
01c6h jbe near ptr 0249h            ; JBE(Jbe_rel32_64) [249h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
01cch lea r8,[rax+0Ch]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 0c
01d0h mov r9d,3000000h              ; MOV(Mov_r32_imm32) [R9D,3000000h:imm32]              encoding(6 bytes) = 41 b9 00 00 00 03
01d6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
01dbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
01e0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
01e4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
01e7h cmp edx,0Dh                   ; CMP(Cmp_rm32_imm8) [EDX,dh:imm32]                    encoding(3 bytes) = 83 fa 0d
01eah jbe short 0249h               ; JBE(Jbe_rel8_64) [249h:jmp64]                        encoding(2 bytes) = 76 5d
01ech lea r8,[rax+0Dh]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 0d
01f0h mov r9d,0C000000h             ; MOV(Mov_r32_imm32) [R9D,c000000h:imm32]              encoding(6 bytes) = 41 b9 00 00 00 0c
01f6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
01fbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0200h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0204h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0207h cmp edx,0Eh                   ; CMP(Cmp_rm32_imm8) [EDX,eh:imm32]                    encoding(3 bytes) = 83 fa 0e
020ah jbe short 0249h               ; JBE(Jbe_rel8_64) [249h:jmp64]                        encoding(2 bytes) = 76 3d
020ch lea r8,[rax+0Eh]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 0e
0210h mov r9d,30000000h             ; MOV(Mov_r32_imm32) [R9D,30000000h:imm32]             encoding(6 bytes) = 41 b9 00 00 00 30
0216h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
021bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0220h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0224h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0227h cmp edx,0Fh                   ; CMP(Cmp_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 fa 0f
022ah jbe short 0249h               ; JBE(Jbe_rel8_64) [249h:jmp64]                        encoding(2 bytes) = 76 1d
022ch add rax,0Fh                   ; ADD(Add_rm64_imm8) [RAX,fh:imm64]                    encoding(4 bytes) = 48 83 c0 0f
0230h mov edx,0C0000000h            ; MOV(Mov_r32_imm32) [EDX,c0000000h:imm32]             encoding(5 bytes) = ba 00 00 00 c0
0235h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
023ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
023fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0242h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0244h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0248h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0249h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F372930h:jmp64]                encoding(5 bytes) = e8 e2 26 37 5f
024eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x2Bytes => new byte[591]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x35,0x02,0x00,0x00,0x41,0xB8,0x03,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x03,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x0F,0x02,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x0C,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x03,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xE5,0x01,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x30,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xC1,0x01,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0xC0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x9D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x03,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0x79,0x01,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x0C,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x0F,0x86,0x55,0x01,0x00,0x00,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x30,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x0F,0x86,0x31,0x01,0x00,0x00,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x00,0xC0,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x0F,0x86,0x0D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0x00,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x09,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x09,0x41,0xB9,0x00,0x00,0x0C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0A,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x0A,0x41,0xB9,0x00,0x00,0x30,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0B,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x0B,0x41,0xB9,0x00,0x00,0xC0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0C,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x0C,0x41,0xB9,0x00,0x00,0x00,0x03,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0D,0x76,0x5D,0x4C,0x8D,0x40,0x0D,0x41,0xB9,0x00,0x00,0x00,0x0C,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0E,0x76,0x3D,0x4C,0x8D,0x40,0x0E,0x41,0xB9,0x00,0x00,0x00,0x30,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0F,0x76,0x1D,0x48,0x83,0xC0,0x0F,0xBA,0x00,0x00,0x00,0xC0,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE2,0x26,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte project(byte src, Part4x2:uint part)
; location: [7FFDDBEBC840h, 7FFDDBEBC853h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte project(byte src, Part6x2:uint part)
; location: [7FFDDBEBC870h, 7FFDDBEBC883h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x2:uint part)
; location: [7FFDDBEBC8A0h, 7FFDDBEBC8AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x2:uint part)
; location: [7FFDDBEBC8C0h, 7FFDDBEBC8CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x2:uint part)
; location: [7FFDDBEBC8E0h, 7FFDDBEBC8EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x2:uint part)
; location: [7FFDDBEBC900h, 7FFDDBEBC90Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x2:uint part)
; location: [7FFDDBEBC920h, 7FFDDBEBC92Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x2:uint part)
; location: [7FFDDBEBC940h, 7FFDDBEBC94Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part4x2:uint part)
; location: [7FFDDBEBC960h, 7FFDDBEBC96Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x2:uint part)
; location: [7FFDDBEBC980h, 7FFDDBEBC98Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x2:uint part)
; location: [7FFDDBEBC9A0h, 7FFDDBEBC9AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x2:uint part)
; location: [7FFDDBEBC9C0h, 7FFDDBEBC9CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x2:uint part)
; location: [7FFDDBEBC9E0h, 7FFDDBEBC9EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x2:uint part)
; location: [7FFDDBEBCA00h, 7FFDDBEBCA0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x3(uint src, Span<byte> dst)
; location: [7FFDDBEBCA20h, 7FFDDBEBCA73h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 004eh               ; JBE(Jbe_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 76 3e
0010h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
0016h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001bh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0021h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
002dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0030h jbe short 004eh               ; JBE(Jbe_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 76 1c
0032h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0035h mov edx,38h                   ; MOV(Mov_r32_imm32) [EDX,38h:imm32]                   encoding(5 bytes) = ba 38 00 00 00
003ah pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
003fh pdep edx,edx,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R9D]            encoding(VEX, 5 bytes) = c4 c2 6b f5 d1
0044h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0047h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0049h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004eh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3724E0h:jmp64]                encoding(5 bytes) = e8 8d 24 37 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part6x3Bytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x3E,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x1C,0x48,0xFF,0xC0,0xBA,0x38,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8D,0x24,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part9x3(uint src, Span<byte> dst)
; location: [7FFDDBEBCA90h, 7FFDDBEBCB0Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 0075h               ; JBE(Jbe_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 76 65
0010h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
0016h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001bh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0021h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
002dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0030h jbe short 0075h               ; JBE(Jbe_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 76 43
0032h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
0036h mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
003ch pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0041h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
0047h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
004ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0050h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0053h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0056h jbe short 0075h               ; JBE(Jbe_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 76 1d
0058h add rax,2                     ; ADD(Add_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 c0 02
005ch mov edx,1C0h                  ; MOV(Mov_r32_imm32) [EDX,1c0h:imm32]                  encoding(5 bytes) = ba c0 01 00 00
0061h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0066h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
006bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
006eh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0070h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0074h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0075h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F372470h:jmp64]                encoding(5 bytes) = e8 f6 23 37 5f
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part9x3Bytes => new byte[123]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x65,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x43,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x1D,0x48,0x83,0xC0,0x02,0xBA,0xC0,0x01,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF6,0x23,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x3(uint src, Span<byte> dst)
; location: [7FFDDBEBCB20h, 7FFDDBEBCBBEh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0099h            ; JBE(Jbe_rel32_64) [99h:jmp64]                        encoding(6 bytes) = 0f 86 85 00 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 63
0036h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003ah mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0040h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0045h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0050h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0054h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0057h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 3d
005ch lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0060h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
0066h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
006bh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0070h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0074h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0077h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
007ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 1d
007ch add rax,3                     ; ADD(Add_rm64_imm8) [RAX,3h:imm64]                    encoding(4 bytes) = 48 83 c0 03
0080h mov edx,0E00h                 ; MOV(Mov_r32_imm32) [EDX,e00h:imm32]                  encoding(5 bytes) = ba 00 0e 00 00
0085h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
008ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
008fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0092h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0094h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0098h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0099h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F3723E0h:jmp64]                encoding(5 bytes) = e8 42 23 37 5f
009eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part12x3Bytes => new byte[159]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x85,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x63,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x3D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x1D,0x48,0x83,0xC0,0x03,0xBA,0x00,0x0E,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x42,0x23,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part15x3(uint src, Span<byte> dst)
; location: [7FFDDBEBCFE0h, 7FFDDBEBD0A2h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 00bdh            ; JBE(Jbe_rel32_64) [BDh:jmp64]                        encoding(6 bytes) = 0f 86 a9 00 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 00bdh            ; JBE(Jbe_rel32_64) [BDh:jmp64]                        encoding(6 bytes) = 0f 86 83 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe short 00bdh               ; JBE(Jbe_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = 76 5d
0060h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0064h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
006ah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
006fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0074h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0078h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007bh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
007eh jbe short 00bdh               ; JBE(Jbe_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = 76 3d
0080h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
0084h mov r9d,0E00h                 ; MOV(Mov_r32_imm32) [R9D,e00h:imm32]                  encoding(6 bytes) = 41 b9 00 0e 00 00
008ah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
008fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0094h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0098h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
009bh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
009eh jbe short 00bdh               ; JBE(Jbe_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = 76 1d
00a0h add rax,4                     ; ADD(Add_rm64_imm8) [RAX,4h:imm64]                    encoding(4 bytes) = 48 83 c0 04
00a4h mov edx,7000h                 ; MOV(Mov_r32_imm32) [EDX,7000h:imm32]                 encoding(5 bytes) = ba 00 70 00 00
00a9h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
00aeh pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
00b3h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00b6h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
00b8h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00bch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00bdh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F371F20h:jmp64]                encoding(5 bytes) = e8 5e 1e 37 5f
00c2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part15x3Bytes => new byte[195]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xA9,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x83,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x5D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x3D,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x1D,0x48,0x83,0xC0,0x04,0xBA,0x00,0x70,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x5E,0x1E,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part18x3(uint src, Span<byte> dst)
; location: [7FFDDBEBD0C0h, 7FFDDBEBD1A6h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 00e1h            ; JBE(Jbe_rel32_64) [E1h:jmp64]                        encoding(6 bytes) = 0f 86 cd 00 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 00e1h            ; JBE(Jbe_rel32_64) [E1h:jmp64]                        encoding(6 bytes) = 0f 86 a7 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 00e1h            ; JBE(Jbe_rel32_64) [E1h:jmp64]                        encoding(6 bytes) = 0f 86 7d 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe short 00e1h               ; JBE(Jbe_rel8_64) [E1h:jmp64]                         encoding(2 bytes) = 76 5d
0084h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
0088h mov r9d,0E00h                 ; MOV(Mov_r32_imm32) [R9D,e00h:imm32]                  encoding(6 bytes) = 41 b9 00 0e 00 00
008eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0093h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0098h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
009ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
009fh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a2h jbe short 00e1h               ; JBE(Jbe_rel8_64) [E1h:jmp64]                         encoding(2 bytes) = 76 3d
00a4h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00a8h mov r9d,7000h                 ; MOV(Mov_r32_imm32) [R9D,7000h:imm32]                 encoding(6 bytes) = 41 b9 00 70 00 00
00aeh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00b3h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00b8h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00bch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00bfh cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00c2h jbe short 00e1h               ; JBE(Jbe_rel8_64) [E1h:jmp64]                         encoding(2 bytes) = 76 1d
00c4h add rax,5                     ; ADD(Add_rm64_imm8) [RAX,5h:imm64]                    encoding(4 bytes) = 48 83 c0 05
00c8h mov edx,38000h                ; MOV(Mov_r32_imm32) [EDX,38000h:imm32]                encoding(5 bytes) = ba 00 80 03 00
00cdh pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
00d2h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
00d7h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00dah mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
00dch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00e0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00e1h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F371E40h:jmp64]                encoding(5 bytes) = e8 5a 1d 37 5f
00e6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part18x3Bytes => new byte[231]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xCD,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xA7,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x5D,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x3D,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x1D,0x48,0x83,0xC0,0x05,0xBA,0x00,0x80,0x03,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x5A,0x1D,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part21x3(uint src, Span<byte> dst)
; location: [7FFDDBEBD1C0h, 7FFDDBEBD2CAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 f1 00 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 cb 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0105h            ; JBE(Jbe_rel32_64) [105h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0E00h                 ; MOV(Mov_r32_imm32) [R9D,e00h:imm32]                  encoding(6 bytes) = 41 b9 00 0e 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe short 0105h               ; JBE(Jbe_rel8_64) [105h:jmp64]                        encoding(2 bytes) = 76 5d
00a8h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00ach mov r9d,7000h                 ; MOV(Mov_r32_imm32) [R9D,7000h:imm32]                 encoding(6 bytes) = 41 b9 00 70 00 00
00b2h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00b7h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00bch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c3h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00c6h jbe short 0105h               ; JBE(Jbe_rel8_64) [105h:jmp64]                        encoding(2 bytes) = 76 3d
00c8h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00cch mov r9d,38000h                ; MOV(Mov_r32_imm32) [R9D,38000h:imm32]                encoding(6 bytes) = 41 b9 00 80 03 00
00d2h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00d7h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00dch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00e3h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00e6h jbe short 0105h               ; JBE(Jbe_rel8_64) [105h:jmp64]                        encoding(2 bytes) = 76 1d
00e8h add rax,6                     ; ADD(Add_rm64_imm8) [RAX,6h:imm64]                    encoding(4 bytes) = 48 83 c0 06
00ech mov edx,1C0000h               ; MOV(Mov_r32_imm32) [EDX,1c0000h:imm32]               encoding(5 bytes) = ba 00 00 1c 00
00f1h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
00f6h pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
00fbh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00feh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0100h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0104h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0105h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F371D40h:jmp64]                encoding(5 bytes) = e8 36 1c 37 5f
010ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part21x3Bytes => new byte[267]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xF1,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xCB,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x5D,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x3D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x1D,0x48,0x83,0xC0,0x06,0xBA,0x00,0x00,0x1C,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x36,0x1C,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part24x3(uint src, Span<byte> dst)
; location: [7FFDDBEBD2E0h, 7FFDDBEBD40Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 15 01 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 ef 00 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0E00h                 ; MOV(Mov_r32_imm32) [R9D,e00h:imm32]                  encoding(6 bytes) = 41 b9 00 0e 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 0129h            ; JBE(Jbe_rel32_64) [129h:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,7000h                 ; MOV(Mov_r32_imm32) [R9D,7000h:imm32]                 encoding(6 bytes) = 41 b9 00 70 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 5d
00cch lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d0h mov r9d,38000h                ; MOV(Mov_r32_imm32) [R9D,38000h:imm32]                encoding(6 bytes) = 41 b9 00 80 03 00
00d6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00e7h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 3d
00ech lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f0h mov r9d,1C0000h               ; MOV(Mov_r32_imm32) [R9D,1c0000h:imm32]               encoding(6 bytes) = 41 b9 00 00 1c 00
00f6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00fbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0100h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0104h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
0107h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
010ah jbe short 0129h               ; JBE(Jbe_rel8_64) [129h:jmp64]                        encoding(2 bytes) = 76 1d
010ch add rax,7                     ; ADD(Add_rm64_imm8) [RAX,7h:imm64]                    encoding(4 bytes) = 48 83 c0 07
0110h mov edx,0E00000h              ; MOV(Mov_r32_imm32) [EDX,e00000h:imm32]               encoding(5 bytes) = ba 00 00 e0 00
0115h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
011ah pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
011fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0122h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0124h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0128h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0129h call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F371C20h:jmp64]                encoding(5 bytes) = e8 f2 1a 37 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part24x3Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x1C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x00,0x00,0xE0,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF2,0x1A,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part27x3(uint src, Span<byte> dst)
; location: [7FFDDBEBD430h, 7FFDDBEBD582h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 39 01 00 00
0014h mov r8d,7                     ; MOV(Mov_r32_imm32) [R8D,7h:imm32]                    encoding(6 bytes) = 41 b8 07 00 00 00
001ah pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
001fh mov r9d,7                     ; MOV(Mov_r32_imm32) [R9D,7h:imm32]                    encoding(6 bytes) = 41 b9 07 00 00 00
0025h pdep r8d,r8d,r9d              ; PDEP(VEX_Pdep_r32_r32_rm32) [R8D,R8D,R9D]            encoding(VEX, 5 bytes) = c4 42 3b f5 c1
002ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002eh mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0031h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0034h jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 13 01 00 00
003ah lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 01
003eh mov r9d,38h                   ; MOV(Mov_r32_imm32) [R9D,38h:imm32]                   encoding(6 bytes) = 41 b9 38 00 00 00
0044h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0049h mov r10d,7                    ; MOV(Mov_r32_imm32) [R10D,7h:imm32]                   encoding(6 bytes) = 41 ba 07 00 00 00
004fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0054h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0058h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
005bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
005eh jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 e9 00 00 00
0064h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 02
0068h mov r9d,1C0h                  ; MOV(Mov_r32_imm32) [R9D,1c0h:imm32]                  encoding(6 bytes) = 41 b9 c0 01 00 00
006eh pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0073h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0078h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
007fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0082h jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0088h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 03
008ch mov r9d,0E00h                 ; MOV(Mov_r32_imm32) [R9D,e00h:imm32]                  encoding(6 bytes) = 41 b9 00 0e 00 00
0092h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
0097h pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
009ch movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00a0h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00a3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00a6h jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 a1 00 00 00
00ach lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 04
00b0h mov r9d,7000h                 ; MOV(Mov_r32_imm32) [R9D,7000h:imm32]                 encoding(6 bytes) = 41 b9 00 70 00 00
00b6h pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00bbh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00c0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00c4h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
00cah jbe near ptr 014dh            ; JBE(Jbe_rel32_64) [14Dh:jmp64]                       encoding(6 bytes) = 0f 86 7d 00 00 00
00d0h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 05
00d4h mov r9d,38000h                ; MOV(Mov_r32_imm32) [R9D,38000h:imm32]                encoding(6 bytes) = 41 b9 00 80 03 00
00dah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00dfh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
00e4h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e8h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
00ebh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
00eeh jbe short 014dh               ; JBE(Jbe_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = 76 5d
00f0h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 06
00f4h mov r9d,1C0000h               ; MOV(Mov_r32_imm32) [R9D,1c0000h:imm32]               encoding(6 bytes) = 41 b9 00 00 1c 00
00fah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
00ffh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0104h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0108h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
010bh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
010eh jbe short 014dh               ; JBE(Jbe_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = 76 3d
0110h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 07
0114h mov r9d,0E00000h              ; MOV(Mov_r32_imm32) [R9D,e00000h:imm32]               encoding(6 bytes) = 41 b9 00 00 e0 00
011ah pext r9d,ecx,r9d              ; PEXT(VEX_Pext_r32_r32_rm32) [R9D,ECX,R9D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c9
011fh pdep r9d,r9d,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [R9D,R9D,R10D]           encoding(VEX, 5 bytes) = c4 42 33 f5 ca
0124h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0128h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),R9L]            encoding(3 bytes) = 45 88 08
012bh cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
012eh jbe short 014dh               ; JBE(Jbe_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = 76 1d
0130h add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
0134h mov edx,7000000h              ; MOV(Mov_r32_imm32) [EDX,7000000h:imm32]              encoding(5 bytes) = ba 00 00 00 07
0139h pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
013eh pdep edx,edx,r10d             ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,R10D]           encoding(VEX, 5 bytes) = c4 c2 6b f5 d2
0143h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0146h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0148h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
014ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
014dh call 7FFE3B22EF00h            ; CALL(Call_rel32_64) [5F371AD0h:jmp64]                encoding(5 bytes) = e8 7e 19 37 5f
0152h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part27x3Bytes => new byte[339]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x39,0x01,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x13,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x5D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x1C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x3D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x00,0x00,0xE0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x1D,0x48,0x83,0xC0,0x08,0xBA,0x00,0x00,0x00,0x07,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7E,0x19,0x37,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
