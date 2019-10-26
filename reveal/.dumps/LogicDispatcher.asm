; 2019-10-25 21:50:51:885
; function: ILogicDispatcher get_Instance()
; location: [7FFDD9B48990h, 7FFDD9B489BCh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000bh mov byte ptr [rsp+20h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 20 00
0010h mov rcx,7FFDD93E68B0h         ; MOV(Mov_r64_imm64) [RCX,7ffdd93e68b0h:imm64]         encoding(10 bytes) = 48 b9 b0 68 3e d9 fd 7f 00 00
001ah call 7FFE38D844B0h            ; CALL(Call_rel32_64) [5F23BB20h:jmp64]                encoding(5 bytes) = e8 01 bb 23 5f
001fh movsx rdx,byte ptr [rsp+20h]  ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 54 24 20
0025h mov [rax+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(3 bytes) = 88 50 08
0028h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_InstanceBytes => new byte[45]{0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0xC6,0x44,0x24,0x20,0x00,0x48,0xB9,0xB0,0x68,0x3E,0xD9,0xFD,0x7F,0x00,0x00,0xE8,0x01,0xBB,0x23,0x5F,0x48,0x0F,0xBE,0x54,0x24,0x20,0x88,0x50,0x08,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit unhandled(ILogicExpr expr)
; location: [7FFDD9B489E0h, 7FFDD9B48A39h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0009h mov rcx,7FFDD9310390h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9310390h:imm64]         encoding(10 bytes) = 48 b9 90 03 31 d9 fd 7f 00 00
0013h call 7FFE38D844B0h            ; CALL(Call_rel32_64) [5F23BAD0h:jmp64]                encoding(5 bytes) = e8 b8 ba 23 5f
0018h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
001bh mov ecx,281h                  ; MOV(Mov_r32_imm32) [ECX,281h:imm32]                  encoding(5 bytes) = b9 81 02 00 00
0020h mov rdx,7FFDD93AFA58h         ; MOV(Mov_r64_imm64) [RDX,7ffdd93afa58h:imm64]         encoding(10 bytes) = 48 ba 58 fa 3a d9 fd 7f 00 00
002ah call 7FFE38EAF6E0h            ; CALL(Call_rel32_64) [5F366D00h:jmp64]                encoding(5 bytes) = e8 d1 6c 36 5f
002fh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0032h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0035h call 7FFDD9284130h            ; CALL(Call_rel32_64) [FFFFFFFFFF73B750h:jmp64]        encoding(5 bytes) = e8 16 b7 73 ff
003ah mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
003dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0040h call 7FFDD9284C88h            ; CALL(Call_rel32_64) [FFFFFFFFFF73C2A8h:jmp64]        encoding(5 bytes) = e8 63 c2 73 ff
0045h lea rcx,[rdi+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4f 10
0049h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
004ch call 7FFE38D835F0h            ; CALL(Call_rel32_64) [5F23AC10h:jmp64]                encoding(5 bytes) = e8 bf ab 23 5f
0051h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0054h call 7FFE38D3A4F0h            ; CALL(Call_rel32_64) [5F1F1B10h:jmp64]                encoding(5 bytes) = e8 b7 1a 1f 5f
0059h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unhandledBytes => new byte[90]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF2,0x48,0xB9,0x90,0x03,0x31,0xD9,0xFD,0x7F,0x00,0x00,0xE8,0xB8,0xBA,0x23,0x5F,0x48,0x8B,0xF8,0xB9,0x81,0x02,0x00,0x00,0x48,0xBA,0x58,0xFA,0x3A,0xD9,0xFD,0x7F,0x00,0x00,0xE8,0xD1,0x6C,0x36,0x5F,0x48,0x8B,0xC8,0x48,0x8B,0xD6,0xE8,0x16,0xB7,0x73,0xFF,0x48,0x8B,0xF0,0x48,0x8B,0xCF,0xE8,0x63,0xC2,0x73,0xFF,0x48,0x8D,0x4F,0x10,0x48,0x8B,0xD6,0xE8,0xBF,0xAB,0x23,0x5F,0x48,0x8B,0xCF,0xE8,0xB7,0x1A,0x1F,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IEqualityExpr expr)
; location: [7FFDD9B48A60h, 7FFDD9B48AD4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0010h mov r11,7FFDD9160E88h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160e88h:imm64]         encoding(10 bytes) = 49 bb 88 0e 16 d9 fd 7f 00 00
001ah cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001ch call qword ptr [7FFDD9160E88h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 06 84 61 ff
0022h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0025h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0028h call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F888h:jmp64]        encoding(5 bytes) = e8 5b f8 74 ff
002dh mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
002fh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0032h mov r11,7FFDD9160E90h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160e90h:imm64]         encoding(10 bytes) = 49 bb 90 0e 16 d9 fd 7f 00 00
003ch cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
003eh call qword ptr [7FFDD9160E90h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 ec 83 61 ff
0044h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0047h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ah call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F888h:jmp64]        encoding(5 bytes) = e8 39 f8 74 ff
004fh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0051h mov [rsp+28h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 28
0055h lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 28
005ah cmp ebx,eax                   ; CMP(Cmp_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 3b d8
005ch je short 0062h                ; JE(Je_rel8_64) [62h:jmp64]                           encoding(2 bytes) = 74 04
005eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0060h jmp short 0067h               ; JMP(Jmp_rel8_64) [67h:jmp64]                         encoding(2 bytes) = eb 05
0062h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0067h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0069h mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 28
006dh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0071h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0072h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0073h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0074h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> DispatchBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0x8B,0xCF,0x49,0xBB,0x88,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x06,0x84,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0xE8,0x5B,0xF8,0x74,0xFF,0x8B,0xD8,0x48,0x8B,0xCF,0x49,0xBB,0x90,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xEC,0x83,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0xE8,0x39,0xF8,0x74,0xFF,0x33,0xD2,0x89,0x54,0x24,0x28,0x48,0x8D,0x54,0x24,0x28,0x3B,0xD8,0x74,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ILogicVarExpr expr)
; location: [7FFDD9B48AF0h, 7FFDD9B48B22h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000bh mov r11,7FFDD9160E98h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160e98h:imm64]         encoding(10 bytes) = 49 bb 98 0e 16 d9 fd 7f 00 00
0015h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0017h call qword ptr [7FFDD9160E98h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 8b 83 61 ff
001dh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDD92982E8h         ; MOV(Mov_r64_imm64) [RAX,7ffdd92982e8h:imm64]         encoding(10 bytes) = 48 b8 e8 82 29 d9 fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCA,0x49,0xBB,0x98,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x8B,0x83,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0xB8,0xE8,0x82,0x29,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IVariedLogicExpr expr)
; location: [7FFDD9B48B40h, 7FFDD9B48B72h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000bh mov r11,7FFDD9160EA0h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ea0h:imm64]         encoding(10 bytes) = 49 bb a0 0e 16 d9 fd 7f 00 00
0015h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0017h call qword ptr [7FFDD9160EA0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 43 83 61 ff
001dh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDD92982E8h         ; MOV(Mov_r64_imm64) [RAX,7ffdd92982e8h:imm64]         encoding(10 bytes) = 48 b8 e8 82 29 d9 fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCA,0x49,0xBB,0xA0,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x43,0x83,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0xB8,0xE8,0x82,0x29,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ILogicLiteral expr)
; location: [7FFDD9B48B90h, 7FFDD9B48BABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFDD9160EA8h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ea8h:imm64]         encoding(10 bytes) = 49 bb a8 0e 16 d9 fd 7f 00 00
0012h mov rax,[7FFDD9160EA8h]       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RIP:br,DS:sr)]        encoding(7 bytes) = 48 8b 05 ff 82 61 ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0xA8,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x8B,0x05,0xFF,0x82,0x61,0xFF,0x39,0x09,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IUnaryLogicOp expr)
; location: [7FFDD9B48BC0h, 7FFDD9B48C19h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ah mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000dh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0010h mov r11,7FFDD9160EB0h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160eb0h:imm64]         encoding(10 bytes) = 49 bb b0 0e 16 d9 fd 7f 00 00
001ah cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001ch call qword ptr [7FFDD9160EB0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 ce 82 61 ff
0022h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0024h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0027h mov r11,7FFDD9160EB8h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160eb8h:imm64]         encoding(10 bytes) = 49 bb b8 0e 16 d9 fd 7f 00 00
0031h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0033h call qword ptr [7FFDD9160EB8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 bf 82 61 ff
0039h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003ch mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
003fh call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F728h:jmp64]        encoding(5 bytes) = e8 e4 f6 74 ff
0044h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0046h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
0048h mov rax,7FFDD9B468B0h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9b468b0h:imm64]         encoding(10 bytes) = 48 b8 b0 68 b4 d9 fd 7f 00 00
0052h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0056h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0057h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0058h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0059h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[92]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xB0,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xCE,0x82,0x61,0xFF,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xB8,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xBF,0x82,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0xE4,0xF6,0x74,0xFF,0x8B,0xD0,0x8B,0xCB,0x48,0xB8,0xB0,0x68,0xB4,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IBinaryLogicOp expr)
; location: [7FFDD9B48C40h, 7FFDD9B48CC0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0011h mov r11,7FFDD9160EC0h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ec0h:imm64]         encoding(10 bytes) = 49 bb c0 0e 16 d9 fd 7f 00 00
001bh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001dh call qword ptr [7FFDD9160EC0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 5d 82 61 ff
0023h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0025h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0028h mov r11,7FFDD9160EC8h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ec8h:imm64]         encoding(10 bytes) = 49 bb c8 0e 16 d9 fd 7f 00 00
0032h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0034h call qword ptr [7FFDD9160EC8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 4e 82 61 ff
003ah mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0040h call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F6A8h:jmp64]        encoding(5 bytes) = e8 63 f6 74 ff
0045h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
0047h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ah mov r11,7FFDD9160ED0h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ed0h:imm64]         encoding(10 bytes) = 49 bb d0 0e 16 d9 fd 7f 00 00
0054h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0056h call qword ptr [7FFDD9160ED0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 34 82 61 ff
005ch mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
005fh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0062h call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F6A8h:jmp64]        encoding(5 bytes) = e8 41 f6 74 ff
0067h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
006ah mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
006ch mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
006eh mov rax,7FFDD9B468B8h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9b468b8h:imm64]         encoding(10 bytes) = 48 b8 b8 68 b4 d9 fd 7f 00 00
0078h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
007ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
007eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0080h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[131]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xC0,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x5D,0x82,0x61,0xFF,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xC8,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x4E,0x82,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x63,0xF6,0x74,0xFF,0x8B,0xE8,0x48,0x8B,0xCE,0x49,0xBB,0xD0,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x34,0x82,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x41,0xF6,0x74,0xFF,0x44,0x8B,0xC0,0x8B,0xCB,0x8B,0xD5,0x48,0xB8,0xB8,0x68,0xB4,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ITernaryLogicOp expr)
; location: [7FFDD9B48CE0h, 7FFDD9B48D8Ah]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
000ah mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000dh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov r11,7FFDD9160ED8h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ed8h:imm64]         encoding(10 bytes) = 49 bb d8 0e 16 d9 fd 7f 00 00
001dh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001fh call qword ptr [7FFDD9160ED8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 d3 81 61 ff
0025h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0027h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
002ah mov r11,7FFDD9160EE0h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ee0h:imm64]         encoding(10 bytes) = 49 bb e0 0e 16 d9 fd 7f 00 00
0034h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0036h call qword ptr [7FFDD9160EE0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 c4 81 61 ff
003ch mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003fh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0042h call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F608h:jmp64]        encoding(5 bytes) = e8 c1 f5 74 ff
0047h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
0049h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ch mov r11,7FFDD9160EE8h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ee8h:imm64]         encoding(10 bytes) = 49 bb e8 0e 16 d9 fd 7f 00 00
0056h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0058h call qword ptr [7FFDD9160EE8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 aa 81 61 ff
005eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0061h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0064h call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F608h:jmp64]        encoding(5 bytes) = e8 9f f5 74 ff
0069h mov r14d,eax                  ; MOV(Mov_r32_rm32) [R14D,EAX]                         encoding(3 bytes) = 44 8b f0
006ch mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
006fh mov r11,7FFDD9160EF0h         ; MOV(Mov_r64_imm64) [R11,7ffdd9160ef0h:imm64]         encoding(10 bytes) = 49 bb f0 0e 16 d9 fd 7f 00 00
0079h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
007bh call qword ptr [7FFDD9160EF0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 8f 81 61 ff
0081h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0084h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0087h call 7FFDD92982E8h            ; CALL(Call_rel32_64) [FFFFFFFFFF74F608h:jmp64]        encoding(5 bytes) = e8 7c f5 74 ff
008ch mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
008fh mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
0091h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
0093h mov r8d,r14d                  ; MOV(Mov_r32_rm32) [R8D,R14D]                         encoding(3 bytes) = 45 8b c6
0096h mov rax,7FFDD9B468D0h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9b468d0h:imm64]         encoding(10 bytes) = 48 b8 d0 68 b4 d9 fd 7f 00 00
00a0h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
00a4h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a5h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00a6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a8h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00aah jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[173]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xD8,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xD3,0x81,0x61,0xFF,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xE0,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xC4,0x81,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0xC1,0xF5,0x74,0xFF,0x8B,0xE8,0x48,0x8B,0xCE,0x49,0xBB,0xE8,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xAA,0x81,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x9F,0xF5,0x74,0xFF,0x44,0x8B,0xF0,0x48,0x8B,0xCE,0x49,0xBB,0xF0,0x0E,0x16,0xD9,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x8F,0x81,0x61,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x7C,0xF5,0x74,0xFF,0x44,0x8B,0xC8,0x8B,0xCB,0x8B,0xD5,0x45,0x8B,0xC6,0x48,0xB8,0xD0,0x68,0xB4,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
