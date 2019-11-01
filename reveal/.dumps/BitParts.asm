; 2019-10-31 21:45:37:301
; function: void part27x3(uint src, Span<byte> dst)
; location: [7FFDDB8286F0h, 7FFDDB828842h]
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
014dh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F566810h:jmp64]                encoding(5 bytes) = e8 be 66 56 5f
0152h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part27x3Bytes => new byte[339]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x39,0x01,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x13,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x5D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x1C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x3D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x00,0x00,0xE0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x1D,0x48,0x83,0xC0,0x08,0xBA,0x00,0x00,0x00,0x07,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xBE,0x66,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part30x3(uint src, Span<byte> dst)
; location: [7FFDDB828860h, 7FFDDB8289D6h]
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
0171h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5666A0h:jmp64]                encoding(5 bytes) = e8 2a 65 56 5f
0176h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part30x3Bytes => new byte[375]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x5D,0x01,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x37,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x0D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x1C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x5D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x00,0x00,0xE0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x3D,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0x00,0x00,0x07,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x09,0x76,0x1D,0x48,0x83,0xC0,0x09,0xBA,0x00,0x00,0x00,0x38,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x2A,0x65,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x3:uint part)
; location: [7FFDDB8289F0h, 7FFDDB8289FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x3:uint part)
; location: [7FFDDB828A10h, 7FFDDB828A1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x3:uint part)
; location: [7FFDDB828A30h, 7FFDDB828A3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x3:uint part)
; location: [7FFDDB828A50h, 7FFDDB828A5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part18x3:uint part)
; location: [7FFDDB828A70h, 7FFDDB828A7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part21x3:uint part)
; location: [7FFDDB828A90h, 7FFDDB828A9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part24x3:uint part)
; location: [7FFDDB828AB0h, 7FFDDB828ABAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part27x3:uint part)
; location: [7FFDDB828AD0h, 7FFDDB828ADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x3:uint part)
; location: [7FFDDB828AF0h, 7FFDDB828AFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x3:uint part)
; location: [7FFDDB828B10h, 7FFDDB828B1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x3:uint part)
; location: [7FFDDB828B30h, 7FFDDB828B3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x3:uint part)
; location: [7FFDDB828B50h, 7FFDDB828B5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part15x3:uint part)
; location: [7FFDDB828B70h, 7FFDDB828B7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part18x3:uint part)
; location: [7FFDDB828B90h, 7FFDDB828B9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part21x3:uint part)
; location: [7FFDDB828BB0h, 7FFDDB828BBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x3:uint part)
; location: [7FFDDB828BD0h, 7FFDDB828BDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part27x3:uint part)
; location: [7FFDDB828BF0h, 7FFDDB828BFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x3:uint part)
; location: [7FFDDB828C10h, 7FFDDB828C1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x4(uint src, Span<byte> dst)
; location: [7FFDDB828C30h, 7FFDDB828C83h]
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
004eh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5662D0h:jmp64]                encoding(5 bytes) = e8 7d 62 56 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part8x4Bytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x3E,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x1C,0x48,0xFF,0xC0,0xBA,0xF0,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7D,0x62,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x4(uint src, Span<byte> dst)
; location: [7FFDDB828CA0h, 7FFDDB828D1Ah]
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
0075h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F566260h:jmp64]                encoding(5 bytes) = e8 e6 61 56 5f
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part12x4Bytes => new byte[123]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x65,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x43,0x4C,0x8D,0x40,0x01,0x41,0xB9,0xF0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x0F,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x1D,0x48,0x83,0xC0,0x02,0xBA,0x00,0x0F,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE6,0x61,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x4(uint src, Span<byte> dst)
; location: [7FFDDB828D30h, 7FFDDB828DCEh]
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
0099h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5661D0h:jmp64]                encoding(5 bytes) = e8 32 61 56 5f
009eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x4Bytes => new byte[159]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x85,0x00,0x00,0x00,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x63,0x4C,0x8D,0x40,0x01,0x41,0xB9,0xF0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x0F,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x3D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x00,0x0F,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x1D,0x48,0x83,0xC0,0x03,0xBA,0x00,0xF0,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x32,0x61,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x4(uint src, Span<byte> dst)
; location: [7FFDDB828DF0h, 7FFDDB828F1Eh]
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
0129h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F566110h:jmp64]                encoding(5 bytes) = e8 e2 5f 56 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x4Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x0F,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x0F,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0xF0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x0F,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x00,0x0F,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0xF0,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x00,0x0F,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x00,0xF0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x00,0x0F,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x00,0x00,0x00,0xF0,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE2,0x5F,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x4:uint part)
; location: [7FFDDB828F40h, 7FFDDB828F4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x4:uint part)
; location: [7FFDDB828F60h, 7FFDDB828F6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x4:uint part)
; location: [7FFDDB828F80h, 7FFDDB828F8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x4:uint part)
; location: [7FFDDB828FA0h, 7FFDDB828FAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x4:uint part)
; location: [7FFDDB828FC0h, 7FFDDB828FCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x4:uint part)
; location: [7FFDDB828FE0h, 7FFDDB828FEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x4:uint part)
; location: [7FFDDB829000h, 7FFDDB82900Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part20x4:uint part)
; location: [7FFDDB829020h, 7FFDDB82902Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x4:uint part)
; location: [7FFDDB829040h, 7FFDDB82904Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x4:uint part)
; location: [7FFDDB829060h, 7FFDDB82906Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x5:uint part)
; location: [7FFDDB829080h, 7FFDDB82908Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x5:uint part)
; location: [7FFDDB8290A0h, 7FFDDB8290AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part20x5:uint part)
; location: [7FFDDB8290C0h, 7FFDDB8290CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part25x5:uint part)
; location: [7FFDDB8290E0h, 7FFDDB8290EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x5:uint part)
; location: [7FFDDB829100h, 7FFDDB82910Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part30x5:uint part)
; location: [7FFDDB829120h, 7FFDDB82912Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x6:uint part)
; location: [7FFDDB829140h, 7FFDDB82914Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x6:uint part)
; location: [7FFDDB829160h, 7FFDDB82916Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x8(uint src, Span<byte> dst)
; location: [7FFDDB829180h, 7FFDDB8291D3h]
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
004eh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F565D80h:jmp64]                encoding(5 bytes) = e8 2d 5d 56 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x8Bytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x3E,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0xFF,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x1C,0x48,0xFF,0xC0,0xBA,0x00,0xFF,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x2D,0x5D,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x8(uint src, Span<byte> dst)
; location: [7FFDDB8291F0h, 7FFDDB82929Dh]
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
00a8h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F565D10h:jmp64]                encoding(5 bytes) = e8 63 5c 56 5f
00adh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x8Bytes => new byte[174]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x94,0x00,0x00,0x00,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0xFF,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x6E,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x41,0xBA,0xFF,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x44,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x20,0x48,0x83,0xC0,0x03,0xBA,0x00,0x00,0x00,0xFF,0xC4,0xE2,0x72,0xF5,0xD2,0x0F,0xB6,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x63,0x5C,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x8:uint part)
; location: [7FFDDB8292C0h, 7FFDDB8292CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x8:uint part)
; location: [7FFDDB8292E0h, 7FFDDB8292EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x8:ulong part)
; location: [7FFDDB829300h, 7FFDDB82930Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x8:uint part)
; location: [7FFDDB829320h, 7FFDDB82932Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part32x8:uint part)
; location: [7FFDDB829340h, 7FFDDB82934Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x8:uint part)
; location: [7FFDDB829360h, 7FFDDB82936Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(ulong src, Part64x8:ulong part)
; location: [7FFDDB829380h, 7FFDDB82938Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part64x8:ulong part)
; location: [7FFDDB8293A0h, 7FFDDB8293AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort pack16x1(ReadOnlySpan<byte> src, ref ushort dst)
; location: [7FFDDB8293C0h, 7FFDDB829556h]
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
0191h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F565B40h:jmp64]                encoding(5 bytes) = e8 aa 59 56 5f
0196h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16x1Bytes => new byte[407]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x83,0xF9,0x00,0x0F,0x86,0x7D,0x01,0x00,0x00,0x44,0x0F,0xB6,0x00,0x66,0x44,0x09,0x02,0x83,0xF9,0x01,0x0F,0x86,0x6C,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x01,0x41,0xD1,0xE0,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x02,0x0F,0x86,0x53,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x02,0x41,0xC1,0xE0,0x02,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x03,0x0F,0x86,0x39,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x03,0x41,0xC1,0xE0,0x03,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x04,0x0F,0x86,0x1F,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x04,0x41,0xC1,0xE0,0x04,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x05,0x0F,0x86,0x05,0x01,0x00,0x00,0x44,0x0F,0xB6,0x40,0x05,0x41,0xC1,0xE0,0x05,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x06,0x0F,0x86,0xEB,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x06,0x41,0xC1,0xE0,0x06,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x07,0x0F,0x86,0xD1,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x07,0x41,0xC1,0xE0,0x07,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x08,0x0F,0x86,0xB7,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x08,0x41,0xC1,0xE0,0x08,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x09,0x0F,0x86,0x9D,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x09,0x41,0xC1,0xE0,0x09,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0A,0x0F,0x86,0x83,0x00,0x00,0x00,0x44,0x0F,0xB6,0x40,0x0A,0x41,0xC1,0xE0,0x0A,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0B,0x76,0x6D,0x44,0x0F,0xB6,0x40,0x0B,0x41,0xC1,0xE0,0x0B,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0C,0x76,0x57,0x44,0x0F,0xB6,0x40,0x0C,0x41,0xC1,0xE0,0x0C,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0D,0x76,0x41,0x44,0x0F,0xB6,0x40,0x0D,0x41,0xC1,0xE0,0x0D,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0E,0x76,0x2B,0x44,0x0F,0xB6,0x40,0x0E,0x41,0xC1,0xE0,0x0E,0x45,0x0F,0xB7,0xC0,0x66,0x44,0x09,0x02,0x83,0xF9,0x0F,0x76,0x15,0x0F,0xB6,0x40,0x0F,0xC1,0xE0,0x0F,0x0F,0xB7,0xC0,0x66,0x09,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xAA,0x59,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, ulong mask)
; location: [7FFDDB829570h, 7FFDDB82957Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(byte src, BitMask8:byte spec)
; location: [7FFDDB829590h, 7FFDDB8295A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort select(ushort src, BitMask16:ushort spec)
; location: [7FFDDB8295C0h, 7FFDDB8295D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, BitMask32:uint spec)
; location: [7FFDDB8295F0h, 7FFDDB8295FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, BitMask64:ulong spec)
; location: [7FFDDB829610h, 7FFDDB82961Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x16(uint src, Span<ushort> dst)
; location: [7FFDDB829630h, 7FFDDB829659h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 0024h               ; JBE(Jbe_rel8_64) [24h:jmp64]                         encoding(2 bytes) = 76 14
0010h mov [rax],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(3 bytes) = 66 89 08
0013h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0016h jbe short 0024h               ; JBE(Jbe_rel8_64) [24h:jmp64]                         encoding(2 bytes) = 76 0c
0018h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
001bh mov [rax+2],cx                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(4 bytes) = 66 89 48 02
001fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0024h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5658D0h:jmp64]                encoding(5 bytes) = e8 a7 58 56 5f
0029h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x16Bytes => new byte[42]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x14,0x66,0x89,0x08,0x83,0xFA,0x01,0x76,0x0C,0xC1,0xE9,0x10,0x66,0x89,0x48,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA7,0x58,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x16(uint src, out ushort x0, out ushort x1)
; location: [7FFDDB829670h, 7FFDDB82967Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),CX]         encoding(3 bytes) = 66 89 0a
0008h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
000bh mov [r8],cx                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),CX]          encoding(4 bytes) = 66 41 89 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x16Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC1,0xE9,0x10,0x66,0x41,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x16:uint part)
; location: [7FFDDB829690h, 7FFDDB82969Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x16:uint part)
; location: [7FFDDB8296B0h, 7FFDDB8296BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort pack16x1(Span<byte> src, ref ushort dst)
; location: [7FFDDB8296D0h, 7FFDDB82974Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0008h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
000bh mov r9d,[rcx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 08
000fh cmp r9,8                      ; CMP(Cmp_rm64_imm8) [R9,8h:imm64]                     encoding(4 bytes) = 49 83 f9 08
0013h jb short 006fh                ; JB(Jb_rel8_64) [6Fh:jmp64]                           encoding(2 bytes) = 72 5a
0015h mov r8,[r8]                   ; MOV(Mov_r64_rm64) [R8,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 00
0018h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0022h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
0027h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
002bh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
002eh mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
0031h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0034h mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 01
0037h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
003ah cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
003eh jb short 0075h                ; JB(Jb_rel8_64) [75h:jmp64]                           encoding(2 bytes) = 72 35
0040h add r8,8                      ; ADD(Add_rm64_imm8) [R8,8h:imm64]                     encoding(4 bytes) = 49 83 c0 08
0044h mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 08
0047h mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0051h pext rcx,rcx,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f2 f5 c8
0056h shl rcx,8                     ; SHL(Shl_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e1 08
005ah movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
005dh or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
005fh mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
0062h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0065h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0069h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006ah call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F565680h:jmp64]                encoding(5 bytes) = e8 11 56 56 5f
006fh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916800h:jmp64]        encoding(5 bytes) = e8 8c 67 91 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0075h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916800h:jmp64]        encoding(5 bytes) = e8 86 67 91 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16x1Bytes => new byte[123]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0x02,0x4C,0x8B,0x01,0x44,0x8B,0x49,0x08,0x49,0x83,0xF9,0x08,0x72,0x5A,0x4D,0x8B,0x00,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBA,0xF5,0xC1,0x45,0x0F,0xB7,0xC0,0x41,0x0B,0xC0,0x66,0x89,0x02,0x0F,0xB7,0x02,0x4C,0x8B,0x01,0x8B,0x49,0x08,0x48,0x83,0xF9,0x10,0x72,0x35,0x49,0x83,0xC0,0x08,0x49,0x8B,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0xC1,0xE1,0x08,0x0F,0xB7,0xC9,0x0B,0xC1,0x66,0x89,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x11,0x56,0x56,0x5F,0xE8,0x8C,0x67,0x91,0xFF,0xCC,0xE8,0x86,0x67,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack32x1(Span<byte> src, ref uint dst)
; location: [7FFDDB829760h, 7FFDDB829833h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
000eh mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0010h cmp rcx,8                     ; CMP(Cmp_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 f9 08
0014h jb near ptr 00bch             ; JB(Jb_rel32_64) [BCh:jmp64]                          encoding(6 bytes) = 0f 82 a2 00 00 00
001ah mov r9,[rax]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 08
001dh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0027h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
002ch or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
002fh mov [rdx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 02
0032h mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
0035h cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
0039h jb near ptr 00c2h             ; JB(Jb_rel32_64) [C2h:jmp64]                          encoding(6 bytes) = 0f 82 83 00 00 00
003fh lea r9,[rax+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 08
0043h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0046h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0050h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0055h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
0059h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
005ch mov [rdx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 02
005fh mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
0062h cmp rcx,18h                   ; CMP(Cmp_rm64_imm8) [RCX,18h:imm64]                   encoding(4 bytes) = 48 83 f9 18
0066h jb short 00c8h                ; JB(Jb_rel8_64) [C8h:jmp64]                           encoding(2 bytes) = 72 60
0068h lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 10
006ch mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
006fh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0079h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
007eh shl r9d,10h                   ; SHL(Shl_rm32_imm8) [R9D,10h:imm8]                    encoding(4 bytes) = 41 c1 e1 10
0082h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0085h mov [rdx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 02
0088h mov r8d,[rdx]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 44 8b 02
008bh cmp rcx,20h                   ; CMP(Cmp_rm64_imm8) [RCX,20h:imm64]                   encoding(4 bytes) = 48 83 f9 20
008fh jb short 00ceh                ; JB(Jb_rel8_64) [CEh:jmp64]                           encoding(2 bytes) = 72 3d
0091h add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
0095h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0098h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
00a2h pext rax,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c1
00a7h shl eax,18h                   ; SHL(Shl_rm32_imm8) [EAX,18h:imm8]                    encoding(3 bytes) = c1 e0 18
00aah or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
00adh mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
00afh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
00b2h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00b6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00b7h call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F5655F0h:jmp64]                encoding(5 bytes) = e8 34 55 56 5f
00bch call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916770h:jmp64]        encoding(5 bytes) = e8 af 66 91 ff
00c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c2h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916770h:jmp64]        encoding(5 bytes) = e8 a9 66 91 ff
00c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c8h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916770h:jmp64]        encoding(5 bytes) = e8 a3 66 91 ff
00cdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00ceh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916770h:jmp64]        encoding(5 bytes) = e8 9d 66 91 ff
00d3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack32x1Bytes => new byte[212]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x44,0x8B,0x02,0x8B,0xC9,0x48,0x83,0xF9,0x08,0x0F,0x82,0xA2,0x00,0x00,0x00,0x4C,0x8B,0x08,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x45,0x0B,0xC1,0x44,0x89,0x02,0x44,0x8B,0x02,0x48,0x83,0xF9,0x10,0x0F,0x82,0x83,0x00,0x00,0x00,0x4C,0x8D,0x48,0x08,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x41,0xC1,0xE1,0x08,0x45,0x0B,0xC1,0x44,0x89,0x02,0x44,0x8B,0x02,0x48,0x83,0xF9,0x18,0x72,0x60,0x4C,0x8D,0x48,0x10,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x41,0xC1,0xE1,0x10,0x45,0x0B,0xC1,0x44,0x89,0x02,0x44,0x8B,0x02,0x48,0x83,0xF9,0x20,0x72,0x3D,0x48,0x83,0xC0,0x18,0x48,0x8B,0x00,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xFA,0xF5,0xC1,0xC1,0xE0,0x18,0x41,0x0B,0xC0,0x89,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x34,0x55,0x56,0x5F,0xE8,0xAF,0x66,0x91,0xFF,0xCC,0xE8,0xA9,0x66,0x91,0xFF,0xCC,0xE8,0xA3,0x66,0x91,0xFF,0xCC,0xE8,0x9D,0x66,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong pack64x1(Span<byte> src, ref ulong dst)
; location: [7FFDDB829850h, 7FFDDB8299F1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 08
000bh mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
000eh mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0010h cmp rcx,8                     ; CMP(Cmp_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 f9 08
0014h jb near ptr 0172h             ; JB(Jb_rel32_64) [172h:jmp64]                         encoding(6 bytes) = 0f 82 58 01 00 00
001ah mov r9,[rax]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 08
001dh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0027h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
002ch or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
002fh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
0032h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0035h cmp rcx,10h                   ; CMP(Cmp_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 f9 10
0039h jb near ptr 0178h             ; JB(Jb_rel32_64) [178h:jmp64]                         encoding(6 bytes) = 0f 82 39 01 00 00
003fh lea r9,[rax+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 08
0043h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0046h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0050h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0055h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
0059h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
005ch mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
005fh mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0062h cmp rcx,18h                   ; CMP(Cmp_rm64_imm8) [RCX,18h:imm64]                   encoding(4 bytes) = 48 83 f9 18
0066h jb near ptr 017eh             ; JB(Jb_rel32_64) [17Eh:jmp64]                         encoding(6 bytes) = 0f 82 12 01 00 00
006ch lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 10
0070h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0073h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
007dh pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0082h shl r9,10h                    ; SHL(Shl_rm64_imm8) [R9,10h:imm8]                     encoding(4 bytes) = 49 c1 e1 10
0086h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0089h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
008ch mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
008fh cmp rcx,20h                   ; CMP(Cmp_rm64_imm8) [RCX,20h:imm64]                   encoding(4 bytes) = 48 83 f9 20
0093h jb near ptr 0184h             ; JB(Jb_rel32_64) [184h:jmp64]                         encoding(6 bytes) = 0f 82 eb 00 00 00
0099h lea r9,[rax+18h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 18
009dh mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
00a0h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00aah pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
00afh shl r9,18h                    ; SHL(Shl_rm64_imm8) [R9,18h:imm8]                     encoding(4 bytes) = 49 c1 e1 18
00b3h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
00b6h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
00b9h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
00bch cmp rcx,28h                   ; CMP(Cmp_rm64_imm8) [RCX,28h:imm64]                   encoding(4 bytes) = 48 83 f9 28
00c0h jb near ptr 018ah             ; JB(Jb_rel32_64) [18Ah:jmp64]                         encoding(6 bytes) = 0f 82 c4 00 00 00
00c6h lea r9,[rax+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 20
00cah mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
00cdh mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00d7h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
00dch shl r9,20h                    ; SHL(Shl_rm64_imm8) [R9,20h:imm8]                     encoding(4 bytes) = 49 c1 e1 20
00e0h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
00e3h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
00e6h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
00e9h cmp rcx,30h                   ; CMP(Cmp_rm64_imm8) [RCX,30h:imm64]                   encoding(4 bytes) = 48 83 f9 30
00edh jb near ptr 0190h             ; JB(Jb_rel32_64) [190h:jmp64]                         encoding(6 bytes) = 0f 82 9d 00 00 00
00f3h lea r9,[rax+28h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 28
00f7h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
00fah mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0104h pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0109h shl r9,28h                    ; SHL(Shl_rm64_imm8) [R9,28h:imm8]                     encoding(4 bytes) = 49 c1 e1 28
010dh or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0110h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
0113h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
0116h cmp rcx,38h                   ; CMP(Cmp_rm64_imm8) [RCX,38h:imm64]                   encoding(4 bytes) = 48 83 f9 38
011ah jb short 0196h                ; JB(Jb_rel8_64) [196h:jmp64]                          encoding(2 bytes) = 72 7a
011ch lea r9,[rax+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 30
0120h mov r9,[r9]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,DS:sr)]          encoding(3 bytes) = 4d 8b 09
0123h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
012dh pext r9,r9,r10                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b2 f5 ca
0132h shl r9,30h                    ; SHL(Shl_rm64_imm8) [R9,30h:imm8]                     encoding(4 bytes) = 49 c1 e1 30
0136h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0139h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 02
013ch mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 02
013fh cmp rcx,40h                   ; CMP(Cmp_rm64_imm8) [RCX,40h:imm64]                   encoding(4 bytes) = 48 83 f9 40
0143h jb short 019ch                ; JB(Jb_rel8_64) [19Ch:jmp64]                          encoding(2 bytes) = 72 57
0145h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
0149h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
014ch mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0156h pext rax,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c1
015bh shl rax,38h                   ; SHL(Shl_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e0 38
015fh or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
0162h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0165h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0168h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
016ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
016dh call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F565500h:jmp64]                encoding(5 bytes) = e8 8e 53 56 5f
0172h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 09 65 91 ff
0177h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0178h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 03 65 91 ff
017dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
017eh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 fd 64 91 ff
0183h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0184h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 f7 64 91 ff
0189h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
018ah call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 f1 64 91 ff
018fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0190h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 eb 64 91 ff
0195h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0196h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 e5 64 91 ff
019bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
019ch call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916680h:jmp64]        encoding(5 bytes) = e8 df 64 91 ff
01a1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack64x1Bytes => new byte[418]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x4C,0x8B,0x02,0x8B,0xC9,0x48,0x83,0xF9,0x08,0x0F,0x82,0x58,0x01,0x00,0x00,0x4C,0x8B,0x08,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x10,0x0F,0x82,0x39,0x01,0x00,0x00,0x4C,0x8D,0x48,0x08,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x08,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x18,0x0F,0x82,0x12,0x01,0x00,0x00,0x4C,0x8D,0x48,0x10,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x10,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x20,0x0F,0x82,0xEB,0x00,0x00,0x00,0x4C,0x8D,0x48,0x18,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x18,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x28,0x0F,0x82,0xC4,0x00,0x00,0x00,0x4C,0x8D,0x48,0x20,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x20,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x30,0x0F,0x82,0x9D,0x00,0x00,0x00,0x4C,0x8D,0x48,0x28,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x28,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x38,0x72,0x7A,0x4C,0x8D,0x48,0x30,0x4D,0x8B,0x09,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB2,0xF5,0xCA,0x49,0xC1,0xE1,0x30,0x4D,0x0B,0xC1,0x4C,0x89,0x02,0x4C,0x8B,0x02,0x48,0x83,0xF9,0x40,0x72,0x57,0x48,0x83,0xC0,0x38,0x48,0x8B,0x00,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xFA,0xF5,0xC1,0x48,0xC1,0xE0,0x38,0x49,0x0B,0xC0,0x48,0x89,0x02,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8E,0x53,0x56,0x5F,0xE8,0x09,0x65,0x91,0xFF,0xCC,0xE8,0x03,0x65,0x91,0xFF,0xCC,0xE8,0xFD,0x64,0x91,0xFF,0xCC,0xE8,0xF7,0x64,0x91,0xFF,0xCC,0xE8,0xF1,0x64,0x91,0xFF,0xCC,0xE8,0xEB,0x64,0x91,0xFF,0xCC,0xE8,0xE5,0x64,0x91,0xFF,0xCC,0xE8,0xDF,0x64,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> unpack8x1(byte src)
; location: [7FFDDB829A10h, 7FFDDB829A51h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
000bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0011h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0018h ja short 003ch                ; JA(Ja_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 77 22
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh mov rdx,1E1FFD770A5h          ; MOV(Mov_r64_imm64) [RDX,1e1ffd770a5h:imm64]          encoding(10 bytes) = 48 ba a5 70 d7 ff e1 01 00 00
0027h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
002ah mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
002dh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,DS:sr),8h:imm32] encoding(7 bytes) = c7 41 08 08 00 00 00
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ch call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9164C0h:jmp64]        encoding(5 bytes) = e8 7f 64 91 ff
0041h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[66]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x8B,0xD0,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x22,0x48,0x63,0xC0,0x48,0xBA,0xA5,0x70,0xD7,0xFF,0xE1,0x01,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7F,0x64,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack8x1(byte src, Span<byte> dst)
; location: [7FFDDB829A70h, 7FFDDB829AC6h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0008h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000bh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0015h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
001ah call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903F88h:jmp64]        encoding(5 bytes) = e8 69 3f 90 ff
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
0045h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF490h:jmp64]                encoding(5 bytes) = e8 46 f4 9e 5d
004ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
004bh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
004fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0051h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916468h:jmp64]        encoding(5 bytes) = e8 12 64 91 ff
0056h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[87]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF2,0x0F,0xB6,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x69,0x3F,0x90,0xFF,0x48,0x8B,0x0E,0x8B,0x56,0x08,0x48,0x85,0xC0,0x75,0x08,0x45,0x33,0xC0,0x45,0x33,0xC9,0xEB,0x08,0x4C,0x8D,0x40,0x10,0x44,0x8B,0x48,0x08,0x44,0x3B,0xCA,0x77,0x12,0x49,0x8B,0xD0,0x4D,0x63,0xC1,0xE8,0x46,0xF4,0x9E,0x5D,0x90,0x48,0x83,0xC4,0x20,0x5E,0xC3,0xE8,0x12,0x64,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack16x1(ushort src, Span<byte> dst)
; location: [7FFDDB829AE0h, 7FFDDB829BABh]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0005h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0006h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0007h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0008h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0012h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0016h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
0019h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001ch movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
001fh sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
0022h movzx ebp,al                  ; MOVZX(Movzx_r32_rm8) [EBP,AL]                        encoding(4 bytes) = 40 0f b6 e8
0026h mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0028h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0032h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
0037h call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903F18h:jmp64]        encoding(5 bytes) = e8 dc 3e 90 ff
003ch test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
003fh jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 06
0041h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0043h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0045h jmp short 004eh               ; JMP(Jmp_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = eb 07
0047h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
004bh mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
004eh cmp ecx,ebx                   ; CMP(Cmp_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 3b cb
0050h ja short 00bah                ; JA(Ja_rel8_64) [BAh:jmp64]                           encoding(2 bytes) = 77 68
0052h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0055h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0058h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF420h:jmp64]                encoding(5 bytes) = e8 c3 f3 9e 5d
005dh cmp ebx,8                     ; CMP(Cmp_rm32_imm8) [EBX,8h:imm32]                    encoding(3 bytes) = 83 fb 08
0060h jb short 00c0h                ; JB(Jb_rel8_64) [C0h:jmp64]                           encoding(2 bytes) = 72 5e
0062h lea r14d,[rbx-8]              ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f8
0066h lea r15,[rdi+8]               ; LEA(Lea_r64_m) [R15,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 4c 8d 7f 08
006ah movzx ecx,bpl                 ; MOVZX(Movzx_r32_rm8) [ECX,BPL]                       encoding(4 bytes) = 40 0f b6 cd
006eh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0078h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
007dh call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903F18h:jmp64]        encoding(5 bytes) = e8 96 3e 90 ff
0082h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0085h jne short 008dh               ; JNE(Jne_rel8_64) [8Dh:jmp64]                         encoding(2 bytes) = 75 06
0087h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0089h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
008bh jmp short 0094h               ; JMP(Jmp_rel8_64) [94h:jmp64]                         encoding(2 bytes) = eb 07
008dh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0091h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0094h cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
0097h ja short 00c6h                ; JA(Ja_rel8_64) [C6h:jmp64]                           encoding(2 bytes) = 77 2d
0099h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
009ch mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
009fh call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF420h:jmp64]                encoding(5 bytes) = e8 7c f3 9e 5d
00a4h mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
00a7h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
00aah mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00adh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00b1h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00b2h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00b3h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00b4h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00b5h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00b7h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00b9h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00bah call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9163F8h:jmp64]        encoding(5 bytes) = e8 39 63 91 ff
00bfh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c0h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9163F0h:jmp64]        encoding(5 bytes) = e8 2b 63 91 ff
00c5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00c6h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9163F8h:jmp64]        encoding(5 bytes) = e8 2d 63 91 ff
00cbh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[204]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x0F,0xB7,0xCA,0x0F,0xB6,0xC9,0x0F,0xB7,0xC2,0xC1,0xF8,0x08,0x40,0x0F,0xB6,0xE8,0x8B,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0xDC,0x3E,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x3B,0xCB,0x77,0x68,0x4C,0x63,0xC1,0x48,0x8B,0xCF,0xE8,0xC3,0xF3,0x9E,0x5D,0x83,0xFB,0x08,0x72,0x5E,0x44,0x8D,0x73,0xF8,0x4C,0x8D,0x7F,0x08,0x40,0x0F,0xB6,0xCD,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x96,0x3E,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x77,0x2D,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0x7C,0xF3,0x9E,0x5D,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x39,0x63,0x91,0xFF,0xCC,0xE8,0x2B,0x63,0x91,0xFF,0xCC,0xE8,0x2D,0x63,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack16x1(ushort src)
; location: [7FFDDB829BD0h, 7FFDDB829CB6h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0005h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0006h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0007h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0008h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
0011h mov rcx,7FFDDB0FEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb0fea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 0f db fd 7f 00 00
001bh mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
0020h call 7FFE3AC645E0h            ; CALL(Call_rel32_64) [5F43AA10h:jmp64]                encoding(5 bytes) = e8 eb a9 43 5f
0025h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0029h mov ebx,10h                   ; MOV(Mov_r32_imm32) [EBX,10h:imm32]                   encoding(5 bytes) = bb 10 00 00 00
002eh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0031h movzx ecx,di                  ; MOVZX(Movzx_r32_rm16) [ECX,DI]                       encoding(3 bytes) = 0f b7 cf
0034h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0037h movzx eax,di                  ; MOVZX(Movzx_r32_rm16) [EAX,DI]                       encoding(3 bytes) = 0f b7 c7
003ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
003dh movzx edi,al                  ; MOVZX(Movzx_r32_rm8) [EDI,AL]                        encoding(4 bytes) = 40 0f b6 f8
0041h mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
0043h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
004dh pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
0052h call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903E28h:jmp64]        encoding(5 bytes) = e8 d1 3d 90 ff
0057h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
005ah jne short 0062h               ; JNE(Jne_rel8_64) [62h:jmp64]                         encoding(2 bytes) = 75 06
005ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
005eh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0060h jmp short 0069h               ; JMP(Jmp_rel8_64) [69h:jmp64]                         encoding(2 bytes) = eb 07
0062h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0066h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0069h cmp ecx,ebx                   ; CMP(Cmp_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 3b cb
006bh ja short 00d5h                ; JA(Ja_rel8_64) [D5h:jmp64]                           encoding(2 bytes) = 77 68
006dh movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0070h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0073h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF330h:jmp64]                encoding(5 bytes) = e8 b8 f2 9e 5d
0078h cmp ebx,8                     ; CMP(Cmp_rm32_imm8) [EBX,8h:imm32]                    encoding(3 bytes) = 83 fb 08
007bh jb short 00dbh                ; JB(Jb_rel8_64) [DBh:jmp64]                           encoding(2 bytes) = 72 5e
007dh lea r14d,[rbx-8]              ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f8
0081h lea r15,[rbp+8]               ; LEA(Lea_r64_m) [R15,mem(Unknown,RBP:br,SS:sr)]       encoding(4 bytes) = 4c 8d 7d 08
0085h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0089h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0093h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
0098h call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903E28h:jmp64]        encoding(5 bytes) = e8 8b 3d 90 ff
009dh test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
00a0h jne short 00a8h               ; JNE(Jne_rel8_64) [A8h:jmp64]                         encoding(2 bytes) = 75 06
00a2h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00a4h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00a6h jmp short 00afh               ; JMP(Jmp_rel8_64) [AFh:jmp64]                         encoding(2 bytes) = eb 07
00a8h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
00ach mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
00afh cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
00b2h ja short 00e1h                ; JA(Ja_rel8_64) [E1h:jmp64]                           encoding(2 bytes) = 77 2d
00b4h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
00b7h mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
00bah call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF330h:jmp64]                encoding(5 bytes) = e8 71 f2 9e 5d
00bfh mov [rsi],rbp                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RBP]        encoding(3 bytes) = 48 89 2e
00c2h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
00c5h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00c8h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00cch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00cdh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00ceh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00cfh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00d0h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00d2h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00d4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00d5h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916308h:jmp64]        encoding(5 bytes) = e8 2e 62 91 ff
00dah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00dbh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916300h:jmp64]        encoding(5 bytes) = e8 20 62 91 ff
00e0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00e1h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916308h:jmp64]        encoding(5 bytes) = e8 22 62 91 ff
00e6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[231]{0x41,0x57,0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0x0F,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0xEB,0xA9,0x43,0x5F,0x48,0x83,0xC0,0x10,0xBB,0x10,0x00,0x00,0x00,0x48,0x8B,0xE8,0x0F,0xB7,0xCF,0x0F,0xB6,0xC9,0x0F,0xB7,0xC7,0xC1,0xF8,0x08,0x40,0x0F,0xB6,0xF8,0x8B,0xC9,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0xD1,0x3D,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x3B,0xCB,0x77,0x68,0x4C,0x63,0xC1,0x48,0x8B,0xCD,0xE8,0xB8,0xF2,0x9E,0x5D,0x83,0xFB,0x08,0x72,0x5E,0x44,0x8D,0x73,0xF8,0x4C,0x8D,0x7D,0x08,0x40,0x0F,0xB6,0xCF,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x8B,0x3D,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x77,0x2D,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0x71,0xF2,0x9E,0x5D,0x48,0x89,0x2E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x2E,0x62,0x91,0xFF,0xCC,0xE8,0x20,0x62,0x91,0xFF,0xCC,0xE8,0x22,0x62,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack32x1(uint src, Span<byte> dst)
; location: [7FFDDB829CE0h, 7FFDDB829EA4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,[rdx]                 ; MOV(Mov_r64_rm64) [RSI,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 32
000bh mov edi,[rdx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 7a 08
000eh call 7FFDDB12D9E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903D08h:jmp64]        encoding(5 bytes) = e8 f5 3c 90 ff
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
003fh mov rcx,1E1FFD770A5h          ; MOV(Mov_r64_imm64) [RCX,1e1ffd770a5h:imm64]          encoding(10 bytes) = 48 b9 a5 70 d7 ff e1 01 00 00
0049h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
004ch test edi,edi                  ; TEST(Test_rm32_r32) [EDI,EDI]                        encoding(2 bytes) = 85 ff
004eh jb near ptr 017dh             ; JB(Jb_rel32_64) [17Dh:jmp64]                         encoding(6 bytes) = 0f 82 29 01 00 00
0054h cmp edi,8                     ; CMP(Cmp_rm32_imm8) [EDI,8h:imm32]                    encoding(3 bytes) = 83 ff 08
0057h jb near ptr 0183h             ; JB(Jb_rel32_64) [183h:jmp64]                         encoding(6 bytes) = 0f 82 26 01 00 00
005dh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0060h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
0066h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF220h:jmp64]                encoding(5 bytes) = e8 b5 f1 9e 5d
006bh cmp ebp,1                     ; CMP(Cmp_rm32_imm8) [EBP,1h:imm32]                    encoding(3 bytes) = 83 fd 01
006eh jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 4b 01 00 00
0074h movzx ecx,byte ptr [rbx+11h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 11
0078h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
007bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
007dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0081h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0088h ja near ptr 0189h             ; JA(Ja_rel32_64) [189h:jmp64]                         encoding(6 bytes) = 0f 87 fb 00 00 00
008eh movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0091h mov rcx,1E1FFD770A5h          ; MOV(Mov_r64_imm64) [RCX,1e1ffd770a5h:imm64]          encoding(10 bytes) = 48 b9 a5 70 d7 ff e1 01 00 00
009bh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
009eh cmp edi,8                     ; CMP(Cmp_rm32_imm8) [EDI,8h:imm32]                    encoding(3 bytes) = 83 ff 08
00a1h jb near ptr 018fh             ; JB(Jb_rel32_64) [18Fh:jmp64]                         encoding(6 bytes) = 0f 82 e8 00 00 00
00a7h lea ecx,[rdi-8]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDI:br,DS:sr)]       encoding(3 bytes) = 8d 4f f8
00aah lea r8,[rsi+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RSI:br,DS:sr)]        encoding(4 bytes) = 4c 8d 46 08
00aeh cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
00b1h jb near ptr 0195h             ; JB(Jb_rel32_64) [195h:jmp64]                         encoding(6 bytes) = 0f 82 de 00 00 00
00b7h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
00bah mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
00c0h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF220h:jmp64]                encoding(5 bytes) = e8 5b f1 9e 5d
00c5h cmp ebp,2                     ; CMP(Cmp_rm32_imm8) [EBP,2h:imm32]                    encoding(3 bytes) = 83 fd 02
00c8h jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 f1 00 00 00
00ceh movzx ecx,byte ptr [rbx+12h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 12
00d2h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
00d5h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00d7h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
00dbh cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
00e2h ja near ptr 019bh             ; JA(Ja_rel32_64) [19Bh:jmp64]                         encoding(6 bytes) = 0f 87 b3 00 00 00
00e8h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
00ebh mov rcx,1E1FFD770A5h          ; MOV(Mov_r64_imm64) [RCX,1e1ffd770a5h:imm64]          encoding(10 bytes) = 48 b9 a5 70 d7 ff e1 01 00 00
00f5h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
00f8h cmp edi,10h                   ; CMP(Cmp_rm32_imm8) [EDI,10h:imm32]                   encoding(3 bytes) = 83 ff 10
00fbh jb near ptr 01a1h             ; JB(Jb_rel32_64) [1A1h:jmp64]                         encoding(6 bytes) = 0f 82 a0 00 00 00
0101h lea ecx,[rdi-10h]             ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDI:br,DS:sr)]       encoding(3 bytes) = 8d 4f f0
0104h lea r8,[rsi+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSI:br,DS:sr)]        encoding(4 bytes) = 4c 8d 46 10
0108h cmp ecx,8                     ; CMP(Cmp_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 f9 08
010bh jb near ptr 01a7h             ; JB(Jb_rel32_64) [1A7h:jmp64]                         encoding(6 bytes) = 0f 82 96 00 00 00
0111h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0114h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
011ah call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF220h:jmp64]                encoding(5 bytes) = e8 01 f1 9e 5d
011fh cmp ebp,3                     ; CMP(Cmp_rm32_imm8) [EBP,3h:imm32]                    encoding(3 bytes) = 83 fd 03
0122h jbe near ptr 01bfh            ; JBE(Jbe_rel32_64) [1BFh:jmp64]                       encoding(6 bytes) = 0f 86 97 00 00 00
0128h movzx ecx,byte ptr [rbx+13h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RBX:br,DS:sr)]      encoding(4 bytes) = 0f b6 4b 13
012ch shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
012fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0131h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0135h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
013ch ja short 01adh                ; JA(Ja_rel8_64) [1ADh:jmp64]                          encoding(2 bytes) = 77 6f
013eh movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0141h mov rcx,1E1FFD770A5h          ; MOV(Mov_r64_imm64) [RCX,1e1ffd770a5h:imm64]          encoding(10 bytes) = 48 b9 a5 70 d7 ff e1 01 00 00
014bh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
014eh cmp edi,18h                   ; CMP(Cmp_rm32_imm8) [EDI,18h:imm32]                   encoding(3 bytes) = 83 ff 18
0151h jb short 01b3h                ; JB(Jb_rel8_64) [1B3h:jmp64]                          encoding(2 bytes) = 72 60
0153h add edi,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EDI,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c7 e8
0156h add rsi,18h                   ; ADD(Add_rm64_imm8) [RSI,18h:imm64]                   encoding(4 bytes) = 48 83 c6 18
015ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
015dh cmp edi,8                     ; CMP(Cmp_rm32_imm8) [EDI,8h:imm32]                    encoding(3 bytes) = 83 ff 08
0160h jb short 01b9h                ; JB(Jb_rel8_64) [1B9h:jmp64]                          encoding(2 bytes) = 72 57
0162h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
0168h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF220h:jmp64]                encoding(5 bytes) = e8 b3 f0 9e 5d
016dh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
016eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0172h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0173h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0174h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0175h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0176h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0177h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 74 60 91 ff
017ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
017dh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 6e 60 91 ff
0182h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0183h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F8h:jmp64]        encoding(5 bytes) = e8 70 60 91 ff
0188h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0189h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 62 60 91 ff
018eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
018fh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 5c 60 91 ff
0194h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0195h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F8h:jmp64]        encoding(5 bytes) = e8 5e 60 91 ff
019ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
019bh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 50 60 91 ff
01a0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01a1h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 4a 60 91 ff
01a6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01a7h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F8h:jmp64]        encoding(5 bytes) = e8 4c 60 91 ff
01ach int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01adh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 3e 60 91 ff
01b2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b3h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F0h:jmp64]        encoding(5 bytes) = e8 38 60 91 ff
01b8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b9h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9161F8h:jmp64]        encoding(5 bytes) = e8 3a 60 91 ff
01beh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01bfh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F565220h:jmp64]                encoding(5 bytes) = e8 5c 50 56 5f
01c4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1Bytes => new byte[453]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0x32,0x8B,0x7A,0x08,0xE8,0xF5,0x3C,0x90,0xFF,0x48,0x8B,0xD8,0x8B,0x6B,0x08,0x83,0xFD,0x00,0x0F,0x86,0x9D,0x01,0x00,0x00,0x0F,0xB6,0x4B,0x10,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x0F,0x87,0x3B,0x01,0x00,0x00,0x48,0x63,0xD1,0x48,0xB9,0xA5,0x70,0xD7,0xFF,0xE1,0x01,0x00,0x00,0x48,0x03,0xD1,0x85,0xFF,0x0F,0x82,0x29,0x01,0x00,0x00,0x83,0xFF,0x08,0x0F,0x82,0x26,0x01,0x00,0x00,0x48,0x8B,0xCE,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0xB5,0xF1,0x9E,0x5D,0x83,0xFD,0x01,0x0F,0x86,0x4B,0x01,0x00,0x00,0x0F,0xB6,0x4B,0x11,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x0F,0x87,0xFB,0x00,0x00,0x00,0x48,0x63,0xD1,0x48,0xB9,0xA5,0x70,0xD7,0xFF,0xE1,0x01,0x00,0x00,0x48,0x03,0xD1,0x83,0xFF,0x08,0x0F,0x82,0xE8,0x00,0x00,0x00,0x8D,0x4F,0xF8,0x4C,0x8D,0x46,0x08,0x83,0xF9,0x08,0x0F,0x82,0xDE,0x00,0x00,0x00,0x49,0x8B,0xC8,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x5B,0xF1,0x9E,0x5D,0x83,0xFD,0x02,0x0F,0x86,0xF1,0x00,0x00,0x00,0x0F,0xB6,0x4B,0x12,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x0F,0x87,0xB3,0x00,0x00,0x00,0x48,0x63,0xD1,0x48,0xB9,0xA5,0x70,0xD7,0xFF,0xE1,0x01,0x00,0x00,0x48,0x03,0xD1,0x83,0xFF,0x10,0x0F,0x82,0xA0,0x00,0x00,0x00,0x8D,0x4F,0xF0,0x4C,0x8D,0x46,0x10,0x83,0xF9,0x08,0x0F,0x82,0x96,0x00,0x00,0x00,0x49,0x8B,0xC8,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x01,0xF1,0x9E,0x5D,0x83,0xFD,0x03,0x0F,0x86,0x97,0x00,0x00,0x00,0x0F,0xB6,0x4B,0x13,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x6F,0x48,0x63,0xD1,0x48,0xB9,0xA5,0x70,0xD7,0xFF,0xE1,0x01,0x00,0x00,0x48,0x03,0xD1,0x83,0xFF,0x18,0x72,0x60,0x83,0xC7,0xE8,0x48,0x83,0xC6,0x18,0x48,0x8B,0xCE,0x83,0xFF,0x08,0x72,0x57,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0xB3,0xF0,0x9E,0x5D,0x90,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x74,0x60,0x91,0xFF,0xCC,0xE8,0x6E,0x60,0x91,0xFF,0xCC,0xE8,0x70,0x60,0x91,0xFF,0xCC,0xE8,0x62,0x60,0x91,0xFF,0xCC,0xE8,0x5C,0x60,0x91,0xFF,0xCC,0xE8,0x5E,0x60,0x91,0xFF,0xCC,0xE8,0x50,0x60,0x91,0xFF,0xCC,0xE8,0x4A,0x60,0x91,0xFF,0xCC,0xE8,0x4C,0x60,0x91,0xFF,0xCC,0xE8,0x3E,0x60,0x91,0xFF,0xCC,0xE8,0x38,0x60,0x91,0xFF,0xCC,0xE8,0x3A,0x60,0x91,0xFF,0xCC,0xE8,0x5C,0x50,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack32x1_bmi(uint src, Span<byte> dst)
; location: [7FFDDB829ED0h, 7FFDDB82A0A0h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r13                      ; PUSH(Push_r64) [R13]                                 encoding(2 bytes) = 41 55
0006h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0008h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0009h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
000ah push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
000bh push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ch sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0010h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0012h mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
0017h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 40
001ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0021h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0026h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0029h mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
002ch mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0030h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
0033h shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0036h movzx ebp,dx                  ; MOVZX(Movzx_r32_rm16) [EBP,DX]                       encoding(3 bytes) = 0f b7 ea
0039h mov r14,rdi                   ; MOV(Mov_r64_rm64) [R14,RDI]                          encoding(3 bytes) = 4c 8b f7
003ch mov r15d,ebx                  ; MOV(Mov_r32_rm32) [R15D,EBX]                         encoding(3 bytes) = 44 8b fb
003fh movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0042h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0045h movzx r12d,cl                 ; MOVZX(Movzx_r32_rm8) [R12D,CL]                       encoding(4 bytes) = 44 0f b6 e1
0049h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
004bh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0055h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
005ah call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903B28h:jmp64]        encoding(5 bytes) = e8 c9 3a 90 ff
005fh test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0062h jne short 006ah               ; JNE(Jne_rel8_64) [6Ah:jmp64]                         encoding(2 bytes) = 75 06
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0068h jmp short 0071h               ; JMP(Jmp_rel8_64) [71h:jmp64]                         encoding(2 bytes) = eb 07
006ah lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
006eh mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0071h cmp ecx,r15d                  ; CMP(Cmp_r32_rm32) [ECX,R15D]                         encoding(3 bytes) = 41 3b cf
0074h ja near ptr 01a7h             ; JA(Ja_rel32_64) [1A7h:jmp64]                         encoding(6 bytes) = 0f 87 2d 01 00 00
007ah movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
007dh mov rcx,r14                   ; MOV(Mov_r64_rm64) [RCX,R14]                          encoding(3 bytes) = 49 8b ce
0080h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF030h:jmp64]                encoding(5 bytes) = e8 ab ef 9e 5d
0085h cmp ebx,8                     ; CMP(Cmp_rm32_imm8) [EBX,8h:imm32]                    encoding(3 bytes) = 83 fb 08
0088h jb near ptr 01adh             ; JB(Jb_rel32_64) [1ADh:jmp64]                         encoding(6 bytes) = 0f 82 1f 01 00 00
008eh lea r14d,[rbx-8]              ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f8
0092h lea r15,[rdi+8]               ; LEA(Lea_r64_m) [R15,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 4c 8d 7f 08
0096h movzx ecx,r12b                ; MOVZX(Movzx_r32_rm8) [ECX,R12L]                      encoding(4 bytes) = 41 0f b6 cc
009ah mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00a4h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
00a9h call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903B28h:jmp64]        encoding(5 bytes) = e8 7a 3a 90 ff
00aeh test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
00b1h jne short 00b9h               ; JNE(Jne_rel8_64) [B9h:jmp64]                         encoding(2 bytes) = 75 06
00b3h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00b5h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
00b7h jmp short 00c0h               ; JMP(Jmp_rel8_64) [C0h:jmp64]                         encoding(2 bytes) = eb 07
00b9h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
00bdh mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
00c0h cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
00c3h ja near ptr 01b3h             ; JA(Ja_rel32_64) [1B3h:jmp64]                         encoding(6 bytes) = 0f 87 ea 00 00 00
00c9h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
00cch mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
00cfh call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF030h:jmp64]                encoding(5 bytes) = e8 5c ef 9e 5d
00d4h mov [rsp+38h],rdi             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDI]        encoding(5 bytes) = 48 89 7c 24 38
00d9h mov [rsp+40h],ebx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EBX]        encoding(4 bytes) = 89 5c 24 40
00ddh cmp ebx,10h                   ; CMP(Cmp_rm32_imm8) [EBX,10h:imm32]                   encoding(3 bytes) = 83 fb 10
00e0h jb near ptr 01b9h             ; JB(Jb_rel32_64) [1B9h:jmp64]                         encoding(6 bytes) = 0f 82 d3 00 00 00
00e6h lea r14d,[rbx-10h]            ; LEA(Lea_r32_m) [R14D,mem(Unknown,RBX:br,DS:sr)]      encoding(4 bytes) = 44 8d 73 f0
00eah lea r15,[rdi+10h]             ; LEA(Lea_r64_m) [R15,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 4c 8d 7f 10
00eeh movzx ecx,bp                  ; MOVZX(Movzx_r32_rm16) [ECX,BP]                       encoding(3 bytes) = 0f b7 cd
00f1h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
00f4h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
00f7h movzx ebp,cl                  ; MOVZX(Movzx_r32_rm8) [EBP,CL]                        encoding(4 bytes) = 40 0f b6 e9
00fbh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00fdh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0107h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
010ch call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903B28h:jmp64]        encoding(5 bytes) = e8 17 3a 90 ff
0111h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0114h jne short 011ch               ; JNE(Jne_rel8_64) [11Ch:jmp64]                        encoding(2 bytes) = 75 06
0116h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0118h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
011ah jmp short 0123h               ; JMP(Jmp_rel8_64) [123h:jmp64]                        encoding(2 bytes) = eb 07
011ch lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0120h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0123h cmp ecx,r14d                  ; CMP(Cmp_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 3b ce
0126h ja near ptr 01bfh             ; JA(Ja_rel32_64) [1BFh:jmp64]                         encoding(6 bytes) = 0f 87 93 00 00 00
012ch movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
012fh mov rcx,r15                   ; MOV(Mov_r64_rm64) [RCX,R15]                          encoding(3 bytes) = 49 8b cf
0132h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF030h:jmp64]                encoding(5 bytes) = e8 f9 ee 9e 5d
0137h cmp r14d,8                    ; CMP(Cmp_rm32_imm8) [R14D,8h:imm32]                   encoding(4 bytes) = 41 83 fe 08
013bh jb near ptr 01c5h             ; JB(Jb_rel32_64) [1C5h:jmp64]                         encoding(6 bytes) = 0f 82 84 00 00 00
0141h lea r12d,[r14-8]              ; LEA(Lea_r32_m) [R12D,mem(Unknown,R14:br,DS:sr)]      encoding(4 bytes) = 45 8d 66 f8
0145h lea r13,[r15+8]               ; LEA(Lea_r64_m) [R13,mem(Unknown,R15:br,DS:sr)]       encoding(4 bytes) = 4d 8d 6f 08
0149h movzx ecx,bpl                 ; MOVZX(Movzx_r32_rm8) [ECX,BPL]                       encoding(4 bytes) = 40 0f b6 cd
014dh mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
0157h pdep rcx,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c8
015ch call 7FFDDB12D9F8h            ; CALL(Call_rel32_64) [FFFFFFFFFF903B28h:jmp64]        encoding(5 bytes) = e8 c7 39 90 ff
0161h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0164h jne short 016ch               ; JNE(Jne_rel8_64) [16Ch:jmp64]                        encoding(2 bytes) = 75 06
0166h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0168h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
016ah jmp short 0173h               ; JMP(Jmp_rel8_64) [173h:jmp64]                        encoding(2 bytes) = eb 07
016ch lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0170h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0173h cmp ecx,r12d                  ; CMP(Cmp_r32_rm32) [ECX,R12D]                         encoding(3 bytes) = 41 3b cc
0176h ja short 01cbh                ; JA(Ja_rel8_64) [1CBh:jmp64]                          encoding(2 bytes) = 77 53
0178h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
017bh mov rcx,r13                   ; MOV(Mov_r64_rm64) [RCX,R13]                          encoding(3 bytes) = 49 8b cd
017eh call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EF030h:jmp64]                encoding(5 bytes) = e8 ad ee 9e 5d
0183h mov [rsp+28h],r15             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R15]        encoding(5 bytes) = 4c 89 7c 24 28
0188h mov [rsp+30h],r14d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R14D]       encoding(5 bytes) = 44 89 74 24 30
018dh mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
0190h mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
0193h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0196h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
019ah pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
019bh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
019ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
019dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
019eh pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
01a0h pop r13                       ; POP(Pop_r64) [R13]                                   encoding(2 bytes) = 41 5d
01a2h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
01a4h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
01a6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
01a7h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916008h:jmp64]        encoding(5 bytes) = e8 5c 5e 91 ff
01ach int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01adh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916000h:jmp64]        encoding(5 bytes) = e8 4e 5e 91 ff
01b2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b3h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916008h:jmp64]        encoding(5 bytes) = e8 50 5e 91 ff
01b8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b9h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916000h:jmp64]        encoding(5 bytes) = e8 42 5e 91 ff
01beh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01bfh call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916008h:jmp64]        encoding(5 bytes) = e8 44 5e 91 ff
01c4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01c5h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF916000h:jmp64]        encoding(5 bytes) = e8 36 5e 91 ff
01cah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01cbh call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF916008h:jmp64]        encoding(5 bytes) = e8 38 5e 91 ff
01d0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1_bmiBytes => new byte[465]{0x41,0x57,0x41,0x56,0x41,0x55,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x48,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x0F,0xB7,0xCA,0xC1,0xEA,0x10,0x0F,0xB7,0xEA,0x4C,0x8B,0xF7,0x44,0x8B,0xFB,0x0F,0xB6,0xC1,0xC1,0xF9,0x08,0x44,0x0F,0xB6,0xE1,0x8B,0xC8,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0xC9,0x3A,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCF,0x0F,0x87,0x2D,0x01,0x00,0x00,0x4C,0x63,0xC1,0x49,0x8B,0xCE,0xE8,0xAB,0xEF,0x9E,0x5D,0x83,0xFB,0x08,0x0F,0x82,0x1F,0x01,0x00,0x00,0x44,0x8D,0x73,0xF8,0x4C,0x8D,0x7F,0x08,0x41,0x0F,0xB6,0xCC,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x7A,0x3A,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x0F,0x87,0xEA,0x00,0x00,0x00,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0x5C,0xEF,0x9E,0x5D,0x48,0x89,0x7C,0x24,0x38,0x89,0x5C,0x24,0x40,0x83,0xFB,0x10,0x0F,0x82,0xD3,0x00,0x00,0x00,0x44,0x8D,0x73,0xF0,0x4C,0x8D,0x7F,0x10,0x0F,0xB7,0xCD,0x0F,0xB6,0xC1,0xC1,0xF9,0x08,0x40,0x0F,0xB6,0xE9,0x8B,0xC8,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0x17,0x3A,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCE,0x0F,0x87,0x93,0x00,0x00,0x00,0x4C,0x63,0xC1,0x49,0x8B,0xCF,0xE8,0xF9,0xEE,0x9E,0x5D,0x41,0x83,0xFE,0x08,0x0F,0x82,0x84,0x00,0x00,0x00,0x45,0x8D,0x66,0xF8,0x4D,0x8D,0x6F,0x08,0x40,0x0F,0xB6,0xCD,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xC8,0xE8,0xC7,0x39,0x90,0xFF,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x41,0x3B,0xCC,0x77,0x53,0x4C,0x63,0xC1,0x49,0x8B,0xCD,0xE8,0xAD,0xEE,0x9E,0x5D,0x4C,0x89,0x7C,0x24,0x28,0x44,0x89,0x74,0x24,0x30,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x48,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5D,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x5C,0x5E,0x91,0xFF,0xCC,0xE8,0x4E,0x5E,0x91,0xFF,0xCC,0xE8,0x50,0x5E,0x91,0xFF,0xCC,0xE8,0x42,0x5E,0x91,0xFF,0xCC,0xE8,0x44,0x5E,0x91,0xFF,0xCC,0xE8,0x36,0x5E,0x91,0xFF,0xCC,0xE8,0x38,0x5E,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack64x1(ulong src, Span<byte> dst)
; location: [7FFDDB82A0D0h, 7FFDDB82A160h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh lea rdi,[rsp+28h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 28
0010h mov ecx,0Ch                   ; MOV(Mov_r32_imm32) [ECX,ch:imm32]                    encoding(5 bytes) = b9 0c 00 00 00
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0019h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
001fh mov rdi,[r8]                  ; MOV(Mov_r64_rm64) [RDI,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 38
0022h mov ebx,[r8+8]                ; MOV(Mov_r32_rm32) [EBX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 58 08
0026h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0029h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
002dh mov ebp,edx                   ; MOV(Mov_r32_rm32) [EBP,EDX]                          encoding(2 bytes) = 8b ea
002fh lea rcx,[rsp+48h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 48
0034h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0037h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
003ch mov [r8],rdi                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RDI]         encoding(3 bytes) = 49 89 38
003fh mov [r8+8],ebx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EBX]         encoding(4 bytes) = 41 89 58 08
0043h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0048h call 7FFDDB829ED0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE00h:jmp64]        encoding(5 bytes) = e8 b3 fd ff ff
004dh mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
004fh cmp ebx,20h                   ; CMP(Cmp_rm32_imm8) [EBX,20h:imm32]                   encoding(3 bytes) = 83 fb 20
0052h jb short 008bh                ; JB(Jb_rel8_64) [8Bh:jmp64]                           encoding(2 bytes) = 72 37
0054h lea ecx,[rbx-20h]             ; LEA(Lea_r32_m) [ECX,mem(Unknown,RBX:br,DS:sr)]       encoding(3 bytes) = 8d 4b e0
0057h lea r8,[rdi+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RDI:br,DS:sr)]        encoding(4 bytes) = 4c 8d 47 20
005bh lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 38
0060h lea r9,[rsp+28h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 28
0065h mov [r9],r8                   ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),R8]          encoding(3 bytes) = 4d 89 01
0068h mov [r9+8],ecx                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),ECX]         encoding(4 bytes) = 41 89 49 08
006ch mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
006fh lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 28
0074h call 7FFDDB829ED0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE00h:jmp64]        encoding(5 bytes) = e8 87 fd ff ff
0079h mov [rsi],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 3e
007ch mov [rsi+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EBX]        encoding(3 bytes) = 89 5e 08
007fh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0082h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
0086h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0087h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0088h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0089h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
008ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
008bh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915E00h:jmp64]        encoding(5 bytes) = e8 70 5d 91 ff
0090h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack64x1Bytes => new byte[145]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x58,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x28,0xB9,0x0C,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x44,0x8B,0xC2,0x48,0xC1,0xEA,0x20,0x8B,0xEA,0x48,0x8D,0x4C,0x24,0x48,0x41,0x8B,0xD0,0x4C,0x8D,0x44,0x24,0x28,0x49,0x89,0x38,0x41,0x89,0x58,0x08,0x4C,0x8D,0x44,0x24,0x28,0xE8,0xB3,0xFD,0xFF,0xFF,0x8B,0xD5,0x83,0xFB,0x20,0x72,0x37,0x8D,0x4B,0xE0,0x4C,0x8D,0x47,0x20,0x48,0x8D,0x44,0x24,0x38,0x4C,0x8D,0x4C,0x24,0x28,0x4D,0x89,0x01,0x41,0x89,0x49,0x08,0x48,0x8B,0xC8,0x4C,0x8D,0x44,0x24,0x28,0xE8,0x87,0xFD,0xFF,0xFF,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x58,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x70,0x5D,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack8x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB82A180h, 7FFDDB82A22Bh]
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
0046h mov rcx,1E1FFD770A5h          ; MOV(Mov_r64_imm64) [RCX,1e1ffd770a5h:imm64]          encoding(10 bytes) = 48 b9 a5 70 d7 ff e1 01 00 00
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
0071h call 7FFE39218F00h            ; CALL(Call_rel32_64) [5D9EED80h:jmp64]                encoding(5 bytes) = e8 0a ed 9e 5d
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
009ah call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915D50h:jmp64]        encoding(5 bytes) = e8 b1 5c 91 ff
009fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00a0h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915D50h:jmp64]        encoding(5 bytes) = e8 ab 5c 91 ff
00a5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
00a6h call 7FFDDB13FED8h            ; CALL(Call_rel32_64) [FFFFFFFFFF915D58h:jmp64]        encoding(5 bytes) = e8 ad 5c 91 ff
00abh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[172]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x49,0x8B,0x38,0x41,0x8B,0x58,0x08,0x48,0x8B,0x2A,0x44,0x8B,0x72,0x08,0x45,0x33,0xFF,0x45,0x33,0xE4,0x45,0x85,0xF6,0x7E,0x58,0x49,0x63,0xCC,0x0F,0xB6,0x0C,0x29,0xC1,0xE1,0x03,0x8B,0xD1,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x57,0x48,0x63,0xD1,0x48,0xB9,0xA5,0x70,0xD7,0xFF,0xE1,0x01,0x00,0x00,0x48,0x03,0xD1,0x44,0x3B,0xFB,0x77,0x48,0x8B,0xCB,0x41,0x2B,0xCF,0x4D,0x63,0xC7,0x4C,0x03,0xC7,0x83,0xF9,0x08,0x72,0x3E,0x49,0x8B,0xC8,0x41,0xB8,0x08,0x00,0x00,0x00,0xE8,0x0A,0xED,0x9E,0x5D,0x41,0xFF,0xC4,0x41,0x83,0xC7,0x08,0x45,0x3B,0xE6,0x7C,0xA8,0x48,0x89,0x3E,0x89,0x5E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0xB1,0x5C,0x91,0xFF,0xCC,0xE8,0xAB,0x5C,0x91,0xFF,0xCC,0xE8,0xAD,0x5C,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack16x1(ReadOnlySpan<ushort> src, Span<byte> dst)
; location: [7FFDDB82A660h, 7FFDDB82A6A4h]
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
0031h call 7FFDDB82A180h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB20h:jmp64]        encoding(5 bytes) = e8 ea fa ff ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F5646F0h:jmp64]                encoding(5 bytes) = e8 ac 46 56 5f
0044h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[69]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x6B,0xD2,0x02,0x70,0x25,0x48,0x8B,0xC6,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x20,0xE8,0xEA,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xE8,0xAC,0x46,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack32x1(ReadOnlySpan<uint> src, Span<byte> dst)
; location: [7FFDDB82A6C0h, 7FFDDB82A704h]
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
0031h call 7FFDDB82A180h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFAC0h:jmp64]        encoding(5 bytes) = e8 8a fa ff ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F564690h:jmp64]                encoding(5 bytes) = e8 4c 46 56 5f
0044h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1Bytes => new byte[69]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x6B,0xD2,0x04,0x70,0x25,0x48,0x8B,0xC6,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x20,0xE8,0x8A,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xE8,0x4C,0x46,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> unpack64x1(ReadOnlySpan<ulong> src, Span<byte> dst)
; location: [7FFDDB82A720h, 7FFDDB82A764h]
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
0031h call 7FFDDB82A180h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFA60h:jmp64]        encoding(5 bytes) = e8 2a fa ff ff
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F564630h:jmp64]                encoding(5 bytes) = e8 ec 45 56 5f
0044h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack64x1Bytes => new byte[69]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x6B,0xD2,0x08,0x70,0x25,0x48,0x8B,0xC6,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x41,0x89,0x51,0x08,0x48,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x20,0xE8,0x2A,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xE8,0xEC,0x45,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x1(byte src, Span<byte> dst)
; location: [7FFDDB82A780h, 7FFDDB82A880h]
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
00fbh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F564780h:jmp64]                encoding(5 bytes) = e8 80 46 56 5f
0100h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part6x1Bytes => new byte[257]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xE7,0x00,0x00,0x00,0x0F,0xB6,0xC9,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xBA,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x8C,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x68,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x44,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x20,0x48,0x83,0xC0,0x05,0xBA,0x20,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0x0F,0xB6,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x80,0x46,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part7x1(uint src, Span<byte> dst)
; location: [7FFDDB82A8A0h, 7FFDDB82A9AAh]
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
0105h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F564660h:jmp64]                encoding(5 bytes) = e8 56 45 56 5f
010ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part7x1Bytes => new byte[267]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xF1,0x00,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xCB,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x5D,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x3D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x1D,0x48,0x83,0xC0,0x06,0xBA,0x40,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x56,0x45,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x1(uint src, Span<byte> dst)
; location: [7FFDDB82A9C0h, 7FFDDB82AAEEh]
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
0129h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F564540h:jmp64]                encoding(5 bytes) = e8 12 44 56 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part8x1Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x80,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x12,0x44,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part9x1(uint src, Span<byte> dst)
; location: [7FFDDB82AB10h, 7FFDDB82AC62h]
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
014dh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5643F0h:jmp64]                encoding(5 bytes) = e8 9e 42 56 5f
0152h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part9x1Bytes => new byte[339]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x39,0x01,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x13,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x5D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x3D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x80,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x1D,0x48,0x83,0xC0,0x08,0xBA,0x00,0x01,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x9E,0x42,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part10x1(ushort src, Span<byte> dst)
; location: [7FFDDB82AC80h, 7FFDDB82ADF9h]
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
0174h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F564280h:jmp64]                encoding(5 bytes) = e8 07 41 56 5f
0179h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part10x1Bytes => new byte[378]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x60,0x01,0x00,0x00,0x0F,0xB7,0xC9,0x41,0xB8,0x01,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x01,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x37,0x01,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x02,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x01,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x0D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x04,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x08,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x10,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x20,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x5D,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x80,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x76,0x3D,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x09,0x76,0x1D,0x48,0x83,0xC0,0x09,0xBA,0x00,0x02,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x07,0x41,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong project8x64(byte src, ref ulong dst)
; location: [7FFDDB82AE10h, 7FFDDB82AE2Dh]
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
; location: [7FFDDB82AE40h, 7FFDDB82AF71h]
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
010fh call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F563F10h:jmp64]                encoding(5 bytes) = e8 fc 3d 56 5f
0114h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915090h:jmp64]        encoding(5 bytes) = e8 77 4f 91 ff
0119h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
011ah call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915090h:jmp64]        encoding(5 bytes) = e8 71 4f 91 ff
011fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0120h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915090h:jmp64]        encoding(5 bytes) = e8 6b 4f 91 ff
0125h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0126h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF915090h:jmp64]        encoding(5 bytes) = e8 65 4f 91 ff
012bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
012ch call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5640C0h:jmp64]                encoding(5 bytes) = e8 8f 3f 56 5f
0131h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x1Bytes => new byte[306]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x8B,0xCA,0x49,0x83,0xF9,0x08,0x0F,0x82,0xED,0x00,0x00,0x00,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x83,0xF9,0x00,0x0F,0x86,0xF5,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x8B,0xCA,0x49,0x83,0xF9,0x10,0x0F,0x82,0xB1,0x00,0x00,0x00,0x4C,0x8D,0x48,0x08,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x0F,0x86,0xAF,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC2,0x4D,0x89,0x01,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x8B,0xCA,0x49,0x83,0xF9,0x18,0x72,0x75,0x4C,0x8D,0x48,0x10,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x83,0xFA,0x00,0x76,0x71,0x45,0x0F,0xB6,0xC0,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC2,0x4D,0x89,0x01,0x41,0xB8,0x00,0x00,0x00,0xFF,0xC4,0xC2,0x72,0xF5,0xC8,0x0F,0xB6,0xC9,0x8B,0xD2,0x48,0x83,0xFA,0x20,0x72,0x3F,0x48,0x83,0xC0,0x18,0xBA,0x01,0x00,0x00,0x00,0x83,0xFA,0x00,0x76,0x37,0x0F,0xB6,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFC,0x3D,0x56,0x5F,0xE8,0x77,0x4F,0x91,0xFF,0xCC,0xE8,0x71,0x4F,0x91,0xFF,0xCC,0xE8,0x6B,0x4F,0x91,0xFF,0xCC,0xE8,0x65,0x4F,0x91,0xFF,0xCC,0xE8,0x8F,0x3F,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, Span<byte> dst)
; location: [7FFDDB82AF90h, 7FFDDB82B153h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
000bh cmp rdx,8                     ; CMP(Cmp_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 fa 08
000fh jb near ptr 0194h             ; JB(Jb_rel32_64) [194h:jmp64]                         encoding(6 bytes) = 0f 82 7f 01 00 00
0015h mov r8d,0FFh                  ; MOV(Mov_r32_imm32) [R8D,ffh:imm32]                   encoding(6 bytes) = 41 b8 ff 00 00 00
001bh pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0020h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0024h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
002eh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0033h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0036h cmp rdx,10h                   ; CMP(Cmp_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 fa 10
003ah jb near ptr 019ah             ; JB(Jb_rel32_64) [19Ah:jmp64]                         encoding(6 bytes) = 0f 82 5a 01 00 00
0040h lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 08
0044h mov r9d,0FF00h                ; MOV(Mov_r32_imm32) [R9D,ff00h:imm32]                 encoding(6 bytes) = 41 b9 00 ff 00 00
004ah pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
004fh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0053h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
005dh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0062h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0065h cmp rdx,18h                   ; CMP(Cmp_rm64_imm8) [RDX,18h:imm64]                   encoding(4 bytes) = 48 83 fa 18
0069h jb near ptr 01a0h             ; JB(Jb_rel32_64) [1A0h:jmp64]                         encoding(6 bytes) = 0f 82 31 01 00 00
006fh lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 10
0073h mov r9d,0FF0000h              ; MOV(Mov_r32_imm32) [R9D,ff0000h:imm32]               encoding(6 bytes) = 41 b9 00 00 ff 00
0079h pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
007eh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0082h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
008ch pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0091h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0094h cmp rdx,20h                   ; CMP(Cmp_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 fa 20
0098h jb near ptr 01a6h             ; JB(Jb_rel32_64) [1A6h:jmp64]                         encoding(6 bytes) = 0f 82 08 01 00 00
009eh lea r8,[rax+18h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 18
00a2h mov r9d,0FF000000h            ; MOV(Mov_r32_imm32) [R9D,ff000000h:imm32]             encoding(6 bytes) = 41 b9 00 00 00 ff
00a8h pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
00adh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00b1h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00bbh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
00c0h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
00c3h cmp rdx,28h                   ; CMP(Cmp_rm64_imm8) [RDX,28h:imm64]                   encoding(4 bytes) = 48 83 fa 28
00c7h jb near ptr 01ach             ; JB(Jb_rel32_64) [1ACh:jmp64]                         encoding(6 bytes) = 0f 82 df 00 00 00
00cdh lea r8,[rax+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 20
00d1h mov r9,0FF00000000h           ; MOV(Mov_r64_imm64) [R9,ff00000000h:imm64]            encoding(10 bytes) = 49 b9 00 00 00 00 ff 00 00 00
00dbh pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
00e0h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00e4h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
00eeh pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
00f3h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
00f6h cmp rdx,30h                   ; CMP(Cmp_rm64_imm8) [RDX,30h:imm64]                   encoding(4 bytes) = 48 83 fa 30
00fah jb near ptr 01b2h             ; JB(Jb_rel32_64) [1B2h:jmp64]                         encoding(6 bytes) = 0f 82 b2 00 00 00
0100h lea r8,[rax+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 28
0104h mov r9,0FF0000000000h         ; MOV(Mov_r64_imm64) [R9,ff0000000000h:imm64]          encoding(10 bytes) = 49 b9 00 00 00 00 00 ff 00 00
010eh pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
0113h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0117h mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0121h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0126h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
0129h cmp rdx,38h                   ; CMP(Cmp_rm64_imm8) [RDX,38h:imm64]                   encoding(4 bytes) = 48 83 fa 38
012dh jb near ptr 01b8h             ; JB(Jb_rel32_64) [1B8h:jmp64]                         encoding(6 bytes) = 0f 82 85 00 00 00
0133h lea r8,[rax+30h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 40 30
0137h mov r9,0FF000000000000h       ; MOV(Mov_r64_imm64) [R9,ff000000000000h:imm64]        encoding(10 bytes) = 49 b9 00 00 00 00 00 00 ff 00
0141h pext r9,rcx,r9                ; PEXT(VEX_Pext_r64_r64_rm64) [R9,RCX,R9]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c9
0146h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
014ah mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0154h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0159h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),R9]          encoding(3 bytes) = 4d 89 08
015ch cmp rdx,40h                   ; CMP(Cmp_rm64_imm8) [RDX,40h:imm64]                   encoding(4 bytes) = 48 83 fa 40
0160h jb short 01beh                ; JB(Jb_rel8_64) [1BEh:jmp64]                          encoding(2 bytes) = 72 5c
0162h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
0166h mov rdx,0FF00000000000000h    ; MOV(Mov_r64_imm64) [RDX,ff00000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 ff
0170h pext rdx,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 d2
0175h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0178h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0182h pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0187h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
018ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
018eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
018fh call 7FFE3AD8ED50h            ; CALL(Call_rel32_64) [5F563DC0h:jmp64]                encoding(5 bytes) = e8 2c 3c 56 5f
0194h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 a7 4d 91 ff
0199h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
019ah call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 a1 4d 91 ff
019fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01a0h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 9b 4d 91 ff
01a5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01a6h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 95 4d 91 ff
01abh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01ach call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 8f 4d 91 ff
01b1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b2h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 89 4d 91 ff
01b7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01b8h call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 83 4d 91 ff
01bdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
01beh call 7FFDDB13FED0h            ; CALL(Call_rel32_64) [FFFFFFFFFF914F40h:jmp64]        encoding(5 bytes) = e8 7d 4d 91 ff
01c3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1Bytes => new byte[452]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x83,0xFA,0x08,0x0F,0x82,0x7F,0x01,0x00,0x00,0x41,0xB8,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x83,0xFA,0x10,0x0F,0x82,0x5A,0x01,0x00,0x00,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x18,0x0F,0x82,0x31,0x01,0x00,0x00,0x4C,0x8D,0x40,0x10,0x41,0xB9,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x20,0x0F,0x82,0x08,0x01,0x00,0x00,0x4C,0x8D,0x40,0x18,0x41,0xB9,0x00,0x00,0x00,0xFF,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x28,0x0F,0x82,0xDF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x20,0x49,0xB9,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x30,0x0F,0x82,0xB2,0x00,0x00,0x00,0x4C,0x8D,0x40,0x28,0x49,0xB9,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x38,0x0F,0x82,0x85,0x00,0x00,0x00,0x4C,0x8D,0x40,0x30,0x49,0xB9,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC9,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x48,0x83,0xFA,0x40,0x72,0x5C,0x48,0x83,0xC0,0x38,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xC4,0xE2,0xF2,0xF5,0xD2,0x0F,0xB6,0xD2,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x2C,0x3C,0x56,0x5F,0xE8,0xA7,0x4D,0x91,0xFF,0xCC,0xE8,0xA1,0x4D,0x91,0xFF,0xCC,0xE8,0x9B,0x4D,0x91,0xFF,0xCC,0xE8,0x95,0x4D,0x91,0xFF,0xCC,0xE8,0x8F,0x4D,0x91,0xFF,0xCC,0xE8,0x89,0x4D,0x91,0xFF,0xCC,0xE8,0x83,0x4D,0x91,0xFF,0xCC,0xE8,0x7D,0x4D,0x91,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part1x1:uint part)
; location: [7FFDDB82B170h, 7FFDDB82B17Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part2x1:uint part)
; location: [7FFDDB82B190h, 7FFDDB82B19Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part3x1:uint part)
; location: [7FFDDB82B1B0h, 7FFDDB82B1BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part4x1:uint part)
; location: [7FFDDB82B1D0h, 7FFDDB82B1DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part5x1:uint part)
; location: [7FFDDB82B1F0h, 7FFDDB82B1FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x1:uint part)
; location: [7FFDDB82B210h, 7FFDDB82B21Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part7x1:uint part)
; location: [7FFDDB82B230h, 7FFDDB82B23Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x1:uint part)
; location: [7FFDDB82B250h, 7FFDDB82B25Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x1:uint part)
; location: [7FFDDB82B270h, 7FFDDB82B27Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x1:uint part)
; location: [7FFDDB82B290h, 7FFDDB82B29Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part11x1:uint part)
; location: [7FFDDB82B2B0h, 7FFDDB82B2BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x1:uint part)
; location: [7FFDDB82B2D0h, 7FFDDB82B2DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part13x1:uint part)
; location: [7FFDDB82B2F0h, 7FFDDB82B2FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x1:uint part)
; location: [7FFDDB82B310h, 7FFDDB82B31Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x1:uint part)
; location: [7FFDDB82B330h, 7FFDDB82B33Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x1:ulong part)
; location: [7FFDDB82B350h, 7FFDDB82B35Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part1x1:uint part)
; location: [7FFDDB82B370h, 7FFDDB82B37Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part2x1:uint part)
; location: [7FFDDB82B390h, 7FFDDB82B39Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part3x1:uint part)
; location: [7FFDDB82B3B0h, 7FFDDB82B3BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part4x1:uint part)
; location: [7FFDDB82B3D0h, 7FFDDB82B3DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part5x1:uint part)
; location: [7FFDDB82B3F0h, 7FFDDB82B3FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(uint src, Part6x1:uint part)
; location: [7FFDDB82B410h, 7FFDDB82B41Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part7x1:uint part)
; location: [7FFDDB82B430h, 7FFDDB82B43Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x1:uint part)
; location: [7FFDDB82B450h, 7FFDDB82B45Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x1:uint part)
; location: [7FFDDB82B470h, 7FFDDB82B47Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x1:uint part)
; location: [7FFDDB82B490h, 7FFDDB82B49Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part11x1:uint part)
; location: [7FFDDB82B4B0h, 7FFDDB82B4BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x1:uint part)
; location: [7FFDDB82B4D0h, 7FFDDB82B4DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part13x1:uint part)
; location: [7FFDDB82B4F0h, 7FFDDB82B4FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x1:uint part)
; location: [7FFDDB82B510h, 7FFDDB82B51Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x1:uint part)
; location: [7FFDDB82B530h, 7FFDDB82B53Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x1:ulong part)
; location: [7FFDDB82B550h, 7FFDDB82B55Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x2(uint src, Span<byte> dst)
; location: [7FFDDB82B570h, 7FFDDB82B60Eh]
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
0099h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F563990h:jmp64]                encoding(5 bytes) = e8 f2 38 56 5f
009eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part8x2Bytes => new byte[159]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x85,0x00,0x00,0x00,0x41,0xB8,0x03,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x03,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x63,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x0C,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x03,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x3D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x30,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x1D,0x48,0x83,0xC0,0x03,0xBA,0xC0,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF2,0x38,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x2(uint src, Span<byte> dst)
; location: [7FFDDB82B630h, 7FFDDB82B75Eh]
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
0129h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5638D0h:jmp64]                encoding(5 bytes) = e8 a2 37 56 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x2Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x03,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x03,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x0C,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x03,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x30,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0xC0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x03,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x0C,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x30,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x00,0xC0,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA2,0x37,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x2(uint src, Span<byte> dst)
; location: [7FFDDB82B780h, 7FFDDB82B9CEh]
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
0249h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F563780h:jmp64]                encoding(5 bytes) = e8 32 35 56 5f
024eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x2Bytes => new byte[591]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x35,0x02,0x00,0x00,0x41,0xB8,0x03,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x03,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x0F,0x02,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x0C,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x03,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xE5,0x01,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0x30,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xC1,0x01,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0xC0,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x9D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x03,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x0F,0x86,0x79,0x01,0x00,0x00,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x0C,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x0F,0x86,0x55,0x01,0x00,0x00,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x30,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x0F,0x86,0x31,0x01,0x00,0x00,0x4C,0x8D,0x40,0x07,0x41,0xB9,0x00,0xC0,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x08,0x0F,0x86,0x0D,0x01,0x00,0x00,0x4C,0x8D,0x40,0x08,0x41,0xB9,0x00,0x00,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x09,0x0F,0x86,0xE9,0x00,0x00,0x00,0x4C,0x8D,0x40,0x09,0x41,0xB9,0x00,0x00,0x0C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0A,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x0A,0x41,0xB9,0x00,0x00,0x30,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0B,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x0B,0x41,0xB9,0x00,0x00,0xC0,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0C,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x0C,0x41,0xB9,0x00,0x00,0x00,0x03,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0D,0x76,0x5D,0x4C,0x8D,0x40,0x0D,0x41,0xB9,0x00,0x00,0x00,0x0C,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0E,0x76,0x3D,0x4C,0x8D,0x40,0x0E,0x41,0xB9,0x00,0x00,0x00,0x30,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x0F,0x76,0x1D,0x48,0x83,0xC0,0x0F,0xBA,0x00,0x00,0x00,0xC0,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x32,0x35,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte project(byte src, Part4x2:uint part)
; location: [7FFDDB82B9F0h, 7FFDDB82BA03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte project(byte src, Part6x2:uint part)
; location: [7FFDDB82BA20h, 7FFDDB82BA33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x2:uint part)
; location: [7FFDDB82BA50h, 7FFDDB82BA5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x2:uint part)
; location: [7FFDDB82BA70h, 7FFDDB82BA7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x2:uint part)
; location: [7FFDDB82BA90h, 7FFDDB82BA9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x2:uint part)
; location: [7FFDDB82BAB0h, 7FFDDB82BABAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x2:uint part)
; location: [7FFDDB82BAD0h, 7FFDDB82BADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x2:uint part)
; location: [7FFDDB82BAF0h, 7FFDDB82BAFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part4x2:uint part)
; location: [7FFDDB82BB10h, 7FFDDB82BB1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x2:uint part)
; location: [7FFDDB82BB30h, 7FFDDB82BB3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x2:uint part)
; location: [7FFDDB82BB50h, 7FFDDB82BB5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x2:uint part)
; location: [7FFDDB82BB70h, 7FFDDB82BB7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x2:uint part)
; location: [7FFDDB82BB90h, 7FFDDB82BB9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x2:uint part)
; location: [7FFDDB82BBB0h, 7FFDDB82BBBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x3(uint src, Span<byte> dst)
; location: [7FFDDB82BBD0h, 7FFDDB82BC23h]
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
004eh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F563330h:jmp64]                encoding(5 bytes) = e8 dd 32 56 5f
0053h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part6x3Bytes => new byte[84]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x3E,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x1C,0x48,0xFF,0xC0,0xBA,0x38,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD1,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xDD,0x32,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part9x3(uint src, Span<byte> dst)
; location: [7FFDDB82BC40h, 7FFDDB82BCBAh]
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
0075h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F5632C0h:jmp64]                encoding(5 bytes) = e8 46 32 56 5f
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part9x3Bytes => new byte[123]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x76,0x65,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x43,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x1D,0x48,0x83,0xC0,0x02,0xBA,0xC0,0x01,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x46,0x32,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x3(uint src, Span<byte> dst)
; location: [7FFDDB82BCD0h, 7FFDDB82BD6Eh]
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
0099h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F563230h:jmp64]                encoding(5 bytes) = e8 92 31 56 5f
009eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part12x3Bytes => new byte[159]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x85,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x76,0x63,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x3D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x1D,0x48,0x83,0xC0,0x03,0xBA,0x00,0x0E,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x92,0x31,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part15x3(uint src, Span<byte> dst)
; location: [7FFDDB82BD90h, 7FFDDB82BE52h]
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
00bdh call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F563170h:jmp64]                encoding(5 bytes) = e8 ae 30 56 5f
00c2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part15x3Bytes => new byte[195]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xA9,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0x83,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x76,0x5D,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x3D,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x1D,0x48,0x83,0xC0,0x04,0xBA,0x00,0x70,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xAE,0x30,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part18x3(uint src, Span<byte> dst)
; location: [7FFDDB82BE70h, 7FFDDB82BF56h]
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
00e1h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F563090h:jmp64]                encoding(5 bytes) = e8 aa 2f 56 5f
00e6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part18x3Bytes => new byte[231]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xCD,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xA7,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x76,0x5D,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x3D,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x1D,0x48,0x83,0xC0,0x05,0xBA,0x00,0x80,0x03,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xAA,0x2F,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part21x3(uint src, Span<byte> dst)
; location: [7FFDDB82BF70h, 7FFDDB82C07Ah]
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
0105h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F562F90h:jmp64]                encoding(5 bytes) = e8 86 2e 56 5f
010ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part21x3Bytes => new byte[267]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0xF1,0x00,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xCB,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x76,0x5D,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x3D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x1D,0x48,0x83,0xC0,0x06,0xBA,0x00,0x00,0x1C,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x86,0x2E,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part24x3(uint src, Span<byte> dst)
; location: [7FFDDB82C090h, 7FFDDB82C1BEh]
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
0129h call 7FFE3AD8EF00h            ; CALL(Call_rel32_64) [5F562E70h:jmp64]                encoding(5 bytes) = e8 42 2d 56 5f
012eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part24x3Bytes => new byte[303]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x83,0xFA,0x00,0x0F,0x86,0x15,0x01,0x00,0x00,0x41,0xB8,0x07,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x41,0xB9,0x07,0x00,0x00,0x00,0xC4,0x42,0x3B,0xF5,0xC1,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x00,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x00,0x00,0x00,0x4C,0x8D,0x40,0x01,0x41,0xB9,0x38,0x00,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0x41,0xBA,0x07,0x00,0x00,0x00,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x02,0x0F,0x86,0xC5,0x00,0x00,0x00,0x4C,0x8D,0x40,0x02,0x41,0xB9,0xC0,0x01,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x03,0x0F,0x86,0xA1,0x00,0x00,0x00,0x4C,0x8D,0x40,0x03,0x41,0xB9,0x00,0x0E,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x04,0x0F,0x86,0x7D,0x00,0x00,0x00,0x4C,0x8D,0x40,0x04,0x41,0xB9,0x00,0x70,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x05,0x76,0x5D,0x4C,0x8D,0x40,0x05,0x41,0xB9,0x00,0x80,0x03,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x06,0x76,0x3D,0x4C,0x8D,0x40,0x06,0x41,0xB9,0x00,0x00,0x1C,0x00,0xC4,0x42,0x72,0xF5,0xC9,0xC4,0x42,0x33,0xF5,0xCA,0x45,0x0F,0xB6,0xC9,0x45,0x88,0x08,0x83,0xFA,0x07,0x76,0x1D,0x48,0x83,0xC0,0x07,0xBA,0x00,0x00,0xE0,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0xC4,0xC2,0x6B,0xF5,0xD2,0x0F,0xB6,0xD2,0x88,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x42,0x2D,0x56,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
