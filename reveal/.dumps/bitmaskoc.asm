; 2019-12-10 01:42:50:624
; function: Vector128<byte> makemask_128x8u(BitVector16 src)
; location: [7FFDD8E5CE90h, 7FFDD8E5CEC7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
000bh mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0015h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
001ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0025h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
002ah vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0030h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_128x8uBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> makemask_128x8u_literal()
; location: [7FFDD8E5CEE0h, 7FFDD8E5CF1Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,0FCh                  ; MOV(Mov_r32_imm32) [EAX,fch:imm32]                   encoding(5 bytes) = b8 fc 00 00 00
000ah mov rdx,8080808080808080h     ; MOV(Mov_r64_imm64) [RDX,8080808080808080h:imm64]     encoding(10 bytes) = 48 ba 80 80 80 80 80 80 80 80
0014h pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0019h mov edx,0FCh                  ; MOV(Mov_r32_imm32) [EDX,fch:imm32]                   encoding(5 bytes) = ba fc 00 00 00
001eh mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0028h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
002dh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0032h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0038h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
003ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_128x8u_literalBytes => new byte[64]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0xFC,0x00,0x00,0x00,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0xBA,0xFC,0x00,0x00,0x00,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> makemask_256x8u(BitVector32 src)
; location: [7FFDD8E5CF40h, 7FFDD8E5CFAFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx r8d,al                  ; MOVZX(Movzx_r32_rm8) [R8D,AL]                        encoding(4 bytes) = 44 0f b6 c0
000ch mov r9,8080808080808080h      ; MOV(Mov_r64_imm64) [R9,8080808080808080h:imm64]      encoding(10 bytes) = 49 b9 80 80 80 80 80 80 80 80
0016h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
001bh sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
0026h vmovq xmm0,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
002bh vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0031h shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0034h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0037h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
003ah pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
003fh sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
0042h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0045h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
004ah vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
004fh vpinsrq xmm1,xmm1,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 c8 01
0055h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0059h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
005fh vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0065h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0069h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
006ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_256x8uBytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x44,0x0F,0xB6,0xC0,0x49,0xB9,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0x42,0xBB,0xF5,0xC1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xC1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC1,0xEA,0x10,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0xC4,0xC2,0xEB,0xF5,0xD1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> makemask_256x8u_literal()
; location: [7FFDD8E5CFD0h, 7FFDD8E5D041h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov eax,0C0h                  ; MOV(Mov_r32_imm32) [EAX,c0h:imm32]                   encoding(5 bytes) = b8 c0 00 00 00
000ah mov rdx,8080808080808080h     ; MOV(Mov_r64_imm64) [RDX,8080808080808080h:imm64]     encoding(10 bytes) = 48 ba 80 80 80 80 80 80 80 80
0014h pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0019h mov edx,0F0h                  ; MOV(Mov_r32_imm32) [EDX,f0h:imm32]                   encoding(5 bytes) = ba f0 00 00 00
001eh mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0028h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
002dh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0032h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0038h mov eax,0F0h                  ; MOV(Mov_r32_imm32) [EAX,f0h:imm32]                   encoding(5 bytes) = b8 f0 00 00 00
003dh pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0042h mov edx,0F0h                  ; MOV(Mov_r32_imm32) [EDX,f0h:imm32]                   encoding(5 bytes) = ba f0 00 00 00
0047h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
004ch vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0051h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
0057h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
005bh vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0061h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0067h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
006bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
006eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_256x8u_literalBytes => new byte[114]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0xC0,0x00,0x00,0x00,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0xBA,0xF0,0x00,0x00,0x00,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0xB8,0xF0,0x00,0x00,0x00,0xC4,0xC2,0xFB,0xF5,0xC0,0xBA,0xF0,0x00,0x00,0x00,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> makemask_g128x8u(BitVector16 src)
; location: [7FFDD8E5D060h, 7FFDD8E5D097h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
000bh mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0015h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
001ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0025h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
002ah vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0030h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_g128x8uBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> makemask_g128x16u(BitVector16 src)
; location: [7FFDD8E5D0B0h, 7FFDD8E5D0E7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
000bh mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0015h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
001ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0025h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
002ah vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0030h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_g128x16uBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> makemask_g256x32u(BitVector32 src)
; location: [7FFDD8E5D510h, 7FFDD8E5D57Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx r8d,al                  ; MOVZX(Movzx_r32_rm8) [R8D,AL]                        encoding(4 bytes) = 44 0f b6 c0
000ch mov r9,8080808080808080h      ; MOV(Mov_r64_imm64) [R9,8080808080808080h:imm64]      encoding(10 bytes) = 49 b9 80 80 80 80 80 80 80 80
0016h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
001bh sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
0026h vmovq xmm0,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
002bh vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0031h shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0034h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0037h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
003ah pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
003fh sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
0042h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0045h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
004ah vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
004fh vpinsrq xmm1,xmm1,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 c8 01
0055h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0059h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
005fh vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0065h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0069h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
006ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_g256x32uBytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x44,0x0F,0xB6,0xC0,0x49,0xB9,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0x42,0xBB,0xF5,0xC1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xC1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC1,0xEA,0x10,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0xC4,0xC2,0xEB,0xF5,0xD1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
