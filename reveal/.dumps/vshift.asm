; 2020-01-01 04:39:45:805
; function: Vector128<byte> vsllv_128x8u(Vector128<byte> x, Vector128<byte> offsets)
; location: [7FF7C7BAF0E0h, 7FF7C7BAF18Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
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
004eh mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0056h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
005bh vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
0062h vpand ymm2,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db d1
0066h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
006ah vpackusdw ymm0,ymm2,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 5 bytes) = c4 e2 6d 2b c0
006fh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0075h vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
007bh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0081h mov dword ptr [rsp],0FFh      ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(7 bytes) = c7 04 24 ff 00 00 00
0088h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
008ch vpbroadcastw xmm2,word ptr [rsp]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 79 14 24
0092h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0096h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
009ah vpackuswb xmm0,xmm1,xmm0      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 67 c0
009eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
00a2h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00a5h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00a8h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00ach ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_128x8uBytes => new byte[173]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x47,0xD3,0xC4,0xE2,0x7D,0x47,0xC1,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xED,0xDB,0xD1,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x6D,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x04,0x24,0xFF,0x00,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x79,0x14,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0x67,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vsllv_128x16u(Vector128<ushort> x, Vector128<ushort> offsets)
; location: [7FF7C7BAF5C0h, 7FF7C7BAF618h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0013h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0018h vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
001dh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0023h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0029h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0031h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0036h vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
003dh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0041h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0045h vpackusdw xmm0,xmm1,xmm0      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 5 bytes) = c4 e2 71 2b c0
004ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0051h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0054h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_128x16uBytes => new byte[89]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x7D,0x47,0xC1,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC4,0xE2,0x71,0x2B,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vsllv_128x32u(Vector128<uint> x, Vector128<uint> offsets)
; location: [7FF7C7BAF640h, 7FF7C7BAF65Ah]
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
; location: [7FF7C7BAF670h, 7FF7C7BAF79Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0010h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0016h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
001bh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0021h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0026h vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
002ch vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0031h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0037h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
003ch vextractf128 xmm4,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d4 00
0042h vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
0047h vextractf128 xmm2,ymm2,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 01
004dh vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
0052h vmovaps ymm5,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 eb
0056h vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
005ch vpmovzxwd ymm5,xmm5           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 33 ed
0061h vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
0067h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
006ch vpsllvd ymm4,ymm4,ymm5        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 47 e5
0071h vpsllvd ymm2,ymm2,ymm3        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 47 d3
0076h mov dword ptr [rsp+14h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 14 ff ff 00 00
007eh lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 14
0083h vpbroadcastd ymm3,dword ptr [rsp+14h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 5c 24 14
008ah vpand ymm4,ymm4,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM4,YMM4,YMM3]    encoding(VEX, 4 bytes) = c5 dd db e3
008eh vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0092h vpackusdw ymm2,ymm4,ymm2      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM2,YMM4,YMM2] encoding(VEX, 5 bytes) = c4 e2 5d 2b d2
0097h vpermq ymm2,ymm2,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM2,YMM2,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 d2 d8
009dh vextractf128 xmm3,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c3 00
00a3h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
00a8h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
00aeh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
00b3h vextractf128 xmm4,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cc 00
00b9h vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
00beh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
00c4h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
00c9h vpsllvd ymm3,ymm3,ymm4        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 47 dc
00ceh vpsllvd ymm0,ymm0,ymm1        ; VPSLLVD(VEX_Vpsllvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 47 c1
00d3h mov dword ptr [rsp+10h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 10 ff ff 00 00
00dbh lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
00e0h vpbroadcastd ymm1,dword ptr [rsp+10h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 10
00e7h vpand ymm3,ymm3,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM3,YMM3,YMM1]    encoding(VEX, 4 bytes) = c5 e5 db d9
00ebh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
00efh vpackusdw ymm0,ymm3,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0] encoding(VEX, 5 bytes) = c4 e2 65 2b c0
00f4h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
00fah mov dword ptr [rsp+0Ch],0FFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 0c ff 00 00 00
0102h lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
0107h vpbroadcastw ymm1,word ptr [rsp+0Ch]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 0c
010eh vpand ymm2,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db d1
0112h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0116h vpackuswb ymm0,ymm2,ymm0      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 4 bytes) = c5 ed 67 c0
011ah vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0120h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0124h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0127h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
012ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
012eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_256x8uBytes => new byte[303]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x30,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xD4,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xD2,0x01,0xC4,0xE2,0x7D,0x33,0xD2,0xC5,0xFC,0x28,0xEB,0xC4,0xE3,0x7D,0x19,0xED,0x00,0xC4,0xE2,0x7D,0x33,0xED,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE2,0x5D,0x47,0xE5,0xC4,0xE2,0x6D,0x47,0xD3,0xC7,0x44,0x24,0x14,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x14,0xC5,0xDD,0xDB,0xE3,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x5D,0x2B,0xD2,0xC4,0xE3,0xFD,0x00,0xD2,0xD8,0xC4,0xE3,0x7D,0x19,0xC3,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCC,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x65,0x47,0xDC,0xC4,0xE2,0x7D,0x47,0xC1,0xC7,0x44,0x24,0x10,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x10,0xC5,0xE5,0xDB,0xD9,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x65,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC7,0x44,0x24,0x0C,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x0C,0xC5,0xED,0xDB,0xD1,0xC5,0xFD,0xDB,0xC1,0xC5,0xED,0x67,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vsllv_256x16u(Vector256<ushort> x, Vector256<ushort> offsets)
; location: [7FF7C7BAF7D0h, 7FF7C7BAF849h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
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
0044h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
004ch lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0051h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
0058h vpand ymm2,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db d1
005ch vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0060h vpackusdw ymm0,ymm2,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 5 bytes) = c4 e2 6d 2b c0
0065h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
006bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
006fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsllv_256x16uBytes => new byte[122]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x47,0xD3,0xC4,0xE2,0x7D,0x47,0xC1,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xED,0xDB,0xD1,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x6D,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vsllv_256x32u(Vector256<uint> x, Vector256<uint> offsets)
; location: [7FF7C7BAF870h, 7FF7C7BAF88Dh]
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
; location: [7FF7C7BAF8A0h, 7FF7C7BAF94Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
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
004eh mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0056h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
005bh vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
0062h vpand ymm2,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db d1
0066h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
006ah vpackusdw ymm0,ymm2,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 5 bytes) = c4 e2 6d 2b c0
006fh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0075h vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
007bh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0081h mov dword ptr [rsp],0FFh      ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(7 bytes) = c7 04 24 ff 00 00 00
0088h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
008ch vpbroadcastw xmm2,word ptr [rsp]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 79 14 24
0092h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0096h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
009ah vpackuswb xmm0,xmm1,xmm0      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 67 c0
009eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
00a2h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00a5h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00a8h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00ach ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_128x8uBytes => new byte[173]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x45,0xD3,0xC4,0xE2,0x7D,0x45,0xC1,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xED,0xDB,0xD1,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x6D,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x04,0x24,0xFF,0x00,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x79,0x14,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0x67,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vsrlv_128x16u(Vector128<ushort> x, Vector128<ushort> offsets)
; location: [7FF7C7BAF970h, 7FF7C7BAF9C8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0013h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0018h vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
001dh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0023h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0029h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0031h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0036h vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
003dh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0041h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0045h vpackusdw xmm0,xmm1,xmm0      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 5 bytes) = c4 e2 71 2b c0
004ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0051h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0054h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_128x16uBytes => new byte[89]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x7D,0x45,0xC1,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC4,0xE2,0x71,0x2B,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vsrlv_128x32u(Vector128<uint> x, Vector128<uint> offsets)
; location: [7FF7C7BAF9F0h, 7FF7C7BAFA0Ah]
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
; location: [7FF7C7BAFA20h, 7FF7C7BAFB4Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
0010h vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0016h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
001bh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0021h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0026h vextractf128 xmm3,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cb 00
002ch vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0031h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0037h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
003ch vextractf128 xmm4,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d4 00
0042h vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
0047h vextractf128 xmm2,ymm2,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 01
004dh vpmovzxwd ymm2,xmm2           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 33 d2
0052h vmovaps ymm5,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 eb
0056h vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
005ch vpmovzxwd ymm5,xmm5           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 33 ed
0061h vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
0067h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
006ch vpsrlvd ymm4,ymm4,ymm5        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 45 e5
0071h vpsrlvd ymm2,ymm2,ymm3        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 45 d3
0076h mov dword ptr [rsp+14h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 14 ff ff 00 00
007eh lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 14
0083h vpbroadcastd ymm3,dword ptr [rsp+14h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 5c 24 14
008ah vpand ymm4,ymm4,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM4,YMM4,YMM3]    encoding(VEX, 4 bytes) = c5 dd db e3
008eh vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0092h vpackusdw ymm2,ymm4,ymm2      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM2,YMM4,YMM2] encoding(VEX, 5 bytes) = c4 e2 5d 2b d2
0097h vpermq ymm2,ymm2,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM2,YMM2,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 d2 d8
009dh vextractf128 xmm3,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c3 00
00a3h vpmovzxwd ymm3,xmm3           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 33 db
00a8h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
00aeh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
00b3h vextractf128 xmm4,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 cc 00
00b9h vpmovzxwd ymm4,xmm4           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 33 e4
00beh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
00c4h vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
00c9h vpsrlvd ymm3,ymm3,ymm4        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 45 dc
00ceh vpsrlvd ymm0,ymm0,ymm1        ; VPSRLVD(VEX_Vpsrlvd_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 45 c1
00d3h mov dword ptr [rsp+10h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 10 ff ff 00 00
00dbh lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
00e0h vpbroadcastd ymm1,dword ptr [rsp+10h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 10
00e7h vpand ymm3,ymm3,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM3,YMM3,YMM1]    encoding(VEX, 4 bytes) = c5 e5 db d9
00ebh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
00efh vpackusdw ymm0,ymm3,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0] encoding(VEX, 5 bytes) = c4 e2 65 2b c0
00f4h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
00fah mov dword ptr [rsp+0Ch],0FFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 0c ff 00 00 00
0102h lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
0107h vpbroadcastw ymm1,word ptr [rsp+0Ch]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 0c
010eh vpand ymm2,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db d1
0112h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0116h vpackuswb ymm0,ymm2,ymm0      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 4 bytes) = c5 ed 67 c0
011ah vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0120h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0124h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0127h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
012ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
012eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_256x8uBytes => new byte[303]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x30,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0xC4,0xE3,0x7D,0x19,0xD4,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xD2,0x01,0xC4,0xE2,0x7D,0x33,0xD2,0xC5,0xFC,0x28,0xEB,0xC4,0xE3,0x7D,0x19,0xED,0x00,0xC4,0xE2,0x7D,0x33,0xED,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE2,0x5D,0x45,0xE5,0xC4,0xE2,0x6D,0x45,0xD3,0xC7,0x44,0x24,0x14,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x14,0xC5,0xDD,0xDB,0xE3,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x5D,0x2B,0xD2,0xC4,0xE3,0xFD,0x00,0xD2,0xD8,0xC4,0xE3,0x7D,0x19,0xC3,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCC,0x00,0xC4,0xE2,0x7D,0x33,0xE4,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x65,0x45,0xDC,0xC4,0xE2,0x7D,0x45,0xC1,0xC7,0x44,0x24,0x10,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x10,0xC5,0xE5,0xDB,0xD9,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x65,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC7,0x44,0x24,0x0C,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x0C,0xC5,0xED,0xDB,0xD1,0xC5,0xFD,0xDB,0xC1,0xC5,0xED,0x67,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vsrlv_256x16u(Vector256<ushort> x, Vector256<ushort> offsets)
; location: [7FF7C7BAFB80h, 7FF7C7BAFBF9h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
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
0044h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
004ch lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0051h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
0058h vpand ymm2,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db d1
005ch vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0060h vpackusdw ymm0,ymm2,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 5 bytes) = c4 e2 6d 2b c0
0065h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
006bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
006fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vsrlv_256x16uBytes => new byte[122]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x33,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC4,0xE3,0x7D,0x19,0xCB,0x00,0xC4,0xE2,0x7D,0x33,0xDB,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC4,0xE2,0x6D,0x45,0xD3,0xC4,0xE2,0x7D,0x45,0xC1,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xED,0xDB,0xD1,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x6D,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vsrlv_256x32u(Vector256<uint> x, Vector256<uint> offsets)
; location: [7FF7C7BAFC20h, 7FF7C7BAFC3Dh]
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
; location: [7FF7C7BAFC50h, 7FF7C7BAFC7Bh]
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
; location: [7FF7C7BB00A0h, 7FF7C7BB00CBh]
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
; location: [7FF7C7BB00F0h, 7FF7C7BB011Bh]
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
; location: [7FF7C7BB0140h, 7FF7C7BB016Bh]
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
; location: [7FF7C7BB0190h, 7FF7C7BB01BEh]
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
; location: [7FF7C7BB01E0h, 7FF7C7BB020Eh]
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
; location: [7FF7C7BB0230h, 7FF7C7BB025Bh]
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
; location: [7FF7C7BB0280h, 7FF7C7BB02ABh]
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
; location: [7FF7C7BB02D0h, 7FF7C7BB02FEh]
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
; location: [7FF7C7BB0320h, 7FF7C7BB0360h]
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
; location: [7FF7C7BB0380h, 7FF7C7BB03C3h]
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
; location: [7FF7C7BB03E0h, 7FF7C7BB046Eh]
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
; location: [7FF7C7BB08A0h, 7FF7C7BB08D0h]
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
; location: [7FF7C7BB08F0h, 7FF7C7BB0981h]
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
; location: [7FF7C7BB09A0h, 7FF7C7BB09D3h]
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
