; 2019-11-21 00:45:03:887
; function: void set_bit(ref uint src, byte pos, bit state)
; location: [7FFDD9F4A680h, 7FFDD9F4A6A9h]
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
; location: [7FFDD9F4A6C0h, 7FFDD9F4A6D4h]
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
; location: [7FFDD9F4A6F0h, 7FFDD9F4A706h]
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
; location: [7FFDD9F4B380h, 7FFDD9F4B42Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0010h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,:sr)]          encoding(4 bytes) = 44 8b 40 08
001ch mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001fh cmp r9d,100h                  ; CMP(Cmp_rm32_imm32) [R9D,100h:imm32]                 encoding(7 bytes) = 41 81 f9 00 01 00 00
0026h jg short 002ah                ; JG(Jg_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7f 02
0028h jmp short 0030h               ; JMP(Jmp_rel8_64) [30h:jmp64]                         encoding(2 bytes) = eb 06
002ah mov r9d,100h                  ; MOV(Mov_r32_imm32) [R9D,100h:imm32]                  encoding(6 bytes) = 41 b9 00 01 00 00
0030h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0033h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0036h jle short 0095h               ; JLE(Jle_rel8_64) [95h:jmp64]                         encoding(2 bytes) = 7e 5d
0038h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
003bh jae short 00a6h               ; JAE(Jae_rel8_64) [A6h:jmp64]                         encoding(2 bytes) = 73 69
003dh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0040h cmp byte ptr [rax+rcx+10h],1  ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(5 bytes) = 80 7c 08 10 01
0045h sete cl                       ; SETE(Sete_rm8) [CL]                                  encoding(3 bytes) = 0f 94 c1
0048h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004bh mov r11,[rdx]                 ; MOV(Mov_r64_rm64) [R11,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 1a
004eh movsxd rsi,r10d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R10D]                   encoding(3 bytes) = 49 63 f2
0051h shr rsi,6                     ; SHR(Shr_rm64_imm8) [RSI,6h:imm8]                     encoding(4 bytes) = 48 c1 ee 06
0055h movsxd rsi,esi                ; MOVSXD(Movsxd_r64_rm32) [RSI,ESI]                    encoding(3 bytes) = 48 63 f6
0058h lea r11,[r11+rsi*8]           ; LEA(Lea_r64_m) [R11,mem(Unknown,R11:br,:sr)]         encoding(4 bytes) = 4d 8d 1c f3
005ch movsxd rsi,r10d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R10D]                   encoding(3 bytes) = 49 63 f2
005fh and rsi,3Fh                   ; AND(And_rm64_imm8) [RSI,3fh:imm64]                   encoding(4 bytes) = 48 83 e6 3f
0063h movzx esi,sil                 ; MOVZX(Movzx_r32_rm8) [ESI,SIL]                       encoding(4 bytes) = 40 0f b6 f6
0067h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0069h je short 007ah                ; JE(Je_rel8_64) [7Ah:jmp64]                           encoding(2 bytes) = 74 0f
006bh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0070h mov ecx,esi                   ; MOV(Mov_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 8b ce
0072h shl rdi,cl                    ; SHL(Shl_rm64_CL) [RDI,CL]                            encoding(3 bytes) = 48 d3 e7
0075h or [r11],rdi                  ; OR(Or_rm64_r64) [mem(64u,R11:br,:sr),RDI]            encoding(3 bytes) = 49 09 3b
0078h jmp short 008dh               ; JMP(Jmp_rel8_64) [8Dh:jmp64]                         encoding(2 bytes) = eb 13
007ah mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
007fh mov ecx,esi                   ; MOV(Mov_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 8b ce
0081h shl rdi,cl                    ; SHL(Shl_rm64_CL) [RDI,CL]                            encoding(3 bytes) = 48 d3 e7
0084h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0087h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
008ah and [r11],rcx                 ; AND(And_rm64_r64) [mem(64u,R11:br,:sr),RCX]          encoding(3 bytes) = 49 21 0b
008dh inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0090h cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
0093h jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c a3
0095h vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0099h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
009fh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00a3h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a4h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a5h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a6h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F543B80h:jmp64]                encoding(5 bytes) = e8 d5 3a 54 5f
00abh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> store_bitstringBytes => new byte[172]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xC1,0x44,0x8B,0x40,0x08,0x45,0x8B,0xC8,0x41,0x81,0xF9,0x00,0x01,0x00,0x00,0x7F,0x02,0xEB,0x06,0x41,0xB9,0x00,0x01,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x5D,0x45,0x3B,0xD0,0x73,0x69,0x49,0x63,0xCA,0x80,0x7C,0x08,0x10,0x01,0x0F,0x94,0xC1,0x0F,0xB6,0xC9,0x4C,0x8B,0x1A,0x49,0x63,0xF2,0x48,0xC1,0xEE,0x06,0x48,0x63,0xF6,0x4D,0x8D,0x1C,0xF3,0x49,0x63,0xF2,0x48,0x83,0xE6,0x3F,0x40,0x0F,0xB6,0xF6,0x85,0xC9,0x74,0x0F,0xBF,0x01,0x00,0x00,0x00,0x8B,0xCE,0x48,0xD3,0xE7,0x49,0x09,0x3B,0xEB,0x13,0xBF,0x01,0x00,0x00,0x00,0x8B,0xCE,0x48,0xD3,0xE7,0x48,0x8B,0xCF,0x48,0xF7,0xD1,0x49,0x21,0x0B,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xA3,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xE8,0xD5,0x3A,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_vector(in BitVector<N23,byte> src)
; location: [7FFDD9F4B5D0h, 7FFDD9F4B5E6h]
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
; location: [7FFDD9F4B600h, 7FFDD9F4B616h]
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
; location: [7FFDD9F4BA30h, 7FFDD9F4BA3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000bh or byte ptr [rax],2           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,:sr),2h:imm8]         encoding(3 bytes) = 80 08 02
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_in_vectorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xFF,0xC0,0x80,0x08,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bits_in_grid(BitGrid<N23,N11,byte> src)
; location: [7FFDD9F4BA50h, 7FFDD9F4BA6Bh]
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
; location: [7FFDD9F4BA80h, 7FFDD9F4BAD5h]
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
; location: [7FFDD9F4BAF0h, 7FFDD9F4BB06h]
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
; location: [7FFDD9F4BB20h, 7FFDD9F4BB31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah add eax,2                     ; ADD(Add_rm32_imm8) [EAX,2h:imm32]                    encoding(3 bytes) = 83 c0 02
000dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000fh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentsBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x83,0xC0,0x02,0x33,0xD2,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int count_segs()
; location: [7FFDD9F4BB50h, 7FFDD9F4BB83h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
000ah mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ch sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
000fh and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
0012h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0014h sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0017h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0019h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
001ch and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
001fh add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0021h and ecx,0FFFFFFFCh            ; AND(And_rm32_imm8) [ECX,fffffffffffffffch:imm32]     encoding(3 bytes) = 83 e1 fc
0024h sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
0026h jne short 002ch               ; JNE(Jne_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = 75 04
0028h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
002ah jmp short 0031h               ; JMP(Jmp_rel8_64) [31h:jmp64]                         encoding(2 bytes) = eb 05
002ch mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0031h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> count_segsBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x03,0x03,0xC8,0x83,0xE1,0xFC,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col_2(int n, ulong src, int row, int col)
; location: [7FFDD9F4BBA0h, 7FFDD9F4BBD8h]
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
; location: [7FFDD9F4BBF0h, 7FFDD9F4BC17h]
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
; location: [7FFDD9F4C030h, 7FFDD9F4C054h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh mov r8d,20h                   ; MOV(Mov_r32_imm32) [R8D,20h:imm32]                   encoding(6 bytes) = 41 b8 20 00 00 00
0011h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0017h call 7FFDD9F4BA08h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF9D8h:jmp64]        encoding(5 bytes) = e8 bc f9 ff ff
001ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0023h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_load_32x32x32Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0x41,0xB8,0x20,0x00,0x00,0x00,0x41,0xB9,0x20,0x00,0x00,0x00,0xE8,0xBC,0xF9,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec bg_specify(ushort rows, ushort cols, ushort segwidth)
; location: [7FFDD9F4C070h, 7FFDD9F4C120h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h movzx r10d,dx                 ; MOVZX(Movzx_r32_rm16) [R10D,DX]                      encoding(4 bytes) = 44 0f b7 d2
000dh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0011h mov eax,r10d                  ; MOV(Mov_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 8b c2
0014h imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0018h mov r11d,eax                  ; MOV(Mov_r32_rm32) [R11D,EAX]                         encoding(3 bytes) = 44 8b d8
001bh sar r11d,3                    ; SAR(Sar_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 fb 03
001fh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0021h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0024h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0027h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0029h and edx,0FFFFFFF8h            ; AND(And_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 e2 f8
002ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
002eh jne short 0034h               ; JNE(Jne_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 75 04
0030h xor esi,esi                   ; XOR(Xor_r32_rm32) [ESI,ESI]                          encoding(2 bytes) = 33 f6
0032h jmp short 0039h               ; JMP(Jmp_rel8_64) [39h:jmp64]                         encoding(2 bytes) = eb 05
0034h mov esi,1                     ; MOV(Mov_r32_imm32) [ESI,1h:imm32]                    encoding(5 bytes) = be 01 00 00 00
0039h add r11d,esi                  ; ADD(Add_r32_rm32) [R11D,ESI]                         encoding(3 bytes) = 44 03 de
003ch movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0040h mov esi,r9d                   ; MOV(Mov_r32_rm32) [ESI,R9D]                          encoding(3 bytes) = 41 8b f1
0043h sar esi,3                     ; SAR(Sar_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 fe 03
0046h mov eax,r11d                  ; MOV(Mov_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 8b c3
0049h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
004ah idiv esi                      ; IDIV(Idiv_rm32) [ESI]                                encoding(2 bytes) = f7 fe
004ch mov edi,eax                   ; MOV(Mov_r32_rm32) [EDI,EAX]                          encoding(2 bytes) = 8b f8
004eh mov eax,r11d                  ; MOV(Mov_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 8b c3
0051h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0052h idiv esi                      ; IDIV(Idiv_rm32) [ESI]                                encoding(2 bytes) = f7 fe
0054h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0056h jne short 005ch               ; JNE(Jne_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 75 04
0058h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
005ah jmp short 0061h               ; JMP(Jmp_rel8_64) [61h:jmp64]                         encoding(2 bytes) = eb 05
005ch mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0061h add eax,edi                   ; ADD(Add_r32_rm32) [EAX,EDI]                          encoding(2 bytes) = 03 c7
0063h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0065h lea rsi,[rsp]                 ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 34 24
0069h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
006dh vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0071h mov [rsi+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 10
0074h mov [rsp],r10w                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R10W]         encoding(5 bytes) = 66 44 89 14 24
0079h mov [rsp+2],r8w               ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R8W]          encoding(6 bytes) = 66 44 89 44 24 02
007fh mov [rsp+4],r9w               ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R9W]          encoding(6 bytes) = 66 44 89 4c 24 04
0085h mov [rsp+0Ch],r11d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R11D]         encoding(5 bytes) = 44 89 5c 24 0c
008ah shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
008eh mov [rsp+8],r11d              ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R11D]         encoding(5 bytes) = 44 89 5c 24 08
0093h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 10
0097h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
009ch vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00a0h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
00a4h mov [rcx+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 10
00a7h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00aah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00aeh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00afh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00b0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_specifyBytes => new byte[177]{0x57,0x56,0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x44,0x0F,0xB7,0xD2,0x45,0x0F,0xB7,0xC0,0x41,0x8B,0xC2,0x41,0x0F,0xAF,0xC0,0x44,0x8B,0xD8,0x41,0xC1,0xFB,0x03,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x07,0x03,0xD0,0x83,0xE2,0xF8,0x2B,0xC2,0x75,0x04,0x33,0xF6,0xEB,0x05,0xBE,0x01,0x00,0x00,0x00,0x44,0x03,0xDE,0x45,0x0F,0xB7,0xC9,0x41,0x8B,0xF1,0xC1,0xFE,0x03,0x41,0x8B,0xC3,0x99,0xF7,0xFE,0x8B,0xF8,0x41,0x8B,0xC3,0x99,0xF7,0xFE,0x85,0xD2,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC7,0x33,0xD2,0x48,0x8D,0x34,0x24,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x06,0x89,0x56,0x10,0x66,0x44,0x89,0x14,0x24,0x66,0x44,0x89,0x44,0x24,0x02,0x66,0x44,0x89,0x4C,0x24,0x04,0x44,0x89,0x5C,0x24,0x0C,0x41,0xC1,0xE3,0x03,0x44,0x89,0x5C,0x24,0x08,0x89,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x8B,0x44,0x24,0x10,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
