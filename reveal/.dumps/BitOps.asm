; 2019-10-22 17:23:24:238
; function: bit get_Off()
; location: [7FFDD9D755A0h, 7FFDD9D755A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_OffBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit get_On()
; location: [7FFDD9D755C0h, 7FFDD9D755CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_OnBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit zero()
; location: [7FFDD9D755E0h, 7FFDD9D755E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zeroBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit identity(bit a)
; location: [7FFDD9D75600h, 7FFDD9D75607h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> identityBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit one()
; location: [7FFDD9D75620h, 7FFDD9D7562Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> oneBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit false(bit a, bit b)
; location: [7FFDD9D75640h, 7FFDD9D7564Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> falseBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit and(bit a, bit b)
; location: [7FFDD9D75660h, 7FFDD9D75669h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nand(bit a, bit b)
; location: [7FFDD9D75680h, 7FFDD9D7568Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit andnot(bit a, bit b)
; location: [7FFDD9D756A0h, 7FFDD9D756AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnotBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x23,0xC1,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit or(bit a, bit b)
; location: [7FFDD9D756C0h, 7FFDD9D756C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nor(bit a, bit b)
; location: [7FFDD9D756E0h, 7FFDD9D756EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit xor(bit a, bit b)
; location: [7FFDD9D75700h, 7FFDD9D75709h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit xnor(bit a, bit b)
; location: [7FFDD9D75720h, 7FFDD9D7572Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit left(bit a, bit b)
; location: [7FFDD9D75740h, 7FFDD9D7574Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> leftBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit right(bit a, bit b)
; location: [7FFDD9D75760h, 7FFDD9D7576Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rightBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit leftnot(bit a, bit b)
; location: [7FFDD9D75780h, 7FFDD9D75790h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> leftnotBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit rightnot(bit a, bit b)
; location: [7FFDD9D757B0h, 7FFDD9D757C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rightnotBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit true(bit a, bit b)
; location: [7FFDD9D757E0h, 7FFDD9D757F2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> trueBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit implies(bit antecedent, bit consequent)
; location: [7FFDD9D75810h, 7FFDD9D75848h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0008h jne short 0014h               ; JNE(Jne_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 75 0a
000ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000ch setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 05
0014h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0019h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001bh mov [rsp],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(3 bytes) = 89 14 24
001eh lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 14 24
0022h test al,al                    ; TEST(Test_rm8_r8) [AL,AL]                            encoding(2 bytes) = 84 c0
0024h jne short 002ah               ; JNE(Jne_rel8_64) [2Ah:jmp64]                         encoding(2 bytes) = 75 04
0026h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0028h jmp short 002fh               ; JMP(Jmp_rel8_64) [2Fh:jmp64]                         encoding(2 bytes) = eb 05
002ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002fh mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0031h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0034h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> impliesBytes => new byte[57]{0x50,0x0F,0x1F,0x40,0x00,0x83,0xF9,0x01,0x75,0x0A,0x85,0xD2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x33,0xD2,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0x84,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit not(bit a)
; location: [7FFDD9D75860h, 7FFDD9D7586Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit xor1(bit a)
; location: [7FFDD9D75880h, 7FFDD9D7588Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor ecx,1                     ; XOR(Xor_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f1 01
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xF1,0x01,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit select(bit a, bit b, bit c)
; location: [7FFDD9D758A0h, 7FFDD9D758B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC1,0xF7,0xD0,0x41,0x23,0xC0,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f01(bit a, bit b, bit c)
; location: [7FFDD9D758D0h, 7FFDD9D758E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f02(bit a, bit b, bit c)
; location: [7FFDD9D75900h, 7FFDD9D75911h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f03(bit a, bit b, bit c)
; location: [7FFDD9D75930h, 7FFDD9D75943h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f04(bit a, bit b, bit c)
; location: [7FFDD9D75960h, 7FFDD9D75971h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f05(bit a, bit b, bit c)
; location: [7FFDD9D75990h, 7FFDD9D759A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x41,0x0B,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f06(bit a, bit b, bit c)
; location: [7FFDD9D759C0h, 7FFDD9D759D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f07(bit a, bit b, bit c)
; location: [7FFDD9D759F0h, 7FFDD9D75A01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xD0,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f08(bit a, bit b, bit c)
; location: [7FFDD9D75A20h, 7FFDD9D75A31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000eh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f09(bit a, bit b, bit c)
; location: [7FFDD9D75A50h, 7FFDD9D75A61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x33,0xD0,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0a(bit a, bit b, bit c)
; location: [7FFDD9D75A80h, 7FFDD9D75A93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0aBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0b(bit a, bit b, bit c)
; location: [7FFDD9D75AB0h, 7FFDD9D75AC4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor edx,1                     ; XOR(Xor_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 f2 01
000fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0bBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x83,0xF2,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0c(bit a, bit b, bit c)
; location: [7FFDD9D75AE0h, 7FFDD9D75AF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0cBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0d(bit a, bit b, bit c)
; location: [7FFDD9D75B10h, 7FFDD9D75B25h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor r8d,1                     ; XOR(Xor_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f0 01
0010h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0013h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0dBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x83,0xF0,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0e(bit a, bit b, bit c)
; location: [7FFDD9D75B40h, 7FFDD9D75B51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0eBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0f(bit a, bit b, bit c)
; location: [7FFDD9D75B70h, 7FFDD9D75B85h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0010h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0012h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0fBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f10(bit a, bit b, bit c)
; location: [7FFDD9D75BA0h, 7FFDD9D75BB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f11(bit a, bit b, bit c)
; location: [7FFDD9D75BD0h, 7FFDD9D75BE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f12(bit a, bit b, bit c)
; location: [7FFDD9D75C00h, 7FFDD9D75C11h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000fh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xC8,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f13(bit a, bit b, bit c)
; location: [7FFDD9D75C30h, 7FFDD9D75C41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xC8,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f14(bit a, bit b, bit c)
; location: [7FFDD9D75C60h, 7FFDD9D75C71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x33,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f15(bit a, bit b, bit c)
; location: [7FFDD9D75C90h, 7FFDD9D75CA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f16(bit a, bit b, bit c)
; location: [7FFDD9D75CC0h, 7FFDD9D75CDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
0012h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0014h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0016h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x41,0x0B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xD0,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f17(bit a, bit b, bit c)
; location: [7FFDD9D75CF0h, 7FFDD9D75D0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
000ah and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
000dh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0011h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0013h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0015h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0018h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x41,0x0B,0xC0,0x41,0x23,0xD0,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f18(bit a, bit b, bit c)
; location: [7FFDD9D75D20h, 7FFDD9D75D2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x41,0x33,0xC8,0x8B,0xC2,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f19(bit a, bit b, bit c)
; location: [7FFDD9D75D40h, 7FFDD9D75D51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
000ah and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
000dh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x41,0x33,0xC0,0x41,0x23,0xD0,0x23,0xD1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1a(bit a, bit b, bit c)
; location: [7FFDD9D75D70h, 7FFDD9D75D83h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000ah and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1aBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x41,0x33,0xC8,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1b(bit a, bit b, bit c)
; location: [7FFDD9D75DA0h, 7FFDD9D75DC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000eh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0011h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0014h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0017h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0019h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1bBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x23,0xC0,0x41,0x8B,0xC8,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1c(bit a, bit b, bit c)
; location: [7FFDD9D75DE0h, 7FFDD9D75DF4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and r8d,ecx                   ; AND(And_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 23 c1
0008h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1cBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x23,0xC1,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x33,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1d(bit a, bit b, bit c)
; location: [7FFDD9D75E10h, 7FFDD9D75E2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
000fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0011h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0014h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0016h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0018h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1dBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x8B,0xC8,0xF7,0xD1,0x83,0xE1,0x01,0x23,0xC2,0xF7,0xD2,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1e(bit a, bit b, bit c)
; location: [7FFDD9D75E40h, 7FFDD9D75E4Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1eBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1f(bit a, bit b, bit c)
; location: [7FFDD9D75E60h, 7FFDD9D75E71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1fBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f20(bit a, bit b, bit c)
; location: [7FFDD9D75E90h, 7FFDD9D75EA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f20Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x23,0xC1,0x83,0xE0,0x01,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f21(bit a, bit b, bit c)
; location: [7FFDD9D75EC0h, 7FFDD9D75ED1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f21Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x33,0xC8,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f22(bit a, bit b, bit c)
; location: [7FFDD9D75EF0h, 7FFDD9D75F03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f22Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x8B,0xC2,0xF7,0xD0,0x41,0x23,0xC0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f23(bit a, bit b, bit c)
; location: [7FFDD9D75F20h, 7FFDD9D75F3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor ecx,1                     ; XOR(Xor_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f1 01
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0013h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0016h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0019h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f23Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x83,0xF1,0x01,0x8B,0xD1,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f24(bit a, bit b, bit c)
; location: [7FFDD9D75F50h, 7FFDD9D75F5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0007h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
000ah mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ch and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f24Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xCA,0x41,0x33,0xD0,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f25(bit a, bit b, bit c)
; location: [7FFDD9D75F70h, 7FFDD9D75F8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh xor r8d,1                     ; XOR(Xor_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f0 01
0012h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0015h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0017h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
001ah xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ch and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f25Bytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x83,0xF0,0x01,0x41,0x8B,0xD0,0xF7,0xD2,0x83,0xE2,0x01,0x33,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f26(bit a, bit b, bit c)
; location: [7FFDD9D75FA0h, 7FFDD9D75FB3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and ecx,edx                   ; AND(And_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 23 ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f26Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xCA,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f27(bit a, bit b, bit c)
; location: [7FFDD9D75FD0h, 7FFDD9D75FF4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0013h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0015h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0017h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
001ah and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
001dh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0021h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f27Bytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x8B,0xD0,0xF7,0xD2,0x8B,0xCA,0x83,0xE1,0x01,0x41,0x23,0xC0,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f28(bit a, bit b, bit c)
; location: [7FFDD9D76010h, 7FFDD9D7601Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000ah and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f28Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x41,0x8B,0xC0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f29(bit a, bit b, bit c)
; location: [7FFDD9D76030h, 7FFDD9D7604Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0009h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0010h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0018h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f29Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xC1,0x0B,0xD1,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x23,0xC0,0x41,0x8B,0xC8,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f2a(bit a, bit b, bit c)
; location: [7FFDD9D76060h, 7FFDD9D76071h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2aBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f2b(bit a, bit b, bit c)
; location: [7FFDD9D76090h, 7FFDD9D760B4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0010h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0012h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0015h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0018h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001bh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
001dh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0021h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2bBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x23,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xD1,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x23,0xC0,0x41,0x8B,0xC8,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f2c(bit a, bit b, bit c)
; location: [7FFDD9D760D0h, 7FFDD9D760DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0008h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
000ah mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2cBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x0B,0xC2,0x33,0xD1,0x41,0x8B,0xC0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f2d(bit a, bit b, bit c)
; location: [7FFDD9D760F0h, 7FFDD9D76101h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2dBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xC2,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f2e(bit a, bit b, bit c)
; location: [7FFDD9D76120h, 7FFDD9D7612Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2eBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x0B,0xC2,0x0B,0xD1,0x41,0x8B,0xC0,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f2f(bit a, bit b, bit c)
; location: [7FFDD9D76140h, 7FFDD9D76156h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000eh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0011h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2fBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x23,0xD0,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f30(bit a, bit b, bit c)
; location: [7FFDD9D76170h, 7FFDD9D76183h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f30Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x8B,0xC2,0xF7,0xD0,0x23,0xC1,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f31(bit a, bit b, bit c)
; location: [7FFDD9D761A0h, 7FFDD9D761BCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor r8d,1                     ; XOR(Xor_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f0 01
0010h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0013h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0015h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0018h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001ah and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f31Bytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x83,0xF0,0x01,0x41,0x8B,0xD0,0xF7,0xD2,0x83,0xE2,0x01,0x0B,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f32(bit a, bit b, bit c)
; location: [7FFDD9D761D0h, 7FFDD9D761E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
000fh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f32Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x0B,0xC8,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f33(bit a, bit b, bit c)
; location: [7FFDD9D76200h, 7FFDD9D76215h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0012h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f33Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x44,0x89,0x44,0x24,0x18,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f34(bit a, bit b, bit c)
; location: [7FFDD9D76230h, 7FFDD9D76244h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and r8d,edx                   ; AND(And_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 23 c2
0008h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f34Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x23,0xC2,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x33,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f35(bit a, bit b, bit c)
; location: [7FFDD9D76260h, 7FFDD9D7627Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
000fh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0011h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0014h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0016h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0018h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f35Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x8B,0xD0,0xF7,0xD2,0x83,0xE2,0x01,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f36(bit a, bit b, bit c)
; location: [7FFDD9D76290h, 7FFDD9D7629Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f36Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xC8,0x8B,0xC2,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f37(bit a, bit b, bit c)
; location: [7FFDD9D762B0h, 7FFDD9D762C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0008h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f37Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xC8,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f38(bit a, bit b, bit c)
; location: [7FFDD9D762E0h, 7FFDD9D762EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8d,ecx                    ; OR(Or_r32_rm32) [R8D,ECX]                            encoding(3 bytes) = 44 0b c1
0008h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
000ah mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f38Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x0B,0xC1,0x33,0xD1,0x41,0x8B,0xC0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f39(bit a, bit b, bit c)
; location: [7FFDD9D76300h, 7FFDD9D76315h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor r8d,1                     ; XOR(Xor_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f0 01
0009h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0013h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f39Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x83,0xF0,0x01,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f3a(bit a, bit b, bit c)
; location: [7FFDD9D76330h, 7FFDD9D7634Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000eh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0010h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0012h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3aBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC1,0x8B,0xD1,0xF7,0xD2,0x41,0x23,0xD0,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f3b(bit a, bit b, bit c)
; location: [7FFDD9D76360h, 7FFDD9D76379h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
000fh xor edx,1                     ; XOR(Xor_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 f2 01
0012h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0014h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0017h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3bBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0x83,0xF2,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f3c(bit a, bit b, bit c)
; location: [7FFDD9D76390h, 7FFDD9D7639Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3cBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x8B,0xC2,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f3d(bit a, bit b, bit c)
; location: [7FFDD9D763B0h, 7FFDD9D763C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
000ah mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3dBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x41,0x0B,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f3e(bit a, bit b, bit c)
; location: [7FFDD9D763E0h, 7FFDD9D763F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
000fh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3eBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0x33,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f3f(bit a, bit b, bit c)
; location: [7FFDD9D76410h, 7FFDD9D76423h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3fBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f40(bit a, bit b, bit c)
; location: [7FFDD9D76440h, 7FFDD9D76451h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f40Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f41(bit a, bit b, bit c)
; location: [7FFDD9D76470h, 7FFDD9D76481h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f41Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f42(bit a, bit b, bit c)
; location: [7FFDD9D764A0h, 7FFDD9D764AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0008h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f42Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x33,0xC8,0x41,0x33,0xD0,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f43(bit a, bit b, bit c)
; location: [7FFDD9D764C0h, 7FFDD9D764DCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and r8d,ecx                   ; AND(And_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 23 c1
0008h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h xor edx,1                     ; XOR(Xor_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 f2 01
0013h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0015h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0018h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ah and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f43Bytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x23,0xC1,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x83,0xF2,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x33,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f44(bit a, bit b, bit c)
; location: [7FFDD9D764F0h, 7FFDD9D76503h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f44Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x41,0x8B,0xC0,0xF7,0xD0,0x23,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f45(bit a, bit b, bit c)
; location: [7FFDD9D76520h, 7FFDD9D76539h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh xor ecx,1                     ; XOR(Xor_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f1 01
0010h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0012h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0015h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0017h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f45Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x83,0xF1,0x01,0xF7,0xD1,0x83,0xE1,0x01,0x0B,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f46(bit a, bit b, bit c)
; location: [7FFDD9D76550h, 7FFDD9D76564h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f46Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f47(bit a, bit b, bit c)
; location: [7FFDD9D76580h, 7FFDD9D7659Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000fh and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0016h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f47Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xF7,0xD1,0x83,0xE1,0x01,0x23,0xC2,0xF7,0xD2,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f48(bit a, bit b, bit c)
; location: [7FFDD9D765B0h, 7FFDD9D765BCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f48Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x33,0xC8,0x8B,0xC2,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f49(bit a, bit b, bit c)
; location: [7FFDD9D765D0h, 7FFDD9D765EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
000ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
000dh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000fh and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0016h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f49Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0x33,0xC0,0x41,0x0B,0xC8,0xF7,0xD1,0x83,0xE1,0x01,0x23,0xC2,0xF7,0xD2,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f4a(bit a, bit b, bit c)
; location: [7FFDD9D76600h, 7FFDD9D7660Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4aBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x41,0x33,0xC8,0x8B,0xC2,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f4b(bit a, bit b, bit c)
; location: [7FFDD9D76620h, 7FFDD9D76631h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
000fh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4bBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x0B,0xC0,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f4c(bit a, bit b, bit c)
; location: [7FFDD9D76650h, 7FFDD9D76661h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4cBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f4d(bit a, bit b, bit c)
; location: [7FFDD9D76680h, 7FFDD9D766A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0012h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0014h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0017h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0019h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
001bh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001fh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4dBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0x23,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x0B,0xC8,0xF7,0xD1,0x83,0xE1,0x01,0x23,0xC2,0xF7,0xD2,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f4e(bit a, bit b, bit c)
; location: [7FFDD9D766C0h, 7FFDD9D766DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
000fh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0012h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0014h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4eBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0x41,0x8B,0xC8,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f4f(bit a, bit b, bit c)
; location: [7FFDD9D766F0h, 7FFDD9D76708h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
000fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0011h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0013h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4fBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x8B,0xC8,0xF7,0xD1,0x23,0xD1,0x83,0xE2,0x01,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f50(bit a, bit b, bit c)
; location: [7FFDD9D76720h, 7FFDD9D76733h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f50Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x41,0x8B,0xC0,0xF7,0xD0,0x23,0xC1,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f51(bit a, bit b, bit c)
; location: [7FFDD9D76750h, 7FFDD9D76769h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh xor edx,1                     ; XOR(Xor_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 f2 01
0010h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0012h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0015h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0017h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f51Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x83,0xF2,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x0B,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f52(bit a, bit b, bit c)
; location: [7FFDD9D76780h, 7FFDD9D76794h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
0012h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f52Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xC8,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f53(bit a, bit b, bit c)
; location: [7FFDD9D767B0h, 7FFDD9D767CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000fh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0012h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0014h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0016h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f53Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f54(bit a, bit b, bit c)
; location: [7FFDD9D767E0h, 7FFDD9D767F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f54Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f55(bit a, bit b, bit c)
; location: [7FFDD9D76810h, 7FFDD9D76825h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0010h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0012h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f55Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f56(bit a, bit b, bit c)
; location: [7FFDD9D76840h, 7FFDD9D7684Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000ah xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f56Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x8B,0xC0,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f57(bit a, bit b, bit c)
; location: [7FFDD9D76860h, 7FFDD9D76871h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f57Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x23,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f58(bit a, bit b, bit c)
; location: [7FFDD9D76890h, 7FFDD9D7689Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f58Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x33,0xC8,0x8B,0xC2,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f59(bit a, bit b, bit c)
; location: [7FFDD9D768B0h, 7FFDD9D768C4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,1                     ; XOR(Xor_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 f2 01
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0011h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f59Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xF2,0x01,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xC1,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f5a(bit a, bit b, bit c)
; location: [7FFDD9D768E0h, 7FFDD9D768EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
000ch xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f5aBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x41,0x8B,0xC0,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f5b(bit a, bit b, bit c)
; location: [7FFDD9D76900h, 7FFDD9D76914h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f5bBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f5c(bit a, bit b, bit c)
; location: [7FFDD9D76930h, 7FFDD9D76944h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f5cBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f5d(bit a, bit b, bit c)
; location: [7FFDD9D76960h, 7FFDD9D76974h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f5dBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f5e(bit a, bit b, bit c)
; location: [7FFDD9D76990h, 7FFDD9D769A4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f5eBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f5f(bit a, bit b, bit c)
; location: [7FFDD9D769C0h, 7FFDD9D769D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f5fBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit faa(bit a, bit b, bit c)
; location: [7FFDD9D769F0h, 7FFDD9D76A00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> faaBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x41,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
