; 2020-01-08 22:54:01:507
; function: Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
; static ReadOnlySpan<byte> vmov_idx3_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB6,0xC2,0xC4,0xE3,0x79,0x20,0xC0,0x03,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
000dh vpinsrb xmm0,xmm0,eax,3                 ; VPINSRB(VEX_Vpinsrb_xmm_xmm_r32m8_imm8) [XMM0,XMM0,EAX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 20 c0 03
0013h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
; static ReadOnlySpan<byte> vmov_idx4_128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB7,0xC2,0xC5,0xF9,0xC4,0xC0,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
000dh vpinsrw xmm0,xmm0,eax,4                 ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM0,XMM0,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 f9 c4 c0 04
0012h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
; static ReadOnlySpan<byte> vmov_idx2_128x32uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vpinsrd xmm0,xmm0,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 02
0010h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0014h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
; static ReadOnlySpan<byte> vmov_idx3_256x8uBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB6,0xC2,0xC4,0xE3,0x71,0x20,0xC8,0x03,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0011h vpinsrb xmm1,xmm1,eax,3                 ; VPINSRB(VEX_Vpinsrb_xmm_xmm_r32m8_imm8) [XMM1,XMM1,EAX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 20 c8 03
0017h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001dh vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0024h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
; static ReadOnlySpan<byte> vmov_idx4_256x16uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB7,0xC2,0xC5,0xF1,0xC4,0xC8,0x04,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0011h vpinsrw xmm1,xmm1,eax,4                 ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM1,XMM1,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 f1 c4 c8 04
0016h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ch vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0023h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
; static ReadOnlySpan<byte> vmov_idx2_256x32uBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh vpinsrd xmm1,xmm1,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
0014h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ah vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001eh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0021h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0024h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
; static ReadOnlySpan<byte> vmov_idx4x2_256x32uBytes => new byte[55]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x01,0xC4,0xC3,0x71,0x22,0xC8,0x00,0xC4,0xE3,0x7D,0x18,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r9]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ah vmovaps ymm1,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh vpinsrd xmm1,xmm1,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
0014h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ah vextractf128 xmm1,ymm0,1                ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 01
0020h vpinsrd xmm1,xmm1,r8d,0                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,R8D,0h:imm8] encoding(VEX, 6 bytes) = c4 c3 71 22 c8 00
0026h vinsertf128 ymm0,ymm0,xmm1,1            ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 01
002ch vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0030h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0033h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0036h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vmov128x8u(byte src)
; static ReadOnlySpan<byte> vmov128x8uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h vmovd xmm0,eax                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]       encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0010h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vmov128x16u(ushort src)
; static ReadOnlySpan<byte> vmov128x16uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h vmovd xmm0,eax                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]       encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0010h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vmov128x32u(uint src)
; static ReadOnlySpan<byte> vmov128x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovd xmm0,edx                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]       encoding(VEX, 4 bytes) = c5 f9 6e c2
0009h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000dh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vmov128x64u(ulong src)
; static ReadOnlySpan<byte> vmov128x64uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovq xmm0,rdx                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
000ah vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000eh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0011h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vmov128x64u(double src)
; static ReadOnlySpan<byte> vmov128x64uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x11,0x09,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd [rcx],xmm1                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 09
0009h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vmov256x8u(byte src)
; static ReadOnlySpan<byte> vmov256x8uBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h vmovd xmm0,eax                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]       encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0010h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0013h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vmov256x16u(ushort src)
; static ReadOnlySpan<byte> vmov256x16uBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h vmovd xmm0,eax                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]       encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0010h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0013h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov256x32u(uint src)
; static ReadOnlySpan<byte> vmov256x32uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovd xmm0,edx                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]       encoding(VEX, 4 bytes) = c5 f9 6e c2
0009h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000dh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0010h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vmov256x64u(ulong src)
; static ReadOnlySpan<byte> vmov256x64uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovq xmm0,rdx                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
000ah vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000eh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0011h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0014h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> vmov256x64u(double src)
; static ReadOnlySpan<byte> vmov256x64uBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd [rcx],ymm1                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0009h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
000ch vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
