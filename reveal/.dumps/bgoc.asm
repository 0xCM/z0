; 2019-12-16 03:16:41:408
; function: Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)
; location: [7FF7C6A519D0h, 7FF7C6A519F0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
000ch movsxd rdx,r8d                ; MOVSXD(Movsxd_r64_rm32) [RDX,R8D]                    encoding(3 bytes) = 49 63 d0
000fh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0012h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0016h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitgrid_vector256Bytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x41,0xC1,0xE0,0x05,0x49,0x63,0xD0,0x48,0x03,0xC2,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)
; location: [7FF7C6A51E10h, 7FF7C6A5207Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
0012h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0016h vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
001ah vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
001eh mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
0023h pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
002fh vpinsrw xmm2,xmm2,edx,0       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,0h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 00
0034h vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
003ah mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
003fh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0044h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0047h vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
004dh vpinsrw xmm2,xmm2,eax,0       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,0h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 00
0052h vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
0058h mov eax,6                     ; MOV(Mov_r32_imm32) [EAX,6h:imm32]                    encoding(5 bytes) = b8 06 00 00 00
005dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0061h vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
0065h vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
0069h mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
006eh pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
0073h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0076h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
007ah vpinsrw xmm2,xmm2,edx,1       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,1h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 01
007fh vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
0085h mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
008ah pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
008fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0092h vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
0098h vpinsrw xmm2,xmm2,eax,1       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,1h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 01
009dh vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
00a3h mov eax,5                     ; MOV(Mov_r32_imm32) [EAX,5h:imm32]                    encoding(5 bytes) = b8 05 00 00 00
00a8h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00ach vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
00b0h vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
00b4h mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
00b9h pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
00beh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
00c1h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
00c5h vpinsrw xmm2,xmm2,edx,2       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,2h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 02
00cah vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
00d0h mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
00d5h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
00dah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00ddh vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
00e3h vpinsrw xmm2,xmm2,eax,2       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,2h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 02
00e8h vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
00eeh mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
00f3h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00f7h vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
00fbh vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
00ffh mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
0104h pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
0109h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
010ch vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0110h vpinsrw xmm2,xmm2,edx,3       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,3h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 03
0115h vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
011bh mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
0120h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0125h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0128h vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
012eh vpinsrw xmm2,xmm2,eax,3       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,3h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 03
0133h vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
0139h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
013eh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0142h vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
0146h vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
014ah mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
014fh pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
0154h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0157h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
015bh vpinsrw xmm2,xmm2,edx,4       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,4h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 04
0160h vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
0166h mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
016bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0170h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0173h vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
0179h vpinsrw xmm2,xmm2,eax,4       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,4h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 04
017eh vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
0184h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0189h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
018dh vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
0191h vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
0195h mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
019ah pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
019fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
01a2h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
01a6h vpinsrw xmm2,xmm2,edx,5       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,5h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 05
01abh vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
01b1h mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
01b6h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
01bbh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
01beh vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
01c4h vpinsrw xmm2,xmm2,eax,5       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,5h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 05
01c9h vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
01cfh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
01d4h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
01d8h vpsllq ymm2,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM2,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 d2
01dch vpmovmskb eax,ymm2            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM2]          encoding(VEX, 4 bytes) = c5 fd d7 c2
01e0h mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
01e5h pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
01eah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
01edh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
01f1h vpinsrw xmm2,xmm2,edx,6       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EDX,6h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d2 06
01f6h vinsertf128 ymm0,ymm0,xmm2,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 00
01fch mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
0201h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0206h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0209h vextractf128 xmm2,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 01
020fh vpinsrw xmm2,xmm2,eax,6       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM2,XMM2,EAX,6h:imm8] encoding(VEX, 5 bytes) = c5 e9 c4 d0 06
0214h vinsertf128 ymm0,ymm0,xmm2,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c2 01
021ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
021ch vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0220h vpsllq ymm1,ymm1,xmm2         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f3 ca
0224h vpmovmskb eax,ymm1            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM1]          encoding(VEX, 4 bytes) = c5 fd d7 c1
0228h mov edx,55555555h             ; MOV(Mov_r32_imm32) [EDX,55555555h:imm32]             encoding(5 bytes) = ba 55 55 55 55
022dh pext edx,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 d2
0232h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0235h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0239h vpinsrw xmm1,xmm1,edx,7       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM1,XMM1,EDX,7h:imm8] encoding(VEX, 5 bytes) = c5 f1 c4 ca 07
023eh vinsertf128 ymm0,ymm0,xmm1,0  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 00
0244h mov edx,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EDX,aaaaaaaah:imm32]             encoding(5 bytes) = ba aa aa aa aa
0249h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
024eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0251h vextractf128 xmm1,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c1 01
0257h vpinsrw xmm1,xmm1,eax,7       ; VPINSRW(VEX_Vpinsrw_xmm_xmm_r32m16_imm8) [XMM1,XMM1,EAX,7h:imm8] encoding(VEX, 5 bytes) = c5 f1 c4 c8 07
025ch vinsertf128 ymm0,ymm0,xmm1,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 18 c1 01
0262h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0266h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0269h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
026ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> transposeBytes => new byte[621]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x10,0x0A,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x00,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x00,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0xB8,0x06,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x01,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x01,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0xB8,0x05,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x02,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x02,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x03,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x03,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0xB8,0x03,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x04,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x04,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x05,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x05,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xD2,0xC5,0xFD,0xD7,0xC2,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xD0,0xC5,0xE9,0xC4,0xD2,0x06,0xC4,0xE3,0x7D,0x18,0xC2,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC2,0x01,0xC5,0xE9,0xC4,0xD0,0x06,0xC4,0xE3,0x7D,0x18,0xC2,0x01,0x33,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xF3,0xCA,0xC5,0xFD,0xD7,0xC1,0xBA,0x55,0x55,0x55,0x55,0xC4,0xE2,0x7A,0xF5,0xD2,0x0F,0xB7,0xD2,0xC5,0xFC,0x28,0xC8,0xC5,0xF1,0xC4,0xCA,0x07,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xBA,0xAA,0xAA,0xAA,0xAA,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC4,0xE3,0x7D,0x19,0xC1,0x01,0xC5,0xF1,0xC4,0xC8,0x07,0xC4,0xE3,0x7D,0x18,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_vector(in BitSpan<N23,byte> src)
; location: [7FF7C6A521F0h, 7FF7C6A52206h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test al,8                     ; TEST(Test_AL_imm8) [AL,8h:imm8]                      encoding(2 bytes) = a8 08
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_vectorBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0xA8,0x08,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int segments()
; location: [7FF7C6A52620h, 7FF7C6A5264Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov byte ptr [rsp+10h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 10 00
000ah lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
000fh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0012h mov byte ptr [rsp+8],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 08 00
0017h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001ch mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
001fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0024h add eax,2                     ; ADD(Add_rm32_imm8) [EAX,2h:imm32]                    encoding(3 bytes) = 83 c0 02
0027h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0029h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
002bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentsBytes => new byte[48]{0x48,0x83,0xEC,0x18,0x90,0xC6,0x44,0x24,0x10,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0xC6,0x44,0x24,0x08,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x83,0xC0,0x02,0x33,0xD2,0x03,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int count_segs()
; location: [7FF7C6A52670h, 7FF7C6A526C2h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0022h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
0025h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0027h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
002ah and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
002dh add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
002fh sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0032h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0034h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0037h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
003ah add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
003ch and ecx,0FFFFFFFCh            ; AND(And_rm32_imm8) [ECX,fffffffffffffffch:imm32]     encoding(3 bytes) = 83 e1 fc
003fh sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
0041h jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 04
0043h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0045h jmp short 004ch               ; JMP(Jmp_rel8_64) [4Ch:jmp64]                         encoding(2 bytes) = eb 05
0047h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
004ch add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
004eh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> count_segsBytes => new byte[83]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x03,0x03,0xC8,0x83,0xE1,0xFC,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col_2(int n, ulong src, int row, int col)
; location: [7FF7C6A526E0h, 7FF7C6A52726h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
000ah imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
000eh add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
0011h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0013h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0016h and eax,3Fh                   ; AND(And_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 e0 3f
0019h add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
001bh sar eax,6                     ; SAR(Sar_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 f8 06
001eh lea rdx,[rsp+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 10
0023h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0026h mov rax,[rdx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 04 c2
002ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
002ch sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
002fh and edx,3Fh                   ; AND(And_rm32_imm8) [EDX,3fh:imm32]                   encoding(3 bytes) = 83 e2 3f
0032h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0034h and edx,0FFFFFFC0h            ; AND(And_rm32_imm8) [EDX,ffffffffffffffc0h:imm32]     encoding(3 bytes) = 83 e2 c0
0037h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0039h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
003ch bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0040h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0043h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_row_col_2Bytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x41,0x0F,0xAF,0xC8,0x41,0x03,0xC9,0x8B,0xC1,0xC1,0xF8,0x1F,0x83,0xE0,0x3F,0x03,0xC1,0xC1,0xF8,0x06,0x48,0x8D,0x54,0x24,0x10,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC2,0x8B,0xD1,0xC1,0xFA,0x1F,0x83,0xE2,0x3F,0x03,0xD1,0x83,0xE2,0xC0,0x2B,0xCA,0x0F,0xB6,0xD1,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_g_position(in ulong src, int pos)
; location: [7FF7C6A52740h, 7FF7C6A52775h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
000ah and eax,3Fh                   ; AND(And_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 e0 3f
000dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000fh sar eax,6                     ; SAR(Sar_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 f8 06
0012h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0015h mov rax,[rcx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 04 c1
0019h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
001bh sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
001eh and ecx,3Fh                   ; AND(And_rm32_imm8) [ECX,3fh:imm32]                   encoding(3 bytes) = 83 e1 3f
0021h add ecx,edx                   ; ADD(Add_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 03 ca
0023h and ecx,0FFFFFFC0h            ; AND(And_rm32_imm8) [ECX,ffffffffffffffc0h:imm32]     encoding(3 bytes) = 83 e1 c0
0026h sub edx,ecx                   ; SUB(Sub_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 2b d1
0028h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002bh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
002fh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0032h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_g_positionBytes => new byte[54]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC1,0xF8,0x1F,0x83,0xE0,0x3F,0x03,0xC2,0xC1,0xF8,0x06,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC1,0x8B,0xCA,0xC1,0xF9,0x1F,0x83,0xE1,0x3F,0x03,0xCA,0x83,0xE1,0xC0,0x2B,0xD1,0x0F,0xB6,0xD2,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
