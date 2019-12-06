; 2019-12-05 18:50:57:756
; function: ulong lsb_64x8x3(ulong src)
; location: [7FFDDAFD67F0h, 7FFDDAFD6804h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,707070707070707h      ; MOV(Mov_r64_imm64) [RAX,707070707070707h:imm64]      encoding(10 bytes) = 48 b8 07 07 07 07 07 07 07 07
000fh pdep rax,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lsb_64x8x3Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0xC4,0xE2,0xF3,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint lsb_32x8x3(uint src)
; location: [7FFDDAFD6820h, 7FFDDAFD6836h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,707070707070707h      ; MOV(Mov_r64_imm64) [RDX,707070707070707h:imm64]      encoding(10 bytes) = 48 ba 07 07 07 07 07 07 07 07
0011h pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lsb_32x8x3Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0xC4,0xE2,0xFB,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort lsb_16x8x3(ushort src)
; location: [7FFDDAFD6850h, 7FFDDAFD686Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov rdx,707070707070707h      ; MOV(Mov_r64_imm64) [RDX,707070707070707h:imm64]      encoding(10 bytes) = 48 ba 07 07 07 07 07 07 07 07
0012h pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lsb_16x8x3Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0xBA,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0xC4,0xE2,0xFB,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lsb_8x3(byte src)
; location: [7FFDDAFD6C90h, 7FFDDAFD6CAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov rdx,707070707070707h      ; MOV(Mov_r64_imm64) [RDX,707070707070707h:imm64]      encoding(10 bytes) = 48 ba 07 07 07 07 07 07 07 07
0012h pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lsb_8x3Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0xBA,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0x07,0xC4,0xE2,0xFB,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_1x64u(int exp0)
; location: [7FFDDAFD6CC0h, 7FFDDAFD6CCDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_1x64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_2x64u(int exp0, int exp1)
; location: [7FFDDAFD6CE0h, 7FFDDAFD6CFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0018h or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_2x64uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_3x64u(int exp0, int exp1, int exp2)
; location: [7FFDDAFD6D10h, 7FFDDAFD6D39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0018h or rax,r9                     ; OR(Or_r64_rm64) [RAX,R9]                             encoding(3 bytes) = 49 0b c1
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0023h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0026h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_3x64uBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x49,0x0B,0xC1,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_5x64u(int exp0, int exp1, int exp2, int exp3, int exp4)
; location: [7FFDDAFD6D50h, 7FFDDAFD6D96h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0018h or rax,r10                    ; OR(Or_r64_rm64) [RAX,R10]                            encoding(3 bytes) = 49 0b c2
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0023h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0026h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0029h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
002eh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0031h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0034h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0037h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
003ch mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
0040h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0043h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_5x64uBytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x49,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_6x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
; location: [7FFDDAFD6DB0h, 7FFDDAFD6E05h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0018h or rax,r10                    ; OR(Or_r64_rm64) [RAX,R10]                            encoding(3 bytes) = 49 0b c2
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0023h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0026h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0029h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
002eh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0031h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0034h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0037h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
003ch mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
0040h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0043h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0046h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
004bh mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 30
004fh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0052h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_6x64uBytes => new byte[86]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x49,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_7x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
; location: [7FFDDAFD6E20h, 7FFDDAFD6E84h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0018h or rax,r10                    ; OR(Or_r64_rm64) [RAX,R10]                            encoding(3 bytes) = 49 0b c2
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0023h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0026h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0029h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
002eh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0031h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0034h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0037h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
003ch mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
0040h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0043h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0046h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
004bh mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 30
004fh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0052h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0055h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
005ah mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 38
005eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0061h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_7x64uBytes => new byte[101]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x49,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit(ref uint src, byte pos, bit state)
; location: [7FFDDAFD6EA0h, 7FFDDAFD6ED3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 44 8b 08
000bh test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
000eh je short 0022h                ; JE(Je_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 74 12
0010h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0013h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0018h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
001ah or r9d,edx                    ; OR(Or_r32_rm32) [R9D,EDX]                            encoding(3 bytes) = 44 0b ca
001dh mov edx,r9d                   ; MOV(Mov_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 8b d1
0020h jmp short 0031h               ; JMP(Jmp_rel8_64) [31h:jmp64]                         encoding(2 bytes) = eb 0f
0022h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0025h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
002ah shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
002ch not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
002eh and edx,r9d                   ; AND(And_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 23 d1
0031h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bitBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x08,0x45,0x85,0xC0,0x74,0x12,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x44,0x0B,0xCA,0x41,0x8B,0xD1,0xEB,0x0F,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x41,0x23,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_on(ref uint src, byte pos)
; location: [7FFDDAFD6EF0h, 7FFDDAFD6F0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 44 8b 00
000bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0013h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0015h or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0018h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
001bh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_onBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x44,0x0B,0xC2,0x41,0x8B,0xD0,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_off(ref uint src, byte pos)
; location: [7FFDDAFD6F20h, 7FFDDAFD6F3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 44 8b 00
000bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0013h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0015h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0017h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
001ah mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_offBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x41,0x23,0xD0,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
