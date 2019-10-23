; 2019-10-22 17:23:23:608
; function: float convert_32f_to_g32f(float src)
; location: [7FFDD9D682C0h, 7FFDD9D682C5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g32fBytes => new byte[6]{0xC5,0xF8,0x77,0x66,0x90,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_32f_to_g64f(float src)
; location: [7FFDD9D682E0h, 7FFDD9D682E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvtss2sd xmm0,xmm0,xmm0      ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fa 5a c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g64fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x5A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_32f_to_gch16(float src)
; location: [7FFDD9D68300h, 7FFDD9D6830Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si eax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r32_xmmm32) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fa 2c c0
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_gch16Bytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x2C,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_64f_to_8i(double src)
; location: [7FFDD9D68320h, 7FFDD9D6832Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_64f_to_g8i(double src)
; location: [7FFDD9D68340h, 7FFDD9D6834Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_g64f_to_g8i(double src)
; location: [7FFDD9D68360h, 7FFDD9D68374h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g8iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_64f_to_8u(double src)
; location: [7FFDD9D68390h, 7FFDD9D6839Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si rax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r64_xmmm64) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fb 2c c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_8uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xFB,0x2C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_64f_to_g8u(double src)
; location: [7FFDD9D683B0h, 7FFDD9D683BCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g8uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_g64f_to_g8u(double src)
; location: [7FFDD9D687E0h, 7FFDD9D687F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_64f_to_16i(double src)
; location: [7FFDD9D68810h, 7FFDD9D6881Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_16iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_64f_to_g16i(double src)
; location: [7FFDD9D68830h, 7FFDD9D6884Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0011h movsx rax,word ptr [rsp+4]    ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 04
0017h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g16iBytes => new byte[28]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x2C,0xC0,0x48,0x0F,0xBE,0xC0,0x88,0x44,0x24,0x04,0x48,0x0F,0xBF,0x44,0x24,0x04,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_g64f_to_g16i(double src)
; location: [7FFDD9D68870h, 7FFDD9D68884h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g16iBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_64f_to_g16u(double src)
; location: [7FFDD9D688A0h, 7FFDD9D688ACh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g16uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_g64f_to_g16u(double src)
; location: [7FFDD9D688C0h, 7FFDD9D688D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_64f_to_g32i(double src)
; location: [7FFDD9D688F0h, 7FFDD9D688F9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g32iBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_g64f_to_g32i(double src)
; location: [7FFDD9D68910h, 7FFDD9D68920h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g32iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_64f_to_g32u(double src)
; location: [7FFDD9D68940h, 7FFDD9D6894Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si rax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r64_xmmm64) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fb 2c c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g32uBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xFB,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_g64f_to_g32u(double src)
; location: [7FFDD9D68960h, 7FFDD9D68970h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g32uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_64f_to_g64i(double src)
; location: [7FFDD9D68990h, 7FFDD9D6899Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si rax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r64_xmmm64) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fb 2c c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g64iBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xFB,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_g64f_to_g64i(double src)
; location: [7FFDD9D689B0h, 7FFDD9D689C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g64iBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_64f_to_g64u(double src)
; location: [7FFDD9D689E0h, 7FFDD9D689ECh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g64uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_g64f_to_g64u(double src)
; location: [7FFDD9D68A00h, 7FFDD9D68A10h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64f_to_g64uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_64f_to_g32f(double src)
; location: [7FFDD9D68A30h, 7FFDD9D68A39h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvtsd2ss xmm0,xmm0,xmm0      ; VCVTSD2SS(VEX_Vcvtsd2ss_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 5a c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g32fBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x5A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_64f_to_g64f(double src)
; location: [7FFDD9D68A50h, 7FFDD9D68A55h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_g64fBytes => new byte[6]{0xC5,0xF8,0x77,0x66,0x90,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_64f_to_gch16(double src)
; location: [7FFDD9D68A70h, 7FFDD9D68A7Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttsd2si eax,xmm0           ; VCVTTSD2SI(VEX_Vcvttsd2si_r32_xmmm64) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fb 2c c0
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64f_to_gch16Bytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x2C,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_ch16_to_8i(Char src)
; location: [7FFDD9D68A90h, 7FFDD9D68A9Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_8iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_ch16_to_g8i(Char src)
; location: [7FFDD9D68EC0h, 7FFDD9D68ECCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g8iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_ch16_to_g8u(Char src)
; location: [7FFDD9D68EE0h, 7FFDD9D68EEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g8uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_ch16_to_16i(Char src)
; location: [7FFDD9D68F00h, 7FFDD9D68F0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_16iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_ch16_to_g16i(Char src)
; location: [7FFDD9D68F20h, 7FFDD9D68F2Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g16iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_ch16_to_16u(Char src)
; location: [7FFDD9D68F40h, 7FFDD9D68F48h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_ch16_to_g16u(Char src)
; location: [7FFDD9D68F60h, 7FFDD9D68F68h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_ch16_to_g32i(Char src)
; location: [7FFDD9D68F80h, 7FFDD9D68F88h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_ch16_to_g32u(Char src)
; location: [7FFDD9D68FA0h, 7FFDD9D68FA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_ch16_to_g64i(Char src)
; location: [7FFDD9D68FC0h, 7FFDD9D68FC8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_ch16_to_g64u(Char src)
; location: [7FFDD9D68FE0h, 7FFDD9D68FE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_ch16_to_g32f(Char src)
; location: [7FFDD9D69000h, 7FFDD9D69010h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000ch vcvtsi2ss xmm0,xmm0,eax       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fa 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_ch16_to_g64f(Char src)
; location: [7FFDD9D69030h, 7FFDD9D69040h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000ch vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_g64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_ch16_to_gch16(Char src)
; location: [7FFDD9D69060h, 7FFDD9D69068h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_ch16_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x8u(Vector128<byte> src, ref byte dst)
; location: [7FFDD9D69080h, 7FFDD9D6908Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x8uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x8u(Vec128<byte> src, ref byte dst)
; location: [7FFDD9D690A0h, 7FFDD9D690ADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x8uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x8u(Vec128<byte> src, ref byte dst)
; location: [7FFDD9D690C0h, 7FFDD9D690CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x8uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x8i(Vector128<sbyte> src, ref sbyte dst)
; location: [7FFDD9D690E0h, 7FFDD9D690EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x8i(Vec128<sbyte> src, ref sbyte dst)
; location: [7FFDD9D69100h, 7FFDD9D6910Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x8i(Vec128<sbyte> src, ref sbyte dst)
; location: [7FFDD9D69120h, 7FFDD9D6912Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x16i(Vector128<short> src, ref short dst)
; location: [7FFDD9D69140h, 7FFDD9D6914Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x16iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x16i(Vec128<short> src, ref short dst)
; location: [7FFDD9D69160h, 7FFDD9D6916Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x16iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x16i(Vec128<short> src, ref short dst)
; location: [7FFDD9D69180h, 7FFDD9D6918Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x16iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x16u(Vector128<ushort> src, ref ushort dst)
; location: [7FFDD9D691A0h, 7FFDD9D691ADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x16uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x16u(Vec128<ushort> src, ref ushort dst)
; location: [7FFDD9D691C0h, 7FFDD9D691CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x16uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x16u(Vec128<ushort> src, ref ushort dst)
; location: [7FFDD9D691E0h, 7FFDD9D691EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x16uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x32i(Vector128<int> src, ref int dst)
; location: [7FFDD9D69200h, 7FFDD9D6920Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x32iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x32i(Vec128<int> src, ref int dst)
; location: [7FFDD9D69220h, 7FFDD9D6922Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x32iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x32i(Vec128<int> src, ref int dst)
; location: [7FFDD9D69240h, 7FFDD9D6924Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x32iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x32u(Vector128<uint> src, ref uint dst)
; location: [7FFDD9D69260h, 7FFDD9D6926Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x32uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x32u(Vec128<uint> src, ref uint dst)
; location: [7FFDD9D69280h, 7FFDD9D6928Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x32uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x32u(Vec128<uint> src, ref uint dst)
; location: [7FFDD9D692A0h, 7FFDD9D692ADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x32uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x64i(Vector128<long> src, ref long dst)
; location: [7FFDD9D692C0h, 7FFDD9D692CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x64iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x64i(Vec128<long> src, ref long dst)
; location: [7FFDD9D692E0h, 7FFDD9D692EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x64iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x64i(Vec128<long> src, ref long dst)
; location: [7FFDD9D69710h, 7FFDD9D6971Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x64iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x64u(Vector128<ulong> src, ref ulong dst)
; location: [7FFDD9D69730h, 7FFDD9D6973Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x64uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x64u(Vec128<ulong> src, ref ulong dst)
; location: [7FFDD9D69750h, 7FFDD9D6975Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x64uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x64u(Vec128<ulong> src, ref ulong dst)
; location: [7FFDD9D69770h, 7FFDD9D6977Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x64uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x32f(Vector128<float> src, ref float dst)
; location: [7FFDD9D69790h, 7FFDD9D6979Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovups [rdx],xmm0            ; VMOVUPS(VEX_Vmovups_xmmm128_xmm) [mem(Packed128_Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f8 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x32f(Vec128<float> src, ref float dst)
; location: [7FFDD9D697B0h, 7FFDD9D697BDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovups [rdx],xmm0            ; VMOVUPS(VEX_Vmovups_xmmm128_xmm) [mem(Packed128_Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f8 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x32f(Vec128<float> src, ref float dst)
; location: [7FFDD9D697D0h, 7FFDD9D697DDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovups [rdx],xmm0            ; VMOVUPS(VEX_Vmovups_xmmm128_xmm) [mem(Packed128_Float32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f8 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n128x64f(Vector128<double> src, ref double dst)
; location: [7FFDD9D697F0h, 7FFDD9D697FDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n128x64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d128x64f(Vec128<double> src, ref double dst)
; location: [7FFDD9D69810h, 7FFDD9D6981Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d128x64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g128x64f(Vec128<double> src, ref double dst)
; location: [7FFDD9D69830h, 7FFDD9D6983Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g128x64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x8u(Vector256<byte> src, ref byte dst)
; location: [7FFDD9D69850h, 7FFDD9D69860h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x8uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x8u(Vec256<byte> src, ref byte dst)
; location: [7FFDD9D69880h, 7FFDD9D69890h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x8uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x8u(Vec256<byte> src, ref byte dst)
; location: [7FFDD9D698B0h, 7FFDD9D698C0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x8uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x8i(Vector256<sbyte> src, ref sbyte dst)
; location: [7FFDD9D698E0h, 7FFDD9D698F0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x8iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x8i(Vec256<sbyte> src, ref sbyte dst)
; location: [7FFDD9D69910h, 7FFDD9D69920h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x8iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x8i(Vec256<sbyte> src, ref sbyte dst)
; location: [7FFDD9D69940h, 7FFDD9D69950h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x8iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x16i(Vector256<short> src, ref short dst)
; location: [7FFDD9D69970h, 7FFDD9D69980h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x16iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x16i(Vec256<short> src, ref short dst)
; location: [7FFDD9D699A0h, 7FFDD9D699B0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x16iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x16i(Vec256<short> src, ref short dst)
; location: [7FFDD9D699D0h, 7FFDD9D699E0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x16iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x16u(Vector256<ushort> src, ref ushort dst)
; location: [7FFDD9D69A00h, 7FFDD9D69A10h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x16uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x16u(Vec256<ushort> src, ref ushort dst)
; location: [7FFDD9D69A30h, 7FFDD9D69A40h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x16uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x16u(Vec256<ushort> src, ref ushort dst)
; location: [7FFDD9D69A60h, 7FFDD9D69A70h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x16uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x32i(Vector256<int> src, ref int dst)
; location: [7FFDD9D69A90h, 7FFDD9D69AA0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x32iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x32i(Vec256<int> src, ref int dst)
; location: [7FFDD9D69AC0h, 7FFDD9D69AD0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x32iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x32i(Vec256<int> src, ref int dst)
; location: [7FFDD9D69AF0h, 7FFDD9D69B00h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x32iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x32u(Vector256<uint> src, ref uint dst)
; location: [7FFDD9D69B20h, 7FFDD9D69B30h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x32u(Vec256<uint> src, ref uint dst)
; location: [7FFDD9D69B50h, 7FFDD9D69B60h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x32u(Vec256<uint> src, ref uint dst)
; location: [7FFDD9D69B80h, 7FFDD9D69B90h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x64i(Vector256<long> src, ref long dst)
; location: [7FFDD9D69BB0h, 7FFDD9D69BC0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x64iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x64i(Vec256<long> src, ref long dst)
; location: [7FFDD9D69BE0h, 7FFDD9D69BF0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x64iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x64i(Vec256<long> src, ref long dst)
; location: [7FFDD9D69C10h, 7FFDD9D69C20h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x64iBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x64u(Vector256<ulong> src, ref ulong dst)
; location: [7FFDD9D69C40h, 7FFDD9D69C50h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x64uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x64u(Vec256<ulong> src, ref ulong dst)
; location: [7FFDD9D69C70h, 7FFDD9D69C80h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x64uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x64u(Vec256<ulong> src, ref ulong dst)
; location: [7FFDD9D69CA0h, 7FFDD9D69CB0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovdqu ymmword ptr [rdx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x64uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFE,0x7F,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x32f(Vector256<float> src, ref float dst)
; location: [7FFDD9D69CD0h, 7FFDD9D69CE0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovups [rdx],ymm0            ; VMOVUPS(VEX_Vmovups_ymmm256_ymm) [mem(Packed256_Float32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fc 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x32f(Vec256<float> src, ref float dst)
; location: [7FFDD9D69D00h, 7FFDD9D69D10h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovups [rdx],ymm0            ; VMOVUPS(VEX_Vmovups_ymmm256_ymm) [mem(Packed256_Float32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fc 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x32f(Vec256<float> src, ref float dst)
; location: [7FFDD9D69D30h, 7FFDD9D69D40h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovups [rdx],ymm0            ; VMOVUPS(VEX_Vmovups_ymmm256_ymm) [mem(Packed256_Float32,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fc 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_n256x64f(Vector256<double> src, ref double dst)
; location: [7FFDD9D69D60h, 7FFDD9D69D70h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_n256x64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_d256x64f(Vec256<double> src, ref double dst)
; location: [7FFDD9D69D90h, 7FFDD9D69DA0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_d256x64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vstore_g256x64f(Vec256<double> src, ref double dst)
; location: [7FFDD9D69DC0h, 7FFDD9D69DD0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vstore_g256x64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x11,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_16i_to_g8u(short src)
; location: [7FFDD9D69DF0h, 7FFDD9D69DFCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g8uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_16i_to_g8i(short src)
; location: [7FFDD9D69E10h, 7FFDD9D69E1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g8iBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_16i_to_g16u(short src)
; location: [7FFDD9D69E30h, 7FFDD9D69E3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g16uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_16i_to_g16i(short src)
; location: [7FFDD9D69E50h, 7FFDD9D69E59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_16i_to_g32i(short src)
; location: [7FFDD9D69E70h, 7FFDD9D69E79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_16i_to_g32u(short src)
; location: [7FFDD9D69E90h, 7FFDD9D69E99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_16i_to_g64i(short src)
; location: [7FFDD9D6A2C0h, 7FFDD9D6A2CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_16i_to_g64u(short src)
; location: [7FFDD9D6A2E0h, 7FFDD9D6A2ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_g16i_to_g64u(short src)
; location: [7FFDD9D6A300h, 7FFDD9D6A30Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g16i_to_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_16i_to_g32f(short src)
; location: [7FFDD9D6A320h, 7FFDD9D6A331h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000dh vcvtsi2ss xmm0,xmm0,eax       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fa 2a c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x0F,0xBF,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_g16i_to_g32f(short src)
; location: [7FFDD9D6A350h, 7FFDD9D6A36Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D69F90h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC40h:jmp64]        encoding(5 bytes) = e8 2b fc ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g16i_to_g32fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x2B,0xFC,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_16i_to_g64f(short src)
; location: [7FFDD9D6A380h, 7FFDD9D6A391h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
000dh vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_g64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0x48,0x0F,0xBF,0xC1,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g16i_to_g64f(short src)
; location: [7FFDD9D6A3B0h, 7FFDD9D6A3CAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6A010h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC60h:jmp64]        encoding(5 bytes) = e8 4b fc ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g16i_to_g64fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x4B,0xFC,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_16i_to_gch16(short src)
; location: [7FFDD9D6A3E0h, 7FFDD9D6A3ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16i_to_gch16Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_g16i_to_gch16(short src)
; location: [7FFDD9D6A400h, 7FFDD9D6A41Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
000eh call 7FFDD9D6A060h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC60h:jmp64]        encoding(5 bytes) = e8 4d fc ff ff
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g16i_to_gch16Bytes => new byte[27]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x4D,0xFC,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_16u_to_g8i(ushort src)
; location: [7FFDD9D6A430h, 7FFDD9D6A43Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g8iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_16u_to_g8u(ushort src)
; location: [7FFDD9D6A450h, 7FFDD9D6A45Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g8uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_16u_to_g16i(ushort src)
; location: [7FFDD9D6A470h, 7FFDD9D6A47Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g16iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_16u_to_g16u(ushort src)
; location: [7FFDD9D6A490h, 7FFDD9D6A498h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_16u_to_g32i(ushort src)
; location: [7FFDD9D6A4B0h, 7FFDD9D6A4B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_16u_to_g32u(ushort src)
; location: [7FFDD9D6A4D0h, 7FFDD9D6A4D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_16u_to_g64i(ushort src)
; location: [7FFDD9D6A4F0h, 7FFDD9D6A4F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_16u_to_g64u(ushort src)
; location: [7FFDD9D6A510h, 7FFDD9D6A518h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_16u_to_g32f(ushort src)
; location: [7FFDD9D6A530h, 7FFDD9D6A540h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000ch vcvtsi2ss xmm0,xmm0,eax       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fa 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_16u_to_g64f(ushort src)
; location: [7FFDD9D6A560h, 7FFDD9D6A570h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000ch vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_g64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0x0F,0xB7,0xC1,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g16u_to_g64f(ushort src)
; location: [7FFDD9D6A590h, 7FFDD9D6A5AAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6A260h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFCD0h:jmp64]        encoding(5 bytes) = e8 bb fc ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g16u_to_g64fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xBB,0xFC,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_16u_to_gch16(ushort src)
; location: [7FFDD9D6A5C0h, 7FFDD9D6A5C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_16u_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_32i_to_gi(int src)
; location: [7FFDD9D6A5E0h, 7FFDD9D6A5E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_giBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_32i_to_g8i(int src)
; location: [7FFDD9D6A600h, 7FFDD9D6A609h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_g32i_to_g8i(int src)
; location: [7FFDD9D6AA30h, 7FFDD9D6AA39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_32i_to_8u(int src)
; location: [7FFDD9D6AA50h, 7FFDD9D6AA58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_32i_to_g8u(int src)
; location: [7FFDD9D6AA70h, 7FFDD9D6AA78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_g32i_to_g8u(int src)
; location: [7FFDD9D6AA90h, 7FFDD9D6AAA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_32i_to_16i(int src)
; location: [7FFDD9D6AAC0h, 7FFDD9D6AAC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_32i_to_g16i(int src)
; location: [7FFDD9D6AAE0h, 7FFDD9D6AAE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_g32i_to_g16i(int src)
; location: [7FFDD9D6AB00h, 7FFDD9D6AB09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_32i_to_16u(int src)
; location: [7FFDD9D6AB20h, 7FFDD9D6AB28h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_32i_to_g16u(int src)
; location: [7FFDD9D6AB40h, 7FFDD9D6AB48h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_g32i_to_g16u(int src)
; location: [7FFDD9D6AB60h, 7FFDD9D6AB71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_32i_to_32i(int src)
; location: [7FFDD9D6AB90h, 7FFDD9D6AB97h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_32i_to_g32i(int src)
; location: [7FFDD9D6ABB0h, 7FFDD9D6ABB7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_g32i_to_g32i(int src)
; location: [7FFDD9D6ABD0h, 7FFDD9D6ABD7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_32i_to_32u(int src)
; location: [7FFDD9D6ABF0h, 7FFDD9D6ABF7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_32i_to_g32u(int src)
; location: [7FFDD9D6AC10h, 7FFDD9D6AC17h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_g32i_to_g32u(int src)
; location: [7FFDD9D6AC30h, 7FFDD9D6AC3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_32i_to_64i(int src)
; location: [7FFDD9D6AC50h, 7FFDD9D6AC58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_32i_to_g64i(int src)
; location: [7FFDD9D6AC70h, 7FFDD9D6AC78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_g32i_to_g64i(int src)
; location: [7FFDD9D6AC90h, 7FFDD9D6AC98h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_32i_to_64u(int src)
; location: [7FFDD9D6ACB0h, 7FFDD9D6ACB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_32i_to_g64u(int src)
; location: [7FFDD9D6ACD0h, 7FFDD9D6ACD8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_g32i_to_g64u(int src)
; location: [7FFDD9D6ACF0h, 7FFDD9D6ACFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_32i_to_32f(int src)
; location: [7FFDD9D6AD10h, 7FFDD9D6AD1Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2ss xmm0,xmm0,ecx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,ECX] encoding(VEX, 4 bytes) = c5 fa 2a c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_32i_to_g32f(int src)
; location: [7FFDD9D6AD30h, 7FFDD9D6AD3Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2ss xmm0,xmm0,ecx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,ECX] encoding(VEX, 4 bytes) = c5 fa 2a c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_g32i_to_g32f(int src)
; location: [7FFDD9D6AD50h, 7FFDD9D6AD6Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6A770h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFA20h:jmp64]        encoding(5 bytes) = e8 0b fa ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g32fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x0B,0xFA,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_32i_to_64f(int src)
; location: [7FFDD9D6AD80h, 7FFDD9D6AD8Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,ecx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,ECX] encoding(VEX, 4 bytes) = c5 fb 2a c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_32i_to_g64f(int src)
; location: [7FFDD9D6ADA0h, 7FFDD9D6ADADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,ecx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,ECX] encoding(VEX, 4 bytes) = c5 fb 2a c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_g64fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g32i_to_g64f(int src)
; location: [7FFDD9D6ADC0h, 7FFDD9D6ADDAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6A790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF9D0h:jmp64]        encoding(5 bytes) = e8 bb f9 ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_g64fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xBB,0xF9,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_32i_to_ch16(int src)
; location: [7FFDD9D6ADF0h, 7FFDD9D6ADF8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_ch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_32i_to_gch16(int src)
; location: [7FFDD9D6AE10h, 7FFDD9D6AE18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32i_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_g32i_to_gch16(int src)
; location: [7FFDD9D6AE30h, 7FFDD9D6AE4Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
000eh call 7FFDD9D6A7E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF9B0h:jmp64]        encoding(5 bytes) = e8 9d f9 ff ff
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32i_to_gch16Bytes => new byte[27]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x9D,0xF9,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_32u_to_8i(uint src)
; location: [7FFDD9D6AE60h, 7FFDD9D6AE69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_32u_to_g8i(uint src)
; location: [7FFDD9D6AE80h, 7FFDD9D6AE89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_g32u_to_g8i(uint src)
; location: [7FFDD9D6AEA0h, 7FFDD9D6AEB2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_32u_to_8u(uint src)
; location: [7FFDD9D6AED0h, 7FFDD9D6AED8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_32u_to_g8u(uint src)
; location: [7FFDD9D6AEF0h, 7FFDD9D6AEF8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_g32u_to_g8u(uint src)
; location: [7FFDD9D6AF10h, 7FFDD9D6AF18h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_32u_to_16i(uint src)
; location: [7FFDD9D6AF30h, 7FFDD9D6AF39h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_32u_to_g16i(uint src)
; location: [7FFDD9D6AF50h, 7FFDD9D6AF59h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_g32u_to_g16i(uint src)
; location: [7FFDD9D6AF70h, 7FFDD9D6AF82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_32u_to_16u(uint src)
; location: [7FFDD9D6AFA0h, 7FFDD9D6AFA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_32u_to_g16u(uint src)
; location: [7FFDD9D6AFC0h, 7FFDD9D6AFC8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_g32u_to_g16u(uint src)
; location: [7FFDD9D6AFE0h, 7FFDD9D6AFE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_32u_to_32i(uint src)
; location: [7FFDD9D6B000h, 7FFDD9D6B007h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_32u_to_g32i(uint src)
; location: [7FFDD9D6B430h, 7FFDD9D6B437h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_g32u_to_g32i(uint src)
; location: [7FFDD9D6B450h, 7FFDD9D6B45Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_32u_to_32u(uint src)
; location: [7FFDD9D6B470h, 7FFDD9D6B477h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_32u_to_g32u(uint src)
; location: [7FFDD9D6B490h, 7FFDD9D6B497h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_g32u_to_g32u(uint src)
; location: [7FFDD9D6B4B0h, 7FFDD9D6B4B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_32u_to_64i(uint src)
; location: [7FFDD9D6B4D0h, 7FFDD9D6B4D7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_32u_to_g64i(uint src)
; location: [7FFDD9D6B4F0h, 7FFDD9D6B4F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g64iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_g32u_to_g64i(uint src)
; location: [7FFDD9D6B510h, 7FFDD9D6B51Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_32u_to_64u(uint src)
; location: [7FFDD9D6B530h, 7FFDD9D6B537h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_32u_to_g64u(uint src)
; location: [7FFDD9D6B550h, 7FFDD9D6B557h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_g32u_to_g64u(uint src)
; location: [7FFDD9D6B570h, 7FFDD9D6B577h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g64uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_32u_to_32f(uint src)
; location: [7FFDD9D6B590h, 7FFDD9D6B5A4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vcvtsi2sd xmm0,xmm0,rax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RAX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c0
0010h vcvtsd2ss xmm0,xmm0,xmm0      ; VCVTSD2SS(VEX_Vcvtsd2ss_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 5a c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_32fBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0xC1,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC0,0xC5,0xFB,0x5A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_32u_to_g32f(uint src)
; location: [7FFDD9D6B5C0h, 7FFDD9D6B5CDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2ss xmm0,xmm0,ecx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,ECX] encoding(VEX, 4 bytes) = c5 fa 2a c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g32fBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_g32u_to_g32f(uint src)
; location: [7FFDD9D6B5E0h, 7FFDD9D6B5FAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6B1D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFBF0h:jmp64]        encoding(5 bytes) = e8 db fb ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g32fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xDB,0xFB,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_32u_to_64f(uint src)
; location: [7FFDD9D6B610h, 7FFDD9D6B620h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vcvtsi2sd xmm0,xmm0,rax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RAX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0xC1,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_32u_to_g64f(uint src)
; location: [7FFDD9D6B640h, 7FFDD9D6B650h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vcvtsi2sd xmm0,xmm0,rax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RAX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_g64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0x8B,0xC1,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g32u_to_g64f(uint src)
; location: [7FFDD9D6B670h, 7FFDD9D6B68Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6B220h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFBB0h:jmp64]        encoding(5 bytes) = e8 9b fb ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_g64fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x9B,0xFB,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_32u_to_ch(uint src)
; location: [7FFDD9D6B6A0h, 7FFDD9D6B6A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_chBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_32u_to_gch16(uint src)
; location: [7FFDD9D6B6C0h, 7FFDD9D6B6C8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32u_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_g32u_to_gch16(uint src)
; location: [7FFDD9D6B6E0h, 7FFDD9D6B6FAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
000eh call 7FFDD9D6B270h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB90h:jmp64]        encoding(5 bytes) = e8 7d fb ff ff
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g32u_to_gch16Bytes => new byte[27]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x7D,0xFB,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_64i_to_g8u(long src)
; location: [7FFDD9D6B710h, 7FFDD9D6B718h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_64i_to_g8i(long src)
; location: [7FFDD9D6B730h, 7FFDD9D6B739h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_64i_to_g16u(long src)
; location: [7FFDD9D6B750h, 7FFDD9D6B758h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_64i_to_g16i(long src)
; location: [7FFDD9D6B770h, 7FFDD9D6B779h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_64i_to_g32i(long src)
; location: [7FFDD9D6B790h, 7FFDD9D6B797h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_64i_to_g32u(long src)
; location: [7FFDD9D6B7B0h, 7FFDD9D6B7B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_64i_to_g64i(long src)
; location: [7FFDD9D6B7D0h, 7FFDD9D6B7D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_64i_to_g64u(long src)
; location: [7FFDD9D6B7F0h, 7FFDD9D6B7F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_64i_to_g32f(long src)
; location: [7FFDD9D6B810h, 7FFDD9D6B81Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2ss xmm0,xmm0,rcx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fa 2a c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g32fBytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFA,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_64i_to_g64f(long src)
; location: [7FFDD9D6B830h, 7FFDD9D6B83Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_g64fBytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_64i_to_gch16(long src)
; location: [7FFDD9D6B850h, 7FFDD9D6B858h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64i_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_64u_to_g8i(ulong src)
; location: [7FFDD9D6BC80h, 7FFDD9D6BC89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_64u_to_g8u(ulong src)
; location: [7FFDD9D6BCA0h, 7FFDD9D6BCA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_64u_to_g16i(ulong src)
; location: [7FFDD9D6BCC0h, 7FFDD9D6BCC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_64u_to_g16u(ulong src)
; location: [7FFDD9D6BCE0h, 7FFDD9D6BCE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_g64u_to_g16u(ulong src)
; location: [7FFDD9D6BD00h, 7FFDD9D6BD08h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64u_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_64u_to_g32i(ulong src)
; location: [7FFDD9D6BD20h, 7FFDD9D6BD27h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g32iBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_64u_to_g32u(ulong src)
; location: [7FFDD9D6BD40h, 7FFDD9D6BD47h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_64u_to_32u(ulong src)
; location: [7FFDD9D6BD60h, 7FFDD9D6BD67h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_g64u_to_g32u(ulong src)
; location: [7FFDD9D6BD80h, 7FFDD9D6BD87h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64u_to_g32uBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_64u_to_g64i(ulong src)
; location: [7FFDD9D6BDA0h, 7FFDD9D6BDA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_64u_to_g64u(ulong src)
; location: [7FFDD9D6BDC0h, 7FFDD9D6BDC8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_64u_to_g32f(ulong src)
; location: [7FFDD9D6BDE0h, 7FFDD9D6BDFFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0011h jge short 001bh               ; JGE(Jge_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 7d 08
0013h vaddsd xmm0,xmm0,qword ptr [7FFDD9D6BE08h]; VADDSD(VEX_Vaddsd_xmm_xmm_xmmm64) [XMM0,XMM0,mem(Float64,RIP:br,DS:sr)] encoding(VEX, 8 bytes) = c5 fb 58 05 0d 00 00 00
001bh vcvtsd2ss xmm0,xmm0,xmm0      ; VCVTSD2SS(VEX_Vcvtsd2ss_xmm_xmm_xmmm64) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fb 5a c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g32fBytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0x48,0x85,0xC9,0x7D,0x08,0xC5,0xFB,0x58,0x05,0x0D,0x00,0x00,0x00,0xC5,0xFB,0x5A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_64u_to_64f(ulong src)
; location: [7FFDD9D6BE20h, 7FFDD9D6BE2Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_64fBytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_64u_to_g64f(ulong src)
; location: [7FFDD9D6BE40h, 7FFDD9D6BE4Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vcvtsi2sd xmm0,xmm0,rcx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RCX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_g64fBytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g64u_to_g64f(ulong src)
; location: [7FFDD9D6BE60h, 7FFDD9D6BE7Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 30
000ch lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0011h call 7FFDD9D6B9E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB80h:jmp64]        encoding(5 bytes) = e8 6a fb ff ff
0016h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0017h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g64u_to_g64fBytes => new byte[28]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x6A,0xFB,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_64u_to_gch16(ulong src)
; location: [7FFDD9D6BE90h, 7FFDD9D6BE98h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_64u_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_32f_to_g8i(float src)
; location: [7FFDD9D6BEB0h, 7FFDD9D6BEBDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si eax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r32_xmmm32) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fa 2c c0
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g8iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x2C,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_32f_to_g8u(float src)
; location: [7FFDD9D6BED0h, 7FFDD9D6BEDCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si eax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r32_xmmm32) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fa 2c c0
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g8uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x2C,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_32f_to_g16i(float src)
; location: [7FFDD9D6BEF0h, 7FFDD9D6BEFDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si eax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r32_xmmm32) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fa 2c c0
0009h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g16iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x2C,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_32f_to_g16u(float src)
; location: [7FFDD9D6BF10h, 7FFDD9D6BF1Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si eax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r32_xmmm32) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fa 2c c0
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g16uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x2C,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_32f_to_g32i(float src)
; location: [7FFDD9D6BF30h, 7FFDD9D6BF39h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si eax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r32_xmmm32) [EAX,XMM0]     encoding(VEX, 4 bytes) = c5 fa 2c c0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g32iBytes => new byte[10]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_32f_to_g32u(float src)
; location: [7FFDD9D6BF50h, 7FFDD9D6BF5Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si rax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r64_xmmm32) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fa 2c c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g32uBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xFA,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_32f_to_g64i(float src)
; location: [7FFDD9D6BF70h, 7FFDD9D6BF7Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vcvttss2si rax,xmm0           ; VCVTTSS2SI(VEX_Vcvttss2si_r64_xmmm32) [RAX,XMM0]     encoding(VEX, 5 bytes) = c4 e1 fa 2c c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g64iBytes => new byte[11]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xFA,0x2C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_32f_to_g64u(float src)
; location: [7FFDD9D6BF90h, 7FFDD9D6BFA5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vcvtss2sd xmm0,xmm0,xmm0      ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 fa 5a c0
000bh call 7FFE390ECA70h            ; CALL(Call_rel32_64) [5F380AE0h:jmp64]                encoding(5 bytes) = e8 d0 0a 38 5f
0010h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0011h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_32f_to_g64uBytes => new byte[22]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFA,0x5A,0xC0,0xE8,0xD0,0x0A,0x38,0x5F,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(byte value)
; location: [7FFDD9D6C3D0h, 7FFDD9D6C411h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
000bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000dh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0011h cmp rdx,800h                  ; CMP(Cmp_rm64_imm32) [RDX,800h:imm64]                 encoding(7 bytes) = 48 81 fa 00 08 00 00
0018h ja short 003ch                ; JA(Ja_rel8_64) [3Ch:jmp64]                           encoding(2 bytes) = 77 22
001ah movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
001dh mov rdx,184E9A65629h          ; MOV(Mov_r64_imm64) [RDX,184e9a65629h:imm64]          encoding(10 bytes) = 48 ba 29 56 a6 e9 84 01 00 00
0027h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
002ah mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
002dh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,DS:sr),8h:imm32] encoding(7 bytes) = c7 41 08 08 00 00 00
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003ch call 7FFDD94B4D50h            ; CALL(Call_rel32_64) [FFFFFFFFFF748980h:jmp64]        encoding(5 bytes) = e8 3f 89 74 ff
0041h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[66]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x8B,0xD0,0x48,0x83,0xC2,0x08,0x48,0x81,0xFA,0x00,0x08,0x00,0x00,0x77,0x22,0x48,0x63,0xC0,0x48,0xBA,0x29,0x56,0xA6,0xE9,0x84,0x01,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x3F,0x89,0x74,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq(BitSize offset, BitSize count)
; location: [7FFDD9D6C430h, 7FFDD9D6C469h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
000ah add rax,r9                    ; ADD(Add_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 03 c1
000dh cmp rax,800h                  ; CMP(Cmp_RAX_imm32) [RAX,800h:imm64]                  encoding(6 bytes) = 48 3d 00 08 00 00
0013h ja short 0034h                ; JA(Ja_rel8_64) [34h:jmp64]                           encoding(2 bytes) = 77 1f
0015h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0018h mov rdx,184E9A65629h          ; MOV(Mov_r64_imm64) [RDX,184e9a65629h:imm64]          encoding(10 bytes) = 48 ba 29 56 a6 e9 84 01 00 00
0022h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0025h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0028h mov [rcx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 41 08
002ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0034h call 7FFDD94B4D50h            ; CALL(Call_rel32_64) [FFFFFFFFFF748920h:jmp64]        encoding(5 bytes) = e8 e7 88 74 ff
0039h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseqBytes => new byte[58]{0x48,0x83,0xEC,0x28,0x90,0x8B,0xC2,0x45,0x8B,0xC8,0x49,0x03,0xC1,0x48,0x3D,0x00,0x08,0x00,0x00,0x77,0x1F,0x48,0x63,0xC2,0x48,0xBA,0x29,0x56,0xA6,0xE9,0x84,0x01,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE7,0x88,0x74,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteInfo byteinfo(byte src)
; location: [7FFDD9D6C480h, 7FFDD9D6C51Fh]
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
001dh mov rcx,7FFDD9558098h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9558098h:imm64]         encoding(10 bytes) = 48 b9 98 80 55 d9 fd 7f 00 00
0027h mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
002ch call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F258430h:jmp64]                encoding(5 bytes) = e8 ff 83 25 5f
0031h mov rax,184E14059E8h          ; MOV(Mov_r64_imm64) [RAX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b8 e8 59 40 e1 84 01 00 00
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
007eh call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F257210h:jmp64]                encoding(5 bytes) = e8 8d 71 25 5f
0083h call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F257210h:jmp64]                encoding(5 bytes) = e8 88 71 25 5f
0088h call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F257210h:jmp64]                encoding(5 bytes) = e8 83 71 25 5f
008dh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
008fh mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0092h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0096h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0097h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0098h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0099h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
009ah call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F382A80h:jmp64]                encoding(5 bytes) = e8 e1 29 38 5f
009fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> byteinfoBytes => new byte[160]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xD9,0x8B,0xF2,0x48,0xB9,0x98,0x80,0x55,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0xFF,0x83,0x25,0x5F,0x48,0xB8,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x00,0x40,0x0F,0xB6,0xD6,0x3B,0x50,0x08,0x73,0x53,0x48,0x63,0xD2,0x48,0xC1,0xE2,0x05,0x48,0x8D,0x44,0x10,0x10,0x0F,0xB6,0x50,0x18,0x48,0x8B,0x08,0x4C,0x8B,0x40,0x08,0x48,0x8B,0x40,0x10,0x4C,0x8D,0x4C,0x24,0x20,0x49,0x89,0x09,0x4D,0x89,0x41,0x08,0x49,0x89,0x41,0x10,0x41,0x88,0x51,0x18,0x48,0x8B,0xFB,0x48,0x8D,0x74,0x24,0x20,0xE8,0x8D,0x71,0x25,0x5F,0xE8,0x88,0x71,0x25,0x5F,0xE8,0x83,0x71,0x25,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3,0xE8,0xE1,0x29,0x38,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8i(sbyte src)
; location: [7FFDD9D6C540h, 7FFDD9D6C5B0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov [rsp+48h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 48
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh movsx rdi,byte ptr [rsp+48h]  ; MOVSX(Movsx_r64_rm8) [RDI,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 7c 24 48
0013h mov rcx,7FFDD9558098h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9558098h:imm64]         encoding(10 bytes) = 48 b9 98 80 55 d9 fd 7f 00 00
001dh mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
0022h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F258370h:jmp64]                encoding(5 bytes) = e8 49 83 25 5f
0027h mov rax,184E14059E8h          ; MOV(Mov_r64_imm64) [RAX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b8 e8 59 40 e1 84 01 00 00
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
006bh call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F3829C0h:jmp64]                encoding(5 bytes) = e8 50 29 38 5f
0070h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq8iBytes => new byte[113]{0x57,0x56,0x48,0x83,0xEC,0x28,0x89,0x54,0x24,0x48,0x48,0x8B,0xF1,0x48,0x0F,0xBE,0x7C,0x24,0x48,0x48,0xB9,0x98,0x80,0x55,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0x49,0x83,0x25,0x5F,0x48,0xB8,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x00,0x40,0x0F,0xB6,0xD7,0x3B,0x50,0x08,0x73,0x2E,0x48,0x63,0xD2,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x44,0x10,0x10,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x48,0x89,0x16,0x89,0x4E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x50,0x29,0x38,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq8u(byte src)
; location: [7FFDD9D6C5D0h, 7FFDD9D6C63Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov [rsp+48h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 48
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh movzx edi,byte ptr [rsp+48h]  ; MOVZX(Movzx_r32_rm8) [EDI,mem(8u,RSP:br,SS:sr)]      encoding(6 bytes) = 40 0f b6 7c 24 48
0013h mov rcx,7FFDD9558098h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9558098h:imm64]         encoding(10 bytes) = 48 b9 98 80 55 d9 fd 7f 00 00
001dh mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
0022h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F2582E0h:jmp64]                encoding(5 bytes) = e8 b9 82 25 5f
0027h mov rax,184E14059E8h          ; MOV(Mov_r64_imm64) [RAX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b8 e8 59 40 e1 84 01 00 00
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
0067h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F382930h:jmp64]                encoding(5 bytes) = e8 c4 28 38 5f
006ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq8uBytes => new byte[109]{0x57,0x56,0x48,0x83,0xEC,0x28,0x89,0x54,0x24,0x48,0x48,0x8B,0xF1,0x40,0x0F,0xB6,0x7C,0x24,0x48,0x48,0xB9,0x98,0x80,0x55,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0xB9,0x82,0x25,0x5F,0x48,0xB8,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x00,0x3B,0x78,0x08,0x73,0x2E,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x44,0x10,0x10,0x48,0x85,0xC0,0x75,0x06,0x33,0xD2,0x33,0xC9,0xEB,0x07,0x48,0x8D,0x50,0x10,0x8B,0x48,0x08,0x48,0x89,0x16,0x89,0x4E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0xC4,0x28,0x38,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq16i(short src)
; location: [7FFDD9D6CA60h, 7FFDD9D6CB86h]
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
0024h mov rcx,7FFDD946EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd946ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 46 d9 fd 7f 00 00
002eh mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
0033h call 7FFE38FC45E0h            ; CALL(Call_rel32_64) [5F257B80h:jmp64]                encoding(5 bytes) = e8 48 7b 25 5f
0038h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
003ch mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
003fh mov r14d,10h                  ; MOV(Mov_r32_imm32) [R14D,10h:imm32]                  encoding(6 bytes) = 41 be 10 00 00 00
0045h mov rcx,7FFDD9558098h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9558098h:imm64]         encoding(10 bytes) = 48 b9 98 80 55 d9 fd 7f 00 00
004fh mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
0054h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F257E50h:jmp64]                encoding(5 bytes) = e8 f7 7d 25 5f
0059h mov rcx,184E14059E8h          ; MOV(Mov_r64_imm64) [RCX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b9 e8 59 40 e1 84 01 00 00
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
009fh call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [5623C4A0h:jmp64]                encoding(5 bytes) = e8 fc c3 23 56
00a4h mov rcx,184E14059E8h          ; MOV(Mov_r64_imm64) [RCX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b9 e8 59 40 e1 84 01 00 00
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
00efh call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [5623C4A0h:jmp64]                encoding(5 bytes) = e8 ac c3 23 56
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
0109h call 7FFDD94B4D50h            ; CALL(Call_rel32_64) [FFFFFFFFFF7482F0h:jmp64]        encoding(5 bytes) = e8 e2 81 74 ff
010eh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
010fh call 7FFDD94B4D58h            ; CALL(Call_rel32_64) [FFFFFFFFFF7482F8h:jmp64]        encoding(5 bytes) = e8 e4 81 74 ff
0114h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0115h call 7FFDD94B4D50h            ; CALL(Call_rel32_64) [FFFFFFFFFF7482F0h:jmp64]        encoding(5 bytes) = e8 d6 81 74 ff
011ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
011bh call 7FFDD94B4D58h            ; CALL(Call_rel32_64) [FFFFFFFFFF7482F8h:jmp64]        encoding(5 bytes) = e8 d8 81 74 ff
0120h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0121h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F3824A0h:jmp64]                encoding(5 bytes) = e8 7a 23 38 5f
0126h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq16iBytes => new byte[295]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x58,0x48,0x8B,0xF1,0x48,0x0F,0xBF,0x4C,0x24,0x58,0x0F,0xB7,0xC9,0x40,0x0F,0xB6,0xF9,0xC1,0xF9,0x08,0x0F,0xB6,0xD9,0x48,0xB9,0x10,0xEA,0x46,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0x48,0x7B,0x25,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x10,0x00,0x00,0x00,0x48,0xB9,0x98,0x80,0x55,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0xF7,0x7D,0x25,0x5F,0x48,0xB9,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x09,0x3B,0x79,0x08,0x0F,0x83,0xB2,0x00,0x00,0x00,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x45,0x85,0xF6,0x72,0x75,0x45,0x3B,0xC6,0x77,0x76,0x4D,0x63,0xC0,0x48,0x8B,0xCD,0xE8,0xFC,0xC3,0x23,0x56,0x48,0xB9,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x09,0x3B,0x59,0x08,0x73,0x6B,0x48,0x63,0xD3,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x41,0x83,0xFE,0x08,0x72,0x39,0x41,0x8D,0x4E,0xF8,0x48,0x8D,0x45,0x08,0x44,0x3B,0xC1,0x77,0x32,0x48,0x8B,0xC8,0x4D,0x63,0xC0,0xE8,0xAC,0xC3,0x23,0x56,0x48,0x89,0x2E,0x44,0x89,0x76,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0xE2,0x81,0x74,0xFF,0xCC,0xE8,0xE4,0x81,0x74,0xFF,0xCC,0xE8,0xD6,0x81,0x74,0xFF,0xCC,0xE8,0xD8,0x81,0x74,0xFF,0xCC,0xE8,0x7A,0x23,0x38,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq16u(ushort src)
; location: [7FFDD9D6CBB0h, 7FFDD9D6CCD2h]
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
0020h mov rcx,7FFDD946EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd946ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 46 d9 fd 7f 00 00
002ah mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
002fh call 7FFE38FC45E0h            ; CALL(Call_rel32_64) [5F257A30h:jmp64]                encoding(5 bytes) = e8 fc 79 25 5f
0034h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0038h mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
003bh mov r14d,10h                  ; MOV(Mov_r32_imm32) [R14D,10h:imm32]                  encoding(6 bytes) = 41 be 10 00 00 00
0041h mov rcx,7FFDD9558098h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9558098h:imm64]         encoding(10 bytes) = 48 b9 98 80 55 d9 fd 7f 00 00
004bh mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
0050h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F257D00h:jmp64]                encoding(5 bytes) = e8 ab 7c 25 5f
0055h mov rcx,184E14059E8h          ; MOV(Mov_r64_imm64) [RCX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b9 e8 59 40 e1 84 01 00 00
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
009bh call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [5623C350h:jmp64]                encoding(5 bytes) = e8 b0 c2 23 56
00a0h mov rcx,184E14059E8h          ; MOV(Mov_r64_imm64) [RCX,184e14059e8h:imm64]          encoding(10 bytes) = 48 b9 e8 59 40 e1 84 01 00 00
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
00ebh call 7FFE2FFA8F00h            ; CALL(Call_rel32_64) [5623C350h:jmp64]                encoding(5 bytes) = e8 60 c2 23 56
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
0105h call 7FFDD94B4D50h            ; CALL(Call_rel32_64) [FFFFFFFFFF7481A0h:jmp64]        encoding(5 bytes) = e8 96 80 74 ff
010ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
010bh call 7FFDD94B4D58h            ; CALL(Call_rel32_64) [FFFFFFFFFF7481A8h:jmp64]        encoding(5 bytes) = e8 98 80 74 ff
0110h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0111h call 7FFDD94B4D50h            ; CALL(Call_rel32_64) [FFFFFFFFFF7481A0h:jmp64]        encoding(5 bytes) = e8 8a 80 74 ff
0116h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0117h call 7FFDD94B4D58h            ; CALL(Call_rel32_64) [FFFFFFFFFF7481A8h:jmp64]        encoding(5 bytes) = e8 8c 80 74 ff
011ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
011dh call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F382350h:jmp64]                encoding(5 bytes) = e8 2e 22 38 5f
0122h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitseq16uBytes => new byte[291]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x58,0x48,0x8B,0xF1,0x0F,0xB7,0x4C,0x24,0x58,0x40,0x0F,0xB6,0xF9,0xC1,0xF9,0x08,0x0F,0xB6,0xD9,0x48,0xB9,0x10,0xEA,0x46,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0xFC,0x79,0x25,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x10,0x00,0x00,0x00,0x48,0xB9,0x98,0x80,0x55,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0xAB,0x7C,0x25,0x5F,0x48,0xB9,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x09,0x3B,0x79,0x08,0x0F,0x83,0xB2,0x00,0x00,0x00,0x48,0x63,0xD7,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x45,0x85,0xF6,0x72,0x75,0x45,0x3B,0xC6,0x77,0x76,0x4D,0x63,0xC0,0x48,0x8B,0xCD,0xE8,0xB0,0xC2,0x23,0x56,0x48,0xB9,0xE8,0x59,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x09,0x3B,0x59,0x08,0x73,0x6B,0x48,0x63,0xD3,0x48,0xC1,0xE2,0x05,0x48,0x8B,0x4C,0x11,0x10,0x48,0x85,0xC9,0x75,0x07,0x33,0xD2,0x45,0x33,0xC0,0xEB,0x08,0x48,0x8D,0x51,0x10,0x44,0x8B,0x41,0x08,0x41,0x83,0xFE,0x08,0x72,0x39,0x41,0x8D,0x4E,0xF8,0x48,0x8D,0x45,0x08,0x44,0x3B,0xC1,0x77,0x32,0x48,0x8B,0xC8,0x4D,0x63,0xC0,0xE8,0x60,0xC2,0x23,0x56,0x48,0x89,0x2E,0x44,0x89,0x76,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0x96,0x80,0x74,0xFF,0xCC,0xE8,0x98,0x80,0x74,0xFF,0xCC,0xE8,0x8A,0x80,0x74,0xFF,0xCC,0xE8,0x8C,0x80,0x74,0xFF,0xCC,0xE8,0x2E,0x22,0x38,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq32i(int src)
; location: [7FFDD9D6CCF0h, 7FFDD9D6CD20h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDD9D6C030h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF340h:jmp64]        encoding(5 bytes) = e8 27 f3 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq32iBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x27,0xF3,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq32u(uint src)
; location: [7FFDD9D6CD40h, 7FFDD9D6CD70h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDD9D6C030h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF2F0h:jmp64]        encoding(5 bytes) = e8 d7 f2 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq32uBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0xD7,0xF2,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq64i(long src)
; location: [7FFDD9D6CD90h, 7FFDD9D6CDC0h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDD9D6C048h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF2B8h:jmp64]        encoding(5 bytes) = e8 9f f2 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq64iBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x9F,0xF2,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq64u(ulong src)
; location: [7FFDD9D6CDE0h, 7FFDD9D6CE10h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0014h call 7FFDD9D6C048h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF268h:jmp64]        encoding(5 bytes) = e8 4f f2 ff ff
0019h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 20
001eh mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
0022h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0025h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0028h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
002bh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
002fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq64uBytes => new byte[49]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xF1,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x4F,0xF2,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x8B,0x54,0x24,0x28,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq32f(float src)
; location: [7FFDD9D6CE30h, 7FFDD9D6CE6Dh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000fh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0012h vmovss dword ptr [rsp+2Ch],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 2c
0018h mov edx,[rsp+2Ch]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 2c
001ch lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0021h call 7FFDD9D6C030h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF200h:jmp64]        encoding(5 bytes) = e8 da f1 ff ff
0026h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
002bh mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
002fh mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0032h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0035h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0038h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
003ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq32fBytes => new byte[62]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF1,0xC5,0xFA,0x11,0x4C,0x24,0x2C,0x8B,0x54,0x24,0x2C,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xDA,0xF1,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x30,0x8B,0x54,0x24,0x38,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> bitseq64f(double src)
; location: [7FFDD9D6CE90h, 7FFDD9D6CECEh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000fh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0012h vmovsd qword ptr [rsp+28h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 28
0018h mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 28
001dh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0022h call 7FFDD9D6C048h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF1B8h:jmp64]        encoding(5 bytes) = e8 91 f1 ff ff
0027h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
002ch mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
0030h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0033h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0036h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0039h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
003dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitseq64fBytes => new byte[63]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF1,0xC5,0xFB,0x11,0x4C,0x24,0x28,0x48,0x8B,0x54,0x24,0x28,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x91,0xF1,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x30,0x8B,0x54,0x24,0x38,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte enable_d8i(ref sbyte src, int pos)
; location: [7FFDD9D6CEF0h, 7FFDD9D6CF09h]
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
; location: [7FFDD9D6D330h, 7FFDD9D6D349h]
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
; location: [7FFDD9D6D360h, 7FFDD9D6D379h]
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
; location: [7FFDD9D6D390h, 7FFDD9D6D3A9h]
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
; location: [7FFDD9D6D3C0h, 7FFDD9D6D3DAh]
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
; location: [7FFDD9D6D3F0h, 7FFDD9D6D40Ah]
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
; location: [7FFDD9D6D420h, 7FFDD9D6D43Ah]
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
; location: [7FFDD9D6D450h, 7FFDD9D6D46Ah]
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
; location: [7FFDD9D6D480h, 7FFDD9D6D496h]
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
; location: [7FFDD9D6D4B0h, 7FFDD9D6D4C6h]
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
; location: [7FFDD9D6D4E0h, 7FFDD9D6D4F6h]
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
; location: [7FFDD9D6D510h, 7FFDD9D6D526h]
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
; location: [7FFDD9D6D540h, 7FFDD9D6D556h]
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
; location: [7FFDD9D6D570h, 7FFDD9D6D586h]
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
; location: [7FFDD9D6D5A0h, 7FFDD9D6D5B6h]
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
; location: [7FFDD9D6D5D0h, 7FFDD9D6D5E6h]
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
; location: [7FFDD9D6D600h, 7FFDD9D6D636h]
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
; location: [7FFDD9D6D650h, 7FFDD9D6D686h]
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
; location: [7FFDD9D6D6A0h, 7FFDD9D6D6DAh]
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
; location: [7FFDD9D6D700h, 7FFDD9D6D73Ah]
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
; location: [7FFDD9D6D760h, 7FFDD9D6D772h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g8i(sbyte src, int pos)
; location: [7FFDD9D6D790h, 7FFDD9D6D7A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d8u(byte src, int pos)
; location: [7FFDD9D6D7C0h, 7FFDD9D6D7D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g8u(byte src, int pos)
; location: [7FFDD9D6D7F0h, 7FFDD9D6D801h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d16i(short src, int pos)
; location: [7FFDD9D6D820h, 7FFDD9D6D832h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g16i(short src, int pos)
; location: [7FFDD9D6D850h, 7FFDD9D6D862h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d16u(ushort src, int pos)
; location: [7FFDD9D6D880h, 7FFDD9D6D891h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g16u(ushort src, int pos)
; location: [7FFDD9D6D8B0h, 7FFDD9D6D8C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32i(int src, int pos)
; location: [7FFDD9D6D8E0h, 7FFDD9D6D8EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32i(int src, int pos)
; location: [7FFDD9D6D900h, 7FFDD9D6D90Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32u(uint src, int pos)
; location: [7FFDD9D6D920h, 7FFDD9D6D92Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32u(uint src, int pos)
; location: [7FFDD9D6D940h, 7FFDD9D6D94Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64i(long src, int pos)
; location: [7FFDD9D6D960h, 7FFDD9D6D96Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64i(long src, int pos)
; location: [7FFDD9D6D980h, 7FFDD9D6D98Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64u(ulong src, int pos)
; location: [7FFDD9D6D9A0h, 7FFDD9D6D9AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64u(ulong src, int pos)
; location: [7FFDD9D6D9C0h, 7FFDD9D6D9CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d32f(float src, int pos)
; location: [7FFDD9D6D9E0h, 7FFDD9D6D9FCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d32fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g32f(float src, int pos)
; location: [7FFDD9D6DA20h, 7FFDD9D6DA3Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g32fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_d64f(double src, int pos)
; location: [7FFDD9D6DA60h, 7FFDD9D6DA7Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_d64fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool testbit_g64f(double src, int pos)
; location: [7FFDD9D6DEA0h, 7FFDD9D6DEBCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testbit_g64fBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_16(uint a)
; location: [7FFDD9D6DEE0h, 7FFDD9D6DEF5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_16Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_16(uint a)
; location: [7FFDD9D6DF10h, 7FFDD9D6DF26h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,1000000000000000h     ; MOV(Mov_r64_imm64) [RDX,1000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 10
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_16Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_25(uint a)
; location: [7FFDD9D6DF40h, 7FFDD9D6DF5Fh]
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
; location: [7FFDD9D6DF70h, 7FFDD9D6DF86h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RDX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 ba 71 3d 0a d7 a3 70 3d 0a
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_25Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_32(uint a)
; location: [7FFDD9D6DFA0h, 7FFDD9D6DFB5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Bh                   ; SHL(Shl_rm64_imm8) [RDX,3bh:imm8]                    encoding(4 bytes) = 48 c1 e2 3b
000bh mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_32Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3B,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_32(uint a)
; location: [7FFDD9D6DFD0h, 7FFDD9D6DFE6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,800000000000000h      ; MOV(Mov_r64_imm64) [RDX,800000000000000h:imm64]      encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 08
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_32Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_lo_32u(uint x, uint y)
; location: [7FFDD9D6E000h, 7FFDD9D6E00Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0009h imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_lo_32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xD2,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_lo_64u(ulong x, ulong y)
; location: [7FFDD9D6E020h, 7FFDD9D6E02Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_lo_64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0F,0xAF,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mul_hi_32u(uint x, uint y)
; location: [7FFDD9D6E040h, 7FFDD9D6E051h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0009h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
000dh shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_hi_32uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xD2,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mul_hi_64u(ulong x, ulong y)
; location: [7FFDD9D6E070h, 7FFDD9D6E087h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_hi_64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x48,0x8B,0xD1,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_full_32u(uint a, uint b, out uint lo, out uint hi)
; location: [7FFDD9D6E0A0h, 7FFDD9D6E0B7h]
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
; location: [7FFDD9D6E0D0h, 7FFDD9D6E0F4h]
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
; location: [7FFDD9D6E110h, 7FFDD9D6E119h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_andBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_sll(UInt8 a, int offset)
; location: [7FFDD9D6E130h, 7FFDD9D6E140h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_sllBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_rotl(UInt8 a, int offset)
; location: [7FFDD9D6E160h, 7FFDD9D6E182h]
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
; location: [7FFDD9D6E1A0h, 7FFDD9D6E1C0h]
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
; location: [7FFDD9D6E1E0h, 7FFDD9D6E1EFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_mulBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 bitview8_or(UInt8 a, UInt8 b)
; location: [7FFDD9D6E200h, 7FFDD9D6E209h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitview8_orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_8i_to_8u(sbyte src)
; location: [7FFDD9D6E220h, 7FFDD9D6E22Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_8uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_8i_to_g8u(sbyte src)
; location: [7FFDD9D6E240h, 7FFDD9D6E24Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g8uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_g8i_to_g8u(sbyte src)
; location: [7FFDD9D6E260h, 7FFDD9D6E271h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g8uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_8i_to_8i(sbyte src)
; location: [7FFDD9D6E290h, 7FFDD9D6E299h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_8i_to_g8i(sbyte src)
; location: [7FFDD9D6E2B0h, 7FFDD9D6E2B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g8iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_g8i_to_g8i(sbyte src)
; location: [7FFDD9D6E2D0h, 7FFDD9D6E2E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g8iBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_8i_to_16i(sbyte src)
; location: [7FFDD9D6E300h, 7FFDD9D6E309h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_8i_to_g16i(sbyte src)
; location: [7FFDD9D6E320h, 7FFDD9D6E329h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g16iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_g8i_to_g16i(sbyte src)
; location: [7FFDD9D6E340h, 7FFDD9D6E353h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
000fh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g16iBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_8i_to_16u(sbyte src)
; location: [7FFDD9D6E370h, 7FFDD9D6E37Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_16uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_8i_to_g16u(sbyte src)
; location: [7FFDD9D6E390h, 7FFDD9D6E39Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g16uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_g8i_to_g16u(sbyte src)
; location: [7FFDD9D6E3B0h, 7FFDD9D6E3C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_8i_to_32i(sbyte src)
; location: [7FFDD9D6E3E0h, 7FFDD9D6E3E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_8i_to_g32i(sbyte src)
; location: [7FFDD9D6E400h, 7FFDD9D6E409h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g32iBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_g8i_to_g32i(sbyte src)
; location: [7FFDD9D6E420h, 7FFDD9D6E42Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g32iBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_8i_to_g32(sbyte src)
; location: [7FFDD9D6E440h, 7FFDD9D6E449h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g32Bytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_8i_to_g32u(sbyte src)
; location: [7FFDD9D6E460h, 7FFDD9D6E469h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_g8i_to_g32u(sbyte src)
; location: [7FFDD9D6E480h, 7FFDD9D6E48Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_8i_to_64i(sbyte src)
; location: [7FFDD9D6E4A0h, 7FFDD9D6E4ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_8i_to_g64i(sbyte src)
; location: [7FFDD9D6E4C0h, 7FFDD9D6E4CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g64iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_g8i_to_g64i(sbyte src)
; location: [7FFDD9D6E4E0h, 7FFDD9D6E4F2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movsx rax,byte ptr [rsp+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 08
000fh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g64iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x0F,0xBE,0x44,0x24,0x08,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_8i_to_64u(sbyte src)
; location: [7FFDD9D6E510h, 7FFDD9D6E51Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_8i_to_g64u(sbyte src)
; location: [7FFDD9D6E530h, 7FFDD9D6E53Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x63,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_g8i_to_g64u(sbyte src)
; location: [7FFDD9D6E550h, 7FFDD9D6E55Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_8i_to_32f(sbyte src)
; location: [7FFDD9D6E570h, 7FFDD9D6E581h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000dh vcvtsi2ss xmm0,xmm0,eax       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fa 2a c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x0F,0xBE,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_8i_to_g32f(sbyte src)
; location: [7FFDD9D6E5A0h, 7FFDD9D6E5B1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000dh vcvtsi2ss xmm0,xmm0,eax       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fa 2a c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g32fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x0F,0xBE,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_g8i_to_g32f(sbyte src)
; location: [7FFDD9D6E5D0h, 7FFDD9D6E5EAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6DDC8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF7F8h:jmp64]        encoding(5 bytes) = e8 e3 f7 ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g32fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xE3,0xF7,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_8i_to_64f(sbyte src)
; location: [7FFDD9D6E600h, 7FFDD9D6E611h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000dh vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_64fBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x0F,0xBE,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_8i_to_g64f(sbyte src)
; location: [7FFDD9D6E630h, 7FFDD9D6E645h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000ch vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0010h vcvtsi2sd xmm0,xmm0,rax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RAX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_g64fBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x0F,0xBE,0xC1,0x48,0x63,0xC0,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g8i_to_g64f(sbyte src)
; location: [7FFDD9D6E660h, 7FFDD9D6E67Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6DE18h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF7B8h:jmp64]        encoding(5 bytes) = e8 a3 f7 ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_g64fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0xA3,0xF7,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_8i_to_ch16(sbyte src)
; location: [7FFDD9D6E690h, 7FFDD9D6E69Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_ch16Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_8i_to_gch16(sbyte src)
; location: [7FFDD9D6E6B0h, 7FFDD9D6E6BCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8i_to_gch16Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_g8i_to_gch16(sbyte src)
; location: [7FFDD9D6E6D0h, 7FFDD9D6E6EAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
000eh call 7FFDD9D6DE68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF798h:jmp64]        encoding(5 bytes) = e8 85 f7 ff ff
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8i_to_gch16Bytes => new byte[27]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x85,0xF7,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_8u_to_8i(byte src)
; location: [7FFDD9D6E700h, 7FFDD9D6E70Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_8iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_8u_to_g8i(byte src)
; location: [7FFDD9D6EB30h, 7FFDD9D6EB3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g8iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte convert_g8u_to_g8i(byte src)
; location: [7FFDD9D6EB50h, 7FFDD9D6EB62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g8iBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_8u_to_g8u(byte src)
; location: [7FFDD9D6EB80h, 7FFDD9D6EB88h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g8uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte convert_g8u_to_g8u(byte src)
; location: [7FFDD9D6EBA0h, 7FFDD9D6EBAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g8uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_8u_to_16i(byte src)
; location: [7FFDD9D6EBC0h, 7FFDD9D6EBCCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_16iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short convert_8u_to_g16i(byte src)
; location: [7FFDD9D6EBE0h, 7FFDD9D6EBECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g16iBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_8u_to_16u(byte src)
; location: [7FFDD9D6EC00h, 7FFDD9D6EC08h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_8u_to_g16u(byte src)
; location: [7FFDD9D6EC20h, 7FFDD9D6EC28h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g16uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort convert_g8u_to_g16u(byte src)
; location: [7FFDD9D6EC40h, 7FFDD9D6EC51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g16uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_8u_to_g32i(byte src)
; location: [7FFDD9D6EC70h, 7FFDD9D6EC78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g32iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int convert_g8u_to_g32i(byte src)
; location: [7FFDD9D6EC90h, 7FFDD9D6EC9Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g32iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_8u_to_g32u(byte src)
; location: [7FFDD9D6ECB0h, 7FFDD9D6ECB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint convert_g8u_to_g32u(byte src)
; location: [7FFDD9D6ECD0h, 7FFDD9D6ECDEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g32uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_8u_to_g64i(byte src)
; location: [7FFDD9D6ECF0h, 7FFDD9D6ECF8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g64iBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long convert_g8u_to_g64i(byte src)
; location: [7FFDD9D6ED10h, 7FFDD9D6ED1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g64iBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_8u_to_g64u(byte src)
; location: [7FFDD9D6ED30h, 7FFDD9D6ED38h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g64uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong convert_g8u_to_g64u(byte src)
; location: [7FFDD9D6ED50h, 7FFDD9D6ED5Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x0F,0xB6,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_8u_to_g32f(byte src)
; location: [7FFDD9D6ED70h, 7FFDD9D6ED80h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000ch vcvtsi2ss xmm0,xmm0,eax       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fa 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g32fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC1,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float convert_g8u_to_g32f(byte src)
; location: [7FFDD9D6EDA0h, 7FFDD9D6EDBAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6E9E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC40h:jmp64]        encoding(5 bytes) = e8 2b fc ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g32fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x2B,0xFC,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_8u_to_g64f(byte src)
; location: [7FFDD9D6EDD0h, 7FFDD9D6EDE0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
000ch vcvtsi2sd xmm0,xmm0,eax       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EAX] encoding(VEX, 4 bytes) = c5 fb 2a c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_g64fBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0x0F,0xB6,0xC1,0xC5,0xFB,0x2A,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double convert_g8u_to_g64f(byte src)
; location: [7FFDD9D6EE00h, 7FFDD9D6EE1Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
000bh lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
0010h call 7FFDD9D6EA30h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC30h:jmp64]        encoding(5 bytes) = e8 1b fc ff ff
0015h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_g64fBytes => new byte[27]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x1B,0xFC,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_8u_to_gch16(byte src)
; location: [7FFDD9D6EE30h, 7FFDD9D6EE38h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_8u_to_gch16Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char convert_g8u_to_gch16(byte src)
; location: [7FFDD9D6EE50h, 7FFDD9D6EE6Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
000eh call 7FFDD9D6EA80h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFC30h:jmp64]        encoding(5 bytes) = e8 1d fc ff ff
0013h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0016h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> convert_g8u_to_gch16Bytes => new byte[27]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x1D,0xFC,0xFF,0xFF,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
