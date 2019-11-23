; 2019-11-23 02:41:20:043
; function: void set_bit(ref uint src, byte pos, bit state)
; location: [7FFDDAFFC640h, 7FFDDAFFC669h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
000bh je short 001bh                ; JE(Je_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 74 0e
000dh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0010h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0015h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0017h or [rax],edx                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),EDX]            encoding(2 bytes) = 09 10
0019h jmp short 0029h               ; JMP(Jmp_rel8_64) [29h:jmp64]                         encoding(2 bytes) = eb 0e
001bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
001eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0023h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0025h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0027h and [rax],edx                 ; AND(And_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 21 10
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bitBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x45,0x85,0xC0,0x74,0x0E,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x09,0x10,0xEB,0x0E,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x21,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_on(ref uint src, byte pos)
; location: [7FFDDAFFC680h, 7FFDDAFFC694h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0010h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0012h or [rax],edx                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),EDX]            encoding(2 bytes) = 09 10
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_onBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_off(ref uint src, byte pos)
; location: [7FFDDAFFC6B0h, 7FFDDAFFC6C6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0010h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0012h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0014h and [rax],edx                 ; AND(And_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 21 10
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_offBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x21,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void store_bitstring(BitString src, in BitGrid<N8,N32,ulong> dst)
; location: [7FFDDAFFD200h, 7FFDDAFFD2CCh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 38
0010h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 40
0015h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
001ah mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
001fh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0022h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
0025h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
002ah mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
002dh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0032h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0035h call 7FFDDA91F278h            ; CALL(Call_rel32_64) [FFFFFFFFFF922078h:jmp64]        encoding(5 bytes) = e8 3e 20 92 ff
003ah shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
003dh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0040h mov edx,[rdi+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDI:br,:sr)]          encoding(3 bytes) = 8b 57 08
0043h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0046h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
0049h jl short 004dh                ; JL(Jl_rel8_64) [4Dh:jmp64]                           encoding(2 bytes) = 7c 02
004bh jmp short 0050h               ; JMP(Jmp_rel8_64) [50h:jmp64]                         encoding(2 bytes) = eb 03
004dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0050h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0052h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0055h jle short 00b6h               ; JLE(Jle_rel8_64) [B6h:jmp64]                         encoding(2 bytes) = 7e 5f
0057h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0059h jae short 00c7h               ; JAE(Jae_rel8_64) [C7h:jmp64]                         encoding(2 bytes) = 73 6c
005bh movsxd rcx,eax                ; MOVSXD(Movsxd_r64_rm32) [RCX,EAX]                    encoding(3 bytes) = 48 63 c8
005eh cmp byte ptr [rdi+rcx+10h],1  ; CMP(Cmp_rm8_imm8) [mem(8u,RDI:br,:sr),1h:imm8]       encoding(5 bytes) = 80 7c 0f 10 01
0063h sete cl                       ; SETE(Sete_rm8) [CL]                                  encoding(3 bytes) = 0f 94 c1
0066h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0069h mov r9,[rsi]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RSI:br,:sr)]           encoding(3 bytes) = 4c 8b 0e
006ch movsxd r10,eax                ; MOVSXD(Movsxd_r64_rm32) [R10,EAX]                    encoding(3 bytes) = 4c 63 d0
006fh shr r10,6                     ; SHR(Shr_rm64_imm8) [R10,6h:imm8]                     encoding(4 bytes) = 49 c1 ea 06
0073h movsxd r10,r10d               ; MOVSXD(Movsxd_r64_rm32) [R10,R10D]                   encoding(3 bytes) = 4d 63 d2
0076h lea r9,[r9+r10*8]             ; LEA(Lea_r64_m) [R9,mem(Unknown,R9:br,:sr)]           encoding(4 bytes) = 4f 8d 0c d1
007ah movsxd r10,eax                ; MOVSXD(Movsxd_r64_rm32) [R10,EAX]                    encoding(3 bytes) = 4c 63 d0
007dh and r10,3Fh                   ; AND(And_rm64_imm8) [R10,3fh:imm64]                   encoding(4 bytes) = 49 83 e2 3f
0081h movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
0085h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0087h je short 009ah                ; JE(Je_rel8_64) [9Ah:jmp64]                           encoding(2 bytes) = 74 11
0089h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
008fh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0092h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0095h or [r9],r11                   ; OR(Or_rm64_r64) [mem(64u,R9:br,:sr),R11]             encoding(3 bytes) = 4d 09 19
0098h jmp short 00afh               ; JMP(Jmp_rel8_64) [AFh:jmp64]                         encoding(2 bytes) = eb 15
009ah mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
00a0h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
00a3h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
00a6h mov rcx,r11                   ; MOV(Mov_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 8b cb
00a9h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
00ach and [r9],rcx                  ; AND(And_rm64_r64) [mem(64u,R9:br,:sr),RCX]           encoding(3 bytes) = 49 21 09
00afh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
00b1h cmp eax,r8d                   ; CMP(Cmp_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 3b c0
00b4h jl short 0057h                ; JL(Jl_rel8_64) [57h:jmp64]                           encoding(2 bytes) = 7c a1
00b6h vmovdqu xmm0,xmmword ptr [rsi]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 06
00bah vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
00c0h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
00c4h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00c5h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00c7h call 7FFE3A54EF00h            ; CALL(Call_rel32_64) [5F551D00h:jmp64]                encoding(5 bytes) = e8 34 1c 55 5f
00cch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> store_bitstringBytes => new byte[205]{0x57,0x56,0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x40,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x8B,0xF9,0x48,0x8D,0x44,0x24,0x30,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x28,0xC6,0x00,0x00,0xE8,0x3E,0x20,0x92,0xFF,0xC1,0xE0,0x03,0x48,0x63,0xC0,0x8B,0x57,0x08,0x44,0x8B,0xC2,0x41,0x3B,0xC0,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xC0,0x33,0xC0,0x45,0x85,0xC0,0x7E,0x5F,0x3B,0xC2,0x73,0x6C,0x48,0x63,0xC8,0x80,0x7C,0x0F,0x10,0x01,0x0F,0x94,0xC1,0x0F,0xB6,0xC9,0x4C,0x8B,0x0E,0x4C,0x63,0xD0,0x49,0xC1,0xEA,0x06,0x4D,0x63,0xD2,0x4F,0x8D,0x0C,0xD1,0x4C,0x63,0xD0,0x49,0x83,0xE2,0x3F,0x45,0x0F,0xB6,0xD2,0x85,0xC9,0x74,0x11,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x4D,0x09,0x19,0xEB,0x15,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0x8B,0xCB,0x48,0xF7,0xD1,0x49,0x21,0x09,0xFF,0xC0,0x41,0x3B,0xC0,0x7C,0xA1,0xC5,0xFA,0x6F,0x06,0xC5,0xFA,0x7F,0x44,0x24,0x38,0x48,0x83,0xC4,0x48,0x5E,0x5F,0xC3,0xE8,0x34,0x1C,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_vector(in BitVector<N23,byte> src)
; location: [7FFDDAFFD870h, 7FFDDAFFD886h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test al,8                     ; TEST(Test_AL_imm8) [AL,8h:imm8]                      encoding(2 bytes) = a8 08
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_vectorBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0xA8,0x08,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_vector_2(in BitVector<N23,byte> src)
; location: [7FFDDAFFD8A0h, 7FFDDAFFD8B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test al,8                     ; TEST(Test_AL_imm8) [AL,8h:imm8]                      encoding(2 bytes) = a8 08
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_vector_2Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0xA8,0x08,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_in_vector(in BitVector<N23,byte> src)
; location: [7FFDDAFFD8D0h, 7FFDDAFFD8DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000bh or byte ptr [rax],2           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,:sr),2h:imm8]         encoding(3 bytes) = 80 08 02
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_in_vectorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xFF,0xC0,0x80,0x08,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bits_in_grid(BitGrid<N23,N11,byte> src)
; location: [7FFDDAFFD8F0h, 7FFDDAFFD90Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h or byte ptr [rax],8           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,:sr),8h:imm8]         encoding(3 bytes) = 80 08 08
000bh mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000eh or byte ptr [rax],20h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,:sr),20h:imm8]        encoding(3 bytes) = 80 08 20
0011h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0014h add rax,2                     ; ADD(Add_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 c0 02
0018h or byte ptr [rax],4           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,:sr),4h:imm8]         encoding(3 bytes) = 80 08 04
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bits_in_gridBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x80,0x08,0x08,0x48,0x8B,0x01,0x80,0x08,0x20,0x48,0x8B,0x01,0x48,0x83,0xC0,0x02,0x80,0x08,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bits_in_grid_2(BitGrid<N23,N11,byte> src, int i, int j)
; location: [7FFDDAFFD920h, 7FFDDAFFD975h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9,[rax]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RAX:br,:sr)]           encoding(3 bytes) = 4c 8b 08
000bh movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
000eh shr rcx,3                     ; SHR(Shr_rm64_imm8) [RCX,3h:imm8]                     encoding(4 bytes) = 48 c1 e9 03
0012h movsxd r10,ecx                ; MOVSXD(Movsxd_r64_rm32) [R10,ECX]                    encoding(3 bytes) = 4c 63 d1
0015h add r9,r10                    ; ADD(Add_r64_rm64) [R9,R10]                           encoding(3 bytes) = 4d 03 ca
0018h movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
001bh and rcx,7                     ; AND(And_rm64_imm8) [RCX,7h:imm64]                    encoding(4 bytes) = 48 83 e1 07
001fh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0022h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0027h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0029h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
002ch or [r9],cl                    ; OR(Or_rm8_r8) [mem(8u,R9:br,:sr),CL]                 encoding(3 bytes) = 41 08 09
002fh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0032h movsxd rcx,r8d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R8D]                    encoding(3 bytes) = 49 63 c8
0035h shr rcx,3                     ; SHR(Shr_rm64_imm8) [RCX,3h:imm8]                     encoding(4 bytes) = 48 c1 e9 03
0039h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
003ch add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
003fh movsxd rcx,r8d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R8D]                    encoding(3 bytes) = 49 63 c8
0042h and rcx,7                     ; AND(And_rm64_imm8) [RCX,7h:imm64]                    encoding(4 bytes) = 48 83 e1 07
0046h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0049h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
004eh shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0050h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0053h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bits_in_grid_2Bytes => new byte[86]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x08,0x48,0x63,0xCA,0x48,0xC1,0xE9,0x03,0x4C,0x63,0xD1,0x4D,0x03,0xCA,0x48,0x63,0xCA,0x48,0x83,0xE1,0x07,0x0F,0xB6,0xC9,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0F,0xB6,0xCA,0x41,0x08,0x09,0x48,0x8B,0x00,0x49,0x63,0xC8,0x48,0xC1,0xE9,0x03,0x48,0x63,0xD1,0x48,0x03,0xC2,0x49,0x63,0xC8,0x48,0x83,0xE1,0x07,0x0F,0xB6,0xC9,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0F,0xB6,0xD2,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_grid(in BitGrid<N23,N5,byte> src)
; location: [7FFDDAFFDD90h, 7FFDDAFFDDA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test al,8                     ; TEST(Test_AL_imm8) [AL,8h:imm8]                      encoding(2 bytes) = a8 08
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_gridBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0xA8,0x08,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int segments()
; location: [7FFDDAFFDDC0h, 7FFDDAFFDE13h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov byte ptr [rsp+30h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 30 00
000ah lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
000fh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0012h call 7FFDDAFFDA48h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC88h:jmp64]        encoding(5 bytes) = e8 71 fc ff ff
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah mov byte ptr [rsp+28h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 28 00
001fh lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 28
0024h mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 02 00
0027h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002ah mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
002ch sar edx,3                     ; SAR(Sar_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 fa 03
002fh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0031h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0034h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0037h add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0039h and ecx,0FFFFFFF8h            ; AND(And_rm32_imm8) [ECX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 e1 f8
003ch sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
003eh jne short 0044h               ; JNE(Jne_rel8_64) [44h:jmp64]                         encoding(2 bytes) = 75 04
0040h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0042h jmp short 0049h               ; JMP(Jmp_rel8_64) [49h:jmp64]                         encoding(2 bytes) = eb 05
0044h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0049h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
004bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
004dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
004fh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentsBytes => new byte[84]{0x48,0x83,0xEC,0x38,0x90,0xC6,0x44,0x24,0x30,0x00,0x48,0x8D,0x44,0x24,0x30,0xC6,0x00,0x00,0xE8,0x71,0xFC,0xFF,0xFF,0x0F,0xB7,0xC0,0xC6,0x44,0x24,0x28,0x00,0x48,0x8D,0x54,0x24,0x28,0xC6,0x02,0x00,0x0F,0xB7,0xC0,0x8B,0xD0,0xC1,0xFA,0x03,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x07,0x03,0xC8,0x83,0xE1,0xF8,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0x33,0xD2,0x03,0xC2,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int count_segs()
; location: [7FFDDAFFDE30h, 7FFDDAFFDEB9h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000ch mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0011h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0016h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0019h call 7FFDDAFFDB78h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFD48h:jmp64]        encoding(5 bytes) = e8 2a fd ff ff
001eh movzx esi,ax                  ; MOVZX(Movzx_r32_rm16) [ESI,AX]                       encoding(3 bytes) = 0f b7 f0
0021h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0026h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0029h call 7FFDDA91E908h            ; CALL(Call_rel32_64) [FFFFFFFFFF920AD8h:jmp64]        encoding(5 bytes) = e8 aa 0a 92 ff
002eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0031h movzx edx,si                  ; MOVZX(Movzx_r32_rm16) [EDX,SI]                       encoding(3 bytes) = 0f b7 d6
0034h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0037h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
003ah mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
003ch sar edx,3                     ; SAR(Sar_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 fa 03
003fh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0041h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0044h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0047h add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0049h and ecx,0FFFFFFF8h            ; AND(And_rm32_imm8) [ECX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 e1 f8
004ch sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
004eh jne short 0054h               ; JNE(Jne_rel8_64) [54h:jmp64]                         encoding(2 bytes) = 75 04
0050h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0052h jmp short 0059h               ; JMP(Jmp_rel8_64) [59h:jmp64]                         encoding(2 bytes) = eb 05
0054h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0059h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
005bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
005dh sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0060h and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
0063h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0065h sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0068h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
006ah sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
006dh and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0070h add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0072h and ecx,0FFFFFFFCh            ; AND(And_rm32_imm8) [ECX,fffffffffffffffch:imm32]     encoding(3 bytes) = 83 e1 fc
0075h sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
0077h jne short 007dh               ; JNE(Jne_rel8_64) [7Dh:jmp64]                         encoding(2 bytes) = 75 04
0079h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
007bh jmp short 0082h               ; JMP(Jmp_rel8_64) [82h:jmp64]                         encoding(2 bytes) = eb 05
007dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0082h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0084h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0088h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0089h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> count_segsBytes => new byte[138]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x28,0xC6,0x00,0x00,0xE8,0x2A,0xFD,0xFF,0xFF,0x0F,0xB7,0xF0,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0xE8,0xAA,0x0A,0x92,0xFF,0x0F,0xB7,0xC0,0x0F,0xB7,0xD6,0x0F,0xB7,0xC0,0x0F,0xAF,0xC2,0x8B,0xD0,0xC1,0xFA,0x03,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x07,0x03,0xC8,0x83,0xE1,0xF8,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x03,0x03,0xC8,0x83,0xE1,0xFC,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col_2(int n, ulong src, int row, int col)
; location: [7FFDDAFFDED0h, 7FFDDAFFDF08h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
000ah imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
000eh add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
0011h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0014h shr rax,6                     ; SHR(Shr_rm64_imm8) [RAX,6h:imm8]                     encoding(4 bytes) = 48 c1 e8 06
0018h lea rdx,[rsp+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 10
001dh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0020h mov rax,[rdx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 04 c2
0024h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0027h and rdx,3Fh                   ; AND(And_rm64_imm8) [RDX,3fh:imm64]                   encoding(4 bytes) = 48 83 e2 3f
002bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0032h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0035h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_row_col_2Bytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x41,0x0F,0xAF,0xC8,0x41,0x03,0xC9,0x48,0x63,0xC1,0x48,0xC1,0xE8,0x06,0x48,0x8D,0x54,0x24,0x10,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC2,0x48,0x63,0xD1,0x48,0x83,0xE2,0x3F,0x0F,0xB6,0xD2,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_g_position(in ulong src, int pos)
; location: [7FFDDAFFDF20h, 7FFDDAFFDF47h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h shr rax,6                     ; SHR(Shr_rm64_imm8) [RAX,6h:imm8]                     encoding(4 bytes) = 48 c1 e8 06
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh mov rax,[rcx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 04 c1
0013h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0016h and rdx,3Fh                   ; AND(And_rm64_imm8) [RDX,3fh:imm64]                   encoding(4 bytes) = 48 83 e2 3f
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0021h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_g_positionBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0xC1,0xE8,0x06,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC1,0x48,0x63,0xD2,0x48,0x83,0xE2,0x3F,0x0F,0xB6,0xD2,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid<uint> bg_load_32x32x32(Span<uint> src)
; location: [7FFDDAFFE360h, 7FFDDAFFE384h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh mov r8d,20h                   ; MOV(Mov_r32_imm32) [R8D,20h:imm32]                   encoding(6 bytes) = 41 b8 20 00 00 00
0011h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0017h call 7FFDDAFFDD18h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF9B8h:jmp64]        encoding(5 bytes) = e8 9c f9 ff ff
001ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0023h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_load_32x32x32Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0x41,0xB8,0x20,0x00,0x00,0x00,0x41,0xB9,0x20,0x00,0x00,0x00,0xE8,0x9C,0xF9,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec bg_specify(ushort rows, ushort cols, ushort segwidth)
; location: [7FFDDAFFE3A0h, 7FFDDAFFE473h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h lea r10,[rsp]                 ; LEA(Lea_r64_m) [R10,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 4c 8d 14 24
000dh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0011h vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0016h mov [r10+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,R10:br,:sr),EAX]          encoding(4 bytes) = 41 89 42 10
001ah movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
001dh mov [rsp],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX]           encoding(4 bytes) = 66 89 04 24
0021h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0025h mov [rsp+2],dx                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),DX]           encoding(5 bytes) = 66 89 54 24 02
002ah movzx r8d,r9w                 ; MOVZX(Movzx_r32_rm16) [R8D,R9W]                      encoding(4 bytes) = 45 0f b7 c1
002eh mov [rsp+4],r8w               ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R8W]          encoding(6 bytes) = 66 44 89 44 24 04
0034h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0037h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
003ah sar r9d,3                     ; SAR(Sar_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 f9 03
003eh mov edx,r9d                   ; MOV(Mov_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 8b d1
0041h mov r10d,eax                  ; MOV(Mov_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 8b d0
0044h sar r10d,1Fh                  ; SAR(Sar_rm32_imm8) [R10D,1fh:imm8]                   encoding(4 bytes) = 41 c1 fa 1f
0048h and r10d,7                    ; AND(And_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 e2 07
004ch add r10d,eax                  ; ADD(Add_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 03 d0
004fh and r10d,0FFFFFFF8h           ; AND(And_rm32_imm8) [R10D,fffffffffffffff8h:imm32]    encoding(4 bytes) = 41 83 e2 f8
0053h sub eax,r10d                  ; SUB(Sub_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 2b c2
0056h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0058h jne short 005fh               ; JNE(Jne_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = 75 05
005ah xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
005dh jmp short 0065h               ; JMP(Jmp_rel8_64) [65h:jmp64]                         encoding(2 bytes) = eb 06
005fh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0065h add edx,r10d                  ; ADD(Add_r32_rm32) [EDX,R10D]                         encoding(3 bytes) = 41 03 d2
0068h mov [rsp+0Ch],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 0c
006ch shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
006fh mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 08
0073h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0075h jne short 007ch               ; JNE(Jne_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = 75 05
0077h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
007ah jmp short 0082h               ; JMP(Jmp_rel8_64) [82h:jmp64]                         encoding(2 bytes) = eb 06
007ch mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0082h add r9d,r10d                  ; ADD(Add_r32_rm32) [R9D,R10D]                         encoding(3 bytes) = 45 03 ca
0085h mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
0088h sar r10d,1Fh                  ; SAR(Sar_rm32_imm8) [R10D,1fh:imm8]                   encoding(4 bytes) = 41 c1 fa 1f
008ch and r10d,7                    ; AND(And_rm32_imm8) [R10D,7h:imm32]                   encoding(4 bytes) = 41 83 e2 07
0090h add r8d,r10d                  ; ADD(Add_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 03 c2
0093h sar r8d,3                     ; SAR(Sar_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 f8 03
0097h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
009ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
009bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
009eh mov r10d,eax                  ; MOV(Mov_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 8b d0
00a1h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
00a4h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
00a5h idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
00a8h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
00aah jne short 00b0h               ; JNE(Jne_rel8_64) [B0h:jmp64]                         encoding(2 bytes) = 75 04
00ach xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
00aeh jmp short 00b5h               ; JMP(Jmp_rel8_64) [B5h:jmp64]                         encoding(2 bytes) = eb 05
00b0h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
00b5h add eax,r10d                  ; ADD(Add_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 03 c2
00b8h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 10
00bch vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
00c1h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00c5h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
00c9h mov [rcx+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 10
00cch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00cfh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00d3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_specifyBytes => new byte[212]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x4C,0x8D,0x14,0x24,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0x89,0x42,0x10,0x0F,0xB7,0xC2,0x66,0x89,0x04,0x24,0x41,0x0F,0xB7,0xD0,0x66,0x89,0x54,0x24,0x02,0x45,0x0F,0xB7,0xC1,0x66,0x44,0x89,0x44,0x24,0x04,0x0F,0xAF,0xC2,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x03,0x41,0x8B,0xD1,0x44,0x8B,0xD0,0x41,0xC1,0xFA,0x1F,0x41,0x83,0xE2,0x07,0x44,0x03,0xD0,0x41,0x83,0xE2,0xF8,0x41,0x2B,0xC2,0x85,0xC0,0x75,0x05,0x45,0x33,0xD2,0xEB,0x06,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x03,0xD2,0x89,0x54,0x24,0x0C,0xC1,0xE2,0x03,0x89,0x54,0x24,0x08,0x85,0xC0,0x75,0x05,0x45,0x33,0xD2,0xEB,0x06,0x41,0xBA,0x01,0x00,0x00,0x00,0x45,0x03,0xCA,0x45,0x8B,0xD0,0x41,0xC1,0xFA,0x1F,0x41,0x83,0xE2,0x07,0x45,0x03,0xC2,0x41,0xC1,0xF8,0x03,0x41,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x44,0x8B,0xD0,0x41,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x85,0xD2,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x41,0x03,0xC2,0x89,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x8B,0x44,0x24,0x10,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
