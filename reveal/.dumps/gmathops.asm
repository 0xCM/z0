; 2020-01-11 03:38:50:834
; function: Sign:int signum_d64u(ulong x)
; static ReadOnlySpan<byte> signum_d64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h jne short 0011h                         ; JNE(Jne_rel8_64) [11h:jmp64]               encoding(2 bytes) = 75 07
000ah mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000fh jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 05
0011h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64u(ulong x)
; static ReadOnlySpan<byte> signum_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h jne short 0011h                         ; JNE(Jne_rel8_64) [11h:jmp64]               encoding(2 bytes) = 75 07
000ah mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000fh jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 05
0011h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32f(float x)
; static ReadOnlySpan<byte> signum_g32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x6C,0xF7,0xBD,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FF7C7A352D8h                      ; CALL(Call_rel32_64) [FFFFFFFFFFBDF778h:jmp64] encoding(5 bytes) = e8 6c f7 bd ff
000ch nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32f(float x)
; static ReadOnlySpan<byte> signum_d32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xD8,0x52,0xA3,0xC7,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,7FF7C7A352D8h                   ; MOV(Mov_r64_imm64) [RAX,7ff7c7a352d8h:imm64] encoding(10 bytes) = 48 b8 d8 52 a3 c7 f7 7f 00 00
000fh jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64f(double x)
; static ReadOnlySpan<byte> signum_d64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xB0,0x52,0xA3,0xC7,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,7FF7C7A352B0h                   ; MOV(Mov_r64_imm64) [RAX,7ff7c7a352b0h:imm64] encoding(10 bytes) = 48 b8 b0 52 a3 c7 f7 7f 00 00
000fh jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64f(double x)
; static ReadOnlySpan<byte> signum_g64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0xB4,0xF6,0xBD,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FF7C7A352B0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFBDF6C0h:jmp64] encoding(5 bytes) = e8 b4 f6 bd ff
000ch nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_d8i(sbyte x)
; static ReadOnlySpan<byte> square_d8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000ch movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_g8i(sbyte x)
; static ReadOnlySpan<byte> square_g8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000ch movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_d8u(byte x)
; static ReadOnlySpan<byte> square_d8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_g8u(byte x)
; static ReadOnlySpan<byte> square_g8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_d16i(short x)
; static ReadOnlySpan<byte> square_d16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_g16i(short x)
; static ReadOnlySpan<byte> square_g16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_d16u(ushort x)
; static ReadOnlySpan<byte> square_d16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_g16u(ushort x)
; static ReadOnlySpan<byte> square_g16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_d32i(int x)
; static ReadOnlySpan<byte> square_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,ecx                            ; IMUL(Imul_r32_rm32) [EAX,ECX]              encoding(3 bytes) = 0f af c1
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_g32i(int x)
; static ReadOnlySpan<byte> square_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                            ; IMUL(Imul_r32_rm32) [ECX,ECX]              encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_d32u(uint x)
; static ReadOnlySpan<byte> square_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,ecx                            ; IMUL(Imul_r32_rm32) [EAX,ECX]              encoding(3 bytes) = 0f af c1
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_g32u(uint x)
; static ReadOnlySpan<byte> square_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                            ; IMUL(Imul_r32_rm32) [ECX,ECX]              encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square_d64i(long x)
; static ReadOnlySpan<byte> square_d64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                            ; IMUL(Imul_r64_rm64) [RAX,RCX]              encoding(4 bytes) = 48 0f af c1
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long square_g64i(long x)
; static ReadOnlySpan<byte> square_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                            ; IMUL(Imul_r64_rm64) [RCX,RCX]              encoding(4 bytes) = 48 0f af c9
0009h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square_d64u(ulong x)
; static ReadOnlySpan<byte> square_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                            ; IMUL(Imul_r64_rm64) [RAX,RCX]              encoding(4 bytes) = 48 0f af c1
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square_g64u(ulong x)
; static ReadOnlySpan<byte> square_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                            ; IMUL(Imul_r64_rm64) [RCX,RCX]              encoding(4 bytes) = 48 0f af c9
0009h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float square_d32f(float x)
; static ReadOnlySpan<byte> square_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm0                   ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fa 59 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float square_g32f(float x)
; static ReadOnlySpan<byte> square_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm0                   ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fa 59 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double square_d64f(double x)
; static ReadOnlySpan<byte> square_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm0                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 59 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double square_g64f(double x)
; static ReadOnlySpan<byte> square_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm0                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 59 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_d8i(sbyte lhs, byte offset)
; static ReadOnlySpan<byte> srl_d8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_g8i(sbyte lhs, byte offset)
; static ReadOnlySpan<byte> srl_g8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_d8u(byte lhs, byte offset)
; static ReadOnlySpan<byte> srl_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_g8u(byte lhs, byte offset)
; static ReadOnlySpan<byte> srl_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_d16i(short lhs, byte offset)
; static ReadOnlySpan<byte> srl_d16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_g16i(short lhs, byte offset)
; static ReadOnlySpan<byte> srl_g16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_d16u(ushort lhs, byte offset)
; static ReadOnlySpan<byte> srl_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_g16u(ushort lhs, byte offset)
; static ReadOnlySpan<byte> srl_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_d32i(int lhs, byte offset)
; static ReadOnlySpan<byte> srl_d32iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_g32i(int lhs, byte offset)
; static ReadOnlySpan<byte> srl_g32iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_d32u(uint lhs, byte offset)
; static ReadOnlySpan<byte> srl_d32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_g32u(uint lhs, byte offset)
; static ReadOnlySpan<byte> srl_g32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_d64i(long lhs, byte offset)
; static ReadOnlySpan<byte> srl_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_g64i(long lhs, byte offset)
; static ReadOnlySpan<byte> srl_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_d64u(ulong lhs, byte offset)
; static ReadOnlySpan<byte> srl_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_g64u(ulong lhs, byte offset)
; static ReadOnlySpan<byte> srl_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> sub_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> sub_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> sub_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> sub_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> sub_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> sub_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> sub_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> sub_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> sub_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> sub_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                             ; SUB(Sub_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 2b ca
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> sub_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> sub_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                             ; SUB(Sub_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 2b ca
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> sub_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                             ; SUB(Sub_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 2b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> sub_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                             ; SUB(Sub_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> sub_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                             ; SUB(Sub_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 2b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> sub_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                             ; SUB(Sub_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float sub_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> sub_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5C,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubss xmm0,xmm0,xmm1                   ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 5c c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float sub_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> sub_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5C,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubss xmm0,xmm0,xmm1                   ; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 5c c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double sub_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> sub_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5C,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubsd xmm0,xmm0,xmm1                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 5c c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double sub_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> sub_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5C,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubsd xmm0,xmm0,xmm1                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 5c c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> xor_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> xor_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> xor_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> xor_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> xor_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> xor_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> xor_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> xor_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> xor_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> xor_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                             ; XOR(Xor_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 33 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> xor_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> xor_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                             ; XOR(Xor_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 33 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> xor_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                             ; XOR(Xor_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 33 c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> xor_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                             ; XOR(Xor_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> xor_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                             ; XOR(Xor_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 33 c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> xor_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                             ; XOR(Xor_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float xor_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> xor_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x33,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h xor eax,[rsp+10h]                       ; XOR(Xor_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 33 44 24 10
001bh mov [rsp+0Ch],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]         ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float xor_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> xor_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x33,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h xor eax,[rsp+10h]                       ; XOR(Xor_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 33 44 24 10
001bh mov [rsp+0Ch],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]         ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double xor_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> xor_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x33,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h xor rax,[rsp+8]                         ; XOR(Xor_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 33 44 24 08
001dh mov [rsp],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]             ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double xor_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> xor_g64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x33,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h xor rax,[rsp+8]                         ; XOR(Xor_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 33 44 24 08
001dh mov [rsp],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]             ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d16i(short x)
; static ReadOnlySpan<byte> nonzero_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx                         ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX] encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0                  ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,:sr),0h:imm16] encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g16i(short x)
; static ReadOnlySpan<byte> nonzero_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d16u(ushort x)
; static ReadOnlySpan<byte> nonzero_d16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx                         ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX] encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0                  ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,:sr),0h:imm16] encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g16u(ushort x)
; static ReadOnlySpan<byte> nonzero_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d32i(int x)
; static ReadOnlySpan<byte> nonzero_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g32i(int x)
; static ReadOnlySpan<byte> nonzero_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d32u(uint x)
; static ReadOnlySpan<byte> nonzero_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g32u(uint x)
; static ReadOnlySpan<byte> nonzero_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d64i(long x)
; static ReadOnlySpan<byte> nonzero_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g64i(long x)
; static ReadOnlySpan<byte> nonzero_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64u(ulong x)
; static ReadOnlySpan<byte> nonzero_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g64u(ulong x)
; static ReadOnlySpan<byte> nonzero_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n32f(float x)
; static ReadOnlySpan<byte> nonzero_n32fBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
000dh setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                          ; JP(Jp_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7a 03
0012h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g32f(float x)
; static ReadOnlySpan<byte> nonzero_g32fBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
000dh setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                          ; JP(Jp_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7a 03
0012h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0020h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64f(double x)
; static ReadOnlySpan<byte> nonzero_n64fBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
000dh setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                          ; JP(Jp_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7a 03
0012h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_g64f(double x)
; static ReadOnlySpan<byte> nonzero_g64fBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
000dh setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
0010h jp short 0015h                          ; JP(Jp_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7a 03
0012h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0020h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte not_d8i(sbyte x)
; static ReadOnlySpan<byte> not_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte not_g8i(sbyte x)
; static ReadOnlySpan<byte> not_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte not_d8u(byte x)
; static ReadOnlySpan<byte> not_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte not_g8u(byte x)
; static ReadOnlySpan<byte> not_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short not_d16i(short x)
; static ReadOnlySpan<byte> not_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short not_g16i(short x)
; static ReadOnlySpan<byte> not_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort not_d16u(ushort x)
; static ReadOnlySpan<byte> not_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort not_g16u(ushort x)
; static ReadOnlySpan<byte> not_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int not_d32i(int x)
; static ReadOnlySpan<byte> not_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int not_g32i(int x)
; static ReadOnlySpan<byte> not_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint not_d32u(uint x)
; static ReadOnlySpan<byte> not_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint not_g32u(uint x)
; static ReadOnlySpan<byte> not_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long not_d64i(long x)
; static ReadOnlySpan<byte> not_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long not_g64i(long x)
; static ReadOnlySpan<byte> not_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong not_d64u(ulong x)
; static ReadOnlySpan<byte> not_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong not_g64u(ulong x)
; static ReadOnlySpan<byte> not_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> or_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> or_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> or_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> or_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> or_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> or_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> or_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> or_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> or_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> or_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                              ; OR(Or_r32_rm32) [EDX,ECX]                  encoding(2 bytes) = 0b d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> or_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> or_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                              ; OR(Or_r32_rm32) [EDX,ECX]                  encoding(2 bytes) = 0b d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> or_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                              ; OR(Or_r64_rm64) [RAX,RDX]                  encoding(3 bytes) = 48 0b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> or_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                              ; OR(Or_r64_rm64) [RDX,RCX]                  encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> or_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                              ; OR(Or_r64_rm64) [RAX,RDX]                  encoding(3 bytes) = 48 0b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> or_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                              ; OR(Or_r64_rm64) [RDX,RCX]                  encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> or_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]                        ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]         ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> or_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]                        ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]         ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> or_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h or rax,[rsp+8]                          ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]  encoding(5 bytes) = 48 0b 44 24 08
001dh mov [rsp],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]             ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> or_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xA0,0x7E,0xE5,0xC7,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,7FF7C7E57EA0h                   ; MOV(Mov_r64_imm64) [RAX,7ff7c7e57ea0h:imm64] encoding(10 bytes) = 48 b8 a0 7e e5 c7 f7 7f 00 00
000fh jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Perm4L:byte perm4_assemble_id()
; static ReadOnlySpan<byte> perm4_assemble_idBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xE4,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0E4h                            ; MOV(Mov_r32_imm32) [EAX,e4h:imm32]         encoding(5 bytes) = b8 e4 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Perm4L:byte perm4_assemble_rid()
; static ReadOnlySpan<byte> perm4_assemble_ridBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x1B,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1Bh                             ; MOV(Mov_r32_imm32) [EAX,1bh:imm32]         encoding(5 bytes) = b8 1b 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8i(sbyte x)
; static ReadOnlySpan<byte> positive_n8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8i(sbyte x)
; static ReadOnlySpan<byte> positive_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8u(byte x)
; static ReadOnlySpan<byte> positive_n8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                              ; TEST(Test_rm8_r8) [CL,CL]                  encoding(2 bytes) = 84 c9
0007h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8u(byte x)
; static ReadOnlySpan<byte> positive_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0012h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16i(short x)
; static ReadOnlySpan<byte> positive_n16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16i(short x)
; static ReadOnlySpan<byte> positive_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16u(ushort x)
; static ReadOnlySpan<byte> positive_n16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16u(ushort x)
; static ReadOnlySpan<byte> positive_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0012h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32i(int x)
; static ReadOnlySpan<byte> positive_n32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32i(int x)
; static ReadOnlySpan<byte> positive_g32iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32u(uint x)
; static ReadOnlySpan<byte> positive_n32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32u(uint x)
; static ReadOnlySpan<byte> positive_g32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64i(long x)
; static ReadOnlySpan<byte> positive_n64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64i(long x)
; static ReadOnlySpan<byte> positive_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0010h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64u(ulong x)
; static ReadOnlySpan<byte> positive_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64u(ulong x)
; static ReadOnlySpan<byte> positive_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0010h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32f(float x)
; static ReadOnlySpan<byte> positive_n32fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32f(float x)
; static ReadOnlySpan<byte> positive_g32fBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64f(double x)
; static ReadOnlySpan<byte> positive_n64fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64f(double x)
; static ReadOnlySpan<byte> positive_g64fBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit ispow2_g16u(ushort a)
; static ReadOnlySpan<byte> ispow2_g16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x8D,0x50,0xFF,0x48,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h lea rdx,[rax-1]                         ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 48 8d 50 ff
000ch test rax,rdx                            ; TEST(Test_rm64_r64) [RDX,RAX]              encoding(3 bytes) = 48 85 c2
000fh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit ispow2_16u(ushort a)
; static ReadOnlySpan<byte> ispow2_16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8D,0x50,0xFF,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h lea edx,[rax-1]                         ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,:sr)] encoding(3 bytes) = 8d 50 ff
000bh test eax,edx                            ; TEST(Test_rm32_r32) [EDX,EAX]              encoding(2 bytes) = 85 c2
000dh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_b8i(sbyte b, uint exp)
; static ReadOnlySpan<byte> pow_b8iBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x22,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x07,0x0F,0xAF,0xC8,0x48,0x0F,0xBE,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x09,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xEB,0xE5,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000bh jne short 0014h                         ; JNE(Jne_rel8_64) [14h:jmp64]               encoding(2 bytes) = 75 07
000dh mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0012h jmp short 0036h                         ; JMP(Jmp_rel8_64) [36h:jmp64]               encoding(2 bytes) = eb 22
0014h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0019h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001ch je short 0025h                          ; JE(Je_rel8_64) [25h:jmp64]                 encoding(2 bytes) = 74 07
001eh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0021h movsx rcx,cl                            ; MOVSX(Movsx_r64_rm8) [RCX,CL]              encoding(4 bytes) = 48 0f be c9
0025h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0027h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0029h je short 0034h                          ; JE(Je_rel8_64) [34h:jmp64]                 encoding(2 bytes) = 74 09
002bh imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0032h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb e5
0034h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0036h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_g8i(sbyte b, uint exp)
; static ReadOnlySpan<byte> pow_g8iBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xD2,0x75,0x07,0xB9,0x01,0x00,0x00,0x00,0xEB,0x20,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x07,0x0F,0xAF,0xC8,0x48,0x0F,0xBE,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x09,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xEB,0xE5,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000bh jne short 0014h                         ; JNE(Jne_rel8_64) [14h:jmp64]               encoding(2 bytes) = 75 07
000dh mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0012h jmp short 0034h                         ; JMP(Jmp_rel8_64) [34h:jmp64]               encoding(2 bytes) = eb 20
0014h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0019h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001ch je short 0025h                          ; JE(Je_rel8_64) [25h:jmp64]                 encoding(2 bytes) = 74 07
001eh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0021h movsx rcx,cl                            ; MOVSX(Movsx_r64_rm8) [RCX,CL]              encoding(4 bytes) = 48 0f be c9
0025h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0027h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0029h je short 0034h                          ; JE(Je_rel8_64) [34h:jmp64]                 encoding(2 bytes) = 74 09
002bh imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0032h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb e5
0034h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0036h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_b8u(byte b, uint exp)
; static ReadOnlySpan<byte> pow_b8uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x20,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x06,0x0F,0xAF,0xC8,0x0F,0xB6,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x08,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xEB,0xE7,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0011h jmp short 0033h                         ; JMP(Jmp_rel8_64) [33h:jmp64]               encoding(2 bytes) = eb 20
0013h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0018h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001bh je short 0023h                          ; JE(Je_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 74 06
001dh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0020h movzx ecx,cl                            ; MOVZX(Movzx_r32_rm8) [ECX,CL]              encoding(3 bytes) = 0f b6 c9
0023h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0025h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0027h je short 0031h                          ; JE(Je_rel8_64) [31h:jmp64]                 encoding(2 bytes) = 74 08
0029h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002fh jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb e7
0031h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_g8u(byte b, uint exp)
; static ReadOnlySpan<byte> pow_g8uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xD2,0x75,0x07,0xB9,0x01,0x00,0x00,0x00,0xEB,0x1E,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x06,0x0F,0xAF,0xC8,0x0F,0xB6,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x08,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xEB,0xE7,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0011h jmp short 0031h                         ; JMP(Jmp_rel8_64) [31h:jmp64]               encoding(2 bytes) = eb 1e
0013h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0018h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001bh je short 0023h                          ; JE(Je_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 74 06
001dh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0020h movzx ecx,cl                            ; MOVZX(Movzx_r32_rm8) [ECX,CL]              encoding(3 bytes) = 0f b6 c9
0023h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0025h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0027h je short 0031h                          ; JE(Je_rel8_64) [31h:jmp64]                 encoding(2 bytes) = 74 08
0029h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002fh jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb e7
0031h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_b16i(short b, uint exp)
; static ReadOnlySpan<byte> pow_b16iBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x22,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x07,0x0F,0xAF,0xC8,0x48,0x0F,0xBF,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x09,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xEB,0xE5,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000bh jne short 0014h                         ; JNE(Jne_rel8_64) [14h:jmp64]               encoding(2 bytes) = 75 07
000dh mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0012h jmp short 0036h                         ; JMP(Jmp_rel8_64) [36h:jmp64]               encoding(2 bytes) = eb 22
0014h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0019h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001ch je short 0025h                          ; JE(Je_rel8_64) [25h:jmp64]                 encoding(2 bytes) = 74 07
001eh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0021h movsx rcx,cx                            ; MOVSX(Movsx_r64_rm16) [RCX,CX]             encoding(4 bytes) = 48 0f bf c9
0025h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0027h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0029h je short 0034h                          ; JE(Je_rel8_64) [34h:jmp64]                 encoding(2 bytes) = 74 09
002bh imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0032h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb e5
0034h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0036h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_g16i(short b, uint exp)
; static ReadOnlySpan<byte> pow_g16iBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xD2,0x75,0x07,0xB9,0x01,0x00,0x00,0x00,0xEB,0x20,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x07,0x0F,0xAF,0xC8,0x48,0x0F,0xBF,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x09,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xEB,0xE5,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000bh jne short 0014h                         ; JNE(Jne_rel8_64) [14h:jmp64]               encoding(2 bytes) = 75 07
000dh mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0012h jmp short 0034h                         ; JMP(Jmp_rel8_64) [34h:jmp64]               encoding(2 bytes) = eb 20
0014h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0019h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001ch je short 0025h                          ; JE(Je_rel8_64) [25h:jmp64]                 encoding(2 bytes) = 74 07
001eh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0021h movsx rcx,cx                            ; MOVSX(Movsx_r64_rm16) [RCX,CX]             encoding(4 bytes) = 48 0f bf c9
0025h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0027h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0029h je short 0034h                          ; JE(Je_rel8_64) [34h:jmp64]                 encoding(2 bytes) = 74 09
002bh imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0032h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb e5
0034h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0036h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_b16u(ushort b, uint exp)
; static ReadOnlySpan<byte> pow_b16uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x20,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x06,0x0F,0xAF,0xC8,0x0F,0xB7,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x08,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xEB,0xE7,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0011h jmp short 0033h                         ; JMP(Jmp_rel8_64) [33h:jmp64]               encoding(2 bytes) = eb 20
0013h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0018h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001bh je short 0023h                          ; JE(Je_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 74 06
001dh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0020h movzx ecx,cx                            ; MOVZX(Movzx_r32_rm16) [ECX,CX]             encoding(3 bytes) = 0f b7 c9
0023h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0025h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0027h je short 0031h                          ; JE(Je_rel8_64) [31h:jmp64]                 encoding(2 bytes) = 74 08
0029h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002ch movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
002fh jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb e7
0031h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_g16u(ushort b, uint exp)
; static ReadOnlySpan<byte> pow_g16uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xD2,0x75,0x07,0xB9,0x01,0x00,0x00,0x00,0xEB,0x1E,0xB9,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x06,0x0F,0xAF,0xC8,0x0F,0xB7,0xC9,0xD1,0xEA,0x85,0xD2,0x74,0x08,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xEB,0xE7,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0011h jmp short 0031h                         ; JMP(Jmp_rel8_64) [31h:jmp64]               encoding(2 bytes) = eb 1e
0013h mov ecx,1                               ; MOV(Mov_r32_imm32) [ECX,1h:imm32]          encoding(5 bytes) = b9 01 00 00 00
0018h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
001bh je short 0023h                          ; JE(Je_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 74 06
001dh imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
0020h movzx ecx,cx                            ; MOVZX(Movzx_r32_rm16) [ECX,CX]             encoding(3 bytes) = 0f b7 c9
0023h shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0025h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0027h je short 0031h                          ; JE(Je_rel8_64) [31h:jmp64]                 encoding(2 bytes) = 74 08
0029h imul eax,eax                            ; IMUL(Imul_r32_rm32) [EAX,EAX]              encoding(3 bytes) = 0f af c0
002ch movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
002fh jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb e7
0031h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_b32i(int b, uint exp)
; static ReadOnlySpan<byte> pow_b32iBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x18,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x03,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x05,0x0F,0xAF,0xC9,0xEB,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 0028h                         ; JMP(Jmp_rel8_64) [28h:jmp64]               encoding(2 bytes) = eb 18
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001dh                          ; JE(Je_rel8_64) [1Dh:jmp64]                 encoding(2 bytes) = 74 03
001ah imul eax,ecx                            ; IMUL(Imul_r32_rm32) [EAX,ECX]              encoding(3 bytes) = 0f af c1
001dh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
001fh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0021h je short 0028h                          ; JE(Je_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 74 05
0023h imul ecx,ecx                            ; IMUL(Imul_r32_rm32) [ECX,ECX]              encoding(3 bytes) = 0f af c9
0026h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb ed
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_g32i(int b, uint exp)
; static ReadOnlySpan<byte> pow_g32iBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x18,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x03,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x05,0x0F,0xAF,0xC9,0xEB,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 0028h                         ; JMP(Jmp_rel8_64) [28h:jmp64]               encoding(2 bytes) = eb 18
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001dh                          ; JE(Je_rel8_64) [1Dh:jmp64]                 encoding(2 bytes) = 74 03
001ah imul eax,ecx                            ; IMUL(Imul_r32_rm32) [EAX,ECX]              encoding(3 bytes) = 0f af c1
001dh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
001fh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0021h je short 0028h                          ; JE(Je_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 74 05
0023h imul ecx,ecx                            ; IMUL(Imul_r32_rm32) [ECX,ECX]              encoding(3 bytes) = 0f af c9
0026h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb ed
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_b32u(uint b, uint exp)
; static ReadOnlySpan<byte> pow_b32uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x18,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x03,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x05,0x0F,0xAF,0xC9,0xEB,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 0028h                         ; JMP(Jmp_rel8_64) [28h:jmp64]               encoding(2 bytes) = eb 18
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001dh                          ; JE(Je_rel8_64) [1Dh:jmp64]                 encoding(2 bytes) = 74 03
001ah imul eax,ecx                            ; IMUL(Imul_r32_rm32) [EAX,ECX]              encoding(3 bytes) = 0f af c1
001dh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
001fh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0021h je short 0028h                          ; JE(Je_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 74 05
0023h imul ecx,ecx                            ; IMUL(Imul_r32_rm32) [ECX,ECX]              encoding(3 bytes) = 0f af c9
0026h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb ed
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_g32u(uint b, uint exp)
; static ReadOnlySpan<byte> pow_g32uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x18,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x03,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x05,0x0F,0xAF,0xC9,0xEB,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 0028h                         ; JMP(Jmp_rel8_64) [28h:jmp64]               encoding(2 bytes) = eb 18
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001dh                          ; JE(Je_rel8_64) [1Dh:jmp64]                 encoding(2 bytes) = 74 03
001ah imul eax,ecx                            ; IMUL(Imul_r32_rm32) [EAX,ECX]              encoding(3 bytes) = 0f af c1
001dh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
001fh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0021h je short 0028h                          ; JE(Je_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 74 05
0023h imul ecx,ecx                            ; IMUL(Imul_r32_rm32) [ECX,ECX]              encoding(3 bytes) = 0f af c9
0026h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb ed
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_b64i(long b, uint exp)
; static ReadOnlySpan<byte> pow_b64iBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x1A,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x04,0x48,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x06,0x48,0x0F,0xAF,0xC9,0xEB,0xEB,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 002ah                         ; JMP(Jmp_rel8_64) [2Ah:jmp64]               encoding(2 bytes) = eb 1a
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001eh                          ; JE(Je_rel8_64) [1Eh:jmp64]                 encoding(2 bytes) = 74 04
001ah imul rax,rcx                            ; IMUL(Imul_r64_rm64) [RAX,RCX]              encoding(4 bytes) = 48 0f af c1
001eh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0020h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0022h je short 002ah                          ; JE(Je_rel8_64) [2Ah:jmp64]                 encoding(2 bytes) = 74 06
0024h imul rcx,rcx                            ; IMUL(Imul_r64_rm64) [RCX,RCX]              encoding(4 bytes) = 48 0f af c9
0028h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb eb
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_g64i(long b, uint exp)
; static ReadOnlySpan<byte> pow_g64iBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x1A,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x04,0x48,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x06,0x48,0x0F,0xAF,0xC9,0xEB,0xEB,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 002ah                         ; JMP(Jmp_rel8_64) [2Ah:jmp64]               encoding(2 bytes) = eb 1a
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001eh                          ; JE(Je_rel8_64) [1Eh:jmp64]                 encoding(2 bytes) = 74 04
001ah imul rax,rcx                            ; IMUL(Imul_r64_rm64) [RAX,RCX]              encoding(4 bytes) = 48 0f af c1
001eh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0020h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0022h je short 002ah                          ; JE(Je_rel8_64) [2Ah:jmp64]                 encoding(2 bytes) = 74 06
0024h imul rcx,rcx                            ; IMUL(Imul_r64_rm64) [RCX,RCX]              encoding(4 bytes) = 48 0f af c9
0028h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb eb
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_b64u(ulong b, uint exp)
; static ReadOnlySpan<byte> pow_b64uBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x1A,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x04,0x48,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x06,0x48,0x0F,0xAF,0xC9,0xEB,0xEB,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 002ah                         ; JMP(Jmp_rel8_64) [2Ah:jmp64]               encoding(2 bytes) = eb 1a
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001eh                          ; JE(Je_rel8_64) [1Eh:jmp64]                 encoding(2 bytes) = 74 04
001ah imul rax,rcx                            ; IMUL(Imul_r64_rm64) [RAX,RCX]              encoding(4 bytes) = 48 0f af c1
001eh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0020h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0022h je short 002ah                          ; JE(Je_rel8_64) [2Ah:jmp64]                 encoding(2 bytes) = 74 06
0024h imul rcx,rcx                            ; IMUL(Imul_r64_rm64) [RCX,RCX]              encoding(4 bytes) = 48 0f af c9
0028h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb eb
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_g64u(ulong b, uint exp)
; static ReadOnlySpan<byte> pow_g64uBytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xD2,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x1A,0xB8,0x01,0x00,0x00,0x00,0xF6,0xC2,0x01,0x74,0x04,0x48,0x0F,0xAF,0xC1,0xD1,0xEA,0x85,0xD2,0x74,0x06,0x48,0x0F,0xAF,0xC9,0xEB,0xEB,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000eh jmp short 002ah                         ; JMP(Jmp_rel8_64) [2Ah:jmp64]               encoding(2 bytes) = eb 1a
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h test dl,1                               ; TEST(Test_rm8_imm8) [DL,1h:imm8]           encoding(3 bytes) = f6 c2 01
0018h je short 001eh                          ; JE(Je_rel8_64) [1Eh:jmp64]                 encoding(2 bytes) = 74 04
001ah imul rax,rcx                            ; IMUL(Imul_r64_rm64) [RAX,RCX]              encoding(4 bytes) = 48 0f af c1
001eh shr edx,1                               ; SHR(Shr_rm32_1) [EDX,1h:imm8]              encoding(2 bytes) = d1 ea
0020h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0022h je short 002ah                          ; JE(Je_rel8_64) [2Ah:jmp64]                 encoding(2 bytes) = 74 06
0024h imul rcx,rcx                            ; IMUL(Imul_r64_rm64) [RCX,RCX]              encoding(4 bytes) = 48 0f af c9
0028h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb eb
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float pow_d32f(float b, uint exp)
; static ReadOnlySpan<byte> pow_d32fBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0xC2,0xC5,0xF0,0x57,0xC9,0xC4,0xE1,0xF3,0x2A,0xC8,0xC5,0xF3,0x5A,0xC9,0x48,0xB8,0x20,0x8D,0x4B,0x27,0xF8,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
000bh vcvtsi2sd xmm1,xmm1,rax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM1,XMM1,RAX] encoding(VEX, 5 bytes) = c4 e1 f3 2a c8
0010h vcvtsd2ss xmm1,xmm1,xmm1                ; VCVTSD2SS(VEX_Vcvtsd2ss_xmm_xmm_xmmm64) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f3 5a c9
0014h mov rax,7FF8274B8D20h                   ; MOV(Mov_r64_imm64) [RAX,7ff8274b8d20h:imm64] encoding(10 bytes) = 48 b8 20 8d 4b 27 f8 7f 00 00
001eh jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float pow_g32f(float b, uint exp)
; static ReadOnlySpan<byte> pow_g32fBytes => new byte[33]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x8B,0xC2,0xC5,0xF0,0x57,0xC9,0xC4,0xE1,0xF3,0x2A,0xC8,0xC5,0xF3,0x5A,0xC9,0xE8,0xA5,0xF9,0x65,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vcvtsi2sd xmm1,xmm1,rax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM1,XMM1,RAX] encoding(VEX, 5 bytes) = c4 e1 f3 2a c8
0012h vcvtsd2ss xmm1,xmm1,xmm1                ; VCVTSD2SS(VEX_Vcvtsd2ss_xmm_xmm_xmmm64) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f3 5a c9
0016h call 7FF8274B8D20h                      ; CALL(Call_rel32_64) [5F65F9C0h:jmp64]      encoding(5 bytes) = e8 a5 f9 65 5f
001bh nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
001ch add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0020h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double pow_d64f(double b, uint exp)
; static ReadOnlySpan<byte> pow_d64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0xC2,0xC5,0xF0,0x57,0xC9,0xC4,0xE1,0xF3,0x2A,0xC8,0x48,0xB8,0xE0,0x8E,0x4B,0x27,0xF8,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
000bh vcvtsi2sd xmm1,xmm1,rax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM1,XMM1,RAX] encoding(VEX, 5 bytes) = c4 e1 f3 2a c8
0010h mov rax,7FF8274B8EE0h                   ; MOV(Mov_r64_imm64) [RAX,7ff8274b8ee0h:imm64] encoding(10 bytes) = 48 b8 e0 8e 4b 27 f8 7f 00 00
001ah jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double pow_g64f(double b, uint exp)
; static ReadOnlySpan<byte> pow_g64fBytes => new byte[29]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x8B,0xC2,0xC5,0xF0,0x57,0xC9,0xC4,0xE1,0xF3,0x2A,0xC8,0xE8,0xF9,0xFA,0x65,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vcvtsi2sd xmm1,xmm1,rax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM1,XMM1,RAX] encoding(VEX, 5 bytes) = c4 e1 f3 2a c8
0012h call 7FF8274B8EE0h                      ; CALL(Call_rel32_64) [5F65FB10h:jmp64]      encoding(5 bytes) = e8 f9 fa 65 5f
0017h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0018h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_d8i(sbyte lhs, byte offset)
; static ReadOnlySpan<byte> sar_d8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_g8i(sbyte lhs, byte offset)
; static ReadOnlySpan<byte> sar_g8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_d8u(byte lhs, byte offset)
; static ReadOnlySpan<byte> sar_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_g8u(byte lhs, byte offset)
; static ReadOnlySpan<byte> sar_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_d16i(short lhs, byte offset)
; static ReadOnlySpan<byte> sar_d16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_g16i(short lhs, byte offset)
; static ReadOnlySpan<byte> sar_g16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ch sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_d16u(ushort lhs, byte offset)
; static ReadOnlySpan<byte> sar_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_g16u(ushort lhs, byte offset)
; static ReadOnlySpan<byte> sar_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_d32i(int lhs, byte offset)
; static ReadOnlySpan<byte> sar_d32iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_g32i(int lhs, byte offset)
; static ReadOnlySpan<byte> sar_g32iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah sar eax,cl                              ; SAR(Sar_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 f8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_d32u(uint lhs, byte offset)
; static ReadOnlySpan<byte> sar_d32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_g32u(uint lhs, byte offset)
; static ReadOnlySpan<byte> sar_g32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_d64i(long lhs, byte offset)
; static ReadOnlySpan<byte> sar_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh sar rax,cl                              ; SAR(Sar_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 f8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_g64i(long lhs, byte offset)
; static ReadOnlySpan<byte> sar_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh sar rax,cl                              ; SAR(Sar_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 f8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_d64u(ulong lhs, byte offset)
; static ReadOnlySpan<byte> sar_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_g64u(ulong lhs, byte offset)
; static ReadOnlySpan<byte> sar_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x0F,0xB6,0xCA,0x48,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh shr rax,cl                              ; SHR(Shr_rm64_CL) [RAX,CL]                  encoding(3 bytes) = 48 d3 e8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select_1(ulong a, ulong b, ulong c)
; static ReadOnlySpan<byte> select_1Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0xC4,0xC2,0xF0,0xF2,0xC0,0x48,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                             ; AND(And_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 23 d1
0008h andn rax,rcx,r8                         ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RCX,R8]   encoding(VEX, 5 bytes) = c4 c2 f0 f2 c0
000dh or rax,rdx                              ; OR(Or_r64_rm64) [RAX,RDX]                  encoding(3 bytes) = 48 0b c2
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select_2(ulong a, ulong b, ulong c)
; static ReadOnlySpan<byte> select_2Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                             ; XOR(Xor_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 33 d1
0008h and rdx,r8                              ; AND(And_r64_rm64) [RDX,R8]                 encoding(3 bytes) = 49 23 d0
000bh xor rdx,rcx                             ; XOR(Xor_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 33 d1
000eh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d8i(sbyte x)
; static ReadOnlySpan<byte> signum_d8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh not edx                                 ; NOT(Not_rm32) [EDX]                        encoding(2 bytes) = f7 d2
000dh inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
000fh shr edx,1Fh                             ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]          encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g8i(sbyte x)
; static ReadOnlySpan<byte> signum_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh not edx                                 ; NOT(Not_rm32) [EDX]                        encoding(2 bytes) = f7 d2
000dh inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
000fh shr edx,1Fh                             ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]          encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d8u(byte x)
; static ReadOnlySpan<byte> signum_d8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                              ; TEST(Test_rm8_r8) [CL,CL]                  encoding(2 bytes) = 84 c9
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000eh jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 05
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g8u(byte x)
; static ReadOnlySpan<byte> signum_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
0011h jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb 05
0013h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16i(short x)
; static ReadOnlySpan<byte> signum_d16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh not edx                                 ; NOT(Not_rm32) [EDX]                        encoding(2 bytes) = f7 d2
000dh inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
000fh shr edx,1Fh                             ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]          encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g16i(short x)
; static ReadOnlySpan<byte> signum_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh not edx                                 ; NOT(Not_rm32) [EDX]                        encoding(2 bytes) = f7 d2
000dh inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
000fh shr edx,1Fh                             ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]          encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16u(ushort x)
; static ReadOnlySpan<byte> signum_d16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
0011h jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb 05
0013h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g16u(ushort x)
; static ReadOnlySpan<byte> signum_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah jne short 0013h                         ; JNE(Jne_rel8_64) [13h:jmp64]               encoding(2 bytes) = 75 07
000ch mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
0011h jmp short 0018h                         ; JMP(Jmp_rel8_64) [18h:jmp64]               encoding(2 bytes) = eb 05
0013h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32i(int x)
; static ReadOnlySpan<byte> signum_d32iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC1,0xE8,0x1F,0xC1,0xF9,0x1F,0x0B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh shr eax,1Fh                             ; SHR(Shr_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 e8 1f
000eh sar ecx,1Fh                             ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]          encoding(3 bytes) = c1 f9 1f
0011h or eax,ecx                              ; OR(Or_r32_rm32) [EAX,ECX]                  encoding(2 bytes) = 0b c1
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32i(int x)
; static ReadOnlySpan<byte> signum_g32iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC1,0xE8,0x1F,0xC1,0xF9,0x1F,0x0B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh shr eax,1Fh                             ; SHR(Shr_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 e8 1f
000eh sar ecx,1Fh                             ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]          encoding(3 bytes) = c1 f9 1f
0011h or eax,ecx                              ; OR(Or_r32_rm32) [EAX,ECX]                  encoding(2 bytes) = 0b c1
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32u(uint x)
; static ReadOnlySpan<byte> signum_d32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000eh jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 05
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32u(uint x)
; static ReadOnlySpan<byte> signum_g32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 07
0009h mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000eh jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 05
0010h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64i(long x)
; static ReadOnlySpan<byte> signum_d64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0xC1,0xE8,0x3F,0x48,0xC1,0xF9,0x3F,0x8B,0xD1,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh inc rax                                 ; INC(Inc_rm64) [RAX]                        encoding(3 bytes) = 48 ff c0
000eh shr rax,3Fh                             ; SHR(Shr_rm64_imm8) [RAX,3fh:imm8]          encoding(4 bytes) = 48 c1 e8 3f
0012h sar rcx,3Fh                             ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]          encoding(4 bytes) = 48 c1 f9 3f
0016h mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
0018h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64i(long x)
; static ReadOnlySpan<byte> signum_g64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0xC1,0xE8,0x3F,0x48,0xC1,0xF9,0x3F,0x8B,0xD1,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh inc rax                                 ; INC(Inc_rm64) [RAX]                        encoding(3 bytes) = 48 ff c0
000eh shr rax,3Fh                             ; SHR(Shr_rm64_imm8) [RAX,3fh:imm8]          encoding(4 bytes) = 48 c1 e8 3f
0012h sar rcx,3Fh                             ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]          encoding(4 bytes) = 48 c1 f9 3f
0016h mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
0018h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> lteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> lteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> lteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> lteq_d32fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC8,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> lteq_g32fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC8,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> lteq_d64fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC8,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lteq_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> lteq_g64fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC8,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max_d8i(sbyte a, sbyte b)
; static ReadOnlySpan<byte> max_d8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh jg short 0013h                          ; JG(Jg_rel8_64) [13h:jmp64]                 encoding(2 bytes) = 7f 02
0011h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 02
0013h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0015h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max_g8i(sbyte a, sbyte b)
; static ReadOnlySpan<byte> max_g8iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h jg short 0017h                          ; JG(Jg_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 7f 02
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0019h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte max_d8u(byte a, byte b)
; static ReadOnlySpan<byte> max_d8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh jg short 0011h                          ; JG(Jg_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7f 02
000fh jmp short 0013h                         ; JMP(Jmp_rel8_64) [13h:jmp64]               encoding(2 bytes) = eb 02
0011h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0013h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte max_g8u(byte a, byte b)
; static ReadOnlySpan<byte> max_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h jg short 0014h                          ; JG(Jg_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 7f 02
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0016h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short max_d16i(short a, short b)
; static ReadOnlySpan<byte> max_d16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh jg short 0013h                          ; JG(Jg_rel8_64) [13h:jmp64]                 encoding(2 bytes) = 7f 02
0011h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 02
0013h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0015h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short max_g16i(short a, short b)
; static ReadOnlySpan<byte> max_g16iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h jg short 0017h                          ; JG(Jg_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 7f 02
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0019h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort max_d16u(ushort a, ushort b)
; static ReadOnlySpan<byte> max_d16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh jg short 0011h                          ; JG(Jg_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7f 02
000fh jmp short 0013h                         ; JMP(Jmp_rel8_64) [13h:jmp64]               encoding(2 bytes) = eb 02
0011h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0013h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort max_g16u(ushort a, ushort b)
; static ReadOnlySpan<byte> max_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h jg short 0014h                          ; JG(Jg_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 7f 02
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0016h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max_d32i(int a, int b)
; static ReadOnlySpan<byte> max_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jg short 000bh                          ; JG(Jg_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7f 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max_g32i(int a, int b)
; static ReadOnlySpan<byte> max_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jg short 000bh                          ; JG(Jg_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7f 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_d32u(uint a, uint b)
; static ReadOnlySpan<byte> max_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h ja short 000bh                          ; JA(Ja_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 77 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_g32u(uint a, uint b)
; static ReadOnlySpan<byte> max_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h ja short 000bh                          ; JA(Ja_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 77 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max_d64i(long a, long b)
; static ReadOnlySpan<byte> max_d64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jg short 000ch                          ; JG(Jg_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7f 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max_g64i(long a, long b)
; static ReadOnlySpan<byte> max_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jg short 000ch                          ; JG(Jg_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7f 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max_d64u(ulong a, ulong b)
; static ReadOnlySpan<byte> max_d64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h ja short 000ch                          ; JA(Ja_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 77 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max_g64u(ulong a, ulong b)
; static ReadOnlySpan<byte> max_g64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h ja short 000ch                          ; JA(Ja_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 77 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float max_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> max_d32fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float max_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> max_g32fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double max_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> max_d64fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double max_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> max_g64fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> min_d8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh jl short 0013h                          ; JL(Jl_rel8_64) [13h:jmp64]                 encoding(2 bytes) = 7c 02
0011h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 02
0013h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0015h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> min_g8iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h jl short 0017h                          ; JL(Jl_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 7c 02
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0019h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte min_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> min_d8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh jl short 0011h                          ; JL(Jl_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7c 02
000fh jmp short 0013h                         ; JMP(Jmp_rel8_64) [13h:jmp64]               encoding(2 bytes) = eb 02
0011h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0013h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte min_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> min_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h jl short 0014h                          ; JL(Jl_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 7c 02
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0016h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short min_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> min_d16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh jl short 0013h                          ; JL(Jl_rel8_64) [13h:jmp64]                 encoding(2 bytes) = 7c 02
0011h jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 02
0013h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0015h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short min_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> min_g16iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h jl short 0017h                          ; JL(Jl_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 7c 02
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0019h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort min_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> min_d16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh jl short 0011h                          ; JL(Jl_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7c 02
000fh jmp short 0013h                         ; JMP(Jmp_rel8_64) [13h:jmp64]               encoding(2 bytes) = eb 02
0011h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0013h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort min_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> min_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x7C,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h jl short 0014h                          ; JL(Jl_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 7c 02
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
0016h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> min_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jl short 000bh                          ; JL(Jl_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7c 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> min_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jl short 000bh                          ; JL(Jl_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7c 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> min_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jb short 000bh                          ; JB(Jb_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 72 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> min_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jb short 000bh                          ; JB(Jb_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 72 02
0009h jmp short 000dh                         ; JMP(Jmp_rel8_64) [Dh:jmp64]                encoding(2 bytes) = eb 02
000bh mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000dh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> min_d64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jl short 000ch                          ; JL(Jl_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7c 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> min_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jl short 000ch                          ; JL(Jl_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7c 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> min_d64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jb short 000ch                          ; JB(Jb_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 72 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> min_g64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jb short 000ch                          ; JB(Jb_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 72 02
000ah jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb 03
000ch mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float min_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> min_d32fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC8,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float min_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> min_g32fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC8,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double min_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> min_d64fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC8,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double min_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> min_g64fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC8,0x77,0x02,0xEB,0x04,0xC5,0xF8,0x28,0xC8,0xC5,0xF8,0x28,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0009h ja short 000dh                          ; JA(Ja_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 77 02
000bh jmp short 0011h                         ; JMP(Jmp_rel8_64) [11h:jmp64]               encoding(2 bytes) = eb 04
000dh vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
0011h vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_n8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> mod_n8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                            ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dl                            ; MOVSX(Movsx_r64_rm8) [RAX,DL]              encoding(4 bytes) = 48 0f be c2
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> mod_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                            ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dl                            ; MOVSX(Movsx_r64_rm8) [RAX,DL]              encoding(4 bytes) = 48 0f be c2
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> mod_g8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                            ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dl                            ; MOVSX(Movsx_r64_rm8) [RAX,DL]              encoding(4 bytes) = 48 0f be c2
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_n8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> mod_n8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> mod_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> mod_g8uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x33,0xD2,0xF7,0xF1,0x0F,0xB6,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div ecx                                 ; DIV(Div_rm32) [ECX]                        encoding(2 bytes) = f7 f1
000fh movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mod_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> mod_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                            ; MOVSX(Movsx_r64_rm16) [RCX,DX]             encoding(4 bytes) = 48 0f bf ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dx                            ; MOVSX(Movsx_r64_rm16) [RAX,DX]             encoding(4 bytes) = 48 0f bf c2
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mod_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> mod_g16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                            ; MOVSX(Movsx_r64_rm16) [RCX,DX]             encoding(4 bytes) = 48 0f bf ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,dx                            ; MOVSX(Movsx_r64_rm16) [RAX,DX]             encoding(4 bytes) = 48 0f bf c2
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mod_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> mod_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                            ; MOVZX(Movzx_r32_rm16) [ECX,DX]             encoding(3 bytes) = 0f b7 ca
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mod_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> mod_g16uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x33,0xD2,0xF7,0xF1,0x0F,0xB7,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                            ; MOVZX(Movzx_r32_rm16) [ECX,DX]             encoding(3 bytes) = 0f b7 ca
000bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div ecx                                 ; DIV(Div_rm32) [ECX]                        encoding(2 bytes) = f7 f1
000fh movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> mod_d32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000bh idiv r8d                                ; IDIV(Idiv_rm32) [R8D]                      encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> mod_g32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000bh idiv r8d                                ; IDIV(Idiv_rm32) [R8D]                      encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> mod_d32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ch div r8d                                 ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> mod_g32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ch div r8d                                 ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> mod_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh cqo                                     ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000dh idiv r8                                 ; IDIV(Idiv_rm64) [R8]                       encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> mod_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh cqo                                     ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000dh idiv r8                                 ; IDIV(Idiv_rm64) [R8]                       encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> mod_d64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div r8                                  ; DIV(Div_rm64) [R8]                         encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> mod_g64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div r8                                  ; DIV(Div_rm64) [R8]                         encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> mod_d32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x34,0x65,0x53,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FF827391660h                      ; CALL(Call_rel32_64) [5F536540h:jmp64]      encoding(5 bytes) = e8 34 65 53 5f
000ch nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> mod_g32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x04,0x65,0x53,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FF827391660h                      ; CALL(Call_rel32_64) [5F536510h:jmp64]      encoding(5 bytes) = e8 04 65 53 5f
000ch nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> mod_d64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x44,0x64,0x53,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FF8273915D0h                      ; CALL(Call_rel32_64) [5F536450h:jmp64]      encoding(5 bytes) = e8 44 64 53 5f
000ch nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> mod_g64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x14,0x64,0x53,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FF8273915D0h                      ; CALL(Call_rel32_64) [5F536420h:jmp64]      encoding(5 bytes) = e8 14 64 53 5f
000ch nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
000dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_u128(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<Pair<ulong>> dst)
; static ReadOnlySpan<byte> mul_u128Bytes => new byte[108]{0x57,0x56,0x53,0x66,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x4C,0x8B,0x0A,0x44,0x8B,0x52,0x08,0x4D,0x8B,0x18,0x45,0x8B,0x40,0x08,0x41,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xD1,0x45,0x3B,0xD0,0x7C,0x02,0xEB,0x03,0x45,0x8B,0xC2,0x33,0xC9,0x45,0x85,0xC0,0x7E,0x34,0x48,0x63,0xD1,0x48,0x8D,0x14,0xD0,0x4C,0x63,0xD1,0x4F,0x8D,0x14,0xD1,0x48,0x63,0xF1,0x48,0xC1,0xE6,0x04,0x49,0x03,0xF3,0x48,0x8B,0x12,0x4D,0x8B,0x12,0x48,0x8B,0xFE,0xC4,0xC2,0xE3,0xF6,0xD2,0x48,0x89,0x1F,0x48,0x89,0x56,0x08,0xFF,0xC1,0x41,0x3B,0xC8,0x7C,0xCC,0x5B,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]                         ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,:sr)] encoding(3 bytes) = 8b 49 08
000bh mov r9,[rdx]                            ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 4c 8b 0a
000eh mov r10d,[rdx+8]                        ; MOV(Mov_r32_rm32) [R10D,mem(32u,RDX:br,:sr)] encoding(4 bytes) = 44 8b 52 08
0012h mov r11,[r8]                            ; MOV(Mov_r64_rm64) [R11,mem(64u,R8:br,:sr)] encoding(3 bytes) = 4d 8b 18
0015h mov r8d,[r8+8]                          ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,:sr)] encoding(4 bytes) = 45 8b 40 08
0019h cmp ecx,r10d                            ; CMP(Cmp_r32_rm32) [ECX,R10D]               encoding(3 bytes) = 41 3b ca
001ch jl short 0020h                          ; JL(Jl_rel8_64) [20h:jmp64]                 encoding(2 bytes) = 7c 02
001eh jmp short 0023h                         ; JMP(Jmp_rel8_64) [23h:jmp64]               encoding(2 bytes) = eb 03
0020h mov r10d,ecx                            ; MOV(Mov_r32_rm32) [R10D,ECX]               encoding(3 bytes) = 44 8b d1
0023h cmp r10d,r8d                            ; CMP(Cmp_r32_rm32) [R10D,R8D]               encoding(3 bytes) = 45 3b d0
0026h jl short 002ah                          ; JL(Jl_rel8_64) [2Ah:jmp64]                 encoding(2 bytes) = 7c 02
0028h jmp short 002dh                         ; JMP(Jmp_rel8_64) [2Dh:jmp64]               encoding(2 bytes) = eb 03
002ah mov r8d,r10d                            ; MOV(Mov_r32_rm32) [R8D,R10D]               encoding(3 bytes) = 45 8b c2
002dh xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
002fh test r8d,r8d                            ; TEST(Test_rm32_r32) [R8D,R8D]              encoding(3 bytes) = 45 85 c0
0032h jle short 0068h                         ; JLE(Jle_rel8_64) [68h:jmp64]               encoding(2 bytes) = 7e 34
0034h movsxd rdx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]          encoding(3 bytes) = 48 63 d1
0037h lea rdx,[rax+rdx*8]                     ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 48 8d 14 d0
003bh movsxd r10,ecx                          ; MOVSXD(Movsxd_r64_rm32) [R10,ECX]          encoding(3 bytes) = 4c 63 d1
003eh lea r10,[r9+r10*8]                      ; LEA(Lea_r64_m) [R10,mem(Unknown,R9:br,:sr)] encoding(4 bytes) = 4f 8d 14 d1
0042h movsxd rsi,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RSI,ECX]          encoding(3 bytes) = 48 63 f1
0045h shl rsi,4                               ; SHL(Shl_rm64_imm8) [RSI,4h:imm8]           encoding(4 bytes) = 48 c1 e6 04
0049h add rsi,r11                             ; ADD(Add_r64_rm64) [RSI,R11]                encoding(3 bytes) = 49 03 f3
004ch mov rdx,[rdx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 12
004fh mov r10,[r10]                           ; MOV(Mov_r64_rm64) [R10,mem(64u,R10:br,:sr)] encoding(3 bytes) = 4d 8b 12
0052h mov rdi,rsi                             ; MOV(Mov_r64_rm64) [RDI,RSI]                encoding(3 bytes) = 48 8b fe
0055h mulx rdx,rbx,r10                        ; MULX(VEX_Mulx_r64_r64_rm64) [RDX,RBX,R10]  encoding(VEX, 5 bytes) = c4 c2 e3 f6 d2
005ah mov [rdi],rbx                           ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX] encoding(3 bytes) = 48 89 1f
005dh mov [rsi+8],rdx                         ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RDX] encoding(4 bytes) = 48 89 56 08
0061h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0063h cmp ecx,r8d                             ; CMP(Cmp_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 3b c8
0066h jl short 0034h                          ; JL(Jl_rel8_64) [34h:jmp64]                 encoding(2 bytes) = 7c cc
0068h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
0069h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
006ah pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
006bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> mul_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> mul_g8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> mul_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> mul_g8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> mul_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> mul_g16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> mul_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> mul_g16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> mul_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> mul_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                            ; IMUL(Imul_r32_rm32) [EDX,ECX]              encoding(3 bytes) = 0f af d1
0008h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> mul_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> mul_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                            ; IMUL(Imul_r32_rm32) [EDX,ECX]              encoding(3 bytes) = 0f af d1
0008h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> mul_d64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                            ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> mul_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                            ; IMUL(Imul_r64_rm64) [RDX,RCX]              encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> mul_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                            ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> mul_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                            ; IMUL(Imul_r64_rm64) [RDX,RCX]              encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mul_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> mul_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm1                   ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 59 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mul_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> mul_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x59,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulss xmm0,xmm0,xmm1                   ; VMULSS(VEX_Vmulss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 59 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mul_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> mul_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm1                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 59 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mul_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> mul_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x59,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmulsd xmm0,xmm0,xmm1                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 59 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_d8i(sbyte x)
; static ReadOnlySpan<byte> negate_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_g8i(sbyte x)
; static ReadOnlySpan<byte> negate_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_d8u(byte x)
; static ReadOnlySpan<byte> negate_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_g8u(byte x)
; static ReadOnlySpan<byte> negate_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_d16i(short x)
; static ReadOnlySpan<byte> negate_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_g16i(short x)
; static ReadOnlySpan<byte> negate_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_d16u(ushort x)
; static ReadOnlySpan<byte> negate_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_g16u(ushort x)
; static ReadOnlySpan<byte> negate_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_d32i(int x)
; static ReadOnlySpan<byte> negate_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_g32i(int x)
; static ReadOnlySpan<byte> negate_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_d32u(uint x)
; static ReadOnlySpan<byte> negate_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_g32u(uint x)
; static ReadOnlySpan<byte> negate_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_d64i(long x)
; static ReadOnlySpan<byte> negate_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h neg rax                                 ; NEG(Neg_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d8
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_g64i(long x)
; static ReadOnlySpan<byte> negate_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h neg rax                                 ; NEG(Neg_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d8
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_d64u(ulong x)
; static ReadOnlySpan<byte> negate_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh inc rax                                 ; INC(Inc_rm64) [RAX]                        encoding(3 bytes) = 48 ff c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_g64u(ulong x)
; static ReadOnlySpan<byte> negate_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h not rax                                 ; NOT(Not_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d0
000bh inc rax                                 ; INC(Inc_rm64) [RAX]                        encoding(3 bytes) = 48 ff c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_g32f(float x)
; static ReadOnlySpan<byte> negate_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FF7C7E5C398h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_d32f(float x)
; static ReadOnlySpan<byte> negate_d32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FF7C7E5C3C8h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_d64f(double x)
; static ReadOnlySpan<byte> negate_d64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FF7C7E5C3F8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_g64f(double x)
; static ReadOnlySpan<byte> negate_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FF7C7E5C428h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d8i(sbyte x)
; static ReadOnlySpan<byte> negative_d8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g8i(sbyte x)
; static ReadOnlySpan<byte> negative_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d16i(short x)
; static ReadOnlySpan<byte> negative_d16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g16i(short x)
; static ReadOnlySpan<byte> negative_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32i(int x)
; static ReadOnlySpan<byte> negative_d32iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32i(int x)
; static ReadOnlySpan<byte> negative_g32iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0007h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64i(long x)
; static ReadOnlySpan<byte> negative_d64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0010h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64i(long x)
; static ReadOnlySpan<byte> negative_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0010h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32f(float x)
; static ReadOnlySpan<byte> negative_d32fBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64f(double x)
; static ReadOnlySpan<byte> negative_d64fBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_n32f(float x)
; static ReadOnlySpan<byte> negative_n32fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32f(float x)
; static ReadOnlySpan<byte> negative_g32fBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_n64f(double x)
; static ReadOnlySpan<byte> negative_n64fBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64f(double x)
; static ReadOnlySpan<byte> negative_g64fBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d8i(sbyte x)
; static ReadOnlySpan<byte> nonzero_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx                         ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX] encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0                  ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8] encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g8i(sbyte x)
; static ReadOnlySpan<byte> nonzero_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d8u(byte x)
; static ReadOnlySpan<byte> nonzero_d8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx                         ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX] encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0                  ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8] encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g8u(byte x)
; static ReadOnlySpan<byte> nonzero_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g32u(uint x)
; static ReadOnlySpan<byte> odd_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d64i(long x)
; static ReadOnlySpan<byte> odd_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g64i(long x)
; static ReadOnlySpan<byte> odd_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d64u(ulong x)
; static ReadOnlySpan<byte> odd_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g64u(ulong x)
; static ReadOnlySpan<byte> odd_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma_d8i(sbyte x, sbyte a, sbyte b)
; static ReadOnlySpan<byte> fma_d8iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x49,0x0F,0xBE,0xD0,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rdx,r8b                           ; MOVSX(Movsx_r64_rm8) [RDX,R8L]             encoding(4 bytes) = 49 0f be d0
0014h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0016h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma_g8i(sbyte x, sbyte a, sbyte b)
; static ReadOnlySpan<byte> fma_g8iBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x49,0x0F,0xBE,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,r8b                           ; MOVSX(Movsx_r64_rm8) [RCX,R8L]             encoding(4 bytes) = 49 0f be c8
0011h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0015h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
0019h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
001ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
001eh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0022h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte fma_d8u(byte x, byte a, byte b)
; static ReadOnlySpan<byte> fma_d8uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x41,0x0F,0xB6,0xD0,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
0012h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte fma_g8u(byte x, byte a, byte b)
; static ReadOnlySpan<byte> fma_g8uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,r8b                           ; MOVZX(Movzx_r32_rm8) [ECX,R8L]             encoding(4 bytes) = 41 0f b6 c8
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0015h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0018h add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
001ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short fma_d16i(short x, short a, short b)
; static ReadOnlySpan<byte> fma_d16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x49,0x0F,0xBF,0xD0,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0010h movsx rdx,r8w                           ; MOVSX(Movsx_r64_rm16) [RDX,R8W]            encoding(4 bytes) = 49 0f bf d0
0014h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0016h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short fma_g16i(short x, short a, short b)
; static ReadOnlySpan<byte> fma_g16iBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x49,0x0F,0xBF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,r8w                           ; MOVSX(Movsx_r64_rm16) [RCX,R8W]            encoding(4 bytes) = 49 0f bf c8
0011h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0015h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
0019h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
001ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
001eh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0022h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort fma_d16u(ushort x, ushort a, ushort b)
; static ReadOnlySpan<byte> fma_d16uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x41,0x0F,0xB7,0xD0,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh movzx edx,r8w                           ; MOVZX(Movzx_r32_rm16) [EDX,R8W]            encoding(4 bytes) = 41 0f b7 d0
0012h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0014h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort fma_g16u(ushort x, ushort a, ushort b)
; static ReadOnlySpan<byte> fma_g16uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x41,0x0F,0xB7,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x03,0xC1,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,r8w                           ; MOVZX(Movzx_r32_rm16) [ECX,R8W]            encoding(4 bytes) = 41 0f b7 c8
000fh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0012h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
0015h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
0018h add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
001ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma_d32i(int x, int a, int b)
; static ReadOnlySpan<byte> fma_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000ah add eax,r8d                             ; ADD(Add_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 03 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma_g32i(int x, int a, int b)
; static ReadOnlySpan<byte> fma_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                            ; IMUL(Imul_r32_rm32) [EDX,ECX]              encoding(3 bytes) = 0f af d1
0008h add edx,r8d                             ; ADD(Add_r32_rm32) [EDX,R8D]                encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_d32u(uint x, uint a, uint b)
; static ReadOnlySpan<byte> fma_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000ah add eax,r8d                             ; ADD(Add_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 03 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_g32u(uint x, uint a, uint b)
; static ReadOnlySpan<byte> fma_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                            ; IMUL(Imul_r32_rm32) [EDX,ECX]              encoding(3 bytes) = 0f af d1
0008h add edx,r8d                             ; ADD(Add_r32_rm32) [EDX,R8D]                encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_d64i(long x, long a, long b)
; static ReadOnlySpan<byte> fma_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                            ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                              ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_g64i(long x, long a, long b)
; static ReadOnlySpan<byte> fma_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                            ; IMUL(Imul_r64_rm64) [RDX,RCX]              encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                              ; ADD(Add_r64_rm64) [RDX,R8]                 encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_d64u(ulong x, ulong a, ulong b)
; static ReadOnlySpan<byte> fma_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                            ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                              ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_g64u(ulong x, ulong a, ulong b)
; static ReadOnlySpan<byte> fma_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                            ; IMUL(Imul_r64_rm64) [RDX,RCX]              encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                              ; ADD(Add_r64_rm64) [RDX,R8]                 encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_d32f(float x, float a, float b)
; static ReadOnlySpan<byte> fma_d32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2              ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_g32f(float x, float a, float b)
; static ReadOnlySpan<byte> fma_g32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2              ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_d64f(double x, double a, double b)
; static ReadOnlySpan<byte> fma_d64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2              ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_g64f(double x, double a, double b)
; static ReadOnlySpan<byte> fma_g64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2              ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gcd_32u(uint a, uint b)
; static ReadOnlySpan<byte> gcd_32uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xD1,0x45,0x85,0xC0,0x74,0x14,0x8B,0xC2,0x33,0xD2,0x41,0xF7,0xF0,0x85,0xD2,0x75,0x04,0x41,0x8B,0xC0,0xC3,0x49,0x87,0xD0,0xEB,0xEC,0x44,0x8B,0xC2,0xEB,0xF2};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov edx,ecx                             ; MOV(Mov_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 8b d1
000ah test r8d,r8d                            ; TEST(Test_rm32_r32) [R8D,R8D]              encoding(3 bytes) = 45 85 c0
000dh je short 0023h                          ; JE(Je_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 74 14
000fh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0011h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0013h div r8d                                 ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
0016h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0018h jne short 001eh                         ; JNE(Jne_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 75 04
001ah mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
001eh xchg rdx,r8                             ; XCHG(Xchg_rm64_r64) [R8,RDX]               encoding(3 bytes) = 49 87 d0
0021h jmp short 000fh                         ; JMP(Jmp_rel8_64) [Fh:jmp64]                encoding(2 bytes) = eb ec
0023h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0026h jmp short 001ah                         ; JMP(Jmp_rel8_64) [1Ah:jmp64]               encoding(2 bytes) = eb f2
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int gcd_32i(int a, int b)
; static ReadOnlySpan<byte> gcd_32iBytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x03,0xC8,0x33,0xC1,0x8B,0xCA,0xC1,0xF9,0x1F,0x44,0x8D,0x04,0x0A,0x41,0x33,0xC8,0x85,0xC9,0x74,0x0B,0x99,0xF7,0xF9,0x8B,0xC1,0x8B,0xCA,0x85,0xC9,0x75,0xF5,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
000ah add ecx,eax                             ; ADD(Add_r32_rm32) [ECX,EAX]                encoding(2 bytes) = 03 c8
000ch xor eax,ecx                             ; XOR(Xor_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 33 c1
000eh mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
0010h sar ecx,1Fh                             ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]          encoding(3 bytes) = c1 f9 1f
0013h lea r8d,[rdx+rcx]                       ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,:sr)] encoding(4 bytes) = 44 8d 04 0a
0017h xor ecx,r8d                             ; XOR(Xor_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 33 c8
001ah test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
001ch je short 0029h                          ; JE(Je_rel8_64) [29h:jmp64]                 encoding(2 bytes) = 74 0b
001eh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
001fh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0021h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0023h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
0025h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0027h jne short 001eh                         ; JNE(Jne_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 75 f5
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d8i(sbyte a, sbyte b)
; static ReadOnlySpan<byte> gt_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g8i(sbyte a, sbyte b)
; static ReadOnlySpan<byte> gt_g8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d8u(byte a, byte b)
; static ReadOnlySpan<byte> gt_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g8u(byte a, byte b)
; static ReadOnlySpan<byte> gt_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d16i(short a, short b)
; static ReadOnlySpan<byte> gt_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g16i(short a, short b)
; static ReadOnlySpan<byte> gt_g16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d16u(ushort a, ushort b)
; static ReadOnlySpan<byte> gt_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g16u(ushort a, ushort b)
; static ReadOnlySpan<byte> gt_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d32i(int a, int b)
; static ReadOnlySpan<byte> gt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g32i(int a, int b)
; static ReadOnlySpan<byte> gt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d32u(uint a, uint b)
; static ReadOnlySpan<byte> gt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g32u(uint a, uint b)
; static ReadOnlySpan<byte> gt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d64i(long a, long b)
; static ReadOnlySpan<byte> gt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g64i(long a, long b)
; static ReadOnlySpan<byte> gt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setg al                                 ; SETG(Setg_rm8) [AL]                        encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d64u(ulong a, ulong b)
; static ReadOnlySpan<byte> gt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g64u(ulong a, ulong b)
; static ReadOnlySpan<byte> gt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d32f(float a, float b)
; static ReadOnlySpan<byte> gt_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g32f(float a, float b)
; static ReadOnlySpan<byte> gt_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d64f(double a, double b)
; static ReadOnlySpan<byte> gt_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g64f(double a, double b)
; static ReadOnlySpan<byte> gt_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d8i(sbyte a, sbyte b)
; static ReadOnlySpan<byte> gteq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g8i(sbyte a, sbyte b)
; static ReadOnlySpan<byte> gteq_g8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d8u(byte a, byte b)
; static ReadOnlySpan<byte> gteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g8u(byte a, byte b)
; static ReadOnlySpan<byte> gteq_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d16i(short a, short b)
; static ReadOnlySpan<byte> gteq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g16i(short a, short b)
; static ReadOnlySpan<byte> gteq_g16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d16u(ushort a, ushort b)
; static ReadOnlySpan<byte> gteq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g16u(ushort a, ushort b)
; static ReadOnlySpan<byte> gteq_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d32i(int a, int b)
; static ReadOnlySpan<byte> gteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g32i(int a, int b)
; static ReadOnlySpan<byte> gteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d32u(uint a, uint b)
; static ReadOnlySpan<byte> gteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g32u(uint a, uint b)
; static ReadOnlySpan<byte> gteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d64i(long a, long b)
; static ReadOnlySpan<byte> gteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g64i(long a, long b)
; static ReadOnlySpan<byte> gteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setge al                                ; SETGE(Setge_rm8) [AL]                      encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d64u(ulong a, ulong b)
; static ReadOnlySpan<byte> gteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g64u(ulong a, ulong b)
; static ReadOnlySpan<byte> gteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d32f(float a, float b)
; static ReadOnlySpan<byte> gteq_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g32f(float a, float b)
; static ReadOnlySpan<byte> gteq_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d64f(double a, double b)
; static ReadOnlySpan<byte> gteq_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g64f(double a, double b)
; static ReadOnlySpan<byte> gteq_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void increments_8u(int count, ref byte dst)
; static ReadOnlySpan<byte> increments_8uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x85,0xC9,0x7E,0x13,0x4C,0x63,0xC0,0x4C,0x03,0xC2,0x44,0x0F,0xB6,0xC8,0x45,0x88,0x08,0xFF,0xC0,0x3B,0xC1,0x7C,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0009h jle short 001eh                         ; JLE(Jle_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 7e 13
000bh movsxd r8,eax                           ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]           encoding(3 bytes) = 4c 63 c0
000eh add r8,rdx                              ; ADD(Add_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 03 c2
0011h movzx r9d,al                            ; MOVZX(Movzx_r32_rm8) [R9D,AL]              encoding(4 bytes) = 44 0f b6 c8
0015h mov [r8],r9b                            ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]    encoding(3 bytes) = 45 88 08
0018h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
001ah cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001ch jl short 000bh                          ; JL(Jl_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7c ed
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void increments_32u(int count, ref uint dst)
; static ReadOnlySpan<byte> increments_32uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x85,0xC9,0x7E,0x13,0x4C,0x63,0xC0,0x4E,0x8D,0x04,0x82,0x44,0x8B,0xC8,0x45,0x89,0x08,0xFF,0xC0,0x3B,0xC1,0x7C,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0009h jle short 001eh                         ; JLE(Jle_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 7e 13
000bh movsxd r8,eax                           ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]           encoding(3 bytes) = 4c 63 c0
000eh lea r8,[rdx+r8*4]                       ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,:sr)] encoding(4 bytes) = 4e 8d 04 82
0012h mov r9d,eax                             ; MOV(Mov_r32_rm32) [R9D,EAX]                encoding(3 bytes) = 44 8b c8
0015h mov [r8],r9d                            ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),R9D] encoding(3 bytes) = 45 89 08
0018h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
001ah cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001ch jl short 000bh                          ; JL(Jl_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7c ed
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void decrements_8u(int count, ref byte dst)
; static ReadOnlySpan<byte> decrements_8uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x85,0xC9,0x7E,0x13,0x4C,0x63,0xC0,0x4C,0x03,0xC2,0x44,0x0F,0xB6,0xC8,0x45,0x88,0x08,0xFF,0xC0,0x3B,0xC1,0x7C,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0009h jle short 001eh                         ; JLE(Jle_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 7e 13
000bh movsxd r8,eax                           ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]           encoding(3 bytes) = 4c 63 c0
000eh add r8,rdx                              ; ADD(Add_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 03 c2
0011h movzx r9d,al                            ; MOVZX(Movzx_r32_rm8) [R9D,AL]              encoding(4 bytes) = 44 0f b6 c8
0015h mov [r8],r9b                            ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]    encoding(3 bytes) = 45 88 08
0018h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
001ah cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001ch jl short 000bh                          ; JL(Jl_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7c ed
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void decrements_32u(int count, ref uint dst)
; static ReadOnlySpan<byte> decrements_32uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x85,0xC9,0x7E,0x13,0x4C,0x63,0xC0,0x4E,0x8D,0x04,0x82,0x44,0x8B,0xC8,0x45,0x89,0x08,0xFF,0xC0,0x3B,0xC1,0x7C,0xED,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0009h jle short 001eh                         ; JLE(Jle_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 7e 13
000bh movsxd r8,eax                           ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]           encoding(3 bytes) = 4c 63 c0
000eh lea r8,[rdx+r8*4]                       ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,:sr)] encoding(4 bytes) = 4e 8d 04 82
0012h mov r9d,eax                             ; MOV(Mov_r32_rm32) [R9D,EAX]                encoding(3 bytes) = 44 8b c8
0015h mov [r8],r9d                            ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),R9D] encoding(3 bytes) = 45 89 08
0018h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
001ah cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001ch jl short 000bh                          ; JL(Jl_rel8_64) [Bh:jmp64]                  encoding(2 bytes) = 7c ed
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void steps_8u(byte first, byte step, int count, ref byte dst)
; static ReadOnlySpan<byte> steps_8uBytes => new byte[59]{0x56,0x0F,0x1F,0x40,0x00,0x33,0xC0,0x45,0x85,0xC0,0x7E,0x2D,0x0F,0xB6,0xD2,0x0F,0xB6,0xC9,0x4C,0x63,0xD0,0x4D,0x03,0xD1,0x44,0x0F,0xB6,0xD8,0x8B,0xF2,0x44,0x0F,0xAF,0xDE,0x45,0x0F,0xB6,0xDB,0x8B,0xF1,0x44,0x03,0xDE,0x45,0x0F,0xB6,0xDB,0x45,0x88,0x1A,0xFF,0xC0,0x41,0x3B,0xC0,0x7C,0xD9,0x5E,0xC3};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(4 bytes) = 0f 1f 40 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h test r8d,r8d                            ; TEST(Test_rm32_r32) [R8D,R8D]              encoding(3 bytes) = 45 85 c0
000ah jle short 0039h                         ; JLE(Jle_rel8_64) [39h:jmp64]               encoding(2 bytes) = 7e 2d
000ch movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000fh movzx ecx,cl                            ; MOVZX(Movzx_r32_rm8) [ECX,CL]              encoding(3 bytes) = 0f b6 c9
0012h movsxd r10,eax                          ; MOVSXD(Movsxd_r64_rm32) [R10,EAX]          encoding(3 bytes) = 4c 63 d0
0015h add r10,r9                              ; ADD(Add_r64_rm64) [R10,R9]                 encoding(3 bytes) = 4d 03 d1
0018h movzx r11d,al                           ; MOVZX(Movzx_r32_rm8) [R11D,AL]             encoding(4 bytes) = 44 0f b6 d8
001ch mov esi,edx                             ; MOV(Mov_r32_rm32) [ESI,EDX]                encoding(2 bytes) = 8b f2
001eh imul r11d,esi                           ; IMUL(Imul_r32_rm32) [R11D,ESI]             encoding(4 bytes) = 44 0f af de
0022h movzx r11d,r11b                         ; MOVZX(Movzx_r32_rm8) [R11D,R11L]           encoding(4 bytes) = 45 0f b6 db
0026h mov esi,ecx                             ; MOV(Mov_r32_rm32) [ESI,ECX]                encoding(2 bytes) = 8b f1
0028h add r11d,esi                            ; ADD(Add_r32_rm32) [R11D,ESI]               encoding(3 bytes) = 44 03 de
002bh movzx r11d,r11b                         ; MOVZX(Movzx_r32_rm8) [R11D,R11L]           encoding(4 bytes) = 45 0f b6 db
002fh mov [r10],r11b                          ; MOV(Mov_rm8_r8) [mem(8u,R10:br,:sr),R11L]  encoding(3 bytes) = 45 88 1a
0032h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
0034h cmp eax,r8d                             ; CMP(Cmp_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 3b c0
0037h jl short 0012h                          ; JL(Jl_rel8_64) [12h:jmp64]                 encoding(2 bytes) = 7c d9
0039h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
003ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void steps_32u(uint first, uint step, int count, ref uint dst)
; static ReadOnlySpan<byte> steps_32uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x45,0x85,0xC0,0x7E,0x1B,0x4C,0x63,0xD0,0x4F,0x8D,0x14,0x91,0x44,0x8B,0xD8,0x44,0x0F,0xAF,0xDA,0x44,0x03,0xD9,0x45,0x89,0x1A,0xFF,0xC0,0x41,0x3B,0xC0,0x7C,0xE5,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h test r8d,r8d                            ; TEST(Test_rm32_r32) [R8D,R8D]              encoding(3 bytes) = 45 85 c0
000ah jle short 0027h                         ; JLE(Jle_rel8_64) [27h:jmp64]               encoding(2 bytes) = 7e 1b
000ch movsxd r10,eax                          ; MOVSXD(Movsxd_r64_rm32) [R10,EAX]          encoding(3 bytes) = 4c 63 d0
000fh lea r10,[r9+r10*4]                      ; LEA(Lea_r64_m) [R10,mem(Unknown,R9:br,:sr)] encoding(4 bytes) = 4f 8d 14 91
0013h mov r11d,eax                            ; MOV(Mov_r32_rm32) [R11D,EAX]               encoding(3 bytes) = 44 8b d8
0016h imul r11d,edx                           ; IMUL(Imul_r32_rm32) [R11D,EDX]             encoding(4 bytes) = 44 0f af da
001ah add r11d,ecx                            ; ADD(Add_r32_rm32) [R11D,ECX]               encoding(3 bytes) = 44 03 d9
001dh mov [r10],r11d                          ; MOV(Mov_rm32_r32) [mem(32u,R10:br,:sr),R11D] encoding(3 bytes) = 45 89 1a
0020h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
0022h cmp eax,r8d                             ; CMP(Cmp_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 3b c0
0025h jl short 000ch                          ; JL(Jl_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7c e5
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_d8i(sbyte x)
; static ReadOnlySpan<byte> inc_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_g8i(sbyte x)
; static ReadOnlySpan<byte> inc_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_d8u(byte x)
; static ReadOnlySpan<byte> inc_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_g8u(byte x)
; static ReadOnlySpan<byte> inc_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_d16i(short x)
; static ReadOnlySpan<byte> inc_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_g16i(short x)
; static ReadOnlySpan<byte> inc_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_d16u(ushort x)
; static ReadOnlySpan<byte> inc_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_g16u(ushort x)
; static ReadOnlySpan<byte> inc_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_d32i(int x)
; static ReadOnlySpan<byte> inc_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]                         ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 41 01
0008h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_g32i(int x)
; static ReadOnlySpan<byte> inc_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_op32i(int x)
; static ReadOnlySpan<byte> inc_op32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_d32u(uint x)
; static ReadOnlySpan<byte> inc_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]                         ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 41 01
0008h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_g32u(uint x)
; static ReadOnlySpan<byte> inc_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_op32u(uint x)
; static ReadOnlySpan<byte> inc_op32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_d64i(long x)
; static ReadOnlySpan<byte> inc_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 41 01
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_g64i(long x)
; static ReadOnlySpan<byte> inc_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                                 ; INC(Inc_rm64) [RCX]                        encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_d64u(ulong x)
; static ReadOnlySpan<byte> inc_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 41 01
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_g64u(ulong x)
; static ReadOnlySpan<byte> inc_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                                 ; INC(Inc_rm64) [RCX]                        encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inc_g32f(float x)
; static ReadOnlySpan<byte> inc_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,dword ptr [7FF7C7E5E220h]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 58 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float inc_d32f(float x)
; static ReadOnlySpan<byte> inc_d32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,dword ptr [7FF7C7E5E250h]; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 58 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inc_d64f(double x)
; static ReadOnlySpan<byte> inc_d64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,qword ptr [7FF7C7E5E280h]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 58 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double inc_g64f(double x)
; static ReadOnlySpan<byte> inc_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,qword ptr [7FF7C7E5E2B0h]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 58 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> lt_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> lt_g8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> lt_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> lt_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> lt_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> lt_g16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> lt_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> lt_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> lt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> lt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> lt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> lt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> lt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> lt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setl al                                 ; SETL(Setl_rm8) [AL]                        encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> lt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> lt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> lt_d32fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> lt_g32fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm1,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e c8
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> lt_d64fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool lt_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> lt_g64fBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0009h seta al                                 ; SETA(Seta_rm8) [AL]                        encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0011h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0014h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> lteq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> lteq_g8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> lteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> lteq_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> lteq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> lteq_g16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> lteq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> lteq_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> lteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> lteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> lteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> lteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> lteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float maxval_g32f()
; static ReadOnlySpan<byte> maxval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FF7C7E5EC50h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_n64f()
; static ReadOnlySpan<byte> maxval_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FF7C7E5EC80h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_g64f()
; static ReadOnlySpan<byte> maxval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FF7C7E5ECB0h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_d8i(sbyte x)
; static ReadOnlySpan<byte> dec_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_g8i(sbyte x)
; static ReadOnlySpan<byte> dec_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000bh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_d8u(byte x)
; static ReadOnlySpan<byte> dec_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_g8u(byte x)
; static ReadOnlySpan<byte> dec_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_d16i(short x)
; static ReadOnlySpan<byte> dec_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_g16i(short x)
; static ReadOnlySpan<byte> dec_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000bh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_d16u(ushort x)
; static ReadOnlySpan<byte> dec_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_g16u(ushort x)
; static ReadOnlySpan<byte> dec_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h dec eax                                 ; DEC(Dec_rm32) [EAX]                        encoding(2 bytes) = ff c8
000ah movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_d32i(int x)
; static ReadOnlySpan<byte> dec_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]                         ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 41 ff
0008h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_g32i(int x)
; static ReadOnlySpan<byte> dec_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                                 ; DEC(Dec_rm32) [ECX]                        encoding(2 bytes) = ff c9
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_d32u(uint x)
; static ReadOnlySpan<byte> dec_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]                         ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 41 ff
0008h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_g32u(uint x)
; static ReadOnlySpan<byte> dec_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                                 ; DEC(Dec_rm32) [ECX]                        encoding(2 bytes) = ff c9
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_d64i(long x)
; static ReadOnlySpan<byte> dec_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 41 ff
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_g64i(long x)
; static ReadOnlySpan<byte> dec_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                                 ; DEC(Dec_rm64) [RCX]                        encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_d64u(ulong x)
; static ReadOnlySpan<byte> dec_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 41 ff
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_g64u(ulong x)
; static ReadOnlySpan<byte> dec_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                                 ; DEC(Dec_rm64) [RCX]                        encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float dec_g32f(float x)
; static ReadOnlySpan<byte> dec_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5C,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubss xmm0,xmm0,dword ptr [7FF7C7E5F2F0h]; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 5c 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float dec_d32f(float x)
; static ReadOnlySpan<byte> dec_d32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5C,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubss xmm0,xmm0,dword ptr [7FF7C7E5F320h]; VSUBSS(VEX_Vsubss_xmm_xmm_xmmm32) [XMM0,XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 5c 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double dec_d64f(double x)
; static ReadOnlySpan<byte> dec_d64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5C,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubsd xmm0,xmm0,qword ptr [7FF7C7E5F350h]; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 5c 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double dec_g64f(double x)
; static ReadOnlySpan<byte> dec_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5C,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vsubsd xmm0,xmm0,qword ptr [7FF7C7E5F380h]; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 5c 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> div_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                            ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> div_g8iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x48,0x0F,0xBE,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                            ; MOVSX(Movsx_r64_rm8) [RCX,DL]              encoding(4 bytes) = 48 0f be ca
000dh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0011h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0012h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0014h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte div_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> div_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte div_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> div_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x0F,0xB6,0xC0,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000fh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short div_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> div_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                            ; MOVSX(Movsx_r64_rm16) [RCX,DX]             encoding(4 bytes) = 48 0f bf ca
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short div_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> div_g16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x48,0x0F,0xBF,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                            ; MOVSX(Movsx_r64_rm16) [RCX,DX]             encoding(4 bytes) = 48 0f bf ca
000dh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0011h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0012h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0014h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> div_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                            ; MOVZX(Movzx_r32_rm16) [ECX,DX]             encoding(3 bytes) = 0f b7 ca
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> div_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x0F,0xB7,0xC0,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                            ; MOVZX(Movzx_r32_rm16) [ECX,DX]             encoding(3 bytes) = 0f b7 ca
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000fh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0011h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> div_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000bh idiv r8d                                ; IDIV(Idiv_rm32) [R8D]                      encoding(3 bytes) = 41 f7 f8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> div_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000bh idiv r8d                                ; IDIV(Idiv_rm32) [R8D]                      encoding(3 bytes) = 41 f7 f8
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> div_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ch div r8d                                 ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> div_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000ah xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ch div r8d                                 ; DIV(Div_rm32) [R8D]                        encoding(3 bytes) = 41 f7 f0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> div_d64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh cqo                                     ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000dh idiv r8                                 ; IDIV(Idiv_rm64) [R8]                       encoding(3 bytes) = 49 f7 f8
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> div_g64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh cqo                                     ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000dh idiv r8                                 ; IDIV(Idiv_rm64) [R8]                       encoding(3 bytes) = 49 f7 f8
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> div_d64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div r8                                  ; DIV(Div_rm64) [R8]                         encoding(3 bytes) = 49 f7 f0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> div_g64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                              ; MOV(Mov_r64_rm64) [R8,RDX]                 encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000dh div r8                                  ; DIV(Div_rm64) [R8]                         encoding(3 bytes) = 49 f7 f0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> div_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1                   ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> div_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1                   ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> div_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1                   ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> div_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1                   ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> divides_d8iBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x48,0x0F,0xBE,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                            ; MOVSX(Movsx_r64_rm8) [RAX,DL]              encoding(4 bytes) = 48 0f be c2
0009h movsx rcx,cl                            ; MOVSX(Movsx_r64_rm8) [RCX,CL]              encoding(4 bytes) = 48 0f be c9
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0012h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0020h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> divides_g8iBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,al                            ; MOVSX(Movsx_r64_rm8) [RCX,AL]              encoding(4 bytes) = 48 0f be c8
0011h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0013h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0014h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0016h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0018h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0020h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0023h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0026h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> divides_d8uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx ecx,cl                            ; MOVZX(Movzx_r32_rm8) [ECX,CL]              encoding(3 bytes) = 0f b6 c9
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0018h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> divides_g8uBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,al                            ; MOVZX(Movzx_r32_rm8) [ECX,AL]              encoding(3 bytes) = 0f b6 c8
000eh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0010h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0011h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0013h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0015h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0020h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0023h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> divides_d16iBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x48,0x0F,0xBF,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                            ; MOVSX(Movsx_r64_rm16) [RAX,DX]             encoding(4 bytes) = 48 0f bf c2
0009h movsx rcx,cx                            ; MOVSX(Movsx_r64_rm16) [RCX,CX]             encoding(4 bytes) = 48 0f bf c9
000dh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000eh idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0010h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0012h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0020h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> divides_g16iBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,ax                            ; MOVSX(Movsx_r64_rm16) [RCX,AX]             encoding(4 bytes) = 48 0f bf c8
0011h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0013h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0014h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0016h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0018h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0020h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0023h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0026h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> divides_d16uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h movzx ecx,cx                            ; MOVZX(Movzx_r32_rm16) [ECX,CX]             encoding(3 bytes) = 0f b7 c9
000bh cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
000ch idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000eh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0018h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> divides_g16uBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,ax                            ; MOVZX(Movzx_r32_rm16) [ECX,AX]             encoding(3 bytes) = 0f b7 c8
000eh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0010h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0011h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
0013h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0015h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0020h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0023h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> divides_d32iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0008h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000ah test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000ch sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0014h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0017h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> divides_g32iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h cdq                                     ; CDQ(Cdq)                                   encoding(1 byte ) = 99
0008h idiv ecx                                ; IDIV(Idiv_rm32) [ECX]                      encoding(2 bytes) = f7 f9
000ah test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000ch sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0014h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0017h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> divides_d32uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0009h div ecx                                 ; DIV(Div_rm32) [ECX]                        encoding(2 bytes) = f7 f1
000bh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000dh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> divides_g32uBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0007h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0009h div ecx                                 ; DIV(Div_rm32) [ECX]                        encoding(2 bytes) = f7 f1
000bh test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
000dh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0015h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> divides_d64iBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h cqo                                     ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000ah idiv rcx                                ; IDIV(Idiv_rm64) [RCX]                      encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                            ; TEST(Test_rm64_r64) [RDX,RDX]              encoding(3 bytes) = 48 85 d2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0018h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> divides_g64iBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h cqo                                     ; CQO(Cqo)                                   encoding(2 bytes) = 48 99
000ah idiv rcx                                ; IDIV(Idiv_rm64) [RCX]                      encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                            ; TEST(Test_rm64_r64) [RDX,RDX]              encoding(3 bytes) = 48 85 d2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0018h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> divides_d64uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ah div rcx                                 ; DIV(Div_rm64) [RCX]                        encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                            ; TEST(Test_rm64_r64) [RDX,RDX]              encoding(3 bytes) = 48 85 d2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0018h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> divides_g64uBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
000ah div rcx                                 ; DIV(Div_rm64) [RCX]                        encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                            ; TEST(Test_rm64_r64) [RDX,RDX]              encoding(3 bytes) = 48 85 d2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0018h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> divides_d32fBytes => new byte[56]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0xF8,0x17,0x53,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FF827391660h                      ; CALL(Call_rel32_64) [5F531810h:jmp64]      encoding(5 bytes) = e8 f8 17 53 5f
0018h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                          ; JP(Jp_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 7a 03
0025h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
002dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> divides_g32fBytes => new byte[56]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x98,0x17,0x53,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FF827391660h                      ; CALL(Call_rel32_64) [5F5317B0h:jmp64]      encoding(5 bytes) = e8 98 17 53 5f
0018h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                          ; JP(Jp_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 7a 03
0025h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
002dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> divides_d64fBytes => new byte[56]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0xA8,0x16,0x53,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FF8273915D0h                      ; CALL(Call_rel32_64) [5F5316C0h:jmp64]      encoding(5 bytes) = e8 a8 16 53 5f
0018h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                          ; JP(Jp_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 7a 03
0025h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
002dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> divides_g64fBytes => new byte[56]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x48,0x16,0x53,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FF8273915D0h                      ; CALL(Call_rel32_64) [5F531660h:jmp64]      encoding(5 bytes) = e8 48 16 53 5f
0018h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                          ; JP(Jp_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 7a 03
0025h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
002dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> eq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> eq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> eq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> eq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> eq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> eq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> eq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> eq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> eq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> eq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> eq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> eq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> eq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> eq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> eq_d32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> eq_g32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> eq_d64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> eq_g64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setnp al                                ; SETNP(Setnp_rm8) [AL]                      encoding(3 bytes) = 0f 9b c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> neq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> neq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> neq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> neq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> neq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> neq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0013h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> neq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> neq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> neq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> neq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> neq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> neq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> neq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> neq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> neq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> neq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> neq_d32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> neq_g32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> neq_d64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> neq_g64fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x9A,0xC0,0x7A,0x03,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setp al                                 ; SETP(Setp_rm8) [AL]                        encoding(3 bytes) = 0f 9a c0
000ch jp short 0011h                          ; JP(Jp_rel8_64) [11h:jmp64]                 encoding(2 bytes) = 7a 03
000eh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d8i(sbyte x)
; static ReadOnlySpan<byte> even_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g8i(sbyte x)
; static ReadOnlySpan<byte> even_g8iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0013h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d8u(byte x)
; static ReadOnlySpan<byte> even_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g8u(byte x)
; static ReadOnlySpan<byte> even_g8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0012h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d16i(short x)
; static ReadOnlySpan<byte> even_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g16i(short x)
; static ReadOnlySpan<byte> even_g16iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0013h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d16u(ushort x)
; static ReadOnlySpan<byte> even_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g16u(ushort x)
; static ReadOnlySpan<byte> even_g16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0012h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d32i(int x)
; static ReadOnlySpan<byte> even_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g32i(int x)
; static ReadOnlySpan<byte> even_g32iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0010h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d32u(uint x)
; static ReadOnlySpan<byte> even_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g32u(uint x)
; static ReadOnlySpan<byte> even_g32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0010h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d64i(long x)
; static ReadOnlySpan<byte> even_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
0009h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g64i(long x)
; static ReadOnlySpan<byte> even_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0010h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d64u(ulong x)
; static ReadOnlySpan<byte> even_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
0009h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
000ch movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g64u(ulong x)
; static ReadOnlySpan<byte> even_g64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0010h and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d8i(sbyte x)
; static ReadOnlySpan<byte> odd_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g8i(sbyte x)
; static ReadOnlySpan<byte> odd_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d8u(byte x)
; static ReadOnlySpan<byte> odd_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g8u(byte x)
; static ReadOnlySpan<byte> odd_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d16i(short x)
; static ReadOnlySpan<byte> odd_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g16i(short x)
; static ReadOnlySpan<byte> odd_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000bh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d16u(ushort x)
; static ReadOnlySpan<byte> odd_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g16u(ushort x)
; static ReadOnlySpan<byte> odd_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000ah setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d32i(int x)
; static ReadOnlySpan<byte> odd_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g32i(int x)
; static ReadOnlySpan<byte> odd_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d32u(uint x)
; static ReadOnlySpan<byte> odd_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                               ; TEST(Test_rm8_imm8) [CL,1h:imm8]           encoding(3 bytes) = f6 c1 01
0008h setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs_d8i(sbyte x)
; static ReadOnlySpan<byte> abs_d8iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xC1,0xFA,0x07,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh sar edx,7                               ; SAR(Sar_rm32_imm8) [EDX,7h:imm8]           encoding(3 bytes) = c1 fa 07
000eh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0010h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0012h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs_g8i(sbyte x)
; static ReadOnlySpan<byte> abs_g8iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xC1,0xFA,0x07,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh sar edx,7                               ; SAR(Sar_rm32_imm8) [EDX,7h:imm8]           encoding(3 bytes) = c1 fa 07
000eh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0010h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0012h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short abs_d16i(short x)
; static ReadOnlySpan<byte> abs_d16iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xC1,0xFA,0x0F,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh sar edx,0Fh                             ; SAR(Sar_rm32_imm8) [EDX,fh:imm8]           encoding(3 bytes) = c1 fa 0f
000eh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0010h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0012h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short abs_g16i(short x)
; static ReadOnlySpan<byte> abs_g16iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xC1,0xFA,0x0F,0x03,0xC2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000bh sar edx,0Fh                             ; SAR(Sar_rm32_imm8) [EDX,fh:imm8]           encoding(3 bytes) = c1 fa 0f
000eh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0010h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0012h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs_d32i(int x)
; static ReadOnlySpan<byte> abs_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]                       ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs_g32i(int x)
; static ReadOnlySpan<byte> abs_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                             ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]          encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]                       ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_d64i(long x)
; static ReadOnlySpan<byte> abs_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                             ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]          encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]                       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                             ; XOR(Xor_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 33 c2
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_g64i(long x)
; static ReadOnlySpan<byte> abs_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                             ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]          encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]                       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                             ; XOR(Xor_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 33 c2
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float abs_g32f(float x)
; static ReadOnlySpan<byte> abs_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FF7C7E61418h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1                   ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float abs_d32f(float x)
; static ReadOnlySpan<byte> abs_d32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FF7C7E61448h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1                   ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double abs_d64f(double x)
; static ReadOnlySpan<byte> abs_d64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FF7C7E61478h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1                   ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double abs_g64f(double x)
; static ReadOnlySpan<byte> abs_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x54,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FF7C7E614A8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vandps xmm0,xmm0,xmm1                   ; VANDPS(VEX_Vandps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 54 c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> add_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> add_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> add_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> add_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> add_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> add_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> add_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> add_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> add_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]                       ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 04 11
0008h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> add_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                             ; ADD(Add_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 03 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> add_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]                       ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 04 11
0008h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> add_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                             ; ADD(Add_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 03 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> add_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 04 11
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> add_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> add_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 04 11
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> add_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float add_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> add_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,xmm1                   ; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 58 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float add_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> add_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x58,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddss xmm0,xmm0,xmm1                   ; VADDSS(VEX_Vaddss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fa 58 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double add_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> add_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,xmm1                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 58 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double add_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> add_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x58,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vaddsd xmm0,xmm0,xmm1                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 fb 58 c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_d8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> and_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_g8i(sbyte lhs, sbyte rhs)
; static ReadOnlySpan<byte> and_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000fh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_d8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> and_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_g8u(byte lhs, byte rhs)
; static ReadOnlySpan<byte> and_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_d16i(short lhs, short rhs)
; static ReadOnlySpan<byte> and_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_g16i(short lhs, short rhs)
; static ReadOnlySpan<byte> and_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000fh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_d16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> and_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_g16u(ushort lhs, ushort rhs)
; static ReadOnlySpan<byte> and_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_d32i(int lhs, int rhs)
; static ReadOnlySpan<byte> and_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_g32i(int lhs, int rhs)
; static ReadOnlySpan<byte> and_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_d32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> and_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_g32u(uint lhs, uint rhs)
; static ReadOnlySpan<byte> and_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_d64i(long lhs, long rhs)
; static ReadOnlySpan<byte> and_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                             ; AND(And_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 23 c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_g64i(long lhs, long rhs)
; static ReadOnlySpan<byte> and_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                             ; AND(And_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_d64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> and_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                             ; AND(And_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 23 c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_g64u(ulong lhs, ulong rhs)
; static ReadOnlySpan<byte> and_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                             ; AND(And_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_d32f(float lhs, float rhs)
; static ReadOnlySpan<byte> and_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]                       ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]         ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_g32f(float lhs, float rhs)
; static ReadOnlySpan<byte> and_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1         ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]                       ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]         ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and_d64f(double lhs, double rhs)
; static ReadOnlySpan<byte> and_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]                         ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]             ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and_g64f(double lhs, double rhs)
; static ReadOnlySpan<byte> and_g64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]                         ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]             ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
002ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d8i(sbyte x, sbyte a, sbyte b)
; static ReadOnlySpan<byte> between_d8iBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x12,0x48,0x0F,0xBE,0xC1,0x49,0x0F,0xBE,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh jl short 0023h                          ; JL(Jl_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 7c 12
0011h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0015h movsx rdx,r8b                           ; MOVSX(Movsx_r64_rm8) [RDX,R8L]             encoding(4 bytes) = 49 0f be d0
0019h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
001bh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h                         ; JMP(Jmp_rel8_64) [25h:jmp64]               encoding(2 bytes) = eb 02
0023h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0025h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g8i(sbyte x, sbyte a, sbyte b)
; static ReadOnlySpan<byte> between_g8iBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x49,0x0F,0xBE,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                            ; MOVSX(Movsx_r64_rm8) [RAX,CL]              encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,r8b                           ; MOVSX(Movsx_r64_rm8) [RCX,R8L]             encoding(4 bytes) = 49 0f be c8
0011h movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0015h movsx rdx,dl                            ; MOVSX(Movsx_r64_rm8) [RDX,DL]              encoding(4 bytes) = 48 0f be d2
0019h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
001bh jl short 0027h                          ; JL(Jl_rel8_64) [27h:jmp64]                 encoding(2 bytes) = 7c 0a
001dh cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001fh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0022h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0025h jmp short 0029h                         ; JMP(Jmp_rel8_64) [29h:jmp64]               encoding(2 bytes) = eb 02
0027h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0029h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d8u(byte x, byte a, byte b)
; static ReadOnlySpan<byte> between_d8uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x11,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh jl short 0020h                          ; JL(Jl_rel8_64) [20h:jmp64]                 encoding(2 bytes) = 7c 11
000fh movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0012h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
0016h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0018h setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh jmp short 0022h                         ; JMP(Jmp_rel8_64) [22h:jmp64]               encoding(2 bytes) = eb 02
0020h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0022h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g8u(byte x, byte a, byte b)
; static ReadOnlySpan<byte> between_g8uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,r8b                           ; MOVZX(Movzx_r32_rm8) [ECX,R8L]             encoding(4 bytes) = 41 0f b6 c8
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0015h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0017h jl short 0023h                          ; JL(Jl_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 7c 0a
0019h cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001bh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h                         ; JMP(Jmp_rel8_64) [25h:jmp64]               encoding(2 bytes) = eb 02
0023h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0025h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d16i(short x, short a, short b)
; static ReadOnlySpan<byte> between_d16iBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x12,0x48,0x0F,0xBF,0xC1,0x49,0x0F,0xBF,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000fh jl short 0023h                          ; JL(Jl_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 7c 12
0011h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0015h movsx rdx,r8w                           ; MOVSX(Movsx_r64_rm16) [RDX,R8W]            encoding(4 bytes) = 49 0f bf d0
0019h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
001bh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h                         ; JMP(Jmp_rel8_64) [25h:jmp64]               encoding(2 bytes) = eb 02
0023h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0025h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g16i(short x, short a, short b)
; static ReadOnlySpan<byte> between_g16iBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x49,0x0F,0xBF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                            ; MOVSX(Movsx_r64_rm16) [RAX,CX]             encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,r8w                           ; MOVSX(Movsx_r64_rm16) [RCX,R8W]            encoding(4 bytes) = 49 0f bf c8
0011h movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0015h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
0019h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
001bh jl short 0027h                          ; JL(Jl_rel8_64) [27h:jmp64]                 encoding(2 bytes) = 7c 0a
001dh cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001fh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0022h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0025h jmp short 0029h                         ; JMP(Jmp_rel8_64) [29h:jmp64]               encoding(2 bytes) = eb 02
0027h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0029h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
002ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d16u(ushort x, ushort a, ushort b)
; static ReadOnlySpan<byte> between_d16uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x11,0x0F,0xB7,0xC1,0x41,0x0F,0xB7,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh jl short 0020h                          ; JL(Jl_rel8_64) [20h:jmp64]                 encoding(2 bytes) = 7c 11
000fh movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0012h movzx edx,r8w                           ; MOVZX(Movzx_r32_rm16) [EDX,R8W]            encoding(4 bytes) = 41 0f b7 d0
0016h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0018h setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
001bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001eh jmp short 0022h                         ; JMP(Jmp_rel8_64) [22h:jmp64]               encoding(2 bytes) = eb 02
0020h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0022h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g16u(ushort x, ushort a, ushort b)
; static ReadOnlySpan<byte> between_g16uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x41,0x0F,0xB7,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,r8w                           ; MOVZX(Movzx_r32_rm16) [ECX,R8W]            encoding(4 bytes) = 41 0f b7 c8
000fh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0012h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
0015h cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0017h jl short 0023h                          ; JL(Jl_rel8_64) [23h:jmp64]                 encoding(2 bytes) = 7c 0a
0019h cmp eax,ecx                             ; CMP(Cmp_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 3b c1
001bh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h                         ; JMP(Jmp_rel8_64) [25h:jmp64]               encoding(2 bytes) = eb 02
0023h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0025h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0028h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d32i(int x, int a, int b)
; static ReadOnlySpan<byte> between_d32iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0B,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jl short 0014h                          ; JL(Jl_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 7c 0b
0009h cmp ecx,r8d                             ; CMP(Cmp_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 3b c8
000ch setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g32i(int x, int a, int b)
; static ReadOnlySpan<byte> between_g32iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0B,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jl short 0014h                          ; JL(Jl_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 7c 0b
0009h cmp ecx,r8d                             ; CMP(Cmp_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 3b c8
000ch setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d32u(uint x, uint a, uint b)
; static ReadOnlySpan<byte> between_d32uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0B,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jb short 0014h                          ; JB(Jb_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 72 0b
0009h cmp ecx,r8d                             ; CMP(Cmp_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 3b c8
000ch setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g32u(uint x, uint a, uint b)
; static ReadOnlySpan<byte> between_g32uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0B,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0007h jb short 0014h                          ; JB(Jb_rel8_64) [14h:jmp64]                 encoding(2 bytes) = 72 0b
0009h cmp ecx,r8d                             ; CMP(Cmp_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 3b c8
000ch setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h                         ; JMP(Jmp_rel8_64) [16h:jmp64]               encoding(2 bytes) = eb 02
0014h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0016h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d64i(long x, long a, long b)
; static ReadOnlySpan<byte> between_d64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0B,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jl short 0015h                          ; JL(Jl_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7c 0b
000ah cmp rcx,r8                              ; CMP(Cmp_r64_rm64) [RCX,R8]                 encoding(3 bytes) = 49 3b c8
000dh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h                         ; JMP(Jmp_rel8_64) [17h:jmp64]               encoding(2 bytes) = eb 02
0015h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0017h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g64i(long x, long a, long b)
; static ReadOnlySpan<byte> between_g64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0B,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jl short 0015h                          ; JL(Jl_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7c 0b
000ah cmp rcx,r8                              ; CMP(Cmp_r64_rm64) [RCX,R8]                 encoding(3 bytes) = 49 3b c8
000dh setle al                                ; SETLE(Setle_rm8) [AL]                      encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h                         ; JMP(Jmp_rel8_64) [17h:jmp64]               encoding(2 bytes) = eb 02
0015h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0017h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d64u(ulong x, ulong a, ulong b)
; static ReadOnlySpan<byte> between_d64uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0B,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jb short 0015h                          ; JB(Jb_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 72 0b
000ah cmp rcx,r8                              ; CMP(Cmp_r64_rm64) [RCX,R8]                 encoding(3 bytes) = 49 3b c8
000dh setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h                         ; JMP(Jmp_rel8_64) [17h:jmp64]               encoding(2 bytes) = eb 02
0015h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0017h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g64u(ulong x, ulong a, ulong b)
; static ReadOnlySpan<byte> between_g64uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0B,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                             ; CMP(Cmp_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 3b ca
0008h jb short 0015h                          ; JB(Jb_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 72 0b
000ah cmp rcx,r8                              ; CMP(Cmp_r64_rm64) [RCX,R8]                 encoding(3 bytes) = 49 3b c8
000dh setbe al                                ; SETBE(Setbe_rm8) [AL]                      encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h                         ; JMP(Jmp_rel8_64) [17h:jmp64]               encoding(2 bytes) = eb 02
0015h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0017h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d32f(float x, float a, float b)
; static ReadOnlySpan<byte> between_d32fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x72,0x0C,0xC5,0xF8,0x2E,0xD0,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h jb short 0017h                          ; JB(Jb_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 72 0c
000bh vucomiss xmm2,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e d0
000fh setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0019h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g32f(float x, float a, float b)
; static ReadOnlySpan<byte> between_g32fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x72,0x0C,0xC5,0xF8,0x2E,0xD0,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h jb short 0017h                          ; JB(Jb_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 72 0c
000bh vucomiss xmm2,xmm0                      ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 2e d0
000fh setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0019h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d64f(double x, double a, double b)
; static ReadOnlySpan<byte> between_d64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x72,0x0C,0xC5,0xF9,0x2E,0xD0,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h jb short 0017h                          ; JB(Jb_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 72 0c
000bh vucomisd xmm2,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e d0
000fh setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0019h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g64f(double x, double a, double b)
; static ReadOnlySpan<byte> between_g64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x72,0x0C,0xC5,0xF9,0x2E,0xD0,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h jb short 0017h                          ; JB(Jb_rel8_64) [17h:jmp64]                 encoding(2 bytes) = 72 0c
000bh vucomisd xmm2,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e d0
000fh setae al                                ; SETAE(Setae_rm8) [AL]                      encoding(3 bytes) = 0f 93 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h jmp short 0019h                         ; JMP(Jmp_rel8_64) [19h:jmp64]               encoding(2 bytes) = eb 02
0017h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0019h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avgz_64u_g(ReadOnlySpan<ulong> src)
; static ReadOnlySpan<byte> avgz_64u_gBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x8B,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x83,0xFA,0x01,0x7E,0x1E,0x4D,0x63,0xC8,0x4E,0x8B,0x0C,0xC8,0x4C,0x8B,0xD1,0x4D,0x23,0xD1,0x49,0x33,0xC9,0x48,0xD1,0xE9,0x49,0x03,0xCA,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE2,0x48,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]                         ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)] encoding(3 bytes) = 8b 51 08
000bh mov rcx,[rax]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)] encoding(3 bytes) = 48 8b 08
000eh mov r8d,1                               ; MOV(Mov_r32_imm32) [R8D,1h:imm32]          encoding(6 bytes) = 41 b8 01 00 00 00
0014h cmp edx,1                               ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]          encoding(3 bytes) = 83 fa 01
0017h jle short 0037h                         ; JLE(Jle_rel8_64) [37h:jmp64]               encoding(2 bytes) = 7e 1e
0019h movsxd r9,r8d                           ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]           encoding(3 bytes) = 4d 63 c8
001ch mov r9,[rax+r9*8]                       ; MOV(Mov_r64_rm64) [R9,mem(64u,RAX:br,:sr)] encoding(4 bytes) = 4e 8b 0c c8
0020h mov r10,rcx                             ; MOV(Mov_r64_rm64) [R10,RCX]                encoding(3 bytes) = 4c 8b d1
0023h and r10,r9                              ; AND(And_r64_rm64) [R10,R9]                 encoding(3 bytes) = 4d 23 d1
0026h xor rcx,r9                              ; XOR(Xor_r64_rm64) [RCX,R9]                 encoding(3 bytes) = 49 33 c9
0029h shr rcx,1                               ; SHR(Shr_rm64_1) [RCX,1h:imm8]              encoding(3 bytes) = 48 d1 e9
002ch add rcx,r10                             ; ADD(Add_r64_rm64) [RCX,R10]                encoding(3 bytes) = 49 03 ca
002fh inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
0032h cmp r8d,edx                             ; CMP(Cmp_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 3b c2
0035h jl short 0019h                          ; JL(Jl_rel8_64) [19h:jmp64]                 encoding(2 bytes) = 7c e2
0037h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
003ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Collector collector_create()
; static ReadOnlySpan<byte> collector_createBytes => new byte[82]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0xB9,0xF8,0xBC,0x08,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x7A,0x46,0x40,0x5F,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x11,0x40,0x30,0xC5,0xFB,0x11,0x40,0x28,0xC5,0xFB,0x11,0x40,0x20,0xC5,0xFB,0x11,0x40,0x18,0x33,0xD2,0x89,0x50,0x38,0xC5,0xFB,0x10,0x05,0x25,0x00,0x00,0x00,0xC5,0xFB,0x11,0x40,0x08,0xC5,0xFB,0x10,0x05,0x20,0x00,0x00,0x00,0xC5,0xFB,0x11,0x40,0x10,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rcx,7FF7C808BCF8h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c808bcf8h:imm64] encoding(10 bytes) = 48 b9 f8 bc 08 c8 f7 7f 00 00
0011h call 7FF827266CB0h                      ; CALL(Call_rel32_64) [5F404690h:jmp64]      encoding(5 bytes) = e8 7a 46 40 5f
0016h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
001ah vmovsd qword ptr [rax+30h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 30
001fh vmovsd qword ptr [rax+28h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 28
0024h vmovsd qword ptr [rax+20h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 20
0029h vmovsd qword ptr [rax+18h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 18
002eh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0030h mov [rax+38h],edx                       ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX] encoding(3 bytes) = 89 50 38
0033h vmovsd xmm0,qword ptr [7FF7C7E62680h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 25 00 00 00
003bh vmovsd qword ptr [rax+8],xmm0           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 08
0040h vmovsd xmm0,qword ptr [7FF7C7E62688h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 20 00 00 00
0048h vmovsd qword ptr [rax+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 10
004dh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0051h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void collector_collect_seq(Collector collector)
; static ReadOnlySpan<byte> collector_collect_seqBytes => new byte[152]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0x01,0x00,0x00,0x00,0x8B,0x11,0x8B,0xD0,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x2A,0xC2,0xFF,0x41,0x38,0xC5,0xFB,0x10,0x49,0x18,0xC5,0xF8,0x28,0xD0,0xC5,0xEB,0x5C,0xD1,0xC5,0xE0,0x57,0xDB,0xC5,0xE3,0x2A,0x59,0x38,0xC5,0xF8,0x28,0xE2,0xC5,0xDB,0x5E,0xE3,0xC5,0xF3,0x58,0xCC,0xC5,0xFB,0x11,0x49,0x20,0xC5,0xFB,0x10,0x49,0x28,0xC5,0xFB,0x10,0x59,0x20,0xC5,0xF8,0x28,0xE0,0xC5,0xDB,0x5C,0xE3,0xC5,0xEB,0x59,0xD4,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x59,0x18,0xC5,0xFB,0x10,0x49,0x30,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xF9,0x2E,0x41,0x10,0x76,0x05,0xC5,0xFB,0x11,0x41,0x10,0xC5,0xFB,0x10,0x49,0x08,0xC5,0xF9,0x2E,0xC8,0x76,0x05,0xC5,0xFB,0x11,0x41,0x08,0xFF,0xC0,0x3D,0xFF,0x00,0x00,0x00,0x0F,0x8C,0x73,0xFF,0xFF,0xFF,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah mov edx,[rcx]                           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)] encoding(2 bytes) = 8b 11
000ch mov edx,eax                             ; MOV(Mov_r32_rm32) [EDX,EAX]                encoding(2 bytes) = 8b d0
000eh vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0012h vcvtsi2sd xmm0,xmm0,edx                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fb 2a c2
0016h inc dword ptr [rcx+38h]                 ; INC(Inc_rm32) [mem(32u,RCX:br,:sr)]        encoding(3 bytes) = ff 41 38
0019h vmovsd xmm1,qword ptr [rcx+18h]         ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 18
001eh vmovaps xmm2,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d0
0022h vsubsd xmm2,xmm2,xmm1                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM1] encoding(VEX, 4 bytes) = c5 eb 5c d1
0026h vxorps xmm3,xmm3,xmm3                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3] encoding(VEX, 4 bytes) = c5 e0 57 db
002ah vcvtsi2sd xmm3,xmm3,dword ptr [rcx+38h] ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM3,XMM3,mem(32i,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 e3 2a 59 38
002fh vmovaps xmm4,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 e2
0033h vdivsd xmm4,xmm4,xmm3                   ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3] encoding(VEX, 4 bytes) = c5 db 5e e3
0037h vaddsd xmm1,xmm1,xmm4                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM4] encoding(VEX, 4 bytes) = c5 f3 58 cc
003bh vmovsd qword ptr [rcx+20h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 20
0040h vmovsd xmm1,qword ptr [rcx+28h]         ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 28
0045h vmovsd xmm3,qword ptr [rcx+20h]         ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 59 20
004ah vmovaps xmm4,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 e0
004eh vsubsd xmm4,xmm4,xmm3                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3] encoding(VEX, 4 bytes) = c5 db 5c e3
0052h vmulsd xmm2,xmm2,xmm4                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM4] encoding(VEX, 4 bytes) = c5 eb 59 d4
0056h vaddsd xmm1,xmm1,xmm2                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f3 58 ca
005ah vmovsd qword ptr [rcx+30h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
005fh vmovsd qword ptr [rcx+18h],xmm3         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM3] encoding(VEX, 5 bytes) = c5 fb 11 59 18
0064h vmovsd xmm1,qword ptr [rcx+30h]         ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 30
0069h vmovsd qword ptr [rcx+28h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
006eh vucomisd xmm0,qword ptr [rcx+10h]       ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 41 10
0073h jbe short 007ah                         ; JBE(Jbe_rel8_64) [7Ah:jmp64]               encoding(2 bytes) = 76 05
0075h vmovsd qword ptr [rcx+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 10
007ah vmovsd xmm1,qword ptr [rcx+8]           ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 08
007fh vucomisd xmm1,xmm0                      ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f9 2e c8
0083h jbe short 008ah                         ; JBE(Jbe_rel8_64) [8Ah:jmp64]               encoding(2 bytes) = 76 05
0085h vmovsd qword ptr [rcx+8],xmm0           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 08
008ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
008ch cmp eax,0FFh                            ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]         encoding(5 bytes) = 3d ff 00 00 00
0091h jl near ptr 000ah                       ; JL(Jl_rel32_64) [Ah:jmp64]                 encoding(6 bytes) = 0f 8c 73 ff ff ff
0097h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void collector_collect_op(Collector collector)
; static ReadOnlySpan<byte> collector_collect_opBytes => new byte[420]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0x01,0x8B,0x41,0x38,0xFF,0xC0,0x89,0x41,0x38,0xC5,0xFB,0x10,0x41,0x18,0xC5,0xFB,0x10,0x0D,0xD4,0x01,0x00,0x00,0xC5,0xF3,0x5C,0xC8,0xC5,0xE8,0x57,0xD2,0xC5,0xEB,0x2A,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE3,0x5E,0xDA,0xC5,0xFB,0x58,0xC3,0xC5,0xFB,0x11,0x41,0x20,0xC5,0xFB,0x10,0x51,0x28,0xC5,0xFB,0x10,0x1D,0xB2,0x01,0x00,0x00,0xC5,0xE3,0x5C,0xD8,0xC5,0xF3,0x59,0xCB,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x41,0x18,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xFB,0x10,0x15,0x97,0x01,0x00,0x00,0xC5,0xF9,0x2E,0x51,0x10,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x90,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x10,0xC5,0xFB,0x10,0x51,0x08,0xC5,0xF9,0x2E,0x15,0x86,0x01,0x00,0x00,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x84,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x08,0xFF,0xC0,0x89,0x41,0x38,0xC5,0xFB,0x10,0x15,0x7A,0x01,0x00,0x00,0xC5,0xEB,0x5C,0xD0,0xC5,0xE0,0x57,0xDB,0xC5,0xE3,0x2A,0xD8,0xC5,0xF8,0x28,0xE2,0xC5,0xDB,0x5E,0xE3,0xC5,0xFB,0x58,0xC4,0xC5,0xFB,0x11,0x41,0x20,0xC5,0xFB,0x10,0x1D,0x5D,0x01,0x00,0x00,0xC5,0xE3,0x5C,0xD8,0xC5,0xEB,0x59,0xD3,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x41,0x18,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xFB,0x10,0x15,0x42,0x01,0x00,0x00,0xC5,0xF9,0x2E,0x51,0x10,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x3B,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x10,0xC5,0xFB,0x10,0x51,0x08,0xC5,0xF9,0x2E,0x15,0x31,0x01,0x00,0x00,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x2F,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x08,0xFF,0xC0,0x89,0x41,0x38,0xC5,0xFB,0x10,0x15,0x25,0x01,0x00,0x00,0xC5,0xEB,0x5C,0xD0,0xC5,0xE0,0x57,0xDB,0xC5,0xE3,0x2A,0xD8,0xC5,0xF8,0x28,0xE2,0xC5,0xDB,0x5E,0xE3,0xC5,0xFB,0x58,0xC4,0xC5,0xFB,0x11,0x41,0x20,0xC5,0xFB,0x10,0x1D,0x08,0x01,0x00,0x00,0xC5,0xE3,0x5C,0xD8,0xC5,0xEB,0x59,0xD3,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x41,0x18,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xFB,0x10,0x05,0xED,0x00,0x00,0x00,0xC5,0xF9,0x2E,0x41,0x10,0x76,0x0D,0xC5,0xFB,0x10,0x05,0xE6,0x00,0x00,0x00,0xC5,0xFB,0x11,0x41,0x10,0xC5,0xFB,0x10,0x41,0x08,0xC5,0xF9,0x2E,0x05,0xDC,0x00,0x00,0x00,0x76,0x0D,0xC5,0xFB,0x10,0x05,0xDA,0x00,0x00,0x00,0xC5,0xFB,0x11,0x41,0x08,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov eax,[rcx]                           ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)] encoding(2 bytes) = 8b 01
0007h mov eax,[rcx+38h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)] encoding(3 bytes) = 8b 41 38
000ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000ch mov [rcx+38h],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX] encoding(3 bytes) = 89 41 38
000fh vmovsd xmm0,qword ptr [rcx+18h]         ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 41 18
0014h vmovsd xmm1,qword ptr [7FF7C7E62970h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d d4 01 00 00
001ch vsubsd xmm1,xmm1,xmm0                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f3 5c c8
0020h vxorps xmm2,xmm2,xmm2                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2] encoding(VEX, 4 bytes) = c5 e8 57 d2
0024h vcvtsi2sd xmm2,xmm2,eax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM2,XMM2,EAX] encoding(VEX, 4 bytes) = c5 eb 2a d0
0028h vmovaps xmm3,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 d9
002ch vdivsd xmm3,xmm3,xmm2                   ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM2] encoding(VEX, 4 bytes) = c5 e3 5e da
0030h vaddsd xmm0,xmm0,xmm3                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM3] encoding(VEX, 4 bytes) = c5 fb 58 c3
0034h vmovsd qword ptr [rcx+20h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 20
0039h vmovsd xmm2,qword ptr [rcx+28h]         ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 51 28
003eh vmovsd xmm3,qword ptr [7FF7C7E62978h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 1d b2 01 00 00
0046h vsubsd xmm3,xmm3,xmm0                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM0] encoding(VEX, 4 bytes) = c5 e3 5c d8
004ah vmulsd xmm1,xmm1,xmm3                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM3] encoding(VEX, 4 bytes) = c5 f3 59 cb
004eh vaddsd xmm1,xmm1,xmm2                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f3 58 ca
0052h vmovsd qword ptr [rcx+30h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
0057h vmovsd qword ptr [rcx+18h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 18
005ch vmovsd qword ptr [rcx+28h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
0061h vmovsd xmm2,qword ptr [7FF7C7E62980h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 97 01 00 00
0069h vucomisd xmm2,qword ptr [rcx+10h]       ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 51 10
006eh jbe short 007dh                         ; JBE(Jbe_rel8_64) [7Dh:jmp64]               encoding(2 bytes) = 76 0d
0070h vmovsd xmm2,qword ptr [7FF7C7E62988h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 90 01 00 00
0078h vmovsd qword ptr [rcx+10h],xmm2         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 10
007dh vmovsd xmm2,qword ptr [rcx+8]           ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 51 08
0082h vucomisd xmm2,qword ptr [7FF7C7E62990h] ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 f9 2e 15 86 01 00 00
008ah jbe short 0099h                         ; JBE(Jbe_rel8_64) [99h:jmp64]               encoding(2 bytes) = 76 0d
008ch vmovsd xmm2,qword ptr [7FF7C7E62998h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 84 01 00 00
0094h vmovsd qword ptr [rcx+8],xmm2           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 08
0099h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
009bh mov [rcx+38h],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX] encoding(3 bytes) = 89 41 38
009eh vmovsd xmm2,qword ptr [7FF7C7E629A0h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 7a 01 00 00
00a6h vsubsd xmm2,xmm2,xmm0                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM0] encoding(VEX, 4 bytes) = c5 eb 5c d0
00aah vxorps xmm3,xmm3,xmm3                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3] encoding(VEX, 4 bytes) = c5 e0 57 db
00aeh vcvtsi2sd xmm3,xmm3,eax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM3,XMM3,EAX] encoding(VEX, 4 bytes) = c5 e3 2a d8
00b2h vmovaps xmm4,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 e2
00b6h vdivsd xmm4,xmm4,xmm3                   ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3] encoding(VEX, 4 bytes) = c5 db 5e e3
00bah vaddsd xmm0,xmm0,xmm4                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM4] encoding(VEX, 4 bytes) = c5 fb 58 c4
00beh vmovsd qword ptr [rcx+20h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 20
00c3h vmovsd xmm3,qword ptr [7FF7C7E629A8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 1d 5d 01 00 00
00cbh vsubsd xmm3,xmm3,xmm0                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM0] encoding(VEX, 4 bytes) = c5 e3 5c d8
00cfh vmulsd xmm2,xmm2,xmm3                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM3] encoding(VEX, 4 bytes) = c5 eb 59 d3
00d3h vaddsd xmm1,xmm1,xmm2                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f3 58 ca
00d7h vmovsd qword ptr [rcx+30h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
00dch vmovsd qword ptr [rcx+18h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 18
00e1h vmovsd qword ptr [rcx+28h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
00e6h vmovsd xmm2,qword ptr [7FF7C7E629B0h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 42 01 00 00
00eeh vucomisd xmm2,qword ptr [rcx+10h]       ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 51 10
00f3h jbe short 0102h                         ; JBE(Jbe_rel8_64) [102h:jmp64]              encoding(2 bytes) = 76 0d
00f5h vmovsd xmm2,qword ptr [7FF7C7E629B8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 3b 01 00 00
00fdh vmovsd qword ptr [rcx+10h],xmm2         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 10
0102h vmovsd xmm2,qword ptr [rcx+8]           ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 51 08
0107h vucomisd xmm2,qword ptr [7FF7C7E629C0h] ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 f9 2e 15 31 01 00 00
010fh jbe short 011eh                         ; JBE(Jbe_rel8_64) [11Eh:jmp64]              encoding(2 bytes) = 76 0d
0111h vmovsd xmm2,qword ptr [7FF7C7E629C8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 2f 01 00 00
0119h vmovsd qword ptr [rcx+8],xmm2           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 08
011eh inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
0120h mov [rcx+38h],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX] encoding(3 bytes) = 89 41 38
0123h vmovsd xmm2,qword ptr [7FF7C7E629D0h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 25 01 00 00
012bh vsubsd xmm2,xmm2,xmm0                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM0] encoding(VEX, 4 bytes) = c5 eb 5c d0
012fh vxorps xmm3,xmm3,xmm3                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3] encoding(VEX, 4 bytes) = c5 e0 57 db
0133h vcvtsi2sd xmm3,xmm3,eax                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM3,XMM3,EAX] encoding(VEX, 4 bytes) = c5 e3 2a d8
0137h vmovaps xmm4,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 e2
013bh vdivsd xmm4,xmm4,xmm3                   ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3] encoding(VEX, 4 bytes) = c5 db 5e e3
013fh vaddsd xmm0,xmm0,xmm4                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM4] encoding(VEX, 4 bytes) = c5 fb 58 c4
0143h vmovsd qword ptr [rcx+20h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 20
0148h vmovsd xmm3,qword ptr [7FF7C7E629D8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 1d 08 01 00 00
0150h vsubsd xmm3,xmm3,xmm0                   ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM0] encoding(VEX, 4 bytes) = c5 e3 5c d8
0154h vmulsd xmm2,xmm2,xmm3                   ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM3] encoding(VEX, 4 bytes) = c5 eb 59 d3
0158h vaddsd xmm1,xmm1,xmm2                   ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f3 58 ca
015ch vmovsd qword ptr [rcx+30h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
0161h vmovsd qword ptr [rcx+18h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 18
0166h vmovsd qword ptr [rcx+28h],xmm1         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
016bh vmovsd xmm0,qword ptr [7FF7C7E629E0h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 ed 00 00 00
0173h vucomisd xmm0,qword ptr [rcx+10h]       ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 41 10
0178h jbe short 0187h                         ; JBE(Jbe_rel8_64) [187h:jmp64]              encoding(2 bytes) = 76 0d
017ah vmovsd xmm0,qword ptr [7FF7C7E629E8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 e6 00 00 00
0182h vmovsd qword ptr [rcx+10h],xmm0         ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 10
0187h vmovsd xmm0,qword ptr [rcx+8]           ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 41 08
018ch vucomisd xmm0,qword ptr [7FF7C7E629F0h] ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 f9 2e 05 dc 00 00 00
0194h jbe short 01a3h                         ; JBE(Jbe_rel8_64) [1A3h:jmp64]              encoding(2 bytes) = 76 0d
0196h vmovsd xmm0,qword ptr [7FF7C7E629F8h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 da 00 00 00
019eh vmovsd qword ptr [rcx+8],xmm0           ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 08
01a3h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_n8u()
; static ReadOnlySpan<byte> one_n8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_g8u()
; static ReadOnlySpan<byte> one_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_n16u()
; static ReadOnlySpan<byte> one_n16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_g16u()
; static ReadOnlySpan<byte> one_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_n32i()
; static ReadOnlySpan<byte> one_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_g32i()
; static ReadOnlySpan<byte> one_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_n32u()
; static ReadOnlySpan<byte> one_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_g32u()
; static ReadOnlySpan<byte> one_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_n64i()
; static ReadOnlySpan<byte> one_n64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_g64i()
; static ReadOnlySpan<byte> one_g64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_n64u()
; static ReadOnlySpan<byte> one_n64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_g64u()
; static ReadOnlySpan<byte> one_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_n32f()
; static ReadOnlySpan<byte> one_n32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FF7C7E62FB0h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_g32f()
; static ReadOnlySpan<byte> one_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FF7C7E62FE0h]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_n64f()
; static ReadOnlySpan<byte> one_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FF7C7E63010h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_g64f()
; static ReadOnlySpan<byte> one_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FF7C7E63040h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte zero_g8i()
; static ReadOnlySpan<byte> zero_g8iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte zero_g8u()
; static ReadOnlySpan<byte> zero_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short zero_g16i()
; static ReadOnlySpan<byte> zero_g16iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort zero_g16u()
; static ReadOnlySpan<byte> zero_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int zero_g32i()
; static ReadOnlySpan<byte> zero_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint zero_g32u()
; static ReadOnlySpan<byte> zero_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long zero_g64i()
; static ReadOnlySpan<byte> zero_g64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong zero_g64u()
; static ReadOnlySpan<byte> zero_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float zero_g32f()
; static ReadOnlySpan<byte> zero_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double zero_g64f()
; static ReadOnlySpan<byte> zero_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FF7C7E63190h]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_n8i()
; static ReadOnlySpan<byte> minval_n8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h                      ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]   encoding(5 bytes) = b8 80 ff ff ff
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_g8i()
; static ReadOnlySpan<byte> minval_g8iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_n8u()
; static ReadOnlySpan<byte> minval_n8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_g8u()
; static ReadOnlySpan<byte> minval_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_n16i()
; static ReadOnlySpan<byte> minval_n16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h                      ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]   encoding(5 bytes) = b8 00 80 ff ff
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_g16i()
; static ReadOnlySpan<byte> minval_g16iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort minval_g16u()
; static ReadOnlySpan<byte> minval_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_32i()
; static ReadOnlySpan<byte> minval_32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h                       ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]   encoding(5 bytes) = b8 00 00 00 80
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_g32i()
; static ReadOnlySpan<byte> minval_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_32u()
; static ReadOnlySpan<byte> minval_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_g32u()
; static ReadOnlySpan<byte> minval_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long minval_g64i()
; static ReadOnlySpan<byte> minval_g64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong minval_g64u()
; static ReadOnlySpan<byte> minval_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float minval_g32f()
; static ReadOnlySpan<byte> minval_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double minval_g64f()
; static ReadOnlySpan<byte> minval_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte maxval_g8i()
; static ReadOnlySpan<byte> maxval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7Fh                             ; MOV(Mov_r32_imm32) [EAX,7fh:imm32]         encoding(5 bytes) = b8 7f 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte maxval_g8u()
; static ReadOnlySpan<byte> maxval_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                            ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]         encoding(5 bytes) = b8 ff 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short maxval_g16i()
; static ReadOnlySpan<byte> maxval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x7F,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFh                           ; MOV(Mov_r32_imm32) [EAX,7fffh:imm32]       encoding(5 bytes) = b8 ff 7f 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort maxval_g16u()
; static ReadOnlySpan<byte> maxval_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFh                          ; MOV(Mov_r32_imm32) [EAX,ffffh:imm32]       encoding(5 bytes) = b8 ff ff 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_n32i()
; static ReadOnlySpan<byte> maxval_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh                       ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_g32i()
; static ReadOnlySpan<byte> maxval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh                       ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_n32u()
; static ReadOnlySpan<byte> maxval_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_g32u()
; static ReadOnlySpan<byte> maxval_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh                      ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]   encoding(5 bytes) = b8 ff ff ff ff
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long maxval_g64i()
; static ReadOnlySpan<byte> maxval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7F,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFFFFFFFFFFFFFFh               ; MOV(Mov_r64_imm64) [RAX,7fffffffffffffffh:imm64] encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff 7f
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong maxval_g64u()
; static ReadOnlySpan<byte> maxval_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFFFFFFFFFFh              ; MOV(Mov_r64_imm64) [RAX,ffffffffffffffffh:imm64] encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff ff
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
