; 2020-01-12 17:49:14:074
; function: bit testbit_8i(sbyte src, int pos)
; static ReadOnlySpan<byte> testbit_8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                              ; BT(Bt_rm32_r32) [EAX,EDX]                  encoding(3 bytes) = 0f a3 d0
000ch setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d8u(byte src, int pos)
; static ReadOnlySpan<byte> testbit_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_8u(byte src, int pos)
; static ReadOnlySpan<byte> testbit_8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_16i(short src, int pos)
; static ReadOnlySpan<byte> testbit_16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                              ; BT(Bt_rm32_r32) [EAX,EDX]                  encoding(3 bytes) = 0f a3 d0
000ch setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_16u(ushort src, int pos)
; static ReadOnlySpan<byte> testbit_16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_32i(int src, int pos)
; static ReadOnlySpan<byte> testbit_32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                              ; BT(Bt_rm32_r32) [ECX,EDX]                  encoding(3 bytes) = 0f a3 d1
0008h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_32u(uint src, int pos)
; static ReadOnlySpan<byte> testbit_32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
0009h shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000bh and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_64i(long src, int pos)
; static ReadOnlySpan<byte> testbit_64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                              ; BT(Bt_rm64_r64) [RCX,RDX]                  encoding(4 bytes) = 48 0f a3 d1
0009h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_64u(ulong src, int pos)
; static ReadOnlySpan<byte> testbit_64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
000ah shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000dh and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
