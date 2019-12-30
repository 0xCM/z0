; 2019-12-29 23:01:33:046
; function: N64 get_n64()
; location: [7FF7C7B82420h, 7FF7C7B82434h]
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
; location: [7FF7C7B82450h, 7FF7C7B8245Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> iskind_16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PrimalKind:uint getkind_16u()
; location: [7FF7C7B82470h, 7FF7C7B8247Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> getkind_16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_var(int cellcount)
; location: [7FF7C7B82A10h, 7FF7C7B82A37h]
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
; location: [7FF7C7B82A50h, 7FF7C7B82A5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blockalign_64x8u_16Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int blockalign_64x8u_17()
; location: [7FF7C7B82A70h, 7FF7C7B82A7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blockalign_64x8u_17Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> get_Chars()
; location: [7FF7C7B82A90h, 7FF7C7B82ADFh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,7FF7C76F8C18h         ; MOV(Mov_r64_imm64) [RCX,7ff7c76f8c18h:imm64]         encoding(10 bytes) = 48 b9 18 8c 6f c7 f7 7f 00 00
0012h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
0017h call 7FF826FA6DE0h            ; CALL(Call_rel32_64) [5F424350h:jmp64]                encoding(5 bytes) = e8 34 43 42 5f
001ch mov rdx,188C8D1D519h          ; MOV(Mov_r64_imm64) [RDX,188c8d1d519h:imm64]          encoding(10 bytes) = 48 ba 19 d5 d1 c8 88 01 00 00
0026h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 48 10
002ah mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
002dh mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0030h mov r8d,[rdx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 42 08
0034h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R8D]          encoding(4 bytes) = 44 89 41 08
0038h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
003ch mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
0041h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
0044h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
0047h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
004ah add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
004eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_CharsBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0xB9,0x18,0x8C,0x6F,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x06,0x00,0x00,0x00,0xE8,0x34,0x43,0x42,0x5F,0x48,0xBA,0x19,0xD5,0xD1,0xC8,0x88,0x01,0x00,0x00,0x48,0x8D,0x48,0x10,0x4C,0x8B,0x02,0x4C,0x89,0x01,0x44,0x8B,0x42,0x08,0x44,0x89,0x41,0x08,0x48,0x83,0xC0,0x10,0xBA,0x06,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> get_Bytes()
; location: [7FF7C7B82B00h, 7FF7C7B82B1Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,188C8D1D511h          ; MOV(Mov_r64_imm64) [RAX,188c8d1d511h:imm64]          encoding(10 bytes) = 48 b8 11 d5 d1 c8 88 01 00 00
000fh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0012h mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 41 08 08 00 00 00
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_BytesBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x11,0xD5,0xD1,0xC8,0x88,0x01,0x00,0x00,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: string get_ContStr()
; location: [7FF7C7B82B30h, 7FF7C7B82B42h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,188C087F9F0h          ; MOV(Mov_r64_imm64) [RAX,188c087f9f0h:imm64]          encoding(10 bytes) = 48 b8 f0 f9 87 c0 88 01 00 00
000fh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_ContStrBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0xF9,0x87,0xC0,0x88,0x01,0x00,0x00,0x48,0x8B,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> get_CharSpan()
; location: [7FF7C7B82B60h, 7FF7C7B82B97h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,188C087F9F0h          ; MOV(Mov_r64_imm64) [RAX,188c087f9f0h:imm64]          encoding(10 bytes) = 48 b8 f0 f9 87 c0 88 01 00 00
000fh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0012h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0015h jne short 001eh               ; JNE(Jne_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = 75 07
0017h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0019h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
001ch jmp short 002dh               ; JMP(Jmp_rel8_64) [2Dh:jmp64]                         encoding(2 bytes) = eb 0f
001eh mov edx,[rax]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 10
0020h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0023h cmp [rdx],edx                 ; CMP(Cmp_rm32_r32) [mem(32u,RDX:br,:sr),EDX]          encoding(2 bytes) = 39 12
0025h add rdx,0Ch                   ; ADD(Add_rm64_imm8) [RDX,ch:imm64]                    encoding(4 bytes) = 48 83 c2 0c
0029h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,:sr)]          encoding(4 bytes) = 44 8b 40 08
002dh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0030h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R8D]          encoding(4 bytes) = 44 89 41 08
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_CharSpanBytes => new byte[56]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0xF9,0x87,0xC0,0x88,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x85,0xC0,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x0F,0x8B,0x10,0x48,0x8B,0xD0,0x39,0x12,0x48,0x83,0xC2,0x0C,0x44,0x8B,0x40,0x08,0x48,0x89,0x11,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_1()
; location: [7FF7C7B82FB0h, 7FF7C7B82FDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,188C087F9F0h          ; MOV(Mov_r64_imm64) [RAX,188c087f9f0h:imm64]          encoding(10 bytes) = 48 b8 f0 f9 87 c0 88 01 00 00
000fh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0012h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0015h jne short 001bh               ; JNE(Jne_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 75 04
0017h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0019h jmp short 0029h               ; JMP(Jmp_rel8_64) [29h:jmp64]                         encoding(2 bytes) = eb 0e
001bh mov edx,[rax]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 10
001dh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0020h cmp [rdx],edx                 ; CMP(Cmp_rm32_r32) [mem(32u,RDX:br,:sr),EDX]          encoding(2 bytes) = 39 12
0022h add rdx,0Ch                   ; ADD(Add_rm64_imm8) [RDX,ch:imm64]                    encoding(4 bytes) = 48 83 c2 0c
0026h mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 08
0029h movzx eax,word ptr [rdx+0Ah]  ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,:sr)]      encoding(4 bytes) = 0f b7 42 0a
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_1Bytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0xF9,0x87,0xC0,0x88,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x85,0xC0,0x75,0x04,0x33,0xD2,0xEB,0x0E,0x8B,0x10,0x48,0x8B,0xD0,0x39,0x12,0x48,0x83,0xC2,0x0C,0x8B,0x40,0x08,0x0F,0xB7,0x42,0x0A,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_2()
; location: [7FF7C7B82FF0h, 7FF7C7B83016h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,188C087F9F0h          ; MOV(Mov_r64_imm64) [RAX,188c087f9f0h:imm64]          encoding(10 bytes) = 48 b8 f0 f9 87 c0 88 01 00 00
000fh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0012h cmp dword ptr [rax+8],5       ; CMP(Cmp_rm32_imm8) [mem(32u,RAX:br,:sr),5h:imm32]    encoding(4 bytes) = 83 78 08 05
0016h jbe short 0021h               ; JBE(Jbe_rel8_64) [21h:jmp64]                         encoding(2 bytes) = 76 09
0018h movzx eax,word ptr [rax+16h]  ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,:sr)]      encoding(4 bytes) = 0f b7 40 16
001ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0021h call 7FF8270CFDD0h            ; CALL(Call_rel32_64) [5F54CDE0h:jmp64]                encoding(5 bytes) = e8 ba cd 54 5f
0026h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> digit_2Bytes => new byte[39]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB8,0xF0,0xF9,0x87,0xC0,0x88,0x01,0x00,0x00,0x48,0x8B,0x00,0x83,0x78,0x08,0x05,0x76,0x09,0x0F,0xB7,0x40,0x16,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xBA,0xCD,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit(int i)
; location: [7FF7C7B83030h, 7FF7C7B83046h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0008h mov rdx,188C8D1D511h          ; MOV(Mov_r64_imm64) [RDX,188c8d1d511h:imm64]          encoding(10 bytes) = 48 ba 11 d5 d1 c8 88 01 00 00
0012h movzx eax,byte ptr [rax+rdx]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 04 10
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digitBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0x48,0xBA,0x11,0xD5,0xD1,0xC8,0x88,0x01,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char bdigit(bit b)
; location: [7FF7C7B83060h, 7FF7C7B8306Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add ecx,30h                   ; ADD(Add_rm32_imm8) [ECX,30h:imm32]                   encoding(3 bytes) = 83 c1 30
0008h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bdigitBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xC1,0x30,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
