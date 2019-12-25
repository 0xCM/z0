; 2019-12-24 18:05:52:307
; function: Vector128<byte> vsllv_128x8u(Vector128<byte> x, Vector128<byte> offsets)
; location: [7FF7C7E4AD70h, 7FF7C7E4AE2Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0013h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0018h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
001eh vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
0023h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0029h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
002eh vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
0034h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
0039h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
003fh vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0044h vpsllvd ymm2,ymm2,ymm3        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 47 d3
0049h vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
004eh mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
0058h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
005ch vpshufb ymm1,ymm2,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 00 c9
0061h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
006bh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
006fh vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
0074h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0078h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
007eh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0084h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
008ah mov rax,208B10A3C3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3c3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3c 0a b1 08 02 00 00
0094h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
0098h vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
009dh mov rax,208B10A3E0Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3e0dh:imm64]          encoding(10 bytes) = 48 b8 0d 3e 0a b1 08 02 00 00
00a7h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
00abh vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
00b0h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
00b4h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
00b8h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00bbh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00beh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_128x8uBytes => new byte[191]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x47,0xD3,0xC4,0xE2,0x7D,0x47,0xC1,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x6D,0x00,0xC9,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0x48,0xB8,0x3D,0x3C,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0x48,0xB8,0x0D,0x3E,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vsllv_128x16u(Vector128<ushort> x, Vector128<ushort> offsets)
; location: [7FF7C7E4AE50h, 7FF7C7E4AEADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0013h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0018h vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
001dh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0023h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0029h mov rax,208B10A3A3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3a3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3a 0a b1 08 02 00 00
0033h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
0037h vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
003ch mov rax,208B10A3D2Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d2dh:imm64]          encoding(10 bytes) = 48 b8 2d 3d 0a b1 08 02 00 00
0046h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
004ah vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
004fh vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0053h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0057h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_128x16uBytes => new byte[94]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x7D,0x47,0xC1,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0x48,0xB8,0x3D,0x3A,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0x48,0xB8,0x2D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vsllv_128x32u(Vector128<uint> x, Vector128<uint> offsets)
; location: [7FF7C7E4AED0h, 7FF7C7E4AEEAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpsllvd xmm0,xmm0,xmm1        ; VPSLLVD(VEX_Vpsllvd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 47 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_128x32uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x47,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vsllv_256x8u(Vector256<byte> x, Vector256<byte> offsets)
; location: [7FF7C7E4AF00h, 7FF7C7E4B101h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,98h                   ; SUB(Sub_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 ec 98 00 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 3c 24
0013h mov ecx,26h                   ; MOV(Mov_r32_imm32) [ECX,26h:imm32]                   encoding(5 bytes) = b9 26 00 00 00
0018h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ah rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
001ch mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001fh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0023h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0028h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
002eh vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
0033h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0039h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
003eh vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
0044h vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0049h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
004fh vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0054h vextractf128 xmm4,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d4 00
005ah vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
005fh vextractf128 xmm2,ymm2,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 01
0065h vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
006ah vmovaps ymm5,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 eb
006eh vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
0074h vpmovzxwd ymm5,xmm5           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 33 ed
0079h vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
007fh vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
0084h vpsllvd ymm4,ymm4,ymm5        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 47 e5
0089h vpsllvd ymm2,ymm2,ymm3        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 47 d3
008eh mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
0098h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
009ch vpshufb ymm3,ymm4,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3] encoding(VEX, 5 bytes) = c4 e2 5d 00 db
00a1h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
00abh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
00afh vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
00b4h vpor ymm2,ymm3,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]      encoding(VEX, 4 bytes) = c5 e5 eb d2
00b8h vpermq ymm2,ymm2,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM2,YMM2,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 d2 d8
00beh vextractf128 xmm3,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c3 00
00c4h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
00c9h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
00cfh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
00d4h vextractf128 xmm4,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cc 00
00dah vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
00dfh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
00e5h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
00eah vpsllvd ymm3,ymm3,ymm4        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 47 dc
00efh vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
00f4h mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
00feh vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0102h vpshufb ymm1,ymm3,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1] encoding(VEX, 5 bytes) = c4 e2 65 00 c9
0107h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
0111h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0115h vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
011ah vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
011eh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0124h mov rax,208B10A3A4Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3a4dh:imm64]          encoding(10 bytes) = 48 b8 4d 3a 0a b1 08 02 00 00
012eh mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
0133h lea r8,[rsp+88h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 88 00 00 00
013bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
013eh mov [r8+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EDX]           encoding(4 bytes) = 41 89 50 08
0142h vmovdqu xmm1,xmmword ptr [rsp+88h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 8c 24 88 00 00 00
014bh vmovdqu xmmword ptr [rsp+78h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 78
0151h vmovdqu xmm1,xmmword ptr [rsp+78h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 4c 24 78
0157h vmovdqu xmmword ptr [rsp+68h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 68
015dh mov rax,[rsp+68h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 68
0162h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0166h vpshufb ymm1,ymm2,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 00 c9
016bh lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 48
0170h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0174h vmovdqu xmmword ptr [rax],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM2] encoding(VEX, 4 bytes) = c5 fa 7f 10
0178h mov rax,208B10A399Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a399dh:imm64]          encoding(10 bytes) = 48 b8 9d 39 0a b1 08 02 00 00
0182h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 40
0187h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
018ch lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 48
0191h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0194h mov dword ptr [rsp+50h],20h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(8 bytes) = c7 44 24 50 20 00 00 00
019ch vmovdqu xmm2,xmmword ptr [rsp+48h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 48
01a2h vmovdqu xmmword ptr [rsp+58h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 58
01a8h vmovdqu xmm2,xmmword ptr [rsp+58h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 58
01aeh vmovdqu xmmword ptr [rsp+30h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 30
01b4h vmovdqu xmm2,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 30
01bah vmovdqu xmmword ptr [rsp+20h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 20
01c0h vmovdqu xmm2,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 20
01c6h vmovdqu xmmword ptr [rsp+10h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 10
01cch vmovdqu xmm2,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 10
01d2h vmovdqu xmmword ptr [rsp],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fa 7f 14 24
01d7h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
01dbh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
01dfh vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
01e4h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
01e8h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
01eeh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
01f2h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
01f5h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
01f8h add rsp,98h                   ; ADD(Add_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 c4 98 00 00 00
01ffh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0200h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0201h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_256x8uBytes => new byte[514]{0x57,0x56,0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x26,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x30,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xD4,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xD2,0x01,0xC4,0xE2,0x7D,0x33,0xD2,0xC5,0xFC,0x28,0xEB,0xC4,0xE3,0x7D,0x19,0xED,0x00,0xC4,0xE2,0x7D,0x33,0xED,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE2,0x5D,0x47,0xE5,0xC4,0xE2,0x6D,0x47,0xD3,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC4,0xE2,0x5D,0x00,0xDB,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC4,0xE2,0x6D,0x00,0xD4,0xC5,0xE5,0xEB,0xD2,0xC4,0xE3,0xFD,0x00,0xD2,0xD8,0xC4,0xE3,0x7D,0x19,0xC3,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCC,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x65,0x47,0xDC,0xC4,0xE2,0x7D,0x47,0xC1,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x65,0x00,0xC9,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC4,0xE2,0x7D,0x00,0xC3,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0xB8,0x4D,0x3A,0x0A,0xB1,0x08,0x02,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0x4C,0x8D,0x84,0x24,0x88,0x00,0x00,0x00,0x49,0x89,0x00,0x41,0x89,0x50,0x08,0xC5,0xFA,0x6F,0x8C,0x24,0x88,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x4C,0x24,0x78,0xC5,0xFA,0x6F,0x4C,0x24,0x78,0xC5,0xFA,0x7F,0x4C,0x24,0x68,0x48,0x8B,0x44,0x24,0x68,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x6D,0x00,0xC9,0x48,0x8D,0x44,0x24,0x48,0xC5,0xE8,0x57,0xD2,0xC5,0xFA,0x7F,0x10,0x48,0xB8,0x9D,0x39,0x0A,0xB1,0x08,0x02,0x00,0x00,0x48,0x89,0x44,0x24,0x40,0x48,0x8B,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x48,0x48,0x89,0x02,0xC7,0x44,0x24,0x50,0x20,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x54,0x24,0x48,0xC5,0xFA,0x7F,0x54,0x24,0x58,0xC5,0xFA,0x6F,0x54,0x24,0x58,0xC5,0xFA,0x7F,0x54,0x24,0x30,0xC5,0xFA,0x6F,0x54,0x24,0x30,0xC5,0xFA,0x7F,0x54,0x24,0x20,0xC5,0xFA,0x6F,0x54,0x24,0x20,0xC5,0xFA,0x7F,0x54,0x24,0x10,0xC5,0xFA,0x6F,0x54,0x24,0x10,0xC5,0xFA,0x7F,0x14,0x24,0x48,0x8B,0x04,0x24,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vsllv_256x16u(Vector256<ushort> x, Vector256<ushort> offsets)
; location: [7FF7C7E4B150h, 7FF7C7E4B1CEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0014h vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
0019h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
001fh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0024h vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
002ah vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
002fh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0035h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
003ah vpsllvd ymm2,ymm2,ymm3        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 47 d3
003fh vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
0044h mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
004eh vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0052h vpshufb ymm1,ymm2,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 00 c9
0057h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
0061h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0065h vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
006ah vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
006eh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0074h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0078h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
007bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
007eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_256x16uBytes => new byte[127]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x47,0xD3,0xC4,0xE2,0x7D,0x47,0xC1,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x6D,0x00,0xC9,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vsllv_256x32u(Vector256<uint> x, Vector256<uint> offsets)
; location: [7FF7C7E4B1F0h, 7FF7C7E4B20Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x47,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vsrlv_128x8u(Vector128<byte> x, Vector128<byte> offsets)
; location: [7FF7C7E4B220h, 7FF7C7E4B2DEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0013h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0018h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
001eh vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
0023h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0029h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
002eh vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
0034h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
0039h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
003fh vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0044h vpsrlvd ymm2,ymm2,ymm3        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 45 d3
0049h vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
004eh mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
0058h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
005ch vpshufb ymm1,ymm2,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 00 c9
0061h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
006bh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
006fh vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
0074h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0078h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
007eh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0084h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
008ah mov rax,208B10A3C3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3c3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3c 0a b1 08 02 00 00
0094h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
0098h vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
009dh mov rax,208B10A3E0Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3e0dh:imm64]          encoding(10 bytes) = 48 b8 0d 3e 0a b1 08 02 00 00
00a7h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
00abh vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
00b0h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
00b4h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
00b8h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00bbh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00beh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_128x8uBytes => new byte[191]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x45,0xD3,0xC4,0xE2,0x7D,0x45,0xC1,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x6D,0x00,0xC9,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0x48,0xB8,0x3D,0x3C,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0x48,0xB8,0x0D,0x3E,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vsrlv_128x16u(Vector128<ushort> x, Vector128<ushort> offsets)
; location: [7FF7C7E4B300h, 7FF7C7E4B35Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0013h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0018h vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
001dh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0023h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0029h mov rax,208B10A3A3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3a3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3a 0a b1 08 02 00 00
0033h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
0037h vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
003ch mov rax,208B10A3D2Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d2dh:imm64]          encoding(10 bytes) = 48 b8 2d 3d 0a b1 08 02 00 00
0046h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
004ah vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
004fh vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0053h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0057h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_128x16uBytes => new byte[94]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x7D,0x45,0xC1,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0x48,0xB8,0x3D,0x3A,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0x48,0xB8,0x2D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vsrlv_128x32u(Vector128<uint> x, Vector128<uint> offsets)
; location: [7FF7C7E4B380h, 7FF7C7E4B39Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpsrlvd xmm0,xmm0,xmm1        ; VPSRLVD(VEX_Vpsrlvd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 45 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_128x32uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x45,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vsrlv_256x8u(Vector256<byte> x, Vector256<byte> offsets)
; location: [7FF7C7E4B3B0h, 7FF7C7E4B5B1h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,98h                   ; SUB(Sub_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 ec 98 00 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 3c 24
0013h mov ecx,26h                   ; MOV(Mov_r32_imm32) [ECX,26h:imm32]                   encoding(5 bytes) = b9 26 00 00 00
0018h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ah rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
001ch mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001fh vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0023h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0028h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
002eh vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
0033h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0039h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
003eh vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
0044h vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0049h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
004fh vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0054h vextractf128 xmm4,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d4 00
005ah vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
005fh vextractf128 xmm2,ymm2,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 01
0065h vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
006ah vmovaps ymm5,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 eb
006eh vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
0074h vpmovzxwd ymm5,xmm5           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 33 ed
0079h vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
007fh vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
0084h vpsrlvd ymm4,ymm4,ymm5        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 45 e5
0089h vpsrlvd ymm2,ymm2,ymm3        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 45 d3
008eh mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
0098h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
009ch vpshufb ymm3,ymm4,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3] encoding(VEX, 5 bytes) = c4 e2 5d 00 db
00a1h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
00abh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
00afh vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
00b4h vpor ymm2,ymm3,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]      encoding(VEX, 4 bytes) = c5 e5 eb d2
00b8h vpermq ymm2,ymm2,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM2,YMM2,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 d2 d8
00beh vextractf128 xmm3,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c3 00
00c4h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
00c9h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
00cfh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
00d4h vextractf128 xmm4,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cc 00
00dah vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
00dfh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
00e5h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
00eah vpsrlvd ymm3,ymm3,ymm4        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 45 dc
00efh vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
00f4h mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
00feh vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0102h vpshufb ymm1,ymm3,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1] encoding(VEX, 5 bytes) = c4 e2 65 00 c9
0107h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
0111h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0115h vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
011ah vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
011eh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0124h mov rax,208B10A3A4Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3a4dh:imm64]          encoding(10 bytes) = 48 b8 4d 3a 0a b1 08 02 00 00
012eh mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
0133h lea r8,[rsp+88h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 88 00 00 00
013bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
013eh mov [r8+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EDX]           encoding(4 bytes) = 41 89 50 08
0142h vmovdqu xmm1,xmmword ptr [rsp+88h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 8c 24 88 00 00 00
014bh vmovdqu xmmword ptr [rsp+78h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 78
0151h vmovdqu xmm1,xmmword ptr [rsp+78h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 4c 24 78
0157h vmovdqu xmmword ptr [rsp+68h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 68
015dh mov rax,[rsp+68h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 68
0162h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0166h vpshufb ymm1,ymm2,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 00 c9
016bh lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 48
0170h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0174h vmovdqu xmmword ptr [rax],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM2] encoding(VEX, 4 bytes) = c5 fa 7f 10
0178h mov rax,208B10A399Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a399dh:imm64]          encoding(10 bytes) = 48 b8 9d 39 0a b1 08 02 00 00
0182h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 40
0187h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
018ch lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 48
0191h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0194h mov dword ptr [rsp+50h],20h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(8 bytes) = c7 44 24 50 20 00 00 00
019ch vmovdqu xmm2,xmmword ptr [rsp+48h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 48
01a2h vmovdqu xmmword ptr [rsp+58h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 58
01a8h vmovdqu xmm2,xmmword ptr [rsp+58h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 58
01aeh vmovdqu xmmword ptr [rsp+30h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 30
01b4h vmovdqu xmm2,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 30
01bah vmovdqu xmmword ptr [rsp+20h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 20
01c0h vmovdqu xmm2,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 20
01c6h vmovdqu xmmword ptr [rsp+10h],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 fa 7f 54 24 10
01cch vmovdqu xmm2,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM2,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 54 24 10
01d2h vmovdqu xmmword ptr [rsp],xmm2; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 fa 7f 14 24
01d7h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
01dbh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
01dfh vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
01e4h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
01e8h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
01eeh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
01f2h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
01f5h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
01f8h add rsp,98h                   ; ADD(Add_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 c4 98 00 00 00
01ffh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0200h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0201h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_256x8uBytes => new byte[514]{0x57,0x56,0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x26,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x30,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xD4,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xD2,0x01,0xC4,0xE2,0x7D,0x33,0xD2,0xC5,0xFC,0x28,0xEB,0xC4,0xE3,0x7D,0x19,0xED,0x00,0xC4,0xE2,0x7D,0x33,0xED,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE2,0x5D,0x45,0xE5,0xC4,0xE2,0x6D,0x45,0xD3,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC4,0xE2,0x5D,0x00,0xDB,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC4,0xE2,0x6D,0x00,0xD4,0xC5,0xE5,0xEB,0xD2,0xC4,0xE3,0xFD,0x00,0xD2,0xD8,0xC4,0xE3,0x7D,0x19,0xC3,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCC,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x65,0x45,0xDC,0xC4,0xE2,0x7D,0x45,0xC1,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x65,0x00,0xC9,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC4,0xE2,0x7D,0x00,0xC3,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0xB8,0x4D,0x3A,0x0A,0xB1,0x08,0x02,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0x4C,0x8D,0x84,0x24,0x88,0x00,0x00,0x00,0x49,0x89,0x00,0x41,0x89,0x50,0x08,0xC5,0xFA,0x6F,0x8C,0x24,0x88,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x4C,0x24,0x78,0xC5,0xFA,0x6F,0x4C,0x24,0x78,0xC5,0xFA,0x7F,0x4C,0x24,0x68,0x48,0x8B,0x44,0x24,0x68,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x6D,0x00,0xC9,0x48,0x8D,0x44,0x24,0x48,0xC5,0xE8,0x57,0xD2,0xC5,0xFA,0x7F,0x10,0x48,0xB8,0x9D,0x39,0x0A,0xB1,0x08,0x02,0x00,0x00,0x48,0x89,0x44,0x24,0x40,0x48,0x8B,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x48,0x48,0x89,0x02,0xC7,0x44,0x24,0x50,0x20,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x54,0x24,0x48,0xC5,0xFA,0x7F,0x54,0x24,0x58,0xC5,0xFA,0x6F,0x54,0x24,0x58,0xC5,0xFA,0x7F,0x54,0x24,0x30,0xC5,0xFA,0x6F,0x54,0x24,0x30,0xC5,0xFA,0x7F,0x54,0x24,0x20,0xC5,0xFA,0x6F,0x54,0x24,0x20,0xC5,0xFA,0x7F,0x54,0x24,0x10,0xC5,0xFA,0x6F,0x54,0x24,0x10,0xC5,0xFA,0x7F,0x14,0x24,0x48,0x8B,0x04,0x24,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vsrlv_256x16u(Vector256<ushort> x, Vector256<ushort> offsets)
; location: [7FF7C7E4B600h, 7FF7C7E4B67Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0014h vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
0019h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
001fh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0024h vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
002ah vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
002fh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0035h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
003ah vpsrlvd ymm2,ymm2,ymm3        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 45 d3
003fh vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
0044h mov rax,208B10A3D3Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d3dh:imm64]          encoding(10 bytes) = 48 b8 3d 3d 0a b1 08 02 00 00
004eh vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0052h vpshufb ymm1,ymm2,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 00 c9
0057h mov rax,208B10A3D9Dh          ; MOV(Mov_r64_imm64) [RAX,208b10a3d9dh:imm64]          encoding(10 bytes) = 48 b8 9d 3d 0a b1 08 02 00 00
0061h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0065h vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
006ah vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
006eh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0074h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0078h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
007bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
007eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_256x16uBytes => new byte[127]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x45,0xD3,0xC4,0xE2,0x7D,0x45,0xC1,0x48,0xB8,0x3D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x08,0xC4,0xE2,0x6D,0x00,0xC9,0x48,0xB8,0x9D,0x3D,0x0A,0xB1,0x08,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vsrlv_256x32u(Vector256<uint> x, Vector256<uint> offsets)
; location: [7FF7C7E4B6A0h, 7FF7C7E4B6BDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x45,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vsllx_128x8u(Vector128<byte> x)
; location: [7FF7C7E4B6D0h, 7FF7C7E4B6FBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsllq xmm1,xmm0,0Fh          ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM1,XMM0,fh:imm8]  encoding(VEX, 5 bytes) = c5 f1 73 f0 0f
000eh vpslldq xmm0,xmm0,8           ; VPSLLDQ(VEX_Vpslldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 f8 08
0013h mov eax,31h                   ; MOV(Mov_r32_imm32) [EAX,31h:imm32]                   encoding(5 bytes) = b8 31 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0020h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0024h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllx_128x8uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF1,0x73,0xF0,0x0F,0xC5,0xF9,0x73,0xF8,0x08,0xB8,0x31,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vsllx_128x16u(Vector128<ushort> x)
; location: [7FF7C7E4BB20h, 7FF7C7E4BB4Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsllq xmm1,xmm0,0Fh          ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM1,XMM0,fh:imm8]  encoding(VEX, 5 bytes) = c5 f1 73 f0 0f
000eh vpslldq xmm0,xmm0,8           ; VPSLLDQ(VEX_Vpslldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 f8 08
0013h mov eax,31h                   ; MOV(Mov_r32_imm32) [EAX,31h:imm32]                   encoding(5 bytes) = b8 31 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0020h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0024h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllx_128x16uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF1,0x73,0xF0,0x0F,0xC5,0xF9,0x73,0xF8,0x08,0xB8,0x31,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vsllx_128x32u(Vector128<uint> x)
; location: [7FF7C7E4BB70h, 7FF7C7E4BB9Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsllq xmm1,xmm0,0Fh          ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM1,XMM0,fh:imm8]  encoding(VEX, 5 bytes) = c5 f1 73 f0 0f
000eh vpslldq xmm0,xmm0,8           ; VPSLLDQ(VEX_Vpslldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 f8 08
0013h mov eax,31h                   ; MOV(Mov_r32_imm32) [EAX,31h:imm32]                   encoding(5 bytes) = b8 31 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0020h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0024h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllx_128x32uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF1,0x73,0xF0,0x0F,0xC5,0xF9,0x73,0xF8,0x08,0xB8,0x31,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vsllx_128x64u(Vector128<ulong> x)
; location: [7FF7C7E4BBC0h, 7FF7C7E4BBEBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsllq xmm1,xmm0,8            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM1,XMM0,8h:imm8]  encoding(VEX, 5 bytes) = c5 f1 73 f0 08
000eh vpslldq xmm0,xmm0,8           ; VPSLLDQ(VEX_Vpslldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 f8 08
0013h mov eax,38h                   ; MOV(Mov_r32_imm32) [EAX,38h:imm32]                   encoding(5 bytes) = b8 38 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0020h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0024h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllx_128x64uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF1,0x73,0xF0,0x08,0xC5,0xF9,0x73,0xF8,0x08,0xB8,0x38,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vsllx_256x8u(Vector256<byte> x)
; location: [7FF7C7E4BC10h, 7FF7C7E4BC3Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpsllq ymm1,ymm0,0Dh          ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM1,YMM0,dh:imm8]  encoding(VEX, 5 bytes) = c5 f5 73 f0 0d
000eh vpslldq ymm0,ymm0,8           ; VPSLLDQ(VEX_Vpslldq_ymm_ymm_imm8) [YMM0,YMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 fd 73 f8 08
0013h mov eax,33h                   ; MOV(Mov_r32_imm32) [EAX,33h:imm32]                   encoding(5 bytes) = b8 33 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0020h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllx_256x8uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xF5,0x73,0xF0,0x0D,0xC5,0xFD,0x73,0xF8,0x08,0xB8,0x33,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vsllx_256x64u(Vector256<ulong> x)
; location: [7FF7C7E4BC60h, 7FF7C7E4BC8Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpsllq ymm1,ymm0,0Dh          ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM1,YMM0,dh:imm8]  encoding(VEX, 5 bytes) = c5 f5 73 f0 0d
000eh vpslldq ymm0,ymm0,8           ; VPSLLDQ(VEX_Vpslldq_ymm_ymm_imm8) [YMM0,YMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 fd 73 f8 08
0013h mov eax,33h                   ; MOV(Mov_r32_imm32) [EAX,33h:imm32]                   encoding(5 bytes) = b8 33 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0020h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllx_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xF5,0x73,0xF0,0x0D,0xC5,0xFD,0x73,0xF8,0x08,0xB8,0x33,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vsrlx_128x8u(Vector128<byte> x)
; location: [7FF7C7E4BCB0h, 7FF7C7E4BCDBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrlq xmm1,xmm0,8            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM1,XMM0,8h:imm8]  encoding(VEX, 5 bytes) = c5 f1 73 d0 08
000eh vpsrldq xmm0,xmm0,8           ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 08
0013h mov eax,38h                   ; MOV(Mov_r32_imm32) [EAX,38h:imm32]                   encoding(5 bytes) = b8 38 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsllq xmm0,xmm0,xmm2         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 f3 c2
0020h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0024h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlx_128x8uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF1,0x73,0xD0,0x08,0xC5,0xF9,0x73,0xD8,0x08,0xB8,0x38,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xF3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vsrlx_128x64u(Vector128<ulong> x)
; location: [7FF7C7E4BD00h, 7FF7C7E4BD2Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpsrlq xmm1,xmm0,8            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM1,XMM0,8h:imm8]  encoding(VEX, 5 bytes) = c5 f1 73 d0 08
000eh vpsrldq xmm0,xmm0,8           ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 08
0013h mov eax,38h                   ; MOV(Mov_r32_imm32) [EAX,38h:imm32]                   encoding(5 bytes) = b8 38 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsllq xmm0,xmm0,xmm2         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 f3 c2
0020h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0024h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlx_128x64uBytes => new byte[44]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF1,0x73,0xD0,0x08,0xC5,0xF9,0x73,0xD8,0x08,0xB8,0x38,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xF3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vsrlx_256x64u(Vector256<ulong> x)
; location: [7FF7C7E4BD50h, 7FF7C7E4BD7Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpsrlq ymm1,ymm0,0Dh          ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM1,YMM0,dh:imm8]  encoding(VEX, 5 bytes) = c5 f5 73 d0 0d
000eh vpsrldq ymm0,ymm0,8           ; VPSRLDQ(VEX_Vpsrldq_ymm_ymm_imm8) [YMM0,YMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 fd 73 d8 08
0013h mov eax,33h                   ; MOV(Mov_r32_imm32) [EAX,33h:imm32]                   encoding(5 bytes) = b8 33 00 00 00
0018h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001ch vpsllq ymm0,ymm0,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd f3 c2
0020h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlx_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xF5,0x73,0xD0,0x0D,0xC5,0xFD,0x73,0xD8,0x08,0xB8,0x33,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xF3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vrotlx_128x64u(Vector128<ulong> x)
; location: [7FF7C7E4BDA0h, 7FF7C7E4BDE0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
000dh vpsllq xmm2,xmm1,0Eh          ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM2,XMM1,eh:imm8]  encoding(VEX, 5 bytes) = c5 e9 73 f1 0e
0012h vpslldq xmm1,xmm1,8           ; VPSLLDQ(VEX_Vpslldq_xmm_xmm_imm8) [XMM1,XMM1,8h:imm8] encoding(VEX, 5 bytes) = c5 f1 73 f9 08
0017h mov eax,32h                   ; MOV(Mov_r32_imm32) [EAX,32h:imm32]                   encoding(5 bytes) = b8 32 00 00 00
001ch vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0020h vpsrlq xmm1,xmm1,xmm3         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]  encoding(VEX, 4 bytes) = c5 f1 d3 cb
0024h vpor xmm1,xmm2,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]      encoding(VEX, 4 bytes) = c5 e9 eb c9
0028h vpsrldq xmm0,xmm0,8           ; VPSRLDQ(VEX_Vpsrldq_xmm_xmm_imm8) [XMM0,XMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 f9 73 d8 08
002dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0031h vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0035h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0039h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vrotlx_128x64uBytes => new byte[65]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF8,0x28,0xC8,0xC5,0xE9,0x73,0xF1,0x0E,0xC5,0xF1,0x73,0xF9,0x08,0xB8,0x32,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD8,0xC5,0xF1,0xD3,0xCB,0xC5,0xE9,0xEB,0xC9,0xC5,0xF9,0x73,0xD8,0x08,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vrotlx_256x64u(Vector256<ulong> x)
; location: [7FF7C7E4BE00h, 7FF7C7E4BE43h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vpsllq ymm2,ymm1,0Eh          ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM2,YMM1,eh:imm8]  encoding(VEX, 5 bytes) = c5 ed 73 f1 0e
0012h vpslldq ymm1,ymm1,8           ; VPSLLDQ(VEX_Vpslldq_ymm_ymm_imm8) [YMM1,YMM1,8h:imm8] encoding(VEX, 5 bytes) = c5 f5 73 f9 08
0017h mov eax,32h                   ; MOV(Mov_r32_imm32) [EAX,32h:imm32]                   encoding(5 bytes) = b8 32 00 00 00
001ch vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0020h vpsrlq ymm1,ymm1,xmm3         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM1,YMM1,XMM3]  encoding(VEX, 4 bytes) = c5 f5 d3 cb
0024h vpor ymm1,ymm2,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]      encoding(VEX, 4 bytes) = c5 ed eb c9
0028h vpsrldq ymm0,ymm0,8           ; VPSRLDQ(VEX_Vpsrldq_ymm_ymm_imm8) [YMM0,YMM0,8h:imm8] encoding(VEX, 5 bytes) = c5 fd 73 d8 08
002dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0031h vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0035h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0039h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vrotlx_256x64uBytes => new byte[68]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xFC,0x28,0xC8,0xC5,0xED,0x73,0xF1,0x0E,0xC5,0xF5,0x73,0xF9,0x08,0xB8,0x32,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD8,0xC5,0xF5,0xD3,0xCB,0xC5,0xED,0xEB,0xC9,0xC5,0xFD,0x73,0xD8,0x08,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
; location: [7FF7C7E4BE60h, 7FF7C7E4BEEEh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000ch vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0018h vpsllq xmm0,xmm0,xmm2         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 f3 c2
001ch movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0020h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0022h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0025h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0028h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
002bh neg r8d                       ; NEG(Neg_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 d8
002eh add r8d,8                     ; ADD(Add_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 c0 08
0032h mov r9d,0FFh                  ; MOV(Mov_r32_imm32) [R9D,ffh:imm32]                   encoding(6 bytes) = 41 b9 ff 00 00 00
0038h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
003bh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
003eh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0042h mov [rsp+4],cl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]              encoding(4 bytes) = 88 4c 24 04
0046h lea rcx,[rsp+4]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 04
004bh vpbroadcastb xmm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 54 24 04
0052h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0056h vmovd xmm2,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e d2
005ah vpsrlq xmm1,xmm1,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f1 d3 ca
005eh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0062h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0064h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0067h mov edx,0FFh                  ; MOV(Mov_r32_imm32) [EDX,ffh:imm32]                   encoding(5 bytes) = ba ff 00 00 00
006ch sar edx,cl                    ; SAR(Sar_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 fa
006eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0071h mov [rsp],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(3 bytes) = 88 14 24
0074h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 14 24
0078h vpbroadcastb xmm2,byte ptr [rsp]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 78 14 24
007eh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0082h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0086h vmovupd [rax],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 00
008ah add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
008eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x8uBytes => new byte[143]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xF9,0x10,0x02,0xC5,0xF8,0x28,0xC8,0x41,0x0F,0xB6,0xC8,0xC5,0xF9,0x6E,0xD1,0xC5,0xF9,0xF3,0xC2,0x41,0x0F,0xB6,0xC8,0xF7,0xD9,0x83,0xC1,0x08,0x0F,0xB6,0xD1,0x44,0x8B,0xC2,0x41,0xF7,0xD8,0x41,0x83,0xC0,0x08,0x41,0xB9,0xFF,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x04,0x48,0x8D,0x4C,0x24,0x04,0xC4,0xE2,0x79,0x78,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF9,0x6E,0xD2,0xC5,0xF1,0xD3,0xCA,0x41,0x0F,0xB6,0xC8,0xF7,0xD9,0x83,0xC1,0x08,0xBA,0xFF,0x00,0x00,0x00,0xD3,0xFA,0x0F,0xB6,0xD2,0x88,0x14,0x24,0x48,0x8D,0x14,0x24,0xC4,0xE2,0x79,0x78,0x14,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
; location: [7FF7C7E4BF10h, 7FF7C7E4BF40h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq xmm1,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x64uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
; location: [7FF7C7E4BF60h, 7FF7C7E4BFF1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000ch vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0018h vpsllq ymm0,ymm0,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd f3 c2
001ch movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0020h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0022h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0025h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0028h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
002bh neg r8d                       ; NEG(Neg_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 d8
002eh add r8d,8                     ; ADD(Add_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 c0 08
0032h mov r9d,0FFh                  ; MOV(Mov_r32_imm32) [R9D,ffh:imm32]                   encoding(6 bytes) = 41 b9 ff 00 00 00
0038h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
003bh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
003eh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0042h mov [rsp+4],cl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]              encoding(4 bytes) = 88 4c 24 04
0046h lea rcx,[rsp+4]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 04
004bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0052h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0056h vmovd xmm2,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e d2
005ah vpsrlq ymm1,ymm1,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 d3 ca
005eh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0062h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0064h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0067h mov edx,0FFh                  ; MOV(Mov_r32_imm32) [EDX,ffh:imm32]                   encoding(5 bytes) = ba ff 00 00 00
006ch sar edx,cl                    ; SAR(Sar_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 fa
006eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0071h mov [rsp],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(3 bytes) = 88 14 24
0074h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 14 24
0078h vpbroadcastb ymm2,byte ptr [rsp]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 78 14 24
007eh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0082h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0086h vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
008ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
008dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0091h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x8uBytes => new byte[146]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0xC1,0xC5,0xFD,0x10,0x02,0xC5,0xFC,0x28,0xC8,0x41,0x0F,0xB6,0xC8,0xC5,0xF9,0x6E,0xD1,0xC5,0xFD,0xF3,0xC2,0x41,0x0F,0xB6,0xC8,0xF7,0xD9,0x83,0xC1,0x08,0x0F,0xB6,0xD1,0x44,0x8B,0xC2,0x41,0xF7,0xD8,0x41,0x83,0xC0,0x08,0x41,0xB9,0xFF,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x04,0x48,0x8D,0x4C,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF9,0x6E,0xD2,0xC5,0xF5,0xD3,0xCA,0x41,0x0F,0xB6,0xC8,0xF7,0xD9,0x83,0xC1,0x08,0xBA,0xFF,0x00,0x00,0x00,0xD3,0xFA,0x0F,0xB6,0xD2,0x88,0x14,0x24,0x48,0x8D,0x14,0x24,0xC4,0xE2,0x7D,0x78,0x14,0x24,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x00,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
; location: [7FF7C7E4C010h, 7FF7C7E4C043h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq ymm1,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x64uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
