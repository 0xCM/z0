; 2019-12-27 03:44:53:433
; function: void split_g64(ulong src, int index, out ulong x0, out ulong x1)
; location: [7FF7C7FFBE10h, 7FF7C7FFBE3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and edx,3Fh                   ; AND(And_rm32_imm8) [EDX,3fh:imm32]                   encoding(3 bytes) = 83 e2 3f
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r10,rax                   ; MOV(Mov_r64_rm64) [R10,RAX]                          encoding(3 bytes) = 4c 8b d0
0010h shr r10,cl                    ; SHR(Shr_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 ea
0013h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
0019h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001bh shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
001eh dec r11                       ; DEC(Dec_rm64) [R11]                                  encoding(3 bytes) = 49 ff cb
0021h and rax,r11                   ; AND(And_r64_rm64) [RAX,R11]                          encoding(3 bytes) = 49 23 c3
0024h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
0027h mov [r9],r10                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),R10]           encoding(3 bytes) = 4d 89 11
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> split_g64Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x83,0xE2,0x3F,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x41,0xBB,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE3,0x49,0xFF,0xCB,0x49,0x23,0xC3,0x49,0x89,0x00,0x4D,0x89,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split_64(ulong src, int index, out ulong x0, out ulong x1)
; location: [7FF7C7FFBE50h, 7FF7C7FFBE7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and edx,3Fh                   ; AND(And_rm32_imm8) [EDX,3fh:imm32]                   encoding(3 bytes) = 83 e2 3f
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r10,rax                   ; MOV(Mov_r64_rm64) [R10,RAX]                          encoding(3 bytes) = 4c 8b d0
0010h shr r10,cl                    ; SHR(Shr_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 ea
0013h mov [r9],r10                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),R10]           encoding(3 bytes) = 4d 89 11
0016h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001eh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0021h dec r9                        ; DEC(Dec_rm64) [R9]                                   encoding(3 bytes) = 49 ff c9
0024h and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
0027h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> split_64Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x83,0xE2,0x3F,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x4D,0x89,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x49,0xFF,0xC9,0x49,0x23,0xC1,0x49,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split_exact(ulong src, out uint x0, out uint x1)
; location: [7FF7C7FFBE90h, 7FF7C7FFBEA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),ECX]          encoding(2 bytes) = 89 0a
0007h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> split_exactBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inject_8u(byte src, byte dst, int start, int len)
; location: [7FF7C7FFC2C0h, 7FF7C7FFC325h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ah lea ecx,[r9-1]                ; LEA(Lea_r32_m) [ECX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 41 8d 49 ff
000eh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0014h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0017h blsmsk rcx,r10                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RCX,R10]                encoding(VEX, 5 bytes) = c4 c2 f0 f3 d2
001ch mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
001fh and r8d,1Fh                   ; AND(And_rm32_imm8) [R8D,1fh:imm32]                   encoding(4 bytes) = 41 83 e0 1f
0023h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0026h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0029h xor r10d,0FFFFh               ; XOR(Xor_rm32_imm32) [R10D,ffffh:imm32]               encoding(7 bytes) = 41 81 f2 ff ff 00 00
0030h and edx,r10d                  ; AND(And_r32_rm32) [EDX,R10D]                         encoding(3 bytes) = 41 23 d2
0033h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0036h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
003ch mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
003fh shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0042h blsmsk rcx,r10                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RCX,R10]                encoding(VEX, 5 bytes) = c4 c2 f0 f3 d2
0047h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0050h and ecx,eax                   ; AND(And_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 23 c8
0052h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0055h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0058h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
005ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0060h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0062h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_8uBytes => new byte[102]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xD2,0x41,0x8D,0x49,0xFF,0x41,0xBA,0x01,0x00,0x00,0x00,0x49,0xD3,0xE2,0xC4,0xC2,0xF0,0xF3,0xD2,0x44,0x8B,0xD1,0x41,0x83,0xE0,0x1F,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x41,0x81,0xF2,0xFF,0xFF,0x00,0x00,0x41,0x23,0xD2,0x0F,0xB6,0xD2,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE2,0xC4,0xC2,0xF0,0xF3,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC0,0x0F,0xB6,0xC9,0x23,0xC8,0x0F,0xB6,0xC1,0x41,0x8B,0xC8,0xD3,0xE0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inject_16u(ushort src, ushort dst, int start, int len)
; location: [7FF7C7FFC340h, 7FF7C7FFC3A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000ah lea ecx,[r9-1]                ; LEA(Lea_r32_m) [ECX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 41 8d 49 ff
000eh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0014h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0017h blsmsk rcx,r10                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RCX,R10]                encoding(VEX, 5 bytes) = c4 c2 f0 f3 d2
001ch mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
001fh and r8d,1Fh                   ; AND(And_rm32_imm8) [R8D,1fh:imm32]                   encoding(4 bytes) = 41 83 e0 1f
0023h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0026h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0029h xor r10d,0FFFFh               ; XOR(Xor_rm32_imm32) [R10D,ffffh:imm32]               encoding(7 bytes) = 41 81 f2 ff ff 00 00
0030h and edx,r10d                  ; AND(And_r32_rm32) [EDX,R10D]                         encoding(3 bytes) = 41 23 d2
0033h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0036h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
003ch mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
003fh shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0042h blsmsk rcx,r10                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RCX,R10]                encoding(VEX, 5 bytes) = c4 c2 f0 f3 d2
0047h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
004ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
004dh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0050h and ecx,eax                   ; AND(And_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 23 c8
0052h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0055h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0058h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
005ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
005dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0060h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0062h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_16uBytes => new byte[102]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB7,0xD2,0x41,0x8D,0x49,0xFF,0x41,0xBA,0x01,0x00,0x00,0x00,0x49,0xD3,0xE2,0xC4,0xC2,0xF0,0xF3,0xD2,0x44,0x8B,0xD1,0x41,0x83,0xE0,0x1F,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x41,0x81,0xF2,0xFF,0xFF,0x00,0x00,0x41,0x23,0xD2,0x0F,0xB7,0xD2,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE2,0xC4,0xC2,0xF0,0xF3,0xD2,0x0F,0xB7,0xC9,0x0F,0xB7,0xC0,0x0F,0xB7,0xC9,0x23,0xC8,0x0F,0xB7,0xC1,0x41,0x8B,0xC8,0xD3,0xE0,0x0F,0xB7,0xC0,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inject_32u(uint src, uint dst, int start, int len)
; location: [7FF7C7FFC3C0h, 7FF7C7FFC407h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h lea ecx,[r9-1]                ; LEA(Lea_r32_m) [ECX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 41 8d 49 ff
000bh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0011h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0014h blsmsk rcx,r10                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RCX,R10]                encoding(VEX, 5 bytes) = c4 c2 f0 f3 d2
0019h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
001ch and r8d,1Fh                   ; AND(And_rm32_imm8) [R8D,1fh:imm32]                   encoding(4 bytes) = 41 83 e0 1f
0020h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0023h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0026h not r10d                      ; NOT(Not_rm32) [R10D]                                 encoding(3 bytes) = 41 f7 d2
0029h and edx,r10d                  ; AND(And_r32_rm32) [EDX,R10D]                         encoding(3 bytes) = 41 23 d2
002ch mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0032h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0035h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0038h blsmsk r9,r10                 ; BLSMSK(VEX_Blsmsk_r64_rm64) [R9,R10]                 encoding(VEX, 5 bytes) = c4 c2 b0 f3 d2
003dh and eax,r9d                   ; AND(And_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 23 c1
0040h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0043h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0045h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_32uBytes => new byte[72]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0x8D,0x49,0xFF,0x41,0xBA,0x01,0x00,0x00,0x00,0x49,0xD3,0xE2,0xC4,0xC2,0xF0,0xF3,0xD2,0x44,0x8B,0xD1,0x41,0x83,0xE0,0x1F,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x41,0xF7,0xD2,0x41,0x23,0xD2,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE2,0xC4,0xC2,0xB0,0xF3,0xD2,0x41,0x23,0xC1,0x41,0x8B,0xC8,0xD3,0xE0,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inject_64u(ulong src, ulong dst, int start, int len)
; location: [7FF7C7FFC830h, 7FF7C7FFC877h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h lea ecx,[r9-1]                ; LEA(Lea_r32_m) [ECX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 41 8d 49 ff
000ch mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0012h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0015h blsmsk r10,r10                ; BLSMSK(VEX_Blsmsk_r64_rm64) [R10,R10]                encoding(VEX, 5 bytes) = c4 c2 a8 f3 d2
001ah and r8d,3Fh                   ; AND(And_rm32_imm8) [R8D,3fh:imm32]                   encoding(4 bytes) = 41 83 e0 3f
001eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0021h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0024h not r10                       ; NOT(Not_rm64) [R10]                                  encoding(3 bytes) = 49 f7 d2
0027h and rdx,r10                   ; AND(And_r64_rm64) [RDX,R10]                          encoding(3 bytes) = 49 23 d2
002ah mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0030h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0033h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0036h blsmsk r9,r10                 ; BLSMSK(VEX_Blsmsk_r64_rm64) [R9,R10]                 encoding(VEX, 5 bytes) = c4 c2 b0 f3 d2
003bh and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
003eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0041h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0044h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inject_64uBytes => new byte[72]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0x8D,0x49,0xFF,0x41,0xBA,0x01,0x00,0x00,0x00,0x49,0xD3,0xE2,0xC4,0xC2,0xA8,0xF3,0xD2,0x41,0x83,0xE0,0x3F,0x41,0x8B,0xC8,0x49,0xD3,0xE2,0x49,0xF7,0xD2,0x49,0x23,0xD2,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE2,0xC4,0xC2,0xB0,0xF3,0xD2,0x49,0x23,0xC1,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_20()
; location: [7FF7C7FFC890h, 7FF7C7FFC89Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,100000h               ; MOV(Mov_r32_imm32) [EAX,100000h:imm32]               encoding(5 bytes) = b8 00 00 10 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_20Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x10,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_20()
; location: [7FF7C7FFC8B0h, 7FF7C7FFC8BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFh               ; MOV(Mov_r32_imm32) [EAX,fffffh:imm32]                encoding(5 bytes) = b8 ff ff 0f 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_20Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x0F,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_33()
; location: [7FF7C7FFC8D0h, 7FF7C7FFC8DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,200000000h            ; MOV(Mov_r64_imm64) [RAX,200000000h:imm64]            encoding(10 bytes) = 48 b8 00 00 00 00 02 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_33Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_33()
; location: [7FF7C7FFC8F0h, 7FF7C7FFC8FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,1FFFFFFFFh            ; MOV(Mov_r64_imm64) [RAX,1ffffffffh:imm64]            encoding(10 bytes) = 48 b8 ff ff ff ff 01 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_33Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_1()
; location: [7FF7C7FFC910h, 7FF7C7FFC91Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_1()
; location: [7FF7C7FFC930h, 7FF7C7FFC93Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_2()
; location: [7FF7C7FFC950h, 7FF7C7FFC95Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_2()
; location: [7FF7C7FFC970h, 7FF7C7FFC97Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_3()
; location: [7FF7C7FFC990h, 7FF7C7FFC99Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_3()
; location: [7FF7C7FFC9B0h, 7FF7C7FFC9BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_4()
; location: [7FF7C7FFC9D0h, 7FF7C7FFC9DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_4()
; location: [7FF7C7FFC9F0h, 7FF7C7FFC9FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0Fh                   ; MOV(Mov_r32_imm32) [EAX,fh:imm32]                    encoding(5 bytes) = b8 0f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x0F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_5()
; location: [7FF7C7FFCA10h, 7FF7C7FFCA1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_5()
; location: [7FF7C7FFCA30h, 7FF7C7FFCA3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1Fh                   ; MOV(Mov_r32_imm32) [EAX,1fh:imm32]                   encoding(5 bytes) = b8 1f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x1F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_6()
; location: [7FF7C7FFCA50h, 7FF7C7FFCA5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_6Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x40,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_6()
; location: [7FF7C7FFCA70h, 7FF7C7FFCA7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3Fh                   ; MOV(Mov_r32_imm32) [EAX,3fh:imm32]                   encoding(5 bytes) = b8 3f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_6Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x3F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_7()
; location: [7FF7C7FFCA90h, 7FF7C7FFCA9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_7Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_7()
; location: [7FF7C7FFCAB0h, 7FF7C7FFCABAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7Fh                   ; MOV(Mov_r32_imm32) [EAX,7fh:imm32]                   encoding(5 bytes) = b8 7f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_7Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2_8()
; location: [7FF7C7FFCAD0h, 7FF7C7FFCADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2m1_8()
; location: [7FF7C7FFCAF0h, 7FF7C7FFCAFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2m1_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint set_bit(uint src, byte pos, bit state)
; location: [7FF7C7FFCB10h, 7FF7C7FFCB3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
000ah je short 001ah                ; JE(Je_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 74 0e
000ch movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000fh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0014h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h jmp short 002ah               ; JMP(Jmp_rel8_64) [2Ah:jmp64]                         encoding(2 bytes) = eb 10
001ah movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
001dh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0022h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0024h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0026h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0028h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bitBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x45,0x85,0xC0,0x74,0x0E,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0B,0xC2,0xEB,0x10,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x23,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint set_bit_nb(uint src, byte pos, bit state)
; location: [7FF7C7FFCB50h, 7FF7C7FFCB79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ah and edx,1Fh                   ; AND(And_rm32_imm8) [EDX,1fh:imm32]                   encoding(3 bytes) = 83 e2 1f
000dh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0018h not r9d                       ; NOT(Not_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d1
001bh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
001eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0020h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0023h and eax,r9d                   ; AND(And_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 23 c1
0026h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_nbBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xD2,0x83,0xE2,0x1F,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x41,0xF7,0xD1,0x41,0xFF,0xC1,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x23,0xC1,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint set_bit_on(uint src, byte pos)
; location: [7FF7C7FFCB90h, 7FF7C7FFCBA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000ah mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
000fh shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_onBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint set_bit_off(uint src, byte pos)
; location: [7FF7C7FFCBC0h, 7FF7C7FFCBD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000ah mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
000fh shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0011h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0013h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_offBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
