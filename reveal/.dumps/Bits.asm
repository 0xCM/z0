; 2019-11-25 21:05:22:341
; function: ulong pack(in uint x0, in uint x1)
; location: [7FFDDB045220h, 7FFDDB045230h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 12
0009h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
000dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(byte x0, byte x1, byte x2, byte x3)
; location: [7FFDDB045250h, 7FFDDB045272h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
0017h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0019h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
001dh shl edx,18h                   ; SHL(Shl_rm32_imm8) [EDX,18h:imm8]                    encoding(3 bytes) = c1 e2 18
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x10,0x0B,0xC2,0x41,0x0F,0xB6,0xD1,0xC1,0xE2,0x18,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
; location: [7FFDDB045290h, 7FFDDB0452AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h movzx edx,r9w                 ; MOVZX(Movzx_r32_rm16) [EDX,R9W]                      encoding(4 bytes) = 41 0f b7 d1
001ah shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
001dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0x41,0x0F,0xB7,0xD0,0x0B,0xC2,0x41,0x0F,0xB7,0xD1,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
; location: [7FFDDB0452C0h, 7FFDDB045320h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
000fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0012h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0016h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0021h shl rdx,18h                   ; SHL(Shl_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 e2 18
0025h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0028h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 28
002ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002fh shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
0033h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0036h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 30
003ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003dh shl rdx,28h                   ; SHL(Shl_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 e2 28
0041h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0044h mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 38
0048h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004bh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
004fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0052h mov edx,[rsp+40h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 40
0056h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0059h shl rdx,38h                   ; SHL(Shl_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 e2 38
005dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[97]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x41,0x0F,0xB6,0xD0,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x41,0x0F,0xB6,0xD1,0x48,0xC1,0xE2,0x18,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x28,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x40,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x38,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
; location: [7FFDDB045340h, 7FFDDB04539Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,:sr)]          encoding(4 bytes) = 44 8b 41 08
000ch mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 02 00
000fh cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
0013h jg short 001ah                ; JG(Jg_rel8_64) [1Ah:jmp64]                           encoding(2 bytes) = 7f 05
0015h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0018h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 06
001ah mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0020h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0023h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0026h jle short 0050h               ; JLE(Jle_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 7e 28
0028h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002bh jae short 0058h               ; JAE(Jae_rel8_64) [58h:jmp64]                         encoding(2 bytes) = 73 2b
002dh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0030h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(4 bytes) = 80 3c 08 01
0034h jne short 0048h               ; JNE(Jne_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 75 12
0036h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0042h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0046h or [rdx],cl                   ; OR(Or_rm8_r8) [mem(8u,RDX:br,:sr),CL]                encoding(2 bytes) = 08 0a
0048h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004bh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004eh jl short 0028h                ; JL(Jl_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7c d8
0050h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0053h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0058h call 7FFE3A54EF00h            ; CALL(Call_rel32_64) [5F509BC0h:jmp64]                encoding(5 bytes) = e8 63 9b 50 5f
005dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[94]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0xC6,0x02,0x00,0x41,0x83,0xF8,0x08,0x7F,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x28,0x45,0x3B,0xD0,0x73,0x2B,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD8,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x63,0x9B,0x50,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
; location: [7FFDDB0453C0h, 7FFDDB045420h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,:sr)]          encoding(4 bytes) = 44 8b 41 08
000ch mov word ptr [rdx],0          ; MOV(Mov_rm16_imm16) [mem(16u,RDX:br,:sr),0h:imm16]   encoding(5 bytes) = 66 c7 02 00 00
0011h cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
0015h jg short 001ch                ; JG(Jg_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7f 05
0017h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ah jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 06
001ch mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
0022h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0025h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0028h jle short 0053h               ; JLE(Jle_rel8_64) [53h:jmp64]                         encoding(2 bytes) = 7e 29
002ah cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002dh jae short 005bh               ; JAE(Jae_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 73 2c
002fh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0032h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(4 bytes) = 80 3c 08 01
0036h jne short 004bh               ; JNE(Jne_rel8_64) [4Bh:jmp64]                         encoding(2 bytes) = 75 13
0038h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003eh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0041h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0044h movzx ecx,r11w                ; MOVZX(Movzx_r32_rm16) [ECX,R11W]                     encoding(4 bytes) = 41 0f b7 cb
0048h or [rdx],cx                   ; OR(Or_rm16_r16) [mem(16u,RDX:br,:sr),CX]             encoding(3 bytes) = 66 09 0a
004bh inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004eh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
0051h jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c d7
0053h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0056h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005bh call 7FFE3A54EF00h            ; CALL(Call_rel32_64) [5F509B40h:jmp64]                encoding(5 bytes) = e8 e0 9a 50 5f
0060h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[97]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x66,0xC7,0x02,0x00,0x00,0x41,0x83,0xF8,0x10,0x7F,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x10,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x2C,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x13,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB7,0xCB,0x66,0x09,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE0,0x9A,0x50,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
; location: [7FFDDB045440h, 7FFDDB04549Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,:sr)]          encoding(4 bytes) = 44 8b 41 08
000ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000eh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),ECX]          encoding(2 bytes) = 89 0a
0010h cmp r8d,20h                   ; CMP(Cmp_rm32_imm8) [R8D,20h:imm32]                   encoding(4 bytes) = 41 83 f8 20
0014h jg short 001bh                ; JG(Jg_rel8_64) [1Bh:jmp64]                           encoding(2 bytes) = 7f 05
0016h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0019h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 06
001bh mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0021h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0024h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0027h jle short 004eh               ; JLE(Jle_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 7e 25
0029h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002ch jae short 0056h               ; JAE(Jae_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 73 28
002eh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0031h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(4 bytes) = 80 3c 08 01
0035h jne short 0046h               ; JNE(Jne_rel8_64) [46h:jmp64]                         encoding(2 bytes) = 75 0f
0037h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003dh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0040h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0043h or [rdx],r11d                 ; OR(Or_rm32_r32) [mem(32u,RDX:br,:sr),R11D]           encoding(3 bytes) = 44 09 1a
0046h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0049h cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004ch jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c db
004eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0051h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0056h call 7FFE3A54EF00h            ; CALL(Call_rel32_64) [5F509AC0h:jmp64]                encoding(5 bytes) = e8 65 9a 50 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x89,0x0A,0x41,0x83,0xF8,0x20,0x7F,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x44,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x65,0x9A,0x50,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
; location: [7FFDDB0454B0h, 7FFDDB04550Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,:sr)]          encoding(4 bytes) = 44 8b 41 08
000ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000eh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0011h cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0015h jg short 001ch                ; JG(Jg_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7f 05
0017h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ah jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 06
001ch mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
0022h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0025h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0028h jle short 004fh               ; JLE(Jle_rel8_64) [4Fh:jmp64]                         encoding(2 bytes) = 7e 25
002ah cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002dh jae short 0057h               ; JAE(Jae_rel8_64) [57h:jmp64]                         encoding(2 bytes) = 73 28
002fh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0032h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(4 bytes) = 80 3c 08 01
0036h jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 0f
0038h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003eh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0041h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0044h or [rdx],r11                  ; OR(Or_rm64_r64) [mem(64u,RDX:br,:sr),R11]            encoding(3 bytes) = 4c 09 1a
0047h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ah cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004dh jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c db
004fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0052h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0057h call 7FFE3A54EF00h            ; CALL(Call_rel32_64) [5F509A50h:jmp64]                encoding(5 bytes) = e8 f4 99 50 5f
005ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[93]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x48,0x89,0x0A,0x41,0x83,0xF8,0x40,0x7F,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x4C,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF4,0x99,0x50,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(sbyte src)
; location: [7FFDDB045530h, 7FFDDB04553Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(byte src)
; location: [7FFDDB045550h, 7FFDDB04555Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(short src)
; location: [7FFDDB045570h, 7FFDDB04557Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ushort src)
; location: [7FFDDB045590h, 7FFDDB04559Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(int src)
; location: [7FFDDB0455B0h, 7FFDDB0455BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(uint src)
; location: [7FFDDB0455D0h, 7FFDDB0455DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(long src)
; location: [7FFDDB0455F0h, 7FFDDB0455FCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong src)
; location: [7FFDDB045610h, 7FFDDB04561Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1)
; location: [7FFDDB045630h, 7FFDDB045643h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x, ulong y, ulong z)
; location: [7FFDDB045660h, 7FFDDB04571Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000eh and r9,r8                     ; AND(And_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 23 c8
0011h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0014h or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
0017h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
001ah mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
001dh shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0020h mov r8,5555555555555555h      ; MOV(Mov_r64_imm64) [R8,5555555555555555h:imm64]      encoding(10 bytes) = 49 b8 55 55 55 55 55 55 55 55
002ah and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
002dh sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
0030h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0033h shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0036h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0039h sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
003ch mov rcx,3333333333333333h     ; MOV(Mov_r64_imm64) [RCX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b9 33 33 33 33 33 33 33 33
0046h and rcx,rdx                   ; AND(And_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 23 ca
0049h shr rdx,2                     ; SHR(Shr_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 ea 02
004dh mov r8,3333333333333333h      ; MOV(Mov_r64_imm64) [R8,3333333333333333h:imm64]      encoding(10 bytes) = 49 b8 33 33 33 33 33 33 33 33
0057h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
005ah add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
005dh and r8,rax                    ; AND(And_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 23 c0
0060h shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0064h mov rcx,3333333333333333h     ; MOV(Mov_r64_imm64) [RCX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b9 33 33 33 33 33 33 33 33
006eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0071h add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
0074h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0077h shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
007bh add rcx,rdx                   ; ADD(Add_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 03 ca
007eh mov rdx,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RDX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 ba 0f 0f 0f 0f 0f 0f 0f 0f
0088h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
008bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
008eh shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
0092h add rcx,rax                   ; ADD(Add_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 03 c8
0095h mov rax,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RAX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 b8 0f 0f 0f 0f 0f 0f 0f 0f
009fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
00a2h add rdx,rdx                   ; ADD(Add_r64_rm64) [RDX,RDX]                          encoding(3 bytes) = 48 03 d2
00a5h add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
00a8h mov rax,101010101010101h      ; MOV(Mov_r64_imm64) [RAX,101010101010101h:imm64]      encoding(10 bytes) = 48 b8 01 01 01 01 01 01 01 01
00b2h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
00b6h shr rax,38h                   ; SHR(Shr_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e8 38
00bah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[187]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0x4C,0x8B,0xC8,0x4D,0x23,0xC8,0x48,0x23,0xD1,0x49,0x0B,0xD1,0x49,0x33,0xC0,0x48,0x8B,0xCA,0x48,0xD1,0xE9,0x49,0xB8,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x49,0x23,0xC8,0x48,0x2B,0xD1,0x48,0x8B,0xC8,0x48,0xD1,0xE9,0x49,0x23,0xC8,0x48,0x2B,0xC1,0x48,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x23,0xCA,0x48,0xC1,0xEA,0x02,0x49,0xB8,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x49,0x23,0xD0,0x48,0x03,0xD1,0x4C,0x23,0xC0,0x48,0xC1,0xE8,0x02,0x48,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x23,0xC1,0x49,0x03,0xC0,0x48,0x8B,0xCA,0x48,0xC1,0xE9,0x04,0x48,0x03,0xCA,0x48,0xBA,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x23,0xD1,0x48,0x8B,0xC8,0x48,0xC1,0xE9,0x04,0x48,0x03,0xC8,0x48,0xB8,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x23,0xC1,0x48,0x03,0xD2,0x48,0x03,0xD0,0x48,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1, ulong x2, ulong x3)
; location: [7FFDDB045730h, 7FFDDB045755h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001ah add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
001ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001eh popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0023h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
; location: [7FFDDB045770h, 7FFDDB0457C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001ah add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
001ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001eh popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0023h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0025h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0027h popcnt rdx,[rsp+28h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]    encoding(7 bytes) = f3 48 0f b8 54 24 28
002eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0030h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0032h popcnt rdx,[rsp+30h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]    encoding(7 bytes) = f3 48 0f b8 54 24 30
0039h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
003bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
003dh popcnt rdx,[rsp+38h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]    encoding(7 bytes) = f3 48 0f b8 54 24 38
0044h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0046h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0048h popcnt rdx,[rsp+40h]          ; POPCNT(Popcnt_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]    encoding(7 bytes) = f3 48 0f b8 54 24 40
004fh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[82]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x28,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x30,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x38,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0x54,0x24,0x40,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5)
; location: [7FFDDB0457E0h, 7FFDDB045960h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 30
000ah mov r10,[rsp+38h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 4c 8b 54 24 38
000fh mov r11,rcx                   ; MOV(Mov_r64_rm64) [R11,RCX]                          encoding(3 bytes) = 4c 8b d9
0012h xor r11,rdx                   ; XOR(Xor_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 33 da
0015h mov rsi,r11                   ; MOV(Mov_r64_rm64) [RSI,R11]                          encoding(3 bytes) = 49 8b f3
0018h and rsi,r8                    ; AND(And_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 23 f0
001bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001eh or rdx,rsi                    ; OR(Or_r64_rm64) [RDX,RSI]                            encoding(3 bytes) = 48 0b d6
0021h xor r8,r11                    ; XOR(Xor_r64_rm64) [R8,R11]                           encoding(3 bytes) = 4d 33 c3
0024h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0027h shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
002ah mov r11,5555555555555555h     ; MOV(Mov_r64_imm64) [R11,5555555555555555h:imm64]     encoding(10 bytes) = 49 bb 55 55 55 55 55 55 55 55
0034h and rcx,r11                   ; AND(And_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 23 cb
0037h sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
003ah mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
003dh shr rcx,1                     ; SHR(Shr_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e9
0040h and rcx,r11                   ; AND(And_r64_rm64) [RCX,R11]                          encoding(3 bytes) = 49 23 cb
0043h sub r8,rcx                    ; SUB(Sub_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 2b c1
0046h mov rcx,3333333333333333h     ; MOV(Mov_r64_imm64) [RCX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b9 33 33 33 33 33 33 33 33
0050h and rcx,rdx                   ; AND(And_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 23 ca
0053h shr rdx,2                     ; SHR(Shr_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 ea 02
0057h mov r11,3333333333333333h     ; MOV(Mov_r64_imm64) [R11,3333333333333333h:imm64]     encoding(10 bytes) = 49 bb 33 33 33 33 33 33 33 33
0061h and rdx,r11                   ; AND(And_r64_rm64) [RDX,R11]                          encoding(3 bytes) = 49 23 d3
0064h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0067h and r11,r8                    ; AND(And_r64_rm64) [R11,R8]                           encoding(3 bytes) = 4d 23 d8
006ah shr r8,2                      ; SHR(Shr_rm64_imm8) [R8,2h:imm8]                      encoding(4 bytes) = 49 c1 e8 02
006eh mov rcx,3333333333333333h     ; MOV(Mov_r64_imm64) [RCX,3333333333333333h:imm64]     encoding(10 bytes) = 48 b9 33 33 33 33 33 33 33 33
0078h and r8,rcx                    ; AND(And_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 23 c1
007bh add r8,r11                    ; ADD(Add_r64_rm64) [R8,R11]                           encoding(3 bytes) = 4d 03 c3
007eh mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0081h shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
0085h add rcx,rdx                   ; ADD(Add_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 03 ca
0088h mov rdx,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RDX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 ba 0f 0f 0f 0f 0f 0f 0f 0f
0092h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0095h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0098h shr rcx,4                     ; SHR(Shr_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e9 04
009ch add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
009fh mov r8,0F0F0F0F0F0F0F0Fh      ; MOV(Mov_r64_imm64) [R8,f0f0f0f0f0f0f0fh:imm64]       encoding(10 bytes) = 49 b8 0f 0f 0f 0f 0f 0f 0f 0f
00a9h and r8,rcx                    ; AND(And_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 23 c1
00ach add rdx,rdx                   ; ADD(Add_r64_rm64) [RDX,RDX]                          encoding(3 bytes) = 48 03 d2
00afh add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
00b2h mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
00bch imul r8,rdx                   ; IMUL(Imul_r64_rm64) [R8,RDX]                         encoding(4 bytes) = 4c 0f af c2
00c0h shr r8,38h                    ; SHR(Shr_rm64_imm8) [R8,38h:imm8]                     encoding(4 bytes) = 49 c1 e8 38
00c4h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
00c7h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
00cah xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
00cdh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
00d0h and r8,r10                    ; AND(And_r64_rm64) [R8,R10]                           encoding(3 bytes) = 4d 23 c2
00d3h and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
00d6h or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
00d9h xor rcx,r10                   ; XOR(Xor_r64_rm64) [RCX,R10]                          encoding(3 bytes) = 49 33 ca
00dch mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
00dfh shr r8,1                      ; SHR(Shr_rm64_1) [R8,1h:imm8]                         encoding(3 bytes) = 49 d1 e8
00e2h mov r9,5555555555555555h      ; MOV(Mov_r64_imm64) [R9,5555555555555555h:imm64]      encoding(10 bytes) = 49 b9 55 55 55 55 55 55 55 55
00ech and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
00efh sub rax,r8                    ; SUB(Sub_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 2b c0
00f2h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
00f5h shr r8,1                      ; SHR(Shr_rm64_1) [R8,1h:imm8]                         encoding(3 bytes) = 49 d1 e8
00f8h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
00fbh sub rcx,r8                    ; SUB(Sub_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 2b c8
00feh mov r8,3333333333333333h      ; MOV(Mov_r64_imm64) [R8,3333333333333333h:imm64]      encoding(10 bytes) = 49 b8 33 33 33 33 33 33 33 33
0108h and r8,rax                    ; AND(And_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 23 c0
010bh shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
010fh mov r9,3333333333333333h      ; MOV(Mov_r64_imm64) [R9,3333333333333333h:imm64]      encoding(10 bytes) = 49 b9 33 33 33 33 33 33 33 33
0119h and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
011ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
011fh and r9,rcx                    ; AND(And_r64_rm64) [R9,RCX]                           encoding(3 bytes) = 4c 23 c9
0122h shr rcx,2                     ; SHR(Shr_rm64_imm8) [RCX,2h:imm8]                     encoding(4 bytes) = 48 c1 e9 02
0126h mov r8,3333333333333333h      ; MOV(Mov_r64_imm64) [R8,3333333333333333h:imm64]      encoding(10 bytes) = 49 b8 33 33 33 33 33 33 33 33
0130h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0133h add rcx,r9                    ; ADD(Add_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 03 c9
0136h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0139h shr r8,4                      ; SHR(Shr_rm64_imm8) [R8,4h:imm8]                      encoding(4 bytes) = 49 c1 e8 04
013dh add r8,rax                    ; ADD(Add_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 03 c0
0140h mov rax,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RAX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 b8 0f 0f 0f 0f 0f 0f 0f 0f
014ah and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
014dh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0150h shr r8,4                      ; SHR(Shr_rm64_imm8) [R8,4h:imm8]                      encoding(4 bytes) = 49 c1 e8 04
0154h add r8,rcx                    ; ADD(Add_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 03 c1
0157h mov rcx,0F0F0F0F0F0F0F0Fh     ; MOV(Mov_r64_imm64) [RCX,f0f0f0f0f0f0f0fh:imm64]      encoding(10 bytes) = 48 b9 0f 0f 0f 0f 0f 0f 0f 0f
0161h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0164h add rax,rax                   ; ADD(Add_r64_rm64) [RAX,RAX]                          encoding(3 bytes) = 48 03 c0
0167h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
016ah mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0174h imul rcx,rax                  ; IMUL(Imul_r64_rm64) [RCX,RAX]                        encoding(4 bytes) = 48 0f af c8
0178h shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
017ch lea eax,[rdx+rcx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 04 0a
017fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0180h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[385]{0x56,0x0F,0x1F,0x40,0x00,0x48,0x8B,0x44,0x24,0x30,0x4C,0x8B,0x54,0x24,0x38,0x4C,0x8B,0xD9,0x4C,0x33,0xDA,0x49,0x8B,0xF3,0x49,0x23,0xF0,0x48,0x23,0xD1,0x48,0x0B,0xD6,0x4D,0x33,0xC3,0x48,0x8B,0xCA,0x48,0xD1,0xE9,0x49,0xBB,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x49,0x23,0xCB,0x48,0x2B,0xD1,0x49,0x8B,0xC8,0x48,0xD1,0xE9,0x49,0x23,0xCB,0x4C,0x2B,0xC1,0x48,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x48,0x23,0xCA,0x48,0xC1,0xEA,0x02,0x49,0xBB,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x49,0x23,0xD3,0x48,0x03,0xD1,0x4D,0x23,0xD8,0x49,0xC1,0xE8,0x02,0x48,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x4C,0x23,0xC1,0x4D,0x03,0xC3,0x48,0x8B,0xCA,0x48,0xC1,0xE9,0x04,0x48,0x03,0xCA,0x48,0xBA,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x48,0x23,0xD1,0x49,0x8B,0xC8,0x48,0xC1,0xE9,0x04,0x49,0x03,0xC8,0x49,0xB8,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x4C,0x23,0xC1,0x48,0x03,0xD2,0x49,0x03,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x4C,0x0F,0xAF,0xC2,0x49,0xC1,0xE8,0x38,0x41,0x8B,0xD0,0x49,0x8B,0xC9,0x48,0x33,0xC8,0x4C,0x8B,0xC1,0x4D,0x23,0xC2,0x49,0x23,0xC1,0x49,0x0B,0xC0,0x49,0x33,0xCA,0x4C,0x8B,0xC0,0x49,0xD1,0xE8,0x49,0xB9,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x4D,0x23,0xC1,0x49,0x2B,0xC0,0x4C,0x8B,0xC1,0x49,0xD1,0xE8,0x4D,0x23,0xC1,0x49,0x2B,0xC8,0x49,0xB8,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x4C,0x23,0xC0,0x48,0xC1,0xE8,0x02,0x49,0xB9,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x49,0x23,0xC1,0x49,0x03,0xC0,0x4C,0x23,0xC9,0x48,0xC1,0xE9,0x02,0x49,0xB8,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x33,0x49,0x23,0xC8,0x49,0x03,0xC9,0x4C,0x8B,0xC0,0x49,0xC1,0xE8,0x04,0x4C,0x03,0xC0,0x48,0xB8,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x49,0x23,0xC0,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x04,0x4C,0x03,0xC1,0x48,0xB9,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x0F,0x49,0x23,0xC8,0x48,0x03,0xC0,0x48,0x03,0xC1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x48,0x0F,0xAF,0xC8,0x48,0xC1,0xE9,0x38,0x8D,0x04,0x0A,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(byte src)
; location: [7FFDDB045980h, 7FFDDB0459A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 04
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 09
0018h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
001ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001eh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(ushort src)
; location: [7FFDDB0459C0h, 7FFDDB0459E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 04
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 09
0018h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
001ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001eh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(uint src)
; location: [7FFDDB045A00h, 7FFDDB045A1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jne short 0012h               ; JNE(Jne_rel8_64) [12h:jmp64]                         encoding(2 bytes) = 75 04
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h jmp short 001bh               ; JMP(Jmp_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = eb 09
0012h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0016h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0018h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(ulong src)
; location: [7FFDDB045A30h, 7FFDDB045A4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
000dh jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 04
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 0a
0013h lzcnt rax,rax                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RAX]                      encoding(5 bytes) = f3 48 0f bd c0
0018h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001ah add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0x48,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x0A,0xF3,0x48,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x3F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte range(byte a, uint min, uint max)
; location: [7FFDDB045A60h, 7FFDDB045A85h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001dh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort range(ushort a, uint min, uint max)
; location: [7FFDDB045AA0h, 7FFDDB045AC5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001dh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0022h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint range(uint a, uint min, uint max)
; location: [7FFDDB045AE0h, 7FFDDB045AFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong range(ulong a, uint min, uint max)
; location: [7FFDDB045B10h, 7FFDDB045B2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
000bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000fh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ah bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rangeBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0xFF,0xC0,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(byte src, uint pos)
; location: [7FFDDB045B40h, 7FFDDB045B5Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0013h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ushort src, uint pos)
; location: [7FFDDB045B70h, 7FFDDB045B8Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0013h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(uint src, uint pos)
; location: [7FFDDB045BA0h, 7FFDDB045BB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0015h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ulong src, uint pos)
; location: [7FFDDB045BD0h, 7FFDDB045BEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0007h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000ah shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0015h popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rankBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC2,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xF3,0x48,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rev(byte src)
; location: [7FFDDB045C00h, 7FFDDB045C33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,80200802h             ; MOV(Mov_r32_imm32) [EDX,80200802h:imm32]             encoding(5 bytes) = ba 02 08 20 80
000dh imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
0011h mov rdx,884422110h            ; MOV(Mov_r64_imm64) [RDX,884422110h:imm64]            encoding(10 bytes) = 48 ba 10 21 42 84 08 00 00 00
001bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
001eh mov rdx,101010101h            ; MOV(Mov_r64_imm64) [RDX,101010101h:imm64]            encoding(10 bytes) = 48 ba 01 01 01 01 01 00 00 00
0028h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xBA,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC2,0x48,0xBA,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC2,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rev(ushort src)
; location: [7FFDDB045C50h, 7FFDDB045CC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0015h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0019h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0023h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0026h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
0030h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0043h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0047h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0051h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0054h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
005eh imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0062h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0066h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0069h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
006ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
006eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[114]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xD1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rev(uint x)
; location: [7FFDDB045CE0h, 7FFDDB045D3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0AAAAAAAAh            ; AND(And_EAX_imm32) [EAX,aaaaaaaah:imm32]             encoding(5 bytes) = 25 aa aa aa aa
000ch shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
000eh and ecx,55555555h             ; AND(And_rm32_imm32) [ECX,55555555h:imm32]            encoding(6 bytes) = 81 e1 55 55 55 55
0014h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0016h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0018h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
001ah and eax,0CCCCCCCCh            ; AND(And_EAX_imm32) [EAX,cccccccch:imm32]             encoding(5 bytes) = 25 cc cc cc cc
001fh shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0022h and ecx,33333333h             ; AND(And_rm32_imm32) [ECX,33333333h:imm32]            encoding(6 bytes) = 81 e1 33 33 33 33
0028h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
002bh or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh and eax,0F0F0F0F0h            ; AND(And_EAX_imm32) [EAX,f0f0f0f0h:imm32]             encoding(5 bytes) = 25 f0 f0 f0 f0
0034h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0037h and ecx,0F0F0F0Fh             ; AND(And_rm32_imm32) [ECX,f0f0f0fh:imm32]             encoding(6 bytes) = 81 e1 0f 0f 0f 0f
003dh shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0040h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0042h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0044h and eax,0FF00FF00h            ; AND(And_EAX_imm32) [EAX,ff00ff00h:imm32]             encoding(5 bytes) = 25 00 ff 00 ff
0049h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
004ch and ecx,0FF00FFh              ; AND(And_rm32_imm32) [ECX,ff00ffh:imm32]              encoding(6 bytes) = 81 e1 ff 00 ff 00
0052h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0055h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0057h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0059h rol eax,10h                   ; ROL(Rol_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 c0 10
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[93]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xAA,0xAA,0xAA,0xAA,0xD1,0xE8,0x81,0xE1,0x55,0x55,0x55,0x55,0xD1,0xE1,0x0B,0xC8,0x8B,0xC1,0x25,0xCC,0xCC,0xCC,0xCC,0xC1,0xE8,0x02,0x81,0xE1,0x33,0x33,0x33,0x33,0xC1,0xE1,0x02,0x0B,0xC8,0x8B,0xC1,0x25,0xF0,0xF0,0xF0,0xF0,0xC1,0xE8,0x04,0x81,0xE1,0x0F,0x0F,0x0F,0x0F,0xC1,0xE1,0x04,0x0B,0xC8,0x8B,0xC1,0x25,0x00,0xFF,0x00,0xFF,0xC1,0xE8,0x08,0x81,0xE1,0xFF,0x00,0xFF,0x00,0xC1,0xE1,0x08,0x0B,0xC8,0x8B,0xC1,0xC1,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rev(ulong src)
; location: [7FFDDB045D50h, 7FFDDB045E17h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh and edx,0AAAAAAAAh            ; AND(And_rm32_imm32) [EDX,aaaaaaaah:imm32]            encoding(6 bytes) = 81 e2 aa aa aa aa
0014h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0016h and eax,55555555h             ; AND(And_EAX_imm32) [EAX,55555555h:imm32]             encoding(5 bytes) = 25 55 55 55 55
001bh shl eax,1                     ; SHL(Shl_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e0
001dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001fh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0021h and edx,0CCCCCCCCh            ; AND(And_rm32_imm32) [EDX,cccccccch:imm32]            encoding(6 bytes) = 81 e2 cc cc cc cc
0027h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
002ah and eax,33333333h             ; AND(And_EAX_imm32) [EAX,33333333h:imm32]             encoding(5 bytes) = 25 33 33 33 33
002fh shl eax,2                     ; SHL(Shl_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e0 02
0032h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0034h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0036h and edx,0F0F0F0F0h            ; AND(And_rm32_imm32) [EDX,f0f0f0f0h:imm32]            encoding(6 bytes) = 81 e2 f0 f0 f0 f0
003ch shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
003fh and eax,0F0F0F0Fh             ; AND(And_EAX_imm32) [EAX,f0f0f0fh:imm32]              encoding(5 bytes) = 25 0f 0f 0f 0f
0044h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0047h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0049h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
004bh and edx,0FF00FF00h            ; AND(And_rm32_imm32) [EDX,ff00ff00h:imm32]            encoding(6 bytes) = 81 e2 00 ff 00 ff
0051h shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
0054h and eax,0FF00FFh              ; AND(And_EAX_imm32) [EAX,ff00ffh:imm32]               encoding(5 bytes) = 25 ff 00 ff 00
0059h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
005ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
005eh rol eax,10h                   ; ROL(Rol_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 c0 10
0061h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0063h and edx,0AAAAAAAAh            ; AND(And_rm32_imm32) [EDX,aaaaaaaah:imm32]            encoding(6 bytes) = 81 e2 aa aa aa aa
0069h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
006bh and ecx,55555555h             ; AND(And_rm32_imm32) [ECX,55555555h:imm32]            encoding(6 bytes) = 81 e1 55 55 55 55
0071h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0073h or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
0075h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0077h and edx,0CCCCCCCCh            ; AND(And_rm32_imm32) [EDX,cccccccch:imm32]            encoding(6 bytes) = 81 e2 cc cc cc cc
007dh shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
0080h and ecx,33333333h             ; AND(And_rm32_imm32) [ECX,33333333h:imm32]            encoding(6 bytes) = 81 e1 33 33 33 33
0086h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0089h or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
008bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
008dh and edx,0F0F0F0F0h            ; AND(And_rm32_imm32) [EDX,f0f0f0f0h:imm32]            encoding(6 bytes) = 81 e2 f0 f0 f0 f0
0093h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0096h and ecx,0F0F0F0Fh             ; AND(And_rm32_imm32) [ECX,f0f0f0fh:imm32]             encoding(6 bytes) = 81 e1 0f 0f 0f 0f
009ch shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
009fh or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
00a1h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00a3h and edx,0FF00FF00h            ; AND(And_rm32_imm32) [EDX,ff00ff00h:imm32]            encoding(6 bytes) = 81 e2 00 ff 00 ff
00a9h shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
00ach and ecx,0FF00FFh              ; AND(And_rm32_imm32) [ECX,ff00ffh:imm32]              encoding(6 bytes) = 81 e1 ff 00 ff 00
00b2h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
00b5h or ecx,edx                    ; OR(Or_r32_rm32) [ECX,EDX]                            encoding(2 bytes) = 0b ca
00b7h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00b9h rol edx,10h                   ; ROL(Rol_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 c2 10
00bch mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
00beh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
00c0h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
00c4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
00c7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[200]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x8B,0xD0,0x81,0xE2,0xAA,0xAA,0xAA,0xAA,0xD1,0xEA,0x25,0x55,0x55,0x55,0x55,0xD1,0xE0,0x0B,0xC2,0x8B,0xD0,0x81,0xE2,0xCC,0xCC,0xCC,0xCC,0xC1,0xEA,0x02,0x25,0x33,0x33,0x33,0x33,0xC1,0xE0,0x02,0x0B,0xC2,0x8B,0xD0,0x81,0xE2,0xF0,0xF0,0xF0,0xF0,0xC1,0xEA,0x04,0x25,0x0F,0x0F,0x0F,0x0F,0xC1,0xE0,0x04,0x0B,0xC2,0x8B,0xD0,0x81,0xE2,0x00,0xFF,0x00,0xFF,0xC1,0xEA,0x08,0x25,0xFF,0x00,0xFF,0x00,0xC1,0xE0,0x08,0x0B,0xC2,0xC1,0xC0,0x10,0x8B,0xD1,0x81,0xE2,0xAA,0xAA,0xAA,0xAA,0xD1,0xEA,0x81,0xE1,0x55,0x55,0x55,0x55,0xD1,0xE1,0x0B,0xCA,0x8B,0xD1,0x81,0xE2,0xCC,0xCC,0xCC,0xCC,0xC1,0xEA,0x02,0x81,0xE1,0x33,0x33,0x33,0x33,0xC1,0xE1,0x02,0x0B,0xCA,0x8B,0xD1,0x81,0xE2,0xF0,0xF0,0xF0,0xF0,0xC1,0xEA,0x04,0x81,0xE1,0x0F,0x0F,0x0F,0x0F,0xC1,0xE1,0x04,0x0B,0xCA,0x8B,0xD1,0x81,0xE2,0x00,0xFF,0x00,0xFF,0xC1,0xEA,0x08,0x81,0xE1,0xFF,0x00,0xFF,0x00,0xC1,0xE1,0x08,0x0B,0xCA,0x8B,0xD1,0xC1,0xC2,0x10,0x8B,0xC0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, int shift)
; location: [7FFDDB045E30h, 7FFDDB045E4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl(ushort src, int shift)
; location: [7FFDDB045E60h, 7FFDDB045E7Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl(uint src, int shift)
; location: [7FFDDB045E90h, 7FFDDB045E9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, int shift)
; location: [7FFDDB045EB0h, 7FFDDB045EBDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, int shift, int width)
; location: [7FFDDB045ED0h, 7FFDDB045EEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000dh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0010h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0018h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0xD3,0xF8,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl(ushort src, int shift, int width)
; location: [7FFDDB045F00h, 7FFDDB045F1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000dh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0010h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0018h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
001bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0xD3,0xF8,0x41,0x0B,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl(uint src, int shift, int width)
; location: [7FFDDB045F30h, 7FFDDB045F4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
000fh sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0012h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0015h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
0017h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0xD3,0xE8,0x41,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, int shift, int width)
; location: [7FFDDB045F60h, 7FFDDB045F7Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000dh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0010h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
0019h or rax,r9                     ; OR(Or_r64_rm64) [RAX,R9]                             encoding(3 bytes) = 49 0b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC8,0x49,0xD3,0xE1,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x48,0xD3,0xE8,0x49,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, int shift)
; location: [7FFDDB045F90h, 7FFDDB045FAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr(ushort src, int shift)
; location: [7FFDDB045FC0h, 7FFDDB045FDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, int shift)
; location: [7FFDDB045FF0h, 7FFDDB045FFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, int shift)
; location: [7FFDDB046010h, 7FFDDB04601Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, int shift, int width)
; location: [7FFDDB046030h, 7FFDDB04604Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000dh sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0010h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0018h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC8,0x41,0xD3,0xF9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0xD3,0xE0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr(ushort src, int shift, int width)
; location: [7FFDDB046060h, 7FFDDB04607Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000dh sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0010h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0018h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
001bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC8,0x41,0xD3,0xF9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0xD3,0xE0,0x41,0x0B,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, int shift, int width)
; location: [7FFDDB046090h, 7FFDDB0460AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch shr r9d,cl                    ; SHR(Shr_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e9
000fh sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0012h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0015h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0017h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC8,0x41,0xD3,0xE9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0xD3,0xE0,0x41,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, int shift, int width)
; location: [7FFDDB0460C0h, 7FFDDB0460DCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000dh shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
0010h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0019h or rax,r9                     ; OR(Or_r64_rm64) [RAX,R9]                             encoding(3 bytes) = 49 0b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC8,0x49,0xD3,0xE9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x49,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte scatter(sbyte src, sbyte mask)
; location: [7FFDDB0460F0h, 7FFDDB04610Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xD2,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte scatter(byte src, byte mask)
; location: [7FFDDB046120h, 7FFDDB046133h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short scatter(short src, short mask)
; location: [7FFDDB046150h, 7FFDDB04616Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0010h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0013h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD2,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort scatter(ushort src, ushort mask)
; location: [7FFDDB046180h, 7FFDDB046193h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int scatter(int src, int mask)
; location: [7FFDDB0461B0h, 7FFDDB0461BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint scatter(uint src, uint mask)
; location: [7FFDDB0461D0h, 7FFDDB0461DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long scatter(long src, long mask)
; location: [7FFDDB0461F0h, 7FFDDB0461FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong scatter(ulong src, ulong mask)
; location: [7FFDDB046210h, 7FFDDB04621Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(byte src, out byte x0, out byte x1)
; location: [7FFDDB046230h, 7FFDDB046245h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
000dh mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
000fh sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0012h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(3 bytes) = 41 88 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0x83,0xE1,0x0F,0x88,0x0A,0xC1,0xF8,0x04,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ushort src, out byte x0, out byte x1)
; location: [7FFDDB046260h, 7FFDDB046270h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
0007h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(3 bytes) = 41 88 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, out ushort x0, out ushort x1)
; location: [7FFDDB046290h, 7FFDDB04629Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,:sr),CX]           encoding(3 bytes) = 66 89 0a
0008h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
000bh mov [r8],cx                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),CX]            encoding(4 bytes) = 66 41 89 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC1,0xE9,0x10,0x66,0x41,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out uint x0, out uint x1)
; location: [7FFDDB0462B0h, 7FFDDB0462C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),ECX]          encoding(2 bytes) = 89 0a
0007h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out ushort x0, out ushort x1, out ushort x2, out ushort x3)
; location: [7FFDDB0462E0h, 7FFDDB04630Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,:sr),CX]           encoding(3 bytes) = 66 89 0a
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
000fh mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),AX]            encoding(4 bytes) = 66 41 89 00
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
001ah mov [r9],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R9:br,:sr),AX]            encoding(4 bytes) = 66 41 89 01
001eh shr rcx,30h                   ; SHR(Shr_rm64_imm8) [RCX,30h:imm8]                    encoding(4 bytes) = 48 c1 e9 30
0022h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
0027h mov [rax],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),CX]           encoding(3 bytes) = 66 89 08
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x10,0x66,0x41,0x89,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x66,0x41,0x89,0x01,0x48,0xC1,0xE9,0x30,0x48,0x8B,0x44,0x24,0x28,0x66,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
; location: [7FFDDB046320h, 7FFDDB046341h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
000ch mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(3 bytes) = 41 88 00
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
0014h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,:sr),AL]               encoding(3 bytes) = 41 88 01
0017h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
001ah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
001fh mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(2 bytes) = 88 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x8B,0xC1,0xC1,0xE8,0x08,0x41,0x88,0x00,0x8B,0xC1,0xC1,0xE8,0x10,0x41,0x88,0x01,0xC1,0xE9,0x18,0x48,0x8B,0x44,0x24,0x28,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out byte x0, out byte x1, out byte x2, out byte x3, out byte x4, out byte x5, out byte x6, out byte x7)
; location: [7FFDDB046360h, 7FFDDB0463BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
000eh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(3 bytes) = 41 88 00
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
0018h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,:sr),AL]               encoding(3 bytes) = 41 88 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh shr rax,18h                   ; SHR(Shr_rm64_imm8) [RAX,18h:imm8]                    encoding(4 bytes) = 48 c1 e8 18
0022h mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 28
0027h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
0029h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h mov rdx,[rsp+30h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 30
0035h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah shr rax,28h                   ; SHR(Shr_rm64_imm8) [RAX,28h:imm8]                    encoding(4 bytes) = 48 c1 e8 28
003eh mov rdx,[rsp+38h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 38
0043h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
0045h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0048h shr rax,30h                   ; SHR(Shr_rm64_imm8) [RAX,30h:imm8]                    encoding(4 bytes) = 48 c1 e8 30
004ch mov rdx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 40
0051h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
0053h shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
0057h mov rax,[rsp+48h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 48
005ch mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(2 bytes) = 88 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[95]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x08,0x41,0x88,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x10,0x41,0x88,0x01,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x18,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x48,0x8B,0x54,0x24,0x30,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x28,0x48,0x8B,0x54,0x24,0x38,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x30,0x48,0x8B,0x54,0x24,0x40,0x88,0x02,0x48,0xC1,0xE9,0x38,0x48,0x8B,0x44,0x24,0x48,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(sbyte src, int pos)
; location: [7FFDDB0463D0h, 7FFDDB0463E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(byte src, int pos)
; location: [7FFDDB046400h, 7FFDDB046411h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(short src, int pos)
; location: [7FFDDB046430h, 7FFDDB046442h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(ushort src, int pos)
; location: [7FFDDB046460h, 7FFDDB046471h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(int src, int pos)
; location: [7FFDDB046490h, 7FFDDB04649Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(uint src, int pos)
; location: [7FFDDB0464B0h, 7FFDDB0464BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(long src, int pos)
; location: [7FFDDB0464D0h, 7FFDDB0464DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(ulong src, int pos)
; location: [7FFDDB0464F0h, 7FFDDB0464FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(float src, int pos)
; location: [7FFDDB046510h, 7FFDDB04652Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit test(double src, int pos)
; location: [7FFDDB046550h, 7FFDDB04656Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testz(ulong a, ulong b)
; location: [7FFDDB046590h, 7FFDDB0465C8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+10h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 10
000ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0011h vpbroadcastq xmm0,qword ptr [rsp+10h]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 44 24 10
0018h mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 08
001dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0022h vpbroadcastq xmm1,qword ptr [rsp+8]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 4c 24 08
0029h vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
002eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testzBytes => new byte[57]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x89,0x4C,0x24,0x10,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x79,0x59,0x44,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC4,0xE2,0x79,0x59,0x4C,0x24,0x08,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testc(ulong a, ulong b)
; location: [7FFDDB0465E0h, 7FFDDB046618h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+10h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 10
000ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0011h vpbroadcastq xmm0,qword ptr [rsp+10h]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 44 24 10
0018h mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 08
001dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0022h vpbroadcastq xmm1,qword ptr [rsp+8]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 59 4c 24 08
0029h vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
002eh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testcBytes => new byte[57]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x89,0x4C,0x24,0x10,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x79,0x59,0x44,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC4,0xE2,0x79,0x59,0x4C,0x24,0x08,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testc(ulong a)
; location: [7FFDDB046630h, 7FFDDB04665Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(4 bytes) = 48 89 0c 24
0009h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
000dh vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
0013h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0017h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
001bh vpcmpeqq xmm1,xmm1,xmm2       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 29 ca
0020h vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0025h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testcBytes => new byte[48]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x89,0x0C,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC5,0xF0,0x57,0xC9,0xC5,0xE8,0x57,0xD2,0xC4,0xE2,0x71,0x29,0xCA,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte toggle(sbyte src, int pos)
; location: [7FFDDB046680h, 7FFDDB0466A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0014h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0018h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte toggle(byte src, int pos)
; location: [7FFDDB0466C0h, 7FFDDB0466DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short toggle(short src, int pos)
; location: [7FFDDB0466F0h, 7FFDDB046712h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0014h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0018h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001ah movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort toggle(ushort src, int pos)
; location: [7FFDDB046730h, 7FFDDB04674Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0019h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int toggle(int src, int pos)
; location: [7FFDDB046760h, 7FFDDB046775h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0012h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint toggle(uint src, int pos)
; location: [7FFDDB046790h, 7FFDDB0467A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0012h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long toggle(long src, int pos)
; location: [7FFDDB0467C0h, 7FFDDB0467D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong toggle(ulong src, int pos)
; location: [7FFDDB0467F0h, 7FFDDB046806h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float toggle(float src, int pos)
; location: [7FFDDB046820h, 7FFDDB046844h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss dword ptr [rsp+8],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 08
000bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0010h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
001bh xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,:sr),R8D]          encoding(3 bytes) = 44 31 00
001eh vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double toggle(double src, int pos)
; location: [7FFDDB046860h, 7FFDDB046884h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0010h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
001bh xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 31 00
001eh vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte toggle(ref sbyte src, int pos)
; location: [7FFDDB0468A0h, 7FFDDB0468B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h xor [rax],dl                  ; XOR(Xor_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 30 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x30,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte toggle(ref byte src, int pos)
; location: [7FFDDB0468D0h, 7FFDDB0468E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h xor [rax],dl                  ; XOR(Xor_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 30 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x30,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short toggle(ref short src, int pos)
; location: [7FFDDB046900h, 7FFDDB04691Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h xor [rax],dx                  ; XOR(Xor_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 31 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x31,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort toggle(ref ushort src, int pos)
; location: [7FFDDB046930h, 7FFDDB04694Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h xor [rax],dx                  ; XOR(Xor_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 31 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x31,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int toggle(ref int src, int pos)
; location: [7FFDDB046960h, 7FFDDB046976h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,:sr),R8D]          encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint toggle(ref uint src, int pos)
; location: [7FFDDB046990h, 7FFDDB0469A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,:sr),R8D]          encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long toggle(ref long src, int pos)
; location: [7FFDDB0469C0h, 7FFDDB0469D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong toggle(ref ulong src, int pos)
; location: [7FFDDB0469F0h, 7FFDDB046A06h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float toggle(ref float src, int pos)
; location: [7FFDDB046A20h, 7FFDDB046A36h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,:sr),R8D]          encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double toggle(ref double src, int pos)
; location: [7FFDDB046A50h, 7FFDDB046A66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte zerohi(byte src, int index)
; location: [7FFDDB046A80h, 7FFDDB046A90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zerohiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort zerohi(ushort src, int index)
; location: [7FFDDB046AB0h, 7FFDDB046AC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zerohiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint zerohi(uint src, int index)
; location: [7FFDDB046AE0h, 7FFDDB046AEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zerohiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong zerohi(ulong src, int index)
; location: [7FFDDB046B00h, 7FFDDB046B0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zerohiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly(N8 n, uint x)
; location: [7FFDDB046B20h, 7FFDDB046B3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h and eax,0FFFF00h              ; AND(And_EAX_imm32) [EAX,ffff00h:imm32]               encoding(5 bytes) = 25 00 ff ff 00
000ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000eh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0011h xor ecx,eax                   ; XOR(Xor_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 33 c8
0013h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
0016h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0018h and eax,0FFFF00h              ; AND(And_EAX_imm32) [EAX,ffff00h:imm32]               encoding(5 bytes) = 25 00 ff ff 00
001dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x25,0x00,0xFF,0xFF,0x00,0x8B,0xC8,0xC1,0xE1,0x08,0x33,0xC8,0xC1,0xE8,0x08,0x33,0xC1,0x25,0x00,0xFF,0xFF,0x00,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly(N8 n, ulong x)
; location: [7FFDDB046B50h, 7FFDDB046B86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0012h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0015h shl rcx,8                     ; SHL(Shl_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e1 08
0019h xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
001ch shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
0020h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0023h mov rcx,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RCX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b9 00 ff ff 00 00 ff ff 00
002dh and rcx,rax                   ; AND(And_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 23 c8
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x23,0xC2,0x48,0x8B,0xC8,0x48,0xC1,0xE1,0x08,0x48,0x33,0xC8,0x48,0xC1,0xE8,0x08,0x48,0x33,0xC1,0x48,0xB9,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x23,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly(N16 n, ulong x)
; location: [7FFDDB046BA0h, 7FFDDB046BD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0012h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0015h shl rcx,10h                   ; SHL(Shl_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e1 10
0019h xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
001ch shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
0020h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0023h mov rcx,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RCX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b9 00 00 ff ff ff ff 00 00
002dh and rcx,rax                   ; AND(And_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 23 c8
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x23,0xC2,0x48,0x8B,0xC8,0x48,0xC1,0xE1,0x10,0x48,0x33,0xC8,0x48,0xC1,0xE8,0x10,0x48,0x33,0xC1,0x48,0xB9,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x23,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte clear(byte src, int first, int last)
; location: [7FFDDB046BF0h, 7FFDDB046C48h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0011h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ch neg r9d                       ; NEG(Neg_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d9
001fh add r9d,8                     ; ADD(Add_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 c1 08
0023h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0027h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
002bh lea r10d,[r8+1]               ; LEA(Lea_r32_m) [R10D,mem(Unknown,R8:br,:sr)]         encoding(4 bytes) = 45 8d 50 01
002fh movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
0033h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0036h movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
003ah bextr ecx,ecx,r9d             ; BEXTR(VEX_Bextr_r32_rm32_r32) [ECX,ECX,R9D]          encoding(VEX, 5 bytes) = c4 e2 30 f7 c9
003fh movzx r9d,cl                  ; MOVZX(Movzx_r32_rm8) [R9D,CL]                        encoding(4 bytes) = 44 0f b6 c9
0043h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0046h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0049h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
004ch lea ecx,[rdx+1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a 01
004fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0052h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0055h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clearBytes => new byte[89]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB6,0xC9,0xC4,0xE2,0x78,0xF7,0xC1,0x0F,0xB6,0xC0,0x45,0x8B,0xC8,0x41,0xF7,0xD9,0x41,0x83,0xC1,0x08,0x45,0x0F,0xB6,0xC9,0x41,0xC1,0xE1,0x08,0x45,0x8D,0x50,0x01,0x45,0x0F,0xB6,0xD2,0x45,0x0B,0xCA,0x45,0x0F,0xB7,0xC9,0xC4,0xE2,0x30,0xF7,0xC9,0x44,0x0F,0xB6,0xC9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x8D,0x4A,0x01,0x41,0xD3,0xE1,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort clear(ushort src, int first, int last)
; location: [7FFDDB046C60h, 7FFDDB046CB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0011h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ch neg r9d                       ; NEG(Neg_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d9
001fh add r9d,10h                   ; ADD(Add_rm32_imm8) [R9D,10h:imm32]                   encoding(4 bytes) = 41 83 c1 10
0023h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0027h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
002bh lea r10d,[r8+1]               ; LEA(Lea_r32_m) [R10D,mem(Unknown,R8:br,:sr)]         encoding(4 bytes) = 45 8d 50 01
002fh movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
0033h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0036h movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
003ah bextr ecx,ecx,r9d             ; BEXTR(VEX_Bextr_r32_rm32_r32) [ECX,ECX,R9D]          encoding(VEX, 5 bytes) = c4 e2 30 f7 c9
003fh movzx r9d,cx                  ; MOVZX(Movzx_r32_rm16) [R9D,CX]                       encoding(4 bytes) = 44 0f b7 c9
0043h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0046h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0049h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
004ch lea ecx,[rdx+1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a 01
004fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0052h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0055h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clearBytes => new byte[89]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB7,0xC9,0xC4,0xE2,0x78,0xF7,0xC1,0x0F,0xB7,0xC0,0x45,0x8B,0xC8,0x41,0xF7,0xD9,0x41,0x83,0xC1,0x10,0x45,0x0F,0xB6,0xC9,0x41,0xC1,0xE1,0x08,0x45,0x8D,0x50,0x01,0x45,0x0F,0xB6,0xD2,0x45,0x0B,0xCA,0x45,0x0F,0xB7,0xC9,0xC4,0xE2,0x30,0xF7,0xC9,0x44,0x0F,0xB7,0xC9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x8D,0x4A,0x01,0x41,0xD3,0xE1,0x41,0x0B,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint clear(uint src, int first, int last)
; location: [7FFDDB046CD0h, 7FFDDB046D1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0013h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0016h neg r9d                       ; NEG(Neg_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d9
0019h add r9d,20h                   ; ADD(Add_rm32_imm8) [R9D,20h:imm32]                   encoding(4 bytes) = 41 83 c1 20
001dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0021h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
0025h lea r10d,[r8+1]               ; LEA(Lea_r32_m) [R10D,mem(Unknown,R8:br,:sr)]         encoding(4 bytes) = 45 8d 50 01
0029h movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
002dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0030h movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0034h bextr r9d,ecx,r9d             ; BEXTR(VEX_Bextr_r32_rm32_r32) [R9D,ECX,R9D]          encoding(VEX, 5 bytes) = c4 62 30 f7 c9
0039h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
003ch mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
003fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0042h lea ecx,[rdx+1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a 01
0045h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0048h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clearBytes => new byte[76]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x45,0x8B,0xC8,0x41,0xF7,0xD9,0x41,0x83,0xC1,0x20,0x45,0x0F,0xB6,0xC9,0x41,0xC1,0xE1,0x08,0x45,0x8D,0x50,0x01,0x45,0x0F,0xB6,0xD2,0x45,0x0B,0xCA,0x45,0x0F,0xB7,0xC9,0xC4,0x62,0x30,0xF7,0xC9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x8D,0x4A,0x01,0x41,0xD3,0xE1,0x41,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong clear(ulong src, int first, int last)
; location: [7FFDDB046D30h, 7FFDDB046D7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0013h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0016h neg r9d                       ; NEG(Neg_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d9
0019h add r9d,40h                   ; ADD(Add_rm32_imm8) [R9D,40h:imm32]                   encoding(4 bytes) = 41 83 c1 40
001dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0021h shl r9d,8                     ; SHL(Shl_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e1 08
0025h lea r10d,[r8+1]               ; LEA(Lea_r32_m) [R10D,mem(Unknown,R8:br,:sr)]         encoding(4 bytes) = 45 8d 50 01
0029h movzx r10d,r10b               ; MOVZX(Movzx_r32_rm8) [R10D,R10L]                     encoding(4 bytes) = 45 0f b6 d2
002dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0030h movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0034h bextr r9,rcx,r9               ; BEXTR(VEX_Bextr_r64_rm64_r64) [R9,RCX,R9]            encoding(VEX, 5 bytes) = c4 62 b0 f7 c9
0039h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
003ch mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
003fh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0042h lea ecx,[rdx+1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a 01
0045h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0048h or rax,r9                     ; OR(Or_r64_rm64) [RAX,R9]                             encoding(3 bytes) = 49 0b c1
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clearBytes => new byte[76]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x45,0x8B,0xC8,0x41,0xF7,0xD9,0x41,0x83,0xC1,0x40,0x45,0x0F,0xB6,0xC9,0x41,0xC1,0xE1,0x08,0x45,0x8D,0x50,0x01,0x45,0x0F,0xB6,0xD2,0x45,0x0B,0xCA,0x45,0x0F,0xB7,0xC9,0xC4,0x62,0xB0,0xF7,0xC9,0x44,0x2B,0xC2,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x8D,0x4A,0x01,0x49,0xD3,0xE1,0x49,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int effwidth(in byte src)
; location: [7FFDDB046D90h, 7FFDDB046DA4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,:sr)]        encoding(3 bytes) = 0f b6 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0011h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> effwidthBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xF7,0xD8,0x83,0xC0,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int effwidth(in ushort src)
; location: [7FFDDB046DC0h, 7FFDDB046DD4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,:sr)]      encoding(3 bytes) = 0f b7 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0011h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> effwidthBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xF7,0xD8,0x83,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int effwidth(uint src)
; location: [7FFDDB046DF0h, 7FFDDB046E00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,ecx                 ; LZCNT(Lzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bd c1
000bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000dh add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> effwidthBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int effwidth(ulong src)
; location: [7FFDDB046E20h, 7FFDDB046E31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,rcx                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bd c1
000ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000eh add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> effwidthBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte extract(sbyte src, byte start, byte length)
; location: [7FFDDB046E50h, 7FFDDB046E71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte extract(sbyte src, int start, int length)
; location: [7FFDDB046E90h, 7FFDDB046EB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte extract(byte src, byte start, byte length)
; location: [7FFDDB046ED0h, 7FFDDB046EEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte extract(byte src, int start, int length)
; location: [7FFDDB046F00h, 7FFDDB046F1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short extract(short src, byte start, byte length)
; location: [7FFDDB046F30h, 7FFDDB046F51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short extract(short src, int start, int length)
; location: [7FFDDB046F70h, 7FFDDB046F91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort extract(ushort src, byte start, byte length)
; location: [7FFDDB046FB0h, 7FFDDB046FCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort extract(ushort src, int start, int length)
; location: [7FFDDB046FE0h, 7FFDDB046FFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(uint src, byte start, byte length)
; location: [7FFDDB047010h, 7FFDDB047029h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(uint src, int start, int length)
; location: [7FFDDB047040h, 7FFDDB047059h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int extract(int src, byte start, byte length)
; location: [7FFDDB047070h, 7FFDDB047089h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int extract(int src, int start, int length)
; location: [7FFDDB0470A0h, 7FFDDB0470B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long extract(long src, byte start, byte length)
; location: [7FFDDB0470D0h, 7FFDDB0470E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long extract(long src, int start, int length)
; location: [7FFDDB047100h, 7FFDDB047119h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(ulong src, byte start, byte length)
; location: [7FFDDB047130h, 7FFDDB047149h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(ulong src, int start, int length)
; location: [7FFDDB047160h, 7FFDDB047179h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(float src, byte start, byte length)
; location: [7FFDDB047190h, 7FFDDB0471B7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0019h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001eh bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(float src, int start, int length)
; location: [7FFDDB0471D0h, 7FFDDB0471F7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0019h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001eh bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(double src, byte start, byte length)
; location: [7FFDDB047210h, 7FFDDB047236h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0011h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0015h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0018h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
0022h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[39]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(double src, int start, int length)
; location: [7FFDDB047250h, 7FFDDB047276h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0011h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0015h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0018h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
0022h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[39]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather(byte src, byte mask)
; location: [7FFDDB047290h, 7FFDDB0472A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte gather(sbyte src, sbyte mask)
; location: [7FFDDB0472C0h, 7FFDDB0472D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short gather(short src, short mask)
; location: [7FFDDB0472F0h, 7FFDDB047306h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, ushort mask)
; location: [7FFDDB047320h, 7FFDDB047333h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int gather(int src, int mask)
; location: [7FFDDB047350h, 7FFDDB04735Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, uint mask)
; location: [7FFDDB047370h, 7FFDDB04737Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long gather(long src, long mask)
; location: [7FFDDB047390h, 7FFDDB04739Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, ulong mask)
; location: [7FFDDB0473B0h, 7FFDDB0473BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(float src, uint mask)
; location: [7FFDDB0473D0h, 7FFDDB0473E8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0014h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[25]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(double src, ulong mask)
; location: [7FFDDB047400h, 7FFDDB047417h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
000eh pext rax,rax,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c2
0013h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[24]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0xC4,0xE2,0xFA,0xF5,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte gather(byte src, byte mask, ref byte dst)
; location: [7FFDDB047430h, 7FFDDB047446h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(3 bytes) = 41 88 00
0013h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte gather(sbyte src, sbyte mask, ref sbyte dst)
; location: [7FFDDB047460h, 7FFDDB047478h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(3 bytes) = 41 88 00
0015h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short gather(short src, short mask, ref short dst)
; location: [7FFDDB047490h, 7FFDDB0474A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),AX]            encoding(4 bytes) = 66 41 89 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort gather(ushort src, ushort mask, ref ushort dst)
; location: [7FFDDB0474C0h, 7FFDDB0474D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),AX]            encoding(4 bytes) = 66 41 89 00
0014h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int gather(int src, int mask, ref int dst)
; location: [7FFDDB0474F0h, 7FFDDB047500h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint gather(uint src, uint mask, ref uint dst)
; location: [7FFDDB047520h, 7FFDDB047530h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long gather(long src, long mask, ref long dst)
; location: [7FFDDB047550h, 7FFDDB047560h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong gather(ulong src, ulong mask, ref ulong dst)
; location: [7FFDDB047580h, 7FFDDB047590h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(sbyte src)
; location: [7FFDDB0475B0h, 7FFDDB0475C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC1,0xF8,0x04,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(byte src)
; location: [7FFDDB0475E0h, 7FFDDB0475EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC1,0xF8,0x04,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(short src)
; location: [7FFDDB047600h, 7FFDDB047610h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC1,0xF8,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(ushort src)
; location: [7FFDDB047630h, 7FFDDB04763Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short hi(int src)
; location: [7FFDDB047650h, 7FFDDB04765Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sar ecx,10h                   ; SAR(Sar_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 f9 10
0008h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xF9,0x10,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort hi(uint src)
; location: [7FFDDB047670h, 7FFDDB04767Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0008h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xE9,0x10,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int hi(long src)
; location: [7FFDDB047690h, 7FFDDB04769Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint hi(ulong src)
; location: [7FFDDB0476B0h, 7FFDDB0476BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inject(byte src, byte dst, int first, int count)
; location: [7FFDDB0476D0h, 7FFDDB047721h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
0008h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000bh bzhi edx,eax,r8d              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EDX,EAX,R8D]            encoding(VEX, 5 bytes) = c4 e2 38 f5 d0
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h movzx r10d,cl                 ; MOVZX(Movzx_r32_rm8) [R10D,CL]                       encoding(4 bytes) = 44 0f b6 d1
0017h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001ah shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
001dh movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
0021h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0024h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0026h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0029h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002ch shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
002fh movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
0033h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0036h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0039h bextr ecx,eax,ecx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [ECX,EAX,ECX]          encoding(VEX, 5 bytes) = c4 e2 70 f7 c8
003eh movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0041h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0044h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0046h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0049h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
004ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
004eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> injectBytes => new byte[82]{0x0F,0x1F,0x44,0x00,0x00,0x45,0x03,0xC8,0x0F,0xB6,0xC2,0xC4,0xE2,0x38,0xF5,0xD0,0x0F,0xB6,0xD2,0x44,0x0F,0xB6,0xD1,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x45,0x0F,0xB6,0xC2,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x08,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xD1,0x41,0x0B,0xCA,0x0F,0xB7,0xC9,0xC4,0xE2,0x70,0xF7,0xC8,0x0F,0xB6,0xC1,0x41,0x8B,0xC9,0xD3,0xE0,0x0F,0xB6,0xC0,0x41,0x0B,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inject(ushort src, ushort dst, int first, int count)
; location: [7FFDDB047740h, 7FFDDB047791h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
0008h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000bh bzhi edx,eax,r8d              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EDX,EAX,R8D]            encoding(VEX, 5 bytes) = c4 e2 38 f5 d0
0010h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0013h movzx r10d,cx                 ; MOVZX(Movzx_r32_rm16) [R10D,CX]                      encoding(4 bytes) = 44 0f b7 d1
0017h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001ah shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
001dh movzx r8d,r10w                ; MOVZX(Movzx_r32_rm16) [R8D,R10W]                     encoding(4 bytes) = 45 0f b7 c2
0021h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0024h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0026h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0029h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002ch shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
002fh movzx r10d,r9b                ; MOVZX(Movzx_r32_rm8) [R10D,R9L]                      encoding(4 bytes) = 45 0f b6 d1
0033h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0036h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0039h bextr ecx,eax,ecx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [ECX,EAX,ECX]          encoding(VEX, 5 bytes) = c4 e2 70 f7 c8
003eh movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0041h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0044h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0046h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0049h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
004ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
004eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> injectBytes => new byte[82]{0x0F,0x1F,0x44,0x00,0x00,0x45,0x03,0xC8,0x0F,0xB7,0xC2,0xC4,0xE2,0x38,0xF5,0xD0,0x0F,0xB7,0xD2,0x44,0x0F,0xB7,0xD1,0x41,0x8B,0xC8,0x41,0xD3,0xE2,0x45,0x0F,0xB7,0xC2,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x10,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xD1,0x41,0x0B,0xCA,0x0F,0xB7,0xC9,0xC4,0xE2,0x70,0xF7,0xC8,0x0F,0xB7,0xC1,0x41,0x8B,0xC9,0xD3,0xE0,0x0F,0xB7,0xC0,0x41,0x0B,0xD0,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inject(uint src, uint dst, int first, int count)
; location: [7FFDDB0477B0h, 7FFDDB0477EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
000ah bzhi r10d,edx,r8d             ; BZHI(VEX_Bzhi_r32_rm32_r32) [R10D,EDX,R8D]           encoding(VEX, 5 bytes) = c4 62 38 f5 d2
000fh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0012h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0014h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0017h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0019h add ecx,20h                   ; ADD(Add_rm32_imm8) [ECX,20h:imm32]                   encoding(3 bytes) = 83 c1 20
001ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001fh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0022h movzx r8d,r9b                 ; MOVZX(Movzx_r32_rm8) [R8D,R9L]                       encoding(4 bytes) = 45 0f b6 c1
0026h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0029h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
002ch bextr edx,edx,ecx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,EDX,ECX]          encoding(VEX, 5 bytes) = c4 e2 70 f7 d2
0031h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0034h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0036h or eax,r10d                   ; OR(Or_r32_rm32) [EAX,R10D]                           encoding(3 bytes) = 41 0b c2
0039h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> injectBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x45,0x03,0xC8,0xC4,0x62,0x38,0xF5,0xD2,0x41,0x8B,0xC8,0xD3,0xE0,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x20,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xC1,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC4,0xE2,0x70,0xF7,0xD2,0x41,0x8B,0xC9,0xD3,0xE2,0x41,0x0B,0xC2,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inject(ulong src, ulong dst, int first, int count)
; location: [7FFDDB047800h, 7FFDDB047842h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
000bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
000eh bzhi r10,rdx,rcx              ; BZHI(VEX_Bzhi_r64_rm64_r64) [R10,RDX,RCX]            encoding(VEX, 5 bytes) = c4 62 f0 f5 d2
0013h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0016h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0019h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
001ch neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
001eh add ecx,40h                   ; ADD(Add_rm32_imm8) [ECX,40h:imm32]                   encoding(3 bytes) = 83 c1 40
0021h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0024h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0027h movzx r8d,r9b                 ; MOVZX(Movzx_r32_rm8) [R8D,R9L]                       encoding(4 bytes) = 45 0f b6 c1
002bh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
002eh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0031h bextr rdx,rdx,rcx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RDX,RCX]          encoding(VEX, 5 bytes) = c4 e2 f0 f7 d2
0036h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0039h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003ch or rax,r10                    ; OR(Or_r64_rm64) [RAX,R10]                            encoding(3 bytes) = 49 0b c2
003fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> injectBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x45,0x03,0xC8,0x41,0x8B,0xC8,0xC4,0x62,0xF0,0xF5,0xD2,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x41,0x8B,0xC9,0xF7,0xD9,0x83,0xC1,0x40,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x45,0x0F,0xB6,0xC1,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC4,0xE2,0xF0,0xF7,0xD2,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x49,0x0B,0xC2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(sbyte src)
; location: [7FFDDB047860h, 7FFDDB04786Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(byte src)
; location: [7FFDDB047880h, 7FFDDB04788Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(short src)
; location: [7FFDDB0478A0h, 7FFDDB0478ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(ushort src)
; location: [7FFDDB0478C0h, 7FFDDB0478CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short lo(int src)
; location: [7FFDDB0478E0h, 7FFDDB0478E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort lo(uint src)
; location: [7FFDDB047900h, 7FFDDB047908h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int lo(long src)
; location: [7FFDDB047920h, 7FFDDB047927h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint lo(ulong src)
; location: [7FFDDB047940h, 7FFDDB047947h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte loff(ref sbyte src)
; location: [7FFDDB047960h, 7FFDDB047977h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,:sr)]        encoding(4 bytes) = 48 0f be 01
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 50 ff
000ch movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0010h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0012h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,:sr),DL]              encoding(2 bytes) = 88 11
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x8D,0x50,0xFF,0x48,0x0F,0xBE,0xD2,0x23,0xD0,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte loff(ref byte src)
; location: [7FFDDB047990h, 7FFDDB0479A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,:sr)]        encoding(3 bytes) = 0f b6 01
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 50 ff
000bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000eh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0010h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,:sr),DL]              encoding(2 bytes) = 88 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x8D,0x50,0xFF,0x0F,0xB6,0xD2,0x23,0xD0,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short loff(ref short src)
; location: [7FFDDB0479C0h, 7FFDDB0479D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,:sr)]      encoding(4 bytes) = 48 0f bf 01
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 50 ff
000ch movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0010h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0012h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,:sr),DX]           encoding(3 bytes) = 66 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x8D,0x50,0xFF,0x48,0x0F,0xBF,0xD2,0x23,0xD0,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort loff(ref ushort src)
; location: [7FFDDB0479F0h, 7FFDDB047A06h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,:sr)]      encoding(3 bytes) = 0f b7 01
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 50 ff
000bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000eh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0010h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,:sr),DX]           encoding(3 bytes) = 66 89 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x8D,0x50,0xFF,0x0F,0xB7,0xD2,0x23,0xD0,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int loff(ref int src)
; location: [7FFDDB047A20h, 7FFDDB047A31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 01
0007h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 50 ff
000ah and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000ch mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(2 bytes) = 89 11
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8D,0x50,0xFF,0x23,0xD0,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint loff(ref uint src)
; location: [7FFDDB047A50h, 7FFDDB047A61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 01
0007h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 50 ff
000ah and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000ch mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(2 bytes) = 89 11
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8D,0x50,0xFF,0x23,0xD0,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long loff(ref long src)
; location: [7FFDDB047A80h, 7FFDDB047A95h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax-1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 ff
000ch and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
000fh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0xFF,0x48,0x23,0xD0,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong loff(ref ulong src)
; location: [7FFDDB047AB0h, 7FFDDB047AC5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax-1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 ff
000ch and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
000fh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0xFF,0x48,0x23,0xD0,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(byte src)
; location: [7FFDDB047AE0h, 7FFDDB047AF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 09
0010h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0014h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0016h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(ushort src)
; location: [7FFDDB047B10h, 7FFDDB047B29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 09
0010h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0014h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0016h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(uint src)
; location: [7FFDDB047B40h, 7FFDDB047B58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h jne short 000dh               ; JNE(Jne_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = 75 04
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 0b
000dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000fh lzcnt eax,ecx                 ; LZCNT(Lzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bd c1
0013h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0015h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x0B,0x33,0xC0,0xF3,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(ulong src)
; location: [7FFDDB047B70h, 7FFDDB047B8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h jne short 000eh               ; JNE(Jne_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 75 04
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch jmp short 001ah               ; JMP(Jmp_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = eb 0c
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h lzcnt rax,rcx                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bd c1
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x0C,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x3F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0)
; location: [7FFDDB047BA0h, 7FFDDB047BB6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1)
; location: [7FFDDB047BD0h, 7FFDDB047BF4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h or [rax],r9                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R9]             encoding(3 bytes) = 4c 09 08
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4C,0x09,0x08,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2)
; location: [7FFDDB047C10h, 7FFDDB047C42h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R10]            encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
; location: [7FFDDB047C60h, 7FFDDB047CA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R10]            encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
; location: [7FFDDB047CC0h, 7FFDDB047D10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R10]            encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[81]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
; location: [7FFDDB047D30h, 7FFDDB047D8Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R10]            encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0050h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0055h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 38
0059h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
005ch or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[96]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
; location: [7FFDDB047DA0h, 7FFDDB047E0Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R10]            encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
0050h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0055h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 38
0059h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
005ch or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
005fh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0064h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 40
0068h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
006bh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),RDX]            encoding(3 bytes) = 48 09 10
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[111]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x40,0x48,0xD3,0xE2,0x48,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
; location: [7FFDDB047E20h, 7FFDDB047E99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or r10,[rax]                  ; OR(Or_r64_rm64) [R10,mem(64u,RAX:br,:sr)]            encoding(3 bytes) = 4c 0b 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rdx,r10                    ; OR(Or_r64_rm64) [RDX,R10]                            encoding(3 bytes) = 49 0b d2
0024h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
002ah mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0030h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0033h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0039h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 28
003dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0040h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0043h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0049h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 30
004dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0050h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0053h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0059h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 40
005dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0060h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0063h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0066h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
006ch mov ecx,[rsp+48h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 48
0070h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0073h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0076h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[122]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x0B,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xD2,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x40,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x48,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mix(N0 parity, byte x, byte y)
; location: [7FFDDB047EB0h, 7FFDDB047EE4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h mov edx,55h                   ; MOV(Mov_r32_imm32) [EDX,55h:imm32]                   encoding(5 bytes) = ba 55 00 00 00
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh mov ecx,55h                   ; MOV(Mov_r32_imm32) [ECX,55h:imm32]                   encoding(5 bytes) = b9 55 00 00 00
0020h pext edx,edx,ecx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6a f5 d1
0025h mov ecx,0AAh                  ; MOV(Mov_r32_imm32) [ECX,aah:imm32]                   encoding(5 bytes) = b9 aa 00 00 00
002ah pdep edx,edx,ecx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 d1
002fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xBA,0x55,0x00,0x00,0x00,0xC4,0xE2,0x7A,0xF5,0xC2,0xC4,0xE2,0x7B,0xF5,0xC2,0x41,0x0F,0xB6,0xD0,0xB9,0x55,0x00,0x00,0x00,0xC4,0xE2,0x6A,0xF5,0xD1,0xB9,0xAA,0x00,0x00,0x00,0xC4,0xE2,0x6B,0xF5,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mix(N1 parity, byte x, byte y)
; location: [7FFDDB047F00h, 7FFDDB047F3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h mov edx,0AAh                  ; MOV(Mov_r32_imm32) [EDX,aah:imm32]                   encoding(5 bytes) = ba aa 00 00 00
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h mov edx,55h                   ; MOV(Mov_r32_imm32) [EDX,55h:imm32]                   encoding(5 bytes) = ba 55 00 00 00
001ah pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
001fh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0023h mov ecx,0AAh                  ; MOV(Mov_r32_imm32) [ECX,aah:imm32]                   encoding(5 bytes) = b9 aa 00 00 00
0028h pext edx,edx,ecx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6a f5 d1
002dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0030h pdep edx,edx,ecx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 d1
0035h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xBA,0xAA,0x00,0x00,0x00,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xBA,0x55,0x00,0x00,0x00,0xC4,0xE2,0x7B,0xF5,0xC2,0x41,0x0F,0xB6,0xD0,0xB9,0xAA,0x00,0x00,0x00,0xC4,0xE2,0x6A,0xF5,0xD1,0x0F,0xB6,0xD2,0xC4,0xE2,0x6B,0xF5,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mix(N0 parity, ushort x, ushort y)
; location: [7FFDDB047F50h, 7FFDDB047F84h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h mov edx,5555h                 ; MOV(Mov_r32_imm32) [EDX,5555h:imm32]                 encoding(5 bytes) = ba 55 55 00 00
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0017h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
001bh mov ecx,5555h                 ; MOV(Mov_r32_imm32) [ECX,5555h:imm32]                 encoding(5 bytes) = b9 55 55 00 00
0020h pext edx,edx,ecx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6a f5 d1
0025h mov ecx,0AAAAh                ; MOV(Mov_r32_imm32) [ECX,aaaah:imm32]                 encoding(5 bytes) = b9 aa aa 00 00
002ah pdep edx,edx,ecx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 d1
002fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0031h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0xBA,0x55,0x55,0x00,0x00,0xC4,0xE2,0x7A,0xF5,0xC2,0xC4,0xE2,0x7B,0xF5,0xC2,0x41,0x0F,0xB7,0xD0,0xB9,0x55,0x55,0x00,0x00,0xC4,0xE2,0x6A,0xF5,0xD1,0xB9,0xAA,0xAA,0x00,0x00,0xC4,0xE2,0x6B,0xF5,0xD1,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mix(N1 parity, ushort x, ushort y)
; location: [7FFDDB047FA0h, 7FFDDB047FDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h mov edx,0AAAAh                ; MOV(Mov_r32_imm32) [EDX,aaaah:imm32]                 encoding(5 bytes) = ba aa aa 00 00
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0015h mov edx,5555h                 ; MOV(Mov_r32_imm32) [EDX,5555h:imm32]                 encoding(5 bytes) = ba 55 55 00 00
001ah pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
001fh movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0023h mov ecx,0AAAAh                ; MOV(Mov_r32_imm32) [ECX,aaaah:imm32]                 encoding(5 bytes) = b9 aa aa 00 00
0028h pext edx,edx,ecx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6a f5 d1
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h pdep edx,edx,ecx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 d1
0035h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0037h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0xBA,0xAA,0xAA,0x00,0x00,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xBA,0x55,0x55,0x00,0x00,0xC4,0xE2,0x7B,0xF5,0xC2,0x41,0x0F,0xB7,0xD0,0xB9,0xAA,0xAA,0x00,0x00,0xC4,0xE2,0x6A,0xF5,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x6B,0xF5,0xD1,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mix(N0 parity, uint x, uint y)
; location: [7FFDDB047FF0h, 7FFDDB04801Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,55555555h             ; MOV(Mov_r32_imm32) [EAX,55555555h:imm32]             encoding(5 bytes) = b8 55 55 55 55
000ah pext eax,edx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 6a f5 c0
000fh mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
0014h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0019h pext edx,r8d,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,R8D,EDX]            encoding(VEX, 5 bytes) = c4 e2 3a f5 d2
001eh mov ecx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [ECX,aaaaaaaah:imm32]             encoding(5 bytes) = b9 aa aa aa aa
0023h pdep edx,edx,ecx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 d1
0028h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x55,0x55,0x55,0x55,0xC4,0xE2,0x6A,0xF5,0xC0,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7B,0xF5,0xC2,0xC4,0xE2,0x3A,0xF5,0xD2,0xB9,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x6B,0xF5,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mix(N1 parity, uint x, uint y)
; location: [7FFDDB048030h, 7FFDDB04805Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EAX,aaaaaaaah:imm32]             encoding(5 bytes) = b8 aa aa aa aa
000ah pext eax,edx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 6a f5 c0
000fh mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
0014h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0019h mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
001eh pext edx,r8d,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,R8D,EDX]            encoding(VEX, 5 bytes) = c4 e2 3a f5 d2
0023h mov ecx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [ECX,aaaaaaaah:imm32]             encoding(5 bytes) = b9 aa aa aa aa
0028h pdep edx,edx,ecx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EDX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 6b f5 d1
002dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x6A,0xF5,0xC0,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7B,0xF5,0xC2,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x3A,0xF5,0xD2,0xB9,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x6B,0xF5,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mix(N0 parity, ulong x, ulong y)
; location: [7FFDDB048070h, 7FFDDB0480AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,5555555555555555h     ; MOV(Mov_r64_imm64) [RAX,5555555555555555h:imm64]     encoding(10 bytes) = 48 b8 55 55 55 55 55 55 55 55
000fh pext rax,rdx,rax              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RDX,RAX]            encoding(VEX, 5 bytes) = c4 e2 ea f5 c0
0014h mov rdx,5555555555555555h     ; MOV(Mov_r64_imm64) [RDX,5555555555555555h:imm64]     encoding(10 bytes) = 48 ba 55 55 55 55 55 55 55 55
001eh pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0023h pext rdx,r8,rdx               ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,R8,RDX]             encoding(VEX, 5 bytes) = c4 e2 ba f5 d2
0028h mov rcx,0AAAAAAAAAAAAAAAAh    ; MOV(Mov_r64_imm64) [RCX,aaaaaaaaaaaaaaaah:imm64]     encoding(10 bytes) = 48 b9 aa aa aa aa aa aa aa aa
0032h pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0037h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0xC4,0xE2,0xEA,0xF5,0xC0,0x48,0xBA,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE2,0xBA,0xF5,0xD2,0x48,0xB9,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mix(N1 parity, ulong x, ulong y)
; location: [7FFDDB0480C0h, 7FFDDB048104h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0AAAAAAAAAAAAAAAAh    ; MOV(Mov_r64_imm64) [RAX,aaaaaaaaaaaaaaaah:imm64]     encoding(10 bytes) = 48 b8 aa aa aa aa aa aa aa aa
000fh pext rax,rdx,rax              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RDX,RAX]            encoding(VEX, 5 bytes) = c4 e2 ea f5 c0
0014h mov rdx,5555555555555555h     ; MOV(Mov_r64_imm64) [RDX,5555555555555555h:imm64]     encoding(10 bytes) = 48 ba 55 55 55 55 55 55 55 55
001eh pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0023h mov rdx,0AAAAAAAAAAAAAAAAh    ; MOV(Mov_r64_imm64) [RDX,aaaaaaaaaaaaaaaah:imm64]     encoding(10 bytes) = 48 ba aa aa aa aa aa aa aa aa
002dh pext rdx,r8,rdx               ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,R8,RDX]             encoding(VEX, 5 bytes) = c4 e2 ba f5 d2
0032h mov rcx,0AAAAAAAAAAAAAAAAh    ; MOV(Mov_r64_imm64) [RCX,aaaaaaaaaaaaaaaah:imm64]     encoding(10 bytes) = 48 b9 aa aa aa aa aa aa aa aa
003ch pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0041h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mixBytes => new byte[69]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0xEA,0xF5,0xC0,0x48,0xBA,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0xC4,0xE2,0xFB,0xF5,0xC2,0x48,0xBA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0xBA,0xF5,0xD2,0x48,0xB9,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int nlz(byte src)
; location: [7FFDDB048120h, 7FFDDB04812Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int nlz(ushort src)
; location: [7FFDDB048140h, 7FFDDB04814Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int nlz(uint src)
; location: [7FFDDB048160h, 7FFDDB04816Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,ecx                 ; LZCNT(Lzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bd c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int nlz(ulong src)
; location: [7FFDDB048180h, 7FFDDB04818Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,rcx                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bd c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(sbyte src)
; location: [7FFDDB0481A0h, 7FFDDB0481ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(byte src)
; location: [7FFDDB0481C0h, 7FFDDB0481CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(short src)
; location: [7FFDDB0481E0h, 7FFDDB0481EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(ushort src)
; location: [7FFDDB048200h, 7FFDDB04820Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(int src)
; location: [7FFDDB048220h, 7FFDDB04822Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(uint src)
; location: [7FFDDB048240h, 7FFDDB04824Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(long src)
; location: [7FFDDB048260h, 7FFDDB04826Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ntz(ulong src)
; location: [7FFDDB048280h, 7FFDDB04828Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1)
; location: [7FFDDB0482A0h, 7FFDDB0482ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2)
; location: [7FFDDB0482C0h, 7FFDDB0482D2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2, bit b3)
; location: [7FFDDB0482F0h, 7FFDDB048309h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0012h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0016h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC0,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2, bit b3, bit b4)
; location: [7FFDDB048320h, 7FFDDB048342h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000fh or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0012h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0016h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0019h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 28
001dh shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x8B,0xC1,0x0B,0xC2,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC0,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC1,0x8B,0x54,0x24,0x28,0xC1,0xE2,0x04,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
; location: [7FFDDB048360h, 7FFDDB048398h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0007h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0009h shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
000dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0010h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0014h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0017h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
001bh shl eax,1                     ; SHL(Shl_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e0
001dh or eax,[rsp+28h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 44 24 28
0021h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 38
0025h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0028h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
002ah mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 40
002eh shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0031h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0033h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0036h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0xD1,0xE2,0x0B,0xD1,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xD0,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xD1,0x8B,0x44,0x24,0x30,0xD1,0xE0,0x0B,0x44,0x24,0x28,0x8B,0x4C,0x24,0x38,0xC1,0xE1,0x02,0x0B,0xC1,0x8B,0x4C,0x24,0x40,0xC1,0xE1,0x03,0x0B,0xC1,0xC1,0xE0,0x04,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(ReadOnlySpan<bit> src, ref uint dst)
; location: [7FFDDB0487C0h, 7FFDDB048804h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 41 08
0008h cmp eax,20h                   ; CMP(Cmp_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 f8 20
000bh jl short 0015h                ; JL(Jl_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7c 08
000dh mov r8d,20h                   ; MOV(Mov_r32_imm32) [R8D,20h:imm32]                   encoding(6 bytes) = 41 b8 20 00 00 00
0013h jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 03
0015h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0018h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
001bh xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001eh test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0021h jle short 0041h               ; JLE(Jle_rel8_64) [41h:jmp64]                         encoding(2 bytes) = 7e 1e
0023h mov r10d,[rdx]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RDX:br,:sr)]         encoding(3 bytes) = 44 8b 12
0026h movsxd rcx,r9d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R9D]                    encoding(3 bytes) = 49 63 c9
0029h mov r11d,[rax+rcx*4]          ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 1c 88
002dh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0030h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0033h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0036h mov [rdx],r10d                ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),R10D]         encoding(3 bytes) = 44 89 12
0039h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
003ch cmp r9d,r8d                   ; CMP(Cmp_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 3b c8
003fh jl short 0023h                ; JL(Jl_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 7c e2
0041h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[69]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x41,0x08,0x83,0xF8,0x20,0x7C,0x08,0x41,0xB8,0x20,0x00,0x00,0x00,0xEB,0x03,0x44,0x8B,0xC0,0x48,0x8B,0x01,0x45,0x33,0xC9,0x45,0x85,0xC0,0x7E,0x1E,0x44,0x8B,0x12,0x49,0x63,0xC9,0x44,0x8B,0x1C,0x88,0x41,0x8B,0xC9,0x41,0xD3,0xE3,0x45,0x0B,0xD3,0x44,0x89,0x12,0x41,0xFF,0xC1,0x45,0x3B,0xC8,0x7C,0xE2,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N1 n, in bit src, ref uint dst)
; location: [7FFDDB048820h, 7FFDDB048832h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 12
000ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x12,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N2 n, in bit src, ref uint dst)
; location: [7FFDDB048850h, 7FFDDB04886Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0012h mov edx,[rdx+4]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 04
0015h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0017h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
001ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x52,0x04,0xD1,0xE2,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N3 n, in bit src, ref uint dst)
; location: [7FFDDB048880h, 7FFDDB0488ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
001fh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
0022h shl edx,2                     ; SHL(Shl_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 e2 02
0025h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
002ah mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x52,0x08,0xC1,0xE2,0x02,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N4 n, in bit src, ref uint dst)
; location: [7FFDDB0488C0h, 7FFDDB0488FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
002dh mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 0c
0030h shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
0033h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
0038h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N8 n, in bit src, ref uint dst)
; location: [7FFDDB048910h, 7FFDDB048986h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
002dh mov ecx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 0c
0030h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0033h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
0038h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
003ch lea rax,[r8+10h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 40 10
0040h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0042h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 44 8b 0a
0045h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0048h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
004ah mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
004ch mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 04
0050h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0053h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0056h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0058h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
005ah mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 08
005eh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
0062h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0065h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0067h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0069h mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 0c
006ch shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
006fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0071h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
0073h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0076h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[119]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x0C,0xC1,0xE1,0x03,0x0B,0xC1,0x41,0x89,0x00,0x48,0x83,0xC2,0x10,0x49,0x8D,0x40,0x10,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xD1,0x89,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N16 n, in bit src, ref uint dst)
; location: [7FFDDB0489A0h, 7FFDDB048A97h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
002dh mov ecx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 0c
0030h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0033h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
0038h lea rax,[rdx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 10
003ch lea rcx,[r8+10h]              ; LEA(Lea_r64_m) [RCX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 48 10
0040h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
0043h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(3 bytes) = 44 8b 10
0046h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0049h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
004ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
004fh mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 04
0053h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0056h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0059h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
005ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
005fh mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 08
0063h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0067h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
006ah mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
006dh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
0070h mov eax,[rax+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 0c
0073h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0076h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0079h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(2 bytes) = 89 01
007bh add rdx,20h                   ; ADD(Add_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 c2 20
007fh lea rax,[r8+20h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 40 20
0083h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0085h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 44 8b 0a
0088h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
008bh mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
008dh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
008fh mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 04
0093h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0096h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0099h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
009bh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
009dh mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 08
00a1h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00a5h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00a8h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
00aah mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
00ach mov r9d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 0c
00b0h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
00b4h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00b7h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
00b9h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
00bdh add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
00c1h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
00c3h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 44 8b 0a
00c6h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00c9h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
00cbh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
00cdh mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 04
00d1h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
00d4h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00d7h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
00d9h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
00dbh mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 08
00dfh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00e3h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
00e6h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
00e8h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
00eah mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 0c
00edh shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
00f0h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
00f2h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
00f4h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
00f7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[248]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x0C,0xC1,0xE1,0x03,0x0B,0xC1,0x41,0x89,0x00,0x48,0x8D,0x42,0x10,0x49,0x8D,0x48,0x10,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x8B,0x40,0x0C,0xC1,0xE0,0x03,0x41,0x0B,0xC1,0x89,0x01,0x48,0x83,0xC2,0x20,0x49,0x8D,0x40,0x20,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x89,0x08,0x48,0x83,0xC2,0x10,0x48,0x83,0xC0,0x10,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xD1,0x89,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint pack(N32 n, in bit src, ref uint dst)
; location: [7FFDDB048AB0h, 7FFDDB048CB2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0008h mov ecx,[rdx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(2 bytes) = 8b 0a
000ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000ch mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
000fh mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
0012h mov ecx,[rdx+4]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 04
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0019h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
001ch mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
001fh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
0022h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0025h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0027h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
002ah mov eax,[r8]                  ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(3 bytes) = 41 8b 00
002dh mov ecx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 0c
0030h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0033h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0035h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(3 bytes) = 41 89 00
0038h lea rax,[rdx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 10
003ch lea rcx,[r8+10h]              ; LEA(Lea_r64_m) [RCX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 48 10
0040h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
0043h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(3 bytes) = 44 8b 10
0046h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0049h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
004ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
004fh mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 04
0053h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0056h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0059h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
005ch mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
005fh mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 08
0063h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0067h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
006ah mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
006dh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
0070h mov eax,[rax+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 0c
0073h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0076h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0079h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(2 bytes) = 89 01
007bh lea rax,[rdx+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 20
007fh lea rcx,[r8+20h]              ; LEA(Lea_r64_m) [RCX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 48 20
0083h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
0086h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(3 bytes) = 44 8b 10
0089h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
008ch mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
008fh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
0092h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 04
0096h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0099h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
009ch mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
009fh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
00a2h mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 08
00a6h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
00aah or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00adh mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
00b0h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
00b3h mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 0c
00b7h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
00bbh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00beh mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
00c1h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
00c5h add rcx,10h                   ; ADD(Add_rm64_imm8) [RCX,10h:imm64]                   encoding(4 bytes) = 48 83 c1 10
00c9h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
00cch mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(3 bytes) = 44 8b 10
00cfh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00d2h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
00d5h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
00d8h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 04
00dch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
00dfh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00e2h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
00e5h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
00e8h mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 44 8b 50 08
00ech shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
00f0h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
00f3h mov [rcx],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D]          encoding(3 bytes) = 44 89 09
00f6h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 44 8b 09
00f9h mov eax,[rax+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 0c
00fch shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
00ffh or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0102h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(2 bytes) = 89 01
0104h add rdx,40h                   ; ADD(Add_rm64_imm8) [RDX,40h:imm64]                   encoding(4 bytes) = 48 83 c2 40
0108h lea rax,[r8+40h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 40 40
010ch mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
010eh mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 44 8b 0a
0111h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0114h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0116h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0118h mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 04
011ch shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
011fh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0122h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0124h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0126h mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 08
012ah shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
012eh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0131h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0133h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0135h mov r9d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 0c
0139h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
013dh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0140h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0142h lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 10
0146h lea r9,[rax+10h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 48 10
014ah mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,:sr)]          encoding(3 bytes) = 45 8b 11
014dh mov r11d,[rcx]                ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,:sr)]         encoding(3 bytes) = 44 8b 19
0150h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0153h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D]          encoding(3 bytes) = 45 89 11
0156h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,:sr)]          encoding(3 bytes) = 45 8b 11
0159h mov r11d,[rcx+4]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,:sr)]         encoding(4 bytes) = 44 8b 59 04
015dh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
0160h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0163h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D]          encoding(3 bytes) = 45 89 11
0166h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,:sr)]          encoding(3 bytes) = 45 8b 11
0169h mov r11d,[rcx+8]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,:sr)]         encoding(4 bytes) = 44 8b 59 08
016dh shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
0171h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0174h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D]          encoding(3 bytes) = 45 89 11
0177h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,:sr)]          encoding(3 bytes) = 45 8b 11
017ah mov ecx,[rcx+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 49 0c
017dh shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0180h or ecx,r10d                   ; OR(Or_r32_rm32) [ECX,R10D]                           encoding(3 bytes) = 41 0b ca
0183h mov [r9],ecx                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),ECX]           encoding(3 bytes) = 41 89 09
0186h add rdx,20h                   ; ADD(Add_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 c2 20
018ah add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
018eh mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0190h mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 44 8b 0a
0193h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
0196h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
0198h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
019ah mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 04
019eh shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
01a1h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01a4h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
01a6h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
01a8h mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 08
01ach shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
01b0h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01b3h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
01b5h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
01b7h mov r9d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 0c
01bbh shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
01bfh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01c2h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
01c4h add rdx,10h                   ; ADD(Add_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 c2 10
01c8h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
01cch mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
01ceh mov r9d,[rdx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 44 8b 0a
01d1h or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01d4h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
01d6h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
01d8h mov r9d,[rdx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 04
01dch shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
01dfh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01e2h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
01e4h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
01e6h mov r9d,[rdx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 4a 08
01eah shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
01eeh or ecx,r9d                    ; OR(Or_r32_rm32) [ECX,R9D]                            encoding(3 bytes) = 41 0b c9
01f1h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
01f3h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
01f5h mov edx,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 0c
01f8h shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
01fbh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
01fdh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
01ffh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0202h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[515]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0x00,0x8B,0x0A,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x04,0xD1,0xE1,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x08,0xC1,0xE1,0x02,0x0B,0xC1,0x41,0x89,0x00,0x41,0x8B,0x00,0x8B,0x4A,0x0C,0xC1,0xE1,0x03,0x0B,0xC1,0x41,0x89,0x00,0x48,0x8D,0x42,0x10,0x49,0x8D,0x48,0x10,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x8B,0x40,0x0C,0xC1,0xE0,0x03,0x41,0x0B,0xC1,0x89,0x01,0x48,0x8D,0x42,0x20,0x49,0x8D,0x48,0x20,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x44,0x89,0x09,0x48,0x83,0xC0,0x10,0x48,0x83,0xC1,0x10,0x44,0x8B,0x09,0x44,0x8B,0x10,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x44,0x89,0x09,0x44,0x8B,0x09,0x8B,0x40,0x0C,0xC1,0xE0,0x03,0x41,0x0B,0xC1,0x89,0x01,0x48,0x83,0xC2,0x40,0x49,0x8D,0x40,0x40,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x89,0x08,0x48,0x8D,0x4A,0x10,0x4C,0x8D,0x48,0x10,0x45,0x8B,0x11,0x44,0x8B,0x19,0x45,0x0B,0xD3,0x45,0x89,0x11,0x45,0x8B,0x11,0x44,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x45,0x89,0x11,0x45,0x8B,0x11,0x44,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x45,0x89,0x11,0x45,0x8B,0x11,0x8B,0x49,0x0C,0xC1,0xE1,0x03,0x41,0x0B,0xCA,0x41,0x89,0x09,0x48,0x83,0xC2,0x20,0x48,0x83,0xC0,0x20,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xC9,0x89,0x08,0x48,0x83,0xC2,0x10,0x48,0x83,0xC0,0x10,0x8B,0x08,0x44,0x8B,0x0A,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x44,0x8B,0x4A,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xC9,0x89,0x08,0x8B,0x08,0x8B,0x52,0x0C,0xC1,0xE2,0x03,0x0B,0xD1,0x89,0x10,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack(byte x0, byte x1)
; location: [7FFDDB048CD0h, 7FFDDB048CE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(ushort x0, ushort x1)
; location: [7FFDDB048D00h, 7FFDDB048D10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vbutterfly(N1 n, Vector128<byte> x)
; location: [7FFDDB048D30h, 7FFDDB048EAEh]
0000h sub rsp,0B8h                  ; SUB(Sub_rm64_imm32) [RSP,b8h:imm64]                  encoding(7 bytes) = 48 81 ec b8 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+0A0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 a0 00 00 00
0013h vmovaps [rsp+90h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 90 00 00 00
001ch mov dword ptr [rsp+8Ch],66h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(11 bytes) = c7 84 24 8c 00 00 00 66 00 00 00
0027h lea rax,[rsp+8Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 8c 00 00 00
002fh vpbroadcastb xmm0,byte ptr [rsp+8Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 79 78 84 24 8c 00 00 00
0039h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
003eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0042h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0046h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
004ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
004eh vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0053h vpsllw ymm3,ymm3,1            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 01
0058h mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
0062h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0066h vmovaps ymm5,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 ec
006ah vmovupd [rsp+60h],ymm4        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM4] encoding(VEX, 6 bytes) = c5 fd 11 64 24 60
0070h vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
0075h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
007fh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0083h vmovaps ymm5,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 ec
0087h vmovupd [rsp+40h],ymm4        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM4] encoding(VEX, 6 bytes) = c5 fd 11 64 24 40
008dh mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
0097h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
009bh vpaddb ymm4,ymm5,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM5,YMM4]  encoding(VEX, 4 bytes) = c5 d5 fc e4
009fh vpshufb ymm4,ymm3,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 00 e4
00a4h vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
00aah mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
00b4h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
00b8h vpaddb ymm5,ymm5,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM6]  encoding(VEX, 4 bytes) = c5 d5 fc ee
00bch vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
00c1h vpor ymm3,ymm4,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3]      encoding(VEX, 4 bytes) = c5 dd eb db
00c5h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
00cbh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
00cfh vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
00d4h vpsrlw ymm4,ymm4,1            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 01
00d9h mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
00e3h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00e7h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
00ebh vmovupd [rsp+20h],ymm5        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 6 bytes) = c5 fd 11 6c 24 20
00f1h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
00f6h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
0100h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0104h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
0108h vmovupd [rsp],ymm5            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 5 bytes) = c5 fd 11 2c 24
010dh mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
0117h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
011bh vpaddb ymm5,ymm6,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM6,YMM5]  encoding(VEX, 4 bytes) = c5 cd fc ed
011fh vpshufb ymm5,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 ed
0124h vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
012ah mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
0134h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0138h vpaddb ymm6,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc f7
013ch vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
0141h vpor ymm4,ymm5,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM5,YMM4]      encoding(VEX, 4 bytes) = c5 d5 eb e4
0145h vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
014bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
014fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0153h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0157h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
015bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
015fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0162h vmovaps xmm6,[rsp+0A0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 a0 00 00 00
016bh vmovaps xmm7,[rsp+90h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 90 00 00 00
0174h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0177h add rsp,0B8h                  ; ADD(Add_rm64_imm32) [RSP,b8h:imm64]                  encoding(7 bytes) = 48 81 c4 b8 00 00 00
017eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[383]{0x48,0x81,0xEC,0xB8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xA0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0x90,0x00,0x00,0x00,0xC7,0x84,0x24,0x8C,0x00,0x00,0x00,0x66,0x00,0x00,0x00,0x48,0x8D,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xE2,0x79,0x78,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC4,0xE2,0x7D,0x30,0xDB,0xC5,0xE5,0x71,0xF3,0x01,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xFC,0x28,0xEC,0xC5,0xFD,0x11,0x64,0x24,0x60,0xC4,0xE2,0x65,0x00,0xDD,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xFC,0x28,0xEC,0xC5,0xFD,0x11,0x64,0x24,0x40,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xD5,0xFC,0xE4,0xC4,0xE2,0x65,0x00,0xE4,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xD5,0xFC,0xEE,0xC4,0xE2,0x65,0x00,0xDD,0xC5,0xDD,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xF8,0x28,0xE2,0xC4,0xE2,0x7D,0x30,0xE4,0xC5,0xDD,0x71,0xD4,0x01,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x6C,0x24,0x20,0xC4,0xE2,0x5D,0x00,0xE6,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x2C,0x24,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xCD,0xFC,0xED,0xC4,0xE2,0x5D,0x00,0xED,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xF7,0xC4,0xE2,0x5D,0x00,0xE6,0xC5,0xD5,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xA0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xB8,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly(N1 n, Vector128<ushort> x)
; location: [7FFDDB048F00h, 7FFDDB048F57h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw xmm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpsllw xmm3,xmm3,1            ; VPSLLW(VEX_Vpsllw_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 71 f3 01
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrlw xmm4,xmm4,1            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 71 d4 01
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x71,0xF3,0x01,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x71,0xD4,0x01,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly(N1 n, Vector128<uint> x)
; location: [7FFDDB048F80h, 7FFDDB048FD7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpslld xmm3,xmm3,1            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 01
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrld xmm4,xmm4,1            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 01
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x01,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x01,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly(N1 n, Vector128<ulong> x)
; location: [7FFDDB049000h, 7FFDDB04905Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0022h vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0026h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
002ah vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002eh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0032h vpsllq xmm3,xmm3,1            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 01
0037h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003bh vpsrlq xmm4,xmm4,1            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 01
0040h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0044h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0048h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
004ch vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0050h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x01,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x01,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vbutterfly(N2 n, Vector128<byte> x)
; location: [7FFDDB049080h, 7FFDDB0491FEh]
0000h sub rsp,0B8h                  ; SUB(Sub_rm64_imm32) [RSP,b8h:imm64]                  encoding(7 bytes) = 48 81 ec b8 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+0A0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 a0 00 00 00
0013h vmovaps [rsp+90h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 90 00 00 00
001ch mov dword ptr [rsp+8Ch],3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(11 bytes) = c7 84 24 8c 00 00 00 3c 00 00 00
0027h lea rax,[rsp+8Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 8c 00 00 00
002fh vpbroadcastb xmm0,byte ptr [rsp+8Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 79 78 84 24 8c 00 00 00
0039h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
003eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0042h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0046h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
004ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
004eh vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0053h vpsllw ymm3,ymm3,2            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 02
0058h mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
0062h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0066h vmovaps ymm5,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 ec
006ah vmovupd [rsp+60h],ymm4        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM4] encoding(VEX, 6 bytes) = c5 fd 11 64 24 60
0070h vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
0075h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
007fh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0083h vmovaps ymm5,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 ec
0087h vmovupd [rsp+40h],ymm4        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM4] encoding(VEX, 6 bytes) = c5 fd 11 64 24 40
008dh mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
0097h vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
009bh vpaddb ymm4,ymm5,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM5,YMM4]  encoding(VEX, 4 bytes) = c5 d5 fc e4
009fh vpshufb ymm4,ymm3,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 00 e4
00a4h vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
00aah mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
00b4h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
00b8h vpaddb ymm5,ymm5,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM6]  encoding(VEX, 4 bytes) = c5 d5 fc ee
00bch vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
00c1h vpor ymm3,ymm4,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3]      encoding(VEX, 4 bytes) = c5 dd eb db
00c5h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
00cbh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
00cfh vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
00d4h vpsrlw ymm4,ymm4,2            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 02
00d9h mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
00e3h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00e7h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
00ebh vmovupd [rsp+20h],ymm5        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 6 bytes) = c5 fd 11 6c 24 20
00f1h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
00f6h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
0100h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0104h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
0108h vmovupd [rsp],ymm5            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 5 bytes) = c5 fd 11 2c 24
010dh mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
0117h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
011bh vpaddb ymm5,ymm6,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM6,YMM5]  encoding(VEX, 4 bytes) = c5 cd fc ed
011fh vpshufb ymm5,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 ed
0124h vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
012ah mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
0134h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0138h vpaddb ymm6,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc f7
013ch vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
0141h vpor ymm4,ymm5,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM5,YMM4]      encoding(VEX, 4 bytes) = c5 d5 eb e4
0145h vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
014bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
014fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0153h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0157h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
015bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
015fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0162h vmovaps xmm6,[rsp+0A0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 a0 00 00 00
016bh vmovaps xmm7,[rsp+90h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 90 00 00 00
0174h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0177h add rsp,0B8h                  ; ADD(Add_rm64_imm32) [RSP,b8h:imm64]                  encoding(7 bytes) = 48 81 c4 b8 00 00 00
017eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[383]{0x48,0x81,0xEC,0xB8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xA0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0x90,0x00,0x00,0x00,0xC7,0x84,0x24,0x8C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x48,0x8D,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xE2,0x79,0x78,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC4,0xE2,0x7D,0x30,0xDB,0xC5,0xE5,0x71,0xF3,0x02,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xFC,0x28,0xEC,0xC5,0xFD,0x11,0x64,0x24,0x60,0xC4,0xE2,0x65,0x00,0xDD,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xFC,0x28,0xEC,0xC5,0xFD,0x11,0x64,0x24,0x40,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xD5,0xFC,0xE4,0xC4,0xE2,0x65,0x00,0xE4,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xD5,0xFC,0xEE,0xC4,0xE2,0x65,0x00,0xDD,0xC5,0xDD,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xF8,0x28,0xE2,0xC4,0xE2,0x7D,0x30,0xE4,0xC5,0xDD,0x71,0xD4,0x02,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x6C,0x24,0x20,0xC4,0xE2,0x5D,0x00,0xE6,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x2C,0x24,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xCD,0xFC,0xED,0xC4,0xE2,0x5D,0x00,0xED,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xF7,0xC4,0xE2,0x5D,0x00,0xE6,0xC5,0xD5,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xA0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xB8,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly(N2 n, Vector128<ushort> x)
; location: [7FFDDB049250h, 7FFDDB0492A7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw xmm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpsllw xmm3,xmm3,2            ; VPSLLW(VEX_Vpsllw_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 71 f3 02
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrlw xmm4,xmm4,2            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 71 d4 02
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x71,0xF3,0x02,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x71,0xD4,0x02,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly(N2 n, Vector128<uint> x)
; location: [7FFDDB0492D0h, 7FFDDB049327h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpslld xmm3,xmm3,2            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 02
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrld xmm4,xmm4,2            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 02
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x02,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x02,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly(N2 n, Vector128<ulong> x)
; location: [7FFDDB049350h, 7FFDDB0493ABh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0022h vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0026h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
002ah vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002eh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0032h vpsllq xmm3,xmm3,2            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 02
0037h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003bh vpsrlq xmm4,xmm4,2            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 02
0040h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0044h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0048h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
004ch vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0050h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x02,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x02,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly(N4 n, Vector128<ushort> x)
; location: [7FFDDB0493D0h, 7FFDDB049427h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw xmm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpsllw xmm3,xmm3,4            ; VPSLLW(VEX_Vpsllw_xmm_xmm_imm8) [XMM3,XMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e1 71 f3 04
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrlw xmm4,xmm4,4            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM4,XMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 d9 71 d4 04
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x71,0xF3,0x04,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x71,0xD4,0x04,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly(N4 n, Vector128<uint> x)
; location: [7FFDDB049450h, 7FFDDB0494A7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpslld xmm3,xmm3,4            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 04
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrld xmm4,xmm4,4            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 04
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x04,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x04,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly(N4 n, Vector128<ulong> x)
; location: [7FFDDB0494D0h, 7FFDDB04952Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0022h vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0026h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
002ah vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002eh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0032h vpsllq xmm3,xmm3,4            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 04
0037h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003bh vpsrlq xmm4,xmm4,4            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 04
0040h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0044h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0048h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
004ch vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0050h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x04,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x04,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly(N8 n, Vector128<uint> x)
; location: [7FFDDB049550h, 7FFDDB0495A7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0022h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0026h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002ah vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002eh vpslld xmm3,xmm3,8            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 08
0033h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0037h vpsrld xmm4,xmm4,8            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 08
003ch vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0040h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0044h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0048h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x08,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x08,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly(N8 n, Vector128<ulong> x)
; location: [7FFDDB0495D0h, 7FFDDB04962Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0022h vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0026h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
002ah vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002eh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0032h vpsllq xmm3,xmm3,8            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 08
0037h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003bh vpsrlq xmm4,xmm4,8            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 08
0040h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0044h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0048h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
004ch vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0050h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x08,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x08,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly(N16 n, Vector128<ulong> x)
; location: [7FFDDB049650h, 7FFDDB0496ABh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0022h vmovaps xmm2,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d1
0026h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
002ah vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002eh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0032h vpsllq xmm3,xmm3,10h          ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,10h:imm8] encoding(VEX, 5 bytes) = c5 e1 73 f3 10
0037h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003bh vpsrlq xmm4,xmm4,10h          ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,10h:imm8] encoding(VEX, 5 bytes) = c5 d9 73 d4 10
0040h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0044h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0048h vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
004ch vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0050h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF8,0x28,0xD8,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x10,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x10,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vbutterfly(N1 n, Vector256<byte> x)
; location: [7FFDDB0496D0h, 7FFDDB049950h]
0000h sub rsp,0D8h                  ; SUB(Sub_rm64_imm32) [RSP,d8h:imm64]                  encoding(7 bytes) = 48 81 ec d8 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+0C0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 c0 00 00 00
0013h vmovaps [rsp+0B0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 b0 00 00 00
001ch vmovaps [rsp+0A0h],xmm8       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 78 29 84 24 a0 00 00 00
0025h vmovaps [rsp+90h],xmm9        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 78 29 8c 24 90 00 00 00
002eh mov dword ptr [rsp+8Ch],66h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(11 bytes) = c7 84 24 8c 00 00 00 66 00 00 00
0039h lea rax,[rsp+8Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 8c 00 00 00
0041h vpbroadcastb ymm0,byte ptr [rsp+8Ch]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 7d 78 84 24 8c 00 00 00
004bh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0050h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0054h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0058h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
005ch vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0060h vextractf128 xmm4,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 dc 00
0066h vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
006bh vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
0071h vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0076h vpsllw ymm4,ymm4,1            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 f4 01
007bh vpsllw ymm3,ymm3,1            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 01
0080h mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
008ah vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
008eh vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
0092h vmovupd [rsp+60h],ymm5        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 6 bytes) = c5 fd 11 6c 24 60
0098h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
009dh vpshufb ymm3,ymm3,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6] encoding(VEX, 5 bytes) = c4 e2 65 00 de
00a2h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
00ach vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00b0h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
00b4h vmovupd [rsp+40h],ymm5        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 6 bytes) = c5 fd 11 6c 24 40
00bah vmovaps ymm5,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 ee
00beh mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
00c8h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
00cch vpaddb ymm7,ymm5,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM5,YMM7]  encoding(VEX, 4 bytes) = c5 d5 fc ff
00d0h vpshufb ymm7,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM7,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 ff
00d5h vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
00dbh mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
00e5h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
00e9h vpaddb ymm5,ymm5,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM8]  encoding(VEX, 5 bytes) = c4 c1 55 fc e8
00eeh vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
00f3h vpor ymm4,ymm7,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM7,YMM4]      encoding(VEX, 4 bytes) = c5 c5 eb e4
00f7h mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
0101h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0105h vpaddb ymm5,ymm6,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM6,YMM5]  encoding(VEX, 4 bytes) = c5 cd fc ed
0109h vpshufb ymm5,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 ed
010eh vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
0114h mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
011eh vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0122h vpaddb ymm6,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc f7
0126h vpshufb ymm3,ymm3,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6] encoding(VEX, 5 bytes) = c4 e2 65 00 de
012bh vpor ymm3,ymm5,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM5,YMM3]      encoding(VEX, 4 bytes) = c5 d5 eb db
012fh vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0135h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
013bh vxorps ymm5,ymm5,ymm5         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM5,YMM5,YMM5]  encoding(VEX, 4 bytes) = c5 d4 57 ed
013fh vinserti128 ymm4,ymm5,xmm4,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 00
0145h vinserti128 ymm3,ymm4,xmm3,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM3,YMM4,XMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 38 db 01
014bh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
014fh vextractf128 xmm5,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e5 00
0155h vpmovzxbw ymm5,xmm5           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 30 ed
015ah vextractf128 xmm4,ymm4,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 01
0160h vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
0165h vpsrlw ymm5,ymm5,1            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM5,YMM5,1h:imm8]  encoding(VEX, 5 bytes) = c5 d5 71 d5 01
016ah vpsrlw ymm4,ymm4,1            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 01
016fh mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
0179h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
017dh vmovaps ymm7,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM7,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 fe
0181h vmovupd [rsp+20h],ymm6        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM6] encoding(VEX, 6 bytes) = c5 fd 11 74 24 20
0187h vpshufb ymm5,ymm5,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7] encoding(VEX, 5 bytes) = c4 e2 55 00 ef
018ch vpshufb ymm4,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 e7
0191h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
019bh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
019fh vmovaps ymm7,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM7,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 fe
01a3h vmovupd [rsp],ymm6            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM6] encoding(VEX, 5 bytes) = c5 fd 11 34 24
01a8h vmovaps ymm6,ymm7             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM7]         encoding(VEX, 4 bytes) = c5 fc 28 f7
01ach mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
01b6h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
01bah vpaddb ymm8,ymm6,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM8,YMM6,YMM8]  encoding(VEX, 5 bytes) = c4 41 4d fc c0
01bfh vpshufb ymm8,ymm5,ymm8        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM8,YMM5,YMM8] encoding(VEX, 5 bytes) = c4 42 55 00 c0
01c4h vperm2i128 ymm5,ymm5,ymm5,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM5,YMM5,YMM5,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 46 ed 03
01cah mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
01d4h vlddqu ymm9,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM9,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 08
01d8h vpaddb ymm6,ymm6,ymm9         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM9]  encoding(VEX, 5 bytes) = c4 c1 4d fc f1
01ddh vpshufb ymm5,ymm5,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM6] encoding(VEX, 5 bytes) = c4 e2 55 00 ee
01e2h vpor ymm5,ymm8,ymm5           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM5,YMM8,YMM5]      encoding(VEX, 4 bytes) = c5 bd eb ed
01e6h mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
01f0h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
01f4h vpaddb ymm6,ymm7,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM7,YMM6]  encoding(VEX, 4 bytes) = c5 c5 fc f6
01f8h vpshufb ymm6,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM6,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 f6
01fdh vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
0203h mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
020dh vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
0211h vpaddb ymm7,ymm7,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM7,YMM8]  encoding(VEX, 5 bytes) = c4 c1 45 fc f8
0216h vpshufb ymm4,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 e7
021bh vpor ymm4,ymm6,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM6,YMM4]      encoding(VEX, 4 bytes) = c5 cd eb e4
021fh vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
0225h vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
022bh vxorps ymm6,ymm6,ymm6         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM6,YMM6,YMM6]  encoding(VEX, 4 bytes) = c5 cc 57 f6
022fh vinserti128 ymm5,ymm6,xmm5,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM5,YMM6,XMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 4d 38 ed 00
0235h vinserti128 ymm4,ymm5,xmm4,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 01
023bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
023fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0243h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0247h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
024bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
024fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0252h vmovaps xmm6,[rsp+0C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 c0 00 00 00
025bh vmovaps xmm7,[rsp+0B0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 b0 00 00 00
0264h vmovaps xmm8,[rsp+0A0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM8,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 84 24 a0 00 00 00
026dh vmovaps xmm9,[rsp+90h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM9,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 8c 24 90 00 00 00
0276h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0279h add rsp,0D8h                  ; ADD(Add_rm64_imm32) [RSP,d8h:imm64]                  encoding(7 bytes) = 48 81 c4 d8 00 00 00
0280h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[641]{0x48,0x81,0xEC,0xD8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xB0,0x00,0x00,0x00,0xC5,0x78,0x29,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0x78,0x29,0x8C,0x24,0x90,0x00,0x00,0x00,0xC7,0x84,0x24,0x8C,0x00,0x00,0x00,0x66,0x00,0x00,0x00,0x48,0x8D,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xE2,0x7D,0x78,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC4,0xE3,0x7D,0x19,0xDC,0x00,0xC4,0xE2,0x7D,0x30,0xE4,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x30,0xDB,0xC5,0xDD,0x71,0xF4,0x01,0xC5,0xE5,0x71,0xF3,0x01,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x6C,0x24,0x60,0xC4,0xE2,0x5D,0x00,0xE6,0xC4,0xE2,0x65,0x00,0xDE,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x6C,0x24,0x40,0xC5,0xFC,0x28,0xEE,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xD5,0xFC,0xFF,0xC4,0xE2,0x5D,0x00,0xFF,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x55,0xFC,0xE8,0xC4,0xE2,0x5D,0x00,0xE5,0xC5,0xC5,0xEB,0xE4,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xCD,0xFC,0xED,0xC4,0xE2,0x65,0x00,0xED,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xF7,0xC4,0xE2,0x65,0x00,0xDE,0xC5,0xD5,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xD4,0x57,0xED,0xC4,0xE3,0x55,0x38,0xE4,0x00,0xC4,0xE3,0x5D,0x38,0xDB,0x01,0xC5,0xFC,0x28,0xE2,0xC4,0xE3,0x7D,0x19,0xE5,0x00,0xC4,0xE2,0x7D,0x30,0xED,0xC4,0xE3,0x7D,0x19,0xE4,0x01,0xC4,0xE2,0x7D,0x30,0xE4,0xC5,0xD5,0x71,0xD5,0x01,0xC5,0xDD,0x71,0xD4,0x01,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xFC,0x28,0xFE,0xC5,0xFD,0x11,0x74,0x24,0x20,0xC4,0xE2,0x55,0x00,0xEF,0xC4,0xE2,0x5D,0x00,0xE7,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xFC,0x28,0xFE,0xC5,0xFD,0x11,0x34,0x24,0xC5,0xFC,0x28,0xF7,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0x41,0x4D,0xFC,0xC0,0xC4,0x42,0x55,0x00,0xC0,0xC4,0xE3,0x55,0x46,0xED,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x08,0xC4,0xC1,0x4D,0xFC,0xF1,0xC4,0xE2,0x55,0x00,0xEE,0xC5,0xBD,0xEB,0xED,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xC5,0xFC,0xF6,0xC4,0xE2,0x5D,0x00,0xF6,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x45,0xFC,0xF8,0xC4,0xE2,0x5D,0x00,0xE7,0xC5,0xCD,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xED,0x00,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xCC,0x57,0xF6,0xC4,0xE3,0x4D,0x38,0xED,0x00,0xC4,0xE3,0x55,0x38,0xE4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xB0,0x00,0x00,0x00,0xC5,0x78,0x28,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0x78,0x28,0x8C,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xD8,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly(N1 n, Vector256<ushort> x)
; location: [7FFDDB0499B0h, 7FFDDB049A0Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw ymm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpsllw ymm3,ymm3,1            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 01
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrlw ymm4,ymm4,1            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 01
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x71,0xF3,0x01,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x71,0xD4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly(N1 n, Vector256<uint> x)
; location: [7FFDDB049A30h, 7FFDDB049A8Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpslld ymm3,ymm3,1            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 01
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrld ymm4,ymm4,1            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 01
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x01,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly(N1 n, Vector256<ulong> x)
; location: [7FFDDB049AB0h, 7FFDDB049B0Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0022h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0026h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
002ah vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0032h vpsllq ymm3,ymm3,1            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 01
0037h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003bh vpsrlq ymm4,ymm4,1            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 01
0040h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0044h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0048h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
004ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0050h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[95]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x01,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vbutterfly(N2 n, Vector256<byte> x)
; location: [7FFDDB049B30h, 7FFDDB049DB0h]
0000h sub rsp,0D8h                  ; SUB(Sub_rm64_imm32) [RSP,d8h:imm64]                  encoding(7 bytes) = 48 81 ec d8 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+0C0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 c0 00 00 00
0013h vmovaps [rsp+0B0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 b0 00 00 00
001ch vmovaps [rsp+0A0h],xmm8       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 78 29 84 24 a0 00 00 00
0025h vmovaps [rsp+90h],xmm9        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 78 29 8c 24 90 00 00 00
002eh mov dword ptr [rsp+8Ch],3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(11 bytes) = c7 84 24 8c 00 00 00 3c 00 00 00
0039h lea rax,[rsp+8Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 8c 00 00 00
0041h vpbroadcastb ymm0,byte ptr [rsp+8Ch]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 7d 78 84 24 8c 00 00 00
004bh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0050h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0054h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0058h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
005ch vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0060h vextractf128 xmm4,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 dc 00
0066h vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
006bh vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
0071h vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0076h vpsllw ymm4,ymm4,2            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 f4 02
007bh vpsllw ymm3,ymm3,2            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 02
0080h mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
008ah vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
008eh vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
0092h vmovupd [rsp+60h],ymm5        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 6 bytes) = c5 fd 11 6c 24 60
0098h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
009dh vpshufb ymm3,ymm3,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6] encoding(VEX, 5 bytes) = c4 e2 65 00 de
00a2h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
00ach vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00b0h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
00b4h vmovupd [rsp+40h],ymm5        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM5] encoding(VEX, 6 bytes) = c5 fd 11 6c 24 40
00bah vmovaps ymm5,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 ee
00beh mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
00c8h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
00cch vpaddb ymm7,ymm5,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM5,YMM7]  encoding(VEX, 4 bytes) = c5 d5 fc ff
00d0h vpshufb ymm7,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM7,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 ff
00d5h vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
00dbh mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
00e5h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
00e9h vpaddb ymm5,ymm5,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM8]  encoding(VEX, 5 bytes) = c4 c1 55 fc e8
00eeh vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
00f3h vpor ymm4,ymm7,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM7,YMM4]      encoding(VEX, 4 bytes) = c5 c5 eb e4
00f7h mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
0101h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0105h vpaddb ymm5,ymm6,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM6,YMM5]  encoding(VEX, 4 bytes) = c5 cd fc ed
0109h vpshufb ymm5,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 ed
010eh vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
0114h mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
011eh vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0122h vpaddb ymm6,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc f7
0126h vpshufb ymm3,ymm3,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6] encoding(VEX, 5 bytes) = c4 e2 65 00 de
012bh vpor ymm3,ymm5,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM5,YMM3]      encoding(VEX, 4 bytes) = c5 d5 eb db
012fh vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0135h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
013bh vxorps ymm5,ymm5,ymm5         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM5,YMM5,YMM5]  encoding(VEX, 4 bytes) = c5 d4 57 ed
013fh vinserti128 ymm4,ymm5,xmm4,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 00
0145h vinserti128 ymm3,ymm4,xmm3,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM3,YMM4,XMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 38 db 01
014bh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
014fh vextractf128 xmm5,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e5 00
0155h vpmovzxbw ymm5,xmm5           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 30 ed
015ah vextractf128 xmm4,ymm4,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 01
0160h vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
0165h vpsrlw ymm5,ymm5,2            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM5,YMM5,2h:imm8]  encoding(VEX, 5 bytes) = c5 d5 71 d5 02
016ah vpsrlw ymm4,ymm4,2            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 02
016fh mov rax,241F8F98B11h          ; MOV(Mov_r64_imm64) [RAX,241f8f98b11h:imm64]          encoding(10 bytes) = 48 b8 11 8b f9 f8 41 02 00 00
0179h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
017dh vmovaps ymm7,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM7,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 fe
0181h vmovupd [rsp+20h],ymm6        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM6] encoding(VEX, 6 bytes) = c5 fd 11 74 24 20
0187h vpshufb ymm5,ymm5,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7] encoding(VEX, 5 bytes) = c4 e2 55 00 ef
018ch vpshufb ymm4,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 e7
0191h mov rax,241F8F989E1h          ; MOV(Mov_r64_imm64) [RAX,241f8f989e1h:imm64]          encoding(10 bytes) = 48 b8 e1 89 f9 f8 41 02 00 00
019bh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
019fh vmovaps ymm7,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM7,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 fe
01a3h vmovupd [rsp],ymm6            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM6] encoding(VEX, 5 bytes) = c5 fd 11 34 24
01a8h vmovaps ymm6,ymm7             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM7]         encoding(VEX, 4 bytes) = c5 fc 28 f7
01ach mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
01b6h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
01bah vpaddb ymm8,ymm6,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM8,YMM6,YMM8]  encoding(VEX, 5 bytes) = c4 41 4d fc c0
01bfh vpshufb ymm8,ymm5,ymm8        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM8,YMM5,YMM8] encoding(VEX, 5 bytes) = c4 42 55 00 c0
01c4h vperm2i128 ymm5,ymm5,ymm5,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM5,YMM5,YMM5,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 46 ed 03
01cah mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
01d4h vlddqu ymm9,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM9,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 08
01d8h vpaddb ymm6,ymm6,ymm9         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM9]  encoding(VEX, 5 bytes) = c4 c1 4d fc f1
01ddh vpshufb ymm5,ymm5,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM6] encoding(VEX, 5 bytes) = c4 e2 55 00 ee
01e2h vpor ymm5,ymm8,ymm5           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM5,YMM8,YMM5]      encoding(VEX, 4 bytes) = c5 bd eb ed
01e6h mov rax,241F8F98AD1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98ad1h:imm64]          encoding(10 bytes) = 48 b8 d1 8a f9 f8 41 02 00 00
01f0h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
01f4h vpaddb ymm6,ymm7,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM7,YMM6]  encoding(VEX, 4 bytes) = c5 c5 fc f6
01f8h vpshufb ymm6,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM6,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 f6
01fdh vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
0203h mov rax,241F8F98CF1h          ; MOV(Mov_r64_imm64) [RAX,241f8f98cf1h:imm64]          encoding(10 bytes) = 48 b8 f1 8c f9 f8 41 02 00 00
020dh vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
0211h vpaddb ymm7,ymm7,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM7,YMM8]  encoding(VEX, 5 bytes) = c4 c1 45 fc f8
0216h vpshufb ymm4,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 e7
021bh vpor ymm4,ymm6,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM6,YMM4]      encoding(VEX, 4 bytes) = c5 cd eb e4
021fh vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
0225h vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
022bh vxorps ymm6,ymm6,ymm6         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM6,YMM6,YMM6]  encoding(VEX, 4 bytes) = c5 cc 57 f6
022fh vinserti128 ymm5,ymm6,xmm5,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM5,YMM6,XMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 4d 38 ed 00
0235h vinserti128 ymm4,ymm5,xmm4,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 01
023bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
023fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0243h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0247h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
024bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
024fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0252h vmovaps xmm6,[rsp+0C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 c0 00 00 00
025bh vmovaps xmm7,[rsp+0B0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 b0 00 00 00
0264h vmovaps xmm8,[rsp+0A0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM8,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 84 24 a0 00 00 00
026dh vmovaps xmm9,[rsp+90h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM9,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 8c 24 90 00 00 00
0276h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0279h add rsp,0D8h                  ; ADD(Add_rm64_imm32) [RSP,d8h:imm64]                  encoding(7 bytes) = 48 81 c4 d8 00 00 00
0280h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[641]{0x48,0x81,0xEC,0xD8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xB0,0x00,0x00,0x00,0xC5,0x78,0x29,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0x78,0x29,0x8C,0x24,0x90,0x00,0x00,0x00,0xC7,0x84,0x24,0x8C,0x00,0x00,0x00,0x3C,0x00,0x00,0x00,0x48,0x8D,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xE2,0x7D,0x78,0x84,0x24,0x8C,0x00,0x00,0x00,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC4,0xE3,0x7D,0x19,0xDC,0x00,0xC4,0xE2,0x7D,0x30,0xE4,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x30,0xDB,0xC5,0xDD,0x71,0xF4,0x02,0xC5,0xE5,0x71,0xF3,0x02,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x6C,0x24,0x60,0xC4,0xE2,0x5D,0x00,0xE6,0xC4,0xE2,0x65,0x00,0xDE,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0xC5,0xFD,0x11,0x6C,0x24,0x40,0xC5,0xFC,0x28,0xEE,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xD5,0xFC,0xFF,0xC4,0xE2,0x5D,0x00,0xFF,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x55,0xFC,0xE8,0xC4,0xE2,0x5D,0x00,0xE5,0xC5,0xC5,0xEB,0xE4,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xCD,0xFC,0xED,0xC4,0xE2,0x65,0x00,0xED,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xF7,0xC4,0xE2,0x65,0x00,0xDE,0xC5,0xD5,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xD4,0x57,0xED,0xC4,0xE3,0x55,0x38,0xE4,0x00,0xC4,0xE3,0x5D,0x38,0xDB,0x01,0xC5,0xFC,0x28,0xE2,0xC4,0xE3,0x7D,0x19,0xE5,0x00,0xC4,0xE2,0x7D,0x30,0xED,0xC4,0xE3,0x7D,0x19,0xE4,0x01,0xC4,0xE2,0x7D,0x30,0xE4,0xC5,0xD5,0x71,0xD5,0x02,0xC5,0xDD,0x71,0xD4,0x02,0x48,0xB8,0x11,0x8B,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xFC,0x28,0xFE,0xC5,0xFD,0x11,0x74,0x24,0x20,0xC4,0xE2,0x55,0x00,0xEF,0xC4,0xE2,0x5D,0x00,0xE7,0x48,0xB8,0xE1,0x89,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xFC,0x28,0xFE,0xC5,0xFD,0x11,0x34,0x24,0xC5,0xFC,0x28,0xF7,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0x41,0x4D,0xFC,0xC0,0xC4,0x42,0x55,0x00,0xC0,0xC4,0xE3,0x55,0x46,0xED,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x08,0xC4,0xC1,0x4D,0xFC,0xF1,0xC4,0xE2,0x55,0x00,0xEE,0xC5,0xBD,0xEB,0xED,0x48,0xB8,0xD1,0x8A,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xC5,0xFC,0xF6,0xC4,0xE2,0x5D,0x00,0xF6,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF1,0x8C,0xF9,0xF8,0x41,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x45,0xFC,0xF8,0xC4,0xE2,0x5D,0x00,0xE7,0xC5,0xCD,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xED,0x00,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xCC,0x57,0xF6,0xC4,0xE3,0x4D,0x38,0xED,0x00,0xC4,0xE3,0x55,0x38,0xE4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xB0,0x00,0x00,0x00,0xC5,0x78,0x28,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0x78,0x28,0x8C,0x24,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xD8,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly(N2 n, Vector256<ushort> x)
; location: [7FFDDB049E10h, 7FFDDB049E6Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw ymm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpsllw ymm3,ymm3,2            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 02
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrlw ymm4,ymm4,2            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 02
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x71,0xF3,0x02,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x71,0xD4,0x02,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly(N2 n, Vector256<uint> x)
; location: [7FFDDB049E90h, 7FFDDB049EEAh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpslld ymm3,ymm3,2            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 02
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrld ymm4,ymm4,2            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 02
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x02,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x02,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly(N2 n, Vector256<ulong> x)
; location: [7FFDDB049F10h, 7FFDDB049F6Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0022h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0026h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
002ah vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0032h vpsllq ymm3,ymm3,2            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 02
0037h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003bh vpsrlq ymm4,ymm4,2            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 02
0040h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0044h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0048h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
004ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0050h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[95]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x02,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x02,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly(N4 n, Vector256<ushort> x)
; location: [7FFDDB049F90h, 7FFDDB049FEAh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw ymm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpsllw ymm3,ymm3,4            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 04
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrlw ymm4,ymm4,4            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 04
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x71,0xF3,0x04,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x71,0xD4,0x04,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly(N4 n, Vector256<uint> x)
; location: [7FFDDB04A010h, 7FFDDB04A06Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpslld ymm3,ymm3,4            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 04
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrld ymm4,ymm4,4            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 04
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x04,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x04,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly(N4 n, Vector256<ulong> x)
; location: [7FFDDB04A090h, 7FFDDB04A0EEh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0022h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0026h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
002ah vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0032h vpsllq ymm3,ymm3,4            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 04
0037h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003bh vpsrlq ymm4,ymm4,4            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 04
0040h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0044h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0048h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
004ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0050h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[95]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x04,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x04,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly(N8 n, Vector256<uint> x)
; location: [7FFDDB04A110h, 7FFDDB04A16Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001eh vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0022h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0026h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002ah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002eh vpslld ymm3,ymm3,8            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 08
0033h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0037h vpsrld ymm4,ymm4,8            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 08
003ch vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0040h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0044h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0048h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x08,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x08,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly(N8 n, Vector256<ulong> x)
; location: [7FFDDB04A190h, 7FFDDB04A1EEh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0022h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0026h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
002ah vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0032h vpsllq ymm3,ymm3,8            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 08
0037h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003bh vpsrlq ymm4,ymm4,8            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 08
0040h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0044h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0048h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
004ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0050h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[95]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x08,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x08,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly(N16 n, Vector256<ulong> x)
; location: [7FFDDB04A210h, 7FFDDB04A26Eh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0022h vmovaps ymm2,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d1
0026h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
002ah vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0032h vpsllq ymm3,ymm3,10h          ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,10h:imm8] encoding(VEX, 5 bytes) = c5 e5 73 f3 10
0037h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003bh vpsrlq ymm4,ymm4,10h          ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,10h:imm8] encoding(VEX, 5 bytes) = c5 dd 73 d4 10
0040h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0044h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0048h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
004ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0050h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterflyBytes => new byte[95]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFC,0x28,0xD1,0xC5,0xFC,0x28,0xD8,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x10,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x10,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> v66(N128 n)
; location: [7FFDDB04A290h, 7FFDDB04A2B4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],66h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(8 bytes) = c7 44 24 04 66 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v66Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> v6666(N128 n)
; location: [7FFDDB04A2D0h, 7FFDDB04A2F4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw xmm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v6666Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> v66666666(N128 n)
; location: [7FFDDB04A310h, 7FFDDB04A334h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v66666666Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> v6666666666666666(N128 n)
; location: [7FFDDB04A350h, 7FFDDB04A378h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v6666666666666666Bytes => new byte[41]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> v3C(N128 n)
; location: [7FFDDB04A390h, 7FFDDB04A3B4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3Ch     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(8 bytes) = c7 44 24 04 3c 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3CBytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> v3C3C(N128 n)
; location: [7FFDDB04A3D0h, 7FFDDB04A3F4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw xmm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3C3CBytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> v3C3C3C3C(N128 n)
; location: [7FFDDB04A410h, 7FFDDB04A434h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3C3C3C3CBytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> v3C3C3C3C3C3C3C3C(N128 n)
; location: [7FFDDB04A450h, 7FFDDB04A478h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3C3C3C3C3C3C3C3CBytes => new byte[41]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> v0FF0(N128 n)
; location: [7FFDDB04A490h, 7FFDDB04A4B4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw xmm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0FF0Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> v0FF00FF0(N128 n)
; location: [7FFDDB04A4D0h, 7FFDDB04A4F4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0FF00FF0Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> v0FF00FF00FF00FF0(N128 n)
; location: [7FFDDB04A510h, 7FFDDB04A538h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0FF00FF00FF00FF0Bytes => new byte[41]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> v00FFFF00(N128 n)
; location: [7FFDDB04A550h, 7FFDDB04A574h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd xmm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v00FFFF00Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> v00FFFF0000FFFF00(N128 n)
; location: [7FFDDB04A590h, 7FFDDB04A5B8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v00FFFF0000FFFF00Bytes => new byte[41]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> v0000FFFFFFFF0000(N128 n)
; location: [7FFDDB04A5D0h, 7FFDDB04A5F8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq xmm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 04 24
001dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0000FFFFFFFF0000Bytes => new byte[41]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x04,0x24,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> v66(N256 n)
; location: [7FFDDB04A610h, 7FFDDB04A637h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],66h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(8 bytes) = c7 44 24 04 66 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb ymm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v66Bytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> v6666(N256 n)
; location: [7FFDDB04A650h, 7FFDDB04A677h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw ymm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v6666Bytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> v66666666(N256 n)
; location: [7FFDDB04A690h, 7FFDDB04A6B7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v66666666Bytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> v6666666666666666(N256 n)
; location: [7FFDDB04A6D0h, 7FFDDB04A6FBh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v6666666666666666Bytes => new byte[44]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> v3C(N256 n)
; location: [7FFDDB04A720h, 7FFDDB04A747h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3Ch     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(8 bytes) = c7 44 24 04 3c 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb ymm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3CBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> v3C3C(N256 n)
; location: [7FFDDB04A760h, 7FFDDB04A787h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw ymm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3C3CBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> v3C3C3C3C(N256 n)
; location: [7FFDDB04A7A0h, 7FFDDB04A7C7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3C3C3C3CBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> v3C3C3C3C3C3C3C3C(N256 n)
; location: [7FFDDB04A7E0h, 7FFDDB04A80Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v3C3C3C3C3C3C3C3CBytes => new byte[44]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> v0FF0(N256 n)
; location: [7FFDDB04A830h, 7FFDDB04A857h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastw ymm0,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM0,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0FF0Bytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> v0FF00FF0(N256 n)
; location: [7FFDDB04A870h, 7FFDDB04A897h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0FF00FF0Bytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> v0FF00FF00FF00FF0(N256 n)
; location: [7FFDDB04A8B0h, 7FFDDB04A8DBh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0FF00FF00FF00FF0Bytes => new byte[44]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> v00FFFF00(N256 n)
; location: [7FFDDB04A900h, 7FFDDB04A927h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
0019h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v00FFFF00Bytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> v00FFFF0000FFFF00(N256 n)
; location: [7FFDDB04A940h, 7FFDDB04A96Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v00FFFF0000FFFF00Bytes => new byte[44]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> v0000FFFFFFFF0000(N256 n)
; location: [7FFDDB04A990h, 7FFDDB04A9BBh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0013h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0017h vpbroadcastq ymm0,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM0,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 04 24
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> v0000FFFFFFFF0000Bytes => new byte[44]{0x50,0xC5,0xF8,0x77,0x90,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x04,0x24,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte between(sbyte src, byte i0, byte i1)
; location: [7FFDDB04A9E0h, 7FFDDB04AA08h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte between(byte src, byte i0, byte i1)
; location: [7FFDDB04AA20h, 7FFDDB04AA46h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short between(short src, byte i0, byte i1)
; location: [7FFDDB04AA60h, 7FFDDB04AA88h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort between(ushort src, byte i0, byte i1)
; location: [7FFDDB04AAA0h, 7FFDDB04AAC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint between(uint src, byte i0, byte i1)
; location: [7FFDDB04AAE0h, 7FFDDB04AB00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int between(int src, byte i0, byte i1)
; location: [7FFDDB04AB20h, 7FFDDB04AB40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong between(ulong src, byte i0, byte i1)
; location: [7FFDDB04AB60h, 7FFDDB04AB80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long between(long src, byte i0, byte i1)
; location: [7FFDDB04ABA0h, 7FFDDB04ABC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float between(float src, byte i0, byte i1)
; location: [7FFDDB04ABE0h, 7FFDDB04AC16h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 04
000fh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0013h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0016h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0018h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
001ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001dh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0020h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
002ah mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(3 bytes) = 89 04 24
002dh vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xD2,0x2B,0xCA,0xFF,0xC1,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double between(double src, byte i0, byte i1)
; location: [7FFDDB04AC30h, 7FFDDB04AC6Ch]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 10
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
001bh inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
001dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0020h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0023h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
002dh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0032h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0038h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[61]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xD2,0x2B,0xCA,0xFF,0xC1,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDDB04AC90h, 7FFDDB04ACD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,:sr)]        encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),R11L]            encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,:sr)]        encoding(4 bytes) = 48 0f be 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h movsx r8,r10b                 ; MOVSX(Movsx_r64_rm8) [R8,R10L]                       encoding(4 bytes) = 4d 0f be c2
0034h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0039h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x4D,0x0F,0xBE,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDDB04ACF0h, 7FFDDB04AD2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,:sr)]       encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),R11L]            encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0025h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0029h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002fh movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
0033h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDDB04AD40h, 7FFDDB04AD82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,:sr)]      encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,:sr)]      encoding(4 bytes) = 48 0f bf 08
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0027h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002bh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0031h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
0035h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
003ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDB04ADA0h, 7FFDDB04ADE1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,:sr)]     encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,:sr)]      encoding(3 bytes) = 0f b7 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
0034h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0039h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDDB04AE00h, 7FFDDB04AE36h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
002ah bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
002fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDB04AE50h, 7FFDDB04AE86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
002ah bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
002fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDB04AEA0h, 7FFDDB04AEDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
002ch bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDB04AEF0h, 7FFDDB04AF2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h movzx r8d,r10b                ; MOVZX(Movzx_r32_rm8) [R8D,R10L]                      encoding(4 bytes) = 45 0f b6 c2
002ch bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB6,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB6,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDDB04AF40h, 7FFDDB04AF85h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,:sr)]        encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),R11L]            encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,:sr)]        encoding(4 bytes) = 48 0f be 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h movsx r8,r10w                 ; MOVSX(Movsx_r64_rm16) [R8,R10W]                      encoding(4 bytes) = 4d 0f bf c2
0034h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0041h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0043h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x4D,0x0F,0xBF,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDDB04AFA0h, 7FFDDB04AFE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,:sr)]       encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),R11L]            encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0025h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0029h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002fh movsx r8,r10w                 ; MOVSX(Movsx_r64_rm16) [R8,R10W]                      encoding(4 bytes) = 4d 0f bf c2
0033h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0038h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0041h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x4D,0x0F,0xBF,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x48,0x0F,0xBF,0xD2,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDDB04B000h, 7FFDDB04B043h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,:sr)]      encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,:sr)]      encoding(4 bytes) = 48 0f bf 08
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0027h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002bh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0031h movsx r8,r10w                 ; MOVSX(Movsx_r64_rm16) [R8,R10W]                      encoding(4 bytes) = 4d 0f bf c2
0035h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
003ah movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0040h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x4D,0x0F,0xBF,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDB04B060h, 7FFDDB04B0A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,:sr)]     encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,:sr)]      encoding(3 bytes) = 0f b7 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h movsx r8,r10w                 ; MOVSX(Movsx_r64_rm16) [R8,R10W]                      encoding(4 bytes) = 4d 0f bf c2
0034h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0040h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0042h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x4D,0x0F,0xBF,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x48,0x0F,0xBF,0xD2,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDB04B0C0h, 7FFDDB04B101h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,:sr)]     encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,:sr)]      encoding(3 bytes) = 0f b7 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h movzx r8d,r10w                ; MOVZX(Movzx_r32_rm16) [R8D,R10W]                     encoding(4 bytes) = 45 0f b7 c2
0034h bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0039h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB7,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDB04B120h, 7FFDDB04B156h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h movzx r8d,r10w                ; MOVZX(Movzx_r32_rm16) [R8D,R10W]                     encoding(4 bytes) = 45 0f b7 c2
002ah bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB7,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDB04B170h, 7FFDDB04B1AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h movzx r8d,r10w                ; MOVZX(Movzx_r32_rm16) [R8D,R10W]                     encoding(4 bytes) = 45 0f b7 c2
002ch bextr edx,r8d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R8D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x45,0x0F,0xB7,0xC2,0xC4,0xC2,0x68,0xF7,0xD0,0x0F,0xB7,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDDB04B1C0h, 7FFDDB04B1EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h bextr edx,r10d,edx            ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R10D,EDX]         encoding(VEX, 5 bytes) = c4 c2 68 f7 d2
002bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDB04B200h, 7FFDDB04B236h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr edx,r10d,edx            ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R10D,EDX]         encoding(VEX, 5 bytes) = c4 c2 68 f7 d2
002dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD2,0x48,0x63,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDB04B250h, 7FFDDB04B285h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr edx,r10d,edx            ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R10D,EDX]         encoding(VEX, 5 bytes) = c4 c2 68 f7 d2
002dh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
002fh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0032h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[54]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD2,0x8B,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDB04B2A0h, 7FFDDB04B2CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h bextr edx,r10d,edx            ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R10D,EDX]         encoding(VEX, 5 bytes) = c4 c2 68 f7 d2
002bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(uint src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDB04B2E0h, 7FFDDB04B315h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr edx,r10d,edx            ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R10D,EDX]         encoding(VEX, 5 bytes) = c4 c2 68 f7 d2
002dh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
002fh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0032h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[54]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD2,0x8B,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDB04B330h, 7FFDDB04B363h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
002dh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0030h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDDB04B380h, 7FFDDB04B3BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,:sr)]        encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),R11L]            encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,:sr)]        encoding(4 bytes) = 48 0f be 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
0035h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0039h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[62]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDDB04B3D0h, 7FFDDB04B40Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,:sr)]       encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),R11L]            encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0025h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0029h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002fh bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
0034h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0037h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0039h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDDB04B420h, 7FFDDB04B45Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,:sr)]      encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,:sr)]      encoding(4 bytes) = 48 0f bf 08
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0027h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002bh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0031h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
0036h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003ah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003ch mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDDB04B470h, 7FFDDB04B4ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,:sr)]     encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),R11W]         encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,:sr)]      encoding(3 bytes) = 0f b7 08
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0026h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ah or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0030h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
0035h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0038h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003ah mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),DX]           encoding(3 bytes) = 66 89 10
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[62]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDDB04B4C0h, 7FFDDB04B4EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
002bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDDB04B500h, 7FFDDB04B52Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,:sr),CL]            encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 08
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ch shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0020h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
002bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002dh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDDB04B540h, 7FFDDB04B573h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
002dh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0030h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDDB04B590h, 7FFDDB04B5C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,:sr),CL]            encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rdx,r10,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R10,RDX]          encoding(VEX, 5 bytes) = c4 c2 e8 f7 d2
002dh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0030h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float bitmap(float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
; location: [7FFDDB04B5E0h, 7FFDDB04B644h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
000ch vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0012h mov ecx,[rsp+14h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 14
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001dh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0021h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0024h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0027h bextr edx,ecx,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,ECX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 d1
002ch movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0030h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0032h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0036h vcvtsi2ss xmm0,xmm0,edx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fa 2a c2
003ah vmovss xmm1,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 10 08
003eh vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0044h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 10
0048h vmovss dword ptr [rsp+0Ch],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 0c
004eh or edx,[rsp+0Ch]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 54 24 0c
0052h mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 08
0056h vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
005ch vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0060h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[101]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x40,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x4C,0x24,0x14,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC2,0xC5,0xFA,0x10,0x08,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x8B,0x54,0x24,0x10,0xC5,0xFA,0x11,0x44,0x24,0x0C,0x0B,0x54,0x24,0x0C,0x89,0x54,0x24,0x08,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double bitmap(double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
; location: [7FFDDB04B670h, 7FFDDB04B6DAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 50
000ch vmovsd qword ptr [rsp+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 20
0012h mov rcx,[rsp+20h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 20
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001eh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0022h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rdx,rcx,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RCX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 d1
002dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0031h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0034h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0038h vcvtsi2sd xmm0,xmm0,rdx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RDX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c2
003dh vmovsd xmm1,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb 10 08
0041h vmovsd qword ptr [rsp+18h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 18
0047h mov rdx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 18
004ch vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0052h or rdx,[rsp+10h]              ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]            encoding(5 bytes) = 48 0b 54 24 10
0057h mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 08
005ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0062h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0066h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[107]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x50,0xC5,0xFB,0x11,0x44,0x24,0x20,0x48,0x8B,0x4C,0x24,0x20,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC2,0xC5,0xFB,0x10,0x08,0xC5,0xFB,0x11,0x4C,0x24,0x18,0x48,0x8B,0x54,0x24,0x18,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x0B,0x54,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsi(byte src)
; location: [7FFDDB04B700h, 7FFDDB04B710h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsi(ushort src)
; location: [7FFDDB04B730h, 7FFDDB04B740h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsi(uint src)
; location: [7FFDDB04B760h, 7FFDDB04B76Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsi(ulong src)
; location: [7FFDDB04B780h, 7FFDDB04B78Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsic(byte src)
; location: [7FFDDB04B7A0h, 7FFDDB04B7B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000ch dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC8,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsic(ushort src)
; location: [7FFDDB04B7D0h, 7FFDDB04B7E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000ch dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC8,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsic(uint src)
; location: [7FFDDB04B800h, 7FFDDB04B80Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
000bh or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC9,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsic(ulong src)
; location: [7FFDDB04B820h, 7FFDDB04B831h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
000eh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC9,0x48,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk(byte src)
; location: [7FFDDB04B850h, 7FFDDB04B860h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk(ushort src)
; location: [7FFDDB04B880h, 7FFDDB04B890h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk(uint src)
; location: [7FFDDB04B8B0h, 7FFDDB04B8BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk(ulong src)
; location: [7FFDDB04B8D0h, 7FFDDB04B8DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsr(byte src)
; location: [7FFDDB04B8F0h, 7FFDDB04B900h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsr(ushort src)
; location: [7FFDDB04B920h, 7FFDDB04B930h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsr(uint src)
; location: [7FFDDB04B950h, 7FFDDB04B95Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr eax,ecx                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsr(ulong src)
; location: [7FFDDB04B970h, 7FFDDB04B97Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr rax,rcx                  ; BLSR(VEX_Blsr_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte butterfly(N1 n, byte x)
; location: [7FFDDB04B990h, 7FFDDB04B9BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000dh and edx,66h                   ; AND(And_rm32_imm8) [EDX,66h:imm32]                   encoding(3 bytes) = 83 e2 66
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0014h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0016h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0018h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h and edx,66h                   ; AND(And_rm32_imm8) [EDX,66h:imm32]                   encoding(3 bytes) = 83 e2 66
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x8B,0xD0,0x0F,0xB6,0xD2,0x83,0xE2,0x66,0x8B,0xCA,0xD1,0xE1,0x33,0xCA,0xD1,0xEA,0x33,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x83,0xE2,0x66,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly(N1 n, ushort x)
; location: [7FFDDB04B9D0h, 7FFDDB04BA01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000dh and edx,6666h                 ; AND(And_rm32_imm32) [EDX,6666h:imm32]                encoding(6 bytes) = 81 e2 66 66 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0017h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0019h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
001bh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0020h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0023h and edx,6666h                 ; AND(And_rm32_imm32) [EDX,6666h:imm32]                encoding(6 bytes) = 81 e2 66 66 00 00
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
002eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[50]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x8B,0xD0,0x0F,0xB7,0xD2,0x81,0xE2,0x66,0x66,0x00,0x00,0x8B,0xCA,0xD1,0xE1,0x33,0xCA,0xD1,0xEA,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0x66,0x66,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly(N1 n, uint x)
; location: [7FFDDB04BA20h, 7FFDDB04BA3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h and eax,66666666h             ; AND(And_EAX_imm32) [EAX,66666666h:imm32]             encoding(5 bytes) = 25 66 66 66 66
000ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000eh shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0010h xor ecx,eax                   ; XOR(Xor_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 33 c8
0012h shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0014h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0016h and eax,66666666h             ; AND(And_EAX_imm32) [EAX,66666666h:imm32]             encoding(5 bytes) = 25 66 66 66 66
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x25,0x66,0x66,0x66,0x66,0x8B,0xC8,0xD1,0xE1,0x33,0xC8,0xD1,0xE8,0x33,0xC1,0x25,0x66,0x66,0x66,0x66,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly(N1 n, ulong x)
; location: [7FFDDB04BA50h, 7FFDDB04BA84h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0012h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0015h shl rcx,1                     ; SHL(Shl_rm64_1) [RCX,1h:imm8]                        encoding(3 bytes) = 48 d1 e1
0018h xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
001bh shr rax,1                     ; SHR(Shr_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e8
001eh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0021h mov rcx,6666666666666666h     ; MOV(Mov_r64_imm64) [RCX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b9 66 66 66 66 66 66 66 66
002bh and rcx,rax                   ; AND(And_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 23 c8
002eh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0031h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x23,0xC2,0x48,0x8B,0xC8,0x48,0xD1,0xE1,0x48,0x33,0xC8,0x48,0xD1,0xE8,0x48,0x33,0xC1,0x48,0xB9,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x23,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte butterfly(N2 n, byte x)
; location: [7FFDDB04BAA0h, 7FFDDB04BACDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000dh and edx,3Ch                   ; AND(And_rm32_imm8) [EDX,3ch:imm32]                   encoding(3 bytes) = 83 e2 3c
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0015h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0017h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
001ah xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0022h and edx,3Ch                   ; AND(And_rm32_imm8) [EDX,3ch:imm32]                   encoding(3 bytes) = 83 e2 3c
0025h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0028h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x8B,0xD0,0x0F,0xB6,0xD2,0x83,0xE2,0x3C,0x8B,0xCA,0xC1,0xE1,0x02,0x33,0xCA,0xC1,0xEA,0x02,0x33,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x83,0xE2,0x3C,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly(N2 n, ushort x)
; location: [7FFDDB04BAE0h, 7FFDDB04BB13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000dh and edx,3C3Ch                 ; AND(And_rm32_imm32) [EDX,3c3ch:imm32]                encoding(6 bytes) = 81 e2 3c 3c 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0018h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
001ah shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
001dh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h and edx,3C3Ch                 ; AND(And_rm32_imm32) [EDX,3c3ch:imm32]                encoding(6 bytes) = 81 e2 3c 3c 00 00
002bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0030h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x8B,0xD0,0x0F,0xB7,0xD2,0x81,0xE2,0x3C,0x3C,0x00,0x00,0x8B,0xCA,0xC1,0xE1,0x02,0x33,0xCA,0xC1,0xEA,0x02,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0x3C,0x3C,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly(N2 n, uint x)
; location: [7FFDDB04BB30h, 7FFDDB04BB4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h and eax,3C3C3C3Ch             ; AND(And_EAX_imm32) [EAX,3c3c3c3ch:imm32]             encoding(5 bytes) = 25 3c 3c 3c 3c
000ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000eh shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0011h xor ecx,eax                   ; XOR(Xor_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 33 c8
0013h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0016h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0018h and eax,3C3C3C3Ch             ; AND(And_EAX_imm32) [EAX,3c3c3c3ch:imm32]             encoding(5 bytes) = 25 3c 3c 3c 3c
001dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x25,0x3C,0x3C,0x3C,0x3C,0x8B,0xC8,0xC1,0xE1,0x02,0x33,0xC8,0xC1,0xE8,0x02,0x33,0xC1,0x25,0x3C,0x3C,0x3C,0x3C,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly(N2 n, ulong x)
; location: [7FFDDB04BB60h, 7FFDDB04BB96h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0012h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0015h shl rcx,2                     ; SHL(Shl_rm64_imm8) [RCX,2h:imm8]                     encoding(4 bytes) = 48 c1 e1 02
0019h xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
001ch shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0020h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0023h mov rcx,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RCX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b9 3c 3c 3c 3c 3c 3c 3c 3c
002dh and rcx,rax                   ; AND(And_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 23 c8
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x23,0xC2,0x48,0x8B,0xC8,0x48,0xC1,0xE1,0x02,0x48,0x33,0xC8,0x48,0xC1,0xE8,0x02,0x48,0x33,0xC1,0x48,0xB9,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x23,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly(N4 n, ushort x)
; location: [7FFDDB04BBB0h, 7FFDDB04BBE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000dh and edx,0FF0h                 ; AND(And_rm32_imm32) [EDX,ff0h:imm32]                 encoding(6 bytes) = 81 e2 f0 0f 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0018h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
001ah shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
001dh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h and edx,0FF0h                 ; AND(And_rm32_imm32) [EDX,ff0h:imm32]                 encoding(6 bytes) = 81 e2 f0 0f 00 00
002bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0030h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x8B,0xD0,0x0F,0xB7,0xD2,0x81,0xE2,0xF0,0x0F,0x00,0x00,0x8B,0xCA,0xC1,0xE1,0x04,0x33,0xCA,0xC1,0xEA,0x04,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0xF0,0x0F,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly(N4 n, uint x)
; location: [7FFDDB04BC00h, 7FFDDB04BC1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h and eax,0FF00FF0h             ; AND(And_EAX_imm32) [EAX,ff00ff0h:imm32]              encoding(5 bytes) = 25 f0 0f f0 0f
000ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000eh shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0011h xor ecx,eax                   ; XOR(Xor_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 33 c8
0013h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0016h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0018h and eax,0FF00FF0h             ; AND(And_EAX_imm32) [EAX,ff00ff0h:imm32]              encoding(5 bytes) = 25 f0 0f f0 0f
001dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x25,0xF0,0x0F,0xF0,0x0F,0x8B,0xC8,0xC1,0xE1,0x04,0x33,0xC8,0xC1,0xE8,0x04,0x33,0xC1,0x25,0xF0,0x0F,0xF0,0x0F,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly(N4 n, ulong x)
; location: [7FFDDB04BC30h, 7FFDDB04BC66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0012h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0015h shl rcx,4                     ; SHL(Shl_rm64_imm8) [RCX,4h:imm8]                     encoding(4 bytes) = 48 c1 e1 04
0019h xor rcx,rax                   ; XOR(Xor_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 33 c8
001ch shr rax,4                     ; SHR(Shr_rm64_imm8) [RAX,4h:imm8]                     encoding(4 bytes) = 48 c1 e8 04
0020h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0023h mov rcx,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RCX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b9 f0 0f f0 0f f0 0f f0 0f
002dh and rcx,rax                   ; AND(And_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 23 c8
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterflyBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x23,0xC2,0x48,0x8B,0xC8,0x48,0xC1,0xE1,0x04,0x48,0x33,0xC8,0x48,0xC1,0xE8,0x04,0x48,0x33,0xC1,0x48,0xB9,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x23,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
