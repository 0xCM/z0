; 2019-12-27 03:44:53:339
; function: N64 get_n64()
; location: [7FF7C7FF30A0h, 7FF7C7FF30B4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0007h mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(4 bytes) = c6 04 24 00
000bh movsx rax,byte ptr [rsp]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,:sr)]        encoding(5 bytes) = 48 0f be 04 24
0010h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_n64Bytes => new byte[21]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0xC6,0x04,0x24,0x00,0x48,0x0F,0xBE,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit iskind_16u()
; location: [7FF7C7FF30D0h, 7FF7C7FF30DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> iskind_16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PrimalKind:uint getkind_16u()
; location: [7FF7C7FF30F0h, 7FF7C7FF30FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> getkind_16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_var(int cellcount)
; location: [7FF7C7FF3690h, 7FF7C7FF36B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000dh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
000fh sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
0012h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0014h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0017h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
001ah add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
001ch and edx,0FFFFFFF8h            ; AND(And_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 e2 f8
001fh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0021h je short 0027h                ; JE(Je_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 74 04
0023h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0025h jmp short 0027h               ; JMP(Jmp_rel8_64) [27h:jmp64]                         encoding(2 bytes) = eb 00
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blockalign_64x8u_varBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x83,0xE0,0x07,0x03,0xC1,0xC1,0xF8,0x03,0x8B,0xD1,0xC1,0xFA,0x1F,0x83,0xE2,0x07,0x03,0xD1,0x83,0xE2,0xF8,0x2B,0xCA,0x74,0x04,0xFF,0xC0,0xEB,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_16()
; location: [7FF7C7FF36D0h, 7FF7C7FF36DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blockalign_64x8u_16Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_17()
; location: [7FF7C7FF36F0h, 7FF7C7FF36FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blockalign_64x8u_17Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
