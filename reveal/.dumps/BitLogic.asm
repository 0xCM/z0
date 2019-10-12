; 2019-10-12 06:44:40:900
; function: Bit and(Bit a, Bit b)
; location: [7FFDAD7E9EF0h, 7FFDAD7E9F03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit or(Bit a, Bit b)
; location: [7FFDAD7E9F20h, 7FFDAD7E9F33h]
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
; location: [7FFDAD7E9F50h, 7FFDAD7E9F63h]
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
; location: [7FFDAD7E9F80h, 7FFDAD7E9F90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit nand(Bit a, Bit b)
; location: [7FFDAD7E9FB0h, 7FFDAD7E9FD7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0016h cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
001ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[40]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit nor(Bit a, Bit b)
; location: [7FFDAD7E9FF0h, 7FFDAD7EA017h]
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
; location: [7FFDAD7EA030h, 7FFDAD7EA057h]
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
; function: Bit select(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA070h, 7FFDAD7EA081h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h jne short 000eh               ; JNE(Jne_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 75 05
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x75,0x05,0x41,0x0F,0xB6,0xC0,0xC3,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f01(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA0A0h, 7FFDAD7EA0E0h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0018h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001bh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002eh cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
0033h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01Bytes => new byte[65]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f02(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA100h, 7FFDAD7EA140h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0017h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
001ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0029h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
002dh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02Bytes => new byte[65]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x41,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f03(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA160h, 7FFDAD7EA18Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+20h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 20
000ah movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000dh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
001bh cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
001fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03Bytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x44,0x89,0x44,0x24,0x20,0x0F,0xB6,0xC2,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f04(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA1B0h, 7FFDAD7EA1F0h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000ch or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0018h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
001dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
002ah movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
002dh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04Bytes => new byte[65]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xC8,0x0B,0xC1,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f05(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA210h, 7FFDAD7EA23Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+18h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 18
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
001bh cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
001fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05Bytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x89,0x54,0x24,0x18,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f06(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA260h, 7FFDAD7EA2A1h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06Bytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f07(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA2C0h, 7FFDAD7EA300h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0018h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001bh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002eh cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
0033h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07Bytes => new byte[65]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f08(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA320h, 7FFDAD7EA361h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002ah mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
002eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0031h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0035h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08Bytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f09(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA380h, 7FFDAD7EA3C0h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0018h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001bh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002eh cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
0033h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09Bytes => new byte[65]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0A(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA3E0h, 7FFDAD7EA40Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+18h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 18
0009h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001bh mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0ABytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x89,0x54,0x24,0x18,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x41,0x0F,0xB6,0xC0,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0B(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA430h, 7FFDAD7EA4B5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
0008h mov edi,r8d                   ; MOV(Mov_r32_rm32) [EDI,R8D]                          encoding(3 bytes) = 41 8b f8
000bh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000dh sete cl                       ; SETE(Sete_rm8) [CL]                                  encoding(3 bytes) = 0f 94 c1
0010h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0013h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0016h mov [rsp+30h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 30
001ah mov rcx,7FFDAD1C8070h         ; MOV(Mov_r64_imm64) [RCX,7ffdad1c8070h:imm64]         encoding(10 bytes) = 48 b9 70 80 1c ad fd 7f 00 00
0024h mov edx,181h                  ; MOV(Mov_r32_imm32) [EDX,181h:imm32]                  encoding(5 bytes) = ba 81 01 00 00
0029h call 7FFE0CC248B0h            ; CALL(Call_rel32_64) [5F43A480h:jmp64]                encoding(5 bytes) = e8 52 a4 43 5f
002eh mov rax,22B900059B0h          ; MOV(Mov_r64_imm64) [RAX,22b900059b0h:imm64]          encoding(10 bytes) = 48 b8 b0 59 00 90 2b 02 00 00
0038h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
003bh movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
003fh movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
0043h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0046h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0048h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004eh mov [rsp+28h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 28
0052h mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 28
0056h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0059h movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
005dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
005fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0062h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0065h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
0069h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
006dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0070h mov edx,[rsp+20h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 20
0074h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0077h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0079h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007fh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0083h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0084h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0085h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0BBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x8B,0xF2,0x41,0x8B,0xF8,0x84,0xC9,0x0F,0x94,0xC1,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x30,0x48,0xB9,0x70,0x80,0x1C,0xAD,0xFD,0x7F,0x00,0x00,0xBA,0x81,0x01,0x00,0x00,0xE8,0x52,0xA4,0x43,0x5F,0x48,0xB8,0xB0,0x59,0x00,0x90,0x2B,0x02,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x40,0x0F,0xB6,0xD6,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x28,0x8B,0x44,0x24,0x28,0x0F,0xB6,0xC0,0x40,0x0F,0xB6,0xD7,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x20,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0C(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA4D0h, 7FFDAD7EA4FDh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+20h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 20
000ah test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0018h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
001bh mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0CBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x44,0x89,0x44,0x24,0x20,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC2,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0D(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA520h, 7FFDAD7EA5A5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
0008h mov edi,r8d                   ; MOV(Mov_r32_rm32) [EDI,R8D]                          encoding(3 bytes) = 41 8b f8
000bh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000dh sete cl                       ; SETE(Sete_rm8) [CL]                                  encoding(3 bytes) = 0f 94 c1
0010h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0013h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0016h mov [rsp+30h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 30
001ah mov rcx,7FFDAD1C8070h         ; MOV(Mov_r64_imm64) [RCX,7ffdad1c8070h:imm64]         encoding(10 bytes) = 48 b9 70 80 1c ad fd 7f 00 00
0024h mov edx,181h                  ; MOV(Mov_r32_imm32) [EDX,181h:imm32]                  encoding(5 bytes) = ba 81 01 00 00
0029h call 7FFE0CC248B0h            ; CALL(Call_rel32_64) [5F43A390h:jmp64]                encoding(5 bytes) = e8 62 a3 43 5f
002eh mov rax,22B900059B0h          ; MOV(Mov_r64_imm64) [RAX,22b900059b0h:imm64]          encoding(10 bytes) = 48 b8 b0 59 00 90 2b 02 00 00
0038h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
003bh movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
003fh movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
0043h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0046h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0048h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004eh mov [rsp+28h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 28
0052h movzx eax,sil                 ; MOVZX(Movzx_r32_rm8) [EAX,SIL]                       encoding(4 bytes) = 40 0f b6 c6
0056h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
005ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
005dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
005fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0062h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0065h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
0069h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
006dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0070h mov edx,[rsp+20h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 20
0074h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0077h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0079h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007fh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0083h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0084h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0085h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0DBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x8B,0xF2,0x41,0x8B,0xF8,0x84,0xC9,0x0F,0x94,0xC1,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x30,0x48,0xB9,0x70,0x80,0x1C,0xAD,0xFD,0x7F,0x00,0x00,0xBA,0x81,0x01,0x00,0x00,0xE8,0x62,0xA3,0x43,0x5F,0x48,0xB8,0xB0,0x59,0x00,0x90,0x2B,0x02,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x40,0x0F,0xB6,0xD7,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x28,0x40,0x0F,0xB6,0xC6,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x20,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0E(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA5C0h, 7FFDAD7EA601h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0EBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0F(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA620h, 7FFDAD7EA639h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000eh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0FBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f10(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA650h, 7FFDAD7EA690h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0018h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
001dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
002ah movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
002dh mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10Bytes => new byte[65]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f11(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA6B0h, 7FFDAD7EA6DCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+10h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 10
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
001bh cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
001fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11Bytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x89,0x4C,0x24,0x10,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f12(Bit a, Bit b, Bit c)
; location: [7FFDAD7EA700h, 7FFDAD7EA741h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12Bytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
