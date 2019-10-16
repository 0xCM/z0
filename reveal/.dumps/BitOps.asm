; 2019-10-15 01:38:29:716
; function: Bit and(Bit a, Bit b)
; location: [7FFDDBEC6690h, 7FFDDBEC66A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit or(Bit a, Bit b)
; location: [7FFDDBEC66C0h, 7FFDDBEC66D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit xor(Bit a, Bit b)
; location: [7FFDDBEC66F0h, 7FFDDBEC6703h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit not(Bit a)
; location: [7FFDDBEC6720h, 7FFDDBEC6730h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit nor(Bit a, Bit b)
; location: [7FFDDBEC6750h, 7FFDDBEC6777h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0016h cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
001ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[40]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit xnor(Bit a, Bit b)
; location: [7FFDDBEC6790h, 7FFDDBEC67B7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0016h cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
001ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[40]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit nand(Bit a, Bit b)
; location: [7FFDDBEC67D0h, 7FFDDBEC682Fh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0008h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000ah mov rcx,7FFDDB755028h         ; MOV(Mov_r64_imm64) [RCX,7ffddb755028h:imm64]         encoding(10 bytes) = 48 b9 28 50 75 db fd 7f 00 00
0014h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0019h call 7FFE3B1048B0h            ; CALL(Call_rel32_64) [5F23E0E0h:jmp64]                encoding(5 bytes) = e8 c2 e0 23 5f
001eh mov rax,2CF90006F00h          ; MOV(Mov_r64_imm64) [RAX,2cf90006f00h:imm64]          encoding(10 bytes) = 48 b8 00 6f 00 90 cf 02 00 00
0028h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
002bh movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
002fh movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
0032h movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
0036h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0039h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
003bh je short 004eh                ; JE(Je_rel8_64) [4Eh:jmp64]                           encoding(2 bytes) = 74 11
003dh movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
0041h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0044h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0046h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0049h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004ch jmp short 0053h               ; JMP(Jmp_rel8_64) [53h:jmp64]                         encoding(2 bytes) = eb 05
004eh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0053h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0056h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0059h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005eh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[96]{0x57,0x56,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x28,0x50,0x75,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xC2,0xE0,0x23,0x5F,0x48,0xB8,0x00,0x6F,0x00,0x90,0xCF,0x02,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x0F,0xB6,0xD0,0x40,0x0F,0xB6,0xCE,0x0F,0xB6,0xD2,0x3B,0xCA,0x74,0x11,0x40,0x0F,0xB6,0xD7,0x0F,0xB6,0xC0,0x3B,0xD0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit implies(Bit antecedent, Bit consequent)
; location: [7FFDDBEC6850h, 7FFDDBEC68CCh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0008h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000ah mov rcx,7FFDDB755028h         ; MOV(Mov_r64_imm64) [RCX,7ffddb755028h:imm64]         encoding(10 bytes) = 48 b9 28 50 75 db fd 7f 00 00
0014h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0019h call 7FFE3B1048B0h            ; CALL(Call_rel32_64) [5F23E060h:jmp64]                encoding(5 bytes) = e8 42 e0 23 5f
001eh mov rax,2CF90006F08h          ; MOV(Mov_r64_imm64) [RAX,2cf90006f08h:imm64]          encoding(10 bytes) = 48 b8 08 6f 00 90 cf 02 00 00
0028h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
002bh movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
002fh movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0038h jne short 005ch               ; JNE(Jne_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 75 22
003ah mov rax,2CF90006F00h          ; MOV(Mov_r64_imm64) [RAX,2cf90006f00h:imm64]          encoding(10 bytes) = 48 b8 00 6f 00 90 cf 02 00 00
0044h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0047h movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
004bh movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
004fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0052h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
0054h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0057h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005ah jmp short 005eh               ; JMP(Jmp_rel8_64) [5Eh:jmp64]                         encoding(2 bytes) = eb 02
005ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
005eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0061h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0064h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
0068h cmp byte ptr [rsp+20h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 20 00
006dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0070h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0073h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0076h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> impliesBytes => new byte[125]{0x57,0x56,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x28,0x50,0x75,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x42,0xE0,0x23,0x5F,0x48,0xB8,0x08,0x6F,0x00,0x90,0xCF,0x02,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x40,0x0F,0xB6,0xD6,0x0F,0xB6,0xC0,0x3B,0xD0,0x75,0x22,0x48,0xB8,0x00,0x6F,0x00,0x90,0xCF,0x02,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x40,0x0F,0xB6,0xD7,0x0F,0xB6,0xC0,0x3B,0xD0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x80,0x7C,0x24,0x20,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit select(Bit a, Bit b, Bit c)
; location: [7FFDDBEC68F0h, 7FFDDBEC6901h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h jne short 000eh               ; JNE(Jne_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 75 05
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x75,0x05,0x41,0x0F,0xB6,0xC0,0xC3,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
