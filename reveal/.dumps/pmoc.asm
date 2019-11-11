; 2019-11-11 00:59:28:609
; function: long square_d64i(long x)
; location: [7FFDDBAC1DF0h, 7FFDDBAC1E07h]
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
; location: [7FFDDBAC1E20h, 7FFDDBAC1E37h]
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
; location: [7FFDDBAC1E50h, 7FFDDBAC1E5Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong square_g64u(ulong x)
; location: [7FFDDBAC1E70h, 7FFDDBAC1E7Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rcx,rcx                  ; IMUL(Imul_r64_rm64) [RCX,RCX]                        encoding(4 bytes) = 48 0f af c9
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_d8i(sbyte lhs, int offset)
; location: [7FFDDBAC1E90h, 7FFDDBAC1EA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte srl_g8i(sbyte lhs, int offset)
; location: [7FFDDBAC22C0h, 7FFDDBAC22D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_d8u(byte lhs, int offset)
; location: [7FFDDBAC22F0h, 7FFDDBAC22FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte srl_g8u(byte lhs, int offset)
; location: [7FFDDBAC2310h, 7FFDDBAC231Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_d16i(short lhs, int offset)
; location: [7FFDDBAC2330h, 7FFDDBAC2341h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short srl_g16i(short lhs, int offset)
; location: [7FFDDBAC2360h, 7FFDDBAC2371h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_d16u(ushort lhs, int offset)
; location: [7FFDDBAC2390h, 7FFDDBAC239Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort srl_g16u(ushort lhs, int offset)
; location: [7FFDDBAC23B0h, 7FFDDBAC23BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_d32i(int lhs, int offset)
; location: [7FFDDBAC23D0h, 7FFDDBAC23DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int srl_g32i(int lhs, int offset)
; location: [7FFDDBAC23F0h, 7FFDDBAC23FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_d32u(uint lhs, int offset)
; location: [7FFDDBAC2410h, 7FFDDBAC241Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint srl_g32u(uint lhs, int offset)
; location: [7FFDDBAC2430h, 7FFDDBAC243Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_d64i(long lhs, int offset)
; location: [7FFDDBAC2450h, 7FFDDBAC245Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long srl_g64i(long lhs, int offset)
; location: [7FFDDBAC2470h, 7FFDDBAC247Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_d64u(ulong lhs, int offset)
; location: [7FFDDBAC2490h, 7FFDDBAC249Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_d64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl_g64u(ulong lhs, int offset)
; location: [7FFDDBAC24B0h, 7FFDDBAC24BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC24D0h, 7FFDDBAC24E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sub_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC2500h, 7FFDDBAC2517h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x2B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_d8u(byte lhs, byte rhs)
; location: [7FFDDBAC2530h, 7FFDDBAC2540h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sub_g8u(byte lhs, byte rhs)
; location: [7FFDDBAC2960h, 7FFDDBAC2973h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x2B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_d16i(short lhs, short rhs)
; location: [7FFDDBAC2990h, 7FFDDBAC29A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sub_g16i(short lhs, short rhs)
; location: [7FFDDBAC29C0h, 7FFDDBAC29D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x2B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC29F0h, 7FFDDBAC2A00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sub_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC2A20h, 7FFDDBAC2A33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_d32i(int lhs, int rhs)
; location: [7FFDDBAC2A50h, 7FFDDBAC2A59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub_g32i(int lhs, int rhs)
; location: [7FFDDBAC2A70h, 7FFDDBAC2A79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC2A90h, 7FFDDBAC2A99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sub_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC2AB0h, 7FFDDBAC2AB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x2B,0xCA,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_d64i(long lhs, long rhs)
; location: [7FFDDBAC2AD0h, 7FFDDBAC2ADBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sub_g64i(long lhs, long rhs)
; location: [7FFDDBAC2AF0h, 7FFDDBAC2AFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC2B10h, 7FFDDBAC2B1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sub_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC2B30h, 7FFDDBAC2B3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h sub rcx,rdx                   ; SUB(Sub_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 2b ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x2B,0xCA,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC2B50h, 7FFDDBAC2B63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xor_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC2B80h, 7FFDDBAC2B97h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_d8u(byte lhs, byte rhs)
; location: [7FFDDBAC2BB0h, 7FFDDBAC2BC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_g8u(byte lhs, byte rhs)
; location: [7FFDDBAC2BE0h, 7FFDDBAC2BF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_d16i(short lhs, short rhs)
; location: [7FFDDBAC2C10h, 7FFDDBAC2C23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xor_g16i(short lhs, short rhs)
; location: [7FFDDBAC2C40h, 7FFDDBAC2C57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC2C70h, 7FFDDBAC2C80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xor_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC2CA0h, 7FFDDBAC2CB3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_d32i(int lhs, int rhs)
; location: [7FFDDBAC2CD0h, 7FFDDBAC2CD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xor_g32i(int lhs, int rhs)
; location: [7FFDDBAC2CF0h, 7FFDDBAC2CF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC2D10h, 7FFDDBAC2D19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xor_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC2D30h, 7FFDDBAC2D39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_d64i(long lhs, long rhs)
; location: [7FFDDBAC2D50h, 7FFDDBAC2D5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xor_g64i(long lhs, long rhs)
; location: [7FFDDBAC2D70h, 7FFDDBAC2D7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC2D90h, 7FFDDBAC2D9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC2DB0h, 7FFDDBAC2DBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort not_d16u(ushort x)
; location: [7FFDDBAC2DD0h, 7FFDDBAC2DDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort not_g16u(ushort x)
; location: [7FFDDBAC2DF0h, 7FFDDBAC2DFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int not_d32i(int x)
; location: [7FFDDBAC2E10h, 7FFDDBAC2E19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int not_g32i(int x)
; location: [7FFDDBAC2E30h, 7FFDDBAC2E39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint not_d32u(uint x)
; location: [7FFDDBAC2E50h, 7FFDDBAC2E59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint not_g32u(uint x)
; location: [7FFDDBAC3280h, 7FFDDBAC3289h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long not_d64i(long x)
; location: [7FFDDBAC32A0h, 7FFDDBAC32ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long not_g64i(long x)
; location: [7FFDDBAC32C0h, 7FFDDBAC32CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong not_d64u(ulong x)
; location: [7FFDDBAC32E0h, 7FFDDBAC32EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong not_g64u(ulong x)
; location: [7FFDDBAC3300h, 7FFDDBAC330Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC3320h, 7FFDDBAC3333h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte or_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC3350h, 7FFDDBAC3367h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x0B,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_d8u(byte lhs, byte rhs)
; location: [7FFDDBAC3380h, 7FFDDBAC3390h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte or_g8u(byte lhs, byte rhs)
; location: [7FFDDBAC33B0h, 7FFDDBAC33C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_d16i(short lhs, short rhs)
; location: [7FFDDBAC33E0h, 7FFDDBAC33F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short or_g16i(short lhs, short rhs)
; location: [7FFDDBAC3410h, 7FFDDBAC3427h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x0B,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC3440h, 7FFDDBAC3450h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort or_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC3470h, 7FFDDBAC3483h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_d32i(int lhs, int rhs)
; location: [7FFDDBAC34A0h, 7FFDDBAC34A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int or_g32i(int lhs, int rhs)
; location: [7FFDDBAC34C0h, 7FFDDBAC34C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC34E0h, 7FFDDBAC34E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint or_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC3500h, 7FFDDBAC3509h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_d64i(long lhs, long rhs)
; location: [7FFDDBAC3520h, 7FFDDBAC352Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long or_g64i(long lhs, long rhs)
; location: [7FFDDBAC3540h, 7FFDDBAC354Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC3560h, 7FFDDBAC356Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC3580h, 7FFDDBAC358Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_d32f(float lhs, float rhs)
; location: [7FFDDBAC3CF0h, 7FFDDBAC3D19h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float or_g32f(float lhs, float rhs)
; location: [7FFDDBAC4330h, 7FFDDBAC4359h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h or eax,[rsp+10h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x0B,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or_d64f(double lhs, double rhs)
; location: [7FFDDBAC4380h, 7FFDDBAC43AAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]            encoding(5 bytes) = 48 0b 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double or_g64f(double lhs, double rhs)
; location: [7FFDDBAC43D0h, 7FFDDBAC43DFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,7FFDDBAC3F88h         ; MOV(Mov_r64_imm64) [RAX,7ffddbac3f88h:imm64]         encoding(10 bytes) = 48 b8 88 3f ac db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> or_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0x88,0x3F,0xAC,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse_d8i(string src, out sbyte dst)
; location: [7FFDDBAC4400h, 7FFDDBAC448Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 006ch                ; JE(Je_rel8_64) [6Ch:jmp64]                           encoding(2 bytes) = 74 56
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 59 08
001dh call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D767190h:jmp64]                encoding(5 bytes) = e8 6e 71 76 5d
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDI]          encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EBX]          encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFE3921C710h            ; CALL(Call_rel32_64) [5D758310h:jmp64]                encoding(5 bytes) = e8 cc 82 75 5d
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0077h               ; JNE(Jne_rel8_64) [77h:jmp64]                         encoding(2 bytes) = 75 2d
004ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 38
004eh add eax,80h                   ; ADD(Add_EAX_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = 05 80 00 00 00
0053h cmp eax,0FFh                  ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 3d ff 00 00 00
0058h ja short 0082h                ; JA(Ja_rel8_64) [82h:jmp64]                           encoding(2 bytes) = 77 28
005ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 38
005eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0062h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,:sr),AL]              encoding(2 bytes) = 88 06
0064h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0068h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006ch mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0071h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979A70h:jmp64]        encoding(5 bytes) = e8 fa 99 97 ff
0076h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0077h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007ch call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C7C8h:jmp64]        encoding(5 bytes) = e8 47 c7 c3 ff
0081h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0082h mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0087h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C7D0h:jmp64]        encoding(5 bytes) = e8 44 c7 c3 ff
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d8iBytes => new byte[141]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x56,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x6E,0x71,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0xCC,0x82,0x75,0x5D,0x8B,0xC8,0x85,0xC9,0x75,0x2D,0x8B,0x44,0x24,0x38,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBE,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xFA,0x99,0x97,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x47,0xC7,0xC3,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x44,0xC7,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte parse_g8i(string src)
; location: [7FFDDBAC44B0h, 7FFDDBAC4535h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 53
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 79 08
0019h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D7670E0h:jmp64]                encoding(5 bytes) = e8 c2 70 76 5d
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RSI]          encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDI]          encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFE3921C710h            ; CALL(Call_rel32_64) [5D758260h:jmp64]                encoding(5 bytes) = e8 20 82 75 5d
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0070h               ; JNE(Jne_rel8_64) [70h:jmp64]                         encoding(2 bytes) = 75 2a
0046h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
004ah add eax,80h                   ; ADD(Add_EAX_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = 05 80 00 00 00
004fh cmp eax,0FFh                  ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 3d ff 00 00 00
0054h ja short 007bh                ; JA(Ja_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 77 25
0056h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
005ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
005eh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0062h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0063h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0065h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ah call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9799C0h:jmp64]        encoding(5 bytes) = e8 51 99 97 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0075h call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C718h:jmp64]        encoding(5 bytes) = e8 9e c6 c3 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0080h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C720h:jmp64]        encoding(5 bytes) = e8 9b c6 c3 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g8iBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x53,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0xC2,0x70,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x20,0x82,0x75,0x5D,0x8B,0xC8,0x85,0xC9,0x75,0x2A,0x8B,0x44,0x24,0x30,0x05,0x80,0x00,0x00,0x00,0x3D,0xFF,0x00,0x00,0x00,0x77,0x25,0x8B,0x44,0x24,0x30,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x51,0x99,0x97,0xFF,0xCC,0xBA,0x05,0x00,0x00,0x00,0xE8,0x9E,0xC6,0xC3,0xFF,0xCC,0xB9,0x05,0x00,0x00,0x00,0xE8,0x9B,0xC6,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse_d8u(string src, out byte dst)
; location: [7FFDDBAC4550h, 7FFDDBAC45D5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 4f
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 59 08
001dh call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D767040h:jmp64]                encoding(5 bytes) = e8 1e 70 76 5d
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDI]          encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EBX]          encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFDDB700B30h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C5E0h:jmp64]        encoding(5 bytes) = e8 9c c5 c3 ff
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0070h               ; JNE(Jne_rel8_64) [70h:jmp64]                         encoding(2 bytes) = 75 26
004ah cmp dword ptr [rsp+38h],0FFh  ; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = 81 7c 24 38 ff 00 00 00
0052h ja short 007bh                ; JA(Ja_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 77 27
0054h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 38
0058h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005bh mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,:sr),AL]              encoding(2 bytes) = 88 06
005dh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0061h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0062h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0063h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0065h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ah call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979920h:jmp64]        encoding(5 bytes) = e8 b1 98 97 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
0075h call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C678h:jmp64]        encoding(5 bytes) = e8 fe c5 c3 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0080h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C680h:jmp64]        encoding(5 bytes) = e8 fb c5 c3 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d8uBytes => new byte[134]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x4F,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x1E,0x70,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x9C,0xC5,0xC3,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x26,0x81,0x7C,0x24,0x38,0xFF,0x00,0x00,0x00,0x77,0x27,0x8B,0x44,0x24,0x38,0x0F,0xB6,0xC0,0x88,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xB1,0x98,0x97,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0xFE,0xC5,0xC3,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0xFB,0xC5,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte parse_g8u(string src)
; location: [7FFDDBAC45F0h, 7FFDDBAC466Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 005eh                ; JE(Je_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 74 4c
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 79 08
0019h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766FA0h:jmp64]                encoding(5 bytes) = e8 82 6f 76 5d
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RSI]          encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDI]          encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFDDB700B30h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C540h:jmp64]        encoding(5 bytes) = e8 00 c5 c3 ff
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 23
0046h cmp dword ptr [rsp+30h],0FFh  ; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = 81 7c 24 30 ff 00 00 00
004eh ja short 0074h                ; JA(Ja_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 77 24
0050h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
0054h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0057h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
005bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005ch pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005eh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0063h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979880h:jmp64]        encoding(5 bytes) = e8 18 98 97 ff
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0069h mov edx,6                     ; MOV(Mov_r32_imm32) [EDX,6h:imm32]                    encoding(5 bytes) = ba 06 00 00 00
006eh call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C5D8h:jmp64]        encoding(5 bytes) = e8 65 c5 c3 ff
0073h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0074h mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0079h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C5E0h:jmp64]        encoding(5 bytes) = e8 62 c5 c3 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g8uBytes => new byte[127]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x4C,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x82,0x6F,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x00,0xC5,0xC3,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x23,0x81,0x7C,0x24,0x30,0xFF,0x00,0x00,0x00,0x77,0x24,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x18,0x98,0x97,0xFF,0xCC,0xBA,0x06,0x00,0x00,0x00,0xE8,0x65,0xC5,0xC3,0xFF,0xCC,0xB9,0x06,0x00,0x00,0x00,0xE8,0x62,0xC5,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse_d16i(string src, out short dst)
; location: [7FFDDBAC4690h, 7FFDDBAC471Dh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 006dh                ; JE(Je_rel8_64) [6Dh:jmp64]                           encoding(2 bytes) = 74 57
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 59 08
001dh call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766F00h:jmp64]                encoding(5 bytes) = e8 de 6e 76 5d
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDI]          encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EBX]          encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFE3921C710h            ; CALL(Call_rel32_64) [5D758080h:jmp64]                encoding(5 bytes) = e8 3c 80 75 5d
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0078h               ; JNE(Jne_rel8_64) [78h:jmp64]                         encoding(2 bytes) = 75 2e
004ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 38
004eh add eax,8000h                 ; ADD(Add_EAX_imm32) [EAX,8000h:imm32]                 encoding(5 bytes) = 05 00 80 00 00
0053h cmp eax,0FFFFh                ; CMP(Cmp_EAX_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = 3d ff ff 00 00
0058h ja short 0083h                ; JA(Ja_rel8_64) [83h:jmp64]                           encoding(2 bytes) = 77 29
005ah mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 38
005eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0062h mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,:sr),AX]           encoding(3 bytes) = 66 89 06
0065h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0069h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
006dh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0072h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9797E0h:jmp64]        encoding(5 bytes) = e8 69 97 97 ff
0077h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0078h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
007dh call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C538h:jmp64]        encoding(5 bytes) = e8 b6 c4 c3 ff
0082h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0083h mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0088h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C540h:jmp64]        encoding(5 bytes) = e8 b3 c4 c3 ff
008dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d16iBytes => new byte[142]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x57,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xDE,0x6E,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x3C,0x80,0x75,0x5D,0x8B,0xC8,0x85,0xC9,0x75,0x2E,0x8B,0x44,0x24,0x38,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x29,0x8B,0x44,0x24,0x38,0x48,0x0F,0xBF,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x69,0x97,0x97,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0xB6,0xC4,0xC3,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0xB3,0xC4,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short parse_g16i(string src)
; location: [7FFDDBAC4740h, 7FFDDBAC47C5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 0065h                ; JE(Je_rel8_64) [65h:jmp64]                           encoding(2 bytes) = 74 53
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 79 08
0019h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766E50h:jmp64]                encoding(5 bytes) = e8 32 6e 76 5d
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RSI]          encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDI]          encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFE3921C710h            ; CALL(Call_rel32_64) [5D757FD0h:jmp64]                encoding(5 bytes) = e8 90 7f 75 5d
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0070h               ; JNE(Jne_rel8_64) [70h:jmp64]                         encoding(2 bytes) = 75 2a
0046h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
004ah add eax,8000h                 ; ADD(Add_EAX_imm32) [EAX,8000h:imm32]                 encoding(5 bytes) = 05 00 80 00 00
004fh cmp eax,0FFFFh                ; CMP(Cmp_EAX_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = 3d ff ff 00 00
0054h ja short 007bh                ; JA(Ja_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 77 25
0056h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
005ah movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
005eh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0062h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0063h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0065h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006ah call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979730h:jmp64]        encoding(5 bytes) = e8 c1 96 97 ff
006fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0070h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0075h call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C488h:jmp64]        encoding(5 bytes) = e8 0e c4 c3 ff
007ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007bh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0080h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C490h:jmp64]        encoding(5 bytes) = e8 0b c4 c3 ff
0085h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g16iBytes => new byte[134]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x53,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x32,0x6E,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x90,0x7F,0x75,0x5D,0x8B,0xC8,0x85,0xC9,0x75,0x2A,0x8B,0x44,0x24,0x30,0x05,0x00,0x80,0x00,0x00,0x3D,0xFF,0xFF,0x00,0x00,0x77,0x25,0x8B,0x44,0x24,0x30,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC1,0x96,0x97,0xFF,0xCC,0xBA,0x07,0x00,0x00,0x00,0xE8,0x0E,0xC4,0xC3,0xFF,0xCC,0xB9,0x07,0x00,0x00,0x00,0xE8,0x0B,0xC4,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse_d16u(string src, out ushort dst)
; location: [7FFDDBAC47E0h, 7FFDDBAC4866h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0014h je short 0066h                ; JE(Je_rel8_64) [66h:jmp64]                           encoding(2 bytes) = 74 50
0016h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 79 0c
001ah mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 59 08
001dh call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766DB0h:jmp64]                encoding(5 bytes) = e8 8e 6d 76 5d
0022h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0025h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002ah mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDI]          encoding(3 bytes) = 48 89 39
002dh mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EBX]          encoding(3 bytes) = 89 59 08
0030h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
0035h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 38
003ah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003fh call 7FFDDB700B30h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C350h:jmp64]        encoding(5 bytes) = e8 0c c3 c3 ff
0044h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0046h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0048h jne short 0071h               ; JNE(Jne_rel8_64) [71h:jmp64]                         encoding(2 bytes) = 75 27
004ah cmp dword ptr [rsp+38h],0FFFFh; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = 81 7c 24 38 ff ff 00 00
0052h ja short 007ch                ; JA(Ja_rel8_64) [7Ch:jmp64]                           encoding(2 bytes) = 77 28
0054h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 38
0058h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
005bh mov [rsi],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSI:br,:sr),AX]           encoding(3 bytes) = 66 89 06
005eh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0062h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0063h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0064h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0066h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
006bh call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979690h:jmp64]        encoding(5 bytes) = e8 20 96 97 ff
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0071h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0076h call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C3E8h:jmp64]        encoding(5 bytes) = e8 6d c3 c3 ff
007bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
007ch mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0081h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C3F0h:jmp64]        encoding(5 bytes) = e8 6a c3 c3 ff
0086h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d16uBytes => new byte[135]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x50,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x8E,0x6D,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0x07,0x00,0x00,0x00,0xE8,0x0C,0xC3,0xC3,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x27,0x81,0x7C,0x24,0x38,0xFF,0xFF,0x00,0x00,0x77,0x28,0x8B,0x44,0x24,0x38,0x0F,0xB7,0xC0,0x66,0x89,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x20,0x96,0x97,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0x6D,0xC3,0xC3,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0x6A,0xC3,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort parse_g16u(string src)
; location: [7FFDDBAC4880h, 7FFDDBAC48FEh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000dh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0010h je short 005eh                ; JE(Je_rel8_64) [5Eh:jmp64]                           encoding(2 bytes) = 74 4c
0012h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 71 0c
0016h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 79 08
0019h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766D10h:jmp64]                encoding(5 bytes) = e8 f2 6c 76 5d
001eh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0021h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0026h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RSI]          encoding(3 bytes) = 48 89 31
0029h mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDI]          encoding(3 bytes) = 89 79 08
002ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0031h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 30
0036h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
003bh call 7FFDDB700B30h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C2B0h:jmp64]        encoding(5 bytes) = e8 70 c2 c3 ff
0040h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0042h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0044h jne short 0069h               ; JNE(Jne_rel8_64) [69h:jmp64]                         encoding(2 bytes) = 75 23
0046h cmp dword ptr [rsp+30h],0FFFFh; CMP(Cmp_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = 81 7c 24 30 ff ff 00 00
004eh ja short 0074h                ; JA(Ja_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 77 24
0050h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
0054h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0057h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
005bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005ch pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005eh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0063h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9795F0h:jmp64]        encoding(5 bytes) = e8 88 95 97 ff
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0069h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
006eh call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C348h:jmp64]        encoding(5 bytes) = e8 d5 c2 c3 ff
0073h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0074h mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0079h call 7FFDDB700BD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C350h:jmp64]        encoding(5 bytes) = e8 d2 c2 c3 ff
007eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g16uBytes => new byte[127]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x4C,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0xF2,0x6C,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0x07,0x00,0x00,0x00,0xE8,0x70,0xC2,0xC3,0xFF,0x8B,0xC8,0x85,0xC9,0x75,0x23,0x81,0x7C,0x24,0x30,0xFF,0xFF,0x00,0x00,0x77,0x24,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x88,0x95,0x97,0xFF,0xCC,0xBA,0x08,0x00,0x00,0x00,0xE8,0xD5,0xC2,0xC3,0xFF,0xCC,0xB9,0x08,0x00,0x00,0x00,0xE8,0xD2,0xC2,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse_d32i(string src, out int dst)
; location: [7FFDDBAC4920h, 7FFDDBAC496Fh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0045h                ; JE(Je_rel8_64) [45h:jmp64]                           encoding(2 bytes) = 74 31
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0026h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766C70h:jmp64]                encoding(5 bytes) = e8 45 6c 76 5d
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDDB700AC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C1A8h:jmp64]        encoding(5 bytes) = e8 6b c1 c3 ff
003dh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EAX]          encoding(2 bytes) = 89 06
003fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0045h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004ah call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979550h:jmp64]        encoding(5 bytes) = e8 01 95 97 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32iBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x45,0x6C,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x6B,0xC1,0xC3,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x01,0x95,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int parse_g32i(string src)
; location: [7FFDDBAC4990h, 7FFDDBAC49D9h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0022h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766C00h:jmp64]                encoding(5 bytes) = e8 d9 6b 76 5d
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDDB700AC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C138h:jmp64]        encoding(5 bytes) = e8 ff c0 c3 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9794E0h:jmp64]        encoding(5 bytes) = e8 97 94 97 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32iBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xD9,0x6B,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0xFF,0xC0,0xC3,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x97,0x94,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse_d32u(string src, out uint dst)
; location: [7FFDDBAC49F0h, 7FFDDBAC4A3Fh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0045h                ; JE(Je_rel8_64) [45h:jmp64]                           encoding(2 bytes) = 74 31
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0026h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766BA0h:jmp64]                encoding(5 bytes) = e8 75 6b 76 5d
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDDB700AD8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C0E8h:jmp64]        encoding(5 bytes) = e8 ab c0 c3 ff
003dh mov [rsi],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EAX]          encoding(2 bytes) = 89 06
003fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0045h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004ah call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979480h:jmp64]        encoding(5 bytes) = e8 31 94 97 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32uBytes => new byte[80]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x31,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x75,0x6B,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0xAB,0xC0,0xC3,0xFF,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x31,0x94,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint parse_g32u(string src)
; location: [7FFDDBAC4A60h, 7FFDDBAC4AA9h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0022h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766B30h:jmp64]                encoding(5 bytes) = e8 09 6b 76 5d
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDDB700AD8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C078h:jmp64]        encoding(5 bytes) = e8 3f c0 c3 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979410h:jmp64]        encoding(5 bytes) = e8 c7 93 97 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32uBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x09,0x6B,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0x3F,0xC0,0xC3,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xC7,0x93,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse_d64i(string src, out long dst)
; location: [7FFDDBAC4AC0h, 7FFDDBAC4B10h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 32
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0026h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766AD0h:jmp64]                encoding(5 bytes) = e8 a5 6a 76 5d
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFDDB700AD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3C010h:jmp64]        encoding(5 bytes) = e8 d3 bf c3 ff
003dh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
0040h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0044h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004bh call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9793B0h:jmp64]        encoding(5 bytes) = e8 60 93 97 ff
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64iBytes => new byte[81]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xA5,0x6A,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0xD3,0xBF,0xC3,0xFF,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x60,0x93,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long parse_g64i(string src)
; location: [7FFDDBAC4B30h, 7FFDDBAC4B79h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0022h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766A60h:jmp64]                encoding(5 bytes) = e8 39 6a 76 5d
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFDDB700AD0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BFA0h:jmp64]        encoding(5 bytes) = e8 67 bf c3 ff
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979340h:jmp64]        encoding(5 bytes) = e8 f7 92 97 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64iBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x39,0x6A,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0x67,0xBF,0xC3,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xF7,0x92,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse_d64u(string src, out ulong dst)
; location: [7FFDDBAC4B90h, 7FFDDBAC4BE0h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0012h je short 0046h                ; JE(Je_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 74 32
0014h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0018h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
001bh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0026h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766A00h:jmp64]                encoding(5 bytes) = e8 d5 69 76 5d
002bh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002eh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0033h mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0038h call 7FFE392FB840h            ; CALL(Call_rel32_64) [5D836CB0h:jmp64]                encoding(5 bytes) = e8 73 6c 83 5d
003dh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
0040h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0044h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
004bh call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9792E0h:jmp64]        encoding(5 bytes) = e8 90 92 97 ff
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64uBytes => new byte[81]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x32,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0xD5,0x69,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0xBA,0x07,0x00,0x00,0x00,0xE8,0x73,0x6C,0x83,0x5D,0x48,0x89,0x06,0x48,0x83,0xC4,0x30,0x5E,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x90,0x92,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong parse_g64u(string src)
; location: [7FFDDBAC4C00h, 7FFDDBAC4C49h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000bh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
000eh je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 2f
0010h lea rax,[rcx+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 0c
0014h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
0017h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
001ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001fh mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0022h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766990h:jmp64]                encoding(5 bytes) = e8 69 69 76 5d
0027h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
002ah lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002fh mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
0034h call 7FFE392FB840h            ; CALL(Call_rel32_64) [5D836C40h:jmp64]                encoding(5 bytes) = e8 07 6c 83 5d
0039h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
003ah add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003fh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0044h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979270h:jmp64]        encoding(5 bytes) = e8 27 92 97 ff
0049h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64uBytes => new byte[74]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x85,0xC9,0x74,0x2F,0x48,0x8D,0x41,0x0C,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xE8,0x69,0x69,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x07,0x00,0x00,0x00,0xE8,0x07,0x6C,0x83,0x5D,0x90,0x48,0x83,0xC4,0x38,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x27,0x92,0x97,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse_d32f(string src, out float dst)
; location: [7FFDDBAC4C60h, 7FFDDBAC4CD4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 005dh                ; JE(Je_rel8_64) [5Dh:jmp64]                           encoding(2 bytes) = 74 44
0019h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 79 0c
001dh mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 59 08
0020h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766930h:jmp64]                encoding(5 bytes) = e8 0b 69 76 5d
0025h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0028h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002dh mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDI]          encoding(3 bytes) = 48 89 39
0030h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EBX]          encoding(3 bytes) = 89 59 08
0033h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
0038h lea r9,[rsp+3Ch]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 3c
003dh mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
0042h call 7FFDDB700B90h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BF30h:jmp64]        encoding(5 bytes) = e8 e9 be c3 ff
0047h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0049h je short 0068h                ; JE(Je_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 74 1d
004bh vmovss xmm0,dword ptr [rsp+3Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 3c
0051h vmovss dword ptr [rsi],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 06
0055h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0059h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005dh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0062h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979210h:jmp64]        encoding(5 bytes) = e8 a9 91 97 ff
0067h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0068h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
006dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006fh call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BF68h:jmp64]        encoding(5 bytes) = e8 f4 be c3 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d32fBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0x0B,0x69,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x3C,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xE9,0xBE,0xC3,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFA,0x10,0x44,0x24,0x3C,0xC5,0xFA,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0xA9,0x91,0x97,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0xF4,0xBE,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float parse_g32f(string src)
; location: [7FFDDBAC4CF0h, 7FFDDBAC4D5Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0010h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0013h je short 0054h                ; JE(Je_rel8_64) [54h:jmp64]                           encoding(2 bytes) = 74 3f
0015h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 71 0c
0019h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 79 08
001ch call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D7668A0h:jmp64]                encoding(5 bytes) = e8 7f 68 76 5d
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0029h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RSI]          encoding(3 bytes) = 48 89 31
002ch mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDI]          encoding(3 bytes) = 89 79 08
002fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0034h lea r9,[rsp+34h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 34
0039h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
003eh call 7FFDDB700B90h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BEA0h:jmp64]        encoding(5 bytes) = e8 5d be c3 ff
0043h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0045h je short 005fh                ; JE(Je_rel8_64) [5Fh:jmp64]                           encoding(2 bytes) = 74 18
0047h vmovss xmm0,dword ptr [rsp+34h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 34
004dh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0054h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0059h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979180h:jmp64]        encoding(5 bytes) = e8 22 91 97 ff
005eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
005fh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BED8h:jmp64]        encoding(5 bytes) = e8 6d be c3 ff
006bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g32fBytes => new byte[108]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x3F,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x7F,0x68,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x34,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x5D,0xBE,0xC3,0xFF,0x85,0xC0,0x74,0x18,0xC5,0xFA,0x10,0x44,0x24,0x34,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x22,0x91,0x97,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x6D,0xBE,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse_d64f(string src, out double dst)
; location: [7FFDDBAC4D80h, 7FFDDBAC4DF4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0017h je short 005dh                ; JE(Je_rel8_64) [5Dh:jmp64]                           encoding(2 bytes) = 74 44
0019h lea rdi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 79 0c
001dh mov ebx,[rcx+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 59 08
0020h call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766810h:jmp64]                encoding(5 bytes) = e8 eb 67 76 5d
0025h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0028h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
002dh mov [rcx],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDI]          encoding(3 bytes) = 48 89 39
0030h mov [rcx+8],ebx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EBX]          encoding(3 bytes) = 89 59 08
0033h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
0038h lea r9,[rsp+38h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 38
003dh mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
0042h call 7FFDDB700B88h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BE08h:jmp64]        encoding(5 bytes) = e8 c1 bd c3 ff
0047h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0049h je short 0068h                ; JE(Je_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 74 1d
004bh vmovsd xmm0,qword ptr [rsp+38h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 38
0051h vmovsd qword ptr [rsi],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 06
0055h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0059h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
005ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005dh mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0062h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF9790F0h:jmp64]        encoding(5 bytes) = e8 89 90 97 ff
0067h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0068h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
006dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
006fh call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BE48h:jmp64]        encoding(5 bytes) = e8 d4 bd c3 ff
0074h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_d64fBytes => new byte[117]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x85,0xC9,0x74,0x44,0x48,0x8D,0x79,0x0C,0x8B,0x59,0x08,0xE8,0xEB,0x67,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x39,0x89,0x59,0x08,0x48,0x8D,0x4C,0x24,0x28,0x4C,0x8D,0x4C,0x24,0x38,0xBA,0xE7,0x00,0x00,0x00,0xE8,0xC1,0xBD,0xC3,0xFF,0x85,0xC0,0x74,0x1D,0xC5,0xFB,0x10,0x44,0x24,0x38,0xC5,0xFB,0x11,0x06,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x89,0x90,0x97,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0xD4,0xBD,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double parse_g64f(string src)
; location: [7FFDDBAC4E10h, 7FFDDBAC4E7Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0010h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0013h je short 0054h                ; JE(Je_rel8_64) [54h:jmp64]                           encoding(2 bytes) = 74 3f
0015h lea rsi,[rcx+0Ch]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 71 0c
0019h mov edi,[rcx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 79 08
001ch call 7FFE3922B590h            ; CALL(Call_rel32_64) [5D766780h:jmp64]                encoding(5 bytes) = e8 5f 67 76 5d
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0029h mov [rcx],rsi                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RSI]          encoding(3 bytes) = 48 89 31
002ch mov [rcx+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDI]          encoding(3 bytes) = 89 79 08
002fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0034h lea r9,[rsp+30h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 30
0039h mov edx,0E7h                  ; MOV(Mov_r32_imm32) [EDX,e7h:imm32]                   encoding(5 bytes) = ba e7 00 00 00
003eh call 7FFDDB700B88h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BD78h:jmp64]        encoding(5 bytes) = e8 35 bd c3 ff
0043h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0045h je short 005fh                ; JE(Je_rel8_64) [5Fh:jmp64]                           encoding(2 bytes) = 74 18
0047h vmovsd xmm0,qword ptr [rsp+30h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 30
004dh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0054h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0059h call 7FFDDB43DE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF979060h:jmp64]        encoding(5 bytes) = e8 02 90 97 ff
005eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
005fh mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0064h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0066h call 7FFDDB700BC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC3BDB8h:jmp64]        encoding(5 bytes) = e8 4d bd c3 ff
006bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> parse_g64fBytes => new byte[108]{0x57,0x56,0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x85,0xC9,0x74,0x3F,0x48,0x8D,0x71,0x0C,0x8B,0x79,0x08,0xE8,0x5F,0x67,0x76,0x5D,0x4C,0x8B,0xC0,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x31,0x89,0x79,0x08,0x48,0x8D,0x4C,0x24,0x20,0x4C,0x8D,0x4C,0x24,0x30,0xBA,0xE7,0x00,0x00,0x00,0xE8,0x35,0xBD,0xC3,0xFF,0x85,0xC0,0x74,0x18,0xC5,0xFB,0x10,0x44,0x24,0x30,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xB9,0x11,0x00,0x00,0x00,0xE8,0x02,0x90,0x97,0xFF,0xCC,0xB9,0x01,0x00,0x00,0x00,0x33,0xD2,0xE8,0x4D,0xBD,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8i(sbyte x)
; location: [7FFDDBAC4EA0h, 7FFDDBAC4EB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8i(sbyte x)
; location: [7FFDDBAC4ED0h, 7FFDDBAC4EEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g8iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n8u(byte x)
; location: [7FFDDBAC4F00h, 7FFDDBAC4F0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g8u(byte x)
; location: [7FFDDBAC4F20h, 7FFDDBAC4F39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16i(short x)
; location: [7FFDDBAC4F50h, 7FFDDBAC4F61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16i(short x)
; location: [7FFDDBAC4F80h, 7FFDDBAC4F9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n16u(ushort x)
; location: [7FFDDBAC4FB0h, 7FFDDBAC4FC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g16u(ushort x)
; location: [7FFDDBAC4FE0h, 7FFDDBAC4FF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g16uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32i(int x)
; location: [7FFDDBAC5010h, 7FFDDBAC501Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32i(int x)
; location: [7FFDDBAC5440h, 7FFDDBAC5456h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n32u(uint x)
; location: [7FFDDBAC5470h, 7FFDDBAC547Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g32u(uint x)
; location: [7FFDDBAC5490h, 7FFDDBAC54A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64i(long x)
; location: [7FFDDBAC54C0h, 7FFDDBAC54CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64i(long x)
; location: [7FFDDBAC54E0h, 7FFDDBAC54F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g64iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_n64u(ulong x)
; location: [7FFDDBAC5510h, 7FFDDBAC551Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool positive_g64u(ulong x)
; location: [7FFDDBAC5530h, 7FFDDBAC5547h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> positive_g64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_b8i(sbyte b, uint exp)
; location: [7FFDDBAC5560h, 7FFDDBAC5573h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h mov rax,7FFDDB444528h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444528h:imm64]         encoding(10 bytes) = 48 b8 28 45 44 db fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC9,0x48,0xB8,0x28,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte pow_g8i(sbyte b, uint exp)
; location: [7FFDDBAC5590h, 7FFDDBAC55A6h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
0009h call 7FFDDB444528h            ; CALL(Call_rel32_64) [FFFFFFFFFF97EF98h:jmp64]        encoding(5 bytes) = e8 8a ef 97 ff
000eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g8iBytes => new byte[23]{0x48,0x83,0xEC,0x28,0x90,0x48,0x0F,0xBE,0xC9,0xE8,0x8A,0xEF,0x97,0xFF,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_b8u(byte b, uint exp)
; location: [7FFDDBAC55C0h, 7FFDDBAC55D2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h mov rax,7FFDDB444530h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444530h:imm64]         encoding(10 bytes) = 48 b8 30 45 44 db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC9,0x48,0xB8,0x30,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pow_g8u(byte b, uint exp)
; location: [7FFDDBAC55F0h, 7FFDDBAC5604h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0008h call 7FFDDB444530h            ; CALL(Call_rel32_64) [FFFFFFFFFF97EF40h:jmp64]        encoding(5 bytes) = e8 33 ef 97 ff
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g8uBytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC9,0xE8,0x33,0xEF,0x97,0xFF,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_b16i(short b, uint exp)
; location: [7FFDDBAC5620h, 7FFDDBAC5633h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h mov rax,7FFDDB444538h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444538h:imm64]         encoding(10 bytes) = 48 b8 38 45 44 db fd 7f 00 00
0013h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC9,0x48,0xB8,0x38,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short pow_g16i(short b, uint exp)
; location: [7FFDDBAC5650h, 7FFDDBAC5666h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
0009h call 7FFDDB444538h            ; CALL(Call_rel32_64) [FFFFFFFFFF97EEE8h:jmp64]        encoding(5 bytes) = e8 da ee 97 ff
000eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0012h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g16iBytes => new byte[23]{0x48,0x83,0xEC,0x28,0x90,0x48,0x0F,0xBF,0xC9,0xE8,0xDA,0xEE,0x97,0xFF,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_b16u(ushort b, uint exp)
; location: [7FFDDBAC5680h, 7FFDDBAC5692h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h mov rax,7FFDDB444540h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444540h:imm64]         encoding(10 bytes) = 48 b8 40 45 44 db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x48,0xB8,0x40,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pow_g16u(ushort b, uint exp)
; location: [7FFDDBAC56B0h, 7FFDDBAC56C4h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0008h call 7FFDDB444540h            ; CALL(Call_rel32_64) [FFFFFFFFFF97EE90h:jmp64]        encoding(5 bytes) = e8 83 ee 97 ff
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g16uBytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB7,0xC9,0xE8,0x83,0xEE,0x97,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_b32i(int b, uint exp)
; location: [7FFDDBAC56E0h, 7FFDDBAC56EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDB444548h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444548h:imm64]         encoding(10 bytes) = 48 b8 48 45 44 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b32iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x48,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int pow_g32i(int b, uint exp)
; location: [7FFDDBAC5710h, 7FFDDBAC571Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDB444548h            ; CALL(Call_rel32_64) [FFFFFFFFFF97EE38h:jmp64]        encoding(5 bytes) = e8 2e ee 97 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g32iBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x2E,0xEE,0x97,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_b32u(uint b, uint exp)
; location: [7FFDDBAC5740h, 7FFDDBAC574Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDB444550h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444550h:imm64]         encoding(10 bytes) = 48 b8 50 45 44 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x50,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pow_g32u(uint b, uint exp)
; location: [7FFDDBAC5770h, 7FFDDBAC577Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDB444550h            ; CALL(Call_rel32_64) [FFFFFFFFFF97EDE0h:jmp64]        encoding(5 bytes) = e8 d6 ed 97 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g32uBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0xD6,0xED,0x97,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_b64i(long b, uint exp)
; location: [7FFDDBAC57A0h, 7FFDDBAC57AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDB444558h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444558h:imm64]         encoding(10 bytes) = 48 b8 58 45 44 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b64iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x58,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long pow_g64i(long b, uint exp)
; location: [7FFDDBAC57D0h, 7FFDDBAC57DFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDB444558h            ; CALL(Call_rel32_64) [FFFFFFFFFF97ED88h:jmp64]        encoding(5 bytes) = e8 7e ed 97 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g64iBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x7E,0xED,0x97,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_b64u(ulong b, uint exp)
; location: [7FFDDBAC5800h, 7FFDDBAC580Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDB444560h         ; MOV(Mov_r64_imm64) [RAX,7ffddb444560h:imm64]         encoding(10 bytes) = 48 b8 60 45 44 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> pow_b64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x60,0x45,0x44,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow_g64u(ulong b, uint exp)
; location: [7FFDDBAC5830h, 7FFDDBAC583Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDDB444560h            ; CALL(Call_rel32_64) [FFFFFFFFFF97ED30h:jmp64]        encoding(5 bytes) = e8 26 ed 97 ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow_g64uBytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x26,0xED,0x97,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_b8i(sbyte lhs, int offset)
; location: [7FFDDBAC5860h, 7FFDDBAC5871h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sar_g8i(sbyte lhs, int offset)
; location: [7FFDDBAC5890h, 7FFDDBAC58A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_b8u(byte lhs, int offset)
; location: [7FFDDBAC58C0h, 7FFDDBAC58CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sar_g8u(byte lhs, int offset)
; location: [7FFDDBAC58E0h, 7FFDDBAC58EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_b16i(short lhs, int offset)
; location: [7FFDDBAC5900h, 7FFDDBAC5911h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sar_g16i(short lhs, int offset)
; location: [7FFDDBAC5930h, 7FFDDBAC5941h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xF8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_b16u(ushort lhs, int offset)
; location: [7FFDDBAC5960h, 7FFDDBAC596Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sar_g16u(ushort lhs, int offset)
; location: [7FFDDBAC5980h, 7FFDDBAC598Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xF8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_b32i(int lhs, int offset)
; location: [7FFDDBAC59A0h, 7FFDDBAC59ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sar_g32i(int lhs, int offset)
; location: [7FFDDBAC5DD0h, 7FFDDBAC5DDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_b32u(uint lhs, int offset)
; location: [7FFDDBAC5DF0h, 7FFDDBAC5DFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sar_g32u(uint lhs, int offset)
; location: [7FFDDBAC5E10h, 7FFDDBAC5E1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_b64i(long lhs, int offset)
; location: [7FFDDBAC5E30h, 7FFDDBAC5E3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sar_g64i(long lhs, int offset)
; location: [7FFDDBAC5E50h, 7FFDDBAC5E5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah sar rax,cl                    ; SAR(Sar_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 f8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_b64u(ulong lhs, int offset)
; location: [7FFDDBAC5E70h, 7FFDDBAC5E7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_b64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sar_g64u(ulong lhs, int offset)
; location: [7FFDDBAC5E90h, 7FFDDBAC5E9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sar_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select_1(ulong a, ulong b, ulong c)
; location: [7FFDDBAC5EB0h, 7FFDDBAC5EC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h andn rax,rcx,r8               ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f0 f2 c0
000dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_1Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0xC4,0xC2,0xF0,0xF2,0xC0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select_2(ulong a, ulong b, ulong c)
; location: [7FFDDBAC5EE0h, 7FFDDBAC5EF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_2Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xD0,0x48,0x23,0xD1,0x49,0x33,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d8i(sbyte x)
; location: [7FFDDBAC5F10h, 7FFDDBAC5F27h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC5F40h, 7FFDDBAC5F57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000fh shr edx,1Fh                   ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d8u(byte x)
; location: [7FFDDBAC5F70h, 7FFDDBAC5F85h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 07
0009h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000eh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 05
0010h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g8u(byte x)
; location: [7FFDDBAC5FA0h, 7FFDDBAC5FB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 07
000ch mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
0011h jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 05
0013h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16i(short x)
; location: [7FFDDBAC5FD0h, 7FFDDBAC5FE7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6000h, 7FFDDBAC6017h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000bh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000dh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
000fh shr edx,1Fh                   ; SHR(Shr_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 ea 1f
0012h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0015h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC2,0xC1,0xEA,0x1F,0xC1,0xF8,0x1F,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d16u(ushort x)
; location: [7FFDDBAC6030h, 7FFDDBAC6048h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 07
000ch mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
0011h jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 05
0013h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g16u(ushort x)
; location: [7FFDDBAC6060h, 7FFDDBAC6078h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 07
000ch mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
0011h jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 05
0013h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32i(int x)
; location: [7FFDDBAC6090h, 7FFDDBAC60A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC60C0h, 7FFDDBAC60E5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+4],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX]          encoding(4 bytes) = 89 4c 24 04
0009h mov rax,[rsp+4]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 04
000eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0011h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0014h inc rdx                       ; INC(Inc_rm64) [RDX]                                  encoding(3 bytes) = 48 ff c2
0017h shr rdx,3Fh                   ; SHR(Shr_rm64_imm8) [RDX,3fh:imm8]                    encoding(4 bytes) = 48 c1 ea 3f
001bh sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
001fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0021h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g32iBytes => new byte[38]{0x50,0x0F,0x1F,0x40,0x00,0x89,0x4C,0x24,0x04,0x48,0x8B,0x44,0x24,0x04,0x48,0x8B,0xD0,0x48,0xF7,0xD2,0x48,0xFF,0xC2,0x48,0xC1,0xEA,0x3F,0x48,0xC1,0xF8,0x3F,0x0B,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d32u(uint x)
; location: [7FFDDBAC6100h, 7FFDDBAC6115h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 07
0009h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000eh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 05
0010h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g32u(uint x)
; location: [7FFDDBAC6130h, 7FFDDBAC6145h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 07
0009h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000eh jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 05
0010h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64i(long x)
; location: [7FFDDBAC6160h, 7FFDDBAC617Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6190h, 7FFDDBAC61AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh shr rax,3Fh                   ; SHR(Shr_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 e8 3f
0012h sar rcx,3Fh                   ; SAR(Sar_rm64_imm8) [RCX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f9 3f
0016h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0xC1,0xE8,0x3F,0x48,0xC1,0xF9,0x3F,0x8B,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_d64u(ulong x)
; location: [7FFDDBAC61C0h, 7FFDDBAC61D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h jne short 0011h               ; JNE(Jne_rel8_64) [11h:jmp64]                         encoding(2 bytes) = 75 07
000ah mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000fh jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 05
0011h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_d64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Sign:int signum_g64u(ulong x)
; location: [7FFDDBAC61F0h, 7FFDDBAC6206h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h jne short 0011h               ; JNE(Jne_rel8_64) [11h:jmp64]                         encoding(2 bytes) = 75 07
000ah mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000fh jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 05
0011h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> signum_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x07,0xB8,0xFF,0xFF,0xFF,0xFF,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_d8i(sbyte x)
; location: [7FFDDBAC6220h, 7FFDDBAC6230h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte square_g8i(sbyte x)
; location: [7FFDDBAC6250h, 7FFDDBAC6260h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g8iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_d8u(byte x)
; location: [7FFDDBAC6280h, 7FFDDBAC628Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte square_g8u(byte x)
; location: [7FFDDBAC62A0h, 7FFDDBAC62AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xAF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_d16i(short x)
; location: [7FFDDBAC62C0h, 7FFDDBAC62D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short square_g16i(short x)
; location: [7FFDDBAC62F0h, 7FFDDBAC6300h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000ch movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g16iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xAF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_d16u(ushort x)
; location: [7FFDDBAC6320h, 7FFDDBAC632Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort square_g16u(ushort x)
; location: [7FFDDBAC6750h, 7FFDDBAC675Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h imul eax,eax                  ; IMUL(Imul_r32_rm32) [EAX,EAX]                        encoding(3 bytes) = 0f af c0
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g16uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xAF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_d32i(int x)
; location: [7FFDDBAC6770h, 7FFDDBAC677Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int square_g32i(int x)
; location: [7FFDDBAC6790h, 7FFDDBAC679Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_d32u(uint x)
; location: [7FFDDBAC67B0h, 7FFDDBAC67BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,ecx                  ; IMUL(Imul_r32_rm32) [EAX,ECX]                        encoding(3 bytes) = 0f af c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint square_g32u(uint x)
; location: [7FFDDBAC67D0h, 7FFDDBAC67DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul ecx,ecx                  ; IMUL(Imul_r32_rm32) [ECX,ECX]                        encoding(3 bytes) = 0f af c9
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> square_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g64i(long lhs, long rhs)
; location: [7FFDDBAC67F0h, 7FFDDBAC67FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC6810h, 7FFDDBAC681Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC6830h, 7FFDDBAC683Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte max_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC6850h, 7FFDDBAC6867h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6880h, 7FFDDBAC689Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jg short 0017h                ; JG(Jg_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7f 02
0015h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 02
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g8iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte max_d8u(byte lhs, byte rhs)
; location: [7FFDDBAC68B0h, 7FFDDBAC68C5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC68E0h, 7FFDDBAC68F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jg short 0014h                ; JG(Jg_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7f 02
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0016h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g8uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short max_d16i(short lhs, short rhs)
; location: [7FFDDBAC6910h, 7FFDDBAC6927h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6940h, 7FFDDBAC695Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h jg short 0017h                ; JG(Jg_rel8_64) [17h:jmp64]                           encoding(2 bytes) = 7f 02
0015h jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 02
0017h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g16iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort max_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC6970h, 7FFDDBAC6985h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC69A0h, 7FFDDBAC69B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h jg short 0014h                ; JG(Jg_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7f 02
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0016h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g16uBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x7F,0x02,0xEB,0x02,0x8B,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max_d32i(int lhs, int rhs)
; location: [7FFDDBAC69D0h, 7FFDDBAC69DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jg short 000bh                ; JG(Jg_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7f 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int max_g32i(int lhs, int rhs)
; location: [7FFDDBAC69F0h, 7FFDDBAC69FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jg short 000bh                ; JG(Jg_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7f 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7F,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC6A10h, 7FFDDBAC6A1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 000bh                ; JA(Ja_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 77 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint max_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC6A30h, 7FFDDBAC6A3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h ja short 000bh                ; JA(Ja_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 77 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x77,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max_d64i(long lhs, long rhs)
; location: [7FFDDBAC6A50h, 7FFDDBAC6A62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jg short 000ch                ; JG(Jg_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7f 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long max_g64i(long lhs, long rhs)
; location: [7FFDDBAC6A80h, 7FFDDBAC6A92h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jg short 000ch                ; JG(Jg_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7f 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7F,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC6AB0h, 7FFDDBAC6AC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 000ch                ; JA(Ja_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 77 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_d64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong max_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC6AE0h, 7FFDDBAC6AF2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h ja short 000ch                ; JA(Ja_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 77 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> max_g64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x77,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte min_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC6B10h, 7FFDDBAC6B27h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6B40h, 7FFDDBAC6B5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6B70h, 7FFDDBAC6B85h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6BA0h, 7FFDDBAC6BB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC6BD0h, 7FFDDBAC6BE7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC7000h, 7FFDDBAC701Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC7030h, 7FFDDBAC7045h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC7060h, 7FFDDBAC7078h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC7090h, 7FFDDBAC709Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int min_g32i(int lhs, int rhs)
; location: [7FFDDBAC70B0h, 7FFDDBAC70BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC70D0h, 7FFDDBAC70DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 000bh                ; JB(Jb_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 72 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint min_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC70F0h, 7FFDDBAC70FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 000bh                ; JB(Jb_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 72 02
0009h jmp short 000dh               ; JMP(Jmp_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = eb 02
000bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000dh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x02,0xEB,0x02,0x8B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min_d64i(long lhs, long rhs)
; location: [7FFDDBAC7110h, 7FFDDBAC7122h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 000ch                ; JL(Jl_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7c 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long min_g64i(long lhs, long rhs)
; location: [7FFDDBAC7140h, 7FFDDBAC7152h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 000ch                ; JL(Jl_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 7c 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC7170h, 7FFDDBAC7182h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 000ch                ; JB(Jb_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 72 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_d64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong min_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC71A0h, 7FFDDBAC71B2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 000ch                ; JB(Jb_rel8_64) [Ch:jmp64]                            encoding(2 bytes) = 72 02
000ah jmp short 000fh               ; JMP(Jmp_rel8_64) [Fh:jmp64]                          encoding(2 bytes) = eb 03
000ch mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> min_g64uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x02,0xEB,0x03,0x48,0x8B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_n8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC71D0h, 7FFDDBAC71E4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_n8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC7200h, 7FFDDBAC7214h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mod_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC7230h, 7FFDDBAC7248h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC7260h, 7FFDDBAC7271h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_n8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_d8u(byte lhs, byte rhs)
; location: [7FFDDBAC7290h, 7FFDDBAC72A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mod_g8u(byte lhs, byte rhs)
; location: [7FFDDBAC72C0h, 7FFDDBAC72D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC72F0h, 7FFDDBAC7304h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mod_g16i(short lhs, short rhs)
; location: [7FFDDBAC7320h, 7FFDDBAC7338h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC7350h, 7FFDDBAC7361h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mod_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC7380h, 7FFDDBAC7394h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000fh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0011h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x0F,0xB7,0xC0,0x99,0xF7,0xF9,0x0F,0xB7,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_d32i(int lhs, int rhs)
; location: [7FFDDBAC73B0h, 7FFDDBAC73C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod_g32i(int lhs, int rhs)
; location: [7FFDDBAC73E0h, 7FFDDBAC73F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC7410h, 7FFDDBAC7421h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC7440h, 7FFDDBAC7451h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod_d64i(long lhs, long rhs)
; location: [7FFDDBAC7470h, 7FFDDBAC7483h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mod_g64i(long lhs, long rhs)
; location: [7FFDDBAC74A0h, 7FFDDBAC74B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC74D0h, 7FFDDBAC74E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mod_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC7500h, 7FFDDBAC7513h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_d32f(float lhs, float rhs)
; location: [7FFDDBAC7530h, 7FFDDBAC7541h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B050790h            ; CALL(Call_rel32_64) [5F589260h:jmp64]                encoding(5 bytes) = e8 54 92 58 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x54,0x92,0x58,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float mod_g32f(float lhs, float rhs)
; location: [7FFDDBAC7560h, 7FFDDBAC7571h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B050790h            ; CALL(Call_rel32_64) [5F589230h:jmp64]                encoding(5 bytes) = e8 24 92 58 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g32fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x24,0x92,0x58,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_d64f(double lhs, double rhs)
; location: [7FFDDBAC7590h, 7FFDDBAC75A1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B050700h            ; CALL(Call_rel32_64) [5F589170h:jmp64]                encoding(5 bytes) = e8 64 91 58 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_d64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x64,0x91,0x58,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double mod_g64f(double lhs, double rhs)
; location: [7FFDDBAC79C0h, 7FFDDBAC79D1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h call 7FFE3B050700h            ; CALL(Call_rel32_64) [5F588D40h:jmp64]                encoding(5 bytes) = e8 34 8d 58 5f
000ch nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_g64fBytes => new byte[18]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xE8,0x34,0x8D,0x58,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_u128(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<Pair<ulong>> dst)
; location: [7FFDDBAC79F0h, 7FFDDBAC7A5Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 49 08
000bh mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
000eh mov r10d,[rdx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RDX:br,:sr)]         encoding(4 bytes) = 44 8b 52 08
0012h mov r11,[r8]                  ; MOV(Mov_r64_rm64) [R11,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 18
0015h mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 45 8b 40 08
0019h cmp ecx,r10d                  ; CMP(Cmp_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 3b ca
001ch jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c 02
001eh jmp short 0023h               ; JMP(Jmp_rel8_64) [23h:jmp64]                         encoding(2 bytes) = eb 03
0020h mov r10d,ecx                  ; MOV(Mov_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 8b d1
0023h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
0026h jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c 02
0028h jmp short 002dh               ; JMP(Jmp_rel8_64) [2Dh:jmp64]                         encoding(2 bytes) = eb 03
002ah mov r8d,r10d                  ; MOV(Mov_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 8b c2
002dh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
002fh test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0032h jle short 0068h               ; JLE(Jle_rel8_64) [68h:jmp64]                         encoding(2 bytes) = 7e 34
0034h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0037h lea rdx,[rax+rdx*8]           ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 14 d0
003bh movsxd r10,ecx                ; MOVSXD(Movsxd_r64_rm32) [R10,ECX]                    encoding(3 bytes) = 4c 63 d1
003eh lea r10,[r9+r10*8]            ; LEA(Lea_r64_m) [R10,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 4f 8d 14 d1
0042h movsxd rsi,ecx                ; MOVSXD(Movsxd_r64_rm32) [RSI,ECX]                    encoding(3 bytes) = 48 63 f1
0045h shl rsi,4                     ; SHL(Shl_rm64_imm8) [RSI,4h:imm8]                     encoding(4 bytes) = 48 c1 e6 04
0049h add rsi,r11                   ; ADD(Add_r64_rm64) [RSI,R11]                          encoding(3 bytes) = 49 03 f3
004ch mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
004fh mov r10,[r10]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,R10:br,:sr)]          encoding(3 bytes) = 4d 8b 12
0052h mov rdi,rsi                   ; MOV(Mov_r64_rm64) [RDI,RSI]                          encoding(3 bytes) = 48 8b fe
0055h mulx rdx,rbx,r10              ; MULX(VEX_Mulx_r64_r64_rm64) [RDX,RBX,R10]            encoding(VEX, 5 bytes) = c4 c2 e3 f6 d2
005ah mov [rdi],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX]          encoding(3 bytes) = 48 89 1f
005dh mov [rsi+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RDX]          encoding(4 bytes) = 48 89 56 08
0061h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0063h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0066h jl short 0034h                ; JL(Jl_rel8_64) [34h:jmp64]                           encoding(2 bytes) = 7c cc
0068h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_u128Bytes => new byte[108]{0x57,0x56,0x53,0x66,0x90,0x48,0x8B,0x01,0x8B,0x49,0x08,0x4C,0x8B,0x0A,0x44,0x8B,0x52,0x08,0x4D,0x8B,0x18,0x45,0x8B,0x40,0x08,0x41,0x3B,0xCA,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xD1,0x45,0x3B,0xD0,0x7C,0x02,0xEB,0x03,0x45,0x8B,0xC2,0x33,0xC9,0x45,0x85,0xC0,0x7E,0x34,0x48,0x63,0xD1,0x48,0x8D,0x14,0xD0,0x4C,0x63,0xD1,0x4F,0x8D,0x14,0xD1,0x48,0x63,0xF1,0x48,0xC1,0xE6,0x04,0x49,0x03,0xF3,0x48,0x8B,0x12,0x4D,0x8B,0x12,0x48,0x8B,0xFE,0xC4,0xC2,0xE3,0xF6,0xD2,0x48,0x89,0x1F,0x48,0x89,0x56,0x08,0xFF,0xC1,0x41,0x3B,0xC8,0x7C,0xCC,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC7A80h, 7FFDDBAC7A94h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte mul_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBAC7EB0h, 7FFDDBAC7EC8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0014h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g8iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x0F,0xAF,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_d8u(byte lhs, byte rhs)
; location: [7FFDDBAC7EE0h, 7FFDDBAC7EF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte mul_g8u(byte lhs, byte rhs)
; location: [7FFDDBAC7F10h, 7FFDDBAC7F24h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_d16i(short lhs, short rhs)
; location: [7FFDDBAC7F40h, 7FFDDBAC7F54h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short mul_g16i(short lhs, short rhs)
; location: [7FFDDBAC7F70h, 7FFDDBAC7F88h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0014h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x0F,0xAF,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC7FA0h, 7FFDDBAC7FB1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort mul_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBAC7FD0h, 7FFDDBAC7FE4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g16uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x0F,0xAF,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_d32i(int lhs, int rhs)
; location: [7FFDDBAC8000h, 7FFDDBAC800Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul_g32i(int lhs, int rhs)
; location: [7FFDDBAC8020h, 7FFDDBAC802Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_d32u(uint lhs, uint rhs)
; location: [7FFDDBAC8040h, 7FFDDBAC804Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_g32u(uint lhs, uint rhs)
; location: [7FFDDBAC8060h, 7FFDDBAC806Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_d64i(long lhs, long rhs)
; location: [7FFDDBAC8080h, 7FFDDBAC808Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long mul_g64i(long lhs, long rhs)
; location: [7FFDDBAC80A0h, 7FFDDBAC80ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC80C0h, 7FFDDBAC80CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBAC80E0h, 7FFDDBAC80ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_d8i(sbyte x)
; location: [7FFDDBAC8100h, 7FFDDBAC810Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte negate_g8i(sbyte x)
; location: [7FFDDBAC8120h, 7FFDDBAC812Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_d8u(byte x)
; location: [7FFDDBAC8140h, 7FFDDBAC814Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte negate_g8u(byte x)
; location: [7FFDDBAC8160h, 7FFDDBAC816Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_d16i(short x)
; location: [7FFDDBAC8180h, 7FFDDBAC818Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short negate_g16i(short x)
; location: [7FFDDBAC81A0h, 7FFDDBAC81AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_d16u(ushort x)
; location: [7FFDDBAC81C0h, 7FFDDBAC81CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort negate_g16u(ushort x)
; location: [7FFDDBAC81E0h, 7FFDDBAC81EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_d32i(int x)
; location: [7FFDDBAC8200h, 7FFDDBAC8209h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int negate_g32i(int x)
; location: [7FFDDBAC8220h, 7FFDDBAC8229h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_d32u(uint x)
; location: [7FFDDBAC8240h, 7FFDDBAC824Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint negate_g32u(uint x)
; location: [7FFDDBAC8260h, 7FFDDBAC826Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_d64i(long x)
; location: [7FFDDBAC8280h, 7FFDDBAC828Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long negate_g64i(long x)
; location: [7FFDDBAC82A0h, 7FFDDBAC82ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h neg rax                       ; NEG(Neg_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_d64u(ulong x)
; location: [7FFDDBAC82C0h, 7FFDDBAC82CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong negate_g64u(ulong x)
; location: [7FFDDBAC82E0h, 7FFDDBAC82EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_g32f(float x)
; location: [7FFDDBAC8300h, 7FFDDBAC8311h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBAC8318h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float negate_d32f(float x)
; location: [7FFDDBAC8330h, 7FFDDBAC8341h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm1,dword ptr [7FFDDBAC8348h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_d64f(double x)
; location: [7FFDDBAC8360h, 7FFDDBAC8371h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBAC8378h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_d64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double negate_g64f(double x)
; location: [7FFDDBAC87A0h, 7FFDDBAC87B1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm1,qword ptr [7FFDDBAC87B8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d 0b 00 00 00
000dh vxorps xmm0,xmm0,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f8 57 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x0D,0x0B,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d8i(sbyte x)
; location: [7FFDDBAC87D0h, 7FFDDBAC87EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d8iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g8i(sbyte x)
; location: [7FFDDBAC8800h, 7FFDDBAC881Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g8iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d16i(short x)
; location: [7FFDDBAC8830h, 7FFDDBAC884Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g16i(short x)
; location: [7FFDDBAC8860h, 7FFDDBAC887Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0014h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32i(int x)
; location: [7FFDDBAC8890h, 7FFDDBAC88A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32i(int x)
; location: [7FFDDBAC88C0h, 7FFDDBAC88D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64i(long x)
; location: [7FFDDBAC88F0h, 7FFDDBAC8907h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d64iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64i(long x)
; location: [7FFDDBAC8920h, 7FFDDBAC8937h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0011h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g64iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d32f(float x)
; location: [7FFDDBAC8950h, 7FFDDBAC896Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d32fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g32f(float x)
; location: [7FFDDBAC8980h, 7FFDDBAC899Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomiss xmm1,xmm0            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f8 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g32fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_d64f(double x)
; location: [7FFDDBAC89B0h, 7FFDDBAC89CCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_d64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool negative_g64f(double x)
; location: [7FFDDBAC89E0h, 7FFDDBAC89FCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0009h vucomisd xmm1,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e c8
000dh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negative_g64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC8,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d8i(sbyte x)
; location: [7FFDDBAC8A10h, 7FFDDBAC8A24h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX]          encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g8i(sbyte x)
; location: [7FFDDBAC8A40h, 7FFDDBAC8A51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d8u(byte x)
; location: [7FFDDBAC8A70h, 7FFDDBAC8A84h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX]          encoding(4 bytes) = 89 4c 24 08
0009h cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = 80 7c 24 08 00
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d8uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g8u(byte x)
; location: [7FFDDBAC8AA0h, 7FFDDBAC8AB0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d16i(short x)
; location: [7FFDDBAC8AD0h, 7FFDDBAC8AE5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX]          encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0        ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,:sr),0h:imm16]    encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g16i(short x)
; location: [7FFDDBAC8B00h, 7FFDDBAC8B11h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d16u(ushort x)
; location: [7FFDDBAC8B30h, 7FFDDBAC8B45h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),ECX]          encoding(4 bytes) = 89 4c 24 08
0009h cmp word ptr [rsp+8],0        ; CMP(Cmp_rm16_imm8) [mem(16u,RSP:br,:sr),0h:imm16]    encoding(6 bytes) = 66 83 7c 24 08 00
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x66,0x83,0x7C,0x24,0x08,0x00,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g16u(ushort x)
; location: [7FFDDBAC8B60h, 7FFDDBAC8B70h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d32i(int x)
; location: [7FFDDBAC8B90h, 7FFDDBAC8B9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g32i(int x)
; location: [7FFDDBAC8BB0h, 7FFDDBAC8BBDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d32u(uint x)
; location: [7FFDDBAC8BD0h, 7FFDDBAC8BDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g32u(uint x)
; location: [7FFDDBAC8BF0h, 7FFDDBAC8BFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_d64i(long x)
; location: [7FFDDBAC8C10h, 7FFDDBAC8C1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g64i(long x)
; location: [7FFDDBAC8C30h, 7FFDDBAC8C3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool nonzero_n64u(ulong x)
; location: [7FFDDBAC8C50h, 7FFDDBAC8C5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_n64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit nonzero_g64u(ulong x)
; location: [7FFDDBAC8C70h, 7FFDDBAC8C7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nonzero_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte not_d8i(sbyte x)
; location: [7FFDDBAC8C90h, 7FFDDBAC8C9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte not_g8i(sbyte x)
; location: [7FFDDBAC8CB0h, 7FFDDBAC8CBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF7,0xD0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte not_d8u(byte x)
; location: [7FFDDBAC8CD0h, 7FFDDBAC8CDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte not_g8u(byte x)
; location: [7FFDDBAC8CF0h, 7FFDDBAC8CFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short not_d16i(short x)
; location: [7FFDDBAC8D10h, 7FFDDBAC8D1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short not_g16i(short x)
; location: [7FFDDBAC8D30h, 7FFDDBAC8D3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_g16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF7,0xD0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g32i(int x)
; location: [7FFDDBAC8D50h, 7FFDDBAC8D63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g32iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d32u(uint x)
; location: [7FFDDBAC8D80h, 7FFDDBAC8D8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g32u(uint x)
; location: [7FFDDBAC8DA0h, 7FFDDBAC8DB3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g32uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d64i(long x)
; location: [7FFDDBAC8DD0h, 7FFDDBAC8DDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0009h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g64i(long x)
; location: [7FFDDBAC9200h, 7FFDDBAC9213h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d64u(ulong x)
; location: [7FFDDBAC9230h, 7FFDDBAC923Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
0009h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g64u(ulong x)
; location: [7FFDDBAC9250h, 7FFDDBAC9263h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d8i(sbyte x)
; location: [7FFDDBAC9280h, 7FFDDBAC9291h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g8i(sbyte x)
; location: [7FFDDBAC92B0h, 7FFDDBAC92C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d8u(byte x)
; location: [7FFDDBAC92E0h, 7FFDDBAC92F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g8u(byte x)
; location: [7FFDDBAC9310h, 7FFDDBAC9320h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d16i(short x)
; location: [7FFDDBAC9340h, 7FFDDBAC9351h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g16i(short x)
; location: [7FFDDBAC9370h, 7FFDDBAC9381h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d16u(ushort x)
; location: [7FFDDBAC93A0h, 7FFDDBAC93B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g16u(ushort x)
; location: [7FFDDBAC93D0h, 7FFDDBAC93E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d32i(int x)
; location: [7FFDDBAC9400h, 7FFDDBAC940Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g32i(int x)
; location: [7FFDDBAC9420h, 7FFDDBAC942Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d32u(uint x)
; location: [7FFDDBAC9440h, 7FFDDBAC944Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g32u(uint x)
; location: [7FFDDBAC9460h, 7FFDDBAC946Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d64i(long x)
; location: [7FFDDBAC9480h, 7FFDDBAC948Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g64i(long x)
; location: [7FFDDBAC94A0h, 7FFDDBAC94AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_d64u(ulong x)
; location: [7FFDDBAC94C0h, 7FFDDBAC94CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit odd_g64u(ulong x)
; location: [7FFDDBAC94E0h, 7FFDDBAC94EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> odd_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte fma_d8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDDBAC9500h, 7FFDDBAC951Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC9530h, 7FFDDBAC9552h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC9570h, 7FFDDBAC9587h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC95A0h, 7FFDDBAC95BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC95D0h, 7FFDDBAC95EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC9600h, 7FFDDBAC9622h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC9640h, 7FFDDBAC9657h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC9670h, 7FFDDBAC968Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBAC96A0h, 7FFDDBAC96ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int fma_g32i(int x, int a, int b)
; location: [7FFDDBAC96C0h, 7FFDDBAC96CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_d32u(uint x, uint a, uint b)
; location: [7FFDDBAC96E0h, 7FFDDBAC96EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ah add eax,r8d                   ; ADD(Add_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 03 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xAF,0xC2,0x41,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint fma_g32u(uint x, uint a, uint b)
; location: [7FFDDBAC9700h, 7FFDDBAC970Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
000bh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x41,0x03,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_d64i(long x, long a, long b)
; location: [7FFDDBAC9720h, 7FFDDBAC972Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long fma_g64i(long x, long a, long b)
; location: [7FFDDBAC9740h, 7FFDDBAC974Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_d64u(ulong x, ulong a, ulong b)
; location: [7FFDDBAC9760h, 7FFDDBAC976Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0x49,0x03,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong fma_g64u(ulong x, ulong a, ulong b)
; location: [7FFDDBAC9780h, 7FFDDBAC978Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0009h add rdx,r8                    ; ADD(Add_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 03 d0
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x49,0x03,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_d32f(float x, float a, float b)
; location: [7FFDDBAC9910h, 7FFDDBAC991Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2    ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float fma_g32f(float x, float a, float b)
; location: [7FFDDBAC9930h, 7FFDDBAC993Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213ss xmm0,xmm1,xmm2    ; VFMADD213SS(VEX_Vfmadd213ss_xmm_xmm_xmmm32) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g32fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0x71,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_d64f(double x, double a, double b)
; location: [7FFDDBAC9950h, 7FFDDBAC995Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2    ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_d64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double fma_g64f(double x, double a, double b)
; location: [7FFDDBAC9970h, 7FFDDBAC997Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vfmadd213sd xmm0,xmm1,xmm2    ; VFMADD213SD(VEX_Vfmadd213sd_xmm_xmm_xmmm64) [XMM0,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 f1 a9 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fma_g64fBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE2,0xF1,0xA9,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d8i(sbyte a, sbyte b)
; location: [7FFDDBAC9990h, 7FFDDBAC99A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g8i(sbyte a, sbyte b)
; location: [7FFDDBAC9DC0h, 7FFDDBAC9DD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d8u(byte a, byte b)
; location: [7FFDDBAC9DF0h, 7FFDDBAC9E03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g8u(byte a, byte b)
; location: [7FFDDBAC9E20h, 7FFDDBAC9E36h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d16i(short a, short b)
; location: [7FFDDBAC9E50h, 7FFDDBAC9E65h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g16i(short a, short b)
; location: [7FFDDBAC9E80h, 7FFDDBAC9E99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d16u(ushort a, ushort b)
; location: [7FFDDBAC9EB0h, 7FFDDBAC9EC3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g16u(ushort a, ushort b)
; location: [7FFDDBAC9EE0h, 7FFDDBAC9EF6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d32i(int a, int b)
; location: [7FFDDBAC9F10h, 7FFDDBAC9F1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g32i(int a, int b)
; location: [7FFDDBAC9F30h, 7FFDDBAC9F3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d32u(uint a, uint b)
; location: [7FFDDBAC9F50h, 7FFDDBAC9F5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g32u(uint a, uint b)
; location: [7FFDDBAC9F70h, 7FFDDBAC9F7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d64i(long a, long b)
; location: [7FFDDBAC9F90h, 7FFDDBAC9F9Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g64i(long a, long b)
; location: [7FFDDBAC9FB0h, 7FFDDBAC9FBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setg al                       ; SETG(Setg_rm8) [AL]                                  encoding(3 bytes) = 0f 9f c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9F,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d64u(ulong a, ulong b)
; location: [7FFDDBAC9FD0h, 7FFDDBAC9FDEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g64u(ulong a, ulong b)
; location: [7FFDDBAC9FF0h, 7FFDDBAC9FFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d32f(float a, float b)
; location: [7FFDDBACA010h, 7FFDDBACA01Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g32f(float a, float b)
; location: [7FFDDBACA040h, 7FFDDBACA04Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_d64f(double a, double b)
; location: [7FFDDBACA070h, 7FFDDBACA07Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gt_g64f(double a, double b)
; location: [7FFDDBACA0A0h, 7FFDDBACA0AFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gt_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d8i(sbyte a, sbyte b)
; location: [7FFDDBACA0D0h, 7FFDDBACA0E5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g8i(sbyte a, sbyte b)
; location: [7FFDDBACA100h, 7FFDDBACA119h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d8u(byte a, byte b)
; location: [7FFDDBACA130h, 7FFDDBACA143h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g8u(byte a, byte b)
; location: [7FFDDBACA160h, 7FFDDBACA176h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d16i(short a, short b)
; location: [7FFDDBACA190h, 7FFDDBACA1A5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g16i(short a, short b)
; location: [7FFDDBACA1C0h, 7FFDDBACA1D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d16u(ushort a, ushort b)
; location: [7FFDDBACA1F0h, 7FFDDBACA203h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g16u(ushort a, ushort b)
; location: [7FFDDBACA220h, 7FFDDBACA236h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d32i(int a, int b)
; location: [7FFDDBACA250h, 7FFDDBACA25Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d64i(long a, long b)
; location: [7FFDDBACA2D0h, 7FFDDBACA2DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g64i(long a, long b)
; location: [7FFDDBACA2F0h, 7FFDDBACA2FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setge al                      ; SETGE(Setge_rm8) [AL]                                encoding(3 bytes) = 0f 9d c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9D,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d64u(ulong a, ulong b)
; location: [7FFE3925D1D0h, 7FFE3925D1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE38E7F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,:sr)]        encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64uBytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g64u(ulong a, ulong b)
; location: [7FFDDBACA330h, 7FFDDBACA33Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d32f(float a, float b)
; location: [7FFDDBACA350h, 7FFDDBACA35Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g32f(float a, float b)
; location: [7FFDDBACA380h, 7FFDDBACA38Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g32fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_d64f(double a, double b)
; location: [7FFDDBACA3B0h, 7FFDDBACA3BFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_d64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_g64f(double a, double b)
; location: [7FFDDBACA3E0h, 7FFDDBACA3EFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0009h setae al                      ; SETAE(Setae_rm8) [AL]                                encoding(3 bytes) = 0f 93 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_g64fBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x2E,0xC1,0x0F,0x93,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_d8i(sbyte x)
; location: [7FFDDBACA410h, 7FFDDBACA41Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte inc_g8i(sbyte x)
; location: [7FFDDBACA430h, 7FFDDBACA443h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_d8u(byte x)
; location: [7FFDDBACA460h, 7FFDDBACA46Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte inc_g8u(byte x)
; location: [7FFDDBACA890h, 7FFDDBACA8A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_d16i(short x)
; location: [7FFDDBACA8C0h, 7FFDDBACA8CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short inc_g16i(short x)
; location: [7FFDDBACA8E0h, 7FFDDBACA8F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC0,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_d16u(ushort x)
; location: [7FFDDBACA910h, 7FFDDBACA91Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort inc_g16u(ushort x)
; location: [7FFDDBACA930h, 7FFDDBACA940h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_d32i(int x)
; location: [7FFDDBACA960h, 7FFDDBACA968h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int inc_g32i(int x)
; location: [7FFDDBACA980h, 7FFDDBACA989h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_d32u(uint x)
; location: [7FFDDBACA9A0h, 7FFDDBACA9A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint inc_g32u(uint x)
; location: [7FFDDBACA9C0h, 7FFDDBACA9C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_d64i(long x)
; location: [7FFDDBACA9E0h, 7FFDDBACA9E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long inc_g64i(long x)
; location: [7FFDDBACAA00h, 7FFDDBACAA0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                       ; INC(Inc_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_d64u(ulong x)
; location: [7FFDDBACAA20h, 7FFDDBACAA29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong inc_g64u(ulong x)
; location: [7FFDDBACAA40h, 7FFDDBACAA4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc rcx                       ; INC(Inc_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC1,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACAA60h, 7FFDDBACAA75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACAA90h, 7FFDDBACAAA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d8u(byte lhs, byte rhs)
; location: [7FFDDBACAAC0h, 7FFDDBACAAD3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g8u(byte lhs, byte rhs)
; location: [7FFDDBACAAF0h, 7FFDDBACAB06h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d16i(short lhs, short rhs)
; location: [7FFDDBACAB20h, 7FFDDBACAB35h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g16i(short lhs, short rhs)
; location: [7FFDDBACAB50h, 7FFDDBACAB69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACAB80h, 7FFDDBACAB93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACABB0h, 7FFDDBACABC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d32i(int lhs, int rhs)
; location: [7FFDDBACABE0h, 7FFDDBACABEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g32i(int lhs, int rhs)
; location: [7FFDDBACAC00h, 7FFDDBACAC0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d32u(uint lhs, uint rhs)
; location: [7FFDDBACAC20h, 7FFDDBACAC2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g32u(uint lhs, uint rhs)
; location: [7FFDDBACAC40h, 7FFDDBACAC4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d64i(long lhs, long rhs)
; location: [7FFDDBACAC60h, 7FFDDBACAC6Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g64i(long lhs, long rhs)
; location: [7FFDDBACAC80h, 7FFDDBACAC8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setl al                       ; SETL(Setl_rm8) [AL]                                  encoding(3 bytes) = 0f 9c c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACACA0h, 7FFDDBACACAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACACC0h, 7FFDDBACACCEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACACE0h, 7FFDDBACACF5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACAD10h, 7FFDDBACAD29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d8u(byte lhs, byte rhs)
; location: [7FFDDBACAD40h, 7FFDDBACAD53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g8u(byte lhs, byte rhs)
; location: [7FFDDBACAD70h, 7FFDDBACAD86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d16i(short lhs, short rhs)
; location: [7FFDDBACADA0h, 7FFDDBACADB5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g16i(short lhs, short rhs)
; location: [7FFDDBACADD0h, 7FFDDBACADE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACAE00h, 7FFDDBACAE13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACB230h, 7FFDDBACB246h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d32i(int lhs, int rhs)
; location: [7FFDDBACB260h, 7FFDDBACB26Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g32i(int lhs, int rhs)
; location: [7FFDDBACB280h, 7FFDDBACB28Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d32u(uint lhs, uint rhs)
; location: [7FFDDBACB2A0h, 7FFDDBACB2ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_g32u(uint lhs, uint rhs)
; location: [7FFDDBACB2C0h, 7FFDDBACB2CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lteq_d64i(long lhs, long rhs)
; location: [7FFDDBACB2E0h, 7FFDDBACB2EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lteq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_n32u()
; location: [7FFDDBACB300h, 7FFDDBACB30Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint maxval_g32u()
; location: [7FFDDBACB4C0h, 7FFDDBACB4CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFFFFh            ; MOV(Mov_r32_imm32) [EAX,ffffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long maxval_g64i()
; location: [7FFDDBACB8F0h, 7FFDDBACB8FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFFFFFFFFFFFFFFh     ; MOV(Mov_r64_imm64) [RAX,7fffffffffffffffh:imm64]     encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff 7f
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong maxval_g64u()
; location: [7FFDDBACB910h, 7FFDDBACB91Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFFFFFFFFFFh    ; MOV(Mov_r64_imm64) [RAX,ffffffffffffffffh:imm64]     encoding(10 bytes) = 48 b8 ff ff ff ff ff ff ff ff
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float maxval_g32f()
; location: [7FFDDBACB930h, 7FFDDBACB93Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBACB940h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_n64f()
; location: [7FFDDBACB960h, 7FFDDBACB96Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBACB970h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double maxval_g64f()
; location: [7FFDDBACB990h, 7FFDDBACB99Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBACB9A0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_d8i(sbyte x)
; location: [7FFDDBACB9C0h, 7FFDDBACB9CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d8iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte dec_g8i(sbyte x)
; location: [7FFDDBACB9E0h, 7FFDDBACB9F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xFF,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_d8u(byte x)
; location: [7FFDDBACBA10h, 7FFDDBACBA1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d8uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte dec_g8u(byte x)
; location: [7FFDDBACBA30h, 7FFDDBACBA40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_d16i(short x)
; location: [7FFDDBACBA60h, 7FFDDBACBA6Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d16iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short dec_g16i(short x)
; location: [7FFDDBACBA80h, 7FFDDBACBA93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xFF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_d16u(ushort x)
; location: [7FFDDBACBAB0h, 7FFDDBACBABDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d16uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort dec_g16u(ushort x)
; location: [7FFDDBACBAD0h, 7FFDDBACBAE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_d32i(int x)
; location: [7FFDDBACBB00h, 7FFDDBACBB08h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int dec_g32i(int x)
; location: [7FFDDBACBB20h, 7FFDDBACBB29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_d32u(uint x)
; location: [7FFDDBACBB40h, 7FFDDBACBB48h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dec_g32u(uint x)
; location: [7FFDDBACBB60h, 7FFDDBACBB69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_d64i(long x)
; location: [7FFDDBACBB80h, 7FFDDBACBB89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long dec_g64i(long x)
; location: [7FFDDBACBBA0h, 7FFDDBACBBABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_d64u(ulong x)
; location: [7FFDDBACBBC0h, 7FFDDBACBBC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dec_g64u(ulong x)
; location: [7FFDDBACBFF0h, 7FFDDBACBFFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0xC9,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong dist_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACC010h, 7FFDDBACC02Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC040h, 7FFDDBACC061h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC080h, 7FFDDBACC09Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC0B0h, 7FFDDBACC0CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC0E0h, 7FFDDBACC0FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC110h, 7FFDDBACC131h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC150h, 7FFDDBACC16Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC180h, 7FFDDBACC19Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC1B0h, 7FFDDBACC1C5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC1E0h, 7FFDDBACC1F5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC210h, 7FFDDBACC223h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC240h, 7FFDDBACC253h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC270h, 7FFDDBACC288h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC2A0h, 7FFDDBACC2B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC2D0h, 7FFDDBACC2E8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC300h, 7FFDDBACC318h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC330h, 7FFDDBACC344h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rcx,dl                  ; MOVSX(Movsx_r64_rm8) [RCX,DL]                        encoding(4 bytes) = 48 0f be ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte div_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACC360h, 7FFDDBACC378h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC390h, 7FFDDBACC3A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xCA,0x99,0xF7,0xF9,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte div_g8u(byte lhs, byte rhs)
; location: [7FFDDBACC3C0h, 7FFDDBACC3D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC3F0h, 7FFDDBACC404h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short div_g16i(short lhs, short rhs)
; location: [7FFDDBACC420h, 7FFDDBACC438h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rcx,dx                  ; MOVSX(Movsx_r64_rm16) [RCX,DX]                       encoding(4 bytes) = 48 0f bf ca
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0012h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0014h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g16iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xCA,0x48,0x0F,0xBF,0xC0,0x99,0xF7,0xF9,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACC450h, 7FFDDBACC461h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,dx                  ; MOVZX(Movzx_r32_rm16) [ECX,DX]                       encoding(3 bytes) = 0f b7 ca
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xCA,0x99,0xF7,0xF9,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort div_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACC480h, 7FFDDBACC494h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACC4B0h, 7FFDDBACC4BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div_g32i(int lhs, int rhs)
; location: [7FFDDBACC4D0h, 7FFDDBACC4DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r8d                      ; IDIV(Idiv_rm32) [R8D]                                encoding(3 bytes) = 41 f7 f8
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x99,0x41,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_d32u(uint lhs, uint rhs)
; location: [7FFDDBACC4F0h, 7FFDDBACC4FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_g32u(uint lhs, uint rhs)
; location: [7FFDDBACC510h, 7FFDDBACC51Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ch div r8d                       ; DIV(Div_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xC2,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_d64i(long lhs, long rhs)
; location: [7FFDDBACC530h, 7FFDDBACC540h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long div_g64i(long lhs, long rhs)
; location: [7FFDDBACC560h, 7FFDDBACC570h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r8                       ; IDIV(Idiv_rm64) [R8]                                 encoding(3 bytes) = 49 f7 f8
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xF8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACC590h, 7FFDDBACC5A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong div_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACC5C0h, 7FFDDBACC5D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xC2,0x48,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_d32f(float lhs, float rhs)
; location: [7FFDDBACC5F0h, 7FFDDBACC5F9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float div_g32f(float lhs, float rhs)
; location: [7FFDDBACCA20h, 7FFDDBACCA29h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivss xmm0,xmm0,xmm1         ; VDIVSS(VEX_Vdivss_xmm_xmm_xmmm32) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fa 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_d64f(double lhs, double rhs)
; location: [7FFDDBACCA40h, 7FFDDBACCA49h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_d64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double div_g64f(double lhs, double rhs)
; location: [7FFDDBACCA60h, 7FFDDBACCA69h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vdivsd xmm0,xmm0,xmm1         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM1]   encoding(VEX, 4 bytes) = c5 fb 5e c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5E,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACCA80h, 7FFDDBACCAA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0009h movsx rcx,cl                  ; MOVSX(Movsx_r64_rm8) [RCX,CL]                        encoding(4 bytes) = 48 0f be c9
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d8iBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC2,0x48,0x0F,0xBE,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACCAC0h, 7FFDDBACCAE7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rcx,al                  ; MOVSX(Movsx_r64_rm8) [RCX,AL]                        encoding(4 bytes) = 48 0f be c8
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0014h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0016h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0018h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0021h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g8iBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d8u(byte lhs, byte rhs)
; location: [7FFDDBACCB00h, 7FFDDBACCB1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0019h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d8uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g8u(byte lhs, byte rhs)
; location: [7FFDDBACCB30h, 7FFDDBACCB54h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0011h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g8uBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d16i(short lhs, short rhs)
; location: [7FFDDBACCB70h, 7FFDDBACCB91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,dx                  ; MOVSX(Movsx_r64_rm16) [RAX,DX]                       encoding(4 bytes) = 48 0f bf c2
0009h movsx rcx,cx                  ; MOVSX(Movsx_r64_rm16) [RCX,CX]                       encoding(4 bytes) = 48 0f bf c9
000dh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000eh idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0010h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d16iBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC2,0x48,0x0F,0xBF,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g16i(short lhs, short rhs)
; location: [7FFDDBACCBB0h, 7FFDDBACCBD7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rcx,ax                  ; MOVSX(Movsx_r64_rm16) [RCX,AX]                       encoding(4 bytes) = 48 0f bf c8
0011h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0013h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0014h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0016h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0018h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0021h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g16iBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACCBF0h, 7FFDDBACCC0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
000bh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000ch idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0019h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d16uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0xC9,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACCC20h, 7FFDDBACCC44h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,ax                  ; MOVZX(Movzx_r32_rm16) [ECX,AX]                       encoding(3 bytes) = 0f b7 c8
000eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0010h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0011h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
0013h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
001eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g16uBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC8,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32i(int lhs, int rhs)
; location: [7FFDDBACCC60h, 7FFDDBACCC7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0008h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32i(int lhs, int rhs)
; location: [7FFDDBACCC90h, 7FFDDBACCCABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0008h idiv ecx                      ; IDIV(Idiv_rm32) [ECX]                                encoding(2 bytes) = f7 f9
000ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x99,0xF7,0xF9,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32u(uint lhs, uint rhs)
; location: [7FFDDBACCCC0h, 7FFDDBACCCDCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0009h div ecx                       ; DIV(Div_rm32) [ECX]                                  encoding(2 bytes) = f7 f1
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32uBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32u(uint lhs, uint rhs)
; location: [7FFDDBACCCF0h, 7FFDDBACCD0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0009h div ecx                       ; DIV(Div_rm32) [ECX]                                  encoding(2 bytes) = f7 f1
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32uBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x33,0xD2,0xF7,0xF1,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64i(long lhs, long rhs)
; location: [7FFDDBACCD20h, 7FFDDBACCD3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000ah idiv rcx                      ; IDIV(Idiv_rm64) [RCX]                                encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0019h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64iBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64i(long lhs, long rhs)
; location: [7FFDDBACCD50h, 7FFDDBACCD6Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000ah idiv rcx                      ; IDIV(Idiv_rm64) [RCX]                                encoding(3 bytes) = 48 f7 f9
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0019h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64iBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x99,0x48,0xF7,0xF9,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACCD80h, 7FFDDBACCD9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah div rcx                       ; DIV(Div_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0019h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACCDB0h, 7FFDDBACCDCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah div rcx                       ; DIV(Div_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 f1
000dh test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h cmp eax,1                     ; CMP(Cmp_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 f8 01
0019h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x33,0xD2,0x48,0xF7,0xF1,0x48,0x85,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x83,0xF8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d32f(float lhs, float rhs)
; location: [7FFDDBACCDE0h, 7FFDDBACCE0Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B050790h            ; CALL(Call_rel32_64) [5F5839B0h:jmp64]                encoding(5 bytes) = e8 98 39 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d32fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x98,0x39,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g32f(float lhs, float rhs)
; location: [7FFDDBACCE30h, 7FFDDBACCE5Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B050790h            ; CALL(Call_rel32_64) [5F583960h:jmp64]                encoding(5 bytes) = e8 48 39 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomiss xmm0,xmm1            ; VUCOMISS(VEX_Vucomiss_xmm_xmmm32) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f8 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g32fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x48,0x39,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF8,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_d64f(double lhs, double rhs)
; location: [7FFDDBACCE80h, 7FFDDBACCEAFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B050700h            ; CALL(Call_rel32_64) [5F583880h:jmp64]                encoding(5 bytes) = e8 68 38 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_d64fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x68,0x38,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool divides_g64f(double lhs, double rhs)
; location: [7FFDDBACCED0h, 7FFDDBACCEFFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
000bh vmovaps xmm0,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM0,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 c1
000fh vmovaps xmm1,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 ca
0013h call 7FFE3B050700h            ; CALL(Call_rel32_64) [5F583830h:jmp64]                encoding(5 bytes) = e8 18 38 58 5f
0018h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
001ch vucomisd xmm0,xmm1            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,XMM1]        encoding(VEX, 4 bytes) = c5 f9 2e c1
0020h setnp al                      ; SETNP(Setnp_rm8) [AL]                                encoding(3 bytes) = 0f 9b c0
0023h jp short 0028h                ; JP(Jp_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7a 03
0025h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divides_g64fBytes => new byte[48]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xC1,0xC5,0xF8,0x28,0xCA,0xE8,0x18,0x38,0x58,0x5F,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x2E,0xC1,0x0F,0x9B,0xC0,0x7A,0x03,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACCF20h, 7FFDDBACCF35h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACCF50h, 7FFDDBACCF69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d8u(byte lhs, byte rhs)
; location: [7FFDDBACCF80h, 7FFDDBACCF93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g8u(byte lhs, byte rhs)
; location: [7FFDDBACCFB0h, 7FFDDBACCFC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d16i(short lhs, short rhs)
; location: [7FFDDBACCFE0h, 7FFDDBACCFF5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g16i(short lhs, short rhs)
; location: [7FFDDBACD010h, 7FFDDBACD029h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACD040h, 7FFDDBACD053h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACD070h, 7FFDDBACD086h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d32i(int lhs, int rhs)
; location: [7FFDDBACD0A0h, 7FFDDBACD0ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g32i(int lhs, int rhs)
; location: [7FFDDBACD0C0h, 7FFDDBACD0CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d32u(uint lhs, uint rhs)
; location: [7FFDDBACD0E0h, 7FFDDBACD0EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g32u(uint lhs, uint rhs)
; location: [7FFDDBACD100h, 7FFDDBACD10Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d64i(long lhs, long rhs)
; location: [7FFDDBACD120h, 7FFDDBACD12Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g64i(long lhs, long rhs)
; location: [7FFDDBACD140h, 7FFDDBACD14Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACD160h, 7FFDDBACD16Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACD180h, 7FFDDBACD18Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> eq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d32f(float lhs, float rhs)
; location: [7FFDDBACD1A0h, 7FFDDBACD1B4h]
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
; function: bit eq_g32f(float lhs, float rhs)
; location: [7FFDDBACD1D0h, 7FFDDBACD1E4h]
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
; function: bit eq_d64f(double lhs, double rhs)
; location: [7FFDDBACD200h, 7FFDDBACD214h]
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
; function: bit eq_g64f(double lhs, double rhs)
; location: [7FFDDBACD630h, 7FFDDBACD644h]
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
; function: bit neq_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACD660h, 7FFDDBACD675h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d8iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACD690h, 7FFDDBACD6A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d8u(byte lhs, byte rhs)
; location: [7FFDDBACD6C0h, 7FFDDBACD6D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g8u(byte lhs, byte rhs)
; location: [7FFDDBACD6F0h, 7FFDDBACD706h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g8uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d16i(short lhs, short rhs)
; location: [7FFDDBACD720h, 7FFDDBACD735h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d16iBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g16i(short lhs, short rhs)
; location: [7FFDDBACD750h, 7FFDDBACD769h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0013h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g16iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACD780h, 7FFDDBACD793h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACD7B0h, 7FFDDBACD7C6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d32i(int lhs, int rhs)
; location: [7FFDDBACD7E0h, 7FFDDBACD7EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g32i(int lhs, int rhs)
; location: [7FFDDBACD800h, 7FFDDBACD80Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d32u(uint lhs, uint rhs)
; location: [7FFDDBACD820h, 7FFDDBACD82Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g32u(uint lhs, uint rhs)
; location: [7FFDDBACD840h, 7FFDDBACD84Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d64i(long lhs, long rhs)
; location: [7FFDDBACD860h, 7FFDDBACD86Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g64i(long lhs, long rhs)
; location: [7FFDDBACD880h, 7FFDDBACD88Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACD8A0h, 7FFDDBACD8AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_d64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACD8C0h, 7FFDDBACD8CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> neq_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit neq_d32f(float lhs, float rhs)
; location: [7FFDDBACD8E0h, 7FFDDBACD8F4h]
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
; function: bit neq_g32f(float lhs, float rhs)
; location: [7FFDDBACD910h, 7FFDDBACD924h]
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
; function: bit neq_d64f(double lhs, double rhs)
; location: [7FFDDBACD940h, 7FFDDBACD954h]
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
; function: bit neq_g64f(double lhs, double rhs)
; location: [7FFDDBACD970h, 7FFDDBACD984h]
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
; function: bit even_d8i(sbyte x)
; location: [7FFDDBACD9A0h, 7FFDDBACD9B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g8i(sbyte x)
; location: [7FFDDBACD9D0h, 7FFDDBACD9E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0013h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g8iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d8u(byte x)
; location: [7FFDDBACDA00h, 7FFDDBACDA10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g8u(byte x)
; location: [7FFDDBACDA30h, 7FFDDBACDA45h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0012h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g8uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d16i(short x)
; location: [7FFDDBACDA60h, 7FFDDBACDA71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g16i(short x)
; location: [7FFDDBACDA90h, 7FFDDBACDAA6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000bh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0013h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g16iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d16u(ushort x)
; location: [7FFDDBACDAC0h, 7FFDDBACDAD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_g16u(ushort x)
; location: [7FFDDBACDAF0h, 7FFDDBACDB05h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0012h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_g16uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit even_d32i(int x)
; location: [7FFDDBACDB20h, 7FFDDBACDB2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,1                     ; TEST(Test_rm8_imm8) [CL,1h:imm8]                     encoding(3 bytes) = f6 c1 01
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> even_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0xC1,0x01,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal_d8i(sbyte lhs, int offset)
; location: [7FFDDBACDB40h, 7FFDDBACDB51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte sal_g8i(sbyte lhs, int offset)
; location: [7FFDDBACDB70h, 7FFDDBACDB81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal_d8u(byte lhs, int offset)
; location: [7FFDDBACDBA0h, 7FFDDBACDBAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte sal_g8u(byte lhs, int offset)
; location: [7FFDDBACDBC0h, 7FFDDBACDBCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal_d16i(short lhs, int offset)
; location: [7FFDDBACDBE0h, 7FFDDBACDBF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short sal_g16i(short lhs, int offset)
; location: [7FFDDBACDC10h, 7FFDDBACDC21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g16iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0xD3,0xE0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal_d16u(ushort lhs, int offset)
; location: [7FFDDBACDC40h, 7FFDDBACDC4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort sal_g16u(ushort lhs, int offset)
; location: [7FFDDBACDC60h, 7FFDDBACDC6Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g16uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal_d32i(int lhs, int offset)
; location: [7FFDDBACDC80h, 7FFDDBACDC8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sal_g32i(int lhs, int offset)
; location: [7FFDDBACDCA0h, 7FFDDBACDCABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g32iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal_d32u(uint lhs, int offset)
; location: [7FFDDBACDCC0h, 7FFDDBACDCCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint sal_g32u(uint lhs, int offset)
; location: [7FFDDBACDCE0h, 7FFDDBACDCEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal_d64i(long lhs, int offset)
; location: [7FFDDBACDD00h, 7FFDDBACDD0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long sal_g64i(long lhs, int offset)
; location: [7FFDDBACE130h, 7FFDDBACE13Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g64iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal_d64u(ulong lhs, int offset)
; location: [7FFDDBACE150h, 7FFDDBACE15Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_d64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sal_g64u(ulong lhs, int offset)
; location: [7FFDDBACE170h, 7FFDDBACE17Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sal_g64uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte abs_d8i(sbyte x)
; location: [7FFDDBACE190h, 7FFDDBACE1A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACE1C0h, 7FFDDBACE1D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACE1F0h, 7FFDDBACE206h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACE220h, 7FFDDBACE236h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
; location: [7FFDDBACE250h, 7FFDDBACE25Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int abs_g32i(int x)
; location: [7FFDDBACE270h, 7FFDDBACE27Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah lea edx,[rcx+rax]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 14 01
000dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x8D,0x14,0x01,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_d64i(long x)
; location: [7FFDDBACE290h, 7FFDDBACE2A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_d64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long abs_g64i(long x)
; location: [7FFDDBACE2C0h, 7FFDDBACE2D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sar rax,3Fh                   ; SAR(Sar_rm64_imm8) [RAX,3fh:imm8]                    encoding(4 bytes) = 48 c1 f8 3f
000ch lea rdx,[rcx+rax]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 14 01
0010h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> abs_g64iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xF8,0x3F,0x48,0x8D,0x14,0x01,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACE2F0h, 7FFDDBACE303h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte add_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACE320h, 7FFDDBACE337h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x03,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_d8u(byte lhs, byte rhs)
; location: [7FFDDBACE350h, 7FFDDBACE360h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte add_g8u(byte lhs, byte rhs)
; location: [7FFDDBACE380h, 7FFDDBACE393h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x03,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_d16i(short lhs, short rhs)
; location: [7FFDDBACE3B0h, 7FFDDBACE3C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short add_g16i(short lhs, short rhs)
; location: [7FFDDBACE3E0h, 7FFDDBACE3F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x03,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACE410h, 7FFDDBACE420h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort add_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACE440h, 7FFDDBACE453h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_d32i(int lhs, int rhs)
; location: [7FFDDBACE470h, 7FFDDBACE478h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add_g32i(int lhs, int rhs)
; location: [7FFDDBACE490h, 7FFDDBACE499h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_d32u(uint lhs, uint rhs)
; location: [7FFDDBACE4B0h, 7FFDDBACE4B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint add_g32u(uint lhs, uint rhs)
; location: [7FFDDBACE4D0h, 7FFDDBACE4D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x03,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_d64i(long lhs, long rhs)
; location: [7FFDDBACE4F0h, 7FFDDBACE4F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d64iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long add_g64i(long lhs, long rhs)
; location: [7FFDDBACE510h, 7FFDDBACE51Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACE530h, 7FFDDBACE539h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_d64uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong add_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACE550h, 7FFDDBACE55Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_d8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACE570h, 7FFDDBACE583h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d8iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte and_g8i(sbyte lhs, sbyte rhs)
; location: [7FFDDBACE5A0h, 7FFDDBACE5B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g8iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x48,0x0F,0xBE,0xC0,0x23,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_d8u(byte lhs, byte rhs)
; location: [7FFDDBACE5D0h, 7FFDDBACE5E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte and_g8u(byte lhs, byte rhs)
; location: [7FFDDBACE600h, 7FFDDBACE613h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_d16i(short lhs, short rhs)
; location: [7FFDDBACE630h, 7FFDDBACE643h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short and_g16i(short lhs, short rhs)
; location: [7FFDDBACEA60h, 7FFDDBACEA77h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g16iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBF,0xC0,0x23,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_d16u(ushort lhs, ushort rhs)
; location: [7FFDDBACEA90h, 7FFDDBACEAA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort and_g16u(ushort lhs, ushort rhs)
; location: [7FFDDBACEAC0h, 7FFDDBACEAD3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_d32i(int lhs, int rhs)
; location: [7FFDDBACEAF0h, 7FFDDBACEAF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int and_g32i(int lhs, int rhs)
; location: [7FFDDBACEB10h, 7FFDDBACEB19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_d32u(uint lhs, uint rhs)
; location: [7FFDDBACEB30h, 7FFDDBACEB39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_g32u(uint lhs, uint rhs)
; location: [7FFDDBACEB50h, 7FFDDBACEB59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_d64i(long lhs, long rhs)
; location: [7FFDDBACEB70h, 7FFDDBACEB7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long and_g64i(long lhs, long rhs)
; location: [7FFDDBACEB90h, 7FFDDBACEB9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64iBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_d64u(ulong lhs, ulong rhs)
; location: [7FFDDBACEBB0h, 7FFDDBACEBBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_g64u(ulong lhs, ulong rhs)
; location: [7FFDDBACEBD0h, 7FFDDBACEBDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_d32f(float lhs, float rhs)
; location: [7FFDDBACEBF0h, 7FFDDBACEC19h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float and_g32f(float lhs, float rhs)
; location: [7FFDDBACEC40h, 7FFDDBACEC69h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
000dh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 14
0011h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0017h and eax,[rsp+10h]             ; AND(And_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 23 44 24 10
001bh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
001fh vmovss xmm0,dword ptr [rsp+0Ch]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 0c
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g32fBytes => new byte[42]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x23,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0xC5,0xFA,0x10,0x44,0x24,0x0C,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and_d64f(double lhs, double rhs)
; location: [7FFDDBACEC90h, 7FFDDBACECBAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_d64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double and_g64f(double lhs, double rhs)
; location: [7FFDDBACECE0h, 7FFDDBACED0Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 10
0012h vmovsd qword ptr [rsp+8],xmm1 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 08
0018h and rax,[rsp+8]               ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 23 44 24 08
001dh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0021h vmovsd xmm0,qword ptr [rsp]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 04 24
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_g64fBytes => new byte[43]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0xC5,0xFB,0x11,0x4C,0x24,0x08,0x48,0x23,0x44,0x24,0x08,0x48,0x89,0x04,0x24,0xC5,0xFB,0x10,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDDBACED30h, 7FFDDBACED58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 0023h                ; JL(Jl_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 7c 12
0011h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0015h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0019h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
001bh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h               ; JMP(Jmp_rel8_64) [25h:jmp64]                         encoding(2 bytes) = eb 02
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d8iBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x12,0x48,0x0F,0xBE,0xC1,0x49,0x0F,0xBE,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g8i(sbyte x, sbyte a, sbyte b)
; location: [7FFDDBACED70h, 7FFDDBACED9Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g8iBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0x49,0x0F,0xBE,0xC8,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d8u(byte x, byte a, byte b)
; location: [7FFDDBACEDB0h, 7FFDDBACEDD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c 11
000fh movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0012h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0016h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0018h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 02
0020h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d8uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x11,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g8u(byte x, byte a, byte b)
; location: [7FFDDBACEDF0h, 7FFDDBACEE18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g8uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d16i(short x, short a, short b)
; location: [7FFDDBACEE30h, 7FFDDBACEE58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000fh jl short 0023h                ; JL(Jl_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 7c 12
0011h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0015h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0019h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
001bh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h jmp short 0025h               ; JMP(Jmp_rel8_64) [25h:jmp64]                         encoding(2 bytes) = eb 02
0023h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d16iBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x12,0x48,0x0F,0xBF,0xC1,0x49,0x0F,0xBF,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g16i(short x, short a, short b)
; location: [7FFDDBACEE70h, 7FFDDBACEE9Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g16iBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0x49,0x0F,0xBF,0xC8,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d16u(ushort x, ushort a, ushort b)
; location: [7FFDDBACEEB0h, 7FFDDBACEED5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c 11
000fh movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0012h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0016h cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
0018h setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 02
0020h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d16uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x11,0x0F,0xB7,0xC1,0x41,0x0F,0xB7,0xD0,0x3B,0xC2,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g16u(ushort x, ushort a, ushort b)
; location: [7FFDDBACEEF0h, 7FFDDBACEF18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
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
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g16uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x41,0x0F,0xB7,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xD2,0x3B,0xC2,0x7C,0x0A,0x3B,0xC1,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d32i(int x, int a, int b)
; location: [7FFDDBACEF30h, 7FFDDBACEF49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d32iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0B,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g32i(int x, int a, int b)
; location: [7FFDDBACEF60h, 7FFDDBACEF79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jl short 0014h                ; JL(Jl_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 7c 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g32iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x7C,0x0B,0x41,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d32u(uint x, uint a, uint b)
; location: [7FFDDBACEF90h, 7FFDDBACEFA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 0014h                ; JB(Jb_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 72 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d32uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0B,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g32u(uint x, uint a, uint b)
; location: [7FFDDBACEFC0h, 7FFDDBACEFD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0007h jb short 0014h                ; JB(Jb_rel8_64) [14h:jmp64]                           encoding(2 bytes) = 72 0b
0009h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
000ch setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h jmp short 0016h               ; JMP(Jmp_rel8_64) [16h:jmp64]                         encoding(2 bytes) = eb 02
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g32uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x3B,0xCA,0x72,0x0B,0x41,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d64i(long x, long a, long b)
; location: [7FFDDBACEFF0h, 7FFDDBACF00Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 0015h                ; JL(Jl_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7c 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0B,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g64i(long x, long a, long b)
; location: [7FFDDBACF020h, 7FFDDBACF03Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jl short 0015h                ; JL(Jl_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7c 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setle al                      ; SETLE(Setle_rm8) [AL]                                encoding(3 bytes) = 0f 9e c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x7C,0x0B,0x49,0x3B,0xC8,0x0F,0x9E,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_d64u(ulong x, ulong a, ulong b)
; location: [7FFDDBACF050h, 7FFDDBACF06Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 0015h                ; JB(Jb_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 72 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_d64uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0B,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit between_g64u(ulong x, ulong a, ulong b)
; location: [7FFDDBACF080h, 7FFDDBACF09Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0008h jb short 0015h                ; JB(Jb_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 72 0b
000ah cmp rcx,r8                    ; CMP(Cmp_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 3b c8
000dh setbe al                      ; SETBE(Setbe_rm8) [AL]                                encoding(3 bytes) = 0f 96 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h jmp short 0017h               ; JMP(Jmp_rel8_64) [17h:jmp64]                         encoding(2 bytes) = eb 02
0015h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> between_g64uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x3B,0xCA,0x72,0x0B,0x49,0x3B,0xC8,0x0F,0x96,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avgz_64u_g(ReadOnlySpan<ulong> src)
; location: [7FFDDBACF890h, 7FFDDBACF8E0h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
000bh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000dh mov [rsp],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(4 bytes) = 48 89 0c 24
0011h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 08
0014h mov [rsp],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(4 bytes) = 48 89 0c 24
0018h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
001dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0020h jle short 0048h               ; JLE(Jle_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 7e 26
0022h movsxd r8,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]                     encoding(3 bytes) = 4c 63 c1
0025h mov r8,[rax+r8*8]             ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,:sr)]           encoding(4 bytes) = 4e 8b 04 c0
0029h lea r9,[rsp]                  ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(4 bytes) = 4c 8d 0c 24
002dh mov r10,[r9]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R9:br,:sr)]           encoding(3 bytes) = 4d 8b 11
0030h mov r11,r10                   ; MOV(Mov_r64_rm64) [R11,R10]                          encoding(3 bytes) = 4d 8b da
0033h and r11,r8                    ; AND(And_r64_rm64) [R11,R8]                           encoding(3 bytes) = 4d 23 d8
0036h xor r8,r10                    ; XOR(Xor_r64_rm64) [R8,R10]                           encoding(3 bytes) = 4d 33 c2
0039h shr r8,1                      ; SHR(Shr_rm64_1) [R8,1h:imm8]                         encoding(3 bytes) = 49 d1 e8
003ch add r8,r11                    ; ADD(Add_r64_rm64) [R8,R11]                           encoding(3 bytes) = 4d 03 c3
003fh mov [r9],r8                   ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),R8]            encoding(3 bytes) = 4d 89 01
0042h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0044h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0046h jl short 0022h                ; JL(Jl_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 7c da
0048h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
004ch add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avgz_64u_gBytes => new byte[81]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x8B,0x01,0x8B,0x51,0x08,0x33,0xC9,0x48,0x89,0x0C,0x24,0x48,0x8B,0x08,0x48,0x89,0x0C,0x24,0xB9,0x01,0x00,0x00,0x00,0x83,0xFA,0x01,0x7E,0x26,0x4C,0x63,0xC1,0x4E,0x8B,0x04,0xC0,0x4C,0x8D,0x0C,0x24,0x4D,0x8B,0x11,0x4D,0x8B,0xDA,0x4D,0x23,0xD8,0x4D,0x33,0xC2,0x49,0xD1,0xE8,0x4D,0x03,0xC3,0x4D,0x89,0x01,0xFF,0xC1,0x3B,0xCA,0x7C,0xDA,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Collector collector_create()
; location: [7FFDDBACF900h, 7FFDDBACF951h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rcx,7FFDDBB83630h         ; MOV(Mov_r64_imm64) [RCX,7ffddbb83630h:imm64]         encoding(10 bytes) = 48 b9 30 36 b8 db fd 7f 00 00
0011h call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5F454BB0h:jmp64]                encoding(5 bytes) = e8 9a 4b 45 5f
0016h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
001ah vmovsd qword ptr [rax+30h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 30
001fh vmovsd qword ptr [rax+28h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 28
0024h vmovsd qword ptr [rax+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 20
0029h vmovsd qword ptr [rax+18h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 18
002eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0030h mov [rax+38h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(3 bytes) = 89 50 38
0033h vmovsd xmm0,qword ptr [7FFDDBACF960h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 25 00 00 00
003bh vmovsd qword ptr [rax+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 08
0040h vmovsd xmm0,qword ptr [7FFDDBACF968h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 20 00 00 00
0048h vmovsd qword ptr [rax+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 40 10
004dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> collector_createBytes => new byte[82]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0xB9,0x30,0x36,0xB8,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0x9A,0x4B,0x45,0x5F,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x11,0x40,0x30,0xC5,0xFB,0x11,0x40,0x28,0xC5,0xFB,0x11,0x40,0x20,0xC5,0xFB,0x11,0x40,0x18,0x33,0xD2,0x89,0x50,0x38,0xC5,0xFB,0x10,0x05,0x25,0x00,0x00,0x00,0xC5,0xFB,0x11,0x40,0x08,0xC5,0xFB,0x10,0x05,0x20,0x00,0x00,0x00,0xC5,0xFB,0x11,0x40,0x10,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void collector_collect_seq(Collector collector)
; location: [7FFDDBACFD90h, 7FFDDBACFE27h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah mov edx,[rcx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 11
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0012h vcvtsi2sd xmm0,xmm0,edx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fb 2a c2
0016h inc dword ptr [rcx+38h]       ; INC(Inc_rm32) [mem(32u,RCX:br,:sr)]                  encoding(3 bytes) = ff 41 38
0019h vmovsd xmm1,qword ptr [rcx+18h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 18
001eh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0022h vsubsd xmm2,xmm2,xmm1         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM1]   encoding(VEX, 4 bytes) = c5 eb 5c d1
0026h vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
002ah vcvtsi2sd xmm3,xmm3,dword ptr [rcx+38h]; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM3,XMM3,mem(32i,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 e3 2a 59 38
002fh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0033h vdivsd xmm4,xmm4,xmm3         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3]   encoding(VEX, 4 bytes) = c5 db 5e e3
0037h vaddsd xmm1,xmm1,xmm4         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM4]   encoding(VEX, 4 bytes) = c5 f3 58 cc
003bh vmovsd qword ptr [rcx+20h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 20
0040h vmovsd xmm1,qword ptr [rcx+28h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 28
0045h vmovsd xmm3,qword ptr [rcx+20h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 59 20
004ah vmovaps xmm4,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 e0
004eh vsubsd xmm4,xmm4,xmm3         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3]   encoding(VEX, 4 bytes) = c5 db 5c e3
0052h vmulsd xmm2,xmm2,xmm4         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM4]   encoding(VEX, 4 bytes) = c5 eb 59 d4
0056h vaddsd xmm1,xmm1,xmm2         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2]   encoding(VEX, 4 bytes) = c5 f3 58 ca
005ah vmovsd qword ptr [rcx+30h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
005fh vmovsd qword ptr [rcx+18h],xmm3; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM3] encoding(VEX, 5 bytes) = c5 fb 11 59 18
0064h vmovsd xmm1,qword ptr [rcx+30h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 30
0069h vmovsd qword ptr [rcx+28h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
006eh vucomisd xmm0,qword ptr [rcx+10h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 41 10
0073h jbe short 007ah               ; JBE(Jbe_rel8_64) [7Ah:jmp64]                         encoding(2 bytes) = 76 05
0075h vmovsd qword ptr [rcx+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 10
007ah vmovsd xmm1,qword ptr [rcx+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 49 08
007fh vucomisd xmm1,xmm0            ; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM1,XMM0]        encoding(VEX, 4 bytes) = c5 f9 2e c8
0083h jbe short 008ah               ; JBE(Jbe_rel8_64) [8Ah:jmp64]                         encoding(2 bytes) = 76 05
0085h vmovsd qword ptr [rcx+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 08
008ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
008ch cmp eax,0FFh                  ; CMP(Cmp_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 3d ff 00 00 00
0091h jl near ptr 000ah             ; JL(Jl_rel32_64) [Ah:jmp64]                           encoding(6 bytes) = 0f 8c 73 ff ff ff
0097h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> collector_collect_seqBytes => new byte[152]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0x01,0x00,0x00,0x00,0x8B,0x11,0x8B,0xD0,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x2A,0xC2,0xFF,0x41,0x38,0xC5,0xFB,0x10,0x49,0x18,0xC5,0xF8,0x28,0xD0,0xC5,0xEB,0x5C,0xD1,0xC5,0xE0,0x57,0xDB,0xC5,0xE3,0x2A,0x59,0x38,0xC5,0xF8,0x28,0xE2,0xC5,0xDB,0x5E,0xE3,0xC5,0xF3,0x58,0xCC,0xC5,0xFB,0x11,0x49,0x20,0xC5,0xFB,0x10,0x49,0x28,0xC5,0xFB,0x10,0x59,0x20,0xC5,0xF8,0x28,0xE0,0xC5,0xDB,0x5C,0xE3,0xC5,0xEB,0x59,0xD4,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x59,0x18,0xC5,0xFB,0x10,0x49,0x30,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xF9,0x2E,0x41,0x10,0x76,0x05,0xC5,0xFB,0x11,0x41,0x10,0xC5,0xFB,0x10,0x49,0x08,0xC5,0xF9,0x2E,0xC8,0x76,0x05,0xC5,0xFB,0x11,0x41,0x08,0xFF,0xC0,0x3D,0xFF,0x00,0x00,0x00,0x0F,0x8C,0x73,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void collector_collect_op(Collector collector)
; location: [7FFDDBACFE60h, 7FFDDBAD0003h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 01
0007h mov eax,[rcx+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 41 38
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx+38h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 38
000fh vmovsd xmm0,qword ptr [rcx+18h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 41 18
0014h vmovsd xmm1,qword ptr [7FFDDBAD0050h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 0d d4 01 00 00
001ch vsubsd xmm1,xmm1,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM0]   encoding(VEX, 4 bytes) = c5 f3 5c c8
0020h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0024h vcvtsi2sd xmm2,xmm2,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM2,XMM2,EAX] encoding(VEX, 4 bytes) = c5 eb 2a d0
0028h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
002ch vdivsd xmm3,xmm3,xmm2         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM2]   encoding(VEX, 4 bytes) = c5 e3 5e da
0030h vaddsd xmm0,xmm0,xmm3         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM3]   encoding(VEX, 4 bytes) = c5 fb 58 c3
0034h vmovsd qword ptr [rcx+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 20
0039h vmovsd xmm2,qword ptr [rcx+28h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 51 28
003eh vmovsd xmm3,qword ptr [7FFDDBAD0058h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 1d b2 01 00 00
0046h vsubsd xmm3,xmm3,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM0]   encoding(VEX, 4 bytes) = c5 e3 5c d8
004ah vmulsd xmm1,xmm1,xmm3         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM3]   encoding(VEX, 4 bytes) = c5 f3 59 cb
004eh vaddsd xmm1,xmm1,xmm2         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2]   encoding(VEX, 4 bytes) = c5 f3 58 ca
0052h vmovsd qword ptr [rcx+30h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
0057h vmovsd qword ptr [rcx+18h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 18
005ch vmovsd qword ptr [rcx+28h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
0061h vmovsd xmm2,qword ptr [7FFDDBAD0060h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 97 01 00 00
0069h vucomisd xmm2,qword ptr [rcx+10h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 51 10
006eh jbe short 007dh               ; JBE(Jbe_rel8_64) [7Dh:jmp64]                         encoding(2 bytes) = 76 0d
0070h vmovsd xmm2,qword ptr [7FFDDBAD0068h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 90 01 00 00
0078h vmovsd qword ptr [rcx+10h],xmm2; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 10
007dh vmovsd xmm2,qword ptr [rcx+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 51 08
0082h vucomisd xmm2,qword ptr [7FFDDBAD0070h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 f9 2e 15 86 01 00 00
008ah jbe short 0099h               ; JBE(Jbe_rel8_64) [99h:jmp64]                         encoding(2 bytes) = 76 0d
008ch vmovsd xmm2,qword ptr [7FFDDBAD0078h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 84 01 00 00
0094h vmovsd qword ptr [rcx+8],xmm2 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 08
0099h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
009bh mov [rcx+38h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 38
009eh vmovsd xmm2,qword ptr [7FFDDBAD0080h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 7a 01 00 00
00a6h vsubsd xmm2,xmm2,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM0]   encoding(VEX, 4 bytes) = c5 eb 5c d0
00aah vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
00aeh vcvtsi2sd xmm3,xmm3,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM3,XMM3,EAX] encoding(VEX, 4 bytes) = c5 e3 2a d8
00b2h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
00b6h vdivsd xmm4,xmm4,xmm3         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3]   encoding(VEX, 4 bytes) = c5 db 5e e3
00bah vaddsd xmm0,xmm0,xmm4         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM4]   encoding(VEX, 4 bytes) = c5 fb 58 c4
00beh vmovsd qword ptr [rcx+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 20
00c3h vmovsd xmm3,qword ptr [7FFDDBAD0088h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 1d 5d 01 00 00
00cbh vsubsd xmm3,xmm3,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM0]   encoding(VEX, 4 bytes) = c5 e3 5c d8
00cfh vmulsd xmm2,xmm2,xmm3         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM3]   encoding(VEX, 4 bytes) = c5 eb 59 d3
00d3h vaddsd xmm1,xmm1,xmm2         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2]   encoding(VEX, 4 bytes) = c5 f3 58 ca
00d7h vmovsd qword ptr [rcx+30h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
00dch vmovsd qword ptr [rcx+18h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 18
00e1h vmovsd qword ptr [rcx+28h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
00e6h vmovsd xmm2,qword ptr [7FFDDBAD0090h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 42 01 00 00
00eeh vucomisd xmm2,qword ptr [rcx+10h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 51 10
00f3h jbe short 0102h               ; JBE(Jbe_rel8_64) [102h:jmp64]                        encoding(2 bytes) = 76 0d
00f5h vmovsd xmm2,qword ptr [7FFDDBAD0098h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 3b 01 00 00
00fdh vmovsd qword ptr [rcx+10h],xmm2; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 10
0102h vmovsd xmm2,qword ptr [rcx+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 51 08
0107h vucomisd xmm2,qword ptr [7FFDDBAD00A0h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 f9 2e 15 31 01 00 00
010fh jbe short 011eh               ; JBE(Jbe_rel8_64) [11Eh:jmp64]                        encoding(2 bytes) = 76 0d
0111h vmovsd xmm2,qword ptr [7FFDDBAD00A8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 2f 01 00 00
0119h vmovsd qword ptr [rcx+8],xmm2 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fb 11 51 08
011eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0120h mov [rcx+38h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 38
0123h vmovsd xmm2,qword ptr [7FFDDBAD00B0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM2,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 15 25 01 00 00
012bh vsubsd xmm2,xmm2,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM0]   encoding(VEX, 4 bytes) = c5 eb 5c d0
012fh vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
0133h vcvtsi2sd xmm3,xmm3,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM3,XMM3,EAX] encoding(VEX, 4 bytes) = c5 e3 2a d8
0137h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
013bh vdivsd xmm4,xmm4,xmm3         ; VDIVSD(VEX_Vdivsd_xmm_xmm_xmmm64) [XMM4,XMM4,XMM3]   encoding(VEX, 4 bytes) = c5 db 5e e3
013fh vaddsd xmm0,xmm0,xmm4         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,XMM4]   encoding(VEX, 4 bytes) = c5 fb 58 c4
0143h vmovsd qword ptr [rcx+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 20
0148h vmovsd xmm3,qword ptr [7FFDDBAD00B8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM3,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 1d 08 01 00 00
0150h vsubsd xmm3,xmm3,xmm0         ; VSUBSD(VEX_Vsubsd_xmm_xmm_xmmm64) [XMM3,XMM3,XMM0]   encoding(VEX, 4 bytes) = c5 e3 5c d8
0154h vmulsd xmm2,xmm2,xmm3         ; VMULSD(VEX_Vmulsd_xmm_xmm_xmmm64) [XMM2,XMM2,XMM3]   encoding(VEX, 4 bytes) = c5 eb 59 d3
0158h vaddsd xmm1,xmm1,xmm2         ; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM1,XMM1,XMM2]   encoding(VEX, 4 bytes) = c5 f3 58 ca
015ch vmovsd qword ptr [rcx+30h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 30
0161h vmovsd qword ptr [rcx+18h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 18
0166h vmovsd qword ptr [rcx+28h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 fb 11 49 28
016bh vmovsd xmm0,qword ptr [7FFDDBAD00C0h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 ed 00 00 00
0173h vucomisd xmm0,qword ptr [rcx+10h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 2e 41 10
0178h jbe short 0187h               ; JBE(Jbe_rel8_64) [187h:jmp64]                        encoding(2 bytes) = 76 0d
017ah vmovsd xmm0,qword ptr [7FFDDBAD00C8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 e6 00 00 00
0182h vmovsd qword ptr [rcx+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 10
0187h vmovsd xmm0,qword ptr [rcx+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,:sr)] encoding(VEX, 5 bytes) = c5 fb 10 41 08
018ch vucomisd xmm0,qword ptr [7FFDDBAD00D0h]; VUCOMISD(VEX_Vucomisd_xmm_xmmm64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 f9 2e 05 dc 00 00 00
0194h jbe short 01a3h               ; JBE(Jbe_rel8_64) [1A3h:jmp64]                        encoding(2 bytes) = 76 0d
0196h vmovsd xmm0,qword ptr [7FFDDBAD00D8h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 da 00 00 00
019eh vmovsd qword ptr [rcx+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 41 08
01a3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> collector_collect_opBytes => new byte[420]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0x01,0x8B,0x41,0x38,0xFF,0xC0,0x89,0x41,0x38,0xC5,0xFB,0x10,0x41,0x18,0xC5,0xFB,0x10,0x0D,0xD4,0x01,0x00,0x00,0xC5,0xF3,0x5C,0xC8,0xC5,0xE8,0x57,0xD2,0xC5,0xEB,0x2A,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE3,0x5E,0xDA,0xC5,0xFB,0x58,0xC3,0xC5,0xFB,0x11,0x41,0x20,0xC5,0xFB,0x10,0x51,0x28,0xC5,0xFB,0x10,0x1D,0xB2,0x01,0x00,0x00,0xC5,0xE3,0x5C,0xD8,0xC5,0xF3,0x59,0xCB,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x41,0x18,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xFB,0x10,0x15,0x97,0x01,0x00,0x00,0xC5,0xF9,0x2E,0x51,0x10,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x90,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x10,0xC5,0xFB,0x10,0x51,0x08,0xC5,0xF9,0x2E,0x15,0x86,0x01,0x00,0x00,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x84,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x08,0xFF,0xC0,0x89,0x41,0x38,0xC5,0xFB,0x10,0x15,0x7A,0x01,0x00,0x00,0xC5,0xEB,0x5C,0xD0,0xC5,0xE0,0x57,0xDB,0xC5,0xE3,0x2A,0xD8,0xC5,0xF8,0x28,0xE2,0xC5,0xDB,0x5E,0xE3,0xC5,0xFB,0x58,0xC4,0xC5,0xFB,0x11,0x41,0x20,0xC5,0xFB,0x10,0x1D,0x5D,0x01,0x00,0x00,0xC5,0xE3,0x5C,0xD8,0xC5,0xEB,0x59,0xD3,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x41,0x18,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xFB,0x10,0x15,0x42,0x01,0x00,0x00,0xC5,0xF9,0x2E,0x51,0x10,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x3B,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x10,0xC5,0xFB,0x10,0x51,0x08,0xC5,0xF9,0x2E,0x15,0x31,0x01,0x00,0x00,0x76,0x0D,0xC5,0xFB,0x10,0x15,0x2F,0x01,0x00,0x00,0xC5,0xFB,0x11,0x51,0x08,0xFF,0xC0,0x89,0x41,0x38,0xC5,0xFB,0x10,0x15,0x25,0x01,0x00,0x00,0xC5,0xEB,0x5C,0xD0,0xC5,0xE0,0x57,0xDB,0xC5,0xE3,0x2A,0xD8,0xC5,0xF8,0x28,0xE2,0xC5,0xDB,0x5E,0xE3,0xC5,0xFB,0x58,0xC4,0xC5,0xFB,0x11,0x41,0x20,0xC5,0xFB,0x10,0x1D,0x08,0x01,0x00,0x00,0xC5,0xE3,0x5C,0xD8,0xC5,0xEB,0x59,0xD3,0xC5,0xF3,0x58,0xCA,0xC5,0xFB,0x11,0x49,0x30,0xC5,0xFB,0x11,0x41,0x18,0xC5,0xFB,0x11,0x49,0x28,0xC5,0xFB,0x10,0x05,0xED,0x00,0x00,0x00,0xC5,0xF9,0x2E,0x41,0x10,0x76,0x0D,0xC5,0xFB,0x10,0x05,0xE6,0x00,0x00,0x00,0xC5,0xFB,0x11,0x41,0x10,0xC5,0xFB,0x10,0x41,0x08,0xC5,0xF9,0x2E,0x05,0xDC,0x00,0x00,0x00,0x76,0x0D,0xC5,0xFB,0x10,0x05,0xDA,0x00,0x00,0x00,0xC5,0xFB,0x11,0x41,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong get_altodd_u64()
; location: [7FFDDBAD00F0h, 7FFDDBAD00FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,5555555555555555h     ; MOV(Mov_r64_imm64) [RAX,5555555555555555h:imm64]     encoding(10 bytes) = 48 b8 55 55 55 55 55 55 55 55
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_altodd_u64Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0x55,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_n8u()
; location: [7FFDDBAD0110h, 7FFDDBAD011Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte one_g8u()
; location: [7FFDDBAD0130h, 7FFDDBAD013Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_n16u()
; location: [7FFDDBAD0150h, 7FFDDBAD015Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort one_g16u()
; location: [7FFDDBAD0170h, 7FFDDBAD017Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_n32i()
; location: [7FFDDBAD0190h, 7FFDDBAD019Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int one_g32i()
; location: [7FFDDBAD01B0h, 7FFDDBAD01BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_n32u()
; location: [7FFDDBAD01D0h, 7FFDDBAD01DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint one_g32u()
; location: [7FFDDBAD01F0h, 7FFDDBAD01FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_n64i()
; location: [7FFDDBAD0210h, 7FFDDBAD021Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long one_g64i()
; location: [7FFDDBAD0230h, 7FFDDBAD023Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_n64u()
; location: [7FFDDBAD0250h, 7FFDDBAD025Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong one_g64u()
; location: [7FFDDBAD0270h, 7FFDDBAD027Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_n32f()
; location: [7FFDDBAD0290h, 7FFDDBAD029Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBAD02A0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float one_g32f()
; location: [7FFDDBAD02C0h, 7FFDDBAD02CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBAD02D0h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_n64f()
; location: [7FFDDBAD02F0h, 7FFDDBAD02FDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBAD0300h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_n64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double one_g64f()
; location: [7FFDDBAD0320h, 7FFDDBAD032Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBAD0330h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte zero_g8i()
; location: [7FFDDBAD0350h, 7FFDDBAD0357h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g8iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte zero_g8u()
; location: [7FFDDBAD0370h, 7FFDDBAD0377h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short zero_g16i()
; location: [7FFDDBAD0390h, 7FFDDBAD0397h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g16iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort zero_g16u()
; location: [7FFDDBAD07B0h, 7FFDDBAD07B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int zero_g32i()
; location: [7FFDDBAD07D0h, 7FFDDBAD07D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint zero_g32u()
; location: [7FFDDBAD07F0h, 7FFDDBAD07F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long zero_g64i()
; location: [7FFDDBAD0810h, 7FFDDBAD0817h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong zero_g64u()
; location: [7FFDDBAD0830h, 7FFDDBAD0837h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float zero_g32f()
; location: [7FFDDBAD0850h, 7FFDDBAD0859h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double zero_g64f()
; location: [7FFDDBAD0870h, 7FFDDBAD087Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBAD0880h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_n8i()
; location: [7FFDDBAD08A0h, 7FFDDBAD08AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h            ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]             encoding(5 bytes) = b8 80 ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte minval_g8i()
; location: [7FFDDBAD08C0h, 7FFDDBAD08CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFFF80h            ; MOV(Mov_r32_imm32) [EAX,ffffff80h:imm32]             encoding(5 bytes) = b8 80 ff ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0xFF,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_n8u()
; location: [7FFDDBAD08E0h, 7FFDDBAD08E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte minval_g8u()
; location: [7FFDDBAD0900h, 7FFDDBAD0907h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g8uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_n16i()
; location: [7FFDDBAD0920h, 7FFDDBAD092Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h            ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]             encoding(5 bytes) = b8 00 80 ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_n16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short minval_g16i()
; location: [7FFDDBAD0940h, 7FFDDBAD094Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFF8000h            ; MOV(Mov_r32_imm32) [EAX,ffff8000h:imm32]             encoding(5 bytes) = b8 00 80 ff ff
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x80,0xFF,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort minval_g16u()
; location: [7FFDDBAD0960h, 7FFDDBAD0967h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g16uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_32i()
; location: [7FFDDBAD0980h, 7FFDDBAD098Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h             ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]             encoding(5 bytes) = b8 00 00 00 80
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int minval_g32i()
; location: [7FFDDBAD09A0h, 7FFDDBAD09AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80000000h             ; MOV(Mov_r32_imm32) [EAX,80000000h:imm32]             encoding(5 bytes) = b8 00 00 00 80
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_32u()
; location: [7FFDDBAD09C0h, 7FFDDBAD09C7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint minval_g32u()
; location: [7FFDDBAD09E0h, 7FFDDBAD09E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long minval_g64i()
; location: [7FFDDBAD0A00h, 7FFDDBAD0A0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong minval_g64u()
; location: [7FFDDBAD0E30h, 7FFDDBAD0E37h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float minval_g32f()
; location: [7FFDDBAD0E50h, 7FFDDBAD0E5Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss xmm0,dword ptr [7FFDDBAD0E60h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fa 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double minval_g64f()
; location: [7FFDDBAD0E80h, 7FFDDBAD0E8Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd xmm0,qword ptr [7FFDDBAD0E90h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RIP:br,:sr)] encoding(VEX, 8 bytes) = c5 fb 10 05 03 00 00 00
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> minval_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x10,0x05,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte maxval_g8i()
; location: [7FFDDBAD0EB0h, 7FFDDBAD0EBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7Fh                   ; MOV(Mov_r32_imm32) [EAX,7fh:imm32]                   encoding(5 bytes) = b8 7f 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g8iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x7F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte maxval_g8u()
; location: [7FFDDBAD0ED0h, 7FFDDBAD0EDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short maxval_g16i()
; location: [7FFDDBAD0EF0h, 7FFDDBAD0EFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFh                 ; MOV(Mov_r32_imm32) [EAX,7fffh:imm32]                 encoding(5 bytes) = b8 ff 7f 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g16iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x7F,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort maxval_g16u()
; location: [7FFDDBAD0F10h, 7FFDDBAD0F1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFFFh                ; MOV(Mov_r32_imm32) [EAX,ffffh:imm32]                 encoding(5 bytes) = b8 ff ff 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g16uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_n32i()
; location: [7FFDDBAD0F30h, 7FFDDBAD0F3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh             ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_n32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int maxval_g32i()
; location: [7FFDDBAD0F50h, 7FFDDBAD0F5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7FFFFFFFh             ; MOV(Mov_r32_imm32) [EAX,7fffffffh:imm32]             encoding(5 bytes) = b8 ff ff ff 7f
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maxval_g32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0xFF,0xFF,0x7F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
