; 2019-12-04 23:04:08:150
; function: BitVector16 bm_16x4_col_literal(in BitMatrix16x4 A)
; location: [7FFDDAF2D600h, 7FFDDAF2D61Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,4444444444444444h     ; MOV(Mov_r64_imm64) [RDX,4444444444444444h:imm64]     encoding(10 bytes) = 48 ba 44 44 44 44 44 44 44 44
0012h pext rax,rax,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bm_16x4_col_literalBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xBA,0x44,0x44,0x44,0x44,0x44,0x44,0x44,0x44,0xC4,0xE2,0xFA,0xF5,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 bm_8x8_col_literal(in BitMatrix8 A)
; location: [7FFDDAF2DD00h, 7FFDDAF2DD3Ch]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000eh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0012h vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0020h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0023h mov rdx,404040404040404h      ; MOV(Mov_r64_imm64) [RDX,404040404040404h:imm64]      encoding(10 bytes) = 48 ba 04 04 04 04 04 04 04 04
002dh pext rax,rax,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c2
0032h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0035h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0038h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bm_8x8_col_literalBytes => new byte[61]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x8B,0x00,0x48,0x8B,0x00,0x48,0xBA,0x04,0x04,0x04,0x04,0x04,0x04,0x04,0x04,0xC4,0xE2,0xFA,0xF5,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 bm_16x4_col_index(in BitMatrix16x4 A, int index)
; location: [7FFDDAF2DD60h, 7FFDDAF2DD82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov r8,1111111111111111h      ; MOV(Mov_r64_imm64) [R8,1111111111111111h:imm64]      encoding(10 bytes) = 49 b8 11 11 11 11 11 11 11 11
0012h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0014h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0017h pext rax,rax,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fa f5 c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bm_16x4_col_indexBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x49,0xB8,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x8B,0xCA,0x49,0xD3,0xE0,0xC4,0xC2,0xFA,0xF5,0xC0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void transpose_8x8_1(in BitMatrix8 A, ref BitMatrix8 Z)
; location: [7FFDDAF2E770h, 7FFDDAF2E7C8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000eh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0012h vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0020h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0023h vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0028h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
002dh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 0a
0030h movsxd r8,eax                 ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]                     encoding(3 bytes) = 4c 63 c0
0033h add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
0036h vpmovmskb r8d,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [R8D,XMM0]          encoding(VEX, 4 bytes) = c5 79 d7 c0
003ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
003eh mov [rcx],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,:sr),R8L]             encoding(3 bytes) = 44 88 01
0041h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0046h vmovd xmm1,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e c9
004ah vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
004eh dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
0050h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0052h jge short 002dh               ; JGE(Jge_rel8_64) [2Dh:jmp64]                         encoding(2 bytes) = 7d d9
0054h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> transpose_8x8_1Bytes => new byte[89]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x8B,0x00,0x48,0x8B,0x00,0xC4,0xE1,0xF9,0x6E,0xC0,0xB8,0x07,0x00,0x00,0x00,0x48,0x8B,0x0A,0x4C,0x63,0xC0,0x49,0x03,0xC8,0xC5,0x79,0xD7,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x01,0xB9,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC9,0xC5,0xF9,0xF3,0xC1,0xFF,0xC8,0x85,0xC0,0x7D,0xD9,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void transpose_8x8_2(in BitMatrix8 A, ref BitMatrix8 Z)
; location: [7FFDDAF2E7F0h, 7FFDDAF2E84Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000eh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0012h vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0018h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 08
001dh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
0020h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0023h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0026h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0029h mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0033h pext r10,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [R10,RAX,RCX]            encoding(VEX, 5 bytes) = c4 62 fa f5 d1
0038h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
003bh shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
003eh shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0041h or r8,r10                     ; OR(Or_r64_rm64) [R8,R10]                             encoding(3 bytes) = 4d 0b c2
0044h shr rax,1                     ; SHR(Shr_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e8
0047h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
004ah cmp r9d,8                     ; CMP(Cmp_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 f9 08
004eh jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c d9
0050h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0053h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0056h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> transpose_8x8_2Bytes => new byte[91]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x48,0x8B,0x09,0x48,0x8B,0x01,0x45,0x33,0xC0,0x45,0x33,0xC9,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x62,0xFA,0xF5,0xD1,0x41,0x8B,0xC9,0xC1,0xE1,0x03,0x49,0xD3,0xE2,0x4D,0x0B,0xC2,0x48,0xD1,0xE8,0x41,0xFF,0xC1,0x41,0x83,0xF9,0x08,0x7C,0xD9,0x48,0x8B,0x02,0x4C,0x89,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void transpose_8x8_3(in BitMatrix8 A, ref BitMatrix8 Z)
; location: [7FFDDAF2E870h, 7FFDDAF2E8E1h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0013h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0016h vmovdqu xmm0,xmmword ptr [rax]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 00
001ah vmovdqu xmmword ptr [rsp],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 04 24
001fh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 0c 24
0023h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
0026h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0029h mov r11,101010101010101h      ; MOV(Mov_r64_imm64) [R11,101010101010101h:imm64]      encoding(10 bytes) = 49 bb 01 01 01 01 01 01 01 01
0033h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0036h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0039h pext rcx,r10,r11              ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,R10,R11]            encoding(VEX, 5 bytes) = c4 c2 aa f5 cb
003eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0041h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0044h mov [rsp+10h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]              encoding(4 bytes) = 88 4c 24 10
0048h mov ecx,[rsp+10h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 10
004ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004fh mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0052h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0055h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0058h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
005bh or r8,r10                     ; OR(Or_r64_rm64) [R8,R10]                             encoding(3 bytes) = 4d 0b c2
005eh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0061h cmp r9d,8                     ; CMP(Cmp_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 f9 08
0065h jl short 0016h                ; JL(Jl_rel8_64) [16h:jmp64]                           encoding(2 bytes) = 7c af
0067h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
006ah mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
006dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> transpose_8x8_3Bytes => new byte[114]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8B,0xC1,0x45,0x33,0xC0,0x45,0x33,0xC9,0xC5,0xFA,0x6F,0x00,0xC5,0xFA,0x7F,0x04,0x24,0x48,0x8D,0x0C,0x24,0x48,0x8B,0x09,0x4C,0x8B,0x11,0x49,0xBB,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x41,0x8B,0xC9,0x49,0xD3,0xE3,0xC4,0xC2,0xAA,0xF5,0xCB,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x10,0x8B,0x4C,0x24,0x10,0x0F,0xB6,0xC9,0x44,0x8B,0xD1,0x41,0x8B,0xC9,0xC1,0xE1,0x03,0x49,0xD3,0xE2,0x4D,0x0B,0xC2,0x41,0xFF,0xC1,0x41,0x83,0xF9,0x08,0x7C,0xAF,0x48,0x8B,0x02,0x4C,0x89,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void transpose_8x8_4(in BitMatrix8 A, ref BitMatrix8 Z)
; location: [7FFDDAF2E900h, 7FFDDAF2E98Ch]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
000eh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0012h vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0020h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0023h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0026h shr rcx,7                     ; SHR(Shr_rm64_imm8) [RCX,7h:imm8]                     encoding(4 bytes) = 48 c1 e9 07
002ah xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
002dh mov r8,0AA00AA00AA00AAh       ; MOV(Mov_r64_imm64) [R8,aa00aa00aa00aah:imm64]        encoding(10 bytes) = 49 b8 aa 00 aa 00 aa 00 aa 00
0037h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
003ah xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
003dh shl rcx,7                     ; SHL(Shl_rm64_imm8) [RCX,7h:imm8]                     encoding(4 bytes) = 48 c1 e1 07
0041h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0044h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0047h shr rcx,0Eh                   ; SHR(Shr_rm64_imm8) [RCX,eh:imm8]                     encoding(4 bytes) = 48 c1 e9 0e
004bh xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
004eh mov r8,0CCCC0000CCCCh         ; MOV(Mov_r64_imm64) [R8,cccc0000cccch:imm64]          encoding(10 bytes) = 49 b8 cc cc 00 00 cc cc 00 00
0058h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
005bh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
005eh shl rcx,0Eh                   ; SHL(Shl_rm64_imm8) [RCX,eh:imm8]                     encoding(4 bytes) = 48 c1 e1 0e
0062h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0065h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0068h shr rcx,1Ch                   ; SHR(Shr_rm64_imm8) [RCX,1ch:imm8]                    encoding(4 bytes) = 48 c1 e9 1c
006ch xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
006fh mov r8d,0F0F0F0F0h            ; MOV(Mov_r32_imm32) [R8D,f0f0f0f0h:imm32]             encoding(6 bytes) = 41 b8 f0 f0 f0 f0
0075h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0078h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
007bh shl rcx,1Ch                   ; SHL(Shl_rm64_imm8) [RCX,1ch:imm8]                    encoding(4 bytes) = 48 c1 e1 1c
007fh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0082h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0085h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0088h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
008ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> transpose_8x8_4Bytes => new byte[141]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x8B,0x00,0x48,0x8B,0x00,0x48,0x8B,0xC8,0x48,0xC1,0xE9,0x07,0x48,0x33,0xC8,0x49,0xB8,0xAA,0x00,0xAA,0x00,0xAA,0x00,0xAA,0x00,0x49,0x23,0xC8,0x48,0x33,0xC1,0x48,0xC1,0xE1,0x07,0x48,0x33,0xC1,0x48,0x8B,0xC8,0x48,0xC1,0xE9,0x0E,0x48,0x33,0xC8,0x49,0xB8,0xCC,0xCC,0x00,0x00,0xCC,0xCC,0x00,0x00,0x49,0x23,0xC8,0x48,0x33,0xC1,0x48,0xC1,0xE1,0x0E,0x48,0x33,0xC1,0x48,0x8B,0xC8,0x48,0xC1,0xE9,0x1C,0x48,0x33,0xC8,0x41,0xB8,0xF0,0xF0,0xF0,0xF0,0x49,0x23,0xC8,0x48,0x33,0xC1,0x48,0xC1,0xE1,0x1C,0x48,0x33,0xC1,0x48,0x8B,0x12,0x48,0x89,0x02,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitMatrix4x16 transpose_16x4(in BitMatrix16x4 A)
; location: [7FFDDAF2E9B0h, 7FFDDAF2EA55h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,1111111111111111h     ; MOV(Mov_r64_imm64) [RDX,1111111111111111h:imm64]     encoding(10 bytes) = 48 ba 11 11 11 11 11 11 11 11
0012h pext rdx,rax,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 d2
0017h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh mov [rsp+20h],dx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),DX]           encoding(5 bytes) = 66 89 54 24 20
0022h mov edx,[rsp+20h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 20
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h mov rcx,2222222222222222h     ; MOV(Mov_r64_imm64) [RCX,2222222222222222h:imm64]     encoding(10 bytes) = 48 b9 22 22 22 22 22 22 22 22
0033h pext rcx,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c9
0038h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
003bh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
003eh mov [rsp+18h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),CX]           encoding(5 bytes) = 66 89 4c 24 18
0043h mov ecx,[rsp+18h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 18
0047h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
004ah shl rcx,10h                   ; SHL(Shl_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e1 10
004eh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0051h mov rcx,4444444444444444h     ; MOV(Mov_r64_imm64) [RCX,4444444444444444h:imm64]     encoding(10 bytes) = 48 b9 44 44 44 44 44 44 44 44
005bh pext rcx,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c9
0060h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0063h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0066h mov [rsp+10h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),CX]           encoding(5 bytes) = 66 89 4c 24 10
006bh mov ecx,[rsp+10h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 10
006fh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0072h shl rcx,20h                   ; SHL(Shl_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e1 20
0076h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0079h mov rcx,8888888888888888h     ; MOV(Mov_r64_imm64) [RCX,8888888888888888h:imm64]     encoding(10 bytes) = 48 b9 88 88 88 88 88 88 88 88
0083h pext rax,rax,rcx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RCX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c1
0088h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
008bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
008eh mov [rsp+8],ax                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX]           encoding(5 bytes) = 66 89 44 24 08
0093h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
0097h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
009ah shl rax,30h                   ; SHL(Shl_rm64_imm8) [RAX,30h:imm8]                    encoding(4 bytes) = 48 c1 e0 30
009eh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
00a1h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00a5h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> transpose_16x4Bytes => new byte[166]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0xBA,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0x11,0xC4,0xE2,0xFA,0xF5,0xD2,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x66,0x89,0x54,0x24,0x20,0x8B,0x54,0x24,0x20,0x0F,0xB7,0xD2,0x48,0xB9,0x22,0x22,0x22,0x22,0x22,0x22,0x22,0x22,0xC4,0xE2,0xFA,0xF5,0xC9,0x0F,0xB7,0xC9,0x0F,0xB7,0xC9,0x66,0x89,0x4C,0x24,0x18,0x8B,0x4C,0x24,0x18,0x0F,0xB7,0xC9,0x48,0xC1,0xE1,0x10,0x48,0x0B,0xD1,0x48,0xB9,0x44,0x44,0x44,0x44,0x44,0x44,0x44,0x44,0xC4,0xE2,0xFA,0xF5,0xC9,0x0F,0xB7,0xC9,0x0F,0xB7,0xC9,0x66,0x89,0x4C,0x24,0x10,0x8B,0x4C,0x24,0x10,0x0F,0xB7,0xC9,0x48,0xC1,0xE1,0x20,0x48,0x0B,0xD1,0x48,0xB9,0x88,0x88,0x88,0x88,0x88,0x88,0x88,0x88,0xC4,0xE2,0xFA,0xF5,0xC1,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0x66,0x89,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB7,0xC0,0x48,0xC1,0xE0,0x30,0x48,0x0B,0xC2,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitMatrix4 pbm_and_4x4(in BitMatrix4 A, in BitMatrix4 B)
; location: [7FFDDAF2EA70h, 7FFDDAF2EA86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,:sr)]      encoding(3 bytes) = 0f b7 01
0008h movzx edx,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RDX:br,:sr)]      encoding(3 bytes) = 0f b7 12
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pbm_and_4x4Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0x12,0x0F,0xB7,0xC0,0x23,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pbm_and_8x8(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
; location: [7FFDDAF2EFC0h, 7FFDDAF2EFDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000bh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
000eh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0011h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pbm_and_8x8Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0x48,0x8B,0x00,0x48,0x8B,0x12,0x48,0x23,0xC2,0x48,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gbm_and_8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> Z)
; location: [7FFDDAFC0480h, 7FFDDAFC049Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000bh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
000eh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0011h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_8x8Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0x48,0x8B,0x00,0x48,0x8B,0x12,0x48,0x23,0xC2,0x48,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pbm_and_16x16(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
; location: [7FFDDAFC2150h, 7FFDDAFC21A0h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ah mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000dh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0010h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0014h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
001ah vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
001eh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0023h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0027h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
002dh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0031h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0036h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
003ch vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0041h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0045h vmovdqu ymmword ptr [rcx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 01
0049h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004ch add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pbm_and_16x16Bytes => new byte[81]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0xC5,0xFE,0x7F,0x01,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gbm_and_16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> Z)
; location: [7FFDDAFC21D0h, 7FFDDAFC2220h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ah mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000dh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0010h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0014h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
001ah vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
001eh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0023h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0027h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
002dh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0031h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0036h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
003ch vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0041h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0045h vmovdqu ymmword ptr [rcx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 01
0049h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004ch add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_16x16Bytes => new byte[81]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0xC5,0xFE,0x7F,0x01,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pbm_and_32x32(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
; location: [7FFDDAFC2A60h, 7FFDDAFC2AD9h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000bh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000eh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0011h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0014h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0017h movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
001ah shl r10,2                     ; SHL(Shl_rm64_imm8) [R10,2h:imm8]                     encoding(4 bytes) = 49 c1 e2 02
001eh lea r11,[rax+r10]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 4e 8d 1c 10
0022h lea rsi,[rdx+r10]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 4a 8d 34 12
0026h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0034h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0039h vlddqu ymm0,ymmword ptr [r11] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R11:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 03
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
005ch add r10,rcx                   ; ADD(Add_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 03 d1
005fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0064h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0067h add r9d,8                     ; ADD(Add_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 c1 08
006bh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
006fh jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c a6
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0078h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pbm_and_32x32Bytes => new byte[122]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0x45,0x33,0xC0,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x49,0xC1,0xE2,0x02,0x4E,0x8D,0x1C,0x10,0x4A,0x8D,0x34,0x12,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC4,0xC1,0x7F,0xF0,0x03,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0x4C,0x03,0xD1,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC0,0x41,0x83,0xC1,0x08,0x41,0x83,0xF8,0x04,0x7C,0xA6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gbm_and_32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> Z)
; location: [7FFDDAFC2B00h, 7FFDDAFC2B79h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000bh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000eh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0011h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0014h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0017h movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
001ah shl r10,2                     ; SHL(Shl_rm64_imm8) [R10,2h:imm8]                     encoding(4 bytes) = 49 c1 e2 02
001eh lea r11,[rax+r10]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 4e 8d 1c 10
0022h lea rsi,[rdx+r10]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 4a 8d 34 12
0026h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0034h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0039h vlddqu ymm0,ymmword ptr [r11] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R11:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 03
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
005ch add r10,rcx                   ; ADD(Add_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 03 d1
005fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0064h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0067h add r9d,8                     ; ADD(Add_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 c1 08
006bh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
006fh jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c a6
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0078h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_32x32Bytes => new byte[122]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0x45,0x33,0xC0,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x49,0xC1,0xE2,0x02,0x4E,0x8D,0x1C,0x10,0x4A,0x8D,0x34,0x12,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC4,0xC1,0x7F,0xF0,0x03,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0x4C,0x03,0xD1,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC0,0x41,0x83,0xC1,0x08,0x41,0x83,0xF8,0x04,0x7C,0xA6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pbm_and_64x64(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
; location: [7FFDDAFC2FA0h, 7FFDDAFC3019h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000bh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000eh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0011h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0014h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0017h movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
001ah shl r10,3                     ; SHL(Shl_rm64_imm8) [R10,3h:imm8]                     encoding(4 bytes) = 49 c1 e2 03
001eh lea r11,[rax+r10]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 4e 8d 1c 10
0022h lea rsi,[rdx+r10]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 4a 8d 34 12
0026h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0034h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0039h vlddqu ymm0,ymmword ptr [r11] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R11:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 03
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
005ch add r10,rcx                   ; ADD(Add_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 03 d1
005fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0064h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0067h add r9d,4                     ; ADD(Add_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 c1 04
006bh cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
006fh jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c a6
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0078h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pbm_and_64x64Bytes => new byte[122]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0x45,0x33,0xC0,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x49,0xC1,0xE2,0x03,0x4E,0x8D,0x1C,0x10,0x4A,0x8D,0x34,0x12,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC4,0xC1,0x7F,0xF0,0x03,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0x4C,0x03,0xD1,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC0,0x41,0x83,0xC1,0x04,0x41,0x83,0xF8,0x10,0x7C,0xA6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gbm_and_64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> Z)
; location: [7FFDDAFC3040h, 7FFDDAFC30B9h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000bh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000eh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0011h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0014h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0017h movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
001ah shl r10,3                     ; SHL(Shl_rm64_imm8) [R10,3h:imm8]                     encoding(4 bytes) = 49 c1 e2 03
001eh lea r11,[rax+r10]             ; LEA(Lea_r64_m) [R11,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 4e 8d 1c 10
0022h lea rsi,[rdx+r10]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 4a 8d 34 12
0026h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002ah vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0030h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0034h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0039h vlddqu ymm0,ymmword ptr [r11] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R11:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 03
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
005ch add r10,rcx                   ; ADD(Add_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 03 d1
005fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0064h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0067h add r9d,4                     ; ADD(Add_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 c1 04
006bh cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
006fh jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c a6
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
0078h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_64x64Bytes => new byte[122]{0x56,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x12,0x49,0x8B,0x08,0x45,0x33,0xC0,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x49,0xC1,0xE2,0x03,0x4E,0x8D,0x1C,0x10,0x4A,0x8D,0x34,0x12,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC4,0xC1,0x7F,0xF0,0x03,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0x4C,0x03,0xD1,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC0,0x41,0x83,0xC1,0x04,0x41,0x83,0xF8,0x10,0x7C,0xA6,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
