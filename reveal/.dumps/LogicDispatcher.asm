; 2019-10-24 05:24:43:908
; function: ILogicDispatcher get_Instance()
; location: [7FFDDBCD39E0h, 7FFDDBCD3A0Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000bh mov byte ptr [rsp+20h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 20 00
0010h mov rcx,7FFDDB5A6318h         ; MOV(Mov_r64_imm64) [RCX,7ffddb5a6318h:imm64]         encoding(10 bytes) = 48 b9 18 63 5a db fd 7f 00 00
001ah call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5F250AD0h:jmp64]                encoding(5 bytes) = e8 b1 0a 25 5f
001fh movsx rdx,byte ptr [rsp+20h]  ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 54 24 20
0025h mov [rax+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(3 bytes) = 88 50 08
0028h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_InstanceBytes => new byte[45]{0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0xC6,0x44,0x24,0x20,0x00,0x48,0xB9,0x18,0x63,0x5A,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0xB1,0x0A,0x25,0x5F,0x48,0x0F,0xBE,0x54,0x24,0x20,0x88,0x50,0x08,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit unhandled(ILogicExpr expr)
; location: [7FFDDBCD3A30h, 7FFDDBCD3A89h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0009h mov rcx,7FFDDB480390h         ; MOV(Mov_r64_imm64) [RCX,7ffddb480390h:imm64]         encoding(10 bytes) = 48 b9 90 03 48 db fd 7f 00 00
0013h call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5F250A80h:jmp64]                encoding(5 bytes) = e8 68 0a 25 5f
0018h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
001bh mov ecx,2B1h                  ; MOV(Mov_r32_imm32) [ECX,2b1h:imm32]                  encoding(5 bytes) = b9 b1 02 00 00
0020h mov rdx,7FFDDB55E788h         ; MOV(Mov_r64_imm64) [RDX,7ffddb55e788h:imm64]         encoding(10 bytes) = 48 ba 88 e7 55 db fd 7f 00 00
002ah call 7FFE3B04F6E0h            ; CALL(Call_rel32_64) [5F37BCB0h:jmp64]                encoding(5 bytes) = e8 81 bc 37 5f
002fh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0032h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0035h call 7FFDDB3F4130h            ; CALL(Call_rel32_64) [FFFFFFFFFF720700h:jmp64]        encoding(5 bytes) = e8 c6 06 72 ff
003ah mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
003dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0040h call 7FFDDB3F4C88h            ; CALL(Call_rel32_64) [FFFFFFFFFF721258h:jmp64]        encoding(5 bytes) = e8 13 12 72 ff
0045h lea rcx,[rdi+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4f 10
0049h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
004ch call 7FFE3AF235F0h            ; CALL(Call_rel32_64) [5F24FBC0h:jmp64]                encoding(5 bytes) = e8 6f fb 24 5f
0051h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0054h call 7FFE3AEDA4F0h            ; CALL(Call_rel32_64) [5F206AC0h:jmp64]                encoding(5 bytes) = e8 67 6a 20 5f
0059h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unhandledBytes => new byte[90]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF2,0x48,0xB9,0x90,0x03,0x48,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x68,0x0A,0x25,0x5F,0x48,0x8B,0xF8,0xB9,0xB1,0x02,0x00,0x00,0x48,0xBA,0x88,0xE7,0x55,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x81,0xBC,0x37,0x5F,0x48,0x8B,0xC8,0x48,0x8B,0xD6,0xE8,0xC6,0x06,0x72,0xFF,0x48,0x8B,0xF0,0x48,0x8B,0xCF,0xE8,0x13,0x12,0x72,0xFF,0x48,0x8D,0x4F,0x10,0x48,0x8B,0xD6,0xE8,0x6F,0xFB,0x24,0x5F,0x48,0x8B,0xCF,0xE8,0x67,0x6A,0x20,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IEqualityExpr expr)
; location: [7FFDDBCD3AB0h, 7FFDDBCD3B24h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0010h mov r11,7FFDDB2D0E88h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0e88h:imm64]         encoding(10 bytes) = 49 bb 88 0e 2d db fd 7f 00 00
001ah cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001ch call qword ptr [7FFDDB2D0E88h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 b6 d3 5f ff
0022h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0025h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0028h call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF738180h:jmp64]        encoding(5 bytes) = e8 53 81 73 ff
002dh mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
002fh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0032h mov r11,7FFDDB2D0E90h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0e90h:imm64]         encoding(10 bytes) = 49 bb 90 0e 2d db fd 7f 00 00
003ch cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
003eh call qword ptr [7FFDDB2D0E90h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 9c d3 5f ff
0044h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0047h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ah call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF738180h:jmp64]        encoding(5 bytes) = e8 31 81 73 ff
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
; static ReadOnlySpan<byte> DispatchBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0x8B,0xCF,0x49,0xBB,0x88,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xB6,0xD3,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0xE8,0x53,0x81,0x73,0xFF,0x8B,0xD8,0x48,0x8B,0xCF,0x49,0xBB,0x90,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x9C,0xD3,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0xE8,0x31,0x81,0x73,0xFF,0x33,0xD2,0x89,0x54,0x24,0x28,0x48,0x8D,0x54,0x24,0x28,0x3B,0xD8,0x74,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ILogicVarExpr expr)
; location: [7FFDDBCD3B40h, 7FFDDBCD3B72h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000bh mov r11,7FFDDB2D0E98h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0e98h:imm64]         encoding(10 bytes) = 49 bb 98 0e 2d db fd 7f 00 00
0015h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0017h call qword ptr [7FFDDB2D0E98h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 3b d3 5f ff
001dh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDDB40BC30h         ; MOV(Mov_r64_imm64) [RAX,7ffddb40bc30h:imm64]         encoding(10 bytes) = 48 b8 30 bc 40 db fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCA,0x49,0xBB,0x98,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x3B,0xD3,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0xB8,0x30,0xBC,0x40,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IVariedLogicExpr expr)
; location: [7FFDDBCD3B90h, 7FFDDBCD3BC2h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000bh mov r11,7FFDDB2D0EA0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ea0h:imm64]         encoding(10 bytes) = 49 bb a0 0e 2d db fd 7f 00 00
0015h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0017h call qword ptr [7FFDDB2D0EA0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 f3 d2 5f ff
001dh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDDB40BC30h         ; MOV(Mov_r64_imm64) [RAX,7ffddb40bc30h:imm64]         encoding(10 bytes) = 48 b8 30 bc 40 db fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCA,0x49,0xBB,0xA0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xF3,0xD2,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0xB8,0x30,0xBC,0x40,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ILogicLiteral expr)
; location: [7FFDDBCD3BE0h, 7FFDDBCD3BFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFDDB2D0EA8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ea8h:imm64]         encoding(10 bytes) = 49 bb a8 0e 2d db fd 7f 00 00
0012h mov rax,[7FFDDB2D0EA8h]       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RIP:br,DS:sr)]        encoding(7 bytes) = 48 8b 05 af d2 5f ff
0019h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0xA8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x8B,0x05,0xAF,0xD2,0x5F,0xFF,0x39,0x09,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IUnaryLogicOp expr)
; location: [7FFDDBCD3C10h, 7FFDDBCD3C82h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ah mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000dh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0010h mov r11,7FFDDB2D0EB0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0eb0h:imm64]         encoding(10 bytes) = 49 bb b0 0e 2d db fd 7f 00 00
001ah cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001ch call qword ptr [7FFDDB2D0EB0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 7e d2 5f ff
0022h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0024h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0027h mov r11,7FFDDB2D0EB8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0eb8h:imm64]         encoding(10 bytes) = 49 bb b8 0e 2d db fd 7f 00 00
0031h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0033h call qword ptr [7FFDDB2D0EB8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 6f d2 5f ff
0039h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003ch mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
003fh call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF738020h:jmp64]        encoding(5 bytes) = e8 dc 7f 73 ff
0044h cmp ebx,1                     ; CMP(Cmp_rm32_imm8) [EBX,1h:imm32]                    encoding(3 bytes) = 83 fb 01
0047h je short 0050h                ; JE(Je_rel8_64) [50h:jmp64]                           encoding(2 bytes) = 74 07
0049h cmp ebx,2                     ; CMP(Cmp_rm32_imm8) [EBX,2h:imm32]                    encoding(3 bytes) = 83 fb 02
004ch je short 0057h                ; JE(Je_rel8_64) [57h:jmp64]                           encoding(2 bytes) = 74 09
004eh jmp short 005fh               ; JMP(Jmp_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = eb 0f
0050h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0052h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0055h jmp short 0057h               ; JMP(Jmp_rel8_64) [57h:jmp64]                         encoding(2 bytes) = eb 00
0057h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
005bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
005ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005fh mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
0061h mov rax,7FFDDBCD3468h         ; MOV(Mov_r64_imm64) [RAX,7ffddbcd3468h:imm64]         encoding(10 bytes) = 48 b8 68 34 cd db fd 7f 00 00
006bh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
006fh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0070h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0071h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0072h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xB0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x7E,0xD2,0x5F,0xFF,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xB8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x6F,0xD2,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0xDC,0x7F,0x73,0xFF,0x83,0xFB,0x01,0x74,0x07,0x83,0xFB,0x02,0x74,0x09,0xEB,0x0F,0xF7,0xD0,0x83,0xE0,0x01,0xEB,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3,0x8B,0xCB,0x48,0xB8,0x68,0x34,0xCD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IBinaryLogicOp expr)
; location: [7FFDDBCD3CA0h, 7FFDDBCD3D20h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0011h mov r11,7FFDDB2D0EC0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ec0h:imm64]         encoding(10 bytes) = 49 bb c0 0e 2d db fd 7f 00 00
001bh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001dh call qword ptr [7FFDDB2D0EC0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 fd d1 5f ff
0023h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0025h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0028h mov r11,7FFDDB2D0EC8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ec8h:imm64]         encoding(10 bytes) = 49 bb c8 0e 2d db fd 7f 00 00
0032h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0034h call qword ptr [7FFDDB2D0EC8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 ee d1 5f ff
003ah mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0040h call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF737F90h:jmp64]        encoding(5 bytes) = e8 4b 7f 73 ff
0045h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
0047h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ah mov r11,7FFDDB2D0ED0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ed0h:imm64]         encoding(10 bytes) = 49 bb d0 0e 2d db fd 7f 00 00
0054h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0056h call qword ptr [7FFDDB2D0ED0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 d4 d1 5f ff
005ch mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
005fh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0062h call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF737F90h:jmp64]        encoding(5 bytes) = e8 29 7f 73 ff
0067h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
006ah mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
006ch mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
006eh mov rax,7FFDDBCD33B8h         ; MOV(Mov_r64_imm64) [RAX,7ffddbcd33b8h:imm64]         encoding(10 bytes) = 48 b8 b8 33 cd db fd 7f 00 00
0078h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
007ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
007eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0080h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[131]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xC0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xFD,0xD1,0x5F,0xFF,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xC8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xEE,0xD1,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x4B,0x7F,0x73,0xFF,0x8B,0xE8,0x48,0x8B,0xCE,0x49,0xBB,0xD0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0xD4,0xD1,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x29,0x7F,0x73,0xFF,0x44,0x8B,0xC0,0x8B,0xCB,0x8B,0xD5,0x48,0xB8,0xB8,0x33,0xCD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ITernaryLogicOp expr)
; location: [7FFDDBCD3D40h, 7FFDDBCD3DEAh]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
000ah mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000dh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov r11,7FFDDB2D0ED8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ed8h:imm64]         encoding(10 bytes) = 49 bb d8 0e 2d db fd 7f 00 00
001dh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
001fh call qword ptr [7FFDDB2D0ED8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 73 d1 5f ff
0025h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0027h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
002ah mov r11,7FFDDB2D0EE0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ee0h:imm64]         encoding(10 bytes) = 49 bb e0 0e 2d db fd 7f 00 00
0034h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0036h call qword ptr [7FFDDB2D0EE0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 64 d1 5f ff
003ch mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003fh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0042h call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF737EF0h:jmp64]        encoding(5 bytes) = e8 a9 7e 73 ff
0047h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
0049h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ch mov r11,7FFDDB2D0EE8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ee8h:imm64]         encoding(10 bytes) = 49 bb e8 0e 2d db fd 7f 00 00
0056h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0058h call qword ptr [7FFDDB2D0EE8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 4a d1 5f ff
005eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0061h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0064h call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF737EF0h:jmp64]        encoding(5 bytes) = e8 87 7e 73 ff
0069h mov r14d,eax                  ; MOV(Mov_r32_rm32) [R14D,EAX]                         encoding(3 bytes) = 44 8b f0
006ch mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
006fh mov r11,7FFDDB2D0EF0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ef0h:imm64]         encoding(10 bytes) = 49 bb f0 0e 2d db fd 7f 00 00
0079h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
007bh call qword ptr [7FFDDB2D0EF0h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 2f d1 5f ff
0081h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0084h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0087h call 7FFDDB40BC30h            ; CALL(Call_rel32_64) [FFFFFFFFFF737EF0h:jmp64]        encoding(5 bytes) = e8 64 7e 73 ff
008ch mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
008fh mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
0091h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
0093h mov r8d,r14d                  ; MOV(Mov_r32_rm32) [R8D,R14D]                         encoding(3 bytes) = 45 8b c6
0096h mov rax,7FFDDBCD33D0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbcd33d0h:imm64]         encoding(10 bytes) = 48 b8 d0 33 cd db fd 7f 00 00
00a0h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
00a4h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a5h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00a6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a8h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00aah jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[173]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xD8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x73,0xD1,0x5F,0xFF,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xE0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x64,0xD1,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0xA9,0x7E,0x73,0xFF,0x8B,0xE8,0x48,0x8B,0xCE,0x49,0xBB,0xE8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x4A,0xD1,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x87,0x7E,0x73,0xFF,0x44,0x8B,0xF0,0x48,0x8B,0xCE,0x49,0xBB,0xF0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x15,0x2F,0xD1,0x5F,0xFF,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x64,0x7E,0x73,0xFF,0x44,0x8B,0xC8,0x8B,0xCB,0x8B,0xD5,0x45,0x8B,0xC6,0x48,0xB8,0xD0,0x33,0xCD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
