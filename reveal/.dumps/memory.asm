; 2020-01-05 20:14:02:144
; function: int blockalign_64x8u_var(int cellcount)
; static ReadOnlySpan<byte> blockalign_64x8u_varBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x83,0xE0,0x07,0x03,0xC1,0xC1,0xF8,0x03,0x8B,0xD1,0xC1,0xFA,0x1F,0x83,0xE2,0x07,0x03,0xD1,0x83,0xE2,0xF8,0x2B,0xCA,0x74,0x04,0xFF,0xC0,0xEB,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
000ah and eax,7                               ; AND(And_rm32_imm8) [EAX,7h:imm32]          encoding(3 bytes) = 83 e0 07
000dh add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000fh sar eax,3                               ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]           encoding(3 bytes) = c1 f8 03
0012h mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
0014h sar edx,1Fh                             ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]          encoding(3 bytes) = c1 fa 1f
0017h and edx,7                               ; AND(And_rm32_imm8) [EDX,7h:imm32]          encoding(3 bytes) = 83 e2 07
001ah add edx,ecx                             ; ADD(Add_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 03 d1
001ch and edx,0FFFFFFF8h                      ; AND(And_rm32_imm8) [EDX,fffffffffffffff8h:imm32] encoding(3 bytes) = 83 e2 f8
001fh sub ecx,edx                             ; SUB(Sub_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 2b ca
0021h je short 0027h                          ; JE(Je_rel8_64) [27h:jmp64]                 encoding(2 bytes) = 74 04
0023h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
0025h jmp short 0027h                         ; JMP(Jmp_rel8_64) [27h:jmp64]               encoding(2 bytes) = eb 00
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_16()
; static ReadOnlySpan<byte> blockalign_64x8u_16Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                               ; MOV(Mov_r32_imm32) [EAX,2h:imm32]          encoding(5 bytes) = b8 02 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_17()
; static ReadOnlySpan<byte> blockalign_64x8u_17Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                               ; MOV(Mov_r32_imm32) [EAX,3h:imm32]          encoding(5 bytes) = b8 03 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_1()
; static ReadOnlySpan<byte> digit_1Bytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x30,0x4C,0x01,0x10,0x3C,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x85,0xC0,0x75,0x04,0x33,0xD2,0xEB,0x0E,0x8B,0x10,0x48,0x8B,0xD0,0x39,0x12,0x48,0x83,0xC2,0x0C,0x8B,0x40,0x08,0x0F,0xB7,0x42,0x0A,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,13C10014C30h                    ; MOV(Mov_r64_imm64) [RAX,13c10014c30h:imm64] encoding(10 bytes) = 48 b8 30 4c 01 10 3c 01 00 00
000fh mov rax,[rax]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(3 bytes) = 48 8b 00
0012h test rax,rax                            ; TEST(Test_rm64_r64) [RAX,RAX]              encoding(3 bytes) = 48 85 c0
0015h jne short 001bh                         ; JNE(Jne_rel8_64) [1Bh:jmp64]               encoding(2 bytes) = 75 04
0017h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0019h jmp short 0029h                         ; JMP(Jmp_rel8_64) [29h:jmp64]               encoding(2 bytes) = eb 0e
001bh mov edx,[rax]                           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,:sr)] encoding(2 bytes) = 8b 10
001dh mov rdx,rax                             ; MOV(Mov_r64_rm64) [RDX,RAX]                encoding(3 bytes) = 48 8b d0
0020h cmp [rdx],edx                           ; CMP(Cmp_rm32_r32) [mem(32u,RDX:br,:sr),EDX] encoding(2 bytes) = 39 12
0022h add rdx,0Ch                             ; ADD(Add_rm64_imm8) [RDX,ch:imm64]          encoding(4 bytes) = 48 83 c2 0c
0026h mov eax,[rax+8]                         ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)] encoding(3 bytes) = 8b 40 08
0029h movzx eax,word ptr [rdx+0Ah]            ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,:sr)] encoding(4 bytes) = 0f b7 42 0a
002dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_2()
; static ReadOnlySpan<byte> digit_2Bytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xAD,0x23,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h call qword ptr [7FF813E1F6C8h]          ; CALL(Call_rm64) [mem(QwordOffset,RIP:br,:sr)] encoding(6 bytes) = ff 15 ad 23 c2 ff
000bh nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000ch add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit(int i)
; static ReadOnlySpan<byte> digitBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0x48,0xBA,0x3D,0xF3,0x78,0x7E,0x3C,0x01,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]          encoding(3 bytes) = 48 63 c1
0008h mov rdx,13C7E78F33Dh                    ; MOV(Mov_r64_imm64) [RDX,13c7e78f33dh:imm64] encoding(10 bytes) = 48 ba 3d f3 78 7e 3c 01 00 00
0012h movzx eax,byte ptr [rax+rdx]            ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)] encoding(4 bytes) = 0f b6 04 10
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char bdigit(bit b)
; static ReadOnlySpan<byte> bdigitBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xC1,0x30,0x0F,0xB7,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h add ecx,30h                             ; ADD(Add_rm32_imm8) [ECX,30h:imm32]         encoding(3 bytes) = 83 c1 30
0008h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
