; 2019-12-27 03:44:53:257
; function: byte pack_8(BitSpan src)
; location: [7FF7C7A87D90h, 7FF7C7A87E29h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
000dh cmp rdx,8                     ; CMP(Cmp_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 fa 08
0011h jb near ptr 0094h             ; JB(Jb_rel32_64) [94h:jmp64]                          encoding(6 bytes) = 0f 82 7d 00 00 00
0017h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
001bh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0021h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0027h mov dword ptr [rsp+24h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 24 ff ff 00 00
002fh lea rax,[rsp+24h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 24
0034h vpbroadcastd xmm2,dword ptr [rsp+24h]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 24
003bh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
003fh vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0043h vpackusdw xmm0,xmm1,xmm0      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 5 bytes) = c4 e2 71 2b c0
0048h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
004ch vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0050h vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
0054h vpcmpeqw xmm2,xmm2,xmm3       ; VPCMPEQW(VEX_Vpcmpeqw_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3] encoding(VEX, 4 bytes) = c5 e9 75 d3
0058h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
005ch vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0060h vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
0064h vpcmpeqw xmm2,xmm2,xmm3       ; VPCMPEQW(VEX_Vpcmpeqw_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3] encoding(VEX, 4 bytes) = c5 e9 75 d3
0068h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
006ch vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0070h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
0075h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0079h vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
007dh vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0081h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0084h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0087h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
008ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
008eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
008fh call 7FF82738FC20h            ; CALL(Call_rel32_64) [5F907E90h:jmp64]                encoding(5 bytes) = e8 fc 7d 90 5f
0094h call 7FF7C775D000h            ; CALL(Call_rel32_64) [FFFFFFFFFFCD5270h:jmp64]        encoding(5 bytes) = e8 d7 51 cd ff
0099h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack_8Bytes => new byte[154]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x08,0x0F,0x82,0x7D,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x79,0x58,0x54,0x24,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC4,0xE2,0x71,0x2B,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xE8,0x57,0xD2,0xC5,0xE0,0x57,0xDB,0xC5,0xE9,0x75,0xD3,0xC5,0xF9,0xDB,0xC2,0xC5,0xE8,0x57,0xD2,0xC5,0xE0,0x57,0xDB,0xC5,0xE9,0x75,0xD3,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFC,0x7D,0x90,0x5F,0xE8,0xD7,0x51,0xCD,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack_16(BitSpan src)
; location: [7FF7C7FF0480h, 7FF7C7FF0529h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
000dh cmp rdx,10h                   ; CMP(Cmp_rm64_imm8) [RDX,10h:imm64]                   encoding(4 bytes) = 48 83 fa 10
0011h jb near ptr 00a4h             ; JB(Jb_rel32_64) [A4h:jmp64]                          encoding(6 bytes) = 0f 82 8d 00 00 00
0017h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
001ah vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
001eh add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
0022h vlddqu ymm1,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 08
0026h mov dword ptr [rsp+24h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 24 ff ff 00 00
002eh lea rax,[rsp+24h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 24
0033h vpbroadcastd ymm2,dword ptr [rsp+24h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 54 24 24
003ah vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
003eh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0042h vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
0047h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
004dh vextractf128 xmm1,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 00
0053h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0059h mov rax,1FA708E5465h          ; MOV(Mov_r64_imm64) [RAX,1fa708e5465h:imm64]          encoding(10 bytes) = 48 b8 65 54 8e 70 fa 01 00 00
0063h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
0067h vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
006ch mov rax,1FA708E5635h          ; MOV(Mov_r64_imm64) [RAX,1fa708e5635h:imm64]          encoding(10 bytes) = 48 b8 35 56 8e 70 fa 01 00 00
0076h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
007ah vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
007fh vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0083h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
0088h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
008ch vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
0090h vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0094h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0097h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
009ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
009eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
009fh call 7FF82738FC20h            ; CALL(Call_rel32_64) [5F39F7A0h:jmp64]                encoding(5 bytes) = e8 fc f6 39 5f
00a4h call 7FF7C775D000h            ; CALL(Call_rel32_64) [FFFFFFFFFF76CB80h:jmp64]        encoding(5 bytes) = e8 d7 ca 76 ff
00a9h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack_16Bytes => new byte[170]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x10,0x0F,0x82,0x8D,0x00,0x00,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x48,0x83,0xC0,0x20,0xC5,0xFF,0xF0,0x08,0xC7,0x44,0x24,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x24,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0x48,0xB8,0x65,0x54,0x8E,0x70,0xFA,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0x48,0xB8,0x35,0x56,0x8E,0x70,0xFA,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0xC5,0xF1,0xEB,0xC0,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFC,0xF6,0x39,0x5F,0xE8,0xD7,0xCA,0x76,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack_32(BitSpan src)
; location: [7FF7C7FF0950h, 7FF7C7FF0A1Dh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
000dh cmp rdx,20h                   ; CMP(Cmp_rm64_imm8) [RDX,20h:imm64]                   encoding(4 bytes) = 48 83 fa 20
0011h jb near ptr 00c8h             ; JB(Jb_rel32_64) [C8h:jmp64]                          encoding(6 bytes) = 0f 82 b1 00 00 00
0017h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
001ah vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
001eh lea rdx,[rax+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 20
0022h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
0026h mov dword ptr [rsp+34h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 34 ff ff 00 00
002eh lea rdx,[rsp+34h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 34
0033h vpbroadcastd ymm2,dword ptr [rsp+34h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 54 24 34
003ah vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
003eh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0042h vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
0047h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
004dh lea rdx,[rax+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 40
0051h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
0055h add rax,60h                   ; ADD(Add_rm64_imm8) [RAX,60h:imm64]                   encoding(4 bytes) = 48 83 c0 60
0059h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
005dh mov dword ptr [rsp+30h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 30 ff ff 00 00
0065h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
006ah vpbroadcastd ymm3,dword ptr [rsp+30h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 5c 24 30
0071h vpand ymm1,ymm1,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 db cb
0075h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0079h vpackusdw ymm1,ymm1,ymm2      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 2b ca
007eh vpermq ymm1,ymm1,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM1,YMM1,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c9 d8
0084h mov dword ptr [rsp+2Ch],0FFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 2c ff 00 00 00
008ch lea rax,[rsp+2Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 2c
0091h vpbroadcastw ymm2,word ptr [rsp+2Ch]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 2c
0098h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
009ch vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
00a0h vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
00a4h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
00aah mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
00afh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00b3h vpsllq ymm0,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c1
00b7h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
00bbh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00beh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00c2h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00c3h call 7FF82738FC20h            ; CALL(Call_rel32_64) [5F39F2D0h:jmp64]                encoding(5 bytes) = e8 08 f2 39 5f
00c8h call 7FF7C775D000h            ; CALL(Call_rel32_64) [FFFFFFFFFF76C6B0h:jmp64]        encoding(5 bytes) = e8 e3 c5 76 ff
00cdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack_32Bytes => new byte[206]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x20,0x0F,0x82,0xB1,0x00,0x00,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x48,0x8D,0x50,0x20,0xC5,0xFF,0xF0,0x0A,0xC7,0x44,0x24,0x34,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x34,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x34,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x50,0x40,0xC5,0xFF,0xF0,0x0A,0x48,0x83,0xC0,0x60,0xC5,0xFF,0xF0,0x10,0xC7,0x44,0x24,0x30,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x30,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x30,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x2C,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x2C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x08,0xF2,0x39,0x5F,0xE8,0xE3,0xC5,0x76,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack_64(BitSpan src)
; location: [7FF7C7FF0A40h, 7FF7C7FF0BCBh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ah mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 51 08
000dh cmp rdx,40h                   ; CMP(Cmp_rm64_imm8) [RDX,40h:imm64]                   encoding(4 bytes) = 48 83 fa 40
0011h jb near ptr 0186h             ; JB(Jb_rel32_64) [186h:jmp64]                         encoding(6 bytes) = 0f 82 6f 01 00 00
0017h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
001ah vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
001eh lea rdx,[rax+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 20
0022h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
0026h mov dword ptr [rsp+34h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 34 ff ff 00 00
002eh lea rdx,[rsp+34h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 34
0033h vpbroadcastd ymm2,dword ptr [rsp+34h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 54 24 34
003ah vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
003eh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0042h vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
0047h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
004dh lea rdx,[rax+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 40
0051h vlddqu ymm1,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 0a
0055h lea rdx,[rax+60h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 60
0059h vlddqu ymm2,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 12
005dh mov dword ptr [rsp+30h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 30 ff ff 00 00
0065h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 30
006ah vpbroadcastd ymm3,dword ptr [rsp+30h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 5c 24 30
0071h vpand ymm1,ymm1,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 db cb
0075h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0079h vpackusdw ymm1,ymm1,ymm2      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 2b ca
007eh vpermq ymm1,ymm1,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM1,YMM1,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c9 d8
0084h mov dword ptr [rsp+2Ch],0FFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 2c ff 00 00 00
008ch lea rdx,[rsp+2Ch]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 2c
0091h vpbroadcastw ymm2,word ptr [rsp+2Ch]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 2c
0098h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
009ch vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
00a0h vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
00a4h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
00aah mov edx,7                     ; MOV(Mov_r32_imm32) [EDX,7h:imm32]                    encoding(5 bytes) = ba 07 00 00 00
00afh vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
00b3h vpsllq ymm0,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c1
00b7h vpmovmskb edx,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EDX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 d0
00bbh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
00bdh lea rcx,[rax+80h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(7 bytes) = 48 8d 88 80 00 00 00
00c4h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
00c8h lea rcx,[rax+0A0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(7 bytes) = 48 8d 88 a0 00 00 00
00cfh vlddqu ymm2,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 11
00d3h mov dword ptr [rsp+28h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 28 ff ff 00 00
00dbh lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 28
00e0h vpbroadcastd ymm0,dword ptr [rsp+28h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM0,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 44 24 28
00e7h vpand ymm1,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c8
00ebh vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
00efh vpackusdw ymm0,ymm1,ymm0      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 2b c0
00f4h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
00fah lea rcx,[rax+0C0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(7 bytes) = 48 8d 88 c0 00 00 00
0101h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0105h add rax,0E0h                  ; ADD(Add_RAX_imm32) [RAX,e0h:imm64]                   encoding(6 bytes) = 48 05 e0 00 00 00
010bh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
010fh mov dword ptr [rsp+24h],0FFFFh; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 24 ff ff 00 00
0117h lea rax,[rsp+24h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 24
011ch vpbroadcastd ymm3,dword ptr [rsp+24h]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM3,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 5c 24 24
0123h vpand ymm1,ymm1,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 db cb
0127h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
012bh vpackusdw ymm1,ymm1,ymm2      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 2b ca
0130h vpermq ymm1,ymm1,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM1,YMM1,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c9 d8
0136h mov dword ptr [rsp+20h],0FFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 20 ff 00 00 00
013eh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0143h vpbroadcastw ymm2,word ptr [rsp+20h]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 20
014ah vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
014eh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0152h vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
0156h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
015ch mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
0161h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0165h vpsllq ymm0,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c1
0169h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
016dh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
016fh shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0173h or rdx,rax                    ; OR(Or_r64_rm64) [RDX,RAX]                            encoding(3 bytes) = 48 0b d0
0176h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0179h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
017ch add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0180h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0181h call 7FF82738FC20h            ; CALL(Call_rel32_64) [5F39F1E0h:jmp64]                encoding(5 bytes) = e8 5a f0 39 5f
0186h call 7FF7C775D000h            ; CALL(Call_rel32_64) [FFFFFFFFFF76C5C0h:jmp64]        encoding(5 bytes) = e8 35 c4 76 ff
018bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack_64Bytes => new byte[396]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x40,0x0F,0x82,0x6F,0x01,0x00,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x48,0x8D,0x50,0x20,0xC5,0xFF,0xF0,0x0A,0xC7,0x44,0x24,0x34,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x34,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x34,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x50,0x40,0xC5,0xFF,0xF0,0x0A,0x48,0x8D,0x50,0x60,0xC5,0xFF,0xF0,0x12,0xC7,0x44,0x24,0x30,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x30,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x30,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x2C,0xFF,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x2C,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x2C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xBA,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xD0,0x8B,0xD2,0x48,0x8D,0x88,0x80,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x09,0x48,0x8D,0x88,0xA0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x11,0xC7,0x44,0x24,0x28,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x4C,0x24,0x28,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x28,0xC5,0xF5,0xDB,0xC8,0xC5,0xED,0xDB,0xC0,0xC4,0xE2,0x75,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x88,0xC0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x09,0x48,0x05,0xE0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC7,0x44,0x24,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x24,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x20,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x20,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xC0,0x8B,0xC0,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xD0,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x5A,0xF0,0x39,0x5F,0xE8,0x35,0xC4,0x76,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
