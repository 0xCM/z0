; 2020-01-05 20:14:02:832
; function: Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t)
; static ReadOnlySpan<byte> convertBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xFF,0xE6,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vcvtpd2dq xmm0,ymm0                     ; VCVTPD2DQ(VEX_Vcvtpd2dq_xmm_ymmm256) [XMM0,YMM0] encoding(VEX, 4 bytes) = c5 ff e6 c0
000dh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0014h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)
; static ReadOnlySpan<byte> vmovelo_8iBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh movsx rax,al                            ; MOVSX(Movsx_r64_rm8) [RAX,AL]              encoding(4 bytes) = 48 0f be c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vmovelo_8u(Vector128<byte> src, N8 w)
; static ReadOnlySpan<byte> vmovelo_8uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short vmovelo_16i(Vector128<short> src, N16 w)
; static ReadOnlySpan<byte> vmovelo_16iBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh movsx rax,ax                            ; MOVSX(Movsx_r64_rm16) [RAX,AX]             encoding(4 bytes) = 48 0f bf c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort vmovelo_16u(Vector128<ushort> src, N16 w)
; static ReadOnlySpan<byte> vmovelo_16uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0x0F,0xB7,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int vmovelo_32i(Vector128<int> src, N32 w)
; static ReadOnlySpan<byte> vmovelo_32iBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vmovelo_32u(Vector128<uint> src, N32 w)
; static ReadOnlySpan<byte> vmovelo_32uBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long vmovelo_64i(Vector128<long> src, N64 w)
; static ReadOnlySpan<byte> vmovelo_64iBytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vmovelo_64u(Vector128<ulong> src, N64 w)
; static ReadOnlySpan<byte> vmovelo_64uBytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
; static ReadOnlySpan<byte> vmovelo_32x128x32Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xFA,0x2A,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vcvtsi2ss xmm0,xmm0,edx                 ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fa 2a c2
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
; static ReadOnlySpan<byte> movelo_32x128x64Bytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xFB,0x2A,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vcvtsi2sd xmm0,xmm0,edx                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fb 2a c2
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
; static ReadOnlySpan<byte> movelo_64x128x64Bytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE1,0xFB,0x2A,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vcvtsi2sd xmm0,xmm0,rdx                 ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RDX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c2
000fh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0013h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
; static ReadOnlySpan<byte> vmovelo_32x128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF2,0x5A,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vcvtss2sd xmm0,xmm1,xmm0                ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f2 5a c0
0012h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
; static ReadOnlySpan<byte> vmovelo_32x128x64iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF2,0x5A,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vcvtss2sd xmm0,xmm1,xmm0                ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f2 5a c0
0012h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
; static ReadOnlySpan<byte> vmovelo_32x128x64fBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF2,0x5A,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vcvtss2sd xmm0,xmm1,xmm0                ; VCVTSS2SD(VEX_Vcvtss2sd_xmm_xmm_xmmm32) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f2 5a c0
0012h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
