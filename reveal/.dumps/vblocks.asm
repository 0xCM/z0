; 2019-12-20 21:49:17:428
; function: Vector256<int> vloadconstblock(ConstBlock128<short> src)
; location: [7FF7C7E96C70h, 7FF7C7E96C87h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vpmovsxwd ymm0,xmmword ptr [rax]; VPMOVSXWD(VEX_Vpmovsxwd_ymm_xmmm128) [YMM0,mem(Packed128_Int16,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 23 00
000dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vloadconstblockBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0xC4,0xE2,0x7D,0x23,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<short> spanconvert(Span<short> src)
; location: [7FF7C7E96CA0h, 7FF7C7E96CB4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
000bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
000eh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> spanconvertBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vloadconstblock_convert(Block128<short> src)
; location: [7FF7C7E970D0h, 7FF7C7E97134h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+18h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 18
000eh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0013h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0018h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
001dh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0020h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
0023h lea r8,[rsp+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 08
0028h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ch vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
0031h lea r8,[rsp+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 08
0036h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
0039h mov [r8+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EDX]           encoding(4 bytes) = 41 89 50 08
003dh vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
0043h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0049h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
004eh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0051h vpmovsxwd ymm0,xmmword ptr [rax]; VPMOVSXWD(VEX_Vpmovsxwd_ymm_xmmm128) [YMM0,mem(Packed128_Int16,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 23 00
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vloadconstblock_convertBytes => new byte[101]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x18,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x00,0x4C,0x8D,0x44,0x24,0x08,0x49,0x89,0x00,0x41,0x89,0x50,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0x48,0x8B,0x00,0xC4,0xE2,0x7D,0x23,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x8u_blocks(ConstBlock128<byte> xb, ConstBlock128<byte> yb, in Block128<byte> zb)
; location: [7FF7C7E97B90h, 7FF7C7E97BFCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,0Fh                   ; AND(And_rm32_imm8) [R9D,fh:imm32]                    encoding(4 bytes) = 41 83 e1 0f
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 006ch               ; JLE(Jle_rel8_64) [6Ch:jmp64]                         encoding(2 bytes) = 7e 4b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0031h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0036h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
0039h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
003ch shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0040h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0043h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0046h vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
004bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004fh mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0052h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0055h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0059h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
005ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
005fh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0064h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0067h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
006ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c b5
006ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x8u_blocksBytes => new byte[109]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x0F,0x41,0x03,0xC1,0xC1,0xF8,0x04,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x4B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xB5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x16u_blocks(ConstBlock128<ushort> xb, ConstBlock128<ushort> yb, in Block128<ushort> zb)
; location: [7FF7C7E98020h, 7FF7C7E9807Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,7                     ; AND(And_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 e1 07
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 3a
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,1                     ; SHL(Shl_rm64_1) [R11,1h:imm8]                        encoding(3 bytes) = 49 d1 e3
0031h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0034h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0039h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
003fh vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
0044h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0048h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004bh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004eh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0053h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0056h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0059h jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c6
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x16u_blocksBytes => new byte[92]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x07,0x41,0x03,0xC1,0xC1,0xF8,0x03,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3A,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x49,0xD1,0xE3,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC6,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x32u_blocks(ConstBlock128<uint> xb, ConstBlock128<uint> yb, in Block128<uint> zb)
; location: [7FF7C7E984A0h, 7FF7C7E984FCh]
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
0045h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x32u_blocksBytes => new byte[93]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x41,0x03,0xC1,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x64u_blocks(ConstBlock128<ulong> xb, ConstBlock128<ulong> yb, in Block128<ulong> zb)
; location: [7FF7C7E98920h, 7FF7C7E98976h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch shr r9d,1Fh                   ; SHR(Shr_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 e9 1f
0010h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0013h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0015h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah jle short 0056h               ; JLE(Jle_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 7e 3a
001ch mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
001fh mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0022h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
0025h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0028h shl r11,3                     ; SHL(Shl_rm64_imm8) [R11,3h:imm8]                     encoding(4 bytes) = 49 c1 e3 03
002ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
002fh vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0034h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
0037h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
003ah vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
003fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0043h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0046h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0049h vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
004eh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0051h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0054h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c c6
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x64u_blocksBytes => new byte[87]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x1F,0x41,0x03,0xC1,0xD1,0xF8,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3A,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xD1,0xE3,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x03,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC6,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x8u_blocks(ConstBlock256<byte> xb, ConstBlock256<byte> yb, in Block256<byte> zb)
; location: [7FF7C7E991A0h, 7FF7C7E9920Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,1Fh                   ; AND(And_rm32_imm8) [R9D,1fh:imm32]                   encoding(4 bytes) = 41 83 e1 1f
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,5                     ; SAR(Sar_rm32_imm8) [EAX,5h:imm8]                     encoding(3 bytes) = c1 f8 05
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 006ch               ; JLE(Jle_rel8_64) [6Ch:jmp64]                         encoding(2 bytes) = 7e 4b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0031h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
0036h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
0039h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
003ch shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0040h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0043h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0046h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
004bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004fh mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0052h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0055h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0059h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
005ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
005fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0064h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0067h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
006ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c b5
006ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x8u_blocksBytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x1F,0x41,0x03,0xC1,0xC1,0xF8,0x05,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x4B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x05,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x05,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x05,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xB5,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x16u_blocks(ConstBlock256<ushort> xb, ConstBlock256<ushort> yb, in Block256<ushort> zb)
; location: [7FF7C7E99230h, 7FF7C7E9928Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,0Fh                   ; AND(And_rm32_imm8) [R9D,fh:imm32]                    encoding(4 bytes) = 41 83 e1 0f
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 3a
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,1                     ; SHL(Shl_rm64_1) [R11,1h:imm8]                        encoding(3 bytes) = 49 d1 e3
0031h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0034h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
0039h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
003fh vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0044h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0048h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004bh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004eh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0053h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0056h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0059h jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c6
005bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x16u_blocksBytes => new byte[95]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x0F,0x41,0x03,0xC1,0xC1,0xF8,0x04,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3A,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x49,0xD1,0xE3,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC6,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x32u_blocks(ConstBlock256<uint> xb, ConstBlock256<uint> yb, in Block256<uint> zb)
; location: [7FF7C7E996B0h, 7FF7C7E9970Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,7                     ; AND(And_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 e1 07
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005ch               ; JLE(Jle_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 7e 3b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,2                     ; SHL(Shl_rm64_imm8) [R11,2h:imm8]                     encoding(4 bytes) = 49 c1 e3 02
0032h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0035h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
003ah mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003dh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0040h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0045h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x32u_blocksBytes => new byte[96]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x07,0x41,0x03,0xC1,0xC1,0xF8,0x03,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x64u_blocks(ConstBlock256<ulong> xb, ConstBlock256<ulong> yb, in Block256<ulong> zb)
; location: [7FF7C7E99730h, 7FF7C7E9978Fh]
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
002eh shl r11,3                     ; SHL(Shl_rm64_imm8) [R11,3h:imm8]                     encoding(4 bytes) = 49 c1 e3 03
0032h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0035h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
003ah mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003dh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0040h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0045h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x64u_blocksBytes => new byte[96]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x41,0x03,0xC1,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x03,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
