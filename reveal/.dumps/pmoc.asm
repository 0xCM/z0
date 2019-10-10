; 2019-10-09 16:40:45:075
; function: Sign:int signum_d8i(sbyte x)
; location: [7FFDDBF57180h, 7FFDDBF57197h]
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
; location: [7FFDDBF57770h, 7FFDDBF57783h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h mov rax,7FFDDBF55B90h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55b90h:imm64]         encoding(10 bytes) = 48 b8 90 5b f5 db fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0xB8,0x90,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d8u(byte x)
; location: [7FFDDBF577A0h, 7FFDDBF577ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g8u(byte x)
; location: [7FFDDBF577C0h, 7FFDDBF577D2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h mov rax,7FFDDBF55BA0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55ba0h:imm64]         encoding(10 bytes) = 48 b8 a0 5b f5 db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x48,0xB8,0xA0,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16i(short x)
; location: [7FFDDBF577F0h, 7FFDDBF57807h]
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
; location: [7FFDDBF57820h, 7FFDDBF57833h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h mov rax,7FFDDBF55BB0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55bb0h:imm64]         encoding(10 bytes) = 48 b8 b0 5b f5 db fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0xB8,0xB0,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16u(ushort x)
; location: [7FFDDBF57850h, 7FFDDBF57860h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g16u(ushort x)
; location: [7FFDDBF57880h, 7FFDDBF57892h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h mov rax,7FFDDBF55BC0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55bc0h:imm64]         encoding(10 bytes) = 48 b8 c0 5b f5 db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x48,0xB8,0xC0,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32i(int x)
; location: [7FFDDBF578B0h, 7FFDDBF578C3h]
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
; location: [7FFDDBF578E0h, 7FFDDBF578EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBF55BD0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55bd0h:imm64]         encoding(10 bytes) = 48 b8 d0 5b f5 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g32iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xD0,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32u(uint x)
; location: [7FFDDBF57910h, 7FFDDBF5791Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32u(uint x)
; location: [7FFDDBF57930h, 7FFDDBF5793Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBF55BE0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55be0h:imm64]         encoding(10 bytes) = 48 b8 e0 5b f5 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xE0,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64i(long x)
; location: [7FFDDBF57960h, 7FFDDBF5797Ah]
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
; location: [7FFDDBF57990h, 7FFDDBF5799Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBF55BF0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55bf0h:imm64]         encoding(10 bytes) = 48 b8 f0 5b f5 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g64iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0x5B,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64u(ulong x)
; location: [7FFDDBF579C0h, 7FFDDBF579CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64u(ulong x)
; location: [7FFDDBF579E0h, 7FFDDBF579EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBF55C00h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf55c00h:imm64]         encoding(10 bytes) = 48 b8 00 5c f5 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> signum_g64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x5C,0xF5,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_d8i(sbyte x)
; location: [7FFDDBF57A10h, 7FFDDBF57A20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_g8i(sbyte x)
; location: [7FFDDBF57E40h, 7FFDDBF57E50h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_d8u(byte x)
; location: [7FFDDBF57E70h, 7FFDDBF57E7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_g8u(byte x)
; location: [7FFDDBF57E90h, 7FFDDBF57E9Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_d16i(short x)
; location: [7FFDDBF57EB0h, 7FFDDBF57EC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_g16i(short x)
; location: [7FFDDBF57EE0h, 7FFDDBF57EF0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_d16u(ushort x)
; location: [7FFDDBF57F10h, 7FFDDBF57F1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_g16u(ushort x)
; location: [7FFDDBF57F30h, 7FFDDBF57F3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_d32i(int x)
; location: [7FFDDBF57F50h, 7FFDDBF57F5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_g32i(int x)
; location: [7FFDDBF57F70h, 7FFDDBF57F7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_d32u(uint x)
; location: [7FFDDBF57F90h, 7FFDDBF57F9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_g32u(uint x)
; location: [7FFDDBF57FB0h, 7FFDDBF57FBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square_d64i(long x)
; location: [7FFDDBF57FD0h, 7FFDDBF57FE7h]
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
; location: [7FFDDBF58000h, 7FFDDBF58017h]
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
; location: [7FFDDBF58030h, 7FFDDBF5803Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square_g64u(ulong x)
; location: [7FFDDBF58050h, 7FFDDBF5805Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF58070h, 7FFDDBF58083h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF580A0h, 7FFDDBF580B7h]
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
; location: [7FFDDBF580D0h, 7FFDDBF580E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_g8u(byte lhs, byte rhs)
; location: [7FFDDBF58100h, 7FFDDBF58113h]
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
; location: [7FFDDBF58130h, 7FFDDBF58143h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_g16i(short lhs, short rhs)
; location: [7FFDDBF58560h, 7FFDDBF58577h]
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
; location: [7FFDDBF58590h, 7FFDDBF585A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBF585C0h, 7FFDDBF585D3h]
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
; location: [7FFDDBF585F0h, 7FFDDBF585F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_g32i(int lhs, int rhs)
; location: [7FFDDBF58610h, 7FFDDBF58619h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_d32u(uint lhs, uint rhs)
; location: [7FFDDBF58630h, 7FFDDBF58639h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_g32u(uint lhs, uint rhs)
; location: [7FFDDBF58650h, 7FFDDBF58659h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_d64i(long lhs, long rhs)
; location: [7FFDDBF58670h, 7FFDDBF5867Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_g64i(long lhs, long rhs)
; location: [7FFDDBF58690h, 7FFDDBF5869Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF586B0h, 7FFDDBF586BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF586D0h, 7FFDDBF586DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_d32i(int lhs, int rhs)
; location: [7FFDDBF586F0h, 7FFDDBF58700h]
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
; location: [7FFDDBF58720h, 7FFDDBF58730h]
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
; location: [7FFDDBF58750h, 7FFDDBF58761h]
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
; location: [7FFDDBF58780h, 7FFDDBF58791h]
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
; location: [7FFDDBF587B0h, 7FFDDBF587C3h]
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
; location: [7FFDDBF587E0h, 7FFDDBF587F3h]
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
; location: [7FFDDBF58810h, 7FFDDBF58823h]
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
; location: [7FFDDBF58840h, 7FFDDBF58853h]
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
; location: [7FFDDBF58C80h, 7FFDDBF58C91h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B4F0790h            ; CALL(Call_rel32_64) [5F597B10h:jmp64]                encoding(5 bytes) = e8 04 7b 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x04,0x7B,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_g32f(float lhs, float rhs)
; location: [7FFDDBF592A0h, 7FFDDBF592B1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B4F0790h            ; CALL(Call_rel32_64) [5F5974F0h:jmp64]                encoding(5 bytes) = e8 e4 74 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0xE4,0x74,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_d64f(double lhs, double rhs)
; location: [7FFDDBF592D0h, 7FFDDBF592E1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B4F0700h            ; CALL(Call_rel32_64) [5F597430h:jmp64]                encoding(5 bytes) = e8 24 74 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x24,0x74,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_g64f(double lhs, double rhs)
; location: [7FFDDBF59300h, 7FFDDBF59311h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B4F0700h            ; CALL(Call_rel32_64) [5F597400h:jmp64]                encoding(5 bytes) = e8 f4 73 59 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0xF4,0x73,0x59,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF59330h, 7FFDDBF59344h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF59360h, 7FFDDBF59378h]
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
; location: [7FFDDBF59390h, 7FFDDBF593A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_g8u(byte lhs, byte rhs)
; location: [7FFDDBF593C0h, 7FFDDBF593D4h]
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
; location: [7FFDDBF593F0h, 7FFDDBF59404h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_g16i(short lhs, short rhs)
; location: [7FFDDBF59420h, 7FFDDBF59438h]
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
; location: [7FFDDBF59450h, 7FFDDBF59461h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBF59480h, 7FFDDBF59494h]
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
; location: [7FFDDBF594B0h, 7FFDDBF594BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_g32i(int lhs, int rhs)
; location: [7FFDDBF594D0h, 7FFDDBF594DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_d32u(uint lhs, uint rhs)
; location: [7FFDDBF594F0h, 7FFDDBF594FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_g32u(uint lhs, uint rhs)
; location: [7FFDDBF59510h, 7FFDDBF5951Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_d64i(long lhs, long rhs)
; location: [7FFDDBF59530h, 7FFDDBF5953Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_g64i(long lhs, long rhs)
; location: [7FFDDBF59550h, 7FFDDBF5955Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF59570h, 7FFDDBF5957Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF59590h, 7FFDDBF5959Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_d8i(sbyte x)
; location: [7FFDDBF595B0h, 7FFDDBF595BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_g8i(sbyte x)
; location: [7FFDDBF595D0h, 7FFDDBF595DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_d8u(byte x)
; location: [7FFDDBF595F0h, 7FFDDBF595FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_g8u(byte x)
; location: [7FFDDBF59610h, 7FFDDBF5961Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_d16i(short x)
; location: [7FFDDBF59630h, 7FFDDBF5963Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_g16i(short x)
; location: [7FFDDBF59650h, 7FFDDBF5965Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_d16u(ushort x)
; location: [7FFDDBF59670h, 7FFDDBF5967Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_g16u(ushort x)
; location: [7FFDDBF59690h, 7FFDDBF5969Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_d32i(int x)
; location: [7FFDDBF596B0h, 7FFDDBF596B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_g32i(int x)
; location: [7FFDDBF59AE0h, 7FFDDBF59AE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_d32u(uint x)
; location: [7FFDDBF59B00h, 7FFDDBF59B0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_g32u(uint x)
; location: [7FFDDBF59B20h, 7FFDDBF59B2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_d64i(long x)
; location: [7FFDDBF59B40h, 7FFDDBF59B4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_g64i(long x)
; location: [7FFDDBF59B60h, 7FFDDBF59B6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_d64u(ulong x)
; location: [7FFDDBF59B80h, 7FFDDBF59B8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_g64u(ulong x)
; location: [7FFDDBF59BA0h, 7FFDDBF59BAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_g32f(float x)
; location: [7FFDDBF59BC0h, 7FFDDBF59BD1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBF59BD8h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_d32f(float x)
; location: [7FFDDBF59BF0h, 7FFDDBF59C01h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBF59C08h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_d64f(double x)
; location: [7FFDDBF59C20h, 7FFDDBF59C31h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBF59C38h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_g64f(double x)
; location: [7FFDDBF59C50h, 7FFDDBF59C61h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBF59C68h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d8i(sbyte x)
; location: [7FFDDBF59C80h, 7FFDDBF59C91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g8i(sbyte x)
; location: [7FFDDBF59CB0h, 7FFDDBF59CC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d16i(short x)
; location: [7FFDDBF59CE0h, 7FFDDBF59CF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g16i(short x)
; location: [7FFDDBF59D10h, 7FFDDBF59D21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32i(int x)
; location: [7FFDDBF59D40h, 7FFDDBF59D4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32i(int x)
; location: [7FFDDBF59D60h, 7FFDDBF59D6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64i(long x)
; location: [7FFDDBF59D80h, 7FFDDBF59D8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64i(long x)
; location: [7FFDDBF59DA0h, 7FFDDBF59DAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32f(float x)
; location: [7FFDDBF59DC0h, 7FFDDBF59DD3h]
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
; location: [7FFDDBF59DF0h, 7FFDDBF59E03h]
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
; location: [7FFDDBF59E20h, 7FFDDBF59E33h]
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
; location: [7FFDDBF59E50h, 7FFDDBF59E63h]
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
; location: [7FFDDBF59E80h, 7FFDDBF59E94h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g8i(sbyte x)
; location: [7FFDDBF59EB0h, 7FFDDBF59EC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n8u(byte x)
; location: [7FFDDBF59EE0h, 7FFDDBF59EF4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g8u(byte x)
; location: [7FFDDBF59F10h, 7FFDDBF59F20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n16i(short x)
; location: [7FFDDBF59F40h, 7FFDDBF59F55h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0        ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,SS:sr),0h:imm16]  encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g16i(short x)
; location: [7FFDDBF59F70h, 7FFDDBF59F81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n16u(ushort x)
; location: [7FFDDBF59FA0h, 7FFDDBF59FB5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0        ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,SS:sr),0h:imm16]  encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g16u(ushort x)
; location: [7FFDDBF59FD0h, 7FFDDBF59FE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n32i(int x)
; location: [7FFDDBF5A000h, 7FFDDBF5A00Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g32i(int x)
; location: [7FFDDBF5A020h, 7FFDDBF5A02Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n32u(uint x)
; location: [7FFDDBF5A040h, 7FFDDBF5A04Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g32u(uint x)
; location: [7FFDDBF5A060h, 7FFDDBF5A06Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64i(long x)
; location: [7FFDDBF5A080h, 7FFDDBF5A08Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g64i(long x)
; location: [7FFDDBF5A0A0h, 7FFDDBF5A0AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64u(ulong x)
; location: [7FFDDBF5A0C0h, 7FFDDBF5A0CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g64u(ulong x)
; location: [7FFDDBF5A0E0h, 7FFDDBF5A0EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse_d8i(string src, out sbyte dst)
; location: [7FFDDBF5A100h, 7FFDDBF5A18Ch]
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
001dh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC1490h:jmp64]                encoding(5 bytes) = e8 6e 14 dc 5e
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFE3AD0C710h            ; CALL(Call_rel32_64) [5EDB2610h:jmp64]                encoding(5 bytes) = e8 cc 25 db 5e
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
0071h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9685E0h:jmp64]        encoding(5 bytes) = e8 6a 85 96 ff
0076h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0077h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007ch call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97C198h:jmp64]        encoding(5 bytes) = e8 17 c1 97 ff
0081h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0082h mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0087h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97C1A0h:jmp64]        encoding(5 bytes) = e8 14 c1 97 ff
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d8iBytes => new byte[141]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x56,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x6E,0x14,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xCC,0x25,0xDB,0x5E,0x8B,0xC8,0x85,0xC9,0x75,0x2D,0x8B,0x44,0x24,0x38,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBE,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x6A,0x85,0x96,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x17,0xC1,0x97,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x14,0xC1,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse_g8i(string src)
; location: [7FFDDBF5A1B0h, 7FFDDBF5A235h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 53
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC13E0h:jmp64]                encoding(5 bytes) = e8 c2 13 dc 5e
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFE3AD0C710h            ; CALL(Call_rel32_64) [5EDB2560h:jmp64]                encoding(5 bytes) = e8 20 25 db 5e
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
006ah call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF968530h:jmp64]        encoding(5 bytes) = e8 c1 84 96 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0075h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97C0E8h:jmp64]        encoding(5 bytes) = e8 6e c0 97 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0080h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97C0F0h:jmp64]        encoding(5 bytes) = e8 6b c0 97 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g8iBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x53,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0xC2,0x13,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x20,0x25,0xDB,0x5E,0x8B,0xC8,0x85,0xC9,0x75,0x2A,0x8B,0x44,0x24,0x30,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x25,0x8B,0x44,0x24,0x30,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC1,0x84,0x96,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x6E,0xC0,0x97,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x6B,0xC0,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse_d8u(string src, out byte dst)
; location: [7FFDDBF5A250h, 7FFDDBF5A2D5h]
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
001dh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC1340h:jmp64]                encoding(5 bytes) = e8 1e 13 dc 5e
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFDDB8D6200h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BFB0h:jmp64]        encoding(5 bytes) = e8 6c bf 97 ff
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
006ah call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF968490h:jmp64]        encoding(5 bytes) = e8 21 84 96 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
0075h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97C048h:jmp64]        encoding(5 bytes) = e8 ce bf 97 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0080h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97C050h:jmp64]        encoding(5 bytes) = e8 cb bf 97 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d8uBytes => new byte[134]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x4F,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x1E,0x13,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x6C,0xBF,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x26,0x81,0x7C,0x24,0x38,0xFF,0x00,0x00,0x00,0x77,0x27,0x8B,0x44,0x24,0x38,0x0F,0xB6,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x21,0x84,0x96,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0xCE,0xBF,0x97,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0xCB,0xBF,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse_g8u(string src)
; location: [7FFDDBF5A700h, 7FFDDBF5A77Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 005eh                ; JE(Je_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 74 4c
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0E90h:jmp64]                encoding(5 bytes) = e8 72 0e dc 5e
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFDDB8D6200h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BB00h:jmp64]        encoding(5 bytes) = e8 c0 ba 97 ff
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
0063h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967FE0h:jmp64]        encoding(5 bytes) = e8 78 7f 96 ff
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0069h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
006eh call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BB98h:jmp64]        encoding(5 bytes) = e8 25 bb 97 ff
0073h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0074h mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0079h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BBA0h:jmp64]        encoding(5 bytes) = e8 22 bb 97 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g8uBytes => new byte[127]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x4C,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x72,0x0E,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0xC0,0xBA,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x23,0x81,0x7C,0x24,0x30,0xFF,0x00,0x00,0x00,0x77,0x24,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x78,0x7F,0x96,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0x25,0xBB,0x97,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0x22,0xBB,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse_d16i(string src, out short dst)
; location: [7FFDDBF5A7A0h, 7FFDDBF5A82Dh]
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
001dh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0DF0h:jmp64]                encoding(5 bytes) = e8 ce 0d dc 5e
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFE3AD0C710h            ; CALL(Call_rel32_64) [5EDB1F70h:jmp64]                encoding(5 bytes) = e8 2c 1f db 5e
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
0072h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967F40h:jmp64]        encoding(5 bytes) = e8 c9 7e 96 ff
0077h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0078h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
007dh call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BAF8h:jmp64]        encoding(5 bytes) = e8 76 ba 97 ff
0082h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0083h mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0088h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BB00h:jmp64]        encoding(5 bytes) = e8 73 ba 97 ff
008dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d16iBytes => new byte[142]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x57,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xCE,0x0D,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x2C,0x1F,0xDB,0x5E,0x8B,0xC8,0x85,0xC9,0x75,0x2E,0x8B,0x44,0x24,0x38,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x29,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBF,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC9,0x7E,0x96,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0x76,0xBA,0x97,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0x73,0xBA,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse_g16i(string src)
; location: [7FFDDBF5A850h, 7FFDDBF5A8D5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 53
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0D40h:jmp64]                encoding(5 bytes) = e8 22 0d dc 5e
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFE3AD0C710h            ; CALL(Call_rel32_64) [5EDB1EC0h:jmp64]                encoding(5 bytes) = e8 80 1e db 5e
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
006ah call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967E90h:jmp64]        encoding(5 bytes) = e8 21 7e 96 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0075h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BA48h:jmp64]        encoding(5 bytes) = e8 ce b9 97 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0080h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97BA50h:jmp64]        encoding(5 bytes) = e8 cb b9 97 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g16iBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x53,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x22,0x0D,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x80,0x1E,0xDB,0x5E,0x8B,0xC8,0x85,0xC9,0x75,0x2A,0x8B,0x44,0x24,0x30,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x25,0x8B,0x44,0x24,0x30,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x21,0x7E,0x96,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0xCE,0xB9,0x97,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0xCB,0xB9,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse_d16u(string src, out ushort dst)
; location: [7FFDDBF5A8F0h, 7FFDDBF5A976h]
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
001dh call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0CA0h:jmp64]                encoding(5 bytes) = e8 7e 0c dc 5e
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFDDB8D6200h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B910h:jmp64]        encoding(5 bytes) = e8 cc b8 97 ff
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
006bh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967DF0h:jmp64]        encoding(5 bytes) = e8 80 7d 96 ff
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0071h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0076h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B9A8h:jmp64]        encoding(5 bytes) = e8 2d b9 97 ff
007bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007ch mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0081h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B9B0h:jmp64]        encoding(5 bytes) = e8 2a b9 97 ff
0086h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d16uBytes => new byte[135]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x50,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x7E,0x0C,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xCC,0xB8,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x27,0x81,0x7C,0x24,0x38,0xFF,0xFF,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x0F,0xB7,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x80,0x7D,0x96,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x2D,0xB9,0x97,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x2A,0xB9,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse_g16u(string src)
; location: [7FFDDBF5A990h, 7FFDDBF5AA0Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 005eh                ; JE(Je_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 74 4c
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 79 08
0019h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0C00h:jmp64]                encoding(5 bytes) = e8 e2 0b dc 5e
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFDDB8D6200h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B870h:jmp64]        encoding(5 bytes) = e8 30 b8 97 ff
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
0063h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967D50h:jmp64]        encoding(5 bytes) = e8 e8 7c 96 ff
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0069h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
006eh call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B908h:jmp64]        encoding(5 bytes) = e8 95 b8 97 ff
0073h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0074h mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0079h call 7FFDDB8D62A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B910h:jmp64]        encoding(5 bytes) = e8 92 b8 97 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g16uBytes => new byte[127]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x4C,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0xE2,0x0B,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x30,0xB8,0x97,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x23,0x81,0x7C,0x24,0x30,0xFF,0xFF,0x00,0x00,0x77,0x24,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xE8,0x7C,0x96,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x95,0xB8,0x97,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x92,0xB8,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse_d32i(string src, out int dst)
; location: [7FFDDBF5AA30h, 7FFDDBF5AA7Fh]
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
0026h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0B60h:jmp64]                encoding(5 bytes) = e8 35 0b dc 5e
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDDB8D6198h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B768h:jmp64]        encoding(5 bytes) = e8 2b b7 97 ff
003dh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
003fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0045h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004ah call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967CB0h:jmp64]        encoding(5 bytes) = e8 61 7c 96 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32iBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x35,0x0B,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x2B,0xB7,0x97,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x61,0x7C,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse_g32i(string src)
; location: [7FFDDBF5AAA0h, 7FFDDBF5AAE9h]
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
0022h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0AF0h:jmp64]                encoding(5 bytes) = e8 c9 0a dc 5e
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDDB8D6198h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B6F8h:jmp64]        encoding(5 bytes) = e8 bf b6 97 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967C40h:jmp64]        encoding(5 bytes) = e8 f7 7b 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32iBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xC9,0x0A,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xBF,0xB6,0x97,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF7,0x7B,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse_d32u(string src, out uint dst)
; location: [7FFDDBF5AB00h, 7FFDDBF5AB4Fh]
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
0026h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0A90h:jmp64]                encoding(5 bytes) = e8 65 0a dc 5e
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDDB8D61A8h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B6A8h:jmp64]        encoding(5 bytes) = e8 6b b6 97 ff
003dh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 89 06
003fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0045h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004ah call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967BE0h:jmp64]        encoding(5 bytes) = e8 91 7b 96 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32uBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x65,0x0A,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x6B,0xB6,0x97,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x91,0x7B,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse_g32u(string src)
; location: [7FFDDBF5AB70h, 7FFDDBF5ABB9h]
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
0022h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0A20h:jmp64]                encoding(5 bytes) = e8 f9 09 dc 5e
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDDB8D61A8h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B638h:jmp64]        encoding(5 bytes) = e8 ff b5 97 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967B70h:jmp64]        encoding(5 bytes) = e8 27 7b 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32uBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xF9,0x09,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xFF,0xB5,0x97,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x27,0x7B,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse_d64i(string src, out long dst)
; location: [7FFDDBF5ABD0h, 7FFDDBF5AC20h]
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
0026h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC09C0h:jmp64]                encoding(5 bytes) = e8 95 09 dc 5e
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDDB8D61A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B5D0h:jmp64]        encoding(5 bytes) = e8 93 b5 97 ff
003dh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0040h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0044h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004bh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967B10h:jmp64]        encoding(5 bytes) = e8 c0 7a 96 ff
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64iBytes => new byte[81]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x95,0x09,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x93,0xB5,0x97,0xFF,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC0,0x7A,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse_g64i(string src)
; location: [7FFDDBF5AC40h, 7FFDDBF5AC89h]
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
0022h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0950h:jmp64]                encoding(5 bytes) = e8 29 09 dc 5e
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDDB8D61A0h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B560h:jmp64]        encoding(5 bytes) = e8 27 b5 97 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967AA0h:jmp64]        encoding(5 bytes) = e8 57 7a 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64iBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x29,0x09,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0x27,0xB5,0x97,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x57,0x7A,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse_d64u(string src, out ulong dst)
; location: [7FFDDBF5ACA0h, 7FFDDBF5ACF0h]
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
0026h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC08F0h:jmp64]                encoding(5 bytes) = e8 c5 08 dc 5e
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFE3ADEB840h            ; CALL(Call_rel32_64) [5EE90BA0h:jmp64]                encoding(5 bytes) = e8 63 0b e9 5e
003dh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0040h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0044h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004bh call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967A40h:jmp64]        encoding(5 bytes) = e8 f0 79 96 ff
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64uBytes => new byte[81]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xC5,0x08,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x63,0x0B,0xE9,0x5E,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF0,0x79,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse_g64u(string src)
; location: [7FFDDBF5AD10h, 7FFDDBF5AD59h]
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
0022h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0880h:jmp64]                encoding(5 bytes) = e8 59 08 dc 5e
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFE3ADEB840h            ; CALL(Call_rel32_64) [5EE90B30h:jmp64]                encoding(5 bytes) = e8 f7 0a e9 5e
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9679D0h:jmp64]        encoding(5 bytes) = e8 87 79 96 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64uBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x59,0x08,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xF7,0x0A,0xE9,0x5E,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x87,0x79,0x96,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse_d32f(string src, out float dst)
; location: [7FFDDBF5AD70h, 7FFDDBF5ADE4h]
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
0020h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0820h:jmp64]                encoding(5 bytes) = e8 fb 07 dc 5e
0025h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0028h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002dh mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0030h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0033h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0038h lea r9,[rsp+3Ch]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 3c
003dh mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
0042h call 7FFDDB8D6260h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B4F0h:jmp64]        encoding(5 bytes) = e8 a9 b4 97 ff
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
0062h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967970h:jmp64]        encoding(5 bytes) = e8 09 79 96 ff
0067h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0068h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
006dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006fh call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B528h:jmp64]        encoding(5 bytes) = e8 b4 b4 97 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32fBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xFB,0x07,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x3C,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xA9,0xB4,0x97,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFA,0x10,0x44,0x24,0x3C,0xC5,0xFA,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x09,0x79,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0xB4,0xB4,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse_g32f(string src)
; location: [7FFDDBF5AE00h, 7FFDDBF5AE6Bh]
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
001ch call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0790h:jmp64]                encoding(5 bytes) = e8 6f 07 dc 5e
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0029h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
002ch mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0034h lea r9,[rsp+34h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 34
0039h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
003eh call 7FFDDB8D6260h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B460h:jmp64]        encoding(5 bytes) = e8 1d b4 97 ff
0043h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0045h je short 005fh                ; JE(Je_rel8_64) [5Fh:jmp64]                           encoding(2 bytes) = 74 18
0047h vmovss xmm0,dword ptr [rsp+34h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 34
004dh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0054h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0059h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9678E0h:jmp64]        encoding(5 bytes) = e8 82 78 96 ff
005eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
005fh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B498h:jmp64]        encoding(5 bytes) = e8 2d b4 97 ff
006bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32fBytes => new byte[108]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x3F,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x6F,0x07,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x34,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x1D,0xB4,0x97,0xFF,0x85,0xC0,0x74,0x18,0xC5,0xFA,0x10,0x44,0x24,0x34,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x82,0x78,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x2D,0xB4,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse_d64f(string src, out double dst)
; location: [7FFDDBF5AE90h, 7FFDDBF5AF04h]
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
0020h call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0700h:jmp64]                encoding(5 bytes) = e8 db 06 dc 5e
0025h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0028h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
002dh mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDI]        encoding(3 bytes) = 48 89 39
0030h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EBX]        encoding(3 bytes) = 89 59 08
0033h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0038h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 38
003dh mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
0042h call 7FFDDB8D6258h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B3C8h:jmp64]        encoding(5 bytes) = e8 81 b3 97 ff
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
0062h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF967850h:jmp64]        encoding(5 bytes) = e8 e9 77 96 ff
0067h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0068h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
006dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006fh call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B408h:jmp64]        encoding(5 bytes) = e8 94 b3 97 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64fBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xDB,0x06,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x81,0xB3,0x97,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFB,0x10,0x44,0x24,0x38,0xC5,0xFB,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xE9,0x77,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x94,0xB3,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse_g64f(string src)
; location: [7FFDDBF5AF20h, 7FFDDBF5AF8Bh]
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
001ch call 7FFE3AD1B590h            ; CALL(Call_rel32_64) [5EDC0670h:jmp64]                encoding(5 bytes) = e8 4f 06 dc 5e
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0029h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RSI]        encoding(3 bytes) = 48 89 31
002ch mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDI]        encoding(3 bytes) = 89 79 08
002fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0034h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 4c 24 30
0039h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
003eh call 7FFDDB8D6258h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B338h:jmp64]        encoding(5 bytes) = e8 f5 b2 97 ff
0043h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0045h je short 005fh                ; JE(Je_rel8_64) [5Fh:jmp64]                           encoding(2 bytes) = 74 18
0047h vmovsd xmm0,qword ptr [rsp+30h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 30
004dh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0054h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0059h call 7FFDDB8C26E0h            ; CALL(Call_rel32_64) [FFFFFFFFFF9677C0h:jmp64]        encoding(5 bytes) = e8 62 77 96 ff
005eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
005fh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h call 7FFDDB8D6298h            ; CALL(Call_rel32_64) [FFFFFFFFFF97B378h:jmp64]        encoding(5 bytes) = e8 0d b3 97 ff
006bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64fBytes => new byte[108]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x3F,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x4F,0x06,0xDC,0x5E,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xF5,0xB2,0x97,0xFF,0x85,0xC0,0x74,0x18,0xC5,0xFB,0x10,0x44,0x24,0x30,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x62,0x77,0x96,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x0D,0xB3,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8i(sbyte x)
; location: [7FFDDBF5AFB0h, 7FFDDBF5AFC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8i(sbyte x)
; location: [7FFDDBF5AFE0h, 7FFDDBF5AFF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8u(byte x)
; location: [7FFDDBF5B010h, 7FFDDBF5B01Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8u(byte x)
; location: [7FFDDBF5B030h, 7FFDDBF5B040h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16i(short x)
; location: [7FFDDBF5B060h, 7FFDDBF5B071h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16i(short x)
; location: [7FFDDBF5B090h, 7FFDDBF5B0A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16u(ushort x)
; location: [7FFDDBF5B0C0h, 7FFDDBF5B0D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16u(ushort x)
; location: [7FFDDBF5B0F0h, 7FFDDBF5B100h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32i(int x)
; location: [7FFDDBF5B120h, 7FFDDBF5B12Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32i(int x)
; location: [7FFDDBF5B140h, 7FFDDBF5B14Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32u(uint x)
; location: [7FFDDBF5B160h, 7FFDDBF5B16Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32u(uint x)
; location: [7FFDDBF5B180h, 7FFDDBF5B18Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64i(long x)
; location: [7FFDDBF5B1A0h, 7FFDDBF5B1AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64i(long x)
; location: [7FFDDBF5B1C0h, 7FFDDBF5B1CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64u(ulong x)
; location: [7FFDDBF5B1E0h, 7FFDDBF5B1EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64u(ulong x)
; location: [7FFDDBF5B200h, 7FFDDBF5B20Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_b8i(sbyte b, uint exp)
; location: [7FFDDBF5B220h, 7FFDDBF5B233h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h mov rax,7FFDDBEB8CC0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8cc0h:imm64]         encoding(10 bytes) = 48 b8 c0 8c eb db fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0xB8,0xC0,0x8C,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_g8i(sbyte b, uint exp)
; location: [7FFDDBF5B250h, 7FFDDBF5B266h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h call 7FFDDBEB8CC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5DA70h:jmp64]        encoding(5 bytes) = e8 62 da f5 ff
000eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g8iBytes => new byte[23]{0x48,0x83,0xEC,0x28,0x90,0x48,0x0F,0xBE,0xC9,0xE8,0x62,0xDA,0xF5,0xFF,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_b8u(byte b, uint exp)
; location: [7FFDDBF5B280h, 7FFDDBF5B292h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h mov rax,7FFDDBEB8D10h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8d10h:imm64]         encoding(10 bytes) = 48 b8 10 8d eb db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x48,0xB8,0x10,0x8D,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_g8u(byte b, uint exp)
; location: [7FFDDBF5B6B0h, 7FFDDBF5B6C4h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h call 7FFDDBEB8D10h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D660h:jmp64]        encoding(5 bytes) = e8 53 d6 f5 ff
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g8uBytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC9,0xE8,0x53,0xD6,0xF5,0xFF,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_b16i(short b, uint exp)
; location: [7FFDDBF5B6E0h, 7FFDDBF5B6F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h mov rax,7FFDDBEB8D60h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8d60h:imm64]         encoding(10 bytes) = 48 b8 60 8d eb db fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0xB8,0x60,0x8D,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_g16i(short b, uint exp)
; location: [7FFDDBF5B710h, 7FFDDBF5B726h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h call 7FFDDBEB8D60h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D650h:jmp64]        encoding(5 bytes) = e8 42 d6 f5 ff
000eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g16iBytes => new byte[23]{0x48,0x83,0xEC,0x28,0x90,0x48,0x0F,0xBF,0xC9,0xE8,0x42,0xD6,0xF5,0xFF,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_b16u(ushort b, uint exp)
; location: [7FFDDBF5B740h, 7FFDDBF5B752h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h mov rax,7FFDDBEB8DB0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8db0h:imm64]         encoding(10 bytes) = 48 b8 b0 8d eb db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x48,0xB8,0xB0,0x8D,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_g16u(ushort b, uint exp)
; location: [7FFDDBF5B770h, 7FFDDBF5B784h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h call 7FFDDBEB8DB0h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D640h:jmp64]        encoding(5 bytes) = e8 33 d6 f5 ff
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g16uBytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0xC9,0xE8,0x33,0xD6,0xF5,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_b32i(int b, uint exp)
; location: [7FFDDBF5B7A0h, 7FFDDBF5B7AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBEB8E00h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8e00h:imm64]         encoding(10 bytes) = 48 b8 00 8e eb db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b32iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x8E,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_g32i(int b, uint exp)
; location: [7FFDDBF5B7D0h, 7FFDDBF5B7DFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDBEB8E00h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D630h:jmp64]        encoding(5 bytes) = e8 26 d6 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g32iBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x26,0xD6,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_b32u(uint b, uint exp)
; location: [7FFDDBF5B800h, 7FFDDBF5B80Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBEB8E40h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8e40h:imm64]         encoding(10 bytes) = 48 b8 40 8e eb db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x40,0x8E,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_g32u(uint b, uint exp)
; location: [7FFDDBF5B830h, 7FFDDBF5B83Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDBEB8E40h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D610h:jmp64]        encoding(5 bytes) = e8 06 d6 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g32uBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x06,0xD6,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_b64i(long b, uint exp)
; location: [7FFDDBF5B860h, 7FFDDBF5B86Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBEB8E80h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8e80h:imm64]         encoding(10 bytes) = 48 b8 80 8e eb db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b64iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x80,0x8E,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_g64i(long b, uint exp)
; location: [7FFDDBF5B890h, 7FFDDBF5B89Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDBEB8E80h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D5F0h:jmp64]        encoding(5 bytes) = e8 e6 d5 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g64iBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0xE6,0xD5,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_b64u(ulong b, uint exp)
; location: [7FFDDBF5B8C0h, 7FFDDBF5B8CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDBEB8EC0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbeb8ec0h:imm64]         encoding(10 bytes) = 48 b8 c0 8e eb db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xC0,0x8E,0xEB,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_g64u(ulong b, uint exp)
; location: [7FFDDBF5B8F0h, 7FFDDBF5B8FFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDBEB8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFF5D5D0h:jmp64]        encoding(5 bytes) = e8 c6 d5 f5 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g64uBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0xC6,0xD5,0xF5,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d8u(byte lhs, byte rhs)
; location: [7FFDDBF5B920h, 7FFDDBF5B933h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g8u(byte lhs, byte rhs)
; location: [7FFDDBF5B950h, 7FFDDBF5B966h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d16i(short lhs, short rhs)
; location: [7FFDDBF5B980h, 7FFDDBF5B995h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g16i(short lhs, short rhs)
; location: [7FFDDBF5B9B0h, 7FFDDBF5B9C9h]
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
; location: [7FFDDBF5B9E0h, 7FFDDBF5B9F3h]
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
; location: [7FFDDBF5BA10h, 7FFDDBF5BA26h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d32i(int lhs, int rhs)
; location: [7FFDDBF5BA40h, 7FFDDBF5BA4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g32i(int lhs, int rhs)
; location: [7FFDDBF5BA60h, 7FFDDBF5BA6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5BA80h, 7FFDDBF5BA8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5BAA0h, 7FFDDBF5BAADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d64i(long lhs, long rhs)
; location: [7FFDDBF5BAC0h, 7FFDDBF5BACEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g64i(long lhs, long rhs)
; location: [7FFDDBF5BAE0h, 7FFDDBF5BAEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5BB00h, 7FFDDBF5BB0Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5BB20h, 7FFDDBF5BB2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d32f(float lhs, float rhs)
; location: [7FFDDBF5BB40h, 7FFDDBF5BB4Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g32f(float lhs, float rhs)
; location: [7FFDDBF5BB70h, 7FFDDBF5BB7Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d64f(double lhs, double rhs)
; location: [7FFDDBF5BBA0h, 7FFDDBF5BBAFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_g64f(double lhs, double rhs)
; location: [7FFDDBF5BBD0h, 7FFDDBF5BBDFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF5BC00h, 7FFDDBF5BC15h]
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
; location: [7FFDDBF5BC30h, 7FFDDBF5BC49h]
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
; location: [7FFDDBF5BC60h, 7FFDDBF5BC73h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBF5BD20h, 7FFDDBF5BD33h]
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
; location: [7FFDDBF5C150h, 7FFDDBF5C166h]
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
; location: [7FFE3AD4D1D0h, 7FFE3AD4D1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE3A96F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32iBytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g32i(int lhs, int rhs)
; location: [7FFDDBF5C1A0h, 7FFDDBF5C1ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5C1C0h, 7FFDDBF5C1CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5C1E0h, 7FFDDBF5C1EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d64i(long lhs, long rhs)
; location: [7FFDDBF5C200h, 7FFDDBF5C20Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g64i(long lhs, long rhs)
; location: [7FFDDBF5C220h, 7FFDDBF5C22Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5C240h, 7FFDDBF5C24Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5C260h, 7FFDDBF5C26Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d32f(float lhs, float rhs)
; location: [7FFDDBF5C280h, 7FFDDBF5C28Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g32f(float lhs, float rhs)
; location: [7FFDDBF5C2B0h, 7FFDDBF5C2BFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_d64f(double lhs, double rhs)
; location: [7FFDDBF5C2E0h, 7FFDDBF5C2EFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gteq_g64f(double lhs, double rhs)
; location: [7FFDDBF5C310h, 7FFDDBF5C31Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_d8i(sbyte x)
; location: [7FFDDBF5C340h, 7FFDDBF5C34Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_g8i(sbyte x)
; location: [7FFDDBF5C360h, 7FFDDBF5C384h]
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
; location: [7FFDDBF5C3A0h, 7FFDDBF5C3ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_g8u(byte x)
; location: [7FFDDBF5C3C0h, 7FFDDBF5C3E2h]
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
; location: [7FFDDBF5C400h, 7FFDDBF5C40Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_g16i(short x)
; location: [7FFDDBF5C830h, 7FFDDBF5C855h]
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
; location: [7FFDDBF5C870h, 7FFDDBF5C87Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_g16u(ushort x)
; location: [7FFDDBF5C890h, 7FFDDBF5C8B3h]
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
; location: [7FFDDBF5C8D0h, 7FFDDBF5C8D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_g32i(int x)
; location: [7FFDDBF5C8F0h, 7FFDDBF5C90Eh]
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
; location: [7FFDDBF5C930h, 7FFDDBF5C938h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_g32u(uint x)
; location: [7FFDDBF5C950h, 7FFDDBF5C96Eh]
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
; location: [7FFDDBF5C990h, 7FFDDBF5C999h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_g64i(long x)
; location: [7FFDDBF5C9B0h, 7FFDDBF5C9BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                       ; INC(Inc_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_d64u(ulong x)
; location: [7FFDDBF5C9D0h, 7FFDDBF5C9D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_g64u(ulong x)
; location: [7FFDDBF5C9F0h, 7FFDDBF5C9FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                       ; INC(Inc_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF5CA10h, 7FFDDBF5CA25h]
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
; location: [7FFDDBF5CE40h, 7FFDDBF5CE59h]
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
; location: [7FFDDBF5CE70h, 7FFDDBF5CE83h]
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
; location: [7FFDDBF5CEA0h, 7FFDDBF5CEB6h]
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
; location: [7FFDDBF5CED0h, 7FFDDBF5CEE5h]
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
; location: [7FFDDBF5CF00h, 7FFDDBF5CF19h]
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
; location: [7FFDDBF5CF30h, 7FFDDBF5CF43h]
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
; location: [7FFDDBF5CF60h, 7FFDDBF5CF76h]
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
; location: [7FFDDBF5CF90h, 7FFDDBF5CF9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g32i(int lhs, int rhs)
; location: [7FFDDBF5CFB0h, 7FFDDBF5CFBDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5CFD0h, 7FFDDBF5CFDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5CFF0h, 7FFDDBF5CFFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d64i(long lhs, long rhs)
; location: [7FFDDBF5D010h, 7FFDDBF5D01Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g64i(long lhs, long rhs)
; location: [7FFDDBF5D030h, 7FFDDBF5D03Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5D050h, 7FFDDBF5D05Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5D070h, 7FFDDBF5D07Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF5D090h, 7FFDDBF5D0A5h]
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
; location: [7FFDDBF5D0C0h, 7FFDDBF5D0D9h]
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
; location: [7FFDDBF5D0F0h, 7FFDDBF5D103h]
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
; location: [7FFDDBF5D120h, 7FFDDBF5D136h]
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
; location: [7FFDDBF5D150h, 7FFDDBF5D165h]
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
; location: [7FFDDBF5D180h, 7FFDDBF5D199h]
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
; location: [7FFDDBF5D1B0h, 7FFDDBF5D1C3h]
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
; location: [7FFDDBF5D1E0h, 7FFDDBF5D1F6h]
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
; location: [7FFDDBF5D210h, 7FFDDBF5D21Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g32i(int lhs, int rhs)
; location: [7FFDDBF5D230h, 7FFDDBF5D23Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5D250h, 7FFDDBF5D25Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5D270h, 7FFDDBF5D27Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d64i(long lhs, long rhs)
; location: [7FFDDBF5D290h, 7FFDDBF5D29Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g64i(long lhs, long rhs)
; location: [7FFDDBF5D2B0h, 7FFDDBF5D2BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5D2D0h, 7FFDDBF5D2DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5D2F0h, 7FFDDBF5D2FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF5D310h, 7FFDDBF5D327h]
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
; location: [7FFDDBF5D340h, 7FFDDBF5D35Fh]
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
; location: [7FFDDBF5D380h, 7FFDDBF5D395h]
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
; location: [7FFDDBF5D7B0h, 7FFDDBF5D7CCh]
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
; location: [7FFDDBF5D7F0h, 7FFDDBF5D807h]
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
; location: [7FFDDBF5D820h, 7FFDDBF5D83Fh]
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
; location: [7FFDDBF5D860h, 7FFDDBF5D875h]
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
; location: [7FFDDBF5D890h, 7FFDDBF5D8ACh]
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
; location: [7FFDDBF5D8D0h, 7FFDDBF5D8DFh]
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
; location: [7FFDDBF5D8F0h, 7FFDDBF5D903h]
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
; location: [7FFDDBF5D920h, 7FFDDBF5D92Fh]
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
; location: [7FFDDBF5D940h, 7FFDDBF5D953h]
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
; location: [7FFDDBF5D970h, 7FFDDBF5D982h]
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
; location: [7FFDDBF5D9A0h, 7FFDDBF5D9B2h]
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
; location: [7FFDDBF5D9D0h, 7FFDDBF5D9E2h]
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
; location: [7FFDDBF5DA00h, 7FFDDBF5DA12h]
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
; location: [7FFDDBF5DA30h, 7FFDDBF5DA47h]
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
; location: [7FFDDBF5DA60h, 7FFDDBF5DA7Bh]
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
; location: [7FFDDBF5DA90h, 7FFDDBF5DAA5h]
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
; location: [7FFDDBF5DAC0h, 7FFDDBF5DAD8h]
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
; location: [7FFDDBF5DAF0h, 7FFDDBF5DB07h]
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
; location: [7FFDDBF5DB20h, 7FFDDBF5DB3Bh]
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
; location: [7FFDDBF5DB50h, 7FFDDBF5DB65h]
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
; location: [7FFDDBF5DB80h, 7FFDDBF5DB98h]
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
; location: [7FFDDBF5DBB0h, 7FFDDBF5DBBFh]
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
; location: [7FFDDBF5DBD0h, 7FFDDBF5DBDFh]
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
; location: [7FFDDBF5DBF0h, 7FFDDBF5DBFFh]
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
; location: [7FFDDBF5E020h, 7FFDDBF5E02Fh]
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
; location: [7FFDDBF5E040h, 7FFDDBF5E052h]
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
; location: [7FFDDBF5E070h, 7FFDDBF5E082h]
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
; location: [7FFDDBF5E0A0h, 7FFDDBF5E0B2h]
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
; location: [7FFDDBF5E0D0h, 7FFDDBF5E0E2h]
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
; location: [7FFDDBF5E100h, 7FFDDBF5E114h]
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
; location: [7FFDDBF5E130h, 7FFDDBF5E144h]
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
; location: [7FFDDBF5E160h, 7FFDDBF5E178h]
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
; location: [7FFDDBF5E190h, 7FFDDBF5E1A1h]
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
; location: [7FFDDBF5E1C0h, 7FFDDBF5E1D1h]
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
; location: [7FFDDBF5E1F0h, 7FFDDBF5E204h]
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
; location: [7FFDDBF5E220h, 7FFDDBF5E234h]
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
; location: [7FFDDBF5E250h, 7FFDDBF5E268h]
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
; location: [7FFDDBF5E280h, 7FFDDBF5E291h]
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
; location: [7FFDDBF5E2B0h, 7FFDDBF5E2C4h]
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
; location: [7FFDDBF5E2E0h, 7FFDDBF5E2F1h]
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
; location: [7FFDDBF5E310h, 7FFDDBF5E324h]
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
; location: [7FFDDBF5E340h, 7FFDDBF5E34Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div_g32i(int lhs, int rhs)
; location: [7FFDDBF5E360h, 7FFDDBF5E36Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5E380h, 7FFDDBF5E38Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5E3A0h, 7FFDDBF5E3AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_d64i(long lhs, long rhs)
; location: [7FFDDBF5E3C0h, 7FFDDBF5E3D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_g64i(long lhs, long rhs)
; location: [7FFDDBF5E3F0h, 7FFDDBF5E400h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5E420h, 7FFDDBF5E430h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5E450h, 7FFDDBF5E460h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_d32f(float lhs, float rhs)
; location: [7FFDDBF5E480h, 7FFDDBF5E489h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_g32f(float lhs, float rhs)
; location: [7FFDDBF5E4A0h, 7FFDDBF5E4A9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_d64f(double lhs, double rhs)
; location: [7FFDDBF5E4C0h, 7FFDDBF5E4C9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_g64f(double lhs, double rhs)
; location: [7FFDDBF5E4E0h, 7FFDDBF5E4E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF5E500h, 7FFDDBF5E518h]
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
; location: [7FFDDBF5E530h, 7FFDDBF5E54Eh]
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
; location: [7FFDDBF5E560h, 7FFDDBF5E576h]
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
; location: [7FFDDBF5E590h, 7FFDDBF5E5ABh]
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
; location: [7FFDDBF5E5C0h, 7FFDDBF5E5D8h]
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
; location: [7FFDDBF5EA00h, 7FFDDBF5EA1Eh]
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
; location: [7FFDDBF5EA30h, 7FFDDBF5EA46h]
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
; location: [7FFDDBF5EA60h, 7FFDDBF5EA7Bh]
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
; location: [7FFDDBF5EA90h, 7FFDDBF5EAA2h]
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
; location: [7FFDDBF5EAC0h, 7FFDDBF5EAD2h]
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
; location: [7FFDDBF5EAF0h, 7FFDDBF5EB03h]
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
; location: [7FFDDBF5EB20h, 7FFDDBF5EB33h]
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
; location: [7FFDDBF5EB50h, 7FFDDBF5EB66h]
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
; location: [7FFDDBF5EB80h, 7FFDDBF5EB96h]
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
; location: [7FFDDBF5EBB0h, 7FFDDBF5EBC6h]
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
; location: [7FFDDBF5EBE0h, 7FFDDBF5EBF6h]
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
; location: [7FFDDBF5EC10h, 7FFDDBF5EC3Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B4F0790h            ; CALL(Call_rel32_64) [5F591B80h:jmp64]                encoding(5 bytes) = e8 68 1b 59 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x68,0x1B,0x59,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32f(float lhs, float rhs)
; location: [7FFDDBF5EC60h, 7FFDDBF5EC8Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B4F0790h            ; CALL(Call_rel32_64) [5F591B30h:jmp64]                encoding(5 bytes) = e8 18 1b 59 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x18,0x1B,0x59,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64f(double lhs, double rhs)
; location: [7FFDDBF5ECB0h, 7FFDDBF5ECDFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B4F0700h            ; CALL(Call_rel32_64) [5F591A50h:jmp64]                encoding(5 bytes) = e8 38 1a 59 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x38,0x1A,0x59,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64f(double lhs, double rhs)
; location: [7FFDDBF5ED00h, 7FFDDBF5ED2Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B4F0700h            ; CALL(Call_rel32_64) [5F591A00h:jmp64]                encoding(5 bytes) = e8 e8 19 59 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0xE8,0x19,0x59,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF5ED50h, 7FFDDBF5ED65h]
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
; location: [7FFDDBF5ED80h, 7FFDDBF5ED99h]
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
; location: [7FFDDBF5EDB0h, 7FFDDBF5EDC3h]
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
; location: [7FFDDBF5EDE0h, 7FFDDBF5EDF6h]
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
; location: [7FFDDBF5EE10h, 7FFDDBF5EE25h]
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
; location: [7FFDDBF5EE40h, 7FFDDBF5EE59h]
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
; location: [7FFDDBF5EE70h, 7FFDDBF5EE83h]
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
; location: [7FFDDBF5EEA0h, 7FFDDBF5EEB6h]
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
; location: [7FFDDBF5EED0h, 7FFDDBF5EEDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g32i(int lhs, int rhs)
; location: [7FFDDBF5EEF0h, 7FFDDBF5EEFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5EF10h, 7FFDDBF5EF1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5EF30h, 7FFDDBF5EF3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d64i(long lhs, long rhs)
; location: [7FFDDBF5EF50h, 7FFDDBF5EF5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g64i(long lhs, long rhs)
; location: [7FFDDBF5EF70h, 7FFDDBF5EF7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5EF90h, 7FFDDBF5EF9Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5EFB0h, 7FFDDBF5EFBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool eq_d32f(float lhs, float rhs)
; location: [7FFDDBF5EFD0h, 7FFDDBF5EFE4h]
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
; location: [7FFDDBF5F000h, 7FFDDBF5F014h]
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
; location: [7FFDDBF5F030h, 7FFDDBF5F044h]
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
; location: [7FFDDBF5F060h, 7FFDDBF5F074h]
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
; location: [7FFDDBF5F090h, 7FFDDBF5F0A5h]
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
; location: [7FFDDBF5F0C0h, 7FFDDBF5F0D9h]
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
; location: [7FFDDBF5F0F0h, 7FFDDBF5F103h]
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
; location: [7FFDDBF5F120h, 7FFDDBF5F136h]
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
; location: [7FFDDBF5F150h, 7FFDDBF5F165h]
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
; location: [7FFDDBF5F180h, 7FFDDBF5F199h]
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
; location: [7FFDDBF5F1B0h, 7FFDDBF5F1C3h]
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
; location: [7FFDDBF5F1E0h, 7FFDDBF5F1F6h]
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
; location: [7FFDDBF5F210h, 7FFDDBF5F21Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g32i(int lhs, int rhs)
; location: [7FFDDBF5F640h, 7FFDDBF5F64Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d32u(uint lhs, uint rhs)
; location: [7FFDDBF5F660h, 7FFDDBF5F66Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g32u(uint lhs, uint rhs)
; location: [7FFDDBF5F680h, 7FFDDBF5F68Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d64i(long lhs, long rhs)
; location: [7FFDDBF5F6A0h, 7FFDDBF5F6AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g64i(long lhs, long rhs)
; location: [7FFDDBF5F6C0h, 7FFDDBF5F6CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5F6E0h, 7FFDDBF5F6EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF5F700h, 7FFDDBF5F70Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool neq_d32f(float lhs, float rhs)
; location: [7FFDDBF5F720h, 7FFDDBF5F734h]
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
; location: [7FFDDBF5F750h, 7FFDDBF5F764h]
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
; location: [7FFDDBF5F780h, 7FFDDBF5F794h]
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
; location: [7FFDDBF5F7B0h, 7FFDDBF5F7C4h]
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
; location: [7FFDDBF5F7E0h, 7FFDDBF5F7F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g8i(sbyte x)
; location: [7FFDDBF5F810h, 7FFDDBF5F829h]
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
; location: [7FFDDBF5F840h, 7FFDDBF5F850h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g8u(byte x)
; location: [7FFDDBF5F870h, 7FFDDBF5F888h]
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
; location: [7FFDDBF5F8A0h, 7FFDDBF5F8B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g16i(short x)
; location: [7FFDDBF5F8D0h, 7FFDDBF5F8E9h]
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
; location: [7FFDDBF5F900h, 7FFDDBF5F910h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g16u(ushort x)
; location: [7FFDDBF5F930h, 7FFDDBF5F948h]
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
; location: [7FFDDBF5F960h, 7FFDDBF5F96Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g32i(int x)
; location: [7FFDDBF5F980h, 7FFDDBF5F996h]
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
; location: [7FFDDBF5F9B0h, 7FFDDBF5F9BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g32u(uint x)
; location: [7FFDDBF5F9D0h, 7FFDDBF5F9E6h]
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
; location: [7FFDDBF5FA00h, 7FFDDBF5FA0Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g64i(long x)
; location: [7FFDDBF5FA20h, 7FFDDBF5FA36h]
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
; location: [7FFDDBF5FA50h, 7FFDDBF5FA5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool even_g64u(ulong x)
; location: [7FFDDBF5FA70h, 7FFDDBF5FA86h]
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
; location: [7FFDDBF5FAA0h, 7FFDDBF5FAB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g8i(sbyte x)
; location: [7FFDDBF5FAD0h, 7FFDDBF5FAE1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d8u(byte x)
; location: [7FFDDBF5FB00h, 7FFDDBF5FB10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g8u(byte x)
; location: [7FFDDBF5FB30h, 7FFDDBF5FB40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d16i(short x)
; location: [7FFDDBF5FB60h, 7FFDDBF5FB71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g16i(short x)
; location: [7FFDDBF5FB90h, 7FFDDBF5FBA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d16u(ushort x)
; location: [7FFDDBF5FBC0h, 7FFDDBF5FBD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g16u(ushort x)
; location: [7FFDDBF5FBF0h, 7FFDDBF5FC00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d32i(int x)
; location: [7FFDDBF5FC20h, 7FFDDBF5FC2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g32i(int x)
; location: [7FFDDBF5FC40h, 7FFDDBF5FC4Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d32u(uint x)
; location: [7FFDDBF5FC60h, 7FFDDBF5FC6Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g32u(uint x)
; location: [7FFDDBF5FC80h, 7FFDDBF5FC8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d64i(long x)
; location: [7FFDDBF5FCA0h, 7FFDDBF5FCAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g64i(long x)
; location: [7FFDDBF5FCC0h, 7FFDDBF5FCCEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_d64u(ulong x)
; location: [7FFDDBF5FCE0h, 7FFDDBF5FCEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool odd_g64u(ulong x)
; location: [7FFDDBF5FD00h, 7FFDDBF5FD0Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma_d8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDDBF5FD20h, 7FFDDBF5FD3Ah]
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
; location: [7FFDDBF5FD50h, 7FFDDBF5FD72h]
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
; location: [7FFDDBF5FD90h, 7FFDDBF5FDA7h]
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
; location: [7FFDDBF5FDC0h, 7FFDDBF5FDDDh]
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
; location: [7FFDDBF5FDF0h, 7FFDDBF5FE0Ah]
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
; location: [7FFDDBF5FE20h, 7FFDDBF5FE42h]
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
; location: [7FFDDBF5FE60h, 7FFDDBF5FE77h]
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
; location: [7FFDDBF5FE90h, 7FFDDBF5FEADh]
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
; location: [7FFDDBF5FEC0h, 7FFDDBF5FECDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma_g32i(int x, int a, int b)
; location: [7FFDDBF5FEE0h, 7FFDDBF5FEEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_d32u(uint x, uint a, uint b)
; location: [7FFDDBF5FF00h, 7FFDDBF5FF0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_g32u(uint x, uint a, uint b)
; location: [7FFDDBF60330h, 7FFDDBF6033Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_d64i(long x, long a, long b)
; location: [7FFDDBF60350h, 7FFDDBF6035Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_g64i(long x, long a, long b)
; location: [7FFDDBF60370h, 7FFDDBF6037Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_d64u(ulong x, ulong a, ulong b)
; location: [7FFDDBF60390h, 7FFDDBF6039Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_g64u(ulong x, ulong a, ulong b)
; location: [7FFDDBF603B0h, 7FFDDBF603BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_d32f(float x, float a, float b)
; location: [7FFDDBF603D0h, 7FFDDBF603DAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2    ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_g32f(float x, float a, float b)
; location: [7FFDDBF603F0h, 7FFDDBF603FAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2    ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_d64f(double x, double a, double b)
; location: [7FFDDBF60410h, 7FFDDBF6041Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2    ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_g64f(double x, double a, double b)
; location: [7FFDDBF60430h, 7FFDDBF6043Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2    ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool gt_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF60450h, 7FFDDBF60465h]
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
; location: [7FFDDBF60480h, 7FFDDBF60499h]
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
; location: [7FFDDBF604B0h, 7FFDDBF604C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF604E0h, 7FFDDBF604F7h]
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
; location: [7FFDDBF60510h, 7FFDDBF60520h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_g8u(byte lhs, byte rhs)
; location: [7FFDDBF60540h, 7FFDDBF60553h]
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
; location: [7FFDDBF60570h, 7FFDDBF60583h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_g16i(short lhs, short rhs)
; location: [7FFDDBF605A0h, 7FFDDBF605B7h]
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
; location: [7FFDDBF605D0h, 7FFDDBF605E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBF60600h, 7FFDDBF60613h]
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
; location: [7FFDDBF60630h, 7FFDDBF60638h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_g32i(int lhs, int rhs)
; location: [7FFDDBF60650h, 7FFDDBF60659h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_d32u(uint lhs, uint rhs)
; location: [7FFDDBF60670h, 7FFDDBF60678h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_g32u(uint lhs, uint rhs)
; location: [7FFDDBF60690h, 7FFDDBF60699h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_d64i(long lhs, long rhs)
; location: [7FFDDBF606B0h, 7FFDDBF606B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_g64i(long lhs, long rhs)
; location: [7FFDDBF606D0h, 7FFDDBF606DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF606F0h, 7FFDDBF606F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF60710h, 7FFDDBF6071Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool between_d8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDDBF60730h, 7FFDDBF60751h]
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
; location: [7FFDDBF60770h, 7FFDDBF60799h]
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
; location: [7FFDDBF607B0h, 7FFDDBF607CFh]
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
; location: [7FFDDBF60BF0h, 7FFDDBF60C15h]
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
; location: [7FFDDBF60C30h, 7FFDDBF60C51h]
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
; location: [7FFDDBF60C70h, 7FFDDBF60C99h]
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
; location: [7FFDDBF60CB0h, 7FFDDBF60CCFh]
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
; location: [7FFDDBF60CE0h, 7FFDDBF60D05h]
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
; location: [7FFDDBF60D20h, 7FFDDBF60D36h]
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
; location: [7FFDDBF60D50h, 7FFDDBF60D66h]
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
; location: [7FFDDBF60D80h, 7FFDDBF60D96h]
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
; location: [7FFDDBF60DB0h, 7FFDDBF60DC6h]
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
; location: [7FFDDBF60DE0h, 7FFDDBF60DF7h]
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
; location: [7FFDDBF60E10h, 7FFDDBF60E27h]
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
; location: [7FFDDBF60E40h, 7FFDDBF60E57h]
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
; location: [7FFDDBF60E70h, 7FFDDBF60E87h]
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
; location: [7FFDDBF60EA0h, 7FFDDBF60EAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte one_g8i()
; location: [7FFDDBF60EC0h, 7FFDDBF60ECAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_n8u()
; location: [7FFDDBF60EE0h, 7FFDDBF60EEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_g8u()
; location: [7FFDDBF60F00h, 7FFDDBF60F0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short one_n16i()
; location: [7FFDDBF60F20h, 7FFDDBF60F2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short one_g16i()
; location: [7FFDDBF61350h, 7FFDDBF6135Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_n16u()
; location: [7FFDDBF61370h, 7FFDDBF6137Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_g16u()
; location: [7FFDDBF61390h, 7FFDDBF6139Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_n32i()
; location: [7FFDDBF613B0h, 7FFDDBF613BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_g32i()
; location: [7FFDDBF613D0h, 7FFDDBF613DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_n32u()
; location: [7FFDDBF613F0h, 7FFDDBF613FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_g32u()
; location: [7FFDDBF61410h, 7FFDDBF6141Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_n64i()
; location: [7FFDDBF61430h, 7FFDDBF6143Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_g64i()
; location: [7FFDDBF61450h, 7FFDDBF6145Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_n64u()
; location: [7FFDDBF61470h, 7FFDDBF6147Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_g64u()
; location: [7FFDDBF61490h, 7FFDDBF6149Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_n32f()
; location: [7FFDDBF614B0h, 7FFDDBF614BDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBF614C0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_g32f()
; location: [7FFDDBF614E0h, 7FFDDBF614EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBF614F0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_n64f()
; location: [7FFDDBF61510h, 7FFDDBF6151Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBF61520h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_g64f()
; location: [7FFDDBF61540h, 7FFDDBF61552h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64fBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xB8,0x01,0x00,0x00,0x00,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte zero_g8i()
; location: [7FFDDBF61570h, 7FFDDBF61577h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g8iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte zero_g8u()
; location: [7FFDDBF61590h, 7FFDDBF61597h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short zero_g16i()
; location: [7FFDDBF615B0h, 7FFDDBF615B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g16iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort zero_g16u()
; location: [7FFDDBF615D0h, 7FFDDBF615D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int zero_g32i()
; location: [7FFDDBF615F0h, 7FFDDBF615F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint zero_g32u()
; location: [7FFDDBF61610h, 7FFDDBF61617h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long zero_g64i()
; location: [7FFDDBF61630h, 7FFDDBF61637h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong zero_g64u()
; location: [7FFDDBF61650h, 7FFDDBF61657h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float zero_g32f()
; location: [7FFDDBF61670h, 7FFDDBF61679h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double zero_g64f()
; location: [7FFDDBF61690h, 7FFDDBF616A2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000eh vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64fBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xB8,0x01,0x00,0x00,0x00,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_n8i()
; location: [7FFDDBF616C0h, 7FFDDBF616CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h            ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]             encoding(5 bytes) = b8 80 ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_g8i()
; location: [7FFDDBF61C30h, 7FFDDBF61C3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h            ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]             encoding(5 bytes) = b8 80 ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_n8u()
; location: [7FFDDBF61C50h, 7FFDDBF61C57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_g8u()
; location: [7FFDDBF61C70h, 7FFDDBF61C77h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_n16i()
; location: [7FFDDBF61C90h, 7FFDDBF61C9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h            ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]             encoding(5 bytes) = b8 00 80 ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_g16i()
; location: [7FFDDBF61CB0h, 7FFDDBF61CBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h            ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]             encoding(5 bytes) = b8 00 80 ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort minval_g16u()
; location: [7FFDDBF61CD0h, 7FFDDBF61CD7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_32i()
; location: [7FFDDBF61CF0h, 7FFDDBF61CFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h             ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]             encoding(5 bytes) = b8 00 00 00 80
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_g32i()
; location: [7FFDDBF61D10h, 7FFDDBF61D1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h             ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]             encoding(5 bytes) = b8 00 00 00 80
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_32u()
; location: [7FFDDBF61D30h, 7FFDDBF61D37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_g32u()
; location: [7FFDDBF62150h, 7FFDDBF62157h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long minval_g64i()
; location: [7FFDDBF62170h, 7FFDDBF6217Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong minval_g64u()
; location: [7FFDDBF62190h, 7FFDDBF62197h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float minval_g32f()
; location: [7FFDDBF621B0h, 7FFDDBF621BDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBF621C0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double minval_g64f()
; location: [7FFDDBF621E0h, 7FFDDBF621EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBF621F0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte maxval_g8i()
; location: [7FFDDBF62210h, 7FFDDBF6221Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7Fh                   ; MOV(Mov_r32_imm32) [EAX,7fh:imm32]                   encoding(5 bytes) = b8 7f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte maxval_g8u()
; location: [7FFDDBF62230h, 7FFDDBF6223Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short maxval_g16i()
; location: [7FFDDBF62250h, 7FFDDBF6225Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFh                 ; MOV(Mov_r32_imm32) [EAX,7fffh:imm32]                 encoding(5 bytes) = b8 ff 7f 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x7F,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort maxval_g16u()
; location: [7FFDDBF62680h, 7FFDDBF6268Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFh                ; MOV(Mov_r32_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = b8 ff ff 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_n32i()
; location: [7FFDDBF626A0h, 7FFDDBF626AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh             ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_g32i()
; location: [7FFDDBF626C0h, 7FFDDBF626CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh             ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_n32u()
; location: [7FFDDBF626E0h, 7FFDDBF626EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_g32u()
; location: [7FFDDBF62700h, 7FFDDBF6270Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long maxval_g64i()
; location: [7FFDDBF62720h, 7FFDDBF6272Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFFFFFFFFFFFFFFh     ; MOV(Mov_r64_imm64) [RAX,7fffffffffffffffh:imm64]     encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff 7f
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong maxval_g64u()
; location: [7FFDDBF62740h, 7FFDDBF6274Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFFFFFFFFFFh    ; MOV(Mov_r64_imm64) [RAX,ffffffffffffffffh:imm64]     encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff ff
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float maxval_g32f()
; location: [7FFDDBF62760h, 7FFDDBF6276Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBF62770h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_n64f()
; location: [7FFDDBF62790h, 7FFDDBF6279Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBF627A0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_g64f()
; location: [7FFDDBF627C0h, 7FFDDBF627CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBF627D0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_d8i(sbyte x)
; location: [7FFDDBF627F0h, 7FFDDBF627FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_g8i(sbyte x)
; location: [7FFDDBF62810h, 7FFDDBF6281Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_d8u(byte x)
; location: [7FFDDBF62830h, 7FFDDBF6283Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_g8u(byte x)
; location: [7FFDDBF62850h, 7FFDDBF6285Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_d16i(short x)
; location: [7FFDDBF62870h, 7FFDDBF6287Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_g16i(short x)
; location: [7FFDDBF62890h, 7FFDDBF6289Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_d16u(ushort x)
; location: [7FFDDBF628B0h, 7FFDDBF628BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_g16u(ushort x)
; location: [7FFDDBF628D0h, 7FFDDBF628DDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_d32i(int x)
; location: [7FFDDBF628F0h, 7FFDDBF628F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_g32i(int x)
; location: [7FFDDBF62910h, 7FFDDBF62919h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_d32u(uint x)
; location: [7FFDDBF62930h, 7FFDDBF62938h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_g32u(uint x)
; location: [7FFDDBF62950h, 7FFDDBF62959h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_d64i(long x)
; location: [7FFDDBF62970h, 7FFDDBF62979h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_g64i(long x)
; location: [7FFDDBF62990h, 7FFDDBF6299Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_d64u(ulong x)
; location: [7FFDDBF629B0h, 7FFDDBF629B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_g64u(ulong x)
; location: [7FFDDBF629D0h, 7FFDDBF629DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF629F0h, 7FFDDBF62A0Dh]
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
; location: [7FFDDBF62E30h, 7FFDDBF62E51h]
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
; location: [7FFDDBF62E70h, 7FFDDBF62E8Bh]
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
; location: [7FFDDBF62EA0h, 7FFDDBF62EBEh]
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
; location: [7FFDDBF62ED0h, 7FFDDBF62EEDh]
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
; location: [7FFDDBF62F00h, 7FFDDBF62F21h]
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
; location: [7FFDDBF62F40h, 7FFDDBF62F5Bh]
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
; location: [7FFDDBF62F70h, 7FFDDBF62F8Eh]
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
; location: [7FFDDBF62FA0h, 7FFDDBF62FB5h]
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
; location: [7FFDDBF62FD0h, 7FFDDBF62FE5h]
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
; location: [7FFDDBF63000h, 7FFDDBF63013h]
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
; location: [7FFDDBF63030h, 7FFDDBF63043h]
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
; location: [7FFDDBF63060h, 7FFDDBF63078h]
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
; location: [7FFDDBF63090h, 7FFDDBF630A8h]
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
; location: [7FFDDBF630C0h, 7FFDDBF630D8h]
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
; location: [7FFDDBF630F0h, 7FFDDBF63108h]
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
; location: [7FFDDBF63120h, 7FFDDBF63134h]
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
; location: [7FFDDBF63150h, 7FFDDBF63168h]
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
; location: [7FFDDBF63180h, 7FFDDBF63191h]
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
; location: [7FFDDBF631B0h, 7FFDDBF631C4h]
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
; location: [7FFDDBF631E0h, 7FFDDBF631F4h]
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
; location: [7FFDDBF63210h, 7FFDDBF63228h]
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
; location: [7FFDDBF63240h, 7FFDDBF63253h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF63270h, 7FFDDBF63287h]
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
; location: [7FFDDBF632A0h, 7FFDDBF632B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_g8u(byte lhs, byte rhs)
; location: [7FFDDBF632D0h, 7FFDDBF632E3h]
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
; location: [7FFDDBF63300h, 7FFDDBF63313h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_g16i(short lhs, short rhs)
; location: [7FFDDBF63330h, 7FFDDBF63347h]
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
; location: [7FFDDBF63360h, 7FFDDBF63370h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBF63390h, 7FFDDBF633A3h]
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
; location: [7FFDDBF633C0h, 7FFDDBF633C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_g32i(int lhs, int rhs)
; location: [7FFDDBF633E0h, 7FFDDBF633E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_d32u(uint lhs, uint rhs)
; location: [7FFDDBF63400h, 7FFDDBF63409h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_g32u(uint lhs, uint rhs)
; location: [7FFDDBF63420h, 7FFDDBF63429h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_d64i(long lhs, long rhs)
; location: [7FFDDBF63440h, 7FFDDBF6344Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_g64i(long lhs, long rhs)
; location: [7FFDDBF63870h, 7FFDDBF6387Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF63890h, 7FFDDBF6389Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF638B0h, 7FFDDBF638BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_d32f(float lhs, float rhs)
; location: [7FFDDBF638D0h, 7FFDDBF638F9h]
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
; location: [7FFDDBF63920h, 7FFDDBF63949h]
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
; location: [7FFDDBF63970h, 7FFDDBF6399Ah]
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
; location: [7FFDDBF639C0h, 7FFDDBF639EAh]
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
; location: [7FFDDBF63A10h, 7FFDDBF63A1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte flip_g8i(sbyte x)
; location: [7FFDDBF63A30h, 7FFDDBF63A3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte flip_d8u(byte x)
; location: [7FFDDBF63A50h, 7FFDDBF63A5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte flip_g8u(byte x)
; location: [7FFDDBF63A70h, 7FFDDBF63A7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short flip_d16i(short x)
; location: [7FFDDBF63A90h, 7FFDDBF63A9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short flip_g16i(short x)
; location: [7FFDDBF63AB0h, 7FFDDBF63ABFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort flip_d16u(ushort x)
; location: [7FFDDBF63AD0h, 7FFDDBF63ADDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort flip_g16u(ushort x)
; location: [7FFDDBF63AF0h, 7FFDDBF63AFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int flip_d32i(int x)
; location: [7FFDDBF63B10h, 7FFDDBF63B19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int flip_g32i(int x)
; location: [7FFDDBF63B30h, 7FFDDBF63B39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint flip_d32u(uint x)
; location: [7FFDDBF63B50h, 7FFDDBF63B59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint flip_g32u(uint x)
; location: [7FFDDBF63B70h, 7FFDDBF63B79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long flip_d64i(long x)
; location: [7FFDDBF63B90h, 7FFDDBF63B9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long flip_g64i(long x)
; location: [7FFDDBF63BB0h, 7FFDDBF63BBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong flip_d64u(ulong x)
; location: [7FFDDBF63BD0h, 7FFDDBF63BDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong flip_g64u(ulong x)
; location: [7FFDDBF63BF0h, 7FFDDBF63BFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF63C10h, 7FFDDBF63C23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF63C40h, 7FFDDBF63C57h]
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
; location: [7FFDDBF63C70h, 7FFDDBF63C80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_g8u(byte lhs, byte rhs)
; location: [7FFDDBF63CA0h, 7FFDDBF63CB3h]
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
; location: [7FFDDBF63CD0h, 7FFDDBF63CE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_g16i(short lhs, short rhs)
; location: [7FFDDBF63D00h, 7FFDDBF63D17h]
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
; location: [7FFDDBF63D30h, 7FFDDBF63D40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBF63D60h, 7FFDDBF63D73h]
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
; location: [7FFDDBF63D90h, 7FFDDBF63D99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_g32i(int lhs, int rhs)
; location: [7FFDDBF641C0h, 7FFDDBF641C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_d32u(uint lhs, uint rhs)
; location: [7FFDDBF641E0h, 7FFDDBF641E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_g32u(uint lhs, uint rhs)
; location: [7FFDDBF64200h, 7FFDDBF64209h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_d64i(long lhs, long rhs)
; location: [7FFDDBF64220h, 7FFDDBF6422Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_g64i(long lhs, long rhs)
; location: [7FFDDBF64240h, 7FFDDBF6424Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF64260h, 7FFDDBF6426Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF64280h, 7FFDDBF6428Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_d32f(float lhs, float rhs)
; location: [7FFDDBF642A0h, 7FFDDBF642C9h]
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
; location: [7FFDDBF642F0h, 7FFDDBF64319h]
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
; location: [7FFDDBF64340h, 7FFDDBF6436Ah]
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
; location: [7FFDDBF64390h, 7FFDDBF6439Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,7FFDDBF63ED0h         ; MOV(Mov_r64_imm64) [RAX,7ffddbf63ed0h:imm64]         encoding(10 bytes) = 48 b8 d0 3e f6 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> or_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xD0,0x3E,0xF6,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal_d8i(sbyte lhs, int offset)
; location: [7FFDDBF643C0h, 7FFDDBF643D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal_g8i(sbyte lhs, int offset)
; location: [7FFDDBF643F0h, 7FFDDBF64401h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal_d8u(byte lhs, int offset)
; location: [7FFDDBF64420h, 7FFDDBF6442Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal_g8u(byte lhs, int offset)
; location: [7FFDDBF64440h, 7FFDDBF6444Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal_d16i(short lhs, int offset)
; location: [7FFDDBF64460h, 7FFDDBF64471h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal_g16i(short lhs, int offset)
; location: [7FFDDBF64490h, 7FFDDBF644A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal_d16u(ushort lhs, int offset)
; location: [7FFDDBF644C0h, 7FFDDBF644CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal_g16u(ushort lhs, int offset)
; location: [7FFDDBF644E0h, 7FFDDBF644EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal_d32i(int lhs, int offset)
; location: [7FFDDBF64500h, 7FFDDBF6450Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal_g32i(int lhs, int offset)
; location: [7FFDDBF64520h, 7FFDDBF6452Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal_d32u(uint lhs, int offset)
; location: [7FFDDBF64540h, 7FFDDBF6454Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal_g32u(uint lhs, int offset)
; location: [7FFDDBF64560h, 7FFDDBF6456Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal_d64i(long lhs, int offset)
; location: [7FFDDBF64580h, 7FFDDBF6458Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal_g64i(long lhs, int offset)
; location: [7FFDDBF645A0h, 7FFDDBF645ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal_d64u(ulong lhs, int offset)
; location: [7FFDDBF645C0h, 7FFDDBF645CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal_g64u(ulong lhs, int offset)
; location: [7FFDDBF645E0h, 7FFDDBF645EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_b8i(sbyte lhs, int offset)
; location: [7FFDDBF64600h, 7FFDDBF64611h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_g8i(sbyte lhs, int offset)
; location: [7FFDDBF64630h, 7FFDDBF64641h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_b8u(byte lhs, int offset)
; location: [7FFDDBF64660h, 7FFDDBF6466Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_g8u(byte lhs, int offset)
; location: [7FFDDBF64A90h, 7FFDDBF64A9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_b16i(short lhs, int offset)
; location: [7FFDDBF64AB0h, 7FFDDBF64AC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_g16i(short lhs, int offset)
; location: [7FFDDBF64AE0h, 7FFDDBF64AF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_b16u(ushort lhs, int offset)
; location: [7FFDDBF64B10h, 7FFDDBF64B1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_g16u(ushort lhs, int offset)
; location: [7FFDDBF64B30h, 7FFDDBF64B3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_b32i(int lhs, int offset)
; location: [7FFDDBF64B50h, 7FFDDBF64B5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_g32i(int lhs, int offset)
; location: [7FFDDBF64B70h, 7FFDDBF64B7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_b32u(uint lhs, int offset)
; location: [7FFDDBF64B90h, 7FFDDBF64B9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_g32u(uint lhs, int offset)
; location: [7FFDDBF64BB0h, 7FFDDBF64BBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_b64i(long lhs, int offset)
; location: [7FFDDBF64BD0h, 7FFDDBF64BDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_g64i(long lhs, int offset)
; location: [7FFDDBF64BF0h, 7FFDDBF64BFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_b64u(ulong lhs, int offset)
; location: [7FFDDBF64C10h, 7FFDDBF64C1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_g64u(ulong lhs, int offset)
; location: [7FFDDBF64C30h, 7FFDDBF64C3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_d8i(sbyte lhs, int offset)
; location: [7FFDDBF64C50h, 7FFDDBF64C61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_g8i(sbyte lhs, int offset)
; location: [7FFDDBF64C80h, 7FFDDBF64C91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_d8u(byte lhs, int offset)
; location: [7FFDDBF64CB0h, 7FFDDBF64CBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_g8u(byte lhs, int offset)
; location: [7FFDDBF64CD0h, 7FFDDBF64CDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_d16i(short lhs, int offset)
; location: [7FFDDBF64CF0h, 7FFDDBF64D01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_g16i(short lhs, int offset)
; location: [7FFDDBF64D20h, 7FFDDBF64D31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_d16u(ushort lhs, int offset)
; location: [7FFDDBF64D50h, 7FFDDBF64D5Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_g16u(ushort lhs, int offset)
; location: [7FFDDBF64D70h, 7FFDDBF64D7Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_d32i(int lhs, int offset)
; location: [7FFDDBF64D90h, 7FFDDBF64D9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_g32i(int lhs, int offset)
; location: [7FFDDBF64DB0h, 7FFDDBF64DBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_d32u(uint lhs, int offset)
; location: [7FFDDBF64DD0h, 7FFDDBF64DDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_g32u(uint lhs, int offset)
; location: [7FFDDBF64DF0h, 7FFDDBF64DFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_d64i(long lhs, int offset)
; location: [7FFDDBF64E10h, 7FFDDBF64E1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_g64i(long lhs, int offset)
; location: [7FFDDBF64E30h, 7FFDDBF64E3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_d64u(ulong lhs, int offset)
; location: [7FFDDBF64E50h, 7FFDDBF64E5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_g64u(ulong lhs, int offset)
; location: [7FFDDBF64E70h, 7FFDDBF64E7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF64E90h, 7FFDDBF64EA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBF64EC0h, 7FFDDBF64ED7h]
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
; location: [7FFDDBF64EF0h, 7FFDDBF64F00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_g8u(byte lhs, byte rhs)
; location: [7FFDDBF65320h, 7FFDDBF65333h]
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
; location: [7FFDDBF65350h, 7FFDDBF65363h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_g16i(short lhs, short rhs)
; location: [7FFDDBF65380h, 7FFDDBF65397h]
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
; location: [7FFDDBF653B0h, 7FFDDBF653C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBF653E0h, 7FFDDBF653F3h]
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
; location: [7FFDDBF65410h, 7FFDDBF65419h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_g32i(int lhs, int rhs)
; location: [7FFDDBF65430h, 7FFDDBF65439h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_d32u(uint lhs, uint rhs)
; location: [7FFDDBF65450h, 7FFDDBF65459h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_g32u(uint lhs, uint rhs)
; location: [7FFDDBF65470h, 7FFDDBF65479h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_d64i(long lhs, long rhs)
; location: [7FFDDBF65490h, 7FFDDBF6549Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_g64i(long lhs, long rhs)
; location: [7FFDDBF654B0h, 7FFDDBF654BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBF654D0h, 7FFDDBF654DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBF654F0h, 7FFDDBF654FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs_d8i(sbyte x)
; location: [7FFDDBF65510h, 7FFDDBF65526h]
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
; location: [7FFDDBF65540h, 7FFDDBF65556h]
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
; location: [7FFDDBF65570h, 7FFDDBF65586h]
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
; location: [7FFDDBF655A0h, 7FFDDBF655B6h]
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
; location: [7FFDDBF655D0h, 7FFDDBF655DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs_g32i(int x)
; location: [7FFDDBF655F0h, 7FFDDBF655FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_d64i(long x)
; location: [7FFDDBF65610h, 7FFDDBF65623h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_g64i(long x)
; location: [7FFDDBF65640h, 7FFDDBF65653h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
