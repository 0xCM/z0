; 2020-01-11 03:38:49:869
; function: Vector256<short> add_d256x16i(Vector256<short> x, Vector256<short> y)
; static ReadOnlySpan<byte> add_d256x16iBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xFD,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddw ymm0,ymm0,ymm1                   ; VPADDW(VEX_Vpaddw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd fd c1
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> add_g256x16i(Vector256<short> x, Vector256<short> y)
; static ReadOnlySpan<byte> add_g256x16iBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xFD,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddw ymm0,ymm0,ymm1                   ; VPADDW(VEX_Vpaddw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd fd c1
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> add_o256x16i(Vector256<short> x, Vector256<short> y)
; static ReadOnlySpan<byte> add_o256x16iBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xFD,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpaddw ymm0,ymm0,ymm1                   ; VPADDW(VEX_Vpaddw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd fd c1
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> abs_d256x16i(Vector256<short> src)
; static ReadOnlySpan<byte> abs_d256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x1D,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpabsw ymm0,ymm0                        ; VPABSW(VEX_Vpabsw_ymm_ymmm256) [YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 1d c0
000eh vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> abs_g256x16i(Vector256<short> src)
; static ReadOnlySpan<byte> abs_g256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x1D,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpabsw ymm0,ymm0                        ; VPABSW(VEX_Vpabsw_ymm_ymmm256) [YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 1d c0
000eh vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> abs_o256x16i(Vector256<short> src)
; static ReadOnlySpan<byte> abs_o256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x1D,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpabsw ymm0,ymm0                        ; VPABSW(VEX_Vpabsw_ymm_ymmm256) [YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 1d c0
000eh vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> sub_d256x16i(Vector256<short> x, Vector256<short> y)
; static ReadOnlySpan<byte> sub_d256x16iBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xF9,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpsubw ymm0,ymm0,ymm1                   ; VPSUBW(VEX_Vpsubw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd f9 c1
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> sub_g256x16i(Vector256<short> x, Vector256<short> y)
; static ReadOnlySpan<byte> sub_g256x16iBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xF9,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpsubw ymm0,ymm0,ymm1                   ; VPSUBW(VEX_Vpsubw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd f9 c1
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_0_256x64u(Vector256<ulong> src)
; static ReadOnlySpan<byte> vcell_0_256x64uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovq rax,xmm0                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_1_256x64u(Vector256<ulong> src)
; static ReadOnlySpan<byte> vcell_1_256x64uBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_1_128x8u(Vector128<byte> src)
; static ReadOnlySpan<byte> vcell_1_128x8uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x01,0x8B,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrb eax,xmm0,1                      ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 01
000fh mov eax,eax                             ; MOV(Mov_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 8b c0
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_2_256x64u(Vector256<ulong> src)
; static ReadOnlySpan<byte> vcell_2_256x64uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vcell_3_256x64u(Vector256<byte> src)
; static ReadOnlySpan<byte> vcell_3_256x64uBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x03,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrb eax,xmm0,3                      ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 03
000fh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vcell_256x32u_1(Vector256<uint> src)
; static ReadOnlySpan<byte> vcell_256x32u_1Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,1                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 01
000fh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vcell_256x32u_2(Vector256<uint> src)
; static ReadOnlySpan<byte> vcell_256x32u_2Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x02,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,2                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 02
000fh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> swap_hl(Vector128<byte> src)
; static ReadOnlySpan<byte> swap_hlBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x70,0xC0,0x4E,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpshufd xmm0,xmm0,4Eh                   ; VPSHUFD(VEX_Vpshufd_xmm_xmmm128_imm8) [XMM0,XMM0,4eh:imm8] encoding(VEX, 5 bytes) = c5 f9 70 c0 4e
000eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> hi_128x64u(Vector128<ulong> src)
; static ReadOnlySpan<byte> hi_128x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vmovq xmm0,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0014h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> hi_128x8u(Vector128<byte> src)
; static ReadOnlySpan<byte> hi_128x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vmovq xmm0,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0014h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> lo_128x64u(Vector128<ulong> src)
; static ReadOnlySpan<byte> lo_128x64uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xFA,0x7E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovq xmm0,xmm0                         ; VMOVQ(VEX_Vmovq_xmm_xmmm64) [XMM0,XMM0]    encoding(VEX, 4 bytes) = c5 fa 7e c0
000dh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> lo_128x8u(Vector128<byte> src)
; static ReadOnlySpan<byte> lo_128x8uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xFA,0x7E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovq xmm0,xmm0                         ; VMOVQ(VEX_Vmovq_xmm_xmmm64) [XMM0,XMM0]    encoding(VEX, 4 bytes) = c5 fa 7e c0
000dh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
; static ReadOnlySpan<byte> vlo_256x8u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
001eh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
; static ReadOnlySpan<byte> vlo_256x8u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0022h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; static ReadOnlySpan<byte> vlo_256x64u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
001eh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; static ReadOnlySpan<byte> vlo_256x64u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0022h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; static ReadOnlySpan<byte> vhi_256x64u_outBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [r8],rax                            ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX] encoding(3 bytes) = 49 89 00
0020h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; static ReadOnlySpan<byte> vhi_256x64u_pairBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                          ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]       encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1                      ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [rdx+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(4 bytes) = 48 89 42 08
0021h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0024h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
