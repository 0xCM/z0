; 2019-10-27 16:51:34:574
; function: ILogicDispatcher get_Instance()
; location: [7FFDDBADE940h, 7FFDDBADE96Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000bh mov byte ptr [rsp+20h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 20 00
0010h mov rcx,7FFDDB5555B8h         ; MOV(Mov_r64_imm64) [RCX,7ffddb5555b8h:imm64]         encoding(10 bytes) = 48 b9 b8 55 55 db fd 7f 00 00
001ah call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5F445B70h:jmp64]                encoding(5 bytes) = e8 51 5b 44 5f
001fh movsx rdx,byte ptr [rsp+20h]  ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 54 24 20
0025h mov [rax+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(3 bytes) = 88 50 08
0028h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_InstanceBytes => new byte[45]{0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0xC6,0x44,0x24,0x20,0x00,0x48,0xB9,0xB8,0x55,0x55,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x51,0x5B,0x44,0x5F,0x48,0x0F,0xBE,0x54,0x24,0x20,0x88,0x50,0x08,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit unhandled(ILogicExpr expr)
; location: [7FFDDBADE990h, 7FFDDBADE9E9h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0009h mov rcx,7FFDDB480390h         ; MOV(Mov_r64_imm64) [RCX,7ffddb480390h:imm64]         encoding(10 bytes) = 48 b9 90 03 48 db fd 7f 00 00
0013h call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5F445B20h:jmp64]                encoding(5 bytes) = e8 08 5b 44 5f
0018h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
001bh mov ecx,281h                  ; MOV(Mov_r32_imm32) [ECX,281h:imm32]                  encoding(5 bytes) = b9 81 02 00 00
0020h mov rdx,7FFDDB51F238h         ; MOV(Mov_r64_imm64) [RDX,7ffddb51f238h:imm64]         encoding(10 bytes) = 48 ba 38 f2 51 db fd 7f 00 00
002ah call 7FFE3B04F6E0h            ; CALL(Call_rel32_64) [5F570D50h:jmp64]                encoding(5 bytes) = e8 21 0d 57 5f
002fh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0032h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0035h call 7FFDDB3F4130h            ; CALL(Call_rel32_64) [FFFFFFFFFF9157A0h:jmp64]        encoding(5 bytes) = e8 66 57 91 ff
003ah mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
003dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0040h call 7FFDDB3F4C88h            ; CALL(Call_rel32_64) [FFFFFFFFFF9162F8h:jmp64]        encoding(5 bytes) = e8 b3 62 91 ff
0045h lea rcx,[rdi+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4f 10
0049h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
004ch call 7FFE3AF235F0h            ; CALL(Call_rel32_64) [5F444C60h:jmp64]                encoding(5 bytes) = e8 0f 4c 44 5f
0051h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0054h call 7FFE3AEDA4F0h            ; CALL(Call_rel32_64) [5F3FBB60h:jmp64]                encoding(5 bytes) = e8 07 bb 3f 5f
0059h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unhandledBytes => new byte[90]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF2,0x48,0xB9,0x90,0x03,0x48,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x08,0x5B,0x44,0x5F,0x48,0x8B,0xF8,0xB9,0x81,0x02,0x00,0x00,0x48,0xBA,0x38,0xF2,0x51,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x21,0x0D,0x57,0x5F,0x48,0x8B,0xC8,0x48,0x8B,0xD6,0xE8,0x66,0x57,0x91,0xFF,0x48,0x8B,0xF0,0x48,0x8B,0xCF,0xE8,0xB3,0x62,0x91,0xFF,0x48,0x8D,0x4F,0x10,0x48,0x8B,0xD6,0xE8,0x0F,0x4C,0x44,0x5F,0x48,0x8B,0xCF,0xE8,0x07,0xBB,0x3F,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IEqualityExpr expr)
; location: [7FFDDBADEA10h, 7FFDDBADEA90h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0010h mov r11,7FFDDB2D0E90h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0e90h:imm64]         encoding(10 bytes) = 49 bb 90 0e 2d db fd 7f 00 00
001ah mov rax,7FFDDB2D0E90h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0e90h:imm64]         encoding(10 bytes) = 48 b8 90 0e 2d db fd 7f 00 00
0024h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0026h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0028h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
002bh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
002eh call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A9C0h:jmp64]        encoding(5 bytes) = e8 8d a9 92 ff
0033h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
0035h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0038h mov r11,7FFDDB2D0E98h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0e98h:imm64]         encoding(10 bytes) = 49 bb 98 0e 2d db fd 7f 00 00
0042h mov rax,7FFDDB2D0E98h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0e98h:imm64]         encoding(10 bytes) = 48 b8 98 0e 2d db fd 7f 00 00
004ch cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
004eh call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0050h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0053h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0056h call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A9C0h:jmp64]        encoding(5 bytes) = e8 65 a9 92 ff
005bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
005dh mov [rsp+28h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 28
0061h lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 28
0066h cmp ebx,eax                   ; CMP(Cmp_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 3b d8
0068h je short 006eh                ; JE(Je_rel8_64) [6Eh:jmp64]                           encoding(2 bytes) = 74 04
006ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
006ch jmp short 0073h               ; JMP(Jmp_rel8_64) [73h:jmp64]                         encoding(2 bytes) = eb 05
006eh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0073h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0075h mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 28
0079h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
007dh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0080h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> DispatchBytes => new byte[129]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0x8B,0xCF,0x49,0xBB,0x90,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0x90,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0xE8,0x8D,0xA9,0x92,0xFF,0x8B,0xD8,0x48,0x8B,0xCF,0x49,0xBB,0x98,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0x98,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0xE8,0x65,0xA9,0x92,0xFF,0x33,0xD2,0x89,0x54,0x24,0x28,0x48,0x8D,0x54,0x24,0x28,0x3B,0xD8,0x74,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ILogicVarExpr expr)
; location: [7FFDDBADEAB0h, 7FFDDBADEAE8h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000bh mov r11,7FFDDB2D0EA0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ea0h:imm64]         encoding(10 bytes) = 49 bb a0 0e 2d db fd 7f 00 00
0015h mov rax,7FFDDB2D0EA0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ea0h:imm64]         encoding(10 bytes) = 48 b8 a0 0e 2d db fd 7f 00 00
001fh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0021h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0023h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0026h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0029h mov rax,7FFDDB4093D0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb4093d0h:imm64]         encoding(10 bytes) = 48 b8 d0 93 40 db fd 7f 00 00
0033h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0037h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0038h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[59]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCA,0x49,0xBB,0xA0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xA0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0xB8,0xD0,0x93,0x40,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IVariedLogicExpr expr)
; location: [7FFDDBADEB00h, 7FFDDBADEB38h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000bh mov r11,7FFDDB2D0EA8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ea8h:imm64]         encoding(10 bytes) = 49 bb a8 0e 2d db fd 7f 00 00
0015h mov rax,7FFDDB2D0EA8h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ea8h:imm64]         encoding(10 bytes) = 48 b8 a8 0e 2d db fd 7f 00 00
001fh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0021h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0023h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0026h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0029h mov rax,7FFDDB4093D0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb4093d0h:imm64]         encoding(10 bytes) = 48 b8 d0 93 40 db fd 7f 00 00
0033h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0037h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0038h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[59]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCA,0x49,0xBB,0xA8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xA8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0xB8,0xD0,0x93,0x40,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ILogicLiteral expr)
; location: [7FFDDBADEB50h, 7FFDDBADEB71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov r11,7FFDDB2D0EB0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0eb0h:imm64]         encoding(10 bytes) = 49 bb b0 0e 2d db fd 7f 00 00
0012h mov rax,7FFDDB2D0EB0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0eb0h:imm64]         encoding(10 bytes) = 48 b8 b0 0e 2d db fd 7f 00 00
001ch mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
001fh cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0021h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x49,0xBB,0xB0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xB0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x8B,0x00,0x39,0x09,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IUnaryLogicOp expr)
; location: [7FFDDBADEB90h, 7FFDDBADEBF5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ah mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000dh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0010h mov r11,7FFDDB2D0EB8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0eb8h:imm64]         encoding(10 bytes) = 49 bb b8 0e 2d db fd 7f 00 00
001ah mov rax,7FFDDB2D0EB8h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0eb8h:imm64]         encoding(10 bytes) = 48 b8 b8 0e 2d db fd 7f 00 00
0024h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0026h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0028h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
002ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
002dh mov r11,7FFDDB2D0EC0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ec0h:imm64]         encoding(10 bytes) = 49 bb c0 0e 2d db fd 7f 00 00
0037h mov rax,7FFDDB2D0EC0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ec0h:imm64]         encoding(10 bytes) = 48 b8 c0 0e 2d db fd 7f 00 00
0041h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0043h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0045h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0048h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
004bh call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A840h:jmp64]        encoding(5 bytes) = e8 f0 a7 92 ff
0050h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0052h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
0054h mov rax,7FFDDBADE328h         ; MOV(Mov_r64_imm64) [RAX,7ffddbade328h:imm64]         encoding(10 bytes) = 48 b8 28 e3 ad db fd 7f 00 00
005eh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0064h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0065h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[104]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xB8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xB8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xC0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xC0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0xF0,0xA7,0x92,0xFF,0x8B,0xD0,0x8B,0xCB,0x48,0xB8,0x28,0xE3,0xAD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(IBinaryLogicOp expr)
; location: [7FFDDBADEC10h, 7FFDDBADECA2h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0011h mov r11,7FFDDB2D0EC8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ec8h:imm64]         encoding(10 bytes) = 49 bb c8 0e 2d db fd 7f 00 00
001bh mov rax,7FFDDB2D0EC8h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ec8h:imm64]         encoding(10 bytes) = 48 b8 c8 0e 2d db fd 7f 00 00
0025h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0027h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0029h mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
002bh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
002eh mov r11,7FFDDB2D0ED0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ed0h:imm64]         encoding(10 bytes) = 49 bb d0 0e 2d db fd 7f 00 00
0038h mov rax,7FFDDB2D0ED0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ed0h:imm64]         encoding(10 bytes) = 48 b8 d0 0e 2d db fd 7f 00 00
0042h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0044h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0046h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0049h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
004ch call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A7C0h:jmp64]        encoding(5 bytes) = e8 6f a7 92 ff
0051h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
0053h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0056h mov r11,7FFDDB2D0ED8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ed8h:imm64]         encoding(10 bytes) = 49 bb d8 0e 2d db fd 7f 00 00
0060h mov rax,7FFDDB2D0ED8h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ed8h:imm64]         encoding(10 bytes) = 48 b8 d8 0e 2d db fd 7f 00 00
006ah cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
006ch call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
006eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0071h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0074h call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A7C0h:jmp64]        encoding(5 bytes) = e8 47 a7 92 ff
0079h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
007ch mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
007eh mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
0080h mov rax,7FFDDBADE330h         ; MOV(Mov_r64_imm64) [RAX,7ffddbade330h:imm64]         encoding(10 bytes) = 48 b8 30 e3 ad db fd 7f 00 00
008ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
008eh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
008fh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0090h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0091h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0092h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[149]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xC8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xC8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xD0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xD0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x6F,0xA7,0x92,0xFF,0x8B,0xE8,0x48,0x8B,0xCE,0x49,0xBB,0xD8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xD8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x47,0xA7,0x92,0xFF,0x44,0x8B,0xC0,0x8B,0xCB,0x8B,0xD5,0x48,0xB8,0x30,0xE3,0xAD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit Dispatch(ITernaryLogicOp expr)
; location: [7FFDDBADECD0h, 7FFDDBADED92h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
000ah mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000dh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov r11,7FFDDB2D0EE0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ee0h:imm64]         encoding(10 bytes) = 49 bb e0 0e 2d db fd 7f 00 00
001dh mov rax,7FFDDB2D0EE0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ee0h:imm64]         encoding(10 bytes) = 48 b8 e0 0e 2d db fd 7f 00 00
0027h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0029h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
002bh mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
002dh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0030h mov r11,7FFDDB2D0EE8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ee8h:imm64]         encoding(10 bytes) = 49 bb e8 0e 2d db fd 7f 00 00
003ah mov rax,7FFDDB2D0EE8h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ee8h:imm64]         encoding(10 bytes) = 48 b8 e8 0e 2d db fd 7f 00 00
0044h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0046h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0048h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
004bh mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
004eh call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A700h:jmp64]        encoding(5 bytes) = e8 ad a6 92 ff
0053h mov ebp,eax                   ; MOV(Mov_r32_rm32) [EBP,EAX]                          encoding(2 bytes) = 8b e8
0055h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0058h mov r11,7FFDDB2D0EF0h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ef0h:imm64]         encoding(10 bytes) = 49 bb f0 0e 2d db fd 7f 00 00
0062h mov rax,7FFDDB2D0EF0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ef0h:imm64]         encoding(10 bytes) = 48 b8 f0 0e 2d db fd 7f 00 00
006ch cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
006eh call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0070h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0073h mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
0076h call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A700h:jmp64]        encoding(5 bytes) = e8 85 a6 92 ff
007bh mov r14d,eax                  ; MOV(Mov_r32_rm32) [R14D,EAX]                         encoding(3 bytes) = 44 8b f0
007eh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0081h mov r11,7FFDDB2D0EF8h         ; MOV(Mov_r64_imm64) [R11,7ffddb2d0ef8h:imm64]         encoding(10 bytes) = 49 bb f8 0e 2d db fd 7f 00 00
008bh mov rax,7FFDDB2D0EF8h         ; MOV(Mov_r64_imm64) [RAX,7ffddb2d0ef8h:imm64]         encoding(10 bytes) = 48 b8 f8 0e 2d db fd 7f 00 00
0095h cmp [rcx],ecx                 ; CMP(Cmp_rm32_r32) [mem(32u,RCX:br,DS:sr),ECX]        encoding(2 bytes) = 39 09
0097h call qword ptr [rax]          ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,DS:sr)]      encoding(2 bytes) = ff 10
0099h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
009ch mov rcx,rdi                   ; MOV(Mov_r64_rm64) [RCX,RDI]                          encoding(3 bytes) = 48 8b cf
009fh call 7FFDDB4093D0h            ; CALL(Call_rel32_64) [FFFFFFFFFF92A700h:jmp64]        encoding(5 bytes) = e8 5c a6 92 ff
00a4h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
00a7h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00a9h mov edx,ebp                   ; MOV(Mov_r32_rm32) [EDX,EBP]                          encoding(2 bytes) = 8b d5
00abh mov r8d,r14d                  ; MOV(Mov_r32_rm32) [R8D,R14D]                         encoding(3 bytes) = 45 8b c6
00aeh mov rax,7FFDDBADE348h         ; MOV(Mov_r64_imm64) [RAX,7ffddbade348h:imm64]         encoding(10 bytes) = 48 b8 48 e3 ad db fd 7f 00 00
00b8h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
00bch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00bdh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00beh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00bfh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c0h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00c2h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> DispatchBytes => new byte[197]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0x8B,0xCE,0x49,0xBB,0xE0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xE0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x8B,0xD8,0x48,0x8B,0xCE,0x49,0xBB,0xE8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xE8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0xAD,0xA6,0x92,0xFF,0x8B,0xE8,0x48,0x8B,0xCE,0x49,0xBB,0xF0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xF0,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x85,0xA6,0x92,0xFF,0x44,0x8B,0xF0,0x48,0x8B,0xCE,0x49,0xBB,0xF8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xB8,0xF8,0x0E,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x39,0x09,0xFF,0x10,0x48,0x8B,0xD0,0x48,0x8B,0xCF,0xE8,0x5C,0xA6,0x92,0xFF,0x44,0x8B,0xC8,0x8B,0xCB,0x8B,0xD5,0x45,0x8B,0xC6,0x48,0xB8,0x48,0xE3,0xAD,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
