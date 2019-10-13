; 2019-10-13 04:28:17:869
; function: Sign:int signum_d8i(sbyte x)
; location: [7FFDD0C8B340h, 7FFDD0C8B357h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000fh shr edx,1Fh                   ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g8i(sbyte x)
; location: [7FFDD0C8B950h, 7FFDD0C8B963h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h mov rax,7FFDD0C89728h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89728h:imm64]         encoding(10 bytes) = 48 b8 28 97 c8 d0 fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0xB8,0x28,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d8u(byte x)
; location: [7FFDD0C8B980h, 7FFDD0C8B98Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g8u(byte x)
; location: [7FFDD0C8B9A0h, 7FFDD0C8B9B2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h mov rax,7FFDD0C89738h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89738h:imm64]         encoding(10 bytes) = 48 b8 38 97 c8 d0 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x48,0xB8,0x38,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16i(short x)
; location: [7FFDD0C8B9D0h, 7FFDD0C8B9E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000fh shr edx,1Fh                   ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g16i(short x)
; location: [7FFDD0C8BA00h, 7FFDD0C8BA13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h mov rax,7FFDD0C89748h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89748h:imm64]         encoding(10 bytes) = 48 b8 48 97 c8 d0 fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0xB8,0x48,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16u(ushort x)
; location: [7FFDD0C8BA30h, 7FFDD0C8BA40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g16u(ushort x)
; location: [7FFDD0C8BA60h, 7FFDD0C8BA72h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h mov rax,7FFDD0C89758h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89758h:imm64]         encoding(10 bytes) = 48 b8 58 97 c8 d0 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x48,0xB8,0x58,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32i(int x)
; location: [7FFDD0C8BA90h, 7FFDD0C8BAA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh shr eax,1Fh                   ; SHR(Shr_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 e8 1f
000eh sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0011h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d32iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC1,0xE8,0x1F,0xC1,0xF9,0x1F,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32i(int x)
; location: [7FFDD0C8BAC0h, 7FFDD0C8BACFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0C89768h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89768h:imm64]         encoding(10 bytes) = 48 b8 68 97 c8 d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g32iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x68,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32u(uint x)
; location: [7FFDD0C8BAF0h, 7FFDD0C8BAFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32u(uint x)
; location: [7FFDD0C8BB10h, 7FFDD0C8BB1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0C89778h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89778h:imm64]         encoding(10 bytes) = 48 b8 78 97 c8 d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x78,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64i(long x)
; location: [7FFDD0C8BB40h, 7FFDD0C8BB5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh shr rax,3Fh                   ; SHR(Shr_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 e8 3f
0012h sar rcx,3Fh                   ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f9 3f
0016h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0xC1,0xE8,0x3F,0x48,0xC1,0xF9,0x3F,0x8B,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64i(long x)
; location: [7FFDD0C8BB70h, 7FFDD0C8BB7Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0C89788h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89788h:imm64]         encoding(10 bytes) = 48 b8 88 97 c8 d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g64iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x88,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64u(ulong x)
; location: [7FFDD0C8BBA0h, 7FFDD0C8BBAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64u(ulong x)
; location: [7FFDD0C8BBC0h, 7FFDD0C8BBCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0C89798h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c89798h:imm64]         encoding(10 bytes) = 48 b8 98 97 c8 d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x98,0x97,0xC8,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_d8i(sbyte x)
; location: [7FFDD0C8BBF0h, 7FFDD0C8BC00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_g8i(sbyte x)
; location: [7FFDD0C8BC20h, 7FFDD0C8BC30h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_d8u(byte x)
; location: [7FFDD0C8BC50h, 7FFDD0C8BC5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_g8u(byte x)
; location: [7FFDD0C8C080h, 7FFDD0C8C08Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_d16i(short x)
; location: [7FFDD0C8C0A0h, 7FFDD0C8C0B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_g16i(short x)
; location: [7FFDD0C8C0D0h, 7FFDD0C8C0E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_d16u(ushort x)
; location: [7FFDD0C8C100h, 7FFDD0C8C10Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_g16u(ushort x)
; location: [7FFDD0C8C120h, 7FFDD0C8C12Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_d32i(int x)
; location: [7FFDD0C8C140h, 7FFDD0C8C14Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_g32i(int x)
; location: [7FFDD0C8C160h, 7FFDD0C8C16Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_d32u(uint x)
; location: [7FFDD0C8C180h, 7FFDD0C8C18Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_g32u(uint x)
; location: [7FFDD0C8C1A0h, 7FFDD0C8C1AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square_d64i(long x)
; location: [7FFDD0C8C1C0h, 7FFDD0C8C1D7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh vsqrtsd xmm0,xmm0,xmm0        ; VSQRTSD(VEX_Vsqrtsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 51 c0
0012h vcvttsd2si rax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r64_xmmm64) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fb 2c c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d64iBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0xC5,0xFB,0x51,0xC0,0xC4,0xE1,0xFB,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square_g64i(long x)
; location: [7FFDD0C8C1F0h, 7FFDD0C8C207h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh vsqrtsd xmm0,xmm0,xmm0        ; VSQRTSD(VEX_Vsqrtsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 51 c0
0012h vcvttsd2si rax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r64_xmmm64) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fb 2c c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g64iBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0xC5,0xFB,0x51,0xC0,0xC4,0xE1,0xFB,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square_d64u(ulong x)
; location: [7FFDD0C8C220h, 7FFDD0C8C22Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square_g64u(ulong x)
; location: [7FFDD0C8C240h, 7FFDD0C8C24Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C8C260h, 7FFDD0C8C273h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C8C290h, 7FFDD0C8C2A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_d8u(byte lhs, byte rhs)
; location: [7FFDD0C8C2C0h, 7FFDD0C8C2D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_g8u(byte lhs, byte rhs)
; location: [7FFDD0C8C2F0h, 7FFDD0C8C303h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_d16i(short lhs, short rhs)
; location: [7FFDD0C8C320h, 7FFDD0C8C333h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_g16i(short lhs, short rhs)
; location: [7FFDD0C8C350h, 7FFDD0C8C367h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8C380h, 7FFDD0C8C390h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8C3B0h, 7FFDD0C8C3C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_d32i(int lhs, int rhs)
; location: [7FFDD0C8C3E0h, 7FFDD0C8C3E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_g32i(int lhs, int rhs)
; location: [7FFDD0C8C810h, 7FFDD0C8C819h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_d32u(uint lhs, uint rhs)
; location: [7FFDD0C8C830h, 7FFDD0C8C839h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_g32u(uint lhs, uint rhs)
; location: [7FFDD0C8C850h, 7FFDD0C8C859h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_d64i(long lhs, long rhs)
; location: [7FFDD0C8C870h, 7FFDD0C8C87Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_g64i(long lhs, long rhs)
; location: [7FFDD0C8C890h, 7FFDD0C8C89Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8C8B0h, 7FFDD0C8C8BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8C8D0h, 7FFDD0C8C8DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_d32i(int lhs, int rhs)
; location: [7FFDD0C8C8F0h, 7FFDD0C8C900h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_g32i(int lhs, int rhs)
; location: [7FFDD0C8C920h, 7FFDD0C8C930h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_d32u(uint lhs, uint rhs)
; location: [7FFDD0C8C950h, 7FFDD0C8C961h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_g32u(uint lhs, uint rhs)
; location: [7FFDD0C8C980h, 7FFDD0C8C991h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod_d64i(long lhs, long rhs)
; location: [7FFDD0C8C9B0h, 7FFDD0C8C9C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod_g64i(long lhs, long rhs)
; location: [7FFDD0C8C9E0h, 7FFDD0C8C9F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8CA10h, 7FFDD0C8CA23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8CA40h, 7FFDD0C8CA53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_d32f(float lhs, float rhs)
; location: [7FFDD0C8CE80h, 7FFDD0C8CE91h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE30220790h            ; CALL(Call_rel32_64) [5F593910h:jmp64]                encoding(5 bytes) = e8 04 39 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x04,0x39,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_g32f(float lhs, float rhs)
; location: [7FFDD0C8D0A0h, 7FFDD0C8D0B1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE30220790h            ; CALL(Call_rel32_64) [5F5936F0h:jmp64]                encoding(5 bytes) = e8 e4 36 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0xE4,0x36,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_d64f(double lhs, double rhs)
; location: [7FFDD0C8D0D0h, 7FFDD0C8D0E1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE30220700h            ; CALL(Call_rel32_64) [5F593630h:jmp64]                encoding(5 bytes) = e8 24 36 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x24,0x36,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_g64f(double lhs, double rhs)
; location: [7FFDD0C8D500h, 7FFDD0C8D511h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE30220700h            ; CALL(Call_rel32_64) [5F593200h:jmp64]                encoding(5 bytes) = e8 f4 31 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0xF4,0x31,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C8D530h, 7FFDD0C8D544h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C8D560h, 7FFDD0C8D578h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0014h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g8iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_d8u(byte lhs, byte rhs)
; location: [7FFDD0C8D590h, 7FFDD0C8D5A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_g8u(byte lhs, byte rhs)
; location: [7FFDD0C8D5C0h, 7FFDD0C8D5D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_d16i(short lhs, short rhs)
; location: [7FFDD0C8D5F0h, 7FFDD0C8D604h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_g16i(short lhs, short rhs)
; location: [7FFDD0C8D620h, 7FFDD0C8D638h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0014h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8D650h, 7FFDD0C8D661h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8D680h, 7FFDD0C8D694h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_d32i(int lhs, int rhs)
; location: [7FFDD0C8D6B0h, 7FFDD0C8D6BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_g32i(int lhs, int rhs)
; location: [7FFDD0C8D6D0h, 7FFDD0C8D6DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_d32u(uint lhs, uint rhs)
; location: [7FFDD0C8D6F0h, 7FFDD0C8D6FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_g32u(uint lhs, uint rhs)
; location: [7FFDD0C8D710h, 7FFDD0C8D71Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_d64i(long lhs, long rhs)
; location: [7FFDD0C8D730h, 7FFDD0C8D73Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_g64i(long lhs, long rhs)
; location: [7FFDD0C8D750h, 7FFDD0C8D75Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8D770h, 7FFDD0C8D77Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8D790h, 7FFDD0C8D79Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_d8i(sbyte x)
; location: [7FFDD0C8D7B0h, 7FFDD0C8D7BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_g8i(sbyte x)
; location: [7FFDD0C8D7D0h, 7FFDD0C8D7DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_d8u(byte x)
; location: [7FFDD0C8D7F0h, 7FFDD0C8D7FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_g8u(byte x)
; location: [7FFDD0C8D810h, 7FFDD0C8D81Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_d16i(short x)
; location: [7FFDD0C8D830h, 7FFDD0C8D83Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_g16i(short x)
; location: [7FFDD0C8D850h, 7FFDD0C8D85Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_d16u(ushort x)
; location: [7FFDD0C8D870h, 7FFDD0C8D87Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_g16u(ushort x)
; location: [7FFDD0C8D890h, 7FFDD0C8D89Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_d32i(int x)
; location: [7FFDD0C8D8B0h, 7FFDD0C8D8B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_g32i(int x)
; location: [7FFDD0C8D8D0h, 7FFDD0C8D8D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_d32u(uint x)
; location: [7FFDD0C8D8F0h, 7FFDD0C8D8FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_g32u(uint x)
; location: [7FFDD0C8DD20h, 7FFDD0C8DD2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_d64i(long x)
; location: [7FFDD0C8DD40h, 7FFDD0C8DD4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_g64i(long x)
; location: [7FFDD0C8DD60h, 7FFDD0C8DD6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_d64u(ulong x)
; location: [7FFDD0C8DD80h, 7FFDD0C8DD8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_g64u(ulong x)
; location: [7FFDD0C8DDA0h, 7FFDD0C8DDAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_g32f(float x)
; location: [7FFDD0C8DDC0h, 7FFDD0C8DDD1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDD0C8DDD8h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_d32f(float x)
; location: [7FFDD0C8DDF0h, 7FFDD0C8DE01h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDD0C8DE08h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_d64f(double x)
; location: [7FFDD0C8DE20h, 7FFDD0C8DE31h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDD0C8DE38h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_g64f(double x)
; location: [7FFDD0C8DE50h, 7FFDD0C8DE61h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDD0C8DE68h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d8i(sbyte x)
; location: [7FFDD0C8DE80h, 7FFDD0C8DE91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g8i(sbyte x)
; location: [7FFDD0C8DEB0h, 7FFDD0C8DEC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d16i(short x)
; location: [7FFDD0C8DEE0h, 7FFDD0C8DEF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g16i(short x)
; location: [7FFDD0C8DF10h, 7FFDD0C8DF21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32i(int x)
; location: [7FFDD0C8DF40h, 7FFDD0C8DF4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32i(int x)
; location: [7FFDD0C8DF60h, 7FFDD0C8DF6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64i(long x)
; location: [7FFDD0C8DF80h, 7FFDD0C8DF8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64i(long x)
; location: [7FFDD0C8DFA0h, 7FFDD0C8DFAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32f(float x)
; location: [7FFDD0C8DFC0h, 7FFDD0C8DFD3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d32fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32f(float x)
; location: [7FFDD0C8DFF0h, 7FFDD0C8E003h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g32fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64f(double x)
; location: [7FFDD0C8E020h, 7FFDD0C8E033h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d64fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64f(double x)
; location: [7FFDD0C8E050h, 7FFDD0C8E063h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g64fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n8i(sbyte x)
; location: [7FFDD0C8E080h, 7FFDD0C8E094h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g8i(sbyte x)
; location: [7FFDD0C8E0B0h, 7FFDD0C8E0C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n8u(byte x)
; location: [7FFDD0C8E0E0h, 7FFDD0C8E0F4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g8u(byte x)
; location: [7FFDD0C8E110h, 7FFDD0C8E120h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n16i(short x)
; location: [7FFDD0C8E140h, 7FFDD0C8E155h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0        ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,SS:sr),0h:imm16]  encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g16i(short x)
; location: [7FFDD0C8E170h, 7FFDD0C8E181h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n16u(ushort x)
; location: [7FFDD0C8E1A0h, 7FFDD0C8E1B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0        ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,SS:sr),0h:imm16]  encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g16u(ushort x)
; location: [7FFDD0C8E1D0h, 7FFDD0C8E1E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n32i(int x)
; location: [7FFDD0C8E200h, 7FFDD0C8E20Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g32i(int x)
; location: [7FFDD0C8E220h, 7FFDD0C8E22Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n32u(uint x)
; location: [7FFDD0C8E240h, 7FFDD0C8E24Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g32u(uint x)
; location: [7FFDD0C8E260h, 7FFDD0C8E26Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64i(long x)
; location: [7FFDD0C8E280h, 7FFDD0C8E28Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g64i(long x)
; location: [7FFDD0C8E2A0h, 7FFDD0C8E2AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64u(ulong x)
; location: [7FFDD0C8E2C0h, 7FFDD0C8E2CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g64u(ulong x)
; location: [7FFDD0C8E2E0h, 7FFDD0C8E2EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse_d8i(string src, out sbyte dst)
; location: [7FFDD0C8E300h, 7FFDD0C8E38Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 006ch                ; JE(Je_rel8_64) [6Ch:jmp64]                           encoding(2 bytes) = 74 56
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
001dh call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BD290h:jmp64]                encoding(5 bytes) = e8 6e d2 8b 39
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFE0A53C710h            ; CALL(Call_rel32_64) [398AE410h:jmp64]                encoding(5 bytes) = e8 cc e3 8a 39
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0077h               ; JNE(Jne_rel8_64) [77h:jmp64]                         encoding(2 bytes) = 75 2d
004ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
004eh add eax,80h                   ; ADD(Add_EAX_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = 05 80 00 00 00
0053h cmp eax,0FFh                  ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 3d ff 00 00 00
0058h ja short 0082h                ; JA(Ja_rel8_64) [82h:jmp64]                           encoding(2 bytes) = 77 28
005ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
005eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0062h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
0064h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0068h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006ch mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0071h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964E40h:jmp64]        encoding(5 bytes) = e8 ca 4d 96 ff
0076h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0077h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007ch call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF978860h:jmp64]        encoding(5 bytes) = e8 df 87 97 ff
0081h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0082h mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0087h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF978868h:jmp64]        encoding(5 bytes) = e8 dc 87 97 ff
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d8iBytes => new byte[141]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x56,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x6E,0xD2,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xCC,0xE3,0x8A,0x39,0x8B,0xC8,0x85,0xC9,0x75,0x2D,0x8B,0x44,0x24,0x38,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBE,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xCA,0x4D,0x96,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0xDF,0x87,0x97,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0xDC,0x87,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse_g8i(string src)
; location: [7FFDD0C8E3B0h, 7FFDD0C8E435h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 53
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BD1E0h:jmp64]                encoding(5 bytes) = e8 c2 d1 8b 39
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFE0A53C710h            ; CALL(Call_rel32_64) [398AE360h:jmp64]                encoding(5 bytes) = e8 20 e3 8a 39
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0070h               ; JNE(Jne_rel8_64) [70h:jmp64]                         encoding(2 bytes) = 75 2a
0046h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
004ah add eax,80h                   ; ADD(Add_EAX_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = 05 80 00 00 00
004fh cmp eax,0FFh                  ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 3d ff 00 00 00
0054h ja short 007bh                ; JA(Ja_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 77 25
0056h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
005ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
005eh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0062h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0063h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0065h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ah call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964D90h:jmp64]        encoding(5 bytes) = e8 21 4d 96 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0075h call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF9787B0h:jmp64]        encoding(5 bytes) = e8 36 87 97 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0080h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF9787B8h:jmp64]        encoding(5 bytes) = e8 33 87 97 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g8iBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x53,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0xC2,0xD1,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x20,0xE3,0x8A,0x39,0x8B,0xC8,0x85,0xC9,0x75,0x2A,0x8B,0x44,0x24,0x30,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x25,0x8B,0x44,0x24,0x30,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x21,0x4D,0x96,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x36,0x87,0x97,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x33,0x87,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse_d8u(string src, out byte dst)
; location: [7FFDD0C8E450h, 7FFDD0C8E4D5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 4f
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
001dh call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BD140h:jmp64]                encoding(5 bytes) = e8 1e d1 8b 39
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFDD0606AC8h            ; CALL(Call_rel32_64) [FFFFFFFFFF978678h:jmp64]        encoding(5 bytes) = e8 34 86 97 ff
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0070h               ; JNE(Jne_rel8_64) [70h:jmp64]                         encoding(2 bytes) = 75 26
004ah cmp dword ptr [rsp+38h],0FFh  ; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,SS:sr),ffh:imm32] encoding(8 bytes) = 81 7c 24 38 ff 00 00 00
0052h ja short 007bh                ; JA(Ja_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 77 27
0054h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0058h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005bh mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
005dh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0061h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0062h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0063h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0065h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ah call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964CF0h:jmp64]        encoding(5 bytes) = e8 81 4c 96 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
0075h call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF978710h:jmp64]        encoding(5 bytes) = e8 96 86 97 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0080h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF978718h:jmp64]        encoding(5 bytes) = e8 93 86 97 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d8uBytes => new byte[134]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x4F,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x1E,0xD1,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x34,0x86,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x26,0x81,0x7C,0x24,0x38,0xFF,0x00,0x00,0x00,0x77,0x27,0x8B,0x44,0x24,0x38,0x0F,0xB6,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x81,0x4C,0x96,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0x96,0x86,0x97,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0x93,0x86,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse_g8u(string src)
; location: [7FFDD0C8E4F0h, 7FFDD0C8E56Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 005eh                ; JE(Je_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 74 4c
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BD0A0h:jmp64]                encoding(5 bytes) = e8 82 d0 8b 39
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFDD0606AC8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9785D8h:jmp64]        encoding(5 bytes) = e8 98 85 97 ff
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 23
0046h cmp dword ptr [rsp+30h],0FFh  ; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,SS:sr),ffh:imm32] encoding(8 bytes) = 81 7c 24 30 ff 00 00 00
004eh ja short 0074h                ; JA(Ja_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 77 24
0050h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
0054h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0057h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
005bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005ch pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005eh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0063h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964C50h:jmp64]        encoding(5 bytes) = e8 e8 4b 96 ff
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0069h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
006eh call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF978670h:jmp64]        encoding(5 bytes) = e8 fd 85 97 ff
0073h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0074h mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0079h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF978678h:jmp64]        encoding(5 bytes) = e8 fa 85 97 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g8uBytes => new byte[127]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x4C,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x82,0xD0,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x98,0x85,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x23,0x81,0x7C,0x24,0x30,0xFF,0x00,0x00,0x00,0x77,0x24,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xE8,0x4B,0x96,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0xFD,0x85,0x97,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0xFA,0x85,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse_d16i(string src, out short dst)
; location: [7FFDD0C8E590h, 7FFDD0C8E61Dh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 006dh                ; JE(Je_rel8_64) [6Dh:jmp64]                           encoding(2 bytes) = 74 57
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
001dh call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BD000h:jmp64]                encoding(5 bytes) = e8 de cf 8b 39
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFE0A53C710h            ; CALL(Call_rel32_64) [398AE180h:jmp64]                encoding(5 bytes) = e8 3c e1 8a 39
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0078h               ; JNE(Jne_rel8_64) [78h:jmp64]                         encoding(2 bytes) = 75 2e
004ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
004eh add eax,8000h                 ; ADD(Add_EAX_imm32) [EAX,8000h:imm32]                 encoding(5 bytes) = 05 00 80 00 00
0053h cmp eax,0FFFFh                ; CMP(Cmp_EAX_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = 3d ff ff 00 00
0058h ja short 0083h                ; JA(Ja_rel8_64) [83h:jmp64]                           encoding(2 bytes) = 77 29
005ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
005eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0062h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
0065h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0069h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006dh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0072h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964BB0h:jmp64]        encoding(5 bytes) = e8 39 4b 96 ff
0077h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0078h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
007dh call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF9785D0h:jmp64]        encoding(5 bytes) = e8 4e 85 97 ff
0082h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0083h mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0088h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF9785D8h:jmp64]        encoding(5 bytes) = e8 4b 85 97 ff
008dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d16iBytes => new byte[142]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x57,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xDE,0xCF,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x3C,0xE1,0x8A,0x39,0x8B,0xC8,0x85,0xC9,0x75,0x2E,0x8B,0x44,0x24,0x38,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x29,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBF,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x39,0x4B,0x96,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0x4E,0x85,0x97,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0x4B,0x85,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse_g16i(string src)
; location: [7FFDD0C8E640h, 7FFDD0C8E6C5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 53
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BCF50h:jmp64]                encoding(5 bytes) = e8 32 cf 8b 39
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFE0A53C710h            ; CALL(Call_rel32_64) [398AE0D0h:jmp64]                encoding(5 bytes) = e8 90 e0 8a 39
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0070h               ; JNE(Jne_rel8_64) [70h:jmp64]                         encoding(2 bytes) = 75 2a
0046h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
004ah add eax,8000h                 ; ADD(Add_EAX_imm32) [EAX,8000h:imm32]                 encoding(5 bytes) = 05 00 80 00 00
004fh cmp eax,0FFFFh                ; CMP(Cmp_EAX_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = 3d ff ff 00 00
0054h ja short 007bh                ; JA(Ja_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 77 25
0056h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
005ah movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
005eh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0062h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0063h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0065h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ah call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964B00h:jmp64]        encoding(5 bytes) = e8 91 4a 96 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0075h call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF978520h:jmp64]        encoding(5 bytes) = e8 a6 84 97 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0080h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF978528h:jmp64]        encoding(5 bytes) = e8 a3 84 97 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g16iBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x53,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x32,0xCF,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x90,0xE0,0x8A,0x39,0x8B,0xC8,0x85,0xC9,0x75,0x2A,0x8B,0x44,0x24,0x30,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x25,0x8B,0x44,0x24,0x30,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x91,0x4A,0x96,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0xA6,0x84,0x97,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0xA3,0x84,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse_d16u(string src, out ushort dst)
; location: [7FFDD0C8E6E0h, 7FFDD0C8E766h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 0066h                ; JE(Je_rel8_64) [66h:jmp64]                           encoding(2 bytes) = 74 50
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
001dh call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BCEB0h:jmp64]                encoding(5 bytes) = e8 8e ce 8b 39
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFDD0606AC8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9783E8h:jmp64]        encoding(5 bytes) = e8 a4 83 97 ff
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0071h               ; JNE(Jne_rel8_64) [71h:jmp64]                         encoding(2 bytes) = 75 27
004ah cmp dword ptr [rsp+38h],0FFFFh; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,SS:sr),ffffh:imm32] encoding(8 bytes) = 81 7c 24 38 ff ff 00 00
0052h ja short 007ch                ; JA(Ja_rel8_64) [7Ch:jmp64]                           encoding(2 bytes) = 77 28
0054h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0058h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
005bh mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 89 06
005eh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0064h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0066h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006bh call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964A60h:jmp64]        encoding(5 bytes) = e8 f0 49 96 ff
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0071h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0076h call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF978480h:jmp64]        encoding(5 bytes) = e8 05 84 97 ff
007bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007ch mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0081h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF978488h:jmp64]        encoding(5 bytes) = e8 02 84 97 ff
0086h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d16uBytes => new byte[135]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x50,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x8E,0xCE,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xA4,0x83,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x27,0x81,0x7C,0x24,0x38,0xFF,0xFF,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x0F,0xB7,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF0,0x49,0x96,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x05,0x84,0x97,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x02,0x84,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse_g16u(string src)
; location: [7FFDD0C8EB90h, 7FFDD0C8EC0Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 005eh                ; JE(Je_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 74 4c
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BCA00h:jmp64]                encoding(5 bytes) = e8 e2 c9 8b 39
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFDD0606AC8h            ; CALL(Call_rel32_64) [FFFFFFFFFF977F38h:jmp64]        encoding(5 bytes) = e8 f8 7e 97 ff
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 23
0046h cmp dword ptr [rsp+30h],0FFFFh; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,SS:sr),ffffh:imm32] encoding(8 bytes) = 81 7c 24 30 ff ff 00 00
004eh ja short 0074h                ; JA(Ja_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 77 24
0050h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
0054h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0057h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
005bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005ch pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005eh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0063h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF9645B0h:jmp64]        encoding(5 bytes) = e8 48 45 96 ff
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0069h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
006eh call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977FD0h:jmp64]        encoding(5 bytes) = e8 5d 7f 97 ff
0073h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0074h mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0079h call 7FFDD0606B68h            ; CALL(Call_rel32_64) [FFFFFFFFFF977FD8h:jmp64]        encoding(5 bytes) = e8 5a 7f 97 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g16uBytes => new byte[127]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x4C,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0xE2,0xC9,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0xF8,0x7E,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x23,0x81,0x7C,0x24,0x30,0xFF,0xFF,0x00,0x00,0x77,0x24,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x48,0x45,0x96,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x5D,0x7F,0x97,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x5A,0x7F,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse_d32i(string src, out int dst)
; location: [7FFDD0C8EC30h, 7FFDD0C8EC7Fh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0045h                ; JE(Je_rel8_64) [45h:jmp64]                           encoding(2 bytes) = 74 31
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0026h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC960h:jmp64]                encoding(5 bytes) = e8 35 c9 8b 39
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDD0606A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977E30h:jmp64]        encoding(5 bytes) = e8 f3 7d 97 ff
003dh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
003fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0045h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004ah call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964510h:jmp64]        encoding(5 bytes) = e8 c1 44 96 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32iBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x35,0xC9,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0xF3,0x7D,0x97,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC1,0x44,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse_g32i(string src)
; location: [7FFDD0C8ECA0h, 7FFDD0C8ECE9h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0022h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC8F0h:jmp64]                encoding(5 bytes) = e8 c9 c8 8b 39
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDD0606A60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977DC0h:jmp64]        encoding(5 bytes) = e8 87 7d 97 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF9644A0h:jmp64]        encoding(5 bytes) = e8 57 44 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32iBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xC9,0xC8,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0x87,0x7D,0x97,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x57,0x44,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse_d32u(string src, out uint dst)
; location: [7FFDD0C8ED00h, 7FFDD0C8ED4Fh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0045h                ; JE(Je_rel8_64) [45h:jmp64]                           encoding(2 bytes) = 74 31
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0026h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC890h:jmp64]                encoding(5 bytes) = e8 65 c8 8b 39
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDD0606A70h            ; CALL(Call_rel32_64) [FFFFFFFFFF977D70h:jmp64]        encoding(5 bytes) = e8 33 7d 97 ff
003dh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
003fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0045h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004ah call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964440h:jmp64]        encoding(5 bytes) = e8 f1 43 96 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32uBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x65,0xC8,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x33,0x7D,0x97,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF1,0x43,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse_g32u(string src)
; location: [7FFDD0C8ED70h, 7FFDD0C8EDB9h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0022h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC820h:jmp64]                encoding(5 bytes) = e8 f9 c7 8b 39
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDD0606A70h            ; CALL(Call_rel32_64) [FFFFFFFFFF977D00h:jmp64]        encoding(5 bytes) = e8 c7 7c 97 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF9643D0h:jmp64]        encoding(5 bytes) = e8 87 43 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32uBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xF9,0xC7,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xC7,0x7C,0x97,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x87,0x43,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse_d64i(string src, out long dst)
; location: [7FFDD0C8EDD0h, 7FFDD0C8EE20h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 32
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0026h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC7C0h:jmp64]                encoding(5 bytes) = e8 95 c7 8b 39
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDD0606A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF977C98h:jmp64]        encoding(5 bytes) = e8 5b 7c 97 ff
003dh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0040h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0044h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004bh call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964370h:jmp64]        encoding(5 bytes) = e8 20 43 96 ff
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64iBytes => new byte[81]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x95,0xC7,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x5B,0x7C,0x97,0xFF,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x20,0x43,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse_g64i(string src)
; location: [7FFDD0C8EE40h, 7FFDD0C8EE89h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0022h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC750h:jmp64]                encoding(5 bytes) = e8 29 c7 8b 39
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDD0606A68h            ; CALL(Call_rel32_64) [FFFFFFFFFF977C28h:jmp64]        encoding(5 bytes) = e8 ef 7b 97 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964300h:jmp64]        encoding(5 bytes) = e8 b7 42 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64iBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x29,0xC7,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xEF,0x7B,0x97,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xB7,0x42,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse_d64u(string src, out ulong dst)
; location: [7FFDD0C8EEA0h, 7FFDD0C8EEF0h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 32
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0026h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC6F0h:jmp64]                encoding(5 bytes) = e8 c5 c6 8b 39
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFE0A61B840h            ; CALL(Call_rel32_64) [3998C9A0h:jmp64]                encoding(5 bytes) = e8 63 c9 98 39
003dh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0040h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0044h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004bh call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF9642A0h:jmp64]        encoding(5 bytes) = e8 50 42 96 ff
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64uBytes => new byte[81]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xC5,0xC6,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x63,0xC9,0x98,0x39,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x50,0x42,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse_g64u(string src)
; location: [7FFDD0C8EF10h, 7FFDD0C8EF59h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(3 bytes) = 89 51 08
0022h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC680h:jmp64]                encoding(5 bytes) = e8 59 c6 8b 39
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFE0A61B840h            ; CALL(Call_rel32_64) [3998C930h:jmp64]                encoding(5 bytes) = e8 f7 c8 98 39
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964230h:jmp64]        encoding(5 bytes) = e8 e7 41 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64uBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x59,0xC6,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xF7,0xC8,0x98,0x39,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xE7,0x41,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse_d32f(string src, out float dst)
; location: [7FFDD0C8EF70h, 7FFDD0C8EFE4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 005dh                ; JE(Je_rel8_64) [5Dh:jmp64]                           encoding(2 bytes) = 74 44
0019h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
001dh mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0020h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC620h:jmp64]                encoding(5 bytes) = e8 fb c5 8b 39
0025h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0028h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002dh mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0030h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0033h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0038h lea r9,[rsp+3Ch]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 3c
003dh mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
0042h call 7FFDD0606B28h            ; CALL(Call_rel32_64) [FFFFFFFFFF977BB8h:jmp64]        encoding(5 bytes) = e8 71 7b 97 ff
0047h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0049h je short 0068h                ; JE(Je_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 74 1d
004bh vmovss xmm0,dword ptr [rsp+3Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 3c
0051h vmovss dword ptr [rsi],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 06
0055h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0059h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005dh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0062h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF9641D0h:jmp64]        encoding(5 bytes) = e8 69 41 96 ff
0067h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0068h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
006dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006fh call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977BF0h:jmp64]        encoding(5 bytes) = e8 7c 7b 97 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32fBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xFB,0xC5,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x3C,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x71,0x7B,0x97,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFA,0x10,0x44,0x24,0x3C,0xC5,0xFA,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x69,0x41,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x7C,0x7B,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse_g32f(string src)
; location: [7FFDD0C8F000h, 7FFDD0C8F06Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
0010h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0013h je short 0054h                ; JE(Je_rel8_64) [54h:jmp64]                           encoding(2 bytes) = 74 3f
0015h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0019h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
001ch call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC590h:jmp64]                encoding(5 bytes) = e8 6f c5 8b 39
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0029h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
002ch mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0034h lea r9,[rsp+34h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 34
0039h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
003eh call 7FFDD0606B28h            ; CALL(Call_rel32_64) [FFFFFFFFFF977B28h:jmp64]        encoding(5 bytes) = e8 e5 7a 97 ff
0043h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0045h je short 005fh                ; JE(Je_rel8_64) [5Fh:jmp64]                           encoding(2 bytes) = 74 18
0047h vmovss xmm0,dword ptr [rsp+34h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 34
004dh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0054h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0059h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964140h:jmp64]        encoding(5 bytes) = e8 e2 40 96 ff
005eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
005fh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977B60h:jmp64]        encoding(5 bytes) = e8 f5 7a 97 ff
006bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32fBytes => new byte[108]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x3F,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x6F,0xC5,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x34,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xE5,0x7A,0x97,0xFF,0x85,0xC0,0x74,0x18,0xC5,0xFA,0x10,0x44,0x24,0x34,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xE2,0x40,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0xF5,0x7A,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse_d64f(string src, out double dst)
; location: [7FFDD0C8F090h, 7FFDD0C8F104h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 005dh                ; JE(Je_rel8_64) [5Dh:jmp64]                           encoding(2 bytes) = 74 44
0019h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 79 0c
001dh mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 59 08
0020h call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC500h:jmp64]                encoding(5 bytes) = e8 db c4 8b 39
0025h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0028h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002dh mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0030h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0033h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0038h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003dh mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
0042h call 7FFDD0606B20h            ; CALL(Call_rel32_64) [FFFFFFFFFF977A90h:jmp64]        encoding(5 bytes) = e8 49 7a 97 ff
0047h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0049h je short 0068h                ; JE(Je_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 74 1d
004bh vmovsd xmm0,qword ptr [rsp+38h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 38
0051h vmovsd qword ptr [rsi],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 06
0055h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0059h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005dh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0062h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF9640B0h:jmp64]        encoding(5 bytes) = e8 49 40 96 ff
0067h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0068h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
006dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006fh call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977AD0h:jmp64]        encoding(5 bytes) = e8 5c 7a 97 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64fBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xDB,0xC4,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x49,0x7A,0x97,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFB,0x10,0x44,0x24,0x38,0xC5,0xFB,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x49,0x40,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x5C,0x7A,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse_g64f(string src)
; location: [7FFDD0C8F120h, 7FFDD0C8F18Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
0010h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0013h je short 0054h                ; JE(Je_rel8_64) [54h:jmp64]                           encoding(2 bytes) = 74 3f
0015h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0019h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
001ch call 7FFE0A54B590h            ; CALL(Call_rel32_64) [398BC470h:jmp64]                encoding(5 bytes) = e8 4f c4 8b 39
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0029h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
002ch mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0034h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0039h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
003eh call 7FFDD0606B20h            ; CALL(Call_rel32_64) [FFFFFFFFFF977A00h:jmp64]        encoding(5 bytes) = e8 bd 79 97 ff
0043h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0045h je short 005fh                ; JE(Je_rel8_64) [5Fh:jmp64]                           encoding(2 bytes) = 74 18
0047h vmovsd xmm0,qword ptr [rsp+30h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 30
004dh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0054h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0059h call 7FFDD05F3140h            ; CALL(Call_rel32_64) [FFFFFFFFFF964020h:jmp64]        encoding(5 bytes) = e8 c2 3f 96 ff
005eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
005fh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h call 7FFDD0606B60h            ; CALL(Call_rel32_64) [FFFFFFFFFF977A40h:jmp64]        encoding(5 bytes) = e8 d5 79 97 ff
006bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64fBytes => new byte[108]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x3F,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x4F,0xC4,0x8B,0x39,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xBD,0x79,0x97,0xFF,0x85,0xC0,0x74,0x18,0xC5,0xFB,0x10,0x44,0x24,0x30,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC2,0x3F,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0xD5,0x79,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8i(sbyte x)
; location: [7FFDD0C8F1B0h, 7FFDD0C8F1C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8i(sbyte x)
; location: [7FFDD0C8F1E0h, 7FFDD0C8F1F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8u(byte x)
; location: [7FFDD0C8F210h, 7FFDD0C8F21Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8u(byte x)
; location: [7FFDD0C8F230h, 7FFDD0C8F240h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16i(short x)
; location: [7FFDD0C8F260h, 7FFDD0C8F271h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16i(short x)
; location: [7FFDD0C8F290h, 7FFDD0C8F2A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16u(ushort x)
; location: [7FFDD0C8F2C0h, 7FFDD0C8F2D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16u(ushort x)
; location: [7FFDD0C8F2F0h, 7FFDD0C8F300h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32i(int x)
; location: [7FFDD0C8F320h, 7FFDD0C8F32Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32i(int x)
; location: [7FFDD0C8F340h, 7FFDD0C8F34Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32u(uint x)
; location: [7FFDD0C8F360h, 7FFDD0C8F36Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32u(uint x)
; location: [7FFDD0C8F380h, 7FFDD0C8F38Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64i(long x)
; location: [7FFDD0C8F3A0h, 7FFDD0C8F3AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64i(long x)
; location: [7FFDD0C8F3C0h, 7FFDD0C8F3CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64u(ulong x)
; location: [7FFDD0C8F3E0h, 7FFDD0C8F3EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64u(ulong x)
; location: [7FFDD0C8F400h, 7FFDD0C8F40Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_b8i(sbyte b, uint exp)
; location: [7FFDD0C8F420h, 7FFDD0C8F433h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h mov rax,7FFDD0BEA190h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea190h:imm64]         encoding(10 bytes) = 48 b8 90 a1 be d0 fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0xB8,0x90,0xA1,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_g8i(sbyte b, uint exp)
; location: [7FFDD0C8F450h, 7FFDD0C8F466h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h call 7FFDD0BEA190h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5AD40h:jmp64]        encoding(5 bytes) = e8 32 ad f5 ff
000eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g8iBytes => new byte[23]{0x48,0x83,0xEC,0x28,0x90,0x48,0x0F,0xBE,0xC9,0xE8,0x32,0xAD,0xF5,0xFF,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_b8u(byte b, uint exp)
; location: [7FFDD0C8F480h, 7FFDD0C8F492h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h mov rax,7FFDD0BEA1E0h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea1e0h:imm64]         encoding(10 bytes) = 48 b8 e0 a1 be d0 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x48,0xB8,0xE0,0xA1,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_g8u(byte b, uint exp)
; location: [7FFDD0C8F4B0h, 7FFDD0C8F4C4h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h call 7FFDD0BEA1E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5AD30h:jmp64]        encoding(5 bytes) = e8 23 ad f5 ff
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g8uBytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC9,0xE8,0x23,0xAD,0xF5,0xFF,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_b16i(short b, uint exp)
; location: [7FFDD0C8F4E0h, 7FFDD0C8F4F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h mov rax,7FFDD0BEA230h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea230h:imm64]         encoding(10 bytes) = 48 b8 30 a2 be d0 fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0xB8,0x30,0xA2,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_g16i(short b, uint exp)
; location: [7FFDD0C8F510h, 7FFDD0C8F526h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h call 7FFDD0BEA230h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5AD20h:jmp64]        encoding(5 bytes) = e8 12 ad f5 ff
000eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g16iBytes => new byte[23]{0x48,0x83,0xEC,0x28,0x90,0x48,0x0F,0xBF,0xC9,0xE8,0x12,0xAD,0xF5,0xFF,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_b16u(ushort b, uint exp)
; location: [7FFDD0C8F540h, 7FFDD0C8F552h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h mov rax,7FFDD0BEA280h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea280h:imm64]         encoding(10 bytes) = 48 b8 80 a2 be d0 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x48,0xB8,0x80,0xA2,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_g16u(ushort b, uint exp)
; location: [7FFDD0C8F970h, 7FFDD0C8F984h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h call 7FFDD0BEA280h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5A910h:jmp64]        encoding(5 bytes) = e8 03 a9 f5 ff
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g16uBytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0xC9,0xE8,0x03,0xA9,0xF5,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_b32i(int b, uint exp)
; location: [7FFDD0C8F9A0h, 7FFDD0C8F9AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0BEA2D0h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea2d0h:imm64]         encoding(10 bytes) = 48 b8 d0 a2 be d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b32iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xD0,0xA2,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_g32i(int b, uint exp)
; location: [7FFDD0C8F9D0h, 7FFDD0C8F9DFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDD0BEA2D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5A900h:jmp64]        encoding(5 bytes) = e8 f6 a8 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g32iBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0xF6,0xA8,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_b32u(uint b, uint exp)
; location: [7FFDD0C8FA00h, 7FFDD0C8FA0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0BEA310h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea310h:imm64]         encoding(10 bytes) = 48 b8 10 a3 be d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x10,0xA3,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_g32u(uint b, uint exp)
; location: [7FFDD0C8FA30h, 7FFDD0C8FA3Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDD0BEA310h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5A8E0h:jmp64]        encoding(5 bytes) = e8 d6 a8 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g32uBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0xD6,0xA8,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_b64i(long b, uint exp)
; location: [7FFDD0C8FA60h, 7FFDD0C8FA6Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0BEA350h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea350h:imm64]         encoding(10 bytes) = 48 b8 50 a3 be d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b64iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x50,0xA3,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_g64i(long b, uint exp)
; location: [7FFDD0C8FA90h, 7FFDD0C8FA9Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDD0BEA350h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5A8C0h:jmp64]        encoding(5 bytes) = e8 b6 a8 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g64iBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0xB6,0xA8,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_b64u(ulong b, uint exp)
; location: [7FFDD0C8FAC0h, 7FFDD0C8FACFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD0BEA390h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0bea390h:imm64]         encoding(10 bytes) = 48 b8 90 a3 be d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x90,0xA3,0xBE,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_g64u(ulong b, uint exp)
; location: [7FFDD0C8FAF0h, 7FFDD0C8FAFFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDD0BEA390h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5A8A0h:jmp64]        encoding(5 bytes) = e8 96 a8 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g64uBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x96,0xA8,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g16i(short lhs, short rhs)
; location: [7FFDD0C8FBB0h, 7FFDD0C8FBC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8FBE0h, 7FFDD0C8FBF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g16u(ushort lhs, ushort rhs)
; location: [7FFE0A57D1D0h, 7FFE0A57D1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE0A19F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g16uBytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d32i(int lhs, int rhs)
; location: [7FFDD0C8FC40h, 7FFDD0C8FC4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g32i(int lhs, int rhs)
; location: [7FFDD0C8FC60h, 7FFDD0C8FC6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d32u(uint lhs, uint rhs)
; location: [7FFDD0C8FC80h, 7FFDD0C8FC8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g32u(uint lhs, uint rhs)
; location: [7FFDD0C8FCA0h, 7FFDD0C8FCADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d64i(long lhs, long rhs)
; location: [7FFDD0C8FCC0h, 7FFDD0C8FCCEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g64i(long lhs, long rhs)
; location: [7FFDD0C8FCE0h, 7FFDD0C8FCEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8FD00h, 7FFDD0C8FD0Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C8FD20h, 7FFDD0C8FD2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d32f(float lhs, float rhs)
; location: [7FFDD0C8FD40h, 7FFDD0C8FD4Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g32f(float lhs, float rhs)
; location: [7FFDD0C8FD70h, 7FFDD0C8FD7Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d64f(double lhs, double rhs)
; location: [7FFDD0C8FDA0h, 7FFDD0C8FDAFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g64f(double lhs, double rhs)
; location: [7FFDD0C8FDD0h, 7FFDD0C8FDDFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C8FE00h, 7FFDD0C8FE15h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C8FE30h, 7FFDD0C8FE49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d8u(byte lhs, byte rhs)
; location: [7FFDD0C8FE60h, 7FFDD0C8FE73h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g8u(byte lhs, byte rhs)
; location: [7FFDD0C8FE90h, 7FFDD0C8FEA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d16i(short lhs, short rhs)
; location: [7FFDD0C8FEC0h, 7FFDD0C8FED5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g16i(short lhs, short rhs)
; location: [7FFDD0C8FEF0h, 7FFDD0C8FF09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8FF20h, 7FFDD0C8FF33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C8FF50h, 7FFDD0C8FF66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d32i(int lhs, int rhs)
; location: [7FFDD0C8FF80h, 7FFDD0C8FF8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g32i(int lhs, int rhs)
; location: [7FFDD0C8FFA0h, 7FFDD0C8FFADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d32u(uint lhs, uint rhs)
; location: [7FFDD0C8FFC0h, 7FFDD0C8FFCDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g32u(uint lhs, uint rhs)
; location: [7FFDD0C903F0h, 7FFDD0C903FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d64i(long lhs, long rhs)
; location: [7FFDD0C90410h, 7FFDD0C9041Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g64i(long lhs, long rhs)
; location: [7FFDD0C90430h, 7FFDD0C9043Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C90450h, 7FFDD0C9045Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C90470h, 7FFDD0C9047Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d32f(float lhs, float rhs)
; location: [7FFDD0C90490h, 7FFDD0C9049Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g32f(float lhs, float rhs)
; location: [7FFDD0C904C0h, 7FFDD0C904CFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d64f(double lhs, double rhs)
; location: [7FFDD0C904F0h, 7FFDD0C904FFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g64f(double lhs, double rhs)
; location: [7FFDD0C90520h, 7FFDD0C9052Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_d8i(sbyte x)
; location: [7FFDD0C90550h, 7FFDD0C9055Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_g8i(sbyte x)
; location: [7FFDD0C90570h, 7FFDD0C90594h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
000dh mov rax,[rsp+14h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 14
0012h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0015h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
001ah movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
0020h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g8iBytes => new byte[37]{0x48,0x83,0xEC,0x18,0x90,0x48,0x0F,0xBE,0xC1,0x88,0x44,0x24,0x14,0x48,0x8B,0x44,0x24,0x14,0x48,0xFF,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_d8u(byte x)
; location: [7FFDD0C905B0h, 7FFDD0C905BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_g8u(byte x)
; location: [7FFDD0C905D0h, 7FFDD0C905F2h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
000ch mov rax,[rsp+14h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 14
0011h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0014h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0019h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
001eh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g8uBytes => new byte[35]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC1,0x88,0x44,0x24,0x14,0x48,0x8B,0x44,0x24,0x14,0x48,0xFF,0xC0,0x48,0x89,0x44,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_d16i(short x)
; location: [7FFDD0C90610h, 7FFDD0C9061Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_g16i(short x)
; location: [7FFDD0C90630h, 7FFDD0C90655h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov [rsp+14h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 14
000eh mov rax,[rsp+14h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 14
0013h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0016h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
001bh movsx rax,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 08
0021h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g16iBytes => new byte[38]{0x48,0x83,0xEC,0x18,0x90,0x48,0x0F,0xBF,0xC1,0x66,0x89,0x44,0x24,0x14,0x48,0x8B,0x44,0x24,0x14,0x48,0xFF,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x0F,0xBF,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_d16u(ushort x)
; location: [7FFDD0C90670h, 7FFDD0C9067Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_g16u(ushort x)
; location: [7FFDD0C90AA0h, 7FFDD0C90AC3h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov [rsp+14h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 14
000dh mov rax,[rsp+14h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 14
0012h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0015h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
001ah movzx eax,word ptr [rsp+8]    ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 08
001fh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g16uBytes => new byte[36]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB7,0xC1,0x66,0x89,0x44,0x24,0x14,0x48,0x8B,0x44,0x24,0x14,0x48,0xFF,0xC0,0x48,0x89,0x44,0x24,0x08,0x0F,0xB7,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_d32i(int x)
; location: [7FFDD0C90AE0h, 7FFDD0C90AE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_g32i(int x)
; location: [7FFDD0C90B00h, 7FFDD0C90B1Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+14h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 14
0009h mov rax,[rsp+14h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 14
000eh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0011h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0016h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
001ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g32iBytes => new byte[31]{0x48,0x83,0xEC,0x18,0x90,0x89,0x4C,0x24,0x14,0x48,0x8B,0x44,0x24,0x14,0x48,0xFF,0xC0,0x48,0x89,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_d32u(uint x)
; location: [7FFDD0C90B40h, 7FFDD0C90B48h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_g32u(uint x)
; location: [7FFDD0C90B60h, 7FFDD0C90B7Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+14h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 14
0009h mov rax,[rsp+14h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 14
000eh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
0011h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0016h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
001ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g32uBytes => new byte[31]{0x48,0x83,0xEC,0x18,0x90,0x89,0x4C,0x24,0x14,0x48,0x8B,0x44,0x24,0x14,0x48,0xFF,0xC0,0x48,0x89,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_d64i(long x)
; location: [7FFDD0C90BA0h, 7FFDD0C90BA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_g64i(long x)
; location: [7FFDD0C90BC0h, 7FFDD0C90BCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                       ; INC(Inc_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_d64u(ulong x)
; location: [7FFDD0C90BE0h, 7FFDD0C90BE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_g64u(ulong x)
; location: [7FFDD0C90C00h, 7FFDD0C90C0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                       ; INC(Inc_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C90C20h, 7FFDD0C90C35h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C90C50h, 7FFDD0C90C69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d8u(byte lhs, byte rhs)
; location: [7FFDD0C90C80h, 7FFDD0C90C93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g8u(byte lhs, byte rhs)
; location: [7FFDD0C90CB0h, 7FFDD0C90CC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d16i(short lhs, short rhs)
; location: [7FFDD0C90CE0h, 7FFDD0C90CF5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g16i(short lhs, short rhs)
; location: [7FFDD0C91110h, 7FFDD0C91129h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C91140h, 7FFDD0C91153h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C91170h, 7FFDD0C91186h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d32i(int lhs, int rhs)
; location: [7FFDD0C911A0h, 7FFDD0C911ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g32i(int lhs, int rhs)
; location: [7FFDD0C911C0h, 7FFDD0C911CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d32u(uint lhs, uint rhs)
; location: [7FFDD0C911E0h, 7FFDD0C911EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g32u(uint lhs, uint rhs)
; location: [7FFDD0C91200h, 7FFDD0C9120Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d64i(long lhs, long rhs)
; location: [7FFDD0C91220h, 7FFDD0C9122Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g64i(long lhs, long rhs)
; location: [7FFDD0C91240h, 7FFDD0C9124Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C91260h, 7FFDD0C9126Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C91280h, 7FFDD0C9128Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C912A0h, 7FFDD0C912B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C912D0h, 7FFDD0C912E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d8u(byte lhs, byte rhs)
; location: [7FFDD0C91300h, 7FFDD0C91313h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g8u(byte lhs, byte rhs)
; location: [7FFDD0C91330h, 7FFDD0C91346h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d16i(short lhs, short rhs)
; location: [7FFDD0C91360h, 7FFDD0C91375h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g16i(short lhs, short rhs)
; location: [7FFDD0C91390h, 7FFDD0C913A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C913C0h, 7FFDD0C913D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C913F0h, 7FFDD0C91406h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d32i(int lhs, int rhs)
; location: [7FFDD0C91420h, 7FFDD0C9142Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g32i(int lhs, int rhs)
; location: [7FFDD0C91440h, 7FFDD0C9144Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d32u(uint lhs, uint rhs)
; location: [7FFDD0C91460h, 7FFDD0C9146Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g32u(uint lhs, uint rhs)
; location: [7FFDD0C91480h, 7FFDD0C9148Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d64i(long lhs, long rhs)
; location: [7FFDD0C914A0h, 7FFDD0C914AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g64i(long lhs, long rhs)
; location: [7FFDD0C914C0h, 7FFDD0C914CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C914E0h, 7FFDD0C914EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C91500h, 7FFDD0C9150Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C91520h, 7FFDD0C91537h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jg short 0013h                ; JG(Jg_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7f 02
0011h jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 02
0013h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C91550h, 7FFDD0C9156Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jg short 0017h                ; JG(Jg_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7f 02
0015h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 02
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g8iBytes => new byte[32]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte max_d8u(byte lhs, byte rhs)
; location: [7FFDD0C91590h, 7FFDD0C915A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jg short 0011h                ; JG(Jg_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7f 02
000fh jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 02
0011h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0013h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte max_g8u(byte lhs, byte rhs)
; location: [7FFDD0C919C0h, 7FFDD0C919DCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jg short 0014h                ; JG(Jg_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7f 02
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0016h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g8uBytes => new byte[29]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short max_d16i(short lhs, short rhs)
; location: [7FFDD0C91A00h, 7FFDD0C91A17h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jg short 0013h                ; JG(Jg_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7f 02
0011h jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 02
0013h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short max_g16i(short lhs, short rhs)
; location: [7FFDD0C91A30h, 7FFDD0C91A4Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jg short 0017h                ; JG(Jg_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7f 02
0015h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 02
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g16iBytes => new byte[32]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort max_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C91A70h, 7FFDD0C91A85h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jg short 0011h                ; JG(Jg_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7f 02
000fh jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 02
0011h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0013h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort max_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C91AA0h, 7FFDD0C91ABCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jg short 0014h                ; JG(Jg_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7f 02
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0016h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g16uBytes => new byte[29]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max_d32i(int lhs, int rhs)
; location: [7FFDD0C91AE0h, 7FFDD0C91AEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jg short 000bh                ; JG(Jg_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7f 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max_g32i(int lhs, int rhs)
; location: [7FFDD0C91B00h, 7FFDD0C91B13h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jg short 000bh                ; JG(Jg_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7f 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g32iBytes => new byte[20]{0x50,0x0F,0x1F,0x40,0x00,0x3B,0xCA,0x7F,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_d32u(uint lhs, uint rhs)
; location: [7FFDD0C91B30h, 7FFDD0C91B3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 000bh                ; JA(Ja_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 77 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_g32u(uint lhs, uint rhs)
; location: [7FFDD0C91B50h, 7FFDD0C91B63h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 000bh                ; JA(Ja_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 77 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g32uBytes => new byte[20]{0x50,0x0F,0x1F,0x40,0x00,0x3B,0xCA,0x77,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max_d64i(long lhs, long rhs)
; location: [7FFDD0C91B80h, 7FFDD0C91B92h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jg short 000ch                ; JG(Jg_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7f 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max_g64i(long lhs, long rhs)
; location: [7FFDD0C91BB0h, 7FFDD0C91BC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jg short 000ch                ; JG(Jg_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7f 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C91BE0h, 7FFDD0C91BF2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 000ch                ; JA(Ja_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 77 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C91C10h, 7FFDD0C91C22h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 000ch                ; JA(Ja_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 77 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C91C40h, 7FFDD0C91C57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 0013h                ; JL(Jl_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7c 02
0011h jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 02
0013h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C91C70h, 7FFDD0C91C8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c 02
0015h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 02
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g8iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte min_d8u(byte lhs, byte rhs)
; location: [7FFDD0C91CA0h, 7FFDD0C91CB5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 0011h                ; JL(Jl_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7c 02
000fh jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 02
0011h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0013h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte min_g8u(byte lhs, byte rhs)
; location: [7FFDD0C91CD0h, 7FFDD0C91CE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 02
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0016h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short min_d16i(short lhs, short rhs)
; location: [7FFDD0C91D00h, 7FFDD0C91D17h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 0013h                ; JL(Jl_rel8_64) [13h:jmp64]                           encoding(2 bytes) = 7c 02
0011h jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 02
0013h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short min_g16i(short lhs, short rhs)
; location: [7FFDD0C91D30h, 7FFDD0C91D4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jl short 0017h                ; JL(Jl_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7c 02
0015h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 02
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g16iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort min_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C91D60h, 7FFDD0C91D75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 0011h                ; JL(Jl_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7c 02
000fh jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 02
0011h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0013h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort min_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C91D90h, 7FFDD0C91DA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 02
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0016h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min_d32i(int lhs, int rhs)
; location: [7FFDD0C91DC0h, 7FFDD0C91DCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min_g32i(int lhs, int rhs)
; location: [7FFDD0C91DE0h, 7FFDD0C91DEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min_d32u(uint lhs, uint rhs)
; location: [7FFDD0C91E00h, 7FFDD0C91E0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 000bh                ; JB(Jb_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 72 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min_g32u(uint lhs, uint rhs)
; location: [7FFDD0C91E20h, 7FFDD0C91E2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 000bh                ; JB(Jb_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 72 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min_d64i(long lhs, long rhs)
; location: [7FFDD0C91E40h, 7FFDD0C91E52h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 000ch                ; JL(Jl_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7c 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min_g64i(long lhs, long rhs)
; location: [7FFDD0C91E70h, 7FFDD0C91E82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 000ch                ; JL(Jl_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7c 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C91EA0h, 7FFDD0C91EB2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 000ch                ; JB(Jb_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 72 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C922D0h, 7FFDD0C922E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 000ch                ; JB(Jb_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 72 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_n8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92300h, 7FFDD0C92314h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_n8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92330h, 7FFDD0C92344h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92360h, 7FFDD0C92378h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0012h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0014h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g8iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x48,0x0F,0xBE,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_n8u(byte lhs, byte rhs)
; location: [7FFDD0C92390h, 7FFDD0C923A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_n8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_d8u(byte lhs, byte rhs)
; location: [7FFDD0C923C0h, 7FFDD0C923D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_g8u(byte lhs, byte rhs)
; location: [7FFDD0C923F0h, 7FFDD0C92404h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000fh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0011h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x0F,0xB6,0xC0,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mod_d16i(short lhs, short rhs)
; location: [7FFDD0C92420h, 7FFDD0C92434h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mod_g16i(short lhs, short rhs)
; location: [7FFDD0C92450h, 7FFDD0C92468h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0012h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0014h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x48,0x0F,0xBF,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mod_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C92480h, 7FFDD0C92491h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mod_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C924B0h, 7FFDD0C924C4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000fh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0011h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x0F,0xB7,0xC0,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C924E0h, 7FFDD0C924F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C92510h, 7FFDD0C92524h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000fh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x0F,0xB7,0xC0,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div_d32i(int lhs, int rhs)
; location: [7FFDD0C92540h, 7FFDD0C9254Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div_g32i(int lhs, int rhs)
; location: [7FFDD0C92560h, 7FFDD0C9256Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_d32u(uint lhs, uint rhs)
; location: [7FFDD0C92580h, 7FFDD0C9258Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_g32u(uint lhs, uint rhs)
; location: [7FFDD0C925A0h, 7FFDD0C925AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_d64i(long lhs, long rhs)
; location: [7FFDD0C925C0h, 7FFDD0C925D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_g64i(long lhs, long rhs)
; location: [7FFDD0C925F0h, 7FFDD0C92600h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C92620h, 7FFDD0C92630h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C92650h, 7FFDD0C92660h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_d32f(float lhs, float rhs)
; location: [7FFDD0C92680h, 7FFDD0C92689h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_g32f(float lhs, float rhs)
; location: [7FFDD0C926A0h, 7FFDD0C926A9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_d64f(double lhs, double rhs)
; location: [7FFDD0C926C0h, 7FFDD0C926C9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_g64f(double lhs, double rhs)
; location: [7FFDD0C926E0h, 7FFDD0C926E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92700h, 7FFDD0C92718h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d8iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x48,0x0F,0xBE,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92730h, 7FFDD0C9274Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,al                  ; MOVSX(Movsx_r64_rm8) [RCX,AL]                        encoding(4 bytes) = 48 0f be c8
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0014h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0016h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0018h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g8iBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8u(byte lhs, byte rhs)
; location: [7FFDD0C92760h, 7FFDD0C92776h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g8u(byte lhs, byte rhs)
; location: [7FFDD0C92790h, 7FFDD0C927ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0011h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g8uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d16i(short lhs, short rhs)
; location: [7FFDD0C927C0h, 7FFDD0C927D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x48,0x0F,0xBF,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g16i(short lhs, short rhs)
; location: [7FFDD0C927F0h, 7FFDD0C9280Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,ax                  ; MOVSX(Movsx_r64_rm16) [RCX,AX]                       encoding(4 bytes) = 48 0f bf c8
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0014h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0016h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0018h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g16iBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C92820h, 7FFDD0C92836h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C92850h, 7FFDD0C9286Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,ax                  ; MOVZX(Movzx_r32_rm16) [ECX,AX]                       encoding(3 bytes) = 0f b7 c8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0011h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g16uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32i(int lhs, int rhs)
; location: [7FFDD0C92880h, 7FFDD0C92892h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0008h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32i(int lhs, int rhs)
; location: [7FFDD0C928B0h, 7FFDD0C928C2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0008h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32u(uint lhs, uint rhs)
; location: [7FFDD0C928E0h, 7FFDD0C928F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0009h div ecx                       ; DIV(Div_rm32) [ECX]                                  encoding(2 bytes) = f7 f1
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32u(uint lhs, uint rhs)
; location: [7FFDD0C92D10h, 7FFDD0C92D23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0009h div ecx                       ; DIV(Div_rm32) [ECX]                                  encoding(2 bytes) = f7 f1
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64i(long lhs, long rhs)
; location: [7FFDD0C92D40h, 7FFDD0C92D56h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000ah idiv rcx                      ; IDIV(Idiv_rm64) [RCX]                                encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64i(long lhs, long rhs)
; location: [7FFDD0C92D70h, 7FFDD0C92D86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000ah idiv rcx                      ; IDIV(Idiv_rm64) [RCX]                                encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C92DA0h, 7FFDD0C92DB6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah div rcx                       ; DIV(Div_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C92DD0h, 7FFDD0C92DE6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah div rcx                       ; DIV(Div_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32f(float lhs, float rhs)
; location: [7FFDD0C92E00h, 7FFDD0C92E2Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE30220790h            ; CALL(Call_rel32_64) [5F58D990h:jmp64]                encoding(5 bytes) = e8 78 d9 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x78,0xD9,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32f(float lhs, float rhs)
; location: [7FFDD0C92E50h, 7FFDD0C92E7Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE30220790h            ; CALL(Call_rel32_64) [5F58D940h:jmp64]                encoding(5 bytes) = e8 28 d9 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x28,0xD9,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64f(double lhs, double rhs)
; location: [7FFDD0C92EA0h, 7FFDD0C92ECFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE30220700h            ; CALL(Call_rel32_64) [5F58D860h:jmp64]                encoding(5 bytes) = e8 48 d8 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x48,0xD8,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64f(double lhs, double rhs)
; location: [7FFDD0C92EF0h, 7FFDD0C92F1Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE30220700h            ; CALL(Call_rel32_64) [5F58D810h:jmp64]                encoding(5 bytes) = e8 f8 d7 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0xF8,0xD7,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92F40h, 7FFDD0C92F55h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C92F70h, 7FFDD0C92F89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d8u(byte lhs, byte rhs)
; location: [7FFDD0C92FA0h, 7FFDD0C92FB3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g8u(byte lhs, byte rhs)
; location: [7FFDD0C92FD0h, 7FFDD0C92FE6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d16i(short lhs, short rhs)
; location: [7FFDD0C93000h, 7FFDD0C93015h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g16i(short lhs, short rhs)
; location: [7FFDD0C93030h, 7FFDD0C93049h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C93060h, 7FFDD0C93073h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C93090h, 7FFDD0C930A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d32i(int lhs, int rhs)
; location: [7FFDD0C930C0h, 7FFDD0C930CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g32i(int lhs, int rhs)
; location: [7FFDD0C930E0h, 7FFDD0C930EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d32u(uint lhs, uint rhs)
; location: [7FFDD0C93100h, 7FFDD0C9310Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g32u(uint lhs, uint rhs)
; location: [7FFDD0C93120h, 7FFDD0C9312Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d64i(long lhs, long rhs)
; location: [7FFDD0C93140h, 7FFDD0C9314Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g64i(long lhs, long rhs)
; location: [7FFDD0C93160h, 7FFDD0C9316Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C93180h, 7FFDD0C9318Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C931A0h, 7FFDD0C931AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d32f(float lhs, float rhs)
; location: [7FFDD0C931C0h, 7FFDD0C931D4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g32f(float lhs, float rhs)
; location: [7FFDD0C931F0h, 7FFDD0C93204h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d64f(double lhs, double rhs)
; location: [7FFDD0C93220h, 7FFDD0C93234h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g64f(double lhs, double rhs)
; location: [7FFDD0C93250h, 7FFDD0C93264h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C93280h, 7FFDD0C93295h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C932B0h, 7FFDD0C932C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d8u(byte lhs, byte rhs)
; location: [7FFDD0C932E0h, 7FFDD0C932F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g8u(byte lhs, byte rhs)
; location: [7FFDD0C93310h, 7FFDD0C93326h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d16i(short lhs, short rhs)
; location: [7FFDD0C93340h, 7FFDD0C93355h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g16i(short lhs, short rhs)
; location: [7FFDD0C93370h, 7FFDD0C93389h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C933A0h, 7FFDD0C933B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C933D0h, 7FFDD0C933E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d32i(int lhs, int rhs)
; location: [7FFDD0C93400h, 7FFDD0C9340Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g32i(int lhs, int rhs)
; location: [7FFDD0C93420h, 7FFDD0C9342Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d32u(uint lhs, uint rhs)
; location: [7FFDD0C93440h, 7FFDD0C9344Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g32u(uint lhs, uint rhs)
; location: [7FFDD0C93460h, 7FFDD0C9346Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d64i(long lhs, long rhs)
; location: [7FFDD0C93480h, 7FFDD0C9348Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g64i(long lhs, long rhs)
; location: [7FFDD0C938B0h, 7FFDD0C938BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C938D0h, 7FFDD0C938DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C938F0h, 7FFDD0C938FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d32f(float lhs, float rhs)
; location: [7FFDD0C93910h, 7FFDD0C93924h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g32f(float lhs, float rhs)
; location: [7FFDD0C93940h, 7FFDD0C93954h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d64f(double lhs, double rhs)
; location: [7FFDD0C93970h, 7FFDD0C93984h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g64f(double lhs, double rhs)
; location: [7FFDD0C939A0h, 7FFDD0C939B4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setp al                       ; SETP(Setp_rm8) [AL]                                  encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                ; JP(Jp_rel8_64) [11h:jmp64]                           encoding(2 bytes) = 7a 03
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d8i(sbyte x)
; location: [7FFDD0C939D0h, 7FFDD0C939E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g8i(sbyte x)
; location: [7FFDD0C93A00h, 7FFDD0C93A19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d8u(byte x)
; location: [7FFDD0C93A30h, 7FFDD0C93A40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g8u(byte x)
; location: [7FFDD0C93A60h, 7FFDD0C93A78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d16i(short x)
; location: [7FFDD0C93A90h, 7FFDD0C93AA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g16i(short x)
; location: [7FFDD0C93AC0h, 7FFDD0C93AD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d16u(ushort x)
; location: [7FFDD0C93AF0h, 7FFDD0C93B00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g16u(ushort x)
; location: [7FFDD0C93B20h, 7FFDD0C93B38h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d32i(int x)
; location: [7FFDD0C93B50h, 7FFDD0C93B5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g32i(int x)
; location: [7FFDD0C93B70h, 7FFDD0C93B86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d32u(uint x)
; location: [7FFDD0C93BA0h, 7FFDD0C93BAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g32u(uint x)
; location: [7FFDD0C93BC0h, 7FFDD0C93BD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d64i(long x)
; location: [7FFDD0C93BF0h, 7FFDD0C93BFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g64i(long x)
; location: [7FFDD0C93C10h, 7FFDD0C93C26h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_d64u(ulong x)
; location: [7FFDD0C93C40h, 7FFDD0C93C4Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g64u(ulong x)
; location: [7FFDD0C93C60h, 7FFDD0C93C76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d8i(sbyte x)
; location: [7FFDD0C93C90h, 7FFDD0C93CA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g8i(sbyte x)
; location: [7FFDD0C93CC0h, 7FFDD0C93CD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d8u(byte x)
; location: [7FFDD0C93CF0h, 7FFDD0C93D00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g8u(byte x)
; location: [7FFDD0C93D20h, 7FFDD0C93D30h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d16i(short x)
; location: [7FFDD0C93D50h, 7FFDD0C93D61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g16i(short x)
; location: [7FFDD0C93D80h, 7FFDD0C93D91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d16u(ushort x)
; location: [7FFDD0C93DB0h, 7FFDD0C93DC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g16u(ushort x)
; location: [7FFDD0C93DE0h, 7FFDD0C93DF0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d32i(int x)
; location: [7FFDD0C93E10h, 7FFDD0C93E1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g32i(int x)
; location: [7FFDD0C93E30h, 7FFDD0C93E3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d32u(uint x)
; location: [7FFDD0C93E50h, 7FFDD0C93E5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g32u(uint x)
; location: [7FFDD0C93E70h, 7FFDD0C93E7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d64i(long x)
; location: [7FFDD0C93E90h, 7FFDD0C93E9Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g64i(long x)
; location: [7FFDD0C93EB0h, 7FFDD0C93EBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d64u(ulong x)
; location: [7FFDD0C93ED0h, 7FFDD0C93EDEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g64u(ulong x)
; location: [7FFDD0C93EF0h, 7FFDD0C93EFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma_d8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDD0C93F10h, 7FFDD0C93F2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0014h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0016h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d8iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x49,0x0F,0xBE,0xD0,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma_g8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDD0C93F40h, 7FFDD0C93F62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,r8b                 ; MOVSX(Movsx_r64_rm8) [RCX,R8L]                       encoding(4 bytes) = 49 0f be c8
0011h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0015h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0019h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
001ch add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
001eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g8iBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x49,0x0F,0xBE,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte fma_d8u(byte x, byte a, byte b)
; location: [7FFDD0C93F80h, 7FFDD0C93F97h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0012h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d8uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x41,0x0F,0xB6,0xD0,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte fma_g8u(byte x, byte a, byte b)
; location: [7FFDD0C93FB0h, 7FFDD0C93FCDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0018h add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g8uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short fma_d16i(short x, short a, short b)
; location: [7FFDD0C93FE0h, 7FFDD0C93FFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0014h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0016h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x49,0x0F,0xBF,0xD0,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short fma_g16i(short x, short a, short b)
; location: [7FFDD0C94010h, 7FFDD0C94032h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,r8w                 ; MOVSX(Movsx_r64_rm16) [RCX,R8W]                      encoding(4 bytes) = 49 0f bf c8
0011h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0015h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0019h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
001ch add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
001eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g16iBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x49,0x0F,0xBF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort fma_d16u(ushort x, ushort a, ushort b)
; location: [7FFDD0C94050h, 7FFDD0C94067h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0012h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d16uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x41,0x0F,0xB7,0xD0,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort fma_g16u(ushort x, ushort a, ushort b)
; location: [7FFDD0C94080h, 7FFDD0C9409Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,r8w                 ; MOVZX(Movzx_r32_rm16) [ECX,R8W]                      encoding(4 bytes) = 41 0f b7 c8
000fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0012h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0015h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0018h add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
001ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g16uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x41,0x0F,0xB7,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma_d32i(int x, int a, int b)
; location: [7FFDD0C940B0h, 7FFDD0C940BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma_g32i(int x, int a, int b)
; location: [7FFDD0C940D0h, 7FFDD0C940DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_d32u(uint x, uint a, uint b)
; location: [7FFDD0C940F0h, 7FFDD0C940FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_g32u(uint x, uint a, uint b)
; location: [7FFDD0C94110h, 7FFDD0C9411Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_d64i(long x, long a, long b)
; location: [7FFDD0C94130h, 7FFDD0C9413Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_g64i(long x, long a, long b)
; location: [7FFDD0C94150h, 7FFDD0C9415Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_d64u(ulong x, ulong a, ulong b)
; location: [7FFDD0C94170h, 7FFDD0C9417Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_g64u(ulong x, ulong a, ulong b)
; location: [7FFDD0C945A0h, 7FFDD0C945AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_d32f(float x, float a, float b)
; location: [7FFDD0C945C0h, 7FFDD0C945CAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2    ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_g32f(float x, float a, float b)
; location: [7FFDD0C945E0h, 7FFDD0C945EAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2    ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_d64f(double x, double a, double b)
; location: [7FFDD0C94600h, 7FFDD0C9460Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2    ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_g64f(double x, double a, double b)
; location: [7FFDD0C94620h, 7FFDD0C9462Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2    ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C94640h, 7FFDD0C94655h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C94670h, 7FFDD0C94689h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C946A0h, 7FFDD0C946B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C946D0h, 7FFDD0C946E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_d8u(byte lhs, byte rhs)
; location: [7FFDD0C94700h, 7FFDD0C94710h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_g8u(byte lhs, byte rhs)
; location: [7FFDD0C94730h, 7FFDD0C94743h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_d16i(short lhs, short rhs)
; location: [7FFDD0C94760h, 7FFDD0C94773h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_g16i(short lhs, short rhs)
; location: [7FFDD0C94790h, 7FFDD0C947A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C947C0h, 7FFDD0C947D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C947F0h, 7FFDD0C94803h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_d32i(int lhs, int rhs)
; location: [7FFDD0C94820h, 7FFDD0C94828h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_g32i(int lhs, int rhs)
; location: [7FFDD0C94840h, 7FFDD0C94849h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_d32u(uint lhs, uint rhs)
; location: [7FFDD0C94860h, 7FFDD0C94868h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_g32u(uint lhs, uint rhs)
; location: [7FFDD0C94880h, 7FFDD0C94889h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_d64i(long lhs, long rhs)
; location: [7FFDD0C948A0h, 7FFDD0C948A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_g64i(long lhs, long rhs)
; location: [7FFDD0C948C0h, 7FFDD0C948CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C948E0h, 7FFDD0C948E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C94900h, 7FFDD0C9490Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDD0C94920h, 7FFDD0C94941h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 001fh                ; JL(Jl_rel8_64) [1Fh:jmp64]                           encoding(2 bytes) = 7c 0e
0011h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0015h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0017h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 02
001fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d8iBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x0E,0x49,0x0F,0xBE,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDD0C94960h, 7FFDD0C94989h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,r8b                 ; MOVSX(Movsx_r64_rm8) [RCX,R8L]                       encoding(4 bytes) = 49 0f be c8
0011h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0015h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0019h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
001bh jl short 0027h                ; JL(Jl_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 7c 0a
001dh cmp eax,ecx                   ; CMP(Cmp_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 3b c1
001fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h jmp short 0029h               ; JMP(Jmp_rel8_64) [29h:jmp64]                         encoding(2 bytes) = eb 02
0027h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g8iBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x49,0x0F,0xBE,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d8u(byte x, byte a, byte b)
; location: [7FFDD0C949A0h, 7FFDD0C949BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 001dh                ; JL(Jl_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 7c 0e
000fh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0013h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0015h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 02
001dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d8uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x0E,0x41,0x0F,0xB6,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g8u(byte x, byte a, byte b)
; location: [7FFDD0C949D0h, 7FFDD0C949F5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0017h jl short 0023h                ; JL(Jl_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 7c 0a
0019h cmp eax,ecx                   ; CMP(Cmp_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 3b c1
001bh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h               ; JMP(Jmp_rel8_64) [25h:jmp64]                         encoding(2 bytes) = eb 02
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g8uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d16i(short x, short a, short b)
; location: [7FFDD0C94A10h, 7FFDD0C94A31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 001fh                ; JL(Jl_rel8_64) [1Fh:jmp64]                           encoding(2 bytes) = 7c 0e
0011h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0015h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0017h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 02
001fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d16iBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x0E,0x49,0x0F,0xBF,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g16i(short x, short a, short b)
; location: [7FFDD0C94A50h, 7FFDD0C94A79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,r8w                 ; MOVSX(Movsx_r64_rm16) [RCX,R8W]                      encoding(4 bytes) = 49 0f bf c8
0011h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0015h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0019h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
001bh jl short 0027h                ; JL(Jl_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 7c 0a
001dh cmp eax,ecx                   ; CMP(Cmp_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 3b c1
001fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h jmp short 0029h               ; JMP(Jmp_rel8_64) [29h:jmp64]                         encoding(2 bytes) = eb 02
0027h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g16iBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x49,0x0F,0xBF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d16u(ushort x, ushort a, ushort b)
; location: [7FFDD0C94A90h, 7FFDD0C94AAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 001dh                ; JL(Jl_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 7c 0e
000fh movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0013h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0015h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 02
001dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d16uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x0E,0x41,0x0F,0xB7,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g16u(ushort x, ushort a, ushort b)
; location: [7FFDD0C94AC0h, 7FFDD0C94AE5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,r8w                 ; MOVZX(Movzx_r32_rm16) [ECX,R8W]                      encoding(4 bytes) = 41 0f b7 c8
000fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0012h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0015h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0017h jl short 0023h                ; JL(Jl_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 7c 0a
0019h cmp eax,ecx                   ; CMP(Cmp_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 3b c1
001bh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h               ; JMP(Jmp_rel8_64) [25h:jmp64]                         encoding(2 bytes) = eb 02
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g16uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x41,0x0F,0xB7,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d32i(int x, int a, int b)
; location: [7FFDD0C94B00h, 7FFDD0C94B16h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0B,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g32i(int x, int a, int b)
; location: [7FFDD0C94F30h, 7FFDD0C94F46h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0B,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d32u(uint x, uint a, uint b)
; location: [7FFDD0C94F60h, 7FFDD0C94F76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 0014h                ; JB(Jb_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 72 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0B,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g32u(uint x, uint a, uint b)
; location: [7FFDD0C94F90h, 7FFDD0C94FA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 0014h                ; JB(Jb_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 72 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0B,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d64i(long x, long a, long b)
; location: [7FFDD0C94FC0h, 7FFDD0C94FD7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 0015h                ; JL(Jl_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7c 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d64iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0B,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g64i(long x, long a, long b)
; location: [7FFDD0C94FF0h, 7FFDD0C95007h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 0015h                ; JL(Jl_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7c 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g64iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0B,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d64u(ulong x, ulong a, ulong b)
; location: [7FFDD0C95020h, 7FFDD0C95037h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 0015h                ; JB(Jb_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 72 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0B,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_g64u(ulong x, ulong a, ulong b)
; location: [7FFDD0C95050h, 7FFDD0C95067h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 0015h                ; JB(Jb_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 72 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0B,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte one_n8i()
; location: [7FFDD0C95080h, 7FFDD0C9508Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte one_g8i()
; location: [7FFDD0C950A0h, 7FFDD0C950AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_n8u()
; location: [7FFDD0C950C0h, 7FFDD0C950CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_g8u()
; location: [7FFDD0C950E0h, 7FFDD0C950EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short one_n16i()
; location: [7FFDD0C95100h, 7FFDD0C9510Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short one_g16i()
; location: [7FFDD0C95120h, 7FFDD0C9512Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_n16u()
; location: [7FFDD0C95140h, 7FFDD0C9514Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_g16u()
; location: [7FFDD0C95570h, 7FFDD0C9557Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_n32i()
; location: [7FFDD0C95590h, 7FFDD0C9559Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_g32i()
; location: [7FFDD0C955B0h, 7FFDD0C955BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_n32u()
; location: [7FFDD0C955D0h, 7FFDD0C955DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_g32u()
; location: [7FFDD0C955F0h, 7FFDD0C955FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_n64i()
; location: [7FFDD0C95610h, 7FFDD0C9561Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_g64i()
; location: [7FFDD0C95630h, 7FFDD0C9563Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_n64u()
; location: [7FFDD0C95650h, 7FFDD0C9565Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_g64u()
; location: [7FFDD0C95670h, 7FFDD0C9567Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_n32f()
; location: [7FFDD0C95690h, 7FFDD0C9569Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDD0C956A0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_g32f()
; location: [7FFDD0C956C0h, 7FFDD0C956CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDD0C956D0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_n64f()
; location: [7FFDD0C956F0h, 7FFDD0C956FDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDD0C95700h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_g64f()
; location: [7FFDD0C95720h, 7FFDD0C95732h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64fBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xB8,0x01,0x00,0x00,0x00,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte zero_g8i()
; location: [7FFDD0C95750h, 7FFDD0C95757h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g8iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte zero_g8u()
; location: [7FFDD0C95770h, 7FFDD0C95777h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short zero_g16i()
; location: [7FFDD0C95790h, 7FFDD0C95797h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g16iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort zero_g16u()
; location: [7FFDD0C957B0h, 7FFDD0C957B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int zero_g32i()
; location: [7FFDD0C957D0h, 7FFDD0C957D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint zero_g32u()
; location: [7FFDD0C957F0h, 7FFDD0C957F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long zero_g64i()
; location: [7FFDD0C95810h, 7FFDD0C95817h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong zero_g64u()
; location: [7FFDD0C95830h, 7FFDD0C95837h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float zero_g32f()
; location: [7FFDD0C95850h, 7FFDD0C95859h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double zero_g64f()
; location: [7FFDD0C95870h, 7FFDD0C95882h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64fBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xB8,0x01,0x00,0x00,0x00,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_n8i()
; location: [7FFDD0C958A0h, 7FFDD0C958AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h            ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]             encoding(5 bytes) = b8 80 ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_g8i()
; location: [7FFDD0C95E10h, 7FFDD0C95E1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h            ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]             encoding(5 bytes) = b8 80 ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_n8u()
; location: [7FFDD0C95E30h, 7FFDD0C95E37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_g8u()
; location: [7FFDD0C95E50h, 7FFDD0C95E57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_n16i()
; location: [7FFDD0C95E70h, 7FFDD0C95E7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h            ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]             encoding(5 bytes) = b8 00 80 ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_g16i()
; location: [7FFDD0C95E90h, 7FFDD0C95E9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h            ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]             encoding(5 bytes) = b8 00 80 ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort minval_g16u()
; location: [7FFDD0C95EB0h, 7FFDD0C95EB7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_32i()
; location: [7FFDD0C95ED0h, 7FFDD0C95EDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h             ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]             encoding(5 bytes) = b8 00 00 00 80
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_g32i()
; location: [7FFDD0C95EF0h, 7FFDD0C95EFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h             ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]             encoding(5 bytes) = b8 00 00 00 80
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_32u()
; location: [7FFDD0C95F10h, 7FFDD0C95F17h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_g32u()
; location: [7FFDD0C95F30h, 7FFDD0C95F37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long minval_g64i()
; location: [7FFDD0C96350h, 7FFDD0C9635Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong minval_g64u()
; location: [7FFDD0C96370h, 7FFDD0C96377h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float minval_g32f()
; location: [7FFDD0C96390h, 7FFDD0C9639Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDD0C963A0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double minval_g64f()
; location: [7FFDD0C963C0h, 7FFDD0C963CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDD0C963D0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte maxval_g8i()
; location: [7FFDD0C963F0h, 7FFDD0C963FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7Fh                   ; MOV(Mov_r32_imm32) [EAX,7fh:imm32]                   encoding(5 bytes) = b8 7f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte maxval_g8u()
; location: [7FFDD0C96410h, 7FFDD0C9641Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short maxval_g16i()
; location: [7FFDD0C96430h, 7FFDD0C9643Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFh                 ; MOV(Mov_r32_imm32) [EAX,7fffh:imm32]                 encoding(5 bytes) = b8 ff 7f 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x7F,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort maxval_g16u()
; location: [7FFDD0C96450h, 7FFDD0C9645Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFh                ; MOV(Mov_r32_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = b8 ff ff 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_n32i()
; location: [7FFDD0C96470h, 7FFDD0C9647Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh             ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_g32i()
; location: [7FFDD0C96490h, 7FFDD0C9649Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh             ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_n32u()
; location: [7FFDD0C964B0h, 7FFDD0C964BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_g32u()
; location: [7FFDD0C968E0h, 7FFDD0C968EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long maxval_g64i()
; location: [7FFDD0C96900h, 7FFDD0C9690Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFFFFFFFFFFFFFFh     ; MOV(Mov_r64_imm64) [RAX,7fffffffffffffffh:imm64]     encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff 7f
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong maxval_g64u()
; location: [7FFDD0C96920h, 7FFDD0C9692Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFFFFFFFFFFh    ; MOV(Mov_r64_imm64) [RAX,ffffffffffffffffh:imm64]     encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff ff
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float maxval_g32f()
; location: [7FFDD0C96940h, 7FFDD0C9694Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDD0C96950h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_n64f()
; location: [7FFDD0C96970h, 7FFDD0C9697Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDD0C96980h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_g64f()
; location: [7FFDD0C969A0h, 7FFDD0C969ADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDD0C969B0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_d8i(sbyte x)
; location: [7FFDD0C969D0h, 7FFDD0C969DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_g8i(sbyte x)
; location: [7FFDD0C969F0h, 7FFDD0C96A03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_d8u(byte x)
; location: [7FFDD0C96A20h, 7FFDD0C96A2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_g8u(byte x)
; location: [7FFDD0C96A40h, 7FFDD0C96A50h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_d16i(short x)
; location: [7FFDD0C96A70h, 7FFDD0C96A7Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_g16i(short x)
; location: [7FFDD0C96A90h, 7FFDD0C96AA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_d16u(ushort x)
; location: [7FFDD0C96AC0h, 7FFDD0C96ACDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_g16u(ushort x)
; location: [7FFDD0C96AE0h, 7FFDD0C96AF0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_d32i(int x)
; location: [7FFDD0C96B10h, 7FFDD0C96B18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_g32i(int x)
; location: [7FFDD0C96B30h, 7FFDD0C96B39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_d32u(uint x)
; location: [7FFDD0C96B50h, 7FFDD0C96B58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_g32u(uint x)
; location: [7FFDD0C96B70h, 7FFDD0C96B79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_d64i(long x)
; location: [7FFDD0C96B90h, 7FFDD0C96B99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_g64i(long x)
; location: [7FFDD0C96BB0h, 7FFDD0C96BBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_d64u(ulong x)
; location: [7FFDD0C96BD0h, 7FFDD0C96BD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_g64u(ulong x)
; location: [7FFDD0C96BF0h, 7FFDD0C96BFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C96C10h, 7FFDD0C96C2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jge short 0018h               ; JGE(Jge_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 7d 07
0011h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0013h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0016h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 05
0018h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d8iBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C96C40h, 7FFDD0C96C61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jge short 001ch               ; JGE(Jge_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = 7d 07
0015h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0017h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
001ah jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 05
001ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
001eh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g8iBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d8u(byte lhs, byte rhs)
; location: [7FFDD0C96C80h, 7FFDD0C96C9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jge short 0016h               ; JGE(Jge_rel8_64) [16h:jmp64]                         encoding(2 bytes) = 7d 07
000fh sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0011h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0014h jmp short 001bh               ; JMP(Jmp_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = eb 05
0016h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0018h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d8uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g8u(byte lhs, byte rhs)
; location: [7FFDD0C96CB0h, 7FFDD0C96CCEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jge short 0019h               ; JGE(Jge_rel8_64) [19h:jmp64]                         encoding(2 bytes) = 7d 07
0012h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0014h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0017h jmp short 001eh               ; JMP(Jmp_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = eb 05
0019h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
001bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g8uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d16i(short lhs, short rhs)
; location: [7FFDD0C96CE0h, 7FFDD0C96CFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jge short 0018h               ; JGE(Jge_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 7d 07
0011h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0013h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0016h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 05
0018h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d16iBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g16i(short lhs, short rhs)
; location: [7FFDD0C97120h, 7FFDD0C97141h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jge short 001ch               ; JGE(Jge_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = 7d 07
0015h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0017h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
001ah jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 05
001ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
001eh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g16iBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C97160h, 7FFDD0C9717Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jge short 0016h               ; JGE(Jge_rel8_64) [16h:jmp64]                         encoding(2 bytes) = 7d 07
000fh sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0011h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0014h jmp short 001bh               ; JMP(Jmp_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = eb 05
0016h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0018h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d16uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C97190h, 7FFDD0C971AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jge short 0019h               ; JGE(Jge_rel8_64) [19h:jmp64]                         encoding(2 bytes) = 7d 07
0012h sub edx,eax                   ; SUB(Sub_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 2b d0
0014h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0017h jmp short 001eh               ; JMP(Jmp_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = eb 05
0019h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
001bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g16uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x7D,0x07,0x2B,0xD0,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xC2,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d32i(int lhs, int rhs)
; location: [7FFDD0C971C0h, 7FFDD0C971D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jge short 0010h               ; JGE(Jge_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 7d 07
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
000eh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 05
0010h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0012h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d32iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7D,0x07,0x2B,0xD1,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g32i(int lhs, int rhs)
; location: [7FFDD0C971F0h, 7FFDD0C97205h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jge short 0010h               ; JGE(Jge_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 7d 07
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
000eh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 05
0010h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0012h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g32iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7D,0x07,0x2B,0xD1,0x48,0x63,0xC2,0xEB,0x05,0x2B,0xCA,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d32u(uint lhs, uint rhs)
; location: [7FFDD0C97220h, 7FFDD0C97233h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jae short 000fh               ; JAE(Jae_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 73 06
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 04
000fh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0011h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x73,0x06,0x2B,0xD1,0x8B,0xC2,0xEB,0x04,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g32u(uint lhs, uint rhs)
; location: [7FFDD0C97250h, 7FFDD0C97263h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jae short 000fh               ; JAE(Jae_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 73 06
0009h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh jmp short 0013h               ; JMP(Jmp_rel8_64) [13h:jmp64]                         encoding(2 bytes) = eb 04
000fh sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0011h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x73,0x06,0x2B,0xD1,0x8B,0xC2,0xEB,0x04,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d64i(long lhs, long rhs)
; location: [7FFDD0C97280h, 7FFDD0C97298h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jge short 0012h               ; JGE(Jge_rel8_64) [12h:jmp64]                         encoding(2 bytes) = 7d 08
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
0010h jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 06
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d64iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7D,0x08,0x48,0x8B,0xC2,0x48,0x2B,0xC1,0xEB,0x06,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g64i(long lhs, long rhs)
; location: [7FFDD0C972B0h, 7FFDD0C972C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jge short 000fh               ; JGE(Jge_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 7d 05
000ah sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
000dh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 06
000fh sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0012h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0015h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g64iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7D,0x05,0x48,0x2B,0xD1,0xEB,0x06,0x48,0x2B,0xCA,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C972E0h, 7FFDD0C972F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jae short 0012h               ; JAE(Jae_rel8_64) [12h:jmp64]                         encoding(2 bytes) = 73 08
000ah mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000dh sub rax,rcx                   ; SUB(Sub_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 2b c1
0010h jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 06
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_d64uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x73,0x08,0x48,0x8B,0xC2,0x48,0x2B,0xC1,0xEB,0x06,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C97310h, 7FFDD0C97328h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jae short 000fh               ; JAE(Jae_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = 73 05
000ah sub rdx,rcx                   ; SUB(Sub_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 2b d1
000dh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 06
000fh sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0012h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0015h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dist_g64uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x73,0x05,0x48,0x2B,0xD1,0xEB,0x06,0x48,0x2B,0xCA,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C97340h, 7FFDD0C97354h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C97370h, 7FFDD0C97388h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0012h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0014h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g8iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x48,0x0F,0xBE,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte div_d8u(byte lhs, byte rhs)
; location: [7FFDD0C973A0h, 7FFDD0C973B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte div_g8u(byte lhs, byte rhs)
; location: [7FFDD0C973D0h, 7FFDD0C973E4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000fh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x0F,0xB6,0xC0,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short div_d16i(short lhs, short rhs)
; location: [7FFDD0C97400h, 7FFDD0C97414h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short div_g16i(short lhs, short rhs)
; location: [7FFDD0C97430h, 7FFDD0C97448h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0012h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0014h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x48,0x0F,0xBF,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C97460h, 7FFDD0C97473h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C97490h, 7FFDD0C974A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_d8u(byte lhs, byte rhs)
; location: [7FFDD0C974C0h, 7FFDD0C974D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_g8u(byte lhs, byte rhs)
; location: [7FFDD0C974F0h, 7FFDD0C97503h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_d16i(short lhs, short rhs)
; location: [7FFDD0C97520h, 7FFDD0C97533h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_g16i(short lhs, short rhs)
; location: [7FFDD0C97550h, 7FFDD0C97567h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C97580h, 7FFDD0C97590h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C975B0h, 7FFDD0C975C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_d32i(int lhs, int rhs)
; location: [7FFDD0C975E0h, 7FFDD0C975E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_g32i(int lhs, int rhs)
; location: [7FFDD0C97600h, 7FFDD0C97609h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_d32u(uint lhs, uint rhs)
; location: [7FFDD0C97620h, 7FFDD0C97629h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_g32u(uint lhs, uint rhs)
; location: [7FFDD0C97640h, 7FFDD0C97649h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_d64i(long lhs, long rhs)
; location: [7FFDD0C97660h, 7FFDD0C9766Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_g64i(long lhs, long rhs)
; location: [7FFDD0C97680h, 7FFDD0C9768Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C976A0h, 7FFDD0C976ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C976C0h, 7FFDD0C976CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_d32f(float lhs, float rhs)
; location: [7FFDD0C976E0h, 7FFDD0C97709h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_g32f(float lhs, float rhs)
; location: [7FFDD0C97B30h, 7FFDD0C97B59h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and_d64f(double lhs, double rhs)
; location: [7FFDD0C97B80h, 7FFDD0C97BAAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and_g64f(double lhs, double rhs)
; location: [7FFDD0C97BD0h, 7FFDD0C97BFAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte flip_d8i(sbyte x)
; location: [7FFDD0C97C20h, 7FFDD0C97C2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte flip_g8i(sbyte x)
; location: [7FFDD0C97C40h, 7FFDD0C97C4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte flip_d8u(byte x)
; location: [7FFDD0C97C60h, 7FFDD0C97C6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte flip_g8u(byte x)
; location: [7FFDD0C97C80h, 7FFDD0C97C8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short flip_d16i(short x)
; location: [7FFDD0C97CA0h, 7FFDD0C97CAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short flip_g16i(short x)
; location: [7FFDD0C97CC0h, 7FFDD0C97CCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort flip_d16u(ushort x)
; location: [7FFDD0C97CE0h, 7FFDD0C97CEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort flip_g16u(ushort x)
; location: [7FFDD0C97D00h, 7FFDD0C97D0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int flip_d32i(int x)
; location: [7FFDD0C97D20h, 7FFDD0C97D29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int flip_g32i(int x)
; location: [7FFDD0C97D40h, 7FFDD0C97D49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint flip_d32u(uint x)
; location: [7FFDD0C97D60h, 7FFDD0C97D69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint flip_g32u(uint x)
; location: [7FFDD0C97D80h, 7FFDD0C97D89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long flip_d64i(long x)
; location: [7FFDD0C97DA0h, 7FFDD0C97DABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long flip_g64i(long x)
; location: [7FFDD0C97DC0h, 7FFDD0C97DCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong flip_d64u(ulong x)
; location: [7FFDD0C97DE0h, 7FFDD0C97DEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong flip_g64u(ulong x)
; location: [7FFDD0C97E00h, 7FFDD0C97E0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C97E20h, 7FFDD0C97E33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C97E50h, 7FFDD0C97E67h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_d8u(byte lhs, byte rhs)
; location: [7FFDD0C97E80h, 7FFDD0C97E90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_g8u(byte lhs, byte rhs)
; location: [7FFDD0C97EB0h, 7FFDD0C97EC3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_d16i(short lhs, short rhs)
; location: [7FFDD0C97EE0h, 7FFDD0C97EF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_g16i(short lhs, short rhs)
; location: [7FFDD0C97F10h, 7FFDD0C97F27h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C97F40h, 7FFDD0C97F50h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C97F70h, 7FFDD0C97F83h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_d32i(int lhs, int rhs)
; location: [7FFDD0C97FA0h, 7FFDD0C97FA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_g32i(int lhs, int rhs)
; location: [7FFDD0C97FC0h, 7FFDD0C97FC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_d32u(uint lhs, uint rhs)
; location: [7FFDD0C97FE0h, 7FFDD0C97FE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_g32u(uint lhs, uint rhs)
; location: [7FFDD0C98000h, 7FFDD0C98009h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_d64i(long lhs, long rhs)
; location: [7FFDD0C98020h, 7FFDD0C9802Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_g64i(long lhs, long rhs)
; location: [7FFDD0C98450h, 7FFDD0C9845Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C98470h, 7FFDD0C9847Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C98490h, 7FFDD0C9849Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_d32f(float lhs, float rhs)
; location: [7FFDD0C984B0h, 7FFDD0C984D9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_g32f(float lhs, float rhs)
; location: [7FFDD0C98500h, 7FFDD0C98529h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or_d64f(double lhs, double rhs)
; location: [7FFDD0C98550h, 7FFDD0C9857Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or_g64f(double lhs, double rhs)
; location: [7FFDD0C985A0h, 7FFDD0C985AFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,7FFDD0C980F0h         ; MOV(Mov_r64_imm64) [RAX,7ffdd0c980f0h:imm64]         encoding(10 bytes) = 48 b8 f0 80 c9 d0 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> or_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xF0,0x80,0xC9,0xD0,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal_d8i(sbyte lhs, int offset)
; location: [7FFDD0C985D0h, 7FFDD0C985E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal_g8i(sbyte lhs, int offset)
; location: [7FFDD0C98600h, 7FFDD0C98611h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal_d8u(byte lhs, int offset)
; location: [7FFDD0C98630h, 7FFDD0C9863Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal_g8u(byte lhs, int offset)
; location: [7FFDD0C98650h, 7FFDD0C9865Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal_d16i(short lhs, int offset)
; location: [7FFDD0C98670h, 7FFDD0C98681h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal_g16i(short lhs, int offset)
; location: [7FFDD0C986A0h, 7FFDD0C986B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal_d16u(ushort lhs, int offset)
; location: [7FFDD0C986D0h, 7FFDD0C986DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal_g16u(ushort lhs, int offset)
; location: [7FFDD0C986F0h, 7FFDD0C986FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal_d32i(int lhs, int offset)
; location: [7FFDD0C98710h, 7FFDD0C9871Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal_g32i(int lhs, int offset)
; location: [7FFDD0C98730h, 7FFDD0C9873Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal_d32u(uint lhs, int offset)
; location: [7FFDD0C98750h, 7FFDD0C9875Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal_g32u(uint lhs, int offset)
; location: [7FFDD0C98770h, 7FFDD0C9877Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal_d64i(long lhs, int offset)
; location: [7FFDD0C98790h, 7FFDD0C9879Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal_g64i(long lhs, int offset)
; location: [7FFDD0C987B0h, 7FFDD0C987BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal_d64u(ulong lhs, int offset)
; location: [7FFDD0C987D0h, 7FFDD0C987DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal_g64u(ulong lhs, int offset)
; location: [7FFDD0C987F0h, 7FFDD0C987FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_b8i(sbyte lhs, int offset)
; location: [7FFDD0C98810h, 7FFDD0C98821h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_g8i(sbyte lhs, int offset)
; location: [7FFDD0C98840h, 7FFDD0C98851h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_b8u(byte lhs, int offset)
; location: [7FFDD0C98870h, 7FFDD0C9887Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_g8u(byte lhs, int offset)
; location: [7FFDD0C98890h, 7FFDD0C9889Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_b16i(short lhs, int offset)
; location: [7FFDD0C988B0h, 7FFDD0C988C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_g16i(short lhs, int offset)
; location: [7FFDD0C988E0h, 7FFDD0C988F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_b16u(ushort lhs, int offset)
; location: [7FFDD0C98910h, 7FFDD0C9891Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_g16u(ushort lhs, int offset)
; location: [7FFDD0C98D40h, 7FFDD0C98D4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_b32i(int lhs, int offset)
; location: [7FFDD0C98D60h, 7FFDD0C98D6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_g32i(int lhs, int offset)
; location: [7FFDD0C98D80h, 7FFDD0C98D8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_b32u(uint lhs, int offset)
; location: [7FFDD0C98DA0h, 7FFDD0C98DABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_g32u(uint lhs, int offset)
; location: [7FFDD0C98DC0h, 7FFDD0C98DCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_b64i(long lhs, int offset)
; location: [7FFDD0C98DE0h, 7FFDD0C98DEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_g64i(long lhs, int offset)
; location: [7FFDD0C98E00h, 7FFDD0C98E0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_b64u(ulong lhs, int offset)
; location: [7FFDD0C98E20h, 7FFDD0C98E2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_g64u(ulong lhs, int offset)
; location: [7FFDD0C98E40h, 7FFDD0C98E4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_d8i(sbyte lhs, int offset)
; location: [7FFDD0C98E60h, 7FFDD0C98E71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_g8i(sbyte lhs, int offset)
; location: [7FFDD0C98E90h, 7FFDD0C98EA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_d8u(byte lhs, int offset)
; location: [7FFDD0C98EC0h, 7FFDD0C98ECFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_g8u(byte lhs, int offset)
; location: [7FFDD0C98EE0h, 7FFDD0C98EEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_d16i(short lhs, int offset)
; location: [7FFDD0C98F00h, 7FFDD0C98F11h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_g16i(short lhs, int offset)
; location: [7FFDD0C98F30h, 7FFDD0C98F41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_d16u(ushort lhs, int offset)
; location: [7FFDD0C98F60h, 7FFDD0C98F6Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_g16u(ushort lhs, int offset)
; location: [7FFDD0C98F80h, 7FFDD0C98F8Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_d32i(int lhs, int offset)
; location: [7FFDD0C98FA0h, 7FFDD0C98FABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_g32i(int lhs, int offset)
; location: [7FFDD0C98FC0h, 7FFDD0C98FCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_d32u(uint lhs, int offset)
; location: [7FFDD0C98FE0h, 7FFDD0C98FEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_g32u(uint lhs, int offset)
; location: [7FFDD0C99000h, 7FFDD0C9900Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_d64i(long lhs, int offset)
; location: [7FFDD0C99020h, 7FFDD0C9902Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_g64i(long lhs, int offset)
; location: [7FFDD0C99040h, 7FFDD0C9904Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_d64u(ulong lhs, int offset)
; location: [7FFDD0C99060h, 7FFDD0C9906Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_g64u(ulong lhs, int offset)
; location: [7FFDD0C99080h, 7FFDD0C9908Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C990A0h, 7FFDD0C990B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDD0C990D0h, 7FFDD0C990E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_d8u(byte lhs, byte rhs)
; location: [7FFDD0C99100h, 7FFDD0C99110h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_g8u(byte lhs, byte rhs)
; location: [7FFDD0C99130h, 7FFDD0C99143h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_d16i(short lhs, short rhs)
; location: [7FFDD0C99160h, 7FFDD0C99173h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_g16i(short lhs, short rhs)
; location: [7FFDD0C99590h, 7FFDD0C995A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_d16u(ushort lhs, ushort rhs)
; location: [7FFDD0C995C0h, 7FFDD0C995D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_g16u(ushort lhs, ushort rhs)
; location: [7FFDD0C995F0h, 7FFDD0C99603h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_d32i(int lhs, int rhs)
; location: [7FFDD0C99620h, 7FFDD0C99629h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_g32i(int lhs, int rhs)
; location: [7FFDD0C99640h, 7FFDD0C99649h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_d32u(uint lhs, uint rhs)
; location: [7FFDD0C99660h, 7FFDD0C99669h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_g32u(uint lhs, uint rhs)
; location: [7FFDD0C99680h, 7FFDD0C99689h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_d64i(long lhs, long rhs)
; location: [7FFDD0C996A0h, 7FFDD0C996ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_g64i(long lhs, long rhs)
; location: [7FFDD0C996C0h, 7FFDD0C996CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_d64u(ulong lhs, ulong rhs)
; location: [7FFDD0C996E0h, 7FFDD0C996EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_g64u(ulong lhs, ulong rhs)
; location: [7FFDD0C99700h, 7FFDD0C9970Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs_d8i(sbyte x)
; location: [7FFDD0C99720h, 7FFDD0C99736h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,7                     ; SAR(Sar_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 fa 07
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d8iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xC1,0xFA,0x07,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs_g8i(sbyte x)
; location: [7FFDD0C99750h, 7FFDD0C99766h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,7                     ; SAR(Sar_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 fa 07
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g8iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xC1,0xFA,0x07,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short abs_d16i(short x)
; location: [7FFDD0C99780h, 7FFDD0C99796h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,0Fh                   ; SAR(Sar_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 fa 0f
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d16iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xC1,0xFA,0x0F,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short abs_g16i(short x)
; location: [7FFDD0C997B0h, 7FFDD0C997C6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh sar edx,0Fh                   ; SAR(Sar_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 fa 0f
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g16iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xC1,0xFA,0x0F,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs_d32i(int x)
; location: [7FFDD0C997E0h, 7FFDD0C997EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs_g32i(int x)
; location: [7FFDD0C99800h, 7FFDD0C9980Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_d64i(long x)
; location: [7FFDD0C99820h, 7FFDD0C99833h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_g64i(long x)
; location: [7FFDD0C99850h, 7FFDD0C99863h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
