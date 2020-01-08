; 2020-01-08 01:52:27:999
; function: byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
; static ReadOnlySpan<byte> opA_8uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort opA_16u(ushort dx, ushort r8w, ushort r9w, ushort rsp28)
; static ReadOnlySpan<byte> opA_16uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x41,0x0F,0xB7,0xD0,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0x41,0x0F,0xB7,0xD1,0x33,0xC2,0x0F,0xB7,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h movzx edx,r8w                           ; MOVZX(Movzx_r32_rm16) [EDX,R8W]            encoding(4 bytes) = 41 0f b7 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0012h movzx edx,r9w                           ; MOVZX(Movzx_r32_rm16) [EDX,R9W]            encoding(4 bytes) = 41 0f b7 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
0022h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0024h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
; static ReadOnlySpan<byte> opA_32uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xAF,0xD0,0x41,0x33,0xD1,0x8B,0xC2,0x0B,0x44,0x24,0x28,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,r8d                            ; IMUL(Imul_r32_rm32) [EDX,R8D]              encoding(4 bytes) = 41 0f af d0
0009h xor edx,r9d                             ; XOR(Xor_r32_rm32) [EDX,R9D]                encoding(3 bytes) = 41 33 d1
000ch mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000eh or eax,[rsp+28h]                        ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 44 24 28
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
; static ReadOnlySpan<byte> opA_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x49,0x33,0xD1,0x48,0x8B,0xC2,0x48,0x0B,0x44,0x24,0x28,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,r8                             ; IMUL(Imul_r64_rm64) [RDX,R8]               encoding(4 bytes) = 49 0f af d0
0009h xor rdx,r9                              ; XOR(Xor_r64_rm64) [RDX,R9]                 encoding(3 bytes) = 49 33 d1
000ch mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000fh or rax,[rsp+28h]                        ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]  encoding(5 bytes) = 48 0b 44 24 28
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
; static ReadOnlySpan<byte> opB_8uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h mov edx,[rsp+30h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 30
002bh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
002eh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
; static ReadOnlySpan<byte> opC_8uBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h mov edx,[rsp+30h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 30
002bh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
002eh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h mov edx,[rsp+38h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 38
0037h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
003ah xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
003ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
003fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
; static ReadOnlySpan<byte> opD_8uBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x83,0xF0,0x05,0x41,0x88,0x01,0x41,0x0F,0xB6,0xC0,0x83,0xC8,0x07,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h xor eax,5                               ; XOR(Xor_rm32_imm8) [EAX,5h:imm32]          encoding(3 bytes) = 83 f0 05
000bh mov [r9],al                             ; MOV(Mov_rm8_r8) [mem(8u,R9:br,:sr),AL]     encoding(3 bytes) = 41 88 01
000eh movzx eax,r8b                           ; MOVZX(Movzx_r32_rm8) [EAX,R8L]             encoding(4 bytes) = 41 0f b6 c0
0012h or eax,7                                ; OR(Or_rm32_imm8) [EAX,7h:imm32]            encoding(3 bytes) = 83 c8 07
0015h mov rdx,[rsp+28h]                       ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 54 24 28
001ah mov [rdx],al                            ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]    encoding(2 bytes) = 88 02
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
; static ReadOnlySpan<byte> opD_64uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x83,0xF2,0x05,0x49,0x89,0x11,0x49,0x83,0xC8,0x07,0x48,0x8B,0x44,0x24,0x28,0x4C,0x89,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,5                               ; XOR(Xor_rm64_imm8) [RDX,5h:imm64]          encoding(4 bytes) = 48 83 f2 05
0009h mov [r9],rdx                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RDX] encoding(3 bytes) = 49 89 11
000ch or r8,7                                 ; OR(Or_rm64_imm8) [R8,7h:imm64]             encoding(4 bytes) = 49 83 c8 07
0010h mov rax,[rsp+28h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 28
0015h mov [rax],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8] encoding(3 bytes) = 4c 89 00
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opE_64u(ulong rdx, out ulong r8, out ulong r9)
; static ReadOnlySpan<byte> opE_64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x83,0xF0,0x05,0x49,0x89,0x00,0x48,0x83,0xCA,0x07,0x49,0x89,0x11,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h xor rax,5                               ; XOR(Xor_rm64_imm8) [RAX,5h:imm64]          encoding(4 bytes) = 48 83 f0 05
000ch mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
000fh or rdx,7                                ; OR(Or_rm64_imm8) [RDX,7h:imm64]            encoding(4 bytes) = 48 83 ca 07
0013h mov [r9],rdx                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RDX] encoding(3 bytes) = 49 89 11
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void opF_64u(ulong rdx, out ulong r8, out ulong r9, out ulong rax)
; static ReadOnlySpan<byte> opF_64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x83,0xF0,0x05,0x49,0x89,0x00,0x48,0x8B,0xC2,0x48,0x83,0xC8,0x07,0x49,0x89,0x01,0x48,0x83,0xE2,0x0D,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x10,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h xor rax,5                               ; XOR(Xor_rm64_imm8) [RAX,5h:imm64]          encoding(4 bytes) = 48 83 f0 05
000ch mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h or rax,7                                ; OR(Or_rm64_imm8) [RAX,7h:imm64]            encoding(4 bytes) = 48 83 c8 07
0016h mov [r9],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RAX] encoding(3 bytes) = 49 89 01
0019h and rdx,0Dh                             ; AND(And_rm64_imm8) [RDX,dh:imm64]          encoding(4 bytes) = 48 83 e2 0d
001dh mov rax,[rsp+28h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 28
0022h mov [rax],rdx                           ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX] encoding(3 bytes) = 48 89 10
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
