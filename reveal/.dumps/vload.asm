; 2020-01-05 02:30:52:122
; function: Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
; location: [7FF7C7BC5600h, 7FF7C7BC5697h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000dh vpmovzxbd ymm1,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM1,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c8
0012h vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
0018h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
001dh vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
0022h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0025h vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
0029h vpgatherdd ymm3,[rdx+ymm1],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RDX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 0a
002fh vpcmpeqd ymm1,ymm1,ymm1       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1] encoding(VEX, 4 bytes) = c5 f5 76 c9
0033h vpgatherdd ymm2,[rax+ymm0],ymm1; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM2,mem(32i,RAX:br,:sr),YMM1] encoding(VEX, 6 bytes) = c4 e2 75 90 14 00
0039h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0041h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0046h vpbroadcastd ymm0,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 04
004dh vpand ymm1,ymm3,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM3,YMM0]    encoding(VEX, 4 bytes) = c5 e5 db c8
0051h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0055h vpackusdw ymm0,ymm1,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 2b c0
005ah vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0060h vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0066h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
006ch mov dword ptr [rsp],0FFh      ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(7 bytes) = c7 04 24 ff 00 00 00
0073h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0077h vpbroadcastw xmm2,word ptr [rsp]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 79 14 24
007dh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0081h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0085h vpackuswb xmm0,xmm1,xmm0      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 67 c0
0089h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
008dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0090h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0093h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0097h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vgather_128x8uBytes => new byte[152]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE2,0x7D,0x31,0xC8,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE2,0x7D,0x31,0xC0,0x48,0x8B,0xD0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x0A,0xC5,0xF5,0x76,0xC9,0xC4,0xE2,0x75,0x90,0x14,0x00,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC5,0xE5,0xDB,0xC8,0xC5,0xED,0xDB,0xC0,0xC4,0xE2,0x75,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x04,0x24,0xFF,0x00,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x79,0x14,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0x67,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
; location: [7FF7C7BC56C0h, 7FF7C7BC5717h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000dh vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
0012h vpcmpeqd ymm1,ymm1,ymm1       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1] encoding(VEX, 4 bytes) = c5 f5 76 c9
0016h vpgatherdd ymm2,[rax+ymm0*2],ymm1; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM2,mem(32i,RAX:br,:sr),YMM1] encoding(VEX, 6 bytes) = c4 e2 75 90 14 40
001ch vextractf128 xmm0,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d0 00
0022h vextractf128 xmm1,ymm2,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d1 01
0028h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0030h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0035h vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
003ch vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0040h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0044h vpackusdw xmm0,xmm0,xmm1      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 2b c1
0049h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0050h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0053h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vgather_128x16uBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xF5,0x76,0xC9,0xC4,0xE2,0x75,0x90,0x14,0x40,0xC4,0xE3,0x7D,0x19,0xD0,0x00,0xC4,0xE3,0x7D,0x19,0xD1,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC4,0xE2,0x79,0x2B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
; location: [7FF7C7BC5740h, 7FF7C7BC587Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
000ah vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000fh vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0013h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0019h vpmovzxbd ymm2,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM2,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 d0
001eh vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
0024h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0029h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
002eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0031h vpcmpeqd ymm3,ymm3,ymm3       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3] encoding(VEX, 4 bytes) = c5 e5 76 db
0035h vpgatherdd ymm4,[rdx+ymm2],ymm3; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM4,mem(32i,RDX:br,:sr),YMM3] encoding(VEX, 6 bytes) = c4 e2 65 90 24 12
003bh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
003eh vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
0042h vpgatherdd ymm3,[rdx+ymm0],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RDX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 02
0048h mov dword ptr [rsp+14h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 14 ff ff 00 00
0050h lea rdx,[rsp+14h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 14
0055h vpbroadcastd ymm0,dword ptr [rsp+14h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 14
005ch vpand ymm2,ymm4,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM4,YMM0]    encoding(VEX, 4 bytes) = c5 dd db d0
0060h vpand ymm0,ymm3,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0]    encoding(VEX, 4 bytes) = c5 e5 db c0
0064h vpackusdw ymm0,ymm2,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 5 bytes) = c4 e2 6d 2b c0
0069h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
006fh vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0075h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
007bh mov dword ptr [rsp+10h],0FFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 10 ff 00 00 00
0083h lea rdx,[rsp+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 10
0088h vpbroadcastw xmm3,word ptr [rsp+10h]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM3,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 5c 24 10
008fh vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0093h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
0097h vpackuswb xmm0,xmm2,xmm0      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0] encoding(VEX, 4 bytes) = c5 e9 67 c0
009bh vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
00a1h vpmovzxbd ymm2,xmm1           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM2,XMM1]      encoding(VEX, 5 bytes) = c4 e2 7d 31 d1
00a6h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
00ach vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
00b1h vpmovzxbd ymm1,xmm1           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM1,XMM1]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c9
00b6h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
00b9h vpcmpeqd ymm3,ymm3,ymm3       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3] encoding(VEX, 4 bytes) = c5 e5 76 db
00bdh vpgatherdd ymm4,[rdx+ymm2],ymm3; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM4,mem(32i,RDX:br,:sr),YMM3] encoding(VEX, 6 bytes) = c4 e2 65 90 24 12
00c3h vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
00c7h vpgatherdd ymm3,[rax+ymm1],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RAX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 08
00cdh mov dword ptr [rsp+0Ch],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 0c ff ff 00 00
00d5h lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
00dah vpbroadcastd ymm1,dword ptr [rsp+0Ch]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 0c
00e1h vpand ymm2,ymm4,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM4,YMM1]    encoding(VEX, 4 bytes) = c5 dd db d1
00e5h vpand ymm1,ymm3,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]    encoding(VEX, 4 bytes) = c5 e5 db c9
00e9h vpackusdw ymm1,ymm2,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1] encoding(VEX, 5 bytes) = c4 e2 6d 2b c9
00eeh vpermq ymm1,ymm1,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM1,YMM1,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c9 d8
00f4h vextractf128 xmm2,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ca 00
00fah vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0100h mov dword ptr [rsp+8],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 08 ff 00 00 00
0108h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
010dh vpbroadcastw xmm3,word ptr [rsp+8]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM3,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 5c 24 08
0114h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0118h vpand xmm1,xmm1,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 db cb
011ch vpackuswb xmm1,xmm2,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1] encoding(VEX, 4 bytes) = c5 e9 67 c9
0120h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0124h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
012ah vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0130h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0134h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0137h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
013ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
013eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vgather_256x8uBytes => new byte[319]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC4,0xE2,0x7D,0x31,0xD0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE2,0x7D,0x31,0xC0,0x48,0x8B,0xD0,0xC5,0xE5,0x76,0xDB,0xC4,0xE2,0x65,0x90,0x24,0x12,0x48,0x8B,0xD0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x02,0xC7,0x44,0x24,0x14,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x14,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x14,0xC5,0xDD,0xDB,0xD0,0xC5,0xE5,0xDB,0xC0,0xC4,0xE2,0x6D,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x10,0xFF,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x10,0xC4,0xE2,0x79,0x79,0x5C,0x24,0x10,0xC5,0xE9,0xDB,0xD3,0xC5,0xF9,0xDB,0xC3,0xC5,0xE9,0x67,0xC0,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x31,0xD1,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE2,0x7D,0x31,0xC9,0x48,0x8B,0xD0,0xC5,0xE5,0x76,0xDB,0xC4,0xE2,0x65,0x90,0x24,0x12,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x08,0xC7,0x44,0x24,0x0C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x0C,0xC5,0xDD,0xDB,0xD1,0xC5,0xE5,0xDB,0xC9,0xC4,0xE2,0x6D,0x2B,0xC9,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC4,0xE3,0x7D,0x19,0xCA,0x00,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC7,0x44,0x24,0x08,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC4,0xE2,0x79,0x79,0x5C,0x24,0x08,0xC5,0xE9,0xDB,0xD3,0xC5,0xF1,0xDB,0xCB,0xC5,0xE9,0x67,0xC9,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<short> vgather_256x16i(Span<short> src, Vector256<short> vix)
; location: [7FF7C7BC58B0h, 7FF7C7BC5963h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000dh vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0011h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0017h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
001ah vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
001fh vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
0023h vpgatherdd ymm3,[rdx+ymm0*2],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RDX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 42
0029h vextractf128 xmm0,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d8 00
002fh vextractf128 xmm2,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 da 01
0035h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
003dh lea rdx,[rsp+4]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 04
0042h vpbroadcastd xmm3,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 5c 24 04
0049h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
004dh vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0051h vpackusdw xmm0,xmm0,xmm2      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 2b c2
0056h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
005ch vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0061h vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
0065h vpgatherdd ymm3,[rax+ymm1*2],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RAX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 48
006bh vextractf128 xmm1,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d9 00
0071h vextractf128 xmm2,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 da 01
0077h mov dword ptr [rsp],0FFFFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(7 bytes) = c7 04 24 ff ff 00 00
007eh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0082h vpbroadcastd xmm3,dword ptr [rsp]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 58 1c 24
0088h vpand xmm1,xmm1,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 db cb
008ch vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0090h vpackusdw xmm1,xmm1,xmm2      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 2b ca
0095h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0099h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
009fh vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
00a5h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
00a9h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00ach vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00afh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00b3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vgather_256x16iBytes => new byte[180]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0x48,0x8B,0xD0,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x42,0xC4,0xE3,0x7D,0x19,0xD8,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x04,0xC4,0xE2,0x79,0x58,0x5C,0x24,0x04,0xC5,0xF9,0xDB,0xC3,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x79,0x2B,0xC2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x48,0xC4,0xE3,0x7D,0x19,0xD9,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x04,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x58,0x1C,0x24,0xC5,0xF1,0xDB,0xCB,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x71,0x2B,0xCA,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vgather_256x16u(Span<ushort> src, Vector256<ushort> vix)
; location: [7FF7C7BC5D90h, 7FF7C7BC5E43h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000dh vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0011h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0017h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
001ah vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
001fh vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
0023h vpgatherdd ymm3,[rdx+ymm0*2],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RDX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 42
0029h vextractf128 xmm0,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d8 00
002fh vextractf128 xmm2,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 da 01
0035h mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
003dh lea rdx,[rsp+4]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 04
0042h vpbroadcastd xmm3,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 5c 24 04
0049h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
004dh vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0051h vpackusdw xmm0,xmm0,xmm2      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 2b c2
0056h vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
005ch vpmovzxwd ymm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c9
0061h vpcmpeqd ymm2,ymm2,ymm2       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ed 76 d2
0065h vpgatherdd ymm3,[rax+ymm1*2],ymm2; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM3,mem(32i,RAX:br,:sr),YMM2] encoding(VEX, 6 bytes) = c4 e2 6d 90 1c 48
006bh vextractf128 xmm1,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d9 00
0071h vextractf128 xmm2,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 da 01
0077h mov dword ptr [rsp],0FFFFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(7 bytes) = c7 04 24 ff ff 00 00
007eh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0082h vpbroadcastd xmm3,dword ptr [rsp]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 58 1c 24
0088h vpand xmm1,xmm1,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 db cb
008ch vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0090h vpackusdw xmm1,xmm1,xmm2      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 2b ca
0095h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0099h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
009fh vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
00a5h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
00a9h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00ach vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00afh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
00b3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vgather_256x16uBytes => new byte[180]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0x48,0x8B,0xD0,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x42,0xC4,0xE3,0x7D,0x19,0xD8,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x04,0xC4,0xE2,0x79,0x58,0x5C,0x24,0x04,0xC5,0xF9,0xDB,0xC3,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x79,0x2B,0xC2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x48,0xC4,0xE3,0x7D,0x19,0xD9,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x04,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x58,0x1C,0x24,0xC5,0xF1,0xDB,0xCB,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x71,0x2B,0xCA,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vgather_256x32i(Span<int> src, Vector256<int> vix)
; location: [7FF7C7BC5E70h, 7FF7C7BC5E91h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000dh vpcmpeqd ymm1,ymm1,ymm1       ; VPCMPEQD(VEX_Vpcmpeqd_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1] encoding(VEX, 4 bytes) = c5 f5 76 c9
0011h vpgatherdd ymm2,[rax+ymm0*4],ymm1; VPGATHERDD(VEX_Vpgatherdd_ymm_vm32y_ymm) [YMM2,mem(32i,RAX:br,:sr),YMM1] encoding(VEX, 6 bytes) = c4 e2 75 90 14 80
0017h vmovupd [rcx],ymm2            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM2] encoding(VEX, 4 bytes) = c5 fd 11 11
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vgather_256x32iBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xF5,0x76,0xC9,0xC4,0xE2,0x75,0x90,0x14,0x80,0xC5,0xFD,0x11,0x11,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7BC5EB0h, 7FF7C7BC5EEAh]
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
; static ReadOnlySpan<byte> vpackus_2x128x32Bytes => new byte[59]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC4,0xE2,0x79,0x2B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
; location: [7FF7C7BC5F10h, 7FF7C7BC5F29h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
000fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
; location: [7FF7C7BC5F40h, 7FF7C7BC5F58h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_256x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
