; 2019-10-29 02:32:29:979
; function: bit eval(ILogicExpr expr)
; location: [7FFDDBCD04E0h, 7FFDDBCD0634h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
000ch mov rcx,7FFDDBD504C0h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd504c0h:imm64]         encoding(10 bytes) = 48 b9 c0 04 d5 db fd 7f 00 00
0016h call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252FF0h:jmp64]                encoding(5 bytes) = e8 d5 2f 25 5f
001bh test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
001eh jne short 0084h               ; JNE(Jne_rel8_64) [84h:jmp64]                         encoding(2 bytes) = 75 64
0020h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0023h mov rcx,7FFDDBD50610h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd50610h:imm64]         encoding(10 bytes) = 48 b9 10 06 d5 db fd 7f 00 00
002dh call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252FF0h:jmp64]                encoding(5 bytes) = e8 be 2f 25 5f
0032h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0035h jne short 00a6h               ; JNE(Jne_rel8_64) [A6h:jmp64]                         encoding(2 bytes) = 75 6f
0037h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
003ah mov rcx,7FFDDBD50738h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd50738h:imm64]         encoding(10 bytes) = 48 b9 38 07 d5 db fd 7f 00 00
0044h call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252FF0h:jmp64]                encoding(5 bytes) = e8 a7 2f 25 5f
0049h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
004ch jne short 00c8h               ; JNE(Jne_rel8_64) [C8h:jmp64]                         encoding(2 bytes) = 75 7a
004eh mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0051h mov rcx,7FFDDBD50818h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd50818h:imm64]         encoding(10 bytes) = 48 b9 18 08 d5 db fd 7f 00 00
005bh call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252FF0h:jmp64]                encoding(5 bytes) = e8 90 2f 25 5f
0060h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0063h jne short 00dfh               ; JNE(Jne_rel8_64) [DFh:jmp64]                         encoding(2 bytes) = 75 7a
0065h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0068h mov rcx,7FFDDBD508D8h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd508d8h:imm64]         encoding(10 bytes) = 48 b9 d8 08 d5 db fd 7f 00 00
0072h call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252FF0h:jmp64]                encoding(5 bytes) = e8 79 2f 25 5f
0077h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
007ah test rdi,rdi                  ; TEST(Test_rm64_r64) [RDI,RDI]                        encoding(3 bytes) = 48 85 ff
007dh jne short 00e9h               ; JNE(Jne_rel8_64) [E9h:jmp64]                         encoding(2 bytes) = 75 6a
007fh jmp near ptr 0145h            ; JMP(Jmp_rel32_64) [145h:jmp64]                       encoding(5 bytes) = e9 c1 00 00 00
0084h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0087h mov r11,7FFDDB2F0E18h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e18h:imm64]         encoding(10 bytes) = 49 bb 18 0e 2f db fd 7f 00 00
0091h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0093h call qword ptr [7FFDDB2F0E18h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 9f 08 62 ff
0099h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
009ch call 7FFDDB421E90h            ; CALL(Call_rel32_64) [FFFFFFFFFF7519B0h:jmp64]        encoding(5 bytes) = e8 0f 19 75 ff
00a1h jmp near ptr 014dh            ; JMP(Jmp_rel32_64) [14Dh:jmp64]                       encoding(5 bytes) = e9 a7 00 00 00
00a6h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00a9h mov r11,7FFDDB2F0E20h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e20h:imm64]         encoding(10 bytes) = 49 bb 20 0e 2f db fd 7f 00 00
00b3h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
00b5h call qword ptr [7FFDDB2F0E20h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 85 08 62 ff
00bbh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00beh call 7FFDDB421E90h            ; CALL(Call_rel32_64) [FFFFFFFFFF7519B0h:jmp64]        encoding(5 bytes) = e8 ed 18 75 ff
00c3h jmp near ptr 014dh            ; JMP(Jmp_rel32_64) [14Dh:jmp64]                       encoding(5 bytes) = e9 85 00 00 00
00c8h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00cbh mov r11,7FFDDB2F0E28h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e28h:imm64]         encoding(10 bytes) = 49 bb 28 0e 2f db fd 7f 00 00
00d5h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
00d7h call qword ptr [7FFDDB2F0E28h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 6b 08 62 ff
00ddh jmp short 014dh               ; JMP(Jmp_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = eb 6e
00dfh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00e2h call 7FFDDB421E98h            ; CALL(Call_rel32_64) [FFFFFFFFFF7519B8h:jmp64]        encoding(5 bytes) = e8 d1 18 75 ff
00e7h jmp short 014dh               ; JMP(Jmp_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = eb 64
00e9h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
00ech mov r11,7FFDDB2F0E30h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e30h:imm64]         encoding(10 bytes) = 49 bb 30 0e 2f db fd 7f 00 00
00f6h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
00f8h call qword ptr [7FFDDB2F0E30h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 52 08 62 ff
00feh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0101h call 7FFDDB421E90h            ; CALL(Call_rel32_64) [FFFFFFFFFF7519B0h:jmp64]        encoding(5 bytes) = e8 aa 18 75 ff
0106h mov esi,eax                   ; MOV(Mov_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 8b f0
0108h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
010bh mov r11,7FFDDB2F0E38h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e38h:imm64]         encoding(10 bytes) = 49 bb 38 0e 2f db fd 7f 00 00
0115h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0117h call qword ptr [7FFDDB2F0E38h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 3b 08 62 ff
011dh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0120h call 7FFDDB421E90h            ; CALL(Call_rel32_64) [FFFFFFFFFF7519B0h:jmp64]        encoding(5 bytes) = e8 8b 18 75 ff
0125h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0127h mov [rsp+20h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 20
012bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0130h cmp esi,eax                   ; CMP(Cmp_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 3b f0
0132h je short 0138h                ; JE(Je_rel8_64) [138h:jmp64]                          encoding(2 bytes) = 74 04
0134h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0136h jmp short 013dh               ; JMP(Jmp_rel8_64) [13Dh:jmp64]                        encoding(2 bytes) = eb 05
0138h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
013dh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
013fh mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 20
0143h jmp short 014dh               ; JMP(Jmp_rel8_64) [14Dh:jmp64]                        encoding(2 bytes) = eb 08
0145h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0148h call 7FFDDB421EA0h            ; CALL(Call_rel32_64) [FFFFFFFFFF7519C0h:jmp64]        encoding(5 bytes) = e8 73 18 75 ff
014dh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
014eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0152h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0153h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0154h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> evalBytes => new byte[341]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8B,0xD6,0x48,0xB9,0xC0,0x04,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0xD5,0x2F,0x25,0x5F,0x48,0x85,0xC0,0x75,0x64,0x48,0x8B,0xD6,0x48,0xB9,0x10,0x06,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0xBE,0x2F,0x25,0x5F,0x48,0x85,0xC0,0x75,0x6F,0x48,0x8B,0xD6,0x48,0xB9,0x38,0x07,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0xA7,0x2F,0x25,0x5F,0x48,0x85,0xC0,0x75,0x7A,0x48,0x8B,0xD6,0x48,0xB9,0x18,0x08,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x90,0x2F,0x25,0x5F,0x48,0x85,0xC0,0x75,0x7A,0x48,0x8B,0xD6,0x48,0xB9,0xD8,0x08,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x79,0x2F,0x25,0x5F,0x48,0x8B,0xF8,0x48,0x85,0xFF,0x75,0x6A,0xE9,0xC1,0x00,0x00,0x00,0x48,0x8B,0xC8,0x49,0xBB,0x18,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x9F,0x08,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0x0F,0x19,0x75,0xFF,0xE9,0xA7,0x00,0x00,0x00,0x48,0x8B,0xC8,0x49,0xBB,0x20,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x85,0x08,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0xED,0x18,0x75,0xFF,0xE9,0x85,0x00,0x00,0x00,0x48,0x8B,0xC8,0x49,0xBB,0x28,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x6B,0x08,0x62,0xFF,0xEB,0x6E,0x48,0x8B,0xC8,0xE8,0xD1,0x18,0x75,0xFF,0xEB,0x64,0x48,0x8B,0xCF,0x49,0xBB,0x30,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x52,0x08,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0xAA,0x18,0x75,0xFF,0x8B,0xF0,0x48,0x8B,0xCF,0x49,0xBB,0x38,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x3B,0x08,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0x8B,0x18,0x75,0xFF,0x33,0xC9,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x20,0x3B,0xF0,0x74,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x20,0xEB,0x08,0x48,0x8B,0xCE,0xE8,0x73,0x18,0x75,0xFF,0x90,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eval(ILogicOpExpr expr)
; location: [7FFDDBCD0650h, 7FFDDBCD0814h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
000eh mov rcx,7FFDDBD50B50h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd50b50h:imm64]         encoding(10 bytes) = 48 b9 50 0b d5 db fd 7f 00 00
0018h call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252E80h:jmp64]                encoding(5 bytes) = e8 63 2e 25 5f
001dh mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
0020h test rdi,rdi                  ; TEST(Test_rm64_r64) [RDI,RDI]                        encoding(3 bytes) = 48 85 ff
0023h jne short 0062h               ; JNE(Jne_rel8_64) [62h:jmp64]                         encoding(2 bytes) = 75 3d
0025h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0028h mov rcx,7FFDDBD50FF0h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd50ff0h:imm64]         encoding(10 bytes) = 48 b9 f0 0f d5 db fd 7f 00 00
0032h call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252E80h:jmp64]                encoding(5 bytes) = e8 49 2e 25 5f
0037h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
003ah test rbx,rbx                  ; TEST(Test_rm64_r64) [RBX,RBX]                        encoding(3 bytes) = 48 85 db
003dh jne short 00afh               ; JNE(Jne_rel8_64) [AFh:jmp64]                         encoding(2 bytes) = 75 70
003fh mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0042h mov rcx,7FFDDBD51210h         ; MOV(Mov_r64_imm64) [RCX,7ffddbd51210h:imm64]         encoding(10 bytes) = 48 b9 10 12 d5 db fd 7f 00 00
004ch call 7FFE3AF234D0h            ; CALL(Call_rel32_64) [5F252E80h:jmp64]                encoding(5 bytes) = e8 2f 2e 25 5f
0051h mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0054h test rbp,rbp                  ; TEST(Test_rm64_r64) [RBP,RBP]                        encoding(3 bytes) = 48 85 ed
0057h jne near ptr 011eh            ; JNE(Jne_rel32_64) [11Eh:jmp64]                       encoding(6 bytes) = 0f 85 c1 00 00 00
005dh jmp near ptr 01afh            ; JMP(Jmp_rel32_64) [1AFh:jmp64]                       encoding(5 bytes) = e9 4d 01 00 00
0062h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0065h mov r11,7FFDDB2F0E40h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e40h:imm64]         encoding(10 bytes) = 49 bb 40 0e 2f db fd 7f 00 00
006fh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0071h call qword ptr [7FFDDB2F0E40h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 79 07 62 ff
0077h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0079h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
007ch mov r11,7FFDDB2F0E48h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e48h:imm64]         encoding(10 bytes) = 49 bb 48 0e 2f db fd 7f 00 00
0086h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0088h call qword ptr [7FFDDB2F0E48h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 6a 07 62 ff
008eh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0091h call 7FFDDBCD04E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE90h:jmp64]        encoding(5 bytes) = e8 fa fd ff ff
0096h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0098h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
009ah mov rax,7FFDDBCD02E0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbcd02e0h:imm64]         encoding(10 bytes) = 48 b8 e0 02 cd db fd 7f 00 00
00a4h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00a8h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a9h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00aah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00abh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00ach jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
00afh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
00b2h mov r11,7FFDDB2F0E50h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e50h:imm64]         encoding(10 bytes) = 49 bb 50 0e 2f db fd 7f 00 00
00bch cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
00beh call qword ptr [7FFDDB2F0E50h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 3c 07 62 ff
00c4h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
00c6h mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
00c9h mov r11,7FFDDB2F0E58h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e58h:imm64]         encoding(10 bytes) = 49 bb 58 0e 2f db fd 7f 00 00
00d3h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
00d5h call qword ptr [7FFDDB2F0E58h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 2d 07 62 ff
00dbh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00deh call 7FFDDBCD04E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE90h:jmp64]        encoding(5 bytes) = e8 ad fd ff ff
00e3h mov esi,eax                   ; MOV(Mov_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 8b f0
00e5h mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
00e8h mov r11,7FFDDB2F0E60h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e60h:imm64]         encoding(10 bytes) = 49 bb 60 0e 2f db fd 7f 00 00
00f2h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
00f4h call qword ptr [7FFDDB2F0E60h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 16 07 62 ff
00fah mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00fdh call 7FFDDBCD04E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE90h:jmp64]        encoding(5 bytes) = e8 8e fd ff ff
0102h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0105h mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
0107h mov edx,esi                   ; MOV(Mov_r32_rm32) [EDX,ESI]                          encoding(2 bytes) = 8b d6
0109h mov rax,7FFDDBCD02E8h         ; MOV(Mov_r64_imm64) [RAX,7ffddbcd02e8h:imm64]         encoding(10 bytes) = 48 b8 e8 02 cd db fd 7f 00 00
0113h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0117h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0118h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0119h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
011ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
011bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
011eh mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0121h mov r11,7FFDDB2F0E68h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e68h:imm64]         encoding(10 bytes) = 49 bb 68 0e 2f db fd 7f 00 00
012bh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
012dh call qword ptr [7FFDDB2F0E68h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 e5 06 62 ff
0133h mov esi,eax                   ; MOV(Mov_r32_rm32) [ESI,EAX]                          encoding(2 bytes) = 8b f0
0135h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0138h mov r11,7FFDDB2F0E70h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e70h:imm64]         encoding(10 bytes) = 49 bb 70 0e 2f db fd 7f 00 00
0142h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0144h call qword ptr [7FFDDB2F0E70h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 d6 06 62 ff
014ah mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
014dh call 7FFDDBCD04E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE90h:jmp64]        encoding(5 bytes) = e8 3e fd ff ff
0152h mov edi,eax                   ; MOV(Mov_r32_rm32) [EDI,EAX]                          encoding(2 bytes) = 8b f8
0154h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0157h mov r11,7FFDDB2F0E78h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e78h:imm64]         encoding(10 bytes) = 49 bb 78 0e 2f db fd 7f 00 00
0161h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0163h call qword ptr [7FFDDB2F0E78h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 bf 06 62 ff
0169h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
016ch call 7FFDDBCD04E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE90h:jmp64]        encoding(5 bytes) = e8 1f fd ff ff
0171h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0173h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0176h mov r11,7FFDDB2F0E80h         ; MOV(Mov_r64_imm64) [R11,7ffddb2f0e80h:imm64]         encoding(10 bytes) = 49 bb 80 0e 2f db fd 7f 00 00
0180h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0182h call qword ptr [7FFDDB2F0E80h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 a8 06 62 ff
0188h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
018bh call 7FFDDBCD04E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFE90h:jmp64]        encoding(5 bytes) = e8 00 fd ff ff
0190h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0193h mov ecx,esi                   ; MOV(Mov_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 8b ce
0195h mov edx,edi                   ; MOV(Mov_r32_rm32) [EDX,EDI]                          encoding(2 bytes) = 8b d7
0197h mov r8d,ebx                   ; MOV(Mov_r32_rm32) [R8D,EBX]                          encoding(3 bytes) = 44 8b c3
019ah mov rax,7FFDDBCD0300h         ; MOV(Mov_r64_imm64) [RAX,7ffddbcd0300h:imm64]         encoding(10 bytes) = 48 b8 00 03 cd db fd 7f 00 00
01a4h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
01a8h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
01a9h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
01aah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
01abh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
01ach jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
01afh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
01b2h mov rax,7FFDDB421EA0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb421ea0h:imm64]         encoding(10 bytes) = 48 b8 a0 1e 42 db fd 7f 00 00
01bch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
01c0h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
01c1h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
01c2h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
01c3h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
01c4h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> evalBytes => new byte[455]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8B,0xD6,0x48,0xB9,0x50,0x0B,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x63,0x2E,0x25,0x5F,0x48,0x8B,0xF8,0x48,0x85,0xFF,0x75,0x3D,0x48,0x8B,0xD6,0x48,0xB9,0xF0,0x0F,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x49,0x2E,0x25,0x5F,0x48,0x8B,0xD8,0x48,0x85,0xDB,0x75,0x70,0x48,0x8B,0xD6,0x48,0xB9,0x10,0x12,0xD5,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x2F,0x2E,0x25,0x5F,0x48,0x8B,0xE8,0x48,0x85,0xED,0x0F,0x85,0xC1,0x00,0x00,0x00,0xE9,0x4D,0x01,0x00,0x00,0x48,0x8B,0xCF,0x49,0xBB,0x40,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x79,0x07,0x62,0xFF,0x8B,0xD8,0x48,0x8B,0xCF,0x49,0xBB,0x48,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x6A,0x07,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0xFA,0xFD,0xFF,0xFF,0x8B,0xD0,0x8B,0xCB,0x48,0xB8,0xE0,0x02,0xCD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0,0x48,0x8B,0xCB,0x49,0xBB,0x50,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x3C,0x07,0x62,0xFF,0x8B,0xE8,0x48,0x8B,0xCB,0x49,0xBB,0x58,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x2D,0x07,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0xAD,0xFD,0xFF,0xFF,0x8B,0xF0,0x48,0x8B,0xCB,0x49,0xBB,0x60,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x16,0x07,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0x8E,0xFD,0xFF,0xFF,0x44,0x8B,0xC0,0x8B,0xCD,0x8B,0xD6,0x48,0xB8,0xE8,0x02,0xCD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0,0x48,0x8B,0xCD,0x49,0xBB,0x68,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xE5,0x06,0x62,0xFF,0x8B,0xF0,0x48,0x8B,0xCD,0x49,0xBB,0x70,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xD6,0x06,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0x3E,0xFD,0xFF,0xFF,0x8B,0xF8,0x48,0x8B,0xCD,0x49,0xBB,0x78,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xBF,0x06,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0x1F,0xFD,0xFF,0xFF,0x8B,0xD8,0x48,0x8B,0xCD,0x49,0xBB,0x80,0x0E,0x2F,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xA8,0x06,0x62,0xFF,0x48,0x8B,0xC8,0xE8,0x00,0xFD,0xFF,0xFF,0x44,0x8B,0xC8,0x8B,0xCE,0x8B,0xD7,0x44,0x8B,0xC3,0x48,0xB8,0x00,0x03,0xCD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0,0x48,0x8B,0xCE,0x48,0xB8,0xA0,0x1E,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit unhandled(ILogicExpr expr)
; location: [7FFDDBCD0840h, 7FFDDBCD0899h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h mov rcx,7FFDDB4A0390h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4a0390h:imm64]         encoding(10 bytes) = 48 b9 90 03 4a db fd 7f 00 00
0013h call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5F253C70h:jmp64]                encoding(5 bytes) = e8 58 3c 25 5f
0018h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
001bh mov ecx,281h                  ; MOV(Mov_r32_imm32) [ECX,281h:imm32]                  encoding(5 bytes) = b9 81 02 00 00
0020h mov rdx,7FFDDB53F538h         ; MOV(Mov_r64_imm64) [RDX,7ffddb53f538h:imm64]         encoding(10 bytes) = 48 ba 38 f5 53 db fd 7f 00 00
002ah call 7FFE3B04F6E0h            ; CALL(Call_rel32_64) [5F37EEA0h:jmp64]                encoding(5 bytes) = e8 71 ee 37 5f
002fh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0032h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0035h call 7FFDDB414130h            ; CALL(Call_rel32_64) [FFFFFFFFFF7438F0h:jmp64]        encoding(5 bytes) = e8 b6 38 74 ff
003ah mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
003dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0040h call 7FFDDB414C88h            ; CALL(Call_rel32_64) [FFFFFFFFFF744448h:jmp64]        encoding(5 bytes) = e8 03 44 74 ff
0045h lea rcx,[rdi+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4f 10
0049h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
004ch call 7FFE3AF235F0h            ; CALL(Call_rel32_64) [5F252DB0h:jmp64]                encoding(5 bytes) = e8 5f 2d 25 5f
0051h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0054h call 7FFE3AEDA4F0h            ; CALL(Call_rel32_64) [5F209CB0h:jmp64]                encoding(5 bytes) = e8 57 9c 20 5f
0059h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unhandledBytes => new byte[90]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0xB9,0x90,0x03,0x4A,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x58,0x3C,0x25,0x5F,0x48,0x8B,0xF8,0xB9,0x81,0x02,0x00,0x00,0x48,0xBA,0x38,0xF5,0x53,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x71,0xEE,0x37,0x5F,0x48,0x8B,0xC8,0x48,0x8B,0xD6,0xE8,0xB6,0x38,0x74,0xFF,0x48,0x8B,0xF0,0x48,0x8B,0xCF,0xE8,0x03,0x44,0x74,0xFF,0x48,0x8D,0x4F,0x10,0x48,0x8B,0xD6,0xE8,0x5F,0x2D,0x25,0x5F,0x48,0x8B,0xCF,0xE8,0x57,0x9C,0x20,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
