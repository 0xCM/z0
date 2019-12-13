; 2019-12-13 15:23:28:586
; function: Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FF7C5BB63D0h, 7FF7C5BB63E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FF7C5BB7680h, 7FF7C5BB7699h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C5BB76B0h, 7FF7C5BB76E9h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C5BB7B10h, 7FF7C5BB7B49h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FF7C5BB7B70h, 7FF7C5BB7BA9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
001eh vperm2i128 ymm1,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c8 03
0024h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0029h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0033h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0036h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64iBytes => new byte[58]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC4,0xE3,0x7D,0x46,0xC8,0x03,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FF7C5BB7BC0h, 7FF7C5BB7BF9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
001eh vperm2i128 ymm1,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c8 03
0024h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0029h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0033h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0036h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64iBytes => new byte[58]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC4,0xE3,0x7D,0x46,0xC8,0x03,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FF7C5BB7C10h, 7FF7C5BB7C6Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
001eh vperm2i128 ymm1,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c8 03
0024h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
002eh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0032h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0036h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
003ch vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0040h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0044h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0049h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64uBytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC4,0xE3,0x7D,0x46,0xC8,0x03,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FF7C5BB8090h, 7FF7C5BB80EDh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
001eh vperm2i128 ymm1,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c8 03
0024h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
002eh mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0032h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0036h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
003ch vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0040h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0044h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0049h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64uBytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC4,0xE3,0x7D,0x46,0xC8,0x03,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FF7C5BB8110h, 7FF7C5BB814Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80h:imm32]  encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FF7C5BB8170h, 7FF7C5BB81ACh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),80h:imm32]  encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FF7C5BB81D0h, 7FF7C5BB81EDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FF7C5BB8610h, 7FF7C5BB862Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FF7C5BB8640h, 7FF7C5BB8681h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FF7C5BB86A0h, 7FF7C5BB86E1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vcompact_128x16x2_128x8_v1(Vector128<ushort> x0, Vector128<ushort> x1)
; location: [7FF7C5BB8B10h, 7FF7C5BB8B4Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw xmm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 54 24 04
0022h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0026h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
002ah vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
002eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0032h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_128x16x2_128x8_v1Bytes => new byte[62]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x54,0x24,0x04,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0xDB,0xC3,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcompact_256x16x2_256x8_v1(Vector256<ushort> x0, Vector256<ushort> x1)
; location: [7FF7C5BB8B70h, 7FF7C5BB8BB2h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw ymm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 04
0022h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0026h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
002ah vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
002eh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0034h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0038h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_256x16x2_256x8_v1Bytes => new byte[67]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vcompact_128x32x2_128x16_v1(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C5BB8BD0h, 7FF7C5BB8C0Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0026h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
002ah vpackusdw xmm0,xmm0,xmm1      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 2b c1
002fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0033h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0036h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_128x32x2_128x16_v1Bytes => new byte[59]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC4,0xE2,0x79,0x2B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vcompact_128x32x2_128x16_v2(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C5BB9380h, 7FF7C5BB93BFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov rax,2E16C0EF045h          ; MOV(Mov_r64_imm64) [RAX,2e16c0ef045h:imm64]          encoding(10 bytes) = 48 b8 45 f0 0e 6c e1 02 00 00
0018h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
001ch vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
0021h mov rax,2E16C0EF2B5h          ; MOV(Mov_r64_imm64) [RAX,2e16c0ef2b5h:imm64]          encoding(10 bytes) = 48 b8 b5 f2 0e 6c e1 02 00 00
002bh vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
002fh vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
0034h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0038h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
003ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_128x32x2_128x16_v2Bytes => new byte[64]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0x48,0xB8,0x45,0xF0,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0x48,0xB8,0xB5,0xF2,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vcompact_256x32x2_128x16_v1(Vector256<uint> x, Vector256<uint> y)
; location: [7FF7C5BB93E0h, 7FF7C5BB9423h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd ymm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 54 24 04
0022h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0026h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
002ah vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
002fh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0035h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0039h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_256x32x2_128x16_v1Bytes => new byte[68]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vcompact_256x32x2_128x16_v2(Vector256<uint> x, Vector256<uint> y)
; location: [7FF7C5BB9440h, 7FF7C5BB9488h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,2E16C0EF2C5h          ; MOV(Mov_r64_imm64) [RAX,2e16c0ef2c5h:imm64]          encoding(10 bytes) = 48 b8 c5 f2 0e 6c e1 02 00 00
0018h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
0021h mov rax,2E16C0EF325h          ; MOV(Mov_r64_imm64) [RAX,2e16c0ef325h:imm64]          encoding(10 bytes) = 48 b8 25 f3 0e 6c e1 02 00 00
002bh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
002fh vpshufb ymm1,ymm1,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 00 ca
0034h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0038h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
003eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0042h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0045h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0048h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_256x32x2_128x16_v2Bytes => new byte[73]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0xC5,0xF2,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0x48,0xB8,0x25,0xF3,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x75,0x00,0xCA,0xC5,0xFD,0xEB,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> msb_mask_v128()
; location: [7FF7C5BB9B00h, 7FF7C5BB9B24h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0F0h    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),f0h:imm32]  encoding(8 bytes) = c7 44 24 04 f0 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> msb_mask_v128Bytes => new byte[37]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xF0,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum_256x64u(Vector256<ulong> src)
; location: [7FF7C5BB9B40h, 7FF7C5BB9B79h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0016h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
001ch add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
001fh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0025h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
002ah vpextrq rcx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RCX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c1 01
0030h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0033h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0036h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sum_256x64uBytes => new byte[58]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x48,0x03,0xD0,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC1,0x01,0x48,0x03,0xC2,0x48,0x03,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum_256x64u(Vector128<ulong> src)
; location: [7FF7C5BB9B90h, 7FF7C5BB9BA7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
0014h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sum_256x64uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pop64_scalar(ulong a, ulong b, ulong c, ulong d)
; location: [7FF7C5BB9FD0h, 7FF7C5BB9FF8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001bh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
001eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0020h popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0025h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop64_scalarBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x48,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x48,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pop64_vector(Vector256<ulong> x)
; location: [7FF7C5BBA010h, 7FF7C5BBA062h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0016h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
001ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
001eh popcnt rcx,rax                ; POPCNT(Popcnt_r64_rm64) [RCX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c8
0023h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0026h popcnt r8,rdx                 ; POPCNT(Popcnt_r64_rm64) [R8,RDX]                     encoding(5 bytes) = f3 4c 0f b8 c2
002bh add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
002eh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0034h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0039h vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
003fh popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
0044h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0047h popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
004ch add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
004fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop64_vectorBytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x33,0xC9,0xF3,0x48,0x0F,0xB8,0xC8,0x45,0x33,0xC0,0xF3,0x4C,0x0F,0xB8,0xC2,0x49,0x03,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xF3,0x48,0x0F,0xB8,0xC0,0x48,0x03,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x48,0x03,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vcsa_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FF7C5BBA080h, 7FF7C5BBA0C7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vmovupd ymm2,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 10
0012h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0016h vmovaps ymm4,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 e1
001ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
001eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0022h vmovaps ymm1,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 cb
0026h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
002ah vpand ymm1,ymm1,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4]    encoding(VEX, 4 bytes) = c5 f5 db cc
002eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0032h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
0037h vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
003bh vpxor ymm0,ymm3,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM2]    encoding(VEX, 4 bytes) = c5 e5 ef c2
003fh vmovupd [r9],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R9:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 01
0044h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcsa_256x64uBytes => new byte[72]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xC1,0x7D,0x10,0x10,0xC5,0xFC,0x28,0xD8,0xC5,0xFC,0x28,0xE1,0xC5,0xE5,0xEF,0xDC,0xC5,0xFD,0xDB,0xC1,0xC5,0xFC,0x28,0xCB,0xC5,0xFC,0x28,0xE2,0xC5,0xF5,0xDB,0xCC,0xC5,0xFD,0xEB,0xC1,0x48,0x8B,0x44,0x24,0x28,0xC5,0xFD,0x11,0x00,0xC5,0xE5,0xEF,0xC2,0xC4,0xC1,0x7D,0x11,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void csa_64u(ulong a, ulong b, ulong c, out ulong lo, out ulong hi)
; location: [7FF7C5BBA0F0h, 7FF7C5BBA115h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0011h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0014h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0017h mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 4c 24 28
001ch mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
001fh xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0022h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RAX]           encoding(3 bytes) = 49 89 01
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> csa_64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0x48,0x23,0xD1,0x48,0x8B,0xC8,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0x4C,0x24,0x28,0x48,0x89,0x11,0x49,0x33,0xC0,0x49,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
; location: [7FF7C5BBA530h, 7FF7C5BBA591h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
000dh vmovupd xmm2,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 12
0011h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0015h vshufps xmm1,xmm1,xmm3,44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,44h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb 44
001ah vshufps xmm0,xmm0,xmm2,0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,eeh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 ee
001fh vmovupd xmm2,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 10
0024h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0028h vmovupd xmm4,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM4,mem(Packed128_Float64,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 21
002dh vmovaps xmm5,xmm4             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM5,XMM4]         encoding(VEX, 4 bytes) = c5 f8 28 ec
0031h vshufps xmm3,xmm3,xmm5,44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM3,XMM3,XMM5,44h:imm8] encoding(VEX, 5 bytes) = c5 e0 c6 dd 44
0036h vshufps xmm2,xmm2,xmm4,0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM2,XMM2,XMM4,eeh:imm8] encoding(VEX, 5 bytes) = c5 e8 c6 d4 ee
003bh vshufps xmm4,xmm1,xmm3,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM4,XMM1,XMM3,88h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 e3 88
0040h vmovupd [rcx],xmm4            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM4] encoding(VEX, 4 bytes) = c5 f9 11 21
0044h vshufps xmm1,xmm1,xmm3,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,ddh:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb dd
0049h vmovupd [rdx],xmm1            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 0a
004dh vshufps xmm1,xmm0,xmm2,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM0,XMM2,88h:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 ca 88
0052h vmovupd [r8],xmm1             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R8:br,:sr),XMM1] encoding(VEX, 5 bytes) = c4 c1 79 11 08
0057h vshufps xmm0,xmm0,xmm2,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,ddh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 dd
005ch vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtransposeBytes => new byte[98]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF0,0xC6,0xCB,0x44,0xC5,0xF8,0xC6,0xC2,0xEE,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF8,0x28,0xDA,0xC4,0xC1,0x79,0x10,0x21,0xC5,0xF8,0x28,0xEC,0xC5,0xE0,0xC6,0xDD,0x44,0xC5,0xE8,0xC6,0xD4,0xEE,0xC5,0xF0,0xC6,0xE3,0x88,0xC5,0xF9,0x11,0x21,0xC5,0xF0,0xC6,0xCB,0xDD,0xC5,0xF9,0x11,0x0A,0xC5,0xF8,0xC6,0xCA,0x88,0xC4,0xC1,0x79,0x11,0x08,0xC5,0xF8,0xC6,0xC2,0xDD,0xC4,0xC1,0x79,0x11,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_0_256x64u(Vector256<ulong> src)
; location: [7FF7C5BBA5C0h, 7FF7C5BBA5D1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_0_256x64uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_1_256x64u(Vector256<ulong> src)
; location: [7FF7C5BBA5F0h, 7FF7C5BBA602h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_1_256x64uBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_1_128x8u(Vector128<byte> src)
; location: [7FF7C5BBA620h, 7FF7C5BBA631h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrb eax,xmm0,1            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 01
000fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_1_128x8uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x01,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vcell_2_256x64u(Vector256<ulong> src)
; location: [7FF7C5BBA650h, 7FF7C5BBA667h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_2_256x64uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vcell_3_256x64u(Vector256<byte> src)
; location: [7FF7C5BBA680h, 7FF7C5BBA692h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrb eax,xmm0,3            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 03
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_3_256x64uBytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x03,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vcell_256x32u_1(Vector256<uint> src)
; location: [7FF7C5BBA6B0h, 7FF7C5BBA6C2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,1            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_256x32u_1Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vcell_256x32u_2(Vector256<uint> src)
; location: [7FF7C5BBA6E0h, 7FF7C5BBA6F2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,2            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 02
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcell_256x32u_2Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> swap_hl(Vector128<byte> src)
; location: [7FF7C5BBA710h, 7FF7C5BBA725h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpshufd xmm0,xmm0,4Eh         ; VPSHUFD(VEX_Vpshufd_xmm_xmmm128_imm8) [XMM0,XMM0,4eh:imm8] encoding(VEX, 5 bytes) = c5 f9 70 c0 4e
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> swap_hlBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x70,0xC0,0x4E,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> hi_128x64u(Vector128<ulong> src)
; location: [7FF7C5BBA740h, 7FF7C5BBA75Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hi_128x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> hi_128x8u(Vector128<byte> src)
; location: [7FF7C5BBA770h, 7FF7C5BBA78Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hi_128x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> lo_128x64u(Vector128<ulong> src)
; location: [7FF7C5BBA7A0h, 7FF7C5BBA7B4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovq xmm0,xmm0               ; VMOVQ(VEX_Vmovq_xmm_xmmm64) [XMM0,XMM0]              encoding(VEX, 4 bytes) = c5 fa 7e c0
000dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lo_128x64uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xFA,0x7E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> lo_128x8u(Vector128<byte> src)
; location: [7FF7C5BBA7D0h, 7FF7C5BBA7E4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovq xmm0,xmm0               ; VMOVQ(VEX_Vmovq_xmm_xmmm64) [XMM0,XMM0]              encoding(VEX, 4 bytes) = c5 fa 7e c0
000dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lo_128x8uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xFA,0x7E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
; location: [7FF7C5BBA800h, 7FF7C5BBA821h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x8u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
; location: [7FF7C5BBAC40h, 7FF7C5BBAC65h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x8u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; location: [7FF7C5BBAC80h, 7FF7C5BBACA1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x64u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; location: [7FF7C5BBACC0h, 7FF7C5BBACE5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x64u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; location: [7FF7C5BBAD00h, 7FF7C5BBAD23h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vhi_256x64u_outBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; location: [7FF7C5BBAD40h, 7FF7C5BBAD67h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
0021h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vhi_256x64u_pairBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; location: [7FF7C5BBAD80h, 7FF7C5BBAD9Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; location: [7FF7C5BBADB0h, 7FF7C5BBADCAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8iBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; location: [7FF7C5BBADE0h, 7FF7C5BBADFDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; location: [7FF7C5BBAE10h, 7FF7C5BBAE2Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
; location: [7FF7C5BBAE40h, 7FF7C5BBAE5Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000dh vpinsrb xmm0,xmm0,eax,3       ; VPINSRB(VEX_Vpinsrb_xmm_xmm_r32m8_imm8) [XMM0,XMM0,EAX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 20 c0 03
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx3_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB6,0xC2,0xC4,0xE3,0x79,0x20,0xC0,0x03,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
; location: [7FF7C5BBAE70h, 7FF7C5BBAE89h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000dh vpinsrw xmm0,xmm0,eax,4       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM0,XMM0,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 f9 c4 c0 04
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx4_128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB7,0xC2,0xC5,0xF9,0xC4,0xC0,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
; location: [7FF7C5BBAEA0h, 7FF7C5BBAEB7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vpinsrd xmm0,xmm0,edx,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 02
0010h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx2_128x32uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
; location: [7FF7C5BBAED0h, 7FF7C5BBAEF7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0011h vpinsrb xmm1,xmm1,eax,3       ; VPINSRB(VEX_Vpinsrb_xmm_xmm_r32m8_imm8) [XMM1,XMM1,EAX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 20 c8 03
0017h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0021h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx3_256x8uBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB6,0xC2,0xC4,0xE3,0x71,0x20,0xC8,0x03,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
; location: [7FF7C5BBAF10h, 7FF7C5BBAF36h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0011h vpinsrw xmm1,xmm1,eax,4       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM1,XMM1,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 f1 c4 c8 04
0016h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx4_256x16uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB7,0xC2,0xC5,0xF1,0xC4,0xC8,0x04,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
; location: [7FF7C5BBAF50h, 7FF7C5BBAF74h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh vpinsrd xmm1,xmm1,edx,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
0014h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx2_256x32uBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
; location: [7FF7C5BBAF90h, 7FF7C5BBAFC6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ah vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000eh vpinsrd xmm1,xmm1,edx,2       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
0014h vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
001ah vextractf128 xmm1,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 01
0020h vpinsrd xmm1,xmm1,r8d,0       ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,R8D,0h:imm8] encoding(VEX, 6 bytes) = c4 c3 71 22 c8 00
0026h vinsertf128 ymm0,ymm0,xmm1,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 01
002ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0030h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0033h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov_idx4x2_256x32uBytes => new byte[55]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x01,0xC4,0xC3,0x71,0x22,0xC8,0x00,0xC4,0xE3,0x7D,0x18,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vmov128x8u(byte src)
; location: [7FF7C5BBAFE0h, 7FF7C5BBAFF3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x8uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vmov128x16u(ushort src)
; location: [7FF7C5BBB010h, 7FF7C5BBB023h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x16uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vmov128x32u(uint src)
; location: [7FF7C5BBB040h, 7FF7C5BBB050h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovd xmm0,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e c2
0009h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x32uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vmov128x64u(ulong src)
; location: [7FF7C5BBB070h, 7FF7C5BBB081h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
000ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x64uBytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vmov128x64u(double src)
; location: [7FF7C5BBB4A0h, 7FF7C5BBB4ACh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd [rcx],xmm1            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 09
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov128x64uBytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x11,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vmov256x8u(byte src)
; location: [7FF7C5BBB4C0h, 7FF7C5BBB4D6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x8uBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vmov256x16u(ushort src)
; location: [7FF7C5BBB4F0h, 7FF7C5BBB506h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h vmovd xmm0,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c0
000ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x16uBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vmov256x32u(uint src)
; location: [7FF7C5BBB520h, 7FF7C5BBB533h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovd xmm0,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e c2
0009h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x32uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vmov256x64u(ulong src)
; location: [7FF7C5BBB550h, 7FF7C5BBB564h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
000ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x64uBytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> vmov256x64u(double src)
; location: [7FF7C5BBB980h, 7FF7C5BBB98Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vmov256x64uBytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vconvert_v256x16u_v2x256x64u(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FF7C5BBB9B0h, 7FF7C5BBB9DBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
000fh vpmovzxwq ymm1,xmm1           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM1,XMM1]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c9
0014h vmovupd [rdx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 0a
0018h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
001eh vpmovzxwq ymm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c0
0023h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
0028h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_v256x16u_v2x256x64uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE2,0x7D,0x34,0xC9,0xC5,0xFD,0x11,0x0A,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x34,0xC0,0xC4,0xC1,0x7D,0x11,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vconvert_xspan32u_v256x64u(Block128<uint> src, out Vector256<ulong> dst)
; location: [7FF7C5BBBE00h, 7FF7C5BBBE6Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+18h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 18
000eh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0013h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0018h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
001dh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0020h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
0023h lea r9,[rsp+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 08
0028h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ch vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0031h lea r9,[rsp+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 08
0036h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RAX]           encoding(3 bytes) = 49 89 01
0039h mov [r9+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),EDX]           encoding(4 bytes) = 41 89 51 08
003dh vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
0043h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0049h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
004eh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0051h vpmovsxdq ymm0,xmmword ptr [rax]; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,mem(Packed128_Int32,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 25 00
0056h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
005bh vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
0060h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0064h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0067h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_xspan32u_v256x64uBytes => new byte[111]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x18,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8D,0x4C,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x4C,0x8D,0x4C,0x24,0x08,0x49,0x89,0x01,0x41,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0x48,0x8B,0x00,0xC4,0xE2,0x7D,0x25,0x00,0xC4,0xC1,0x7D,0x11,0x00,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> packus(Vector128<ushort> x, Vector128<ushort> y)
; location: [7FF7C5BBBE90h, 7FF7C5BBBECDh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw xmm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 54 24 04
0022h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0026h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
002ah vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
002eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0032h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packusBytes => new byte[62]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x54,0x24,0x04,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0xDB,0xC3,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> packus(Vector256<ushort> x, Vector256<ushort> y)
; location: [7FF7C5BBBEF0h, 7FF7C5BBBF2Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw ymm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 04
0022h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0026h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
002ah vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packusBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
; location: [7FF7C5BBBF50h, 7FF7C5BBBF73h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,2E16C0EEE65h          ; MOV(Mov_r64_imm64) [RAX,2e16c0eee65h:imm64]          encoding(10 bytes) = 48 b8 65 ee 0e 6c e1 02 00 00
0013h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0017h vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
001ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbswap_128x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x65,0xEE,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
; location: [7FF7C5BBBF90h, 7FF7C5BBBFADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; location: [7FF7C5BBBFC0h, 7FF7C5BBBFDDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; location: [7FF7C5BBBFF0h, 7FF7C5BBC040h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,2E16C0EF295h          ; MOV(Mov_r64_imm64) [RAX,2e16c0ef295h:imm64]          encoding(10 bytes) = 48 b8 95 f2 0e 6c e1 02 00 00
0018h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpaddb ymm2,ymm1,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2]  encoding(VEX, 4 bytes) = c5 f5 fc d2
0020h vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
0025h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
002bh mov rax,2E16C0EEE45h          ; MOV(Mov_r64_imm64) [RAX,2e16c0eee45h:imm64]          encoding(10 bytes) = 48 b8 45 ee 0e 6c e1 02 00 00
0035h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0039h vpaddb ymm1,ymm1,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]  encoding(VEX, 4 bytes) = c5 f5 fc cb
003dh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0042h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0046h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar32x8_256x8uBytes => new byte[81]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x95,0xF2,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x45,0xEE,0x0E,0x6C,0xE1,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FF7C5BBC230h, 7FF7C5BBC250h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FF7C5BBC670h, 7FF7C5BBC690h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FF7C5BBC6B0h, 7FF7C5BBC6D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FF7C5BBC6F0h, 7FF7C5BBC710h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FF7C5BBC730h, 7FF7C5BBC750h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FF7C5BBC770h, 7FF7C5BBC790h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FF7C5BBC7B0h, 7FF7C5BBC7D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FF7C5BBC7F0h, 7FF7C5BBC810h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FF7C5BBC830h, 7FF7C5BBC850h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FF7C5BBC870h, 7FF7C5BBC890h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FF7C5BBC8B0h, 7FF7C5BBC8D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FF7C5BBC8F0h, 7FF7C5BBC910h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FF7C5BBC930h, 7FF7C5BBC950h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FF7C5BBC970h, 7FF7C5BBC990h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64iBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FF7C5BBC9B0h, 7FF7C5BBC9D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FF7C5BBC9F0h, 7FF7C5BBCA10h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FF7C5BBCA30h, 7FF7C5BBCA53h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FF7C5BBCE70h, 7FF7C5BBCE93h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FF7C5BBCEB0h, 7FF7C5BBCED3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FF7C5BBCEF0h, 7FF7C5BBCF13h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FF7C5BBCF30h, 7FF7C5BBCF53h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FF7C5BBCF70h, 7FF7C5BBCF93h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FF7C5BBCFB0h, 7FF7C5BBCFD3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FF7C5BBCFF0h, 7FF7C5BBD013h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FF7C5BBD030h, 7FF7C5BBD053h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FF7C5BBD070h, 7FF7C5BBD093h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FF7C5BBD0B0h, 7FF7C5BBD0D3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FF7C5BBD4F0h, 7FF7C5BBD513h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FF7C5BBD530h, 7FF7C5BBD553h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FF7C5BBD570h, 7FF7C5BBD593h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64iBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FF7C5BBD5B0h, 7FF7C5BBD5D3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FF7C5BBD5F0h, 7FF7C5BBD613h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x8u_refs(int partcount, int partwidth, in byte a, in byte b, ref byte z)
; location: [7FF7C5BBE060h, 7FF7C5BBE0D2h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+60h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 60
000fh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0012h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0015h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0017h jle short 006bh               ; JLE(Jle_rel8_64) [6Bh:jmp64]                         encoding(2 bytes) = 7e 52
0019h movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001ch lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0020h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
0024h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0028h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
002eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0032h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0037h vlddqu xmm0,xmmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 07
003bh vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0041h vlddqu xmm0,xmmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 03
0045h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
004ah vmovapd xmm0,[rsp+10h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 10
0050h vmovapd xmm1,[rsp]            ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 28 0c 24
0055h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0059h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
005ch vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0060h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0063h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
0066h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0069h jl short 0019h                ; JL(Jl_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7c ae
006bh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
006fh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0070h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0071h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0072h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x8u_refsBytes => new byte[115]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x60,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x52,0x49,0x63,0xF3,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFB,0xF0,0x07,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFB,0xF0,0x03,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xF9,0x28,0x44,0x24,0x10,0xC5,0xF9,0x28,0x0C,0x24,0xC5,0xF9,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFA,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAE,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x8u_blocks(ConstBlock128<byte> xb, ConstBlock128<byte> yb, in Block128<byte> zb)
; location: [7FF7C5C50AA0h, 7FF7C5C50B0Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,0Fh                   ; AND(And_rm32_imm8) [R9D,fh:imm32]                    encoding(4 bytes) = 41 83 e1 0f
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 006ch               ; JLE(Jle_rel8_64) [6Ch:jmp64]                         encoding(2 bytes) = 7e 4b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0031h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0036h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
0039h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
003ch shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0040h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0043h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0046h vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
004bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
004fh mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0052h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0055h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0059h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
005ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
005fh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0064h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0067h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
006ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c b5
006ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x8u_blocksBytes => new byte[109]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x0F,0x41,0x03,0xC1,0xC1,0xF8,0x04,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x4B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xB5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x16u_refs(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
; location: [7FF7C5C50F30h, 7FF7C5C50FA5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+60h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 60
000fh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0012h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0015h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0017h jle short 006eh               ; JLE(Jle_rel8_64) [6Eh:jmp64]                         encoding(2 bytes) = 7e 55
0019h movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001ch shl rsi,1                     ; SHL(Shl_rm64_1) [RSI,1h:imm8]                        encoding(3 bytes) = 48 d1 e6
001fh lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0023h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
0027h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002bh vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0031h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0035h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
003ah vlddqu xmm0,xmmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 07
003eh vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0044h vlddqu xmm0,xmmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 03
0048h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
004dh vmovapd xmm0,[rsp+10h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 10
0053h vmovapd xmm1,[rsp]            ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 28 0c 24
0058h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
005ch add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
005fh vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0063h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0066h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
0069h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006ch jl short 0019h                ; JL(Jl_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7c ab
006eh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0072h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0073h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0074h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0075h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x16u_refsBytes => new byte[118]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x60,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x55,0x49,0x63,0xF3,0x48,0xD1,0xE6,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFB,0xF0,0x07,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFB,0xF0,0x03,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xF9,0x28,0x44,0x24,0x10,0xC5,0xF9,0x28,0x0C,0x24,0xC5,0xF9,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFA,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAB,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x16u_blocks(ConstBlock128<ushort> xb, ConstBlock128<ushort> yb, in Block128<ushort> zb)
; location: [7FF7C5C513E0h, 7FF7C5C5143Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,7                     ; AND(And_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 e1 07
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 3a
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,1                     ; SHL(Shl_rm64_1) [R11,1h:imm8]                        encoding(3 bytes) = 49 d1 e3
0031h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0034h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0039h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
003fh vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
0044h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0048h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004bh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004eh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0053h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0056h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0059h jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c6
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x16u_blocksBytes => new byte[92]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x07,0x41,0x03,0xC1,0xC1,0xF8,0x03,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3A,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x49,0xD1,0xE3,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC6,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x32u_refs(int partcount, int partwidth, in uint a, in uint b, ref uint z)
; location: [7FF7C5C51450h, 7FF7C5C514C6h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+60h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 60
000fh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0012h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0015h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0017h jle short 006fh               ; JLE(Jle_rel8_64) [6Fh:jmp64]                         encoding(2 bytes) = 7e 56
0019h movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001ch shl rsi,2                     ; SHL(Shl_rm64_imm8) [RSI,2h:imm8]                     encoding(4 bytes) = 48 c1 e6 02
0020h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0024h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
0028h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ch vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0032h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0036h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
003bh vlddqu xmm0,xmmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 07
003fh vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0045h vlddqu xmm0,xmmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 03
0049h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
004eh vmovapd xmm0,[rsp+10h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 10
0054h vmovapd xmm1,[rsp]            ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 28 0c 24
0059h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
005dh add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0060h vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0064h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0067h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006ah cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006dh jl short 0019h                ; JL(Jl_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7c aa
006fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0073h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0074h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0075h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0076h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x32u_refsBytes => new byte[119]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x60,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x02,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFB,0xF0,0x07,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFB,0xF0,0x03,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xF9,0x28,0x44,0x24,0x10,0xC5,0xF9,0x28,0x0C,0x24,0xC5,0xF9,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFA,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x32u_blocks(ConstBlock128<uint> xb, ConstBlock128<uint> yb, in Block128<uint> zb)
; location: [7FF7C5C514F0h, 7FF7C5C5154Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,2                     ; SAR(Sar_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 f8 02
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005ch               ; JLE(Jle_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 7e 3b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,2                     ; SHL(Shl_rm64_imm8) [R11,2h:imm8]                     encoding(4 bytes) = 49 c1 e3 02
0032h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0035h vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
003ah mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003dh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0040h vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
0045h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x32u_blocksBytes => new byte[93]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x41,0x03,0xC1,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x64u_refs(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
; location: [7FF7C5C51970h, 7FF7C5C519E6h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+60h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 60
000fh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0012h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0015h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0017h jle short 006fh               ; JLE(Jle_rel8_64) [6Fh:jmp64]                         encoding(2 bytes) = 7e 56
0019h movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001ch shl rsi,3                     ; SHL(Shl_rm64_imm8) [RSI,3h:imm8]                     encoding(4 bytes) = 48 c1 e6 03
0020h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0024h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
0028h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ch vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0032h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0036h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
003bh vlddqu xmm0,xmmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 07
003fh vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0045h vlddqu xmm0,xmmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 03
0049h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
004eh vmovapd xmm0,[rsp+10h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 10
0054h vmovapd xmm1,[rsp]            ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 f9 28 0c 24
0059h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
005dh add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0060h vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0064h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0067h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006ah cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006dh jl short 0019h                ; JL(Jl_rel8_64) [19h:jmp64]                           encoding(2 bytes) = 7c aa
006fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0073h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0074h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0075h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0076h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x64u_refsBytes => new byte[119]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x60,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x03,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFB,0xF0,0x07,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFB,0xF0,0x03,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xF9,0x28,0x44,0x24,0x10,0xC5,0xF9,0x28,0x0C,0x24,0xC5,0xF9,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFA,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_128x64u_blocks(ConstBlock128<ulong> xb, ConstBlock128<ulong> yb, in Block128<ulong> zb)
; location: [7FF7C5C51E20h, 7FF7C5C51E76h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch shr r9d,1Fh                   ; SHR(Shr_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 e9 1f
0010h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0013h sar eax,1                     ; SAR(Sar_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 f8
0015h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0018h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001ah jle short 0056h               ; JLE(Jle_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 7e 3a
001ch mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
001fh mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0022h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
0025h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0028h shl r11,3                     ; SHL(Shl_rm64_imm8) [R11,3h:imm8]                     encoding(4 bytes) = 49 c1 e3 03
002ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
002fh vlddqu xmm0,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 02
0034h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
0037h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
003ah vlddqu xmm1,xmmword ptr [r10] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 0a
003fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0043h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0046h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0049h vmovdqu xmmword ptr [r10],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R10:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 02
004eh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0051h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0054h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c c6
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_128x64u_blocksBytes => new byte[87]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x1F,0x41,0x03,0xC1,0xD1,0xF8,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3A,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xD1,0xE3,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x03,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x0A,0xC5,0xF9,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC6,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x8u_refs(int partcount, int partwidth, in byte a, in byte b, ref byte z)
; location: [7FF7C5C51E90h, 7FF7C5C51F08h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 006eh               ; JLE(Jle_rel8_64) [6Eh:jmp64]                         encoding(2 bytes) = 7e 52
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0023h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
0027h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002bh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0031h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0035h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003ah vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
005ch add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
005fh vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0063h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0066h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
0069h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006ch jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c ae
006eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0071h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0075h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0076h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0077h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0078h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x8u_refsBytes => new byte[121]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x52,0x49,0x63,0xF3,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAE,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x8u_blocks(ConstBlock256<byte> xb, ConstBlock256<byte> yb, in Block256<byte> zb)
; location: [7FF7C5C52B50h, 7FF7C5C52BBFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,1Fh                   ; AND(And_rm32_imm8) [R9D,1fh:imm32]                   encoding(4 bytes) = 41 83 e1 1f
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,5                     ; SAR(Sar_rm32_imm8) [EAX,5h:imm8]                     encoding(3 bytes) = c1 f8 05
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 006ch               ; JLE(Jle_rel8_64) [6Ch:jmp64]                         encoding(2 bytes) = 7e 4b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0031h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
0036h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
0039h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
003ch shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0040h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
0043h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0046h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
004bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004fh mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
0052h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0055h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0059h movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
005ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
005fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0064h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0067h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
006ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c b5
006ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x8u_blocksBytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x1F,0x41,0x03,0xC1,0xC1,0xF8,0x05,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x4B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x05,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x05,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x05,0x4D,0x63,0xDB,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xB5,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x16u_refs(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
; location: [7FF7C5C52BE0h, 7FF7C5C52C5Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0071h               ; JLE(Jle_rel8_64) [71h:jmp64]                         encoding(2 bytes) = 7e 55
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,1                     ; SHL(Shl_rm64_1) [RSI,1h:imm8]                        encoding(3 bytes) = 48 d1 e6
0022h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0026h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
002ah vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0034h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0038h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003dh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0041h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0047h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004bh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0050h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0056h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
005fh add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0062h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0066h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0069h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006fh jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c ab
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0078h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0079h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x16u_refsBytes => new byte[124]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x55,0x49,0x63,0xF3,0x48,0xD1,0xE6,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAB,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x16u_blocks(ConstBlock256<ushort> xb, ConstBlock256<ushort> yb, in Block256<ushort> zb)
; location: [7FF7C5C52C80h, 7FF7C5C52CDEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,0Fh                   ; AND(And_rm32_imm8) [R9D,fh:imm32]                    encoding(4 bytes) = 41 83 e1 0f
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005bh               ; JLE(Jle_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 7e 3a
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,1                     ; SHL(Shl_rm64_1) [R11,1h:imm8]                        encoding(3 bytes) = 49 d1 e3
0031h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0034h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
0039h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
003fh vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0044h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0048h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004bh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004eh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0053h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0056h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
0059h jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c6
005bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x16u_blocksBytes => new byte[95]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x0F,0x41,0x03,0xC1,0xC1,0xF8,0x04,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3A,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x04,0x4D,0x63,0xDB,0x49,0xD1,0xE3,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC6,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x32u_refs(int partcount, int partwidth, in uint a, in uint b, ref uint z)
; location: [7FF7C5C53100h, 7FF7C5C5317Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0072h               ; JLE(Jle_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 7e 56
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,2                     ; SHL(Shl_rm64_imm8) [RSI,2h:imm8]                     encoding(4 bytes) = 48 c1 e6 02
0023h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0027h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
002bh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002fh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0035h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0039h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003eh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0042h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0048h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004ch vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0051h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0057h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0060h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0063h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0067h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
006ah add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006dh cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0070h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c aa
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0079h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x32u_refsBytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x02,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x32u_blocks(ConstBlock256<uint> xb, ConstBlock256<uint> yb, in Block256<uint> zb)
; location: [7FF7C5C531B0h, 7FF7C5C5320Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,7                     ; AND(And_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 e1 07
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005ch               ; JLE(Jle_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 7e 3b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,2                     ; SHL(Shl_rm64_imm8) [R11,2h:imm8]                     encoding(4 bytes) = 49 c1 e3 02
0032h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0035h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
003ah mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003dh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0040h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0045h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x32u_blocksBytes => new byte[96]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x07,0x41,0x03,0xC1,0xC1,0xF8,0x03,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x03,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x64u_refs(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
; location: [7FF7C5C53230h, 7FF7C5C532ACh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0072h               ; JLE(Jle_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 7e 56
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,3                     ; SHL(Shl_rm64_imm8) [RSI,3h:imm8]                     encoding(4 bytes) = 48 c1 e6 03
0023h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 3c 30
0027h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 1c 31
002bh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002fh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0035h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0039h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003eh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0042h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0048h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004ch vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0051h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0057h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0060h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0063h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0067h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
006ah add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006dh cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0070h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c aa
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0079h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x64u_refsBytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x03,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vblock_xor_256x64u_blocks(ConstBlock256<ulong> xb, ConstBlock256<ulong> yb, in Block256<ulong> zb)
; location: [7FF7C5C536E0h, 7FF7C5C5373Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,[r8+8]                ; MOV(Mov_r32_rm32) [EAX,mem(32u,R8:br,:sr)]           encoding(4 bytes) = 41 8b 40 08
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0010h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0014h add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0017h sar eax,2                     ; SAR(Sar_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 f8 02
001ah xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
001dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
001fh jle short 005ch               ; JLE(Jle_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 7e 3b
0021h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
0024h mov r11d,r9d                  ; MOV(Mov_r32_rm32) [R11D,R9D]                         encoding(3 bytes) = 45 8b d9
0027h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
002bh movsxd r11,r11d               ; MOVSXD(Movsxd_r64_rm32) [R11,R11D]                   encoding(3 bytes) = 4d 63 db
002eh shl r11,3                     ; SHL(Shl_rm64_imm8) [R11,3h:imm8]                     encoding(4 bytes) = 49 c1 e3 03
0032h add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0035h vlddqu ymm0,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 02
003ah mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 4c 8b 12
003dh add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
0040h vlddqu ymm1,ymmword ptr [r10] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,R10:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7f f0 0a
0045h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch add r10,r11                   ; ADD(Add_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 03 d3
004fh vmovdqu ymmword ptr [r10],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R10:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 02
0054h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0057h cmp r9d,eax                   ; CMP(Cmp_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 3b c8
005ah jl short 0021h                ; JL(Jl_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 7c c5
005ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblock_xor_256x64u_blocksBytes => new byte[96]{0xC5,0xF8,0x77,0x66,0x90,0x41,0x8B,0x40,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x41,0x03,0xC1,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x3B,0x4C,0x8B,0x11,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x03,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x02,0x4C,0x8B,0x12,0x4D,0x03,0xD3,0xC4,0xC1,0x7F,0xF0,0x0A,0xC5,0xFD,0xEF,0xC1,0x4D,0x8B,0x10,0x4D,0x03,0xD3,0xC4,0xC1,0x7E,0x7F,0x02,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xC5,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
