; 2020-01-08 01:52:28:276
; function: ReadOnlySpan<byte> bitseq(byte value)
; static ReadOnlySpan<byte> bitseqBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x48,0x63,0xC0,0x48,0xBA,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                               ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]           encoding(3 bytes) = c1 e0 03
000bh movsxd rax,eax                          ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]          encoding(3 bytes) = 48 63 c0
000eh mov rdx,28CFD815F7Dh                    ; MOV(Mov_r64_imm64) [RDX,28cfd815f7dh:imm64] encoding(10 bytes) = 48 ba 7d 5f 81 fd 8c 02 00 00
0018h add rax,rdx                             ; ADD(Add_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 03 c2
001bh mov [rcx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX] encoding(3 bytes) = 48 89 01
001eh mov dword ptr [rcx+8],8                 ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),8h:imm32] encoding(7 bytes) = c7 41 08 08 00 00 00
0025h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_8u(byte value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_8uBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0xC1,0xE2,0x03,0x48,0x63,0xD2,0x48,0xB9,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0x12,0x48,0x89,0x10,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h movzx edx,cl                            ; MOVZX(Movzx_r32_rm8) [EDX,CL]              encoding(3 bytes) = 0f b6 d1
000bh shl edx,3                               ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]           encoding(3 bytes) = c1 e2 03
000eh movsxd rdx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]          encoding(3 bytes) = 48 63 d2
0011h mov rcx,28CFD815F7Dh                    ; MOV(Mov_r64_imm64) [RCX,28cfd815f7dh:imm64] encoding(10 bytes) = 48 b9 7d 5f 81 fd 8c 02 00 00
001bh add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
001eh mov rdx,[rdx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 12
0021h mov [rax],rdx                           ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX] encoding(3 bytes) = 48 89 10
0024h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_16u(ushort value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_16uBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x48,0x8B,0xC8,0x44,0x0F,0xB6,0xC2,0x41,0xC1,0xE0,0x03,0x4D,0x63,0xC0,0x49,0xB9,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x4D,0x03,0xC1,0x4D,0x8B,0x00,0x4C,0x89,0x01,0x48,0x83,0xC0,0x08,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC1,0xE2,0x03,0x48,0x63,0xD2,0x49,0x03,0xD1,0x48,0x8B,0x12,0x48,0x89,0x10,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h movzx edx,cx                            ; MOVZX(Movzx_r32_rm16) [EDX,CX]             encoding(3 bytes) = 0f b7 d1
000bh mov rcx,rax                             ; MOV(Mov_r64_rm64) [RCX,RAX]                encoding(3 bytes) = 48 8b c8
000eh movzx r8d,dl                            ; MOVZX(Movzx_r32_rm8) [R8D,DL]              encoding(4 bytes) = 44 0f b6 c2
0012h shl r8d,3                               ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]           encoding(4 bytes) = 41 c1 e0 03
0016h movsxd r8,r8d                           ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]           encoding(3 bytes) = 4d 63 c0
0019h mov r9,28CFD815F7Dh                     ; MOV(Mov_r64_imm64) [R9,28cfd815f7dh:imm64] encoding(10 bytes) = 49 b9 7d 5f 81 fd 8c 02 00 00
0023h add r8,r9                               ; ADD(Add_r64_rm64) [R8,R9]                  encoding(3 bytes) = 4d 03 c1
0026h mov r8,[r8]                             ; MOV(Mov_r64_rm64) [R8,mem(64u,R8:br,:sr)]  encoding(3 bytes) = 4d 8b 00
0029h mov [rcx],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8] encoding(3 bytes) = 4c 89 01
002ch add rax,8                               ; ADD(Add_rm64_imm8) [RAX,8h:imm64]          encoding(4 bytes) = 48 83 c0 08
0030h sar edx,8                               ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]           encoding(3 bytes) = c1 fa 08
0033h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0036h shl edx,3                               ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]           encoding(3 bytes) = c1 e2 03
0039h movsxd rdx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]          encoding(3 bytes) = 48 63 d2
003ch add rdx,r9                              ; ADD(Add_r64_rm64) [RDX,R9]                 encoding(3 bytes) = 49 03 d1
003fh mov rdx,[rdx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 12
0042h mov [rax],rdx                           ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX] encoding(3 bytes) = 48 89 10
0045h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_32u(uint value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_32uBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x45,0x33,0xC0,0x41,0x8B,0xC8,0xC1,0xE1,0x03,0x4C,0x63,0xC9,0x4C,0x03,0xC8,0x44,0x8B,0xD2,0x41,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xBA,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x49,0x03,0xCA,0x48,0x8B,0x09,0x49,0x89,0x09,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x04,0x7C,0xC8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000ah xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
000dh mov ecx,r8d                             ; MOV(Mov_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 8b c8
0010h shl ecx,3                               ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]           encoding(3 bytes) = c1 e1 03
0013h movsxd r9,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]           encoding(3 bytes) = 4c 63 c9
0016h add r9,rax                              ; ADD(Add_r64_rm64) [R9,RAX]                 encoding(3 bytes) = 4c 03 c8
0019h mov r10d,edx                            ; MOV(Mov_r32_rm32) [R10D,EDX]               encoding(3 bytes) = 44 8b d2
001ch shr r10d,cl                             ; SHR(Shr_rm32_CL) [R10D,CL]                 encoding(3 bytes) = 41 d3 ea
001fh movzx ecx,r10b                          ; MOVZX(Movzx_r32_rm8) [ECX,R10L]            encoding(4 bytes) = 41 0f b6 ca
0023h shl ecx,3                               ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]           encoding(3 bytes) = c1 e1 03
0026h movsxd rcx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]          encoding(3 bytes) = 48 63 c9
0029h mov r10,28CFD815F7Dh                    ; MOV(Mov_r64_imm64) [R10,28cfd815f7dh:imm64] encoding(10 bytes) = 49 ba 7d 5f 81 fd 8c 02 00 00
0033h add rcx,r10                             ; ADD(Add_r64_rm64) [RCX,R10]                encoding(3 bytes) = 49 03 ca
0036h mov rcx,[rcx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 09
0039h mov [r9],rcx                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RCX] encoding(3 bytes) = 49 89 09
003ch inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
003fh cmp r8d,4                               ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]          encoding(4 bytes) = 41 83 f8 04
0043h jl short 000dh                          ; JL(Jl_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 7c c8
0045h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_64u(ulong value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_64uBytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0xD1,0x45,0x33,0xC0,0x41,0x8B,0xC8,0xC1,0xE1,0x03,0x4C,0x63,0xC9,0x4C,0x03,0xC8,0x4C,0x8B,0xD2,0x49,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xBA,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x49,0x03,0xCA,0x48,0x8B,0x09,0x49,0x89,0x09,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x08,0x7C,0xC8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000bh xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
000eh mov ecx,r8d                             ; MOV(Mov_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 8b c8
0011h shl ecx,3                               ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]           encoding(3 bytes) = c1 e1 03
0014h movsxd r9,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]           encoding(3 bytes) = 4c 63 c9
0017h add r9,rax                              ; ADD(Add_r64_rm64) [R9,RAX]                 encoding(3 bytes) = 4c 03 c8
001ah mov r10,rdx                             ; MOV(Mov_r64_rm64) [R10,RDX]                encoding(3 bytes) = 4c 8b d2
001dh shr r10,cl                              ; SHR(Shr_rm64_CL) [R10,CL]                  encoding(3 bytes) = 49 d3 ea
0020h movzx ecx,r10b                          ; MOVZX(Movzx_r32_rm8) [ECX,R10L]            encoding(4 bytes) = 41 0f b6 ca
0024h shl ecx,3                               ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]           encoding(3 bytes) = c1 e1 03
0027h movsxd rcx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]          encoding(3 bytes) = 48 63 c9
002ah mov r10,28CFD815F7Dh                    ; MOV(Mov_r64_imm64) [R10,28cfd815f7dh:imm64] encoding(10 bytes) = 49 ba 7d 5f 81 fd 8c 02 00 00
0034h add rcx,r10                             ; ADD(Add_r64_rm64) [RCX,R10]                encoding(3 bytes) = 49 03 ca
0037h mov rcx,[rcx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 09
003ah mov [r9],rcx                            ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RCX] encoding(3 bytes) = 49 89 09
003dh inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
0040h cmp r8d,8                               ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]          encoding(4 bytes) = 41 83 f8 08
0044h jl short 000eh                          ; JL(Jl_rel8_64) [Eh:jmp64]                  encoding(2 bytes) = 7c c8
0046h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(int offset, int count)
; static ReadOnlySpan<byte> bitseqBytes => new byte[58]{0x48,0x83,0xEC,0x28,0x90,0x8B,0xC2,0x45,0x8B,0xC8,0x49,0x03,0xC1,0x48,0x3D,0x00,0x08,0x00,0x00,0x77,0x1F,0x48,0x63,0xC2,0x48,0xBA,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x5F,0xF3,0xCE,0xFF,0xCC};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h mov r9d,r8d                             ; MOV(Mov_r32_rm32) [R9D,R8D]                encoding(3 bytes) = 45 8b c8
000ah add rax,r9                              ; ADD(Add_r64_rm64) [RAX,R9]                 encoding(3 bytes) = 49 03 c1
000dh cmp rax,800h                            ; CMP(Cmp_RAX_imm32) [RAX,800h:imm64]        encoding(6 bytes) = 48 3d 00 08 00 00
0013h ja short 0034h                          ; JA(Ja_rel8_64) [34h:jmp64]                 encoding(2 bytes) = 77 1f
0015h movsxd rax,edx                          ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]          encoding(3 bytes) = 48 63 c2
0018h mov rdx,28CFD815F7Dh                    ; MOV(Mov_r64_imm64) [RDX,28cfd815f7dh:imm64] encoding(10 bytes) = 48 ba 7d 5f 81 fd 8c 02 00 00
0022h add rax,rdx                             ; ADD(Add_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 03 c2
0025h mov [rcx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX] encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],r8d                         ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R8D] encoding(4 bytes) = 44 89 41 08
002ch mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
002fh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0034h call 7FF7B59E56A8h                      ; CALL(Call_rel32_64) [FFFFFFFFFFCEF398h:jmp64] encoding(5 bytes) = e8 5f f3 ce ff
0039h int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8u(byte src)
; static ReadOnlySpan<byte> bitseq8uBytes => new byte[89]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0x99,0xB5,0xF7,0x7F,0x00,0x00,0xBA,0x08,0x00,0x00,0x00,0xE8,0x61,0x0A,0x80,0x5F,0x48,0x8D,0x50,0x10,0x40,0x0F,0xB6,0xCF,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xB8,0x7D,0x5F,0x81,0xFD,0x8C,0x02,0x00,0x00,0x49,0x03,0xC8,0x48,0x8B,0x09,0x48,0x89,0x0A,0x48,0x83,0xC0,0x10,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0009h mov edi,edx                             ; MOV(Mov_r32_rm32) [EDI,EDX]                encoding(2 bytes) = 8b fa
000bh mov rcx,7FF7B599EA10h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b599ea10h:imm64] encoding(10 bytes) = 48 b9 10 ea 99 b5 f7 7f 00 00
0015h mov edx,8                               ; MOV(Mov_r32_imm32) [EDX,8h:imm32]          encoding(5 bytes) = ba 08 00 00 00
001ah call 7FF8154F6DE0h                      ; CALL(Call_rel32_64) [5F800A80h:jmp64]      encoding(5 bytes) = e8 61 0a 80 5f
001fh lea rdx,[rax+10h]                       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 48 8d 50 10
0023h movzx ecx,dil                           ; MOVZX(Movzx_r32_rm8) [ECX,DIL]             encoding(4 bytes) = 40 0f b6 cf
0027h shl ecx,3                               ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]           encoding(3 bytes) = c1 e1 03
002ah movsxd rcx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]          encoding(3 bytes) = 48 63 c9
002dh mov r8,28CFD815F7Dh                     ; MOV(Mov_r64_imm64) [R8,28cfd815f7dh:imm64] encoding(10 bytes) = 49 b8 7d 5f 81 fd 8c 02 00 00
0037h add rcx,r8                              ; ADD(Add_r64_rm64) [RCX,R8]                 encoding(3 bytes) = 49 03 c8
003ah mov rcx,[rcx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 09
003dh mov [rdx],rcx                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX] encoding(3 bytes) = 48 89 0a
0040h add rax,10h                             ; ADD(Add_rm64_imm8) [RAX,10h:imm64]         encoding(4 bytes) = 48 83 c0 10
0044h mov edx,8                               ; MOV(Mov_r32_imm32) [EDX,8h:imm32]          encoding(5 bytes) = ba 08 00 00 00
0049h mov [rsi],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX] encoding(3 bytes) = 48 89 06
004ch mov [rsi+8],edx                         ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX] encoding(3 bytes) = 89 56 08
004fh mov rax,rsi                             ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0052h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0056h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0057h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
0058h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> bitchars_8u(byte value)
; static ReadOnlySpan<byte> bitchars_8uBytes => new byte[52]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x04,0x48,0x63,0xC0,0x48,0xBA,0x85,0x69,0x81,0xFD,0x8C,0x02,0x00,0x00,0x48,0x03,0xC2,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x0D,0x98,0x92,0x5F,0xCC};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h shl eax,4                               ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]           encoding(3 bytes) = c1 e0 04
000bh movsxd rax,eax                          ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]          encoding(3 bytes) = 48 63 c0
000eh mov rdx,28CFD816985h                    ; MOV(Mov_r64_imm64) [RDX,28cfd816985h:imm64] encoding(10 bytes) = 48 ba 85 69 81 fd 8c 02 00 00
0018h add rax,rdx                             ; ADD(Add_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 03 c2
001bh mov edx,8                               ; MOV(Mov_r32_imm32) [EDX,8h:imm32]          encoding(5 bytes) = ba 08 00 00 00
0020h mov [rcx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX] encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx                         ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX] encoding(3 bytes) = 89 51 08
0026h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0029h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
002dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
002eh call 7FF81561FC20h                      ; CALL(Call_rel32_64) [5F929840h:jmp64]      encoding(5 bytes) = e8 0d 98 92 5f
0033h int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_8u(byte value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_8uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0xC1,0xE2,0x04,0x48,0x63,0xD2,0x48,0xB9,0x85,0x69,0x81,0xFD,0x8C,0x02,0x00,0x00,0x48,0x03,0xD1,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h movzx edx,cl                            ; MOVZX(Movzx_r32_rm8) [EDX,CL]              encoding(3 bytes) = 0f b6 d1
000bh shl edx,4                               ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]           encoding(3 bytes) = c1 e2 04
000eh movsxd rdx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]          encoding(3 bytes) = 48 63 d2
0011h mov rcx,28CFD816985h                    ; MOV(Mov_r64_imm64) [RCX,28cfd816985h:imm64] encoding(10 bytes) = 48 b9 85 69 81 fd 8c 02 00 00
001bh add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
001eh vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0022h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0026h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_16u(ushort value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_16uBytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xB8,0x85,0x69,0x81,0xFD,0x8C,0x02,0x00,0x00,0x49,0x03,0xC8,0x4C,0x8B,0xC0,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC1,0xE2,0x04,0x48,0x63,0xD2,0x48,0xB9,0x85,0x69,0x81,0xFD,0x8C,0x02,0x00,0x00,0x48,0x03,0xD1,0x48,0x83,0xC0,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h movzx edx,cx                            ; MOVZX(Movzx_r32_rm16) [EDX,CX]             encoding(3 bytes) = 0f b7 d1
000bh movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000eh shl ecx,4                               ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]           encoding(3 bytes) = c1 e1 04
0011h movsxd rcx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]          encoding(3 bytes) = 48 63 c9
0014h mov r8,28CFD816985h                     ; MOV(Mov_r64_imm64) [R8,28cfd816985h:imm64] encoding(10 bytes) = 49 b8 85 69 81 fd 8c 02 00 00
001eh add rcx,r8                              ; ADD(Add_r64_rm64) [RCX,R8]                 encoding(3 bytes) = 49 03 c8
0021h mov r8,rax                              ; MOV(Mov_r64_rm64) [R8,RAX]                 encoding(3 bytes) = 4c 8b c0
0024h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0028h vmovdqu xmmword ptr [r8],xmm0           ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
002dh sar edx,8                               ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]           encoding(3 bytes) = c1 fa 08
0030h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0033h shl edx,4                               ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]           encoding(3 bytes) = c1 e2 04
0036h movsxd rdx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]          encoding(3 bytes) = 48 63 d2
0039h mov rcx,28CFD816985h                    ; MOV(Mov_r64_imm64) [RCX,28cfd816985h:imm64] encoding(10 bytes) = 48 b9 85 69 81 fd 8c 02 00 00
0043h add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
0046h add rax,10h                             ; ADD(Add_rm64_imm8) [RAX,10h:imm64]         encoding(4 bytes) = 48 83 c0 10
004ah vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
004eh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0052h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_32u(uint value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_32uBytes => new byte[78]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x45,0x33,0xC0,0x45,0x8B,0xC8,0x41,0xC1,0xE1,0x03,0x41,0x8B,0xC9,0x44,0x8B,0xD2,0x41,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xBA,0x85,0x69,0x81,0xFD,0x8C,0x02,0x00,0x00,0x49,0x03,0xCA,0x4D,0x63,0xC9,0x4E,0x8D,0x0C,0x48,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x01,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x04,0x7C,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000ah xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
000dh mov r9d,r8d                             ; MOV(Mov_r32_rm32) [R9D,R8D]                encoding(3 bytes) = 45 8b c8
0010h shl r9d,3                               ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]           encoding(4 bytes) = 41 c1 e1 03
0014h mov ecx,r9d                             ; MOV(Mov_r32_rm32) [ECX,R9D]                encoding(3 bytes) = 41 8b c9
0017h mov r10d,edx                            ; MOV(Mov_r32_rm32) [R10D,EDX]               encoding(3 bytes) = 44 8b d2
001ah shr r10d,cl                             ; SHR(Shr_rm32_CL) [R10D,CL]                 encoding(3 bytes) = 41 d3 ea
001dh movzx ecx,r10b                          ; MOVZX(Movzx_r32_rm8) [ECX,R10L]            encoding(4 bytes) = 41 0f b6 ca
0021h shl ecx,4                               ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]           encoding(3 bytes) = c1 e1 04
0024h movsxd rcx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]          encoding(3 bytes) = 48 63 c9
0027h mov r10,28CFD816985h                    ; MOV(Mov_r64_imm64) [R10,28cfd816985h:imm64] encoding(10 bytes) = 49 ba 85 69 81 fd 8c 02 00 00
0031h add rcx,r10                             ; ADD(Add_r64_rm64) [RCX,R10]                encoding(3 bytes) = 49 03 ca
0034h movsxd r9,r9d                           ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]           encoding(3 bytes) = 4d 63 c9
0037h lea r9,[rax+r9*2]                       ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 4e 8d 0c 48
003bh vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
003fh vmovdqu xmmword ptr [r9],xmm0           ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0044h inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
0047h cmp r8d,4                               ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]          encoding(4 bytes) = 41 83 f8 04
004bh jl short 000dh                          ; JL(Jl_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 7c c0
004dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_64u(ulong value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_64uBytes => new byte[79]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x48,0x8B,0xD1,0x45,0x33,0xC0,0x45,0x8B,0xC8,0x41,0xC1,0xE1,0x03,0x41,0x8B,0xC9,0x4C,0x8B,0xD2,0x49,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xBA,0x85,0x69,0x81,0xFD,0x8C,0x02,0x00,0x00,0x49,0x03,0xCA,0x4D,0x63,0xC9,0x4E,0x8D,0x0C,0x48,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x01,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x08,0x7C,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000bh xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
000eh mov r9d,r8d                             ; MOV(Mov_r32_rm32) [R9D,R8D]                encoding(3 bytes) = 45 8b c8
0011h shl r9d,3                               ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]           encoding(4 bytes) = 41 c1 e1 03
0015h mov ecx,r9d                             ; MOV(Mov_r32_rm32) [ECX,R9D]                encoding(3 bytes) = 41 8b c9
0018h mov r10,rdx                             ; MOV(Mov_r64_rm64) [R10,RDX]                encoding(3 bytes) = 4c 8b d2
001bh shr r10,cl                              ; SHR(Shr_rm64_CL) [R10,CL]                  encoding(3 bytes) = 49 d3 ea
001eh movzx ecx,r10b                          ; MOVZX(Movzx_r32_rm8) [ECX,R10L]            encoding(4 bytes) = 41 0f b6 ca
0022h shl ecx,4                               ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]           encoding(3 bytes) = c1 e1 04
0025h movsxd rcx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]          encoding(3 bytes) = 48 63 c9
0028h mov r10,28CFD816985h                    ; MOV(Mov_r64_imm64) [R10,28cfd816985h:imm64] encoding(10 bytes) = 49 ba 85 69 81 fd 8c 02 00 00
0032h add rcx,r10                             ; ADD(Add_r64_rm64) [RCX,R10]                encoding(3 bytes) = 49 03 ca
0035h movsxd r9,r9d                           ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]           encoding(3 bytes) = 4d 63 c9
0038h lea r9,[rax+r9*2]                       ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 4e 8d 0c 48
003ch vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0040h vmovdqu xmmword ptr [r9],xmm0           ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0045h inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
0048h cmp r8d,8                               ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]          encoding(4 bytes) = 41 83 f8 08
004ch jl short 000eh                          ; JL(Jl_rel8_64) [Eh:jmp64]                  encoding(2 bytes) = 7c c0
004eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
