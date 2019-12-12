; 2019-12-11 14:36:57:695
; function: byte butterfly_8x1(byte x)
; location: [7FFDD8E402D0h, 7FFDD8E402F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,66h                   ; AND(And_rm32_imm8) [EDX,66h:imm32]                   encoding(3 bytes) = 83 e2 66
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0011h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0013h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0015h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh and edx,66h                   ; AND(And_rm32_imm8) [EDX,66h:imm32]                   encoding(3 bytes) = 83 e2 66
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_8x1Bytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0x83,0xE2,0x66,0x8B,0xCA,0xD1,0xE1,0x33,0xCA,0xD1,0xEA,0x33,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x83,0xE2,0x66,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vbutterfly_128x8x1(Vector128<byte> x)
; location: [7FFDD8E40720h, 7FFDD8E407A8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh mov dword ptr [rsp+14h],66h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(8 bytes) = c7 44 24 14 66 00 00 00
0013h lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 14
0018h vpbroadcastb xmm1,byte ptr [rsp+14h]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 4c 24 14
001fh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0023h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0027h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002bh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002fh vpsllq xmm3,xmm3,1            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 01
0034h mov dword ptr [rsp+10h],0FEh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),feh:imm32]  encoding(8 bytes) = c7 44 24 10 fe 00 00 00
003ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0041h vpbroadcastb xmm4,byte ptr [rsp+10h]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM4,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 64 24 10
0048h vpand xmm3,xmm3,xmm4          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 db dc
004ch vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0050h vpsrlq xmm4,xmm4,1            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 01
0055h mov dword ptr [rsp+0Ch],7Fh   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),7fh:imm32]  encoding(8 bytes) = c7 44 24 0c 7f 00 00 00
005dh lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
0062h vpbroadcastb xmm5,byte ptr [rsp+0Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM5,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 6c 24 0c
0069h vpand xmm4,xmm4,xmm5          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]    encoding(VEX, 4 bytes) = c5 d9 db e5
006dh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0071h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0075h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0079h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
007dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0081h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0084h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0088h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x8x1Bytes => new byte[137]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x14,0x66,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x79,0x78,0x4C,0x24,0x14,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x01,0xC7,0x44,0x24,0x10,0xFE,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x79,0x78,0x64,0x24,0x10,0xC5,0xE1,0xDB,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x01,0xC7,0x44,0x24,0x0C,0x7F,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x79,0x78,0x6C,0x24,0x0C,0xC5,0xD9,0xDB,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vbutterfly_256x8x1(Vector256<byte> x)
; location: [7FFDD8E407D0h, 7FFDD8E4085Bh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh mov dword ptr [rsp+14h],66h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(8 bytes) = c7 44 24 14 66 00 00 00
0013h lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 14
0018h vpbroadcastb ymm1,byte ptr [rsp+14h]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 4c 24 14
001fh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0023h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0027h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002bh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002fh vpsllq ymm3,ymm3,1            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 01
0034h mov dword ptr [rsp+10h],0FEh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),feh:imm32]  encoding(8 bytes) = c7 44 24 10 fe 00 00 00
003ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0041h vpbroadcastb ymm4,byte ptr [rsp+10h]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM4,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 64 24 10
0048h vpand ymm3,ymm3,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 db dc
004ch vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0050h vpsrlq ymm4,ymm4,1            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 01
0055h mov dword ptr [rsp+0Ch],7Fh   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),7fh:imm32]  encoding(8 bytes) = c7 44 24 0c 7f 00 00 00
005dh lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
0062h vpbroadcastb ymm5,byte ptr [rsp+0Ch]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM5,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 6c 24 0c
0069h vpand ymm4,ymm4,ymm5          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]    encoding(VEX, 4 bytes) = c5 dd db e5
006dh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0071h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0075h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0079h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
007dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0081h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0084h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0087h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
008bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x8x1Bytes => new byte[140]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x14,0x66,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x7D,0x78,0x4C,0x24,0x14,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x01,0xC7,0x44,0x24,0x10,0xFE,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x7D,0x78,0x64,0x24,0x10,0xC5,0xE5,0xDB,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x01,0xC7,0x44,0x24,0x0C,0x7F,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x78,0x6C,0x24,0x0C,0xC5,0xDD,0xDB,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly_16x1(ushort x)
; location: [7FFDD8E40880h, 7FFDD8E408AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,6666h                 ; AND(And_rm32_imm32) [EDX,6666h:imm32]                encoding(6 bytes) = 81 e2 66 66 00 00
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0014h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0016h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0018h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0020h and edx,6666h                 ; AND(And_rm32_imm32) [EDX,6666h:imm32]                encoding(6 bytes) = 81 e2 66 66 00 00
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
002bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_16x1Bytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0x81,0xE2,0x66,0x66,0x00,0x00,0x8B,0xCA,0xD1,0xE1,0x33,0xCA,0xD1,0xEA,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0x66,0x66,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly_128x16x1(Vector128<ushort> x)
; location: [7FFDD8E408C0h, 7FFDD8E40916h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw xmm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpsllw xmm3,xmm3,1            ; VPSLLW(VEX_Vpsllw_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 71 f3 01
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrlw xmm4,xmm4,1            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 71 d4 01
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x16x1Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x71,0xF3,0x01,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x71,0xD4,0x01,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly_256x16x1(Vector256<ushort> x)
; location: [7FFDD8E40D40h, 7FFDD8E40D99h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw ymm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpsllw ymm3,ymm3,1            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 01
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrlw ymm4,ymm4,1            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 01
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x16x1Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x71,0xF3,0x01,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x71,0xD4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly_32x1(uint x)
; location: [7FFDD8E40DC0h, 7FFDD8E40DDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,66666666h             ; AND(And_EAX_imm32) [EAX,66666666h:imm32]             encoding(5 bytes) = 25 66 66 66 66
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0010h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0012h shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h and eax,66666666h             ; AND(And_EAX_imm32) [EAX,66666666h:imm32]             encoding(5 bytes) = 25 66 66 66 66
001bh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x1Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x66,0x66,0x66,0x66,0x8B,0xD0,0xD1,0xE2,0x33,0xD0,0xD1,0xE8,0x33,0xC2,0x25,0x66,0x66,0x66,0x66,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x1(Vector128<uint> x)
; location: [7FFDD8E40DF0h, 7FFDD8E40E46h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpslld xmm3,xmm3,1            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 01
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrld xmm4,xmm4,1            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 01
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x1Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x01,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x01,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x1(Vector256<uint> x)
; location: [7FFDD8E40E70h, 7FFDD8E40EC9h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpslld ymm3,ymm3,1            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 01
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrld ymm4,ymm4,1            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 01
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x1Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x01,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x1(ulong x)
; location: [7FFDD8E40EF0h, 7FFDD8E40F24h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,1                     ; SHL(Shl_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 e2
0018h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001bh shr rax,1                     ; SHR(Shr_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e8
001eh xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0021h mov rdx,6666666666666666h     ; MOV(Mov_r64_imm64) [RDX,6666666666666666h:imm64]     encoding(10 bytes) = 48 ba 66 66 66 66 66 66 66 66
002bh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
002eh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0031h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x1Bytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xD1,0xE2,0x48,0x33,0xD0,0x48,0xD1,0xE8,0x48,0x33,0xC2,0x48,0xBA,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x1(Vector128<ulong> x)
; location: [7FFDD8E41340h, 7FFDD8E4139Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h vpsllq xmm3,xmm3,1            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 01
0036h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003ah vpsrlq xmm4,xmm4,1            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 01
003fh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0043h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0047h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
004bh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x1Bytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x01,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x01,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x1(Vector256<ulong> x)
; location: [7FFDD8E413C0h, 7FFDD8E4141Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h vpsllq ymm3,ymm3,1            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,1h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 01
0036h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003ah vpsrlq ymm4,ymm4,1            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,1h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 01
003fh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0043h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0047h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
004bh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x1Bytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x01,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte butterfly_8x2(byte x)
; location: [7FFDD8E41440h, 7FFDD8E4146Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,3Ch                   ; AND(And_rm32_imm8) [EDX,3ch:imm32]                   encoding(3 bytes) = 83 e2 3c
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0012h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0014h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
0017h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001fh and edx,3Ch                   ; AND(And_rm32_imm8) [EDX,3ch:imm32]                   encoding(3 bytes) = 83 e2 3c
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_8x2Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0x83,0xE2,0x3C,0x8B,0xCA,0xC1,0xE1,0x02,0x33,0xCA,0xC1,0xEA,0x02,0x33,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x83,0xE2,0x3C,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vbutterfly_128x8x2(Vector128<byte> x)
; location: [7FFDD8E41480h, 7FFDD8E41508h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh mov dword ptr [rsp+14h],3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(8 bytes) = c7 44 24 14 3c 00 00 00
0013h lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 14
0018h vpbroadcastb xmm1,byte ptr [rsp+14h]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 4c 24 14
001fh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0023h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0027h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002bh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002fh vpsllq xmm3,xmm3,2            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 02
0034h mov dword ptr [rsp+10h],0FCh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),fch:imm32]  encoding(8 bytes) = c7 44 24 10 fc 00 00 00
003ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0041h vpbroadcastb xmm4,byte ptr [rsp+10h]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM4,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 64 24 10
0048h vpand xmm3,xmm3,xmm4          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 db dc
004ch vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0050h vpsrlq xmm4,xmm4,2            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 02
0055h mov dword ptr [rsp+0Ch],3Fh   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3fh:imm32]  encoding(8 bytes) = c7 44 24 0c 3f 00 00 00
005dh lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
0062h vpbroadcastb xmm5,byte ptr [rsp+0Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM5,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 6c 24 0c
0069h vpand xmm4,xmm4,xmm5          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]    encoding(VEX, 4 bytes) = c5 d9 db e5
006dh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0071h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0075h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0079h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
007dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0081h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0084h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0088h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x8x2Bytes => new byte[137]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x14,0x3C,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x79,0x78,0x4C,0x24,0x14,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x02,0xC7,0x44,0x24,0x10,0xFC,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x79,0x78,0x64,0x24,0x10,0xC5,0xE1,0xDB,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x02,0xC7,0x44,0x24,0x0C,0x3F,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x79,0x78,0x6C,0x24,0x0C,0xC5,0xD9,0xDB,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vbutterfly_256x8x2(Vector256<byte> x)
; location: [7FFDD8E41530h, 7FFDD8E415BBh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh mov dword ptr [rsp+14h],3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(8 bytes) = c7 44 24 14 3c 00 00 00
0013h lea rax,[rsp+14h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 14
0018h vpbroadcastb ymm1,byte ptr [rsp+14h]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 4c 24 14
001fh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0023h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0027h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002bh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002fh vpsllq ymm3,ymm3,2            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 02
0034h mov dword ptr [rsp+10h],0FCh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),fch:imm32]  encoding(8 bytes) = c7 44 24 10 fc 00 00 00
003ch lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0041h vpbroadcastb ymm4,byte ptr [rsp+10h]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM4,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 64 24 10
0048h vpand ymm3,ymm3,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 db dc
004ch vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0050h vpsrlq ymm4,ymm4,2            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 02
0055h mov dword ptr [rsp+0Ch],3Fh   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3fh:imm32]  encoding(8 bytes) = c7 44 24 0c 3f 00 00 00
005dh lea rax,[rsp+0Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 0c
0062h vpbroadcastb ymm5,byte ptr [rsp+0Ch]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM5,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 6c 24 0c
0069h vpand ymm4,ymm4,ymm5          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]    encoding(VEX, 4 bytes) = c5 dd db e5
006dh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0071h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0075h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0079h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
007dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0081h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0084h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0087h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
008bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x8x2Bytes => new byte[140]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x14,0x3C,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x14,0xC4,0xE2,0x7D,0x78,0x4C,0x24,0x14,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x02,0xC7,0x44,0x24,0x10,0xFC,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC4,0xE2,0x7D,0x78,0x64,0x24,0x10,0xC5,0xE5,0xDB,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x02,0xC7,0x44,0x24,0x0C,0x3F,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x78,0x6C,0x24,0x0C,0xC5,0xDD,0xDB,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly_16x2(ushort x)
; location: [7FFDD8E415E0h, 7FFDD8E41610h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,3C3Ch                 ; AND(And_rm32_imm32) [EDX,3c3ch:imm32]                encoding(6 bytes) = 81 e2 3c 3c 00 00
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0015h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0017h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
001ah xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h and edx,3C3Ch                 ; AND(And_rm32_imm32) [EDX,3c3ch:imm32]                encoding(6 bytes) = 81 e2 3c 3c 00 00
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
002dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_16x2Bytes => new byte[49]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0x81,0xE2,0x3C,0x3C,0x00,0x00,0x8B,0xCA,0xC1,0xE1,0x02,0x33,0xCA,0xC1,0xEA,0x02,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0x3C,0x3C,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly_128x16x2(Vector128<ushort> x)
; location: [7FFDD8E41630h, 7FFDD8E41686h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw xmm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpsllw xmm3,xmm3,2            ; VPSLLW(VEX_Vpsllw_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 71 f3 02
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrlw xmm4,xmm4,2            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 71 d4 02
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x16x2Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x71,0xF3,0x02,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x71,0xD4,0x02,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly_256x16x2(Vector256<ushort> x)
; location: [7FFDD8E416B0h, 7FFDD8E41709h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw ymm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpsllw ymm3,ymm3,2            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 02
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrlw ymm4,ymm4,2            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 02
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x16x2Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x71,0xF3,0x02,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x71,0xD4,0x02,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly_32x2(uint x)
; location: [7FFDD8E41730h, 7FFDD8E4174Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,3C3C3C3Ch             ; AND(And_EAX_imm32) [EAX,3c3c3c3ch:imm32]             encoding(5 bytes) = 25 3c 3c 3c 3c
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,2                     ; SHL(Shl_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 e2 02
0011h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0013h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h and eax,3C3C3C3Ch             ; AND(And_EAX_imm32) [EAX,3c3c3c3ch:imm32]             encoding(5 bytes) = 25 3c 3c 3c 3c
001dh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x2Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x3C,0x3C,0x3C,0x3C,0x8B,0xD0,0xC1,0xE2,0x02,0x33,0xD0,0xC1,0xE8,0x02,0x33,0xC2,0x25,0x3C,0x3C,0x3C,0x3C,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x2(Vector128<uint> x)
; location: [7FFDD8E41760h, 7FFDD8E417B6h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpslld xmm3,xmm3,2            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 02
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrld xmm4,xmm4,2            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 02
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x2Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x02,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x02,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x2(Vector256<uint> x)
; location: [7FFDD8E417E0h, 7FFDD8E41839h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpslld ymm3,ymm3,2            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 02
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrld ymm4,ymm4,2            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 02
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x2Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x02,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x02,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x2(ulong x)
; location: [7FFDD8E41860h, 7FFDD8E41896h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,2                     ; SHL(Shl_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 e2 02
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RDX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 ba 3c 3c 3c 3c 3c 3c 3c 3c
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x2Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x02,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x02,0x48,0x33,0xC2,0x48,0xBA,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x2(Vector128<ulong> x)
; location: [7FFDD8E418B0h, 7FFDD8E4190Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h vpsllq xmm3,xmm3,2            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 02
0036h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003ah vpsrlq xmm4,xmm4,2            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 02
003fh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0043h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0047h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
004bh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x2Bytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x02,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x02,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x2(Vector256<ulong> x)
; location: [7FFDD8E41930h, 7FFDD8E4198Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h vpsllq ymm3,ymm3,2            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,2h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 02
0036h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003ah vpsrlq ymm4,ymm4,2            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,2h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 02
003fh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0043h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0047h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
004bh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x2Bytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x02,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x02,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly_16x4(ushort x)
; location: [7FFDD8E419B0h, 7FFDD8E419E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000dh and edx,0FF0h                 ; AND(And_rm32_imm32) [EDX,ff0h:imm32]                 encoding(6 bytes) = 81 e2 f0 0f 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0018h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
001ah shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
001dh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h and edx,0FF0h                 ; AND(And_rm32_imm32) [EDX,ff0h:imm32]                 encoding(6 bytes) = 81 e2 f0 0f 00 00
002bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0030h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_16x4Bytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0x0F,0xB7,0xD2,0x81,0xE2,0xF0,0x0F,0x00,0x00,0x8B,0xCA,0xC1,0xE1,0x04,0x33,0xCA,0xC1,0xEA,0x04,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0xF0,0x0F,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly_128x16x4(Vector128<ushort> x)
; location: [7FFDD8E41A00h, 7FFDD8E41A56h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw xmm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpsllw xmm3,xmm3,4            ; VPSLLW(VEX_Vpsllw_xmm_xmm_imm8) [XMM3,XMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e1 71 f3 04
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrlw xmm4,xmm4,4            ; VPSRLW(VEX_Vpsrlw_xmm_xmm_imm8) [XMM4,XMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 d9 71 d4 04
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x16x4Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x71,0xF3,0x04,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x71,0xD4,0x04,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly_256x16x4(Vector256<ushort> x)
; location: [7FFDD8E41A80h, 7FFDD8E41AD9h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw ymm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpsllw ymm3,ymm3,4            ; VPSLLW(VEX_Vpsllw_ymm_ymm_imm8) [YMM3,YMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e5 71 f3 04
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrlw ymm4,ymm4,4            ; VPSRLW(VEX_Vpsrlw_ymm_ymm_imm8) [YMM4,YMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 dd 71 d4 04
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x16x4Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x71,0xF3,0x04,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x71,0xD4,0x04,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_32x4(uint x)
; location: [7FFDD8E41B00h, 7FFDD8E41B1Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0FF00FF0h             ; AND(And_EAX_imm32) [EAX,ff00ff0h:imm32]              encoding(5 bytes) = 25 f0 0f f0 0f
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
0011h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0013h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h and eax,0FF00FF0h             ; AND(And_EAX_imm32) [EAX,ff00ff0h:imm32]              encoding(5 bytes) = 25 f0 0f f0 0f
001dh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x4Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xF0,0x0F,0xF0,0x0F,0x8B,0xD0,0xC1,0xE2,0x04,0x33,0xD0,0xC1,0xE8,0x04,0x33,0xC2,0x25,0xF0,0x0F,0xF0,0x0F,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x4(Vector128<uint> x)
; location: [7FFDD8E41B30h, 7FFDD8E41B86h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpslld xmm3,xmm3,4            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 04
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrld xmm4,xmm4,4            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 04
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x4Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x04,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x04,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x4(Vector256<uint> x)
; location: [7FFDD8E41BB0h, 7FFDD8E41C09h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpslld ymm3,ymm3,4            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 04
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrld ymm4,ymm4,4            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 04
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x4Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x04,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x04,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x4(ulong x)
; location: [7FFDD8E41C30h, 7FFDD8E41C66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,4                     ; SHL(Shl_rm64_imm8) [RDX,4h:imm8]                     encoding(4 bytes) = 48 c1 e2 04
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,4                     ; SHR(Shr_rm64_imm8) [RAX,4h:imm8]                     encoding(4 bytes) = 48 c1 e8 04
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RDX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 ba f0 0f f0 0f f0 0f f0 0f
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x4Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x04,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x04,0x48,0x33,0xC2,0x48,0xBA,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x4(Vector128<ulong> x)
; location: [7FFDD8E41C80h, 7FFDD8E41CDAh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h vpsllq xmm3,xmm3,4            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 04
0036h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003ah vpsrlq xmm4,xmm4,4            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 04
003fh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0043h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0047h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
004bh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x4Bytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x04,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x04,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x4(Vector256<ulong> x)
; location: [7FFDD8E41D00h, 7FFDD8E41D5Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h vpsllq ymm3,ymm3,4            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,4h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 04
0036h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003ah vpsrlq ymm4,ymm4,4            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,4h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 04
003fh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0043h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0047h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
004bh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x4Bytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x04,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x04,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_32x8(uint x)
; location: [7FFDD8E42190h, 7FFDD8E421AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0FFFF00h              ; AND(And_EAX_imm32) [EAX,ffff00h:imm32]               encoding(5 bytes) = 25 00 ff ff 00
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0011h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0013h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h and eax,0FFFF00h              ; AND(And_EAX_imm32) [EAX,ffff00h:imm32]               encoding(5 bytes) = 25 00 ff ff 00
001dh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x8Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x00,0xFF,0xFF,0x00,0x8B,0xD0,0xC1,0xE2,0x08,0x33,0xD0,0xC1,0xE8,0x08,0x33,0xC2,0x25,0x00,0xFF,0xFF,0x00,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x8(Vector128<uint> x)
; location: [7FFDD8E421C0h, 7FFDD8E42216h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh vpslld xmm3,xmm3,8            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM3,XMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e1 72 f3 08
0032h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0036h vpsrld xmm4,xmm4,8            ; VPSRLD(VEX_Vpsrld_xmm_xmm_imm8) [XMM4,XMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 d9 72 d4 08
003bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
003fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0043h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0047h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x8Bytes => new byte[87]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x72,0xF3,0x08,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x72,0xD4,0x08,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x8(Vector256<uint> x)
; location: [7FFDD8E42240h, 7FFDD8E42299h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh vpslld ymm3,ymm3,8            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM3,YMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e5 72 f3 08
0032h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0036h vpsrld ymm4,ymm4,8            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM4,YMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 dd 72 d4 08
003bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
003fh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0043h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0047h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0055h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x8Bytes => new byte[90]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x72,0xF3,0x08,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x72,0xD4,0x08,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x8(ulong x)
; location: [7FFDD8E422C0h, 7FFDD8E422F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RDX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 ba 00 ff ff 00 00 ff ff 00
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x8Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x08,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x08,0x48,0x33,0xC2,0x48,0xBA,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x8(Vector128<ulong> x)
; location: [7FFDD8E42310h, 7FFDD8E4236Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h vpsllq xmm3,xmm3,8            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e1 73 f3 08
0036h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003ah vpsrlq xmm4,xmm4,8            ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 d9 73 d4 08
003fh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0043h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0047h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
004bh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x8Bytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x08,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x08,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x8(Vector256<ulong> x)
; location: [7FFDD8E42390h, 7FFDD8E423EDh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h vpsllq ymm3,ymm3,8            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,8h:imm8]  encoding(VEX, 5 bytes) = c5 e5 73 f3 08
0036h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003ah vpsrlq ymm4,ymm4,8            ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,8h:imm8]  encoding(VEX, 5 bytes) = c5 dd 73 d4 08
003fh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0043h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0047h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
004bh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x8Bytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x08,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x08,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x16(ulong x)
; location: [7FFDD8E42410h, 7FFDD8E42446h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RDX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 ba 00 00 ff ff ff ff 00 00
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x16Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x10,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x10,0x48,0x33,0xC2,0x48,0xBA,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x16(Vector128<ulong> x)
; location: [7FFDD8E42460h, 7FFDD8E424BAh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h vpsllq xmm3,xmm3,10h          ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM3,XMM3,10h:imm8] encoding(VEX, 5 bytes) = c5 e1 73 f3 10
0036h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003ah vpsrlq xmm4,xmm4,10h          ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_imm8) [XMM4,XMM4,10h:imm8] encoding(VEX, 5 bytes) = c5 d9 73 d4 10
003fh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0043h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0047h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
004bh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
004fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x16Bytes => new byte[91]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0x73,0xF3,0x10,0xC5,0xF8,0x28,0xE2,0xC5,0xD9,0x73,0xD4,0x10,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x16(Vector256<ulong> x)
; location: [7FFDD8E424E0h, 7FFDD8E4253Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h vpsllq ymm3,ymm3,10h          ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM3,YMM3,10h:imm8] encoding(VEX, 5 bytes) = c5 e5 73 f3 10
0036h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003ah vpsrlq ymm4,ymm4,10h          ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_imm8) [YMM4,YMM4,10h:imm8] encoding(VEX, 5 bytes) = c5 dd 73 d4 10
003fh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0043h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0047h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
004bh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x16Bytes => new byte[94]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0x73,0xF3,0x10,0xC5,0xFC,0x28,0xE2,0xC5,0xDD,0x73,0xD4,0x10,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
