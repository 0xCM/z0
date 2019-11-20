; 2019-11-20 01:20:43:033
; function: bit testbit_d8i(sbyte src, int pos)
; location: [7FFDD9F1A200h, 7FFDD9F1A212h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g8i(sbyte src, int pos)
; location: [7FFDD9F1A230h, 7FFDD9F1A242h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d8u(byte src, int pos)
; location: [7FFDD9F1A260h, 7FFDD9F1A271h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g8u(byte src, int pos)
; location: [7FFDD9F1A290h, 7FFDD9F1A2A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d16i(short src, int pos)
; location: [7FFDD9F1A2C0h, 7FFDD9F1A2D2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g16i(short src, int pos)
; location: [7FFDD9F1A2F0h, 7FFDD9F1A302h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d16u(ushort src, int pos)
; location: [7FFDD9F1A320h, 7FFDD9F1A331h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g16u(ushort src, int pos)
; location: [7FFDD9F1A350h, 7FFDD9F1A361h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d32i(int src, int pos)
; location: [7FFDD9F1A380h, 7FFDD9F1A38Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g32i(int src, int pos)
; location: [7FFDD9F1A7B0h, 7FFDD9F1A7BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d32u(uint src, int pos)
; location: [7FFDD9F1A7D0h, 7FFDD9F1A7DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g32u(uint src, int pos)
; location: [7FFDD9F1A7F0h, 7FFDD9F1A7FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d64i(long src, int pos)
; location: [7FFDD9F1A810h, 7FFDD9F1A81Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g64i(long src, int pos)
; location: [7FFDD9F1A830h, 7FFDD9F1A83Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d64u(ulong src, int pos)
; location: [7FFDD9F1A850h, 7FFDD9F1A85Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g64u(ulong src, int pos)
; location: [7FFDD9F1A870h, 7FFDD9F1A87Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d32f(float src, int pos)
; location: [7FFDD9F1A890h, 7FFDD9F1A8ACh]
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
; static ReadOnlySpan<byte> testbit_d32fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g32f(float src, int pos)
; location: [7FFDD9F1A8D0h, 7FFDD9F1A8ECh]
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
; static ReadOnlySpan<byte> testbit_g32fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_d64f(double src, int pos)
; location: [7FFDD9F1A910h, 7FFDD9F1A92Ch]
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
; static ReadOnlySpan<byte> testbit_d64fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit testbit_g64f(double src, int pos)
; location: [7FFDD9F1A950h, 7FFDD9F1A96Ch]
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
; static ReadOnlySpan<byte> testbit_g64fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_d8i(ref sbyte src, int pos)
; location: [7FFDD9F1A990h, 7FFDD9F1A9A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_g8i(ref sbyte src, int pos)
; location: [7FFDD9F1A9C0h, 7FFDD9F1A9D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g8iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte enable_d8u(ref byte src, int pos)
; location: [7FFDD9F1A9F0h, 7FFDD9F1AA09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte enable_g8u(ref byte src, int pos)
; location: [7FFDD9F1AA20h, 7FFDD9F1AA39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h or [rax],dl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,:sr),DL]                encoding(2 bytes) = 08 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g8uBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x08,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short enable_d16i(ref short src, int pos)
; location: [7FFDD9F1AA50h, 7FFDD9F1AA6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short enable_g16i(ref short src, int pos)
; location: [7FFDD9F1AA80h, 7FFDD9F1AA9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g16iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort enable_d16u(ref ushort src, int pos)
; location: [7FFDD9F1AAB0h, 7FFDD9F1AACAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort enable_g16u(ref ushort src, int pos)
; location: [7FFDD9F1AAE0h, 7FFDD9F1AAFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h or [rax],dx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,:sr),DX]             encoding(3 bytes) = 66 09 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g16uBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x09,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int enable_d32i(ref int src, int pos)
; location: [7FFDD9F1AB10h, 7FFDD9F1AB26h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int enable_g32i(ref int src, int pos)
; location: [7FFDD9F1AB40h, 7FFDD9F1AB56h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint enable_d32u(ref uint src, int pos)
; location: [7FFDD9F1AB70h, 7FFDD9F1AB86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint enable_g32u(ref uint src, int pos)
; location: [7FFDD9F1ABA0h, 7FFDD9F1ABB6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h or [rax],r8d                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,:sr),R8D]            encoding(3 bytes) = 44 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long enable_d64i(ref long src, int pos)
; location: [7FFDD9F1ABD0h, 7FFDD9F1ABE6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long enable_g64i(ref long src, int pos)
; location: [7FFDD9F1AC00h, 7FFDD9F1AC16h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong enable_d64u(ref ulong src, int pos)
; location: [7FFDD9F1AC30h, 7FFDD9F1AC46h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong enable_g64u(ref ulong src, int pos)
; location: [7FFDD9F1AC60h, 7FFDD9F1AC76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,:sr),R8]             encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float enable_d32f(ref float src, int pos)
; location: [7FFDD9F1AC90h, 7FFDD9F1ACC6h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
000ch vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
0012h mov r8d,[rsp+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 04
0017h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0022h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0025h mov [rsp],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R8D]          encoding(4 bytes) = 44 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d32fBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFA,0x10,0x00,0xC5,0xFA,0x11,0x44,0x24,0x04,0x44,0x8B,0x44,0x24,0x04,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x45,0x0B,0xC1,0x44,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float enable_g32f(ref float src, int pos)
; location: [7FFDD9F1ACE0h, 7FFDD9F1AD16h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovss xmm0,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 10 00
000ch vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
0012h mov r8d,[rsp+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 04
0017h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001fh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0022h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0025h mov [rsp],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R8D]          encoding(4 bytes) = 44 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g32fBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFA,0x10,0x00,0xC5,0xFA,0x11,0x44,0x24,0x04,0x44,0x8B,0x44,0x24,0x04,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE1,0x45,0x0B,0xC1,0x44,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double enable_d64f(ref double src, int pos)
; location: [7FFDD9F1AD30h, 7FFDD9F1AD6Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
000eh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0014h mov r8,[rsp+10h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,:sr)]           encoding(5 bytes) = 4c 8b 44 24 10
0019h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rsp+8],r8                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R8]           encoding(5 bytes) = 4c 89 44 24 08
002ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0032h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_d64fBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0xC1,0xC5,0xFB,0x10,0x00,0xC5,0xFB,0x11,0x44,0x24,0x10,0x4C,0x8B,0x44,0x24,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4D,0x0B,0xC1,0x4C,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double enable_g64f(ref double src, int pos)
; location: [7FFDD9F1AD90h, 7FFDD9F1ADCAh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah vmovsd xmm0,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb 10 00
000eh vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0014h mov r8,[rsp+10h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,:sr)]           encoding(5 bytes) = 4c 8b 44 24 10
0019h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rsp+8],r8                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),R8]           encoding(5 bytes) = 4c 89 44 24 08
002ch vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0032h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
0036h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> enable_g64fBytes => new byte[59]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0xC1,0xC5,0xFB,0x10,0x00,0xC5,0xFB,0x11,0x44,0x24,0x10,0x4C,0x8B,0x44,0x24,0x10,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4D,0x0B,0xC1,0x4C,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> hexdigits(ushort a)
; location: [7FFDD9F1B1F0h, 7FFDD9F1B202h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0008h mov rax,7FFDD9F1AE10h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9f1ae10h:imm64]         encoding(10 bytes) = 48 b8 10 ae f1 d9 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> hexdigitsBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xD2,0x48,0xB8,0x10,0xAE,0xF1,0xD9,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char hexdigit(byte a)
; location: [7FFDD9F1B220h, 7FFDD9F1B23Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000eh mov rdx,283252D202Dh          ; MOV(Mov_r64_imm64) [RDX,283252d202dh:imm64]          encoding(10 bytes) = 48 ba 2d 20 2d 25 83 02 00 00
0018h movzx eax,byte ptr [rax+rdx]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 04 10
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hexdigitBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x83,0xE0,0x0F,0x48,0x63,0xC0,0x48,0xBA,0x2D,0x20,0x2D,0x25,0x83,0x02,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void hexdigits(byte a, out Char d0, out Char d1)
; location: [7FFDD9F1B250h, 7FFDD9F1B284h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
000dh movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0010h mov r9,283252D202Dh           ; MOV(Mov_r64_imm64) [R9,283252d202dh:imm64]           encoding(10 bytes) = 49 b9 2d 20 2d 25 83 02 00 00
001ah movzx ecx,byte ptr [rcx+r9]   ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 09
001fh mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,:sr),CX]           encoding(3 bytes) = 66 89 0a
0022h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0025h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0028h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
002bh movzx eax,byte ptr [rax+r9]   ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 42 0f b6 04 08
0030h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),AX]            encoding(4 bytes) = 66 41 89 00
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hexdigitsBytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0x83,0xE1,0x0F,0x48,0x63,0xC9,0x49,0xB9,0x2D,0x20,0x2D,0x25,0x83,0x02,0x00,0x00,0x42,0x0F,0xB6,0x0C,0x09,0x66,0x89,0x0A,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x48,0x63,0xC0,0x42,0x0F,0xB6,0x04,0x08,0x66,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void datablock_store(in byte src, uint count, ref Block128 dst)
; location: [7FFDD9F1B2A0h, 7FFDD9F1B2B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
000bh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
000eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0011h call 7FFE39363850h            ; CALL(Call_rel32_64) [5F4485B0h:jmp64]                encoding(5 bytes) = e8 9a 85 44 5f
0016h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> datablock_storeBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x49,0x8B,0xC8,0x44,0x8B,0xC2,0x48,0x8B,0xD0,0xE8,0x9A,0x85,0x44,0x5F,0x90,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void datablock_bytes(ref Block128 src)
; location: [7FFDD9F1B2D0h, 7FFDD9F1B2F3h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mov [rsp+28h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 28
0015h mov [rsp+30h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 30
0019h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001eh call 7FFE3948ED50h            ; CALL(Call_rel32_64) [5F573A80h:jmp64]                encoding(5 bytes) = e8 5d 3a 57 5f
0023h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> datablock_bytesBytes => new byte[36]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0xB8,0x10,0x00,0x00,0x00,0x48,0x89,0x4C,0x24,0x28,0x89,0x44,0x24,0x30,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x5D,0x3A,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(byte value)
; location: [7FFDD9F1B450h, 7FFDD9F1B478h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
000bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000eh mov rdx,283252D182Dh          ; MOV(Mov_r64_imm64) [RDX,283252d182dh:imm64]          encoding(10 bytes) = 48 ba 2d 18 2d 25 83 02 00 00
0018h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
001bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001eh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 41 08 08 00 00 00
0025h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseqBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x48,0x63,0xC0,0x48,0xBA,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_8u(byte value, Span<byte> dst)
; location: [7FFDD9F1B8A0h, 7FFDD9F1B8C4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
000eh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0011h mov rcx,283252D182Dh          ; MOV(Mov_r64_imm64) [RCX,283252d182dh:imm64]          encoding(10 bytes) = 48 b9 2d 18 2d 25 83 02 00 00
001bh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
001eh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0021h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq_8uBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0xC1,0xE2,0x03,0x48,0x63,0xD2,0x48,0xB9,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0x12,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_16u(ushort value, Span<byte> dst)
; location: [7FFDD9F1B8E0h, 7FFDD9F1B925h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0012h shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
0016h movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
0019h mov r9,283252D182Dh           ; MOV(Mov_r64_imm64) [R9,283252d182dh:imm64]           encoding(10 bytes) = 49 b9 2d 18 2d 25 83 02 00 00
0023h add r8,r9                     ; ADD(Add_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 03 c1
0026h mov r8,[r8]                   ; MOV(Mov_r64_rm64) [R8,mem(64u,R8:br,:sr)]            encoding(3 bytes) = 4d 8b 00
0029h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
002ch add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
0030h sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
0033h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0036h shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
0039h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
003ch add rdx,r9                    ; ADD(Add_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 03 d1
003fh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0042h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq_16uBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x48,0x8B,0xC8,0x44,0x0F,0xB6,0xC2,0x41,0xC1,0xE0,0x03,0x4D,0x63,0xC0,0x49,0xB9,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x4D,0x03,0xC1,0x4D,0x8B,0x00,0x4C,0x89,0x01,0x48,0x83,0xC0,0x08,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC1,0xE2,0x03,0x48,0x63,0xD2,0x49,0x03,0xD1,0x48,0x8B,0x12,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_32u(uint value, Span<byte> dst)
; location: [7FFDD9F1B940h, 7FFDD9F1B985h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000dh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0010h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0013h movsxd r9,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]                     encoding(3 bytes) = 4c 63 c9
0016h add r9,rax                    ; ADD(Add_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 03 c8
0019h mov r10d,edx                  ; MOV(Mov_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 8b d2
001ch shr r10d,cl                   ; SHR(Shr_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 ea
001fh movzx ecx,r10b                ; MOVZX(Movzx_r32_rm8) [ECX,R10L]                      encoding(4 bytes) = 41 0f b6 ca
0023h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0026h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0029h mov r10,283252D182Dh          ; MOV(Mov_r64_imm64) [R10,283252d182dh:imm64]          encoding(10 bytes) = 49 ba 2d 18 2d 25 83 02 00 00
0033h add rcx,r10                   ; ADD(Add_r64_rm64) [RCX,R10]                          encoding(3 bytes) = 49 03 ca
0036h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
0039h mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RCX]           encoding(3 bytes) = 49 89 09
003ch inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
003fh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0043h jl short 000dh                ; JL(Jl_rel8_64) [Dh:jmp64]                            encoding(2 bytes) = 7c c8
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq_32uBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x45,0x33,0xC0,0x41,0x8B,0xC8,0xC1,0xE1,0x03,0x4C,0x63,0xC9,0x4C,0x03,0xC8,0x44,0x8B,0xD2,0x41,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xBA,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x49,0x03,0xCA,0x48,0x8B,0x09,0x49,0x89,0x09,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x04,0x7C,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseq_64u(ulong value, Span<byte> dst)
; location: [7FFDD9F1B9A0h, 7FFDD9F1B9E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000eh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0011h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0014h movsxd r9,ecx                 ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]                     encoding(3 bytes) = 4c 63 c9
0017h add r9,rax                    ; ADD(Add_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 03 c8
001ah mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
001dh shr r10,cl                    ; SHR(Shr_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 ea
0020h movzx ecx,r10b                ; MOVZX(Movzx_r32_rm8) [ECX,R10L]                      encoding(4 bytes) = 41 0f b6 ca
0024h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
0027h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
002ah mov r10,283252D182Dh          ; MOV(Mov_r64_imm64) [R10,283252d182dh:imm64]          encoding(10 bytes) = 49 ba 2d 18 2d 25 83 02 00 00
0034h add rcx,r10                   ; ADD(Add_r64_rm64) [RCX,R10]                          encoding(3 bytes) = 49 03 ca
0037h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
003ah mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RCX]           encoding(3 bytes) = 49 89 09
003dh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0040h cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
0044h jl short 000eh                ; JL(Jl_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 7c c8
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq_64uBytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0xD1,0x45,0x33,0xC0,0x41,0x8B,0xC8,0xC1,0xE1,0x03,0x4C,0x63,0xC9,0x4C,0x03,0xC8,0x4C,0x8B,0xD2,0x49,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xBA,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x49,0x03,0xCA,0x48,0x8B,0x09,0x49,0x89,0x09,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x08,0x7C,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(int offset, int count)
; location: [7FFDD9F1BA00h, 7FFDD9F1BA39h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
000ah add rax,r9                    ; ADD(Add_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 03 c1
000dh cmp rax,800h                  ; CMP(Cmp_RAX_imm32) [RAX,800h:imm64]                  encoding(6 bytes) = 48 3d 00 08 00 00
0013h ja short 0034h                ; JA(Ja_rel8_64) [34h:jmp64]                           encoding(2 bytes) = 77 1f
0015h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0018h mov rdx,283252D182Dh          ; MOV(Mov_r64_imm64) [RDX,283252d182dh:imm64]          encoding(10 bytes) = 48 ba 2d 18 2d 25 83 02 00 00
0022h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R8D]          encoding(4 bytes) = 44 89 41 08
002ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0034h call 7FFDD985E4A8h            ; CALL(Call_rel32_64) [FFFFFFFFFF942AA8h:jmp64]        encoding(5 bytes) = e8 6f 2a 94 ff
0039h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[58]{0x48,0x83,0xEC,0x28,0x90,0x8B,0xC2,0x45,0x8B,0xC8,0x49,0x03,0xC1,0x48,0x3D,0x00,0x08,0x00,0x00,0x77,0x1F,0x48,0x63,0xC2,0x48,0xBA,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x6F,0x2A,0x94,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8u(byte src)
; location: [7FFDD9F1BA50h, 7FFDD9F1BAA8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000bh mov rcx,7FFDD981EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd981ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 81 d9 fd 7f 00 00
0015h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
001ah call 7FFE393645E0h            ; CALL(Call_rel32_64) [5F448B90h:jmp64]                encoding(5 bytes) = e8 71 8b 44 5f
001fh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
0023h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0027h shl ecx,3                     ; SHL(Shl_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e1 03
002ah movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
002dh mov r8,283252D182Dh           ; MOV(Mov_r64_imm64) [R8,283252d182dh:imm64]           encoding(10 bytes) = 49 b8 2d 18 2d 25 83 02 00 00
0037h add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
003ah mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
003dh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0040h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0044h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0049h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
004ch mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
004fh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0052h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0056h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0057h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq8uBytes => new byte[89]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0x81,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x08,0x00,0x00,0x00,0xE8,0x71,0x8B,0x44,0x5F,0x48,0x8D,0x50,0x10,0x40,0x0F,0xB6,0xCF,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xB8,0x2D,0x18,0x2D,0x25,0x83,0x02,0x00,0x00,0x49,0x03,0xC8,0x48,0x8B,0x09,0x48,0x89,0x0A,0x48,0x83,0xC0,0x10,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1BED0h, 7FFDD9F1BEFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000fh sub r9,[r8]                   ; SUB(Sub_r64_rm64) [R9,mem(64u,R8:br,:sr)]            encoding(3 bytes) = 4d 2b 08
0012h cmp rax,r9                    ; CMP(Cmp_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 3b c1
0015h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh sub rdx,[r8+8]                ; SUB(Sub_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 2b 50 08
001fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0021h sub rdx,rax                   ; SUB(Sub_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 2b d0
0024h mov [rcx],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R9]           encoding(3 bytes) = 4c 89 09
0027h mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
002bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_128u_aBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0xC8,0x4D,0x2B,0x08,0x49,0x3B,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x49,0x2B,0x50,0x08,0x8B,0xC0,0x48,0x2B,0xD0,0x4C,0x89,0x09,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void sub_128u_b(in ulong a, in ulong b, ref ulong c)
; location: [7FFDD9F1BF10h, 7FFDD9F1BF3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h sub rax,[rdx]                 ; SUB(Sub_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 2b 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
000eh mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0011h cmp rax,[r8]                  ; CMP(Cmp_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 3b 00
0014h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah add r8,8                      ; ADD(Add_rm64_imm8) [R8,8h:imm64]                     encoding(4 bytes) = 49 83 c0 08
001eh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
0022h sub rcx,[rdx+8]               ; SUB(Sub_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 2b 4a 08
0026h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0028h sub rcx,rax                   ; SUB(Sub_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 2b c8
002bh mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RCX]           encoding(3 bytes) = 49 89 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_128u_bBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x2B,0x02,0x49,0x89,0x00,0x48,0x8B,0x01,0x49,0x3B,0x00,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x49,0x83,0xC0,0x08,0x48,0x8B,0x49,0x08,0x48,0x2B,0x4A,0x08,0x8B,0xC0,0x48,0x2B,0xC8,0x49,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong byteswap64(ulong src)
; location: [7FFDD9F1BF50h, 7FFDD9F1BFCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,38h                   ; SHR(Shr_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e8 38
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h shr rdx,30h                   ; SHR(Shr_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 ea 30
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
001dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0020h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0023h shr rdx,28h                   ; SHR(Shr_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 ea 28
0027h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ah shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
002eh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0031h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh shl rdx,18h                   ; SHL(Shl_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 e2 18
003fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0042h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0045h shr rdx,18h                   ; SHR(Shr_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 ea 18
0049h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004ch shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
0050h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0053h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0056h shr rdx,10h                   ; SHR(Shr_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 ea 10
005ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
005dh shl rdx,28h                   ; SHL(Shl_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 e2 28
0061h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0064h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0067h shr rdx,8                     ; SHR(Shr_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 ea 08
006bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
006eh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
0072h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0075h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0078h shl rdx,38h                   ; SHL(Shl_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 e2 38
007ch or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
007fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> byteswap64Bytes => new byte[128]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x38,0x0F,0xB6,0xC0,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x30,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x28,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x18,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x10,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x28,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x08,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0x0F,0xB6,0xD1,0x48,0xC1,0xE2,0x38,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 mul_8u(UInt8 a, UInt8 b)
; location: [7FFDD9F1BFE0h, 7FFDD9F1BFEFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
; location: [7FFDD9F1C000h, 7FFDD9F1C028h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
000ch mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
0011h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0014h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0017h mulx rax,r9,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,R9,RCX]             encoding(VEX, 5 bytes) = c4 e2 b3 f6 c1
001ch mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
001fh mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
0024h mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_128uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x48,0x8B,0xD0,0xC4,0xE2,0xB3,0xF6,0xC1,0x4D,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x48,0x89,0x42,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1C040h, 7FFDD9F1C06Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000fh add r9,[r8]                   ; ADD(Add_r64_rm64) [R9,mem(64u,R8:br,:sr)]            encoding(3 bytes) = 4d 03 08
0012h cmp rax,r9                    ; CMP(Cmp_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 3b c1
0015h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh add rdx,[r8+8]                ; ADD(Add_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 03 50 08
001fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0021h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0024h mov [rcx],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R9]           encoding(3 bytes) = 4c 89 09
0027h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
002bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_128uBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0xC8,0x4D,0x03,0x08,0x49,0x3B,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x49,0x03,0x50,0x08,0x8B,0xC0,0x48,0x03,0xC2,0x4C,0x89,0x09,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1C080h, 7FFDD9F1C09Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h xor rax,[r8]                  ; XOR(Xor_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 33 00
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh xor rdx,[r8+8]                ; XOR(Xor_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 33 50 08
0013h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0016h mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_128uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x49,0x33,0x00,0x48,0x8B,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1C0B0h, 7FFDD9F1C0D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h xor rax,[r8]                  ; XOR(Xor_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 33 00
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh xor rdx,[r8+8]                ; XOR(Xor_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 33 50 08
0013h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0016h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0019h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001ch mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_128uBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x49,0x33,0x00,0x48,0x8B,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> negate_128u(Pair<ulong> a)
; location: [7FFDD9F1C0F0h, 7FFDD9F1C11Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000fh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0012h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 01
0016h cmp rax,r8                    ; CMP(Cmp_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 3b c0
0019h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0022h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0025h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
0029h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_128uBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x4C,0x8D,0x40,0x01,0x49,0x3B,0xC0,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x48,0x03,0xC2,0x4C,0x89,0x01,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> inc_128u(ref Pair<ulong> a)
; location: [7FFDD9F1C130h, 7FFDD9F1C158h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax+1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 01
000ch cmp rax,rdx                   ; CMP(Cmp_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 3b c2
000fh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h mov r8,[rcx+8]                ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,:sr)]           encoding(4 bytes) = 4c 8b 41 08
0019h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
001bh add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
001eh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0021h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
0025h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_128uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0x01,0x48,0x3B,0xC2,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x4C,0x8B,0x41,0x08,0x8B,0xC0,0x49,0x03,0xC0,0x48,0x89,0x11,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> srl_128u(Pair<ulong> a, int offset)
; location: [7FFDD9F1C170h, 7FFDD9F1C1D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0013h jl short 0035h                ; JL(Jl_rel8_64) [35h:jmp64]                           encoding(2 bytes) = 7c 20
0015h cmp r8d,80h                   ; CMP(Cmp_rm32_imm32) [R8D,80h:imm32]                  encoding(7 bytes) = 41 81 f8 80 00 00 00
001ch jl short 0026h                ; JL(Jl_rel8_64) [26h:jmp64]                           encoding(2 bytes) = 7c 08
001eh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0021h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0024h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 3c
0026h lea ecx,[r8-40h]              ; LEA(Lea_r32_m) [ECX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 41 8d 48 c0
002ah shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
002dh mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
0030h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0033h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 2d
0035h mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
0038h and r10d,3Fh                  ; AND(And_rm32_imm8) [R10D,3fh:imm32]                  encoding(4 bytes) = 41 83 e2 3f
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh mov r11,rdx                   ; MOV(Mov_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 8b da
0042h shr r11,cl                    ; SHR(Shr_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 eb
0045h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0048h shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
004bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
004eh neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0050h add ecx,3Fh                   ; ADD(Add_rm32_imm8) [ECX,3fh:imm32]                   encoding(3 bytes) = 83 c1 3f
0053h shl rdx,1                     ; SHL(Shl_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 e2
0056h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0059h or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
005ch mov r10,r11                   ; MOV(Mov_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 8b d3
005fh mov r11,rdx                   ; MOV(Mov_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 8b da
0062h mov [rax],r10                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R10]          encoding(3 bytes) = 4c 89 10
0065h mov [rax+8],r11               ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R11]          encoding(4 bytes) = 4c 89 58 08
0069h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_128uBytes => new byte[106]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x0A,0x48,0x8B,0x52,0x08,0x41,0x83,0xF8,0x40,0x7C,0x20,0x41,0x81,0xF8,0x80,0x00,0x00,0x00,0x7C,0x08,0x45,0x33,0xD2,0x45,0x33,0xDB,0xEB,0x3C,0x41,0x8D,0x48,0xC0,0x49,0xD3,0xE9,0x4D,0x8B,0xD9,0x45,0x33,0xD2,0xEB,0x2D,0x45,0x8B,0xD0,0x41,0x83,0xE2,0x3F,0x41,0x8B,0xCA,0x4C,0x8B,0xDA,0x49,0xD3,0xEB,0x41,0x8B,0xCA,0x49,0xD3,0xE9,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x3F,0x48,0xD1,0xE2,0x48,0xD3,0xE2,0x49,0x0B,0xD1,0x4D,0x8B,0xD3,0x4C,0x8B,0xDA,0x4C,0x89,0x10,0x4C,0x89,0x58,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> sll_128u(Pair<ulong> a, int offset)
; location: [7FFDD9F1C1F0h, 7FFDD9F1C259h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0013h jl short 0035h                ; JL(Jl_rel8_64) [35h:jmp64]                           encoding(2 bytes) = 7c 20
0015h cmp r8d,80h                   ; CMP(Cmp_rm32_imm32) [R8D,80h:imm32]                  encoding(7 bytes) = 41 81 f8 80 00 00 00
001ch jl short 0026h                ; JL(Jl_rel8_64) [26h:jmp64]                           encoding(2 bytes) = 7c 08
001eh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0021h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0024h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 3c
0026h lea ecx,[r8-40h]              ; LEA(Lea_r32_m) [ECX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 41 8d 48 c0
002ah shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
002dh mov r10,r9                    ; MOV(Mov_r64_rm64) [R10,R9]                           encoding(3 bytes) = 4d 8b d1
0030h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0033h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 2d
0035h mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
0038h and r10d,3Fh                  ; AND(And_rm32_imm8) [R10D,3fh:imm32]                  encoding(4 bytes) = 41 83 e2 3f
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0042h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0045h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0047h add ecx,3Fh                   ; ADD(Add_rm32_imm8) [ECX,3fh:imm32]                   encoding(3 bytes) = 83 c1 3f
004ah mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
004dh shr r11,1                     ; SHR(Shr_rm64_1) [R11,1h:imm8]                        encoding(3 bytes) = 49 d1 eb
0050h shr r11,cl                    ; SHR(Shr_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 eb
0053h or rdx,r11                    ; OR(Or_r64_rm64) [RDX,R11]                            encoding(3 bytes) = 49 0b d3
0056h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0059h mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
005ch shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
005fh mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
0062h mov [rax],r10                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R10]          encoding(3 bytes) = 4c 89 10
0065h mov [rax+8],r11               ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R11]          encoding(4 bytes) = 4c 89 58 08
0069h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_128uBytes => new byte[106]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x0A,0x48,0x8B,0x52,0x08,0x41,0x83,0xF8,0x40,0x7C,0x20,0x41,0x81,0xF8,0x80,0x00,0x00,0x00,0x7C,0x08,0x45,0x33,0xD2,0x45,0x33,0xDB,0xEB,0x3C,0x41,0x8D,0x48,0xC0,0x49,0xD3,0xE1,0x4D,0x8B,0xD1,0x45,0x33,0xDB,0xEB,0x2D,0x45,0x8B,0xD0,0x41,0x83,0xE2,0x3F,0x41,0x8B,0xCA,0x48,0xD3,0xE2,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x3F,0x4D,0x8B,0xD9,0x49,0xD1,0xEB,0x49,0xD3,0xEB,0x49,0x0B,0xD3,0x41,0x8B,0xCA,0x4D,0x8B,0xD9,0x49,0xD3,0xE3,0x4C,0x8B,0xD2,0x4C,0x89,0x10,0x4C,0x89,0x58,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit same_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1C270h, 7FFDD9F1C292h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h cmp rax,[rdx]                 ; CMP(Cmp_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 3b 02
000bh jne short 001dh               ; JNE(Jne_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = 75 10
000dh mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 41 08
0011h cmp rax,[rdx+8]               ; CMP(Cmp_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 3b 42 08
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 02
001dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> same_128uBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x3B,0x02,0x75,0x10,0x48,0x8B,0x41,0x08,0x48,0x3B,0x42,0x08,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1C2B0h, 7FFDD9F1C2E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,:sr)]           encoding(3 bytes) = 4c 8b 01
000fh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
0013h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0016h setb r9b                      ; SETB(Setb_rm8) [R9L]                                 encoding(4 bytes) = 41 0f 92 c1
001ah movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
001eh cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0021h jne short 002eh               ; JNE(Jne_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 75 0b
0023h cmp r8,rax                    ; CMP(Cmp_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 3b c0
0026h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch jmp short 0030h               ; JMP(Jmp_rel8_64) [30h:jmp64]                         encoding(2 bytes) = eb 02
002eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0030h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_128uBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x3B,0xCA,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x48,0x3B,0xCA,0x75,0x0B,0x4C,0x3B,0xC0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FFDD9F1C300h, 7FFDD9F1C33Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,:sr)]           encoding(3 bytes) = 4c 8b 01
000fh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
0013h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0016h setb r9b                      ; SETB(Setb_rm8) [R9L]                                 encoding(4 bytes) = 41 0f 92 c1
001ah movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
001eh cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0021h jne short 002eh               ; JNE(Jne_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 75 0b
0023h cmp r8,rax                    ; CMP(Cmp_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 3b c0
0026h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch jmp short 0030h               ; JMP(Jmp_rel8_64) [30h:jmp64]                         encoding(2 bytes) = eb 02
002eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0030h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0038h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_128uBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x3B,0xCA,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x48,0x3B,0xCA,0x75,0x0B,0x4C,0x3B,0xC0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_32u(Pair<uint> src, ref Pair<uint> dst)
; location: [7FFDD9F1C350h, 7FFDD9F1C37Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 08
000ah mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
000eh mov ecx,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 0c
0012h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
0017h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
001ah mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
001ch mulx eax,r9d,ecx              ; MULX(VEX_Mulx_r32_r32_rm32) [EAX,R9D,ECX]            encoding(VEX, 5 bytes) = c4 e2 33 f6 c1
0021h mov [r8],r9d                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),R9D]           encoding(3 bytes) = 45 89 08
0024h mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
0029h mov [rdx+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),EAX]          encoding(3 bytes) = 89 42 04
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_32uBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x8B,0x44,0x24,0x08,0x8B,0x4C,0x24,0x0C,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x8B,0xD0,0xC4,0xE2,0x33,0xF6,0xC1,0x45,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x89,0x42,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 or_8u(UInt8 a, UInt8 b)
; location: [7FFDD9F1C390h, 7FFDD9F1C399h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_8uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_16(uint a)
; location: [7FFDD9F1C3B0h, 7FFDD9F1C3C5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_16Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_16(uint a)
; location: [7FFDD9F1C3E0h, 7FFDD9F1C3F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,1000000000000000h     ; MOV(Mov_r64_imm64) [RDX,1000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 10
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_16Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_25(uint a)
; location: [7FFDD9F1C410h, 7FFDD9F1C42Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h mov rax,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RAX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 b8 71 3d 0a d7 a3 70 3d 0a
0011h imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
0015h mov eax,19h                   ; MOV(Mov_r32_imm32) [EAX,19h:imm32]                   encoding(5 bytes) = b8 19 00 00 00
001ah mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_25Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xB8,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0x48,0x0F,0xAF,0xD0,0xB8,0x19,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_25(uint a)
; location: [7FFDD9F1C440h, 7FFDD9F1C456h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RDX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 ba 71 3d 0a d7 a3 70 3d 0a
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_25Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_32(uint a)
; location: [7FFDD9F1C470h, 7FFDD9F1C485h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Bh                   ; SHL(Shl_rm64_imm8) [RDX,3bh:imm8]                    encoding(4 bytes) = 48 c1 e2 3b
000bh mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_32Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3B,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_32(uint a)
; location: [7FFDD9F1C4A0h, 7FFDD9F1C4B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,800000000000000h      ; MOV(Mov_r64_imm64) [RDX,800000000000000h:imm64]      encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 08
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_32Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
