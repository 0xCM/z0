; 2020-01-16 19:14:10:408
; function: ref uint reftest_1(in uint x, in uint y, ref uint z)
; static ReadOnlySpan<byte> reftest_1Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                           ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)] encoding(2 bytes) = 8b 01
0007h add eax,[rdx]                           ; ADD(Add_r32_rm32) [EAX,mem(32u,RDX:br,:sr)] encoding(2 bytes) = 03 02
0009h mov [r8],eax                            ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX] encoding(3 bytes) = 41 89 00
000ch mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint reftest_2(in uint x, in uint y, ref uint z)
; static ReadOnlySpan<byte> reftest_2Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                           ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)] encoding(2 bytes) = 8b 01
0007h add eax,[rdx]                           ; ADD(Add_r32_rm32) [EAX,mem(32u,RDX:br,:sr)] encoding(2 bytes) = 03 02
0009h mov [r8],eax                            ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX] encoding(3 bytes) = 41 89 00
000ch mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Block128<uint> vbsll(in Block128<uint> a, in Block128<uint> dst)
; static ReadOnlySpan<byte> vbsllBytes => new byte[94]{0xC5,0xF8,0x77,0x66,0x90,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x45,0x03,0xC1,0x41,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x45,0x85,0xC0,0x7E,0x37,0x48,0x8B,0x01,0x48,0x8B,0x0A,0x4C,0x8B,0xD0,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0xC5,0xF9,0x73,0xF8,0x03,0x4C,0x8B,0xD1,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x45,0x3B,0xC8,0x7C,0xCF,0x48,0x8B,0xC2,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov r8d,[rdx+8]                         ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,:sr)] encoding(4 bytes) = 44 8b 42 08
0009h mov r9d,r8d                             ; MOV(Mov_r32_rm32) [R9D,R8D]                encoding(3 bytes) = 45 8b c8
000ch sar r9d,1Fh                             ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]          encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,3                               ; AND(And_rm32_imm8) [R9D,3h:imm32]          encoding(4 bytes) = 41 83 e1 03
0014h add r8d,r9d                             ; ADD(Add_r32_rm32) [R8D,R9D]                encoding(3 bytes) = 45 03 c1
0017h sar r8d,2                               ; SAR(Sar_rm32_imm8) [R8D,2h:imm8]           encoding(4 bytes) = 41 c1 f8 02
001bh xor r9d,r9d                             ; XOR(Xor_r32_rm32) [R9D,R9D]                encoding(3 bytes) = 45 33 c9
001eh test r8d,r8d                            ; TEST(Test_rm32_r32) [R8D,R8D]              encoding(3 bytes) = 45 85 c0
0021h jle short 005ah                         ; JLE(Jle_rel8_64) [5Ah:jmp64]               encoding(2 bytes) = 7e 37
0023h mov rax,[rcx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 01
0026h mov rcx,[rdx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 0a
0029h mov r10,rax                             ; MOV(Mov_r64_rm64) [R10,RAX]                encoding(3 bytes) = 4c 8b d0
002ch mov r11d,r9d                            ; MOV(Mov_r32_rm32) [R11D,R9D]               encoding(3 bytes) = 45 8b d9
002fh shl r11d,2                              ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]          encoding(4 bytes) = 41 c1 e3 02
0033h movsxd r11,r11d                         ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]         encoding(3 bytes) = 4d 63 db
0036h shl r11,2                               ; SHL(Shl_rm64_imm8) [R11,2h:imm8]           encoding(4 bytes) = 49 c1 e3 02
003ah add r10,r11                             ; ADD(Add_r64_rm64) [R10,R11]                encoding(3 bytes) = 4d 03 d3
003dh vlddqu xmm0,xmmword ptr [r10]           ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0042h vpslldq xmm0,xmm0,3                     ; VPSLLDQ(VEX_Vpslldq_xmm_xmm_imm8) [XMM0,XMM0,3h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 f8 03
0047h mov r10,rcx                             ; MOV(Mov_r64_rm64) [R10,RCX]                encoding(3 bytes) = 4c 8b d1
004ah add r10,r11                             ; ADD(Add_r64_rm64) [R10,R11]                encoding(3 bytes) = 4d 03 d3
004dh vmovdqu xmmword ptr [r10],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0052h inc r9d                                 ; INC(Inc_rm32) [R9D]                        encoding(3 bytes) = 41 ff c1
0055h cmp r9d,r8d                             ; CMP(Cmp_r32_rm32) [R9D,R8D]                encoding(3 bytes) = 45 3b c8
0058h jl short 0029h                          ; JL(Jl_rel8_64) [29h:jmp64]                 encoding(2 bytes) = 7c cf
005ah mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
005dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<short> spanconvert(Span<short> src)
; static ReadOnlySpan<byte> spanconvertBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]                         ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 52 08
000bh mov [rcx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX] encoding(3 bytes) = 48 89 01
000eh mov [rcx+8],edx                         ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX] encoding(3 bytes) = 89 51 08
0011h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
