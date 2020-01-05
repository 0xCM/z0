; 2020-01-05 15:03:45:058
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
; function: Char digit_2()
; static ReadOnlySpan<byte> digit_2Bytes => new byte[39]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB8,0x18,0x4C,0xB7,0x96,0x58,0x02,0x00,0x00,0x48,0x8B,0x00,0x83,0x78,0x08,0x05,0x76,0x09,0x0F,0xB7,0x40,0x16,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xCA,0xE9,0x57,0x5F,0xCC};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h mov rax,25896B74C18h                    ; MOV(Mov_r64_imm64) [RAX,25896b74c18h:imm64] encoding(10 bytes) = 48 b8 18 4c b7 96 58 02 00 00
000fh mov rax,[rax]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(3 bytes) = 48 8b 00
0012h cmp dword ptr [rax+8],5                 ; CMP(Cmp_rm32_imm8) [mem(32u,RAX:br,:sr),5h:imm32] encoding(4 bytes) = 83 78 08 05
0016h jbe short 0021h                         ; JBE(Jbe_rel8_64) [21h:jmp64]               encoding(2 bytes) = 76 09
0018h movzx eax,word ptr [rax+16h]            ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,:sr)] encoding(4 bytes) = 0f b7 40 16
001ch add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0020h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0021h call 7FF8155FFDD0h                      ; CALL(Call_rel32_64) [5F57E9F0h:jmp64]      encoding(5 bytes) = e8 ca e9 57 5f
0026h int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit(int i)
; static ReadOnlySpan<byte> digitBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0x48,0xBA,0x75,0xF2,0x1E,0x85,0x58,0x02,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]          encoding(3 bytes) = 48 63 c1
0008h mov rdx,258851EF275h                    ; MOV(Mov_r64_imm64) [RDX,258851ef275h:imm64] encoding(10 bytes) = 48 ba 75 f2 1e 85 58 02 00 00
0012h movzx eax,byte ptr [rax+rdx]            ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)] encoding(4 bytes) = 0f b6 04 10
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char bdigit(bit b)
; static ReadOnlySpan<byte> bdigitBytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xAD,0x23,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h call qword ptr [7FF8131AF6C8h]          ; CALL(Call_rm64) [mem(QwordOffset,RIP:br,:sr)] encoding(6 bytes) = ff 15 ad 23 c2 ff
000bh nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000ch add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
