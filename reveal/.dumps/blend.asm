; 2019-12-14 22:09:14:927
; function: Vector256<ushort> vmerge16(Vector128<ushort> x, Vector128<ushort> y)
; location: [7FF7F0E72CE0h, 7FF7F0E72D14h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm2,xmm0,xmm1,33h   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM2,XMM0,XMM1,33h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e d1 33
0014h vpblendw xmm0,xmm0,xmm1,0CCh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,cch:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 cc
001ah vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
001eh vinserti128 ymm1,ymm1,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM1,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 ca 00
0024h vinserti128 ymm0,ymm1,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM1,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 c0 01
002ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmerge16Bytes => new byte[53]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xD1,0x33,0xC4,0xE3,0x79,0x0E,0xC1,0xCC,0xC5,0xF4,0x57,0xC9,0xC4,0xE3,0x75,0x38,0xCA,0x00,0xC4,0xE3,0x75,0x38,0xC0,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmerge32(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7F0E72D30h, 7FF7F0E72D64h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendd xmm2,xmm0,xmm1,0Ch   ; VPBLENDD(VEX_Vpblendd_xmm_xmm_xmmm128_imm8) [XMM2,XMM0,XMM1,ch:imm8] encoding(VEX, 6 bytes) = c4 e3 79 02 d1 0c
0014h vpblendd xmm0,xmm0,xmm1,0Ch   ; VPBLENDD(VEX_Vpblendd_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,ch:imm8] encoding(VEX, 6 bytes) = c4 e3 79 02 c1 0c
001ah vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
001eh vinserti128 ymm1,ymm1,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM1,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 ca 00
0024h vinserti128 ymm0,ymm1,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM1,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 c0 01
002ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmerge32Bytes => new byte[53]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x02,0xD1,0x0C,0xC4,0xE3,0x79,0x02,0xC1,0x0C,0xC5,0xF4,0x57,0xC9,0xC4,0xE3,0x75,0x38,0xCA,0x00,0xC4,0xE3,0x75,0x38,0xC0,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vmerge64(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FF7F0E72D80h, 7FF7F0E72DB4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vblendpd xmm2,xmm0,xmm1,2     ; VBLENDPD(VEX_Vblendpd_xmm_xmm_xmmm128_imm8) [XMM2,XMM0,XMM1,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0d d1 02
0014h vblendpd xmm0,xmm0,xmm1,1     ; VBLENDPD(VEX_Vblendpd_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0d c1 01
001ah vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
001eh vinserti128 ymm1,ymm1,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM1,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 ca 00
0024h vinserti128 ymm0,ymm1,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM1,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 c0 01
002ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0031h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmerge64Bytes => new byte[53]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0D,0xD1,0x02,0xC4,0xE3,0x79,0x0D,0xC1,0x01,0xC5,0xF4,0x57,0xC9,0xC4,0xE3,0x75,0x38,0xCA,0x00,0xC4,0xE3,0x75,0x38,0xC0,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
; location: [7FF7F0E72DD0h, 7FF7F0E72DE5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpshufd xmm0,xmm0,4Eh         ; VPSHUFD(VEX_Vpshufd_xmm_xmmm128_imm8) [XMM0,XMM0,4eh:imm8] encoding(VEX, 5 bytes) = c5 f9 70 c0 4e
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vreverse_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x70,0xC0,0x4E,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vreverse_128x8u(Vector128<byte> x)
; location: [7FF7F0E73150h, 7FF7F0E73173h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,2AFAF95F0DDh          ; MOV(Mov_r64_imm64) [RAX,2afaf95f0ddh:imm64]          encoding(10 bytes) = 48 b8 dd f0 95 af af 02 00 00
0013h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0017h vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
001ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vreverse_128x8uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0xDD,0xF0,0x95,0xAF,0xAF,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vreverse_256x8u(Vector256<byte> x)
; location: [7FF7F0E73590h, 7FF7F0E735E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,2AFAF95F2EDh          ; MOV(Mov_r64_imm64) [RAX,2afaf95f2edh:imm64]          encoding(10 bytes) = 48 b8 ed f2 95 af af 02 00 00
0013h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0017h mov rax,2AFAF95F43Dh          ; MOV(Mov_r64_imm64) [RAX,2afaf95f43dh:imm64]          encoding(10 bytes) = 48 b8 3d f4 95 af af 02 00 00
0021h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0025h vpaddb ymm2,ymm1,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2]  encoding(VEX, 4 bytes) = c5 f5 fc d2
0029h vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
002eh vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
0034h mov rax,2AFAF95EFEDh          ; MOV(Mov_r64_imm64) [RAX,2afaf95efedh:imm64]          encoding(10 bytes) = 48 b8 ed ef 95 af af 02 00 00
003eh vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0042h vpaddb ymm1,ymm1,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]  encoding(VEX, 4 bytes) = c5 f5 fc cb
0046h vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
004bh vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vreverse_256x8uBytes => new byte[90]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0xED,0xF2,0x95,0xAF,0xAF,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0x48,0xB8,0x3D,0xF4,0x95,0xAF,0xAF,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0xED,0xEF,0x95,0xAF,0xAF,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FF7F0E73610h, 7FF7F0E7362Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0     ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 00
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FF7F0E73640h, 7FF7F0E7365Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0FFh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,ffh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 ff
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xFF,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FF7F0E73670h, 7FF7F0E7368Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0F0h  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,f0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 f0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xF0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FF7F0E736A0h, 7FF7F0E736BBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0Fh   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,fh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 0f
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x0F,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
; location: [7FF7F0E736D0h, 7FF7F0E736EBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0AAh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,aah:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 aa
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LRLRLRLRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xAA,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
; location: [7FF7F0E73700h, 7FF7F0E7371Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,55h   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,55h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 55
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RLRLRLRLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x55,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
