; 2019-10-27 16:51:33:447
; function: ReadOnlySpan<byte> bitseq(byte value)
; location: [7FFDDBACEB00h, 7FFDDBACEB41h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
000bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0011h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0018h ja short 003ch                ; JA(Ja_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 77 22
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh mov rdx,2073B2281FDh          ; MOV(Mov_r64_imm64) [RDX,2073b2281fdh:imm64]          encoding(10 bytes) = 48 ba fd 81 22 3b 07 02 00 00
0027h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
002ah mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
002dh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,DS:sr),8h:imm32] encoding(7 bytes) = c7 41 08 08 00 00 00
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ch call 7FFDDB410468h            ; CALL(Call_rel32_64) [FFFFFFFFFF941968h:jmp64]        encoding(5 bytes) = e8 27 19 94 ff
0041h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[66]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x8B,0xD0,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x22,0x48,0x63,0xC0,0x48,0xBA,0xFD,0x81,0x22,0x3B,0x07,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x27,0x19,0x94,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(BitSize offset, BitSize count)
; location: [7FFDDBACEB60h, 7FFDDBACEB99h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
000ah add rax,r9                    ; ADD(Add_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 03 c1
000dh cmp rax,800h                  ; CMP(Cmp_RAX_imm32) [RAX,800h:imm64]                  encoding(6 bytes) = 48 3d 00 08 00 00
0013h ja short 0034h                ; JA(Ja_rel8_64) [34h:jmp64]                           encoding(2 bytes) = 77 1f
0015h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0018h mov rdx,2073B2281FDh          ; MOV(Mov_r64_imm64) [RDX,2073b2281fdh:imm64]          encoding(10 bytes) = 48 ba fd 81 22 3b 07 02 00 00
0022h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 41 08
002ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0034h call 7FFDDB410468h            ; CALL(Call_rel32_64) [FFFFFFFFFF941908h:jmp64]        encoding(5 bytes) = e8 cf 18 94 ff
0039h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[58]{0x48,0x83,0xEC,0x28,0x90,0x8B,0xC2,0x45,0x8B,0xC8,0x49,0x03,0xC1,0x48,0x3D,0x00,0x08,0x00,0x00,0x77,0x1F,0x48,0x63,0xC2,0x48,0xBA,0xFD,0x81,0x22,0x3B,0x07,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xCF,0x18,0x94,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteInfo byteinfo(byte src)
; location: [7FFDDBACEFC0h, 7FFDDBACF05Fh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0018h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
001bh mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
001dh mov rcx,7FFDDB4B8058h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4b8058h:imm64]         encoding(10 bytes) = 48 b9 58 80 4b db fd 7f 00 00
0027h mov edx,17Ah                  ; MOV(Mov_r32_imm32) [EDX,17ah:imm32]                  encoding(5 bytes) = ba 7a 01 00 00
002ch call 7FFE3AF248B0h            ; CALL(Call_rel32_64) [5F4558F0h:jmp64]                encoding(5 bytes) = e8 bf 58 45 5f
0031h mov rax,20732DD57C0h          ; MOV(Mov_r64_imm64) [RAX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b8 c0 57 dd 32 07 02 00 00
003bh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
003eh movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
0042h cmp edx,[rax+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 3b 50 08
0045h jae short 009ah               ; JAE(Jae_rel8_64) [9Ah:jmp64]                         encoding(2 bytes) = 73 53
0047h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
004ah shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
004eh lea rax,[rax+rdx+10h]         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RAX:br,DS:sr)]       encoding(5 bytes) = 48 8d 44 10 10
0053h movzx edx,byte ptr [rax+18h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 50 18
0057h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
005ah mov r8,[rax+8]                ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(4 bytes) = 4c 8b 40 08
005eh mov rax,[rax+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 48 8b 40 10
0062h lea r9,[rsp+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 20
0067h mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 09
006ah mov [r9+8],r8                 ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),R8]          encoding(4 bytes) = 4d 89 41 08
006eh mov [r9+10h],rax              ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(4 bytes) = 49 89 41 10
0072h mov [r9+18h],dl               ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),DL]             encoding(4 bytes) = 41 88 51 18
0076h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
0079h lea rsi,[rsp+20h]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 74 24 20
007eh call 7FFE3AF23690h            ; CALL(Call_rel32_64) [5F4546D0h:jmp64]                encoding(5 bytes) = e8 4d 46 45 5f
0083h call 7FFE3AF23690h            ; CALL(Call_rel32_64) [5F4546D0h:jmp64]                encoding(5 bytes) = e8 48 46 45 5f
0088h call 7FFE3AF23690h            ; CALL(Call_rel32_64) [5F4546D0h:jmp64]                encoding(5 bytes) = e8 43 46 45 5f
008dh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
008fh mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0092h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0096h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0097h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0098h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0099h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
009ah call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F57FF40h:jmp64]                encoding(5 bytes) = e8 a1 fe 57 5f
009fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> byteinfoBytes => new byte[160]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xD9,0x8B,0xF2,0x48,0xB9,0x58,0x80,0x4B,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x7A,0x01,0x00,0x00,0xE8,0xBF,0x58,0x45,0x5F,0x48,0xB8,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x00,0x40,0x0F,0xB6,0xD6,0x3B,0x50,0x08,0x73,0x53,0x48,0x63,0xD2,0x48,0xC1,0xE2,0x05,0x48,0x8D,0x44,0x10,0x10,0x0F,0xB6,0x50,0x18,0x48,0x8B,0x08,0x4C,0x8B,0x40,0x08,0x48,0x8B,0x40,0x10,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x4D,0x89,0x41,0x08,0x49,0x89,0x41,0x10,0x41,0x88,0x51,0x18,0x48,0x8B,0xFB,0x48,0x8D,0x74,0x24,0x20,0xE8,0x4D,0x46,0x45,0x5F,0xE8,0x48,0x46,0x45,0x5F,0xE8,0x43,0x46,0x45,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xE8,0xA1,0xFE,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8i(sbyte src)
; location: [7FFDDBACF080h, 7FFDDBACF0F0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov [rsp+48h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 48
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh movsx rdi,byte ptr [rsp+48h]  ; MOVSX(Movsx_r64_rm8) [RDI,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 7c 24 48
0013h mov rcx,7FFDDB4B8058h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4b8058h:imm64]         encoding(10 bytes) = 48 b9 58 80 4b db fd 7f 00 00
001dh mov edx,17Ah                  ; MOV(Mov_r32_imm32) [EDX,17ah:imm32]                  encoding(5 bytes) = ba 7a 01 00 00
0022h call 7FFE3AF248B0h            ; CALL(Call_rel32_64) [5F455830h:jmp64]                encoding(5 bytes) = e8 09 58 45 5f
0027h mov rax,20732DD57C0h          ; MOV(Mov_r64_imm64) [RAX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b8 c0 57 dd 32 07 02 00 00
0031h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0034h movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
0038h cmp edx,[rax+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 3b 50 08
003bh jae short 006bh               ; JAE(Jae_rel8_64) [6Bh:jmp64]                         encoding(2 bytes) = 73 2e
003dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0040h shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
0044h mov rax,[rax+rdx+10h]         ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(5 bytes) = 48 8b 44 10 10
0049h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
004ch jne short 0054h               ; JNE(Jne_rel8_64) [54h:jmp64]                         encoding(2 bytes) = 75 06
004eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0050h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0052h jmp short 005bh               ; JMP(Jmp_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = eb 07
0054h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0058h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
005bh mov [rsi],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 16
005eh mov [rsi+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),ECX]        encoding(3 bytes) = 89 4e 08
0061h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0064h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0068h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0069h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006bh call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F57FE80h:jmp64]                encoding(5 bytes) = e8 10 fe 57 5f
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq8iBytes => new byte[113]{0x57,0x56,0x48,0x83,0xEC,0x28,0x89,0x54,0x24,0x48,0x48,0x8B,0xF1,0x48,0x0F,0xBE,0x7C,0x24,0x48,0x48,0xB9,0x58,0x80,0x4B,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x7A,0x01,0x00,0x00,0xE8,0x09,0x58,0x45,0x5F,0x48,0xB8,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x00,0x40,0x0F,0xB6,0xD7,0x3B,0x50,0x08,0x73,0x2E,0x48,0x63,0xD2,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x44,0x10,0x10,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x48,0x89,0x16,0x89,0x4E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x10,0xFE,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8u(byte src)
; location: [7FFDDBACF110h, 7FFDDBACF17Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov [rsp+48h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 48
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh movzx edi,byte ptr [rsp+48h]  ; MOVZX(Movzx_r32_rm8) [EDI,mem(8u,RSP:br,SS:sr)]      encoding(6 bytes) = 40 0f b6 7c 24 48
0013h mov rcx,7FFDDB4B8058h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4b8058h:imm64]         encoding(10 bytes) = 48 b9 58 80 4b db fd 7f 00 00
001dh mov edx,17Ah                  ; MOV(Mov_r32_imm32) [EDX,17ah:imm32]                  encoding(5 bytes) = ba 7a 01 00 00
0022h call 7FFE3AF248B0h            ; CALL(Call_rel32_64) [5F4557A0h:jmp64]                encoding(5 bytes) = e8 79 57 45 5f
0027h mov rax,20732DD57C0h          ; MOV(Mov_r64_imm64) [RAX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b8 c0 57 dd 32 07 02 00 00
0031h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0034h cmp edi,[rax+8]               ; CMP(Cmp_r32_rm32) [EDI,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 3b 78 08
0037h jae short 0067h               ; JAE(Jae_rel8_64) [67h:jmp64]                         encoding(2 bytes) = 73 2e
0039h movsxd rdx,edi                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDI]                    encoding(3 bytes) = 48 63 d7
003ch shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
0040h mov rax,[rax+rdx+10h]         ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(5 bytes) = 48 8b 44 10 10
0045h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
0048h jne short 0050h               ; JNE(Jne_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 75 06
004ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
004ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
004eh jmp short 0057h               ; JMP(Jmp_rel8_64) [57h:jmp64]                         encoding(2 bytes) = eb 07
0050h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0054h mov ecx,[rax+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 48 08
0057h mov [rsi],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 16
005ah mov [rsi+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),ECX]        encoding(3 bytes) = 89 4e 08
005dh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0065h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0066h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0067h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F57FDF0h:jmp64]                encoding(5 bytes) = e8 84 fd 57 5f
006ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq8uBytes => new byte[109]{0x57,0x56,0x48,0x83,0xEC,0x28,0x89,0x54,0x24,0x48,0x48,0x8B,0xF1,0x40,0x0F,0xB6,0x7C,0x24,0x48,0x48,0xB9,0x58,0x80,0x4B,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x7A,0x01,0x00,0x00,0xE8,0x79,0x57,0x45,0x5F,0x48,0xB8,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x00,0x3B,0x78,0x08,0x73,0x2E,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x44,0x10,0x10,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x48,0x89,0x16,0x89,0x4E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x84,0xFD,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq16i(short src)
; location: [7FFDDBACF5A0h, 7FFDDBACF6C6h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
000ah mov [rsp+58h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 58
000eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0011h movsx rcx,word ptr [rsp+58h]  ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 4c 24 58
0017h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
001ah movzx edi,cl                  ; MOVZX(Movzx_r32_rm8) [EDI,CL]                        encoding(4 bytes) = 40 0f b6 f9
001eh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0021h movzx ebx,cl                  ; MOVZX(Movzx_r32_rm8) [EBX,CL]                        encoding(3 bytes) = 0f b6 d9
0024h mov rcx,7FFDDB3CEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb3cea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 3c db fd 7f 00 00
002eh mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
0033h call 7FFE3AF245E0h            ; CALL(Call_rel32_64) [5F455040h:jmp64]                encoding(5 bytes) = e8 08 50 45 5f
0038h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
003ch mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
003fh mov r14d,10h                  ; MOV(Mov_r32_imm32) [R14D,10h:imm32]                  encoding(6 bytes) = 41 be 10 00 00 00
0045h mov rcx,7FFDDB4B8058h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4b8058h:imm64]         encoding(10 bytes) = 48 b9 58 80 4b db fd 7f 00 00
004fh mov edx,17Ah                  ; MOV(Mov_r32_imm32) [EDX,17ah:imm32]                  encoding(5 bytes) = ba 7a 01 00 00
0054h call 7FFE3AF248B0h            ; CALL(Call_rel32_64) [5F455310h:jmp64]                encoding(5 bytes) = e8 b7 52 45 5f
0059h mov rcx,20732DD57C0h          ; MOV(Mov_r64_imm64) [RCX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b9 c0 57 dd 32 07 02 00 00
0063h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0066h cmp edi,[rcx+8]               ; CMP(Cmp_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 79 08
0069h jae near ptr 0121h            ; JAE(Jae_rel32_64) [121h:jmp64]                       encoding(6 bytes) = 0f 83 b2 00 00 00
006fh movsxd rdx,edi                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDI]                    encoding(3 bytes) = 48 63 d7
0072h shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
0076h mov rcx,[rcx+rdx+10h]         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(5 bytes) = 48 8b 4c 11 10
007bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
007eh jne short 0087h               ; JNE(Jne_rel8_64) [87h:jmp64]                         encoding(2 bytes) = 75 07
0080h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0082h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0085h jmp short 008fh               ; JMP(Jmp_rel8_64) [8Fh:jmp64]                         encoding(2 bytes) = eb 08
0087h lea rdx,[rcx+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 51 10
008bh mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
008fh test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0092h jb short 0109h                ; JB(Jb_rel8_64) [109h:jmp64]                          encoding(2 bytes) = 72 75
0094h cmp r8d,r14d                  ; CMP(Cmp_r32_rm32) [R8D,R14D]                         encoding(3 bytes) = 45 3b c6
0097h ja short 010fh                ; JA(Ja_rel8_64) [10Fh:jmp64]                          encoding(2 bytes) = 77 76
0099h movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
009ch mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
009fh call 7FFE3A868F00h            ; CALL(Call_rel32_64) [5ED99960h:jmp64]                encoding(5 bytes) = e8 bc 98 d9 5e
00a4h mov rcx,20732DD57C0h          ; MOV(Mov_r64_imm64) [RCX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b9 c0 57 dd 32 07 02 00 00
00aeh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
00b1h cmp ebx,[rcx+8]               ; CMP(Cmp_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 59 08
00b4h jae short 0121h               ; JAE(Jae_rel8_64) [121h:jmp64]                        encoding(2 bytes) = 73 6b
00b6h movsxd rdx,ebx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EBX]                    encoding(3 bytes) = 48 63 d3
00b9h shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
00bdh mov rcx,[rcx+rdx+10h]         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(5 bytes) = 48 8b 4c 11 10
00c2h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
00c5h jne short 00ceh               ; JNE(Jne_rel8_64) [CEh:jmp64]                         encoding(2 bytes) = 75 07
00c7h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00c9h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
00cch jmp short 00d6h               ; JMP(Jmp_rel8_64) [D6h:jmp64]                         encoding(2 bytes) = eb 08
00ceh lea rdx,[rcx+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 51 10
00d2h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
00d6h cmp r14d,8                    ; CMP(Cmp_rm32_imm8) [R14D,8h:imm32]                   encoding(4 bytes) = 41 83 fe 08
00dah jb short 0115h                ; JB(Jb_rel8_64) [115h:jmp64]                          encoding(2 bytes) = 72 39
00dch lea ecx,[r14-8]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,R14:br,DS:sr)]       encoding(4 bytes) = 41 8d 4e f8
00e0h lea rax,[rbp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RBP:br,SS:sr)]       encoding(4 bytes) = 48 8d 45 08
00e4h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
00e7h ja short 011bh                ; JA(Ja_rel8_64) [11Bh:jmp64]                          encoding(2 bytes) = 77 32
00e9h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00ech movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
00efh call 7FFE3A868F00h            ; CALL(Call_rel32_64) [5ED99960h:jmp64]                encoding(5 bytes) = e8 6c 98 d9 5e
00f4h mov [rsi],rbp                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RBP]        encoding(3 bytes) = 48 89 2e
00f7h mov [rsi+8],r14d              ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),R14D]       encoding(4 bytes) = 44 89 76 08
00fbh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00feh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0102h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0103h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0104h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0105h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0106h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0108h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0109h call 7FFDDB410468h            ; CALL(Call_rel32_64) [FFFFFFFFFF940EC8h:jmp64]        encoding(5 bytes) = e8 ba 0d 94 ff
010eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
010fh call 7FFDDB410470h            ; CALL(Call_rel32_64) [FFFFFFFFFF940ED0h:jmp64]        encoding(5 bytes) = e8 bc 0d 94 ff
0114h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0115h call 7FFDDB410468h            ; CALL(Call_rel32_64) [FFFFFFFFFF940EC8h:jmp64]        encoding(5 bytes) = e8 ae 0d 94 ff
011ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
011bh call 7FFDDB410470h            ; CALL(Call_rel32_64) [FFFFFFFFFF940ED0h:jmp64]        encoding(5 bytes) = e8 b0 0d 94 ff
0120h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0121h call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F57F960h:jmp64]                encoding(5 bytes) = e8 3a f8 57 5f
0126h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq16iBytes => new byte[295]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x58,0x48,0x8B,0xF1,0x48,0x0F,0xBF,0x4C,0x24,0x58,0x0F,0xB7,0xC9,0x40,0x0F,0xB6,0xF9,0xC1,0xF9,0x08,0x0F,0xB6,0xD9,0x48,0xB9,0x10,0xEA,0x3C,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0x08,0x50,0x45,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x10,0x00,0x00,0x00,0x48,0xB9,0x58,0x80,0x4B,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x7A,0x01,0x00,0x00,0xE8,0xB7,0x52,0x45,0x5F,0x48,0xB9,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x09,0x3B,0x79,0x08,0x0F,0x83,0xB2,0x00,0x00,0x00,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x45,0x85,0xF6,0x72,0x75,0x45,0x3B,0xC6,0x77,0x76,0x4D,0x63,0xC0,0x48,0x8B,0xCD,0xE8,0xBC,0x98,0xD9,0x5E,0x48,0xB9,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x09,0x3B,0x59,0x08,0x73,0x6B,0x48,0x63,0xD3,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x41,0x83,0xFE,0x08,0x72,0x39,0x41,0x8D,0x4E,0xF8,0x48,0x8D,0x45,0x08,0x44,0x3B,0xC1,0x77,0x32,0x48,0x8B,0xC8,0x4D,0x63,0xC0,0xE8,0x6C,0x98,0xD9,0x5E,0x48,0x89,0x2E,0x44,0x89,0x76,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0xBA,0x0D,0x94,0xFF,0xCC,0xE8,0xBC,0x0D,0x94,0xFF,0xCC,0xE8,0xAE,0x0D,0x94,0xFF,0xCC,0xE8,0xB0,0x0D,0x94,0xFF,0xCC,0xE8,0x3A,0xF8,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq16u(ushort src)
; location: [7FFDDBACF6F0h, 7FFDDBACF812h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
000ah mov [rsp+58h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 58
000eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0011h movzx ecx,word ptr [rsp+58h]  ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 4c 24 58
0016h movzx edi,cl                  ; MOVZX(Movzx_r32_rm8) [EDI,CL]                        encoding(4 bytes) = 40 0f b6 f9
001ah sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
001dh movzx ebx,cl                  ; MOVZX(Movzx_r32_rm8) [EBX,CL]                        encoding(3 bytes) = 0f b6 d9
0020h mov rcx,7FFDDB3CEA10h         ; MOV(Mov_r64_imm64) [RCX,7ffddb3cea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 3c db fd 7f 00 00
002ah mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
002fh call 7FFE3AF245E0h            ; CALL(Call_rel32_64) [5F454EF0h:jmp64]                encoding(5 bytes) = e8 bc 4e 45 5f
0034h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0038h mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
003bh mov r14d,10h                  ; MOV(Mov_r32_imm32) [R14D,10h:imm32]                  encoding(6 bytes) = 41 be 10 00 00 00
0041h mov rcx,7FFDDB4B8058h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4b8058h:imm64]         encoding(10 bytes) = 48 b9 58 80 4b db fd 7f 00 00
004bh mov edx,17Ah                  ; MOV(Mov_r32_imm32) [EDX,17ah:imm32]                  encoding(5 bytes) = ba 7a 01 00 00
0050h call 7FFE3AF248B0h            ; CALL(Call_rel32_64) [5F4551C0h:jmp64]                encoding(5 bytes) = e8 6b 51 45 5f
0055h mov rcx,20732DD57C0h          ; MOV(Mov_r64_imm64) [RCX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b9 c0 57 dd 32 07 02 00 00
005fh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0062h cmp edi,[rcx+8]               ; CMP(Cmp_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 79 08
0065h jae near ptr 011dh            ; JAE(Jae_rel32_64) [11Dh:jmp64]                       encoding(6 bytes) = 0f 83 b2 00 00 00
006bh movsxd rdx,edi                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDI]                    encoding(3 bytes) = 48 63 d7
006eh shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
0072h mov rcx,[rcx+rdx+10h]         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(5 bytes) = 48 8b 4c 11 10
0077h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
007ah jne short 0083h               ; JNE(Jne_rel8_64) [83h:jmp64]                         encoding(2 bytes) = 75 07
007ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
007eh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0081h jmp short 008bh               ; JMP(Jmp_rel8_64) [8Bh:jmp64]                         encoding(2 bytes) = eb 08
0083h lea rdx,[rcx+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 51 10
0087h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
008bh test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
008eh jb short 0105h                ; JB(Jb_rel8_64) [105h:jmp64]                          encoding(2 bytes) = 72 75
0090h cmp r8d,r14d                  ; CMP(Cmp_r32_rm32) [R8D,R14D]                         encoding(3 bytes) = 45 3b c6
0093h ja short 010bh                ; JA(Ja_rel8_64) [10Bh:jmp64]                          encoding(2 bytes) = 77 76
0095h movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
0098h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
009bh call 7FFE3A868F00h            ; CALL(Call_rel32_64) [5ED99810h:jmp64]                encoding(5 bytes) = e8 70 97 d9 5e
00a0h mov rcx,20732DD57C0h          ; MOV(Mov_r64_imm64) [RCX,20732dd57c0h:imm64]          encoding(10 bytes) = 48 b9 c0 57 dd 32 07 02 00 00
00aah mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
00adh cmp ebx,[rcx+8]               ; CMP(Cmp_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 59 08
00b0h jae short 011dh               ; JAE(Jae_rel8_64) [11Dh:jmp64]                        encoding(2 bytes) = 73 6b
00b2h movsxd rdx,ebx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EBX]                    encoding(3 bytes) = 48 63 d3
00b5h shl rdx,5                     ; SHL(Shl_rm64_imm8) [RDX,5h:imm8]                     encoding(4 bytes) = 48 c1 e2 05
00b9h mov rcx,[rcx+rdx+10h]         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(5 bytes) = 48 8b 4c 11 10
00beh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
00c1h jne short 00cah               ; JNE(Jne_rel8_64) [CAh:jmp64]                         encoding(2 bytes) = 75 07
00c3h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00c5h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
00c8h jmp short 00d2h               ; JMP(Jmp_rel8_64) [D2h:jmp64]                         encoding(2 bytes) = eb 08
00cah lea rdx,[rcx+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 51 10
00ceh mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
00d2h cmp r14d,8                    ; CMP(Cmp_rm32_imm8) [R14D,8h:imm32]                   encoding(4 bytes) = 41 83 fe 08
00d6h jb short 0111h                ; JB(Jb_rel8_64) [111h:jmp64]                          encoding(2 bytes) = 72 39
00d8h lea ecx,[r14-8]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,R14:br,DS:sr)]       encoding(4 bytes) = 41 8d 4e f8
00dch lea rax,[rbp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RBP:br,SS:sr)]       encoding(4 bytes) = 48 8d 45 08
00e0h cmp r8d,ecx                   ; CMP(Cmp_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 3b c1
00e3h ja short 0117h                ; JA(Ja_rel8_64) [117h:jmp64]                          encoding(2 bytes) = 77 32
00e5h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
00e8h movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
00ebh call 7FFE3A868F00h            ; CALL(Call_rel32_64) [5ED99810h:jmp64]                encoding(5 bytes) = e8 20 97 d9 5e
00f0h mov [rsi],rbp                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RBP]        encoding(3 bytes) = 48 89 2e
00f3h mov [rsi+8],r14d              ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),R14D]       encoding(4 bytes) = 44 89 76 08
00f7h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00fah add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
00feh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00ffh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0100h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0101h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0102h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0104h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0105h call 7FFDDB410468h            ; CALL(Call_rel32_64) [FFFFFFFFFF940D78h:jmp64]        encoding(5 bytes) = e8 6e 0c 94 ff
010ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
010bh call 7FFDDB410470h            ; CALL(Call_rel32_64) [FFFFFFFFFF940D80h:jmp64]        encoding(5 bytes) = e8 70 0c 94 ff
0110h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0111h call 7FFDDB410468h            ; CALL(Call_rel32_64) [FFFFFFFFFF940D78h:jmp64]        encoding(5 bytes) = e8 62 0c 94 ff
0116h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0117h call 7FFDDB410470h            ; CALL(Call_rel32_64) [FFFFFFFFFF940D80h:jmp64]        encoding(5 bytes) = e8 64 0c 94 ff
011ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
011dh call 7FFE3B04EF00h            ; CALL(Call_rel32_64) [5F57F810h:jmp64]                encoding(5 bytes) = e8 ee f6 57 5f
0122h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq16uBytes => new byte[291]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x58,0x48,0x8B,0xF1,0x0F,0xB7,0x4C,0x24,0x58,0x40,0x0F,0xB6,0xF9,0xC1,0xF9,0x08,0x0F,0xB6,0xD9,0x48,0xB9,0x10,0xEA,0x3C,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0xBC,0x4E,0x45,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x10,0x00,0x00,0x00,0x48,0xB9,0x58,0x80,0x4B,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x7A,0x01,0x00,0x00,0xE8,0x6B,0x51,0x45,0x5F,0x48,0xB9,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x09,0x3B,0x79,0x08,0x0F,0x83,0xB2,0x00,0x00,0x00,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x45,0x85,0xF6,0x72,0x75,0x45,0x3B,0xC6,0x77,0x76,0x4D,0x63,0xC0,0x48,0x8B,0xCD,0xE8,0x70,0x97,0xD9,0x5E,0x48,0xB9,0xC0,0x57,0xDD,0x32,0x07,0x02,0x00,0x00,0x48,0x8B,0x09,0x3B,0x59,0x08,0x73,0x6B,0x48,0x63,0xD3,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x41,0x83,0xFE,0x08,0x72,0x39,0x41,0x8D,0x4E,0xF8,0x48,0x8D,0x45,0x08,0x44,0x3B,0xC1,0x77,0x32,0x48,0x8B,0xC8,0x4D,0x63,0xC0,0xE8,0x20,0x97,0xD9,0x5E,0x48,0x89,0x2E,0x44,0x89,0x76,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0x6E,0x0C,0x94,0xFF,0xCC,0xE8,0x70,0x0C,0x94,0xFF,0xCC,0xE8,0x62,0x0C,0x94,0xFF,0xCC,0xE8,0x64,0x0C,0x94,0xFF,0xCC,0xE8,0xEE,0xF6,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq32i(int src)
; location: [7FFDDBACF830h, 7FFDDBACF860h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDDBACE950h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF120h:jmp64]        encoding(5 bytes) = e8 07 f1 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq32iBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x07,0xF1,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq32u(uint src)
; location: [7FFDDBACF880h, 7FFDDBACF8B0h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDDBACE950h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF0D0h:jmp64]        encoding(5 bytes) = e8 b7 f0 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq32uBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0xB7,0xF0,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq64i(long src)
; location: [7FFDDBACF8D0h, 7FFDDBACF900h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDDBACE968h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF098h:jmp64]        encoding(5 bytes) = e8 7f f0 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq64iBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x7F,0xF0,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq64u(ulong src)
; location: [7FFDDBACF920h, 7FFDDBACF950h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDDBACE968h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF048h:jmp64]        encoding(5 bytes) = e8 2f f0 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq64uBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x2F,0xF0,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq32f(float src)
; location: [7FFDDBACF970h, 7FFDDBACF9ADh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000fh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0012h vmovss dword ptr [rsp+2Ch],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 2c
0018h mov edx,[rsp+2Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 2c
001ch lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0021h call 7FFDDBACE950h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFEFE0h:jmp64]        encoding(5 bytes) = e8 ba ef ff ff
0026h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
002bh mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
002fh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0032h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0035h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0038h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
003ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq32fBytes => new byte[62]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF1,0xC5,0xFA,0x11,0x4C,0x24,0x2C,0x8B,0x54,0x24,0x2C,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xBA,0xEF,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x30,0x8B,0x54,0x24,0x38,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq64f(double src)
; location: [7FFDDBACF9D0h, 7FFDDBACFA0Eh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000fh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0012h vmovsd qword ptr [rsp+28h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 28
0018h mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 28
001dh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0022h call 7FFDDBACE968h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFEF98h:jmp64]        encoding(5 bytes) = e8 71 ef ff ff
0027h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
002ch mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
0030h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0033h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq64fBytes => new byte[63]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF1,0xC5,0xFB,0x11,0x4C,0x24,0x28,0x48,0x8B,0x54,0x24,0x28,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x71,0xEF,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x30,0x8B,0x54,0x24,0x38,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_d8i(ref sbyte src, int pos)
; location: [7FFDDBACFA30h, 7FFDDBACFA49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]              encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_g8i(ref sbyte src, int pos)
; location: [7FFDDBACFA60h, 7FFDDBACFA79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]              encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte enable_d8u(ref byte src, int pos)
; location: [7FFDDBACFA90h, 7FFDDBACFAA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]              encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte enable_g8u(ref byte src, int pos)
; location: [7FFDDBACFAC0h, 7FFDDBACFAD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]              encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short enable_d16i(ref short src, int pos)
; location: [7FFDDBACFAF0h, 7FFDDBACFB0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]           encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short enable_g16i(ref short src, int pos)
; location: [7FFDDBACFF30h, 7FFDDBACFF4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]           encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort enable_d16u(ref ushort src, int pos)
; location: [7FFDDBACFF60h, 7FFDDBACFF7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]           encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort enable_g16u(ref ushort src, int pos)
; location: [7FFDDBACFF90h, 7FFDDBACFFAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]           encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int enable_d32i(ref int src, int pos)
; location: [7FFDDBACFFC0h, 7FFDDBACFFD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]          encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int enable_g32i(ref int src, int pos)
; location: [7FFDDBACFFF0h, 7FFDDBAD0006h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]          encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint enable_d32u(ref uint src, int pos)
; location: [7FFDDBAD0020h, 7FFDDBAD0036h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]          encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint enable_g32u(ref uint src, int pos)
; location: [7FFDDBAD0050h, 7FFDDBAD0066h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]          encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long enable_d64i(ref long src, int pos)
; location: [7FFDDBAD0080h, 7FFDDBAD0096h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long enable_g64i(ref long src, int pos)
; location: [7FFDDBAD00B0h, 7FFDDBAD00C6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong enable_d64u(ref ulong src, int pos)
; location: [7FFDDBAD00E0h, 7FFDDBAD00F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong enable_g64u(ref ulong src, int pos)
; location: [7FFDDBAD0110h, 7FFDDBAD0126h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float enable_d32f(ref float src, int pos)
; location: [7FFDDBAD0140h, 7FFDDBAD0176h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
000ch vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
0012h mov r8d,[rsp+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 44 24 04
0017h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0022h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0025h mov [rsp],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(4 bytes) = 44 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32fBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFA,0x10,0x00,0xC5,0xFA,0x11,0x44,0x24,0x04,0x44,0x8B,0x44,0x24,0x04,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x45,0x0B,0xC1,0x44,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float enable_g32f(ref float src, int pos)
; location: [7FFDDBAD0190h, 7FFDDBAD01C6h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
000ch vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
0012h mov r8d,[rsp+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 44 24 04
0017h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0022h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0025h mov [rsp],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(4 bytes) = 44 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32fBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFA,0x10,0x00,0xC5,0xFA,0x11,0x44,0x24,0x04,0x44,0x8B,0x44,0x24,0x04,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x45,0x0B,0xC1,0x44,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double enable_d64f(ref double src, int pos)
; location: [7FFDDBAD01E0h, 7FFDDBAD021Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
000eh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0014h mov r8,[rsp+10h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,SS:sr)]         encoding(5 bytes) = 4c 8b 44 24 10
0019h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rsp+8],r8                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(5 bytes) = 4c 89 44 24 08
002ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0032h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64fBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0xC1,0xC5,0xFB,0x10,0x00,0xC5,0xFB,0x11,0x44,0x24,0x10,0x4C,0x8B,0x44,0x24,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4D,0x0B,0xC1,0x4C,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double enable_g64f(ref double src, int pos)
; location: [7FFDDBAD0240h, 7FFDDBAD027Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
000eh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0014h mov r8,[rsp+10h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,SS:sr)]         encoding(5 bytes) = 4c 8b 44 24 10
0019h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rsp+8],r8                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(5 bytes) = 4c 89 44 24 08
002ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0032h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64fBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0xC1,0xC5,0xFB,0x10,0x00,0xC5,0xFB,0x11,0x44,0x24,0x10,0x4C,0x8B,0x44,0x24,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4D,0x0B,0xC1,0x4C,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d8i(sbyte src, int pos)
; location: [7FFDDBAD02A0h, 7FFDDBAD02D2h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0012h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0015h jb short 001bh                ; JB(Jb_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 72 04
0017h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0019h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 05
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0022h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0025h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0028h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8iBytes => new byte[51]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xBE,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g8i(sbyte src, int pos)
; location: [7FFDDBAD02F0h, 7FFDDBAD0322h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000bh mov [rsp],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(3 bytes) = 89 0c 24
000eh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 0c 24
0012h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0015h jb short 001bh                ; JB(Jb_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 72 04
0017h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0019h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 05
001bh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0020h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0022h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0025h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0028h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8iBytes => new byte[51]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBE,0xC1,0x33,0xC9,0x89,0x0C,0x24,0x48,0x8D,0x0C,0x24,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d8u(byte src, int pos)
; location: [7FFDDBAD0340h, 7FFDDBAD0371h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0011h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0014h jb short 001ah                ; JB(Jb_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 72 04
0016h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0018h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 05
001ah mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001fh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0021h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0024h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0027h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8uBytes => new byte[50]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xB6,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g8u(byte src, int pos)
; location: [7FFDDBAD0390h, 7FFDDBAD03C1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000ah mov [rsp],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(3 bytes) = 89 0c 24
000dh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 0c 24
0011h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0014h jb short 001ah                ; JB(Jb_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 72 04
0016h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0018h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 05
001ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
001fh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0021h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0024h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0027h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8uBytes => new byte[50]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x33,0xC9,0x89,0x0C,0x24,0x48,0x8D,0x0C,0x24,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d16i(short src, int pos)
; location: [7FFDDBAD03E0h, 7FFDDBAD0412h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0012h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0015h jb short 001bh                ; JB(Jb_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 72 04
0017h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0019h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 05
001bh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0020h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0022h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0025h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0028h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16iBytes => new byte[51]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xBF,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g16i(short src, int pos)
; location: [7FFDDBAD0430h, 7FFDDBAD0462h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000bh mov [rsp],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(3 bytes) = 89 0c 24
000eh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 0c 24
0012h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0015h jb short 001bh                ; JB(Jb_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 72 04
0017h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0019h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 05
001bh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0020h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0022h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0025h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0028h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16iBytes => new byte[51]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBF,0xC1,0x33,0xC9,0x89,0x0C,0x24,0x48,0x8D,0x0C,0x24,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d16u(ushort src, int pos)
; location: [7FFDDBAD0480h, 7FFDDBAD04B1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0011h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0014h jb short 001ah                ; JB(Jb_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 72 04
0016h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0018h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 05
001ah mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001fh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0021h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0024h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0027h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16uBytes => new byte[50]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xB7,0xC9,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g16u(ushort src, int pos)
; location: [7FFDDBAD04D0h, 7FFDDBAD0501h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000ah mov [rsp],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(3 bytes) = 89 0c 24
000dh lea rcx,[rsp]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 0c 24
0011h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0014h jb short 001ah                ; JB(Jb_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 72 04
0016h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0018h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 05
001ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
001fh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
0021h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0024h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0027h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16uBytes => new byte[50]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB7,0xC1,0x33,0xC9,0x89,0x0C,0x24,0x48,0x8D,0x0C,0x24,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32i(int src, int pos)
; location: [7FFDDBAD0520h, 7FFDDBAD054Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0011h jb short 0017h                ; JB(Jb_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 72 04
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 05
0017h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001ch mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0021h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0024h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32iBytes => new byte[47]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32i(int src, int pos)
; location: [7FFDDBAD0570h, 7FFDDBAD059Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0011h jb short 0017h                ; JB(Jb_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 72 04
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 05
0017h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001ch mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0021h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0024h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32iBytes => new byte[47]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32u(uint src, int pos)
; location: [7FFDDBAD05C0h, 7FFDDBAD05EEh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0011h jb short 0017h                ; JB(Jb_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 72 04
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 05
0017h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001ch mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0021h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0024h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32uBytes => new byte[47]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32u(uint src, int pos)
; location: [7FFDDBAD0610h, 7FFDDBAD063Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0011h jb short 0017h                ; JB(Jb_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 72 04
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h jmp short 001ch               ; JMP(Jmp_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = eb 05
0017h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001ch mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0021h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0024h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32uBytes => new byte[47]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64i(long src, int pos)
; location: [7FFDDBAD0660h, 7FFDDBAD066Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64i(long src, int pos)
; location: [7FFDDBAD0680h, 7FFDDBAD068Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64u(ulong src, int pos)
; location: [7FFDDBAD06A0h, 7FFDDBAD06CFh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0012h jb short 0018h                ; JB(Jb_rel8_64) [18h:jmp64]                           encoding(2 bytes) = 72 04
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 05
0018h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001fh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0022h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64uBytes => new byte[48]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64u(ulong src, int pos)
; location: [7FFDDBAD06F0h, 7FFDDBAD071Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000eh bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0012h jb short 0018h                ; JB(Jb_rel8_64) [18h:jmp64]                           encoding(2 bytes) = 72 04
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 05
0018h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
001fh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0022h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64uBytes => new byte[48]{0x50,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0x0F,0xA3,0xD1,0x72,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32f(float src, int pos)
; location: [7FFDDBAD0740h, 7FFDDBAD077Dh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0017h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
001ch bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
001fh jb short 0025h                ; JB(Jb_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 72 04
0021h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0023h jmp short 002ah               ; JMP(Jmp_rel8_64) [2Ah:jmp64]                         encoding(2 bytes) = eb 05
0025h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
002ch mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0030h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0033h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32fBytes => new byte[62]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x08,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32f(float src, int pos)
; location: [7FFDDBAD07A0h, 7FFDDBAD07DDh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0013h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0017h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
001ch bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
001fh jb short 0025h                ; JB(Jb_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 72 04
0021h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0023h jmp short 002ah               ; JMP(Jmp_rel8_64) [2Ah:jmp64]                         encoding(2 bytes) = eb 05
0025h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
002ch mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0030h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0033h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32fBytes => new byte[62]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x08,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64f(double src, int pos)
; location: [7FFDDBAD0800h, 7FFDDBAD083Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0014h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0018h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
001dh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0021h jb short 0027h                ; JB(Jb_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 72 04
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h jmp short 002ch               ; JMP(Jmp_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = eb 05
0027h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002ch mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
002eh mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0032h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0035h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0038h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64fBytes => new byte[64]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x48,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x08,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64f(double src, int pos)
; location: [7FFDDBAD0860h, 7FFDDBAD089Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0014h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0018h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
001dh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0021h jb short 0027h                ; JB(Jb_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 72 04
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h jmp short 002ch               ; JMP(Jmp_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = eb 05
0027h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002ch mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
002eh mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0032h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0035h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0038h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64fBytes => new byte[64]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x33,0xC9,0x89,0x4C,0x24,0x08,0x48,0x8D,0x4C,0x24,0x08,0x48,0x0F,0xA3,0xD0,0x72,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x01,0x8B,0x44,0x24,0x08,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_16(uint a)
; location: [7FFDDBAD08C0h, 7FFDDBAD08D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_16Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_16(uint a)
; location: [7FFDDBAD08F0h, 7FFDDBAD0906h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,1000000000000000h     ; MOV(Mov_r64_imm64) [RDX,1000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 10
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_16Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_25(uint a)
; location: [7FFDDBAD0920h, 7FFDDBAD093Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h mov rax,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RAX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 b8 71 3d 0a d7 a3 70 3d 0a
0011h imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
0015h mov eax,19h                   ; MOV(Mov_r32_imm32) [EAX,19h:imm32]                   encoding(5 bytes) = b8 19 00 00 00
001ah mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_25Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xB8,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0x48,0x0F,0xAF,0xD0,0xB8,0x19,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_25(uint a)
; location: [7FFDDBAD0950h, 7FFDDBAD0966h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RDX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 ba 71 3d 0a d7 a3 70 3d 0a
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_25Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_32(uint a)
; location: [7FFDDBAD0980h, 7FFDDBAD0995h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Bh                   ; SHL(Shl_rm64_imm8) [RDX,3bh:imm8]                    encoding(4 bytes) = 48 c1 e2 3b
000bh mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_32Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3B,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_32(uint a)
; location: [7FFDDBAD09B0h, 7FFDDBAD09C6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,800000000000000h      ; MOV(Mov_r64_imm64) [RDX,800000000000000h:imm64]      encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 08
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_32Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_lo_32u(uint x, uint y)
; location: [7FFDDBAD09E0h, 7FFDDBAD09ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0009h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_lo_32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xD2,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_lo_64u(ulong x, ulong y)
; location: [7FFDDBAD0A00h, 7FFDDBAD0A0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_lo_64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_hi_32u(uint x, uint y)
; location: [7FFDDBAD0A20h, 7FFDDBAD0A31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0009h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000dh shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_hi_32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xD2,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_hi_64u(ulong x, ulong y)
; location: [7FFDDBAD0A50h, 7FFDDBAD0A67h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_hi_64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x48,0x8B,0xD1,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_full_32u(uint a, uint b, out uint lo, out uint hi)
; location: [7FFDDBAD0A80h, 7FFDDBAD0A97h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0009h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0014h mov [r9],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 01
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_full_32uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xD2,0x48,0x0F,0xAF,0xC2,0x41,0x89,0x00,0x48,0xC1,0xE8,0x20,0x41,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_full_64u(ulong x, ulong y, out ulong lo, out ulong hi)
; location: [7FFDDBAD0AB0h, 7FFDDBAD0AD4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
0011h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
0014h mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0019h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
001ch mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0021h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 01
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_full_64uBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x89,0x00,0x48,0x8B,0x44,0x24,0x10,0x48,0x8B,0xD1,0xC4,0xE2,0xFB,0xF6,0xC0,0x49,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_and(UInt8 a, UInt8 b)
; location: [7FFDDBAD0AF0h, 7FFDDBAD0AF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_sll(UInt8 a, int offset)
; location: [7FFDDBAD0B10h, 7FFDDBAD0B20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_sllBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_rotl(UInt8 a, int offset)
; location: [7FFDDBAD0B40h, 7FFDDBAD0B62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
000fh and r8d,0FFh                  ; AND(And_rm32_imm32) [R8D,ffh:imm32]                  encoding(7 bytes) = 41 81 e0 ff 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
001ah add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
001dh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
001fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x81,0xE0,0xFF,0x00,0x00,0x00,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE8,0x41,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_rotr(UInt8 a, int offset)
; location: [7FFDDBAD0B80h, 7FFDDBAD0BA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0013h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0016h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0018h and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
001dh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_rotrBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x25,0xFF,0x00,0x00,0x00,0x41,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_mul(UInt8 a, UInt8 b)
; location: [7FFDDBAD0BC0h, 7FFDDBAD0BCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_or(UInt8 a, UInt8 b)
; location: [7FFDDBAD0BE0h, 7FFDDBAD0BE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> tospan_128x8i(Vector128<byte> src)
; location: [7FFDDBAD0C00h, 7FFDDBAD0C18h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDBACFEF0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF2F0h:jmp64]        encoding(5 bytes) = e8 e0 f2 ff ff
0010h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0013h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0017h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> tospan_128x8iBytes => new byte[25]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0xE0,0xF2,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x8u(Vector128<byte> src, ref byte dst)
; location: [7FFDDBAD1040h, 7FFDDBAD104Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x8uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x8i(Vector128<sbyte> src, ref sbyte dst)
; location: [7FFDDBAD1060h, 7FFDDBAD106Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x16i(Vector128<short> src, ref short dst)
; location: [7FFDDBAD1080h, 7FFDDBAD108Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x16iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x16u(Vector128<ushort> src, ref ushort dst)
; location: [7FFDDBAD10A0h, 7FFDDBAD10ADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x16uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x16u(Vector128<ushort> src, ref ushort dst)
; location: [7FFDDBAD10C0h, 7FFDDBAD10CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x16uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x32i(Vector128<int> src, ref int dst)
; location: [7FFDDBAD10E0h, 7FFDDBAD10EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x32iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x32u(Vector128<uint> src, ref uint dst)
; location: [7FFDDBAD1100h, 7FFDDBAD110Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x32uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x64i(Vector128<long> src, ref long dst)
; location: [7FFDDBAD1120h, 7FFDDBAD112Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x64iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x64u(Vector128<ulong> src, ref ulong dst)
; location: [7FFDDBAD1140h, 7FFDDBAD114Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x64uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x32f(Vector128<float> src, ref float dst)
; location: [7FFDDBAD1160h, 7FFDDBAD116Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovups [rdx],xmm0            ; VMOVUPS(VEX_Vmovups_xmmm128_xmm) [mem(Packed128_Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f8 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x64f(Vector128<double> src, ref double dst)
; location: [7FFDDBAD1180h, 7FFDDBAD118Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x8u(Vector256<byte> src, ref byte dst)
; location: [7FFDDBAD11A0h, 7FFDDBAD11B0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x8uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x8i(Vector256<sbyte> src, ref sbyte dst)
; location: [7FFDDBAD11D0h, 7FFDDBAD11E0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x8iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x16i(Vector256<short> src, ref short dst)
; location: [7FFDDBAD1200h, 7FFDDBAD1210h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x16iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x16u(Vector256<ushort> src, ref ushort dst)
; location: [7FFDDBAD1230h, 7FFDDBAD1240h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x16uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x32i(Vector256<int> src, ref int dst)
; location: [7FFDDBAD1260h, 7FFDDBAD1270h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x32iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x32u(Vector256<uint> src, ref uint dst)
; location: [7FFDDBAD1690h, 7FFDDBAD16A0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x64i(Vector256<long> src, ref long dst)
; location: [7FFDDBAD16C0h, 7FFDDBAD16D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x64iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x64u(Vector256<ulong> src, ref ulong dst)
; location: [7FFDDBAD16F0h, 7FFDDBAD1700h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x64uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x32f(Vector256<float> src, ref float dst)
; location: [7FFDDBAD1720h, 7FFDDBAD1730h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovups [rdx],ymm0            ; VMOVUPS(VEX_Vmovups_ymmm256_ymm) [mem(Packed256_Float32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fc 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x64f(Vector256<double> src, ref double dst)
; location: [7FFDDBAD1750h, 7FFDDBAD1760h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
