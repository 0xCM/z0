; 2020-01-16 19:14:10:563
; function: VectorKind:uint vkind_128x32u()
; static ReadOnlySpan<byte> vkind_128x32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0x00,0x10,0x20,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20100080h                       ; MOV(Mov_r32_imm32) [EAX,20100080h:imm32]   encoding(5 bytes) = b8 80 00 10 20
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: VectorKind:uint vkind_256x32u()
; static ReadOnlySpan<byte> vkind_256x32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x10,0x20,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20100100h                       ; MOV(Mov_r32_imm32) [EAX,20100100h:imm32]   encoding(5 bytes) = b8 00 01 10 20
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BlockKind:uint bkind_256x32u()
; static ReadOnlySpan<byte> bkind_256x32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x10,0x20,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20100100h                       ; MOV(Mov_r32_imm32) [EAX,20100100h:imm32]   encoding(5 bytes) = b8 00 01 10 20
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PrimalKind:uint pkind_8u()
; static ReadOnlySpan<byte> pkind_8uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x01,0x20,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20010008h                       ; MOV(Mov_r32_imm32) [EAX,20010008h:imm32]   encoding(5 bytes) = b8 08 00 01 20
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PrimalKind:uint pkind_32u()
; static ReadOnlySpan<byte> pkind_32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x10,0x20,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20100020h                       ; MOV(Mov_r32_imm32) [EAX,20100020h:imm32]   encoding(5 bytes) = b8 20 00 10 20
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: PrimalKind:uint pkind_32i()
; static ReadOnlySpan<byte> pkind_32iBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x20,0x80,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,80200020h                       ; MOV(Mov_r32_imm32) [EAX,80200020h:imm32]   encoding(5 bytes) = b8 20 00 20 80
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> ones_128x8u()
; static ReadOnlySpan<byte> ones_128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqb xmm0,xmm0,xmm1                 ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0011h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> ones_128x64u()
; static ReadOnlySpan<byte> ones_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqq xmm0,xmm0,xmm1                 ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0012h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> ones_256x8u()
; static ReadOnlySpan<byte> ones_256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0] encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1] encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqb ymm0,ymm0,ymm1                 ; VPCMPEQB(VEX_Vpcmpeqb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 74 c1
0011h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0015h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0018h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> ones_256x64u()
; static ReadOnlySpan<byte> ones_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0] encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1] encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqq ymm0,ymm0,ymm1                 ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> ones_256x64f()
; static ReadOnlySpan<byte> ones_256x64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0xC2,0xC1,0x08,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0] encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1] encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vcmpeq_uqpd ymm0,ymm0,ymm1              ; VCMPPD(VEX_Vcmppd_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,8h:imm8] encoding(VEX, 5 bytes) = c5 fd c2 c1 08
0012h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> pattern_lanemerge_256x8u()
; static ReadOnlySpan<byte> pattern_lanemerge_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xBD,0x92,0x77,0xC6,0x2A,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,12AC67792BDh                    ; MOV(Mov_r64_imm64) [RAX,12ac67792bdh:imm64] encoding(10 bytes) = 48 b8 bd 92 77 c6 2a 01 00 00
000fh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0013h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> pattern_lanemerge_256x16u()
; static ReadOnlySpan<byte> pattern_lanemerge_256x16uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0x8D,0x94,0x77,0xC6,0x2A,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov rax,12AC677948Dh                    ; MOV(Mov_r64_imm64) [RAX,12ac677948dh:imm64] encoding(10 bytes) = 48 b8 8d 94 77 c6 2a 01 00 00
000fh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0013h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> makemask_d128x8u(ushort src)
; static ReadOnlySpan<byte> makemask_d128x8uBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h movzx edx,al                            ; MOVZX(Movzx_r32_rm8) [EDX,AL]              encoding(3 bytes) = 0f b6 d0
000bh mov r8,8080808080808080h                ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64] encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0015h pdep rdx,rdx,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]   encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
001ah vmovq xmm0,rdx                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
001fh shr eax,8                               ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]           encoding(3 bytes) = c1 e8 08
0022h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0025h pdep rax,rax,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
002ah vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0030h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0034h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> makemask_d256x8u(uint src)
; static ReadOnlySpan<byte> makemask_d256x8uBytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x44,0x0F,0xB6,0xC0,0x49,0xB9,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0x42,0xBB,0xF5,0xC1,0xC4,0xC1,0xF9,0x6E,0xC0,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC1,0xEA,0x10,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0xC4,0xC2,0xEB,0xF5,0xD1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h movzx r8d,al                            ; MOVZX(Movzx_r32_rm8) [R8D,AL]              encoding(4 bytes) = 44 0f b6 c0
000ch mov r9,8080808080808080h                ; MOV(Mov_r64_imm64) [R9,8080808080808080h:imm64] encoding(10 bytes) = 49 b9 80 80 80 80 80 80 80 80
0016h pdep r8,r8,r9                           ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]     encoding(VEX, 5 bytes) = c4 42 bb f5 c1
001bh vmovq xmm0,r8                           ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]        encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
0020h shr eax,8                               ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]           encoding(3 bytes) = c1 e8 08
0023h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0026h pdep rax,rax,r9                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
002bh vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0031h shr edx,10h                             ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]          encoding(3 bytes) = c1 ea 10
0034h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0037h movzx edx,al                            ; MOVZX(Movzx_r32_rm8) [EDX,AL]              encoding(3 bytes) = 0f b6 d0
003ah pdep rdx,rdx,r9                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]   encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
003fh vmovq xmm1,rdx                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
0044h shr eax,8                               ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]           encoding(3 bytes) = c1 e8 08
0047h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
004ah pdep rax,rax,r9                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
004fh vpinsrq xmm1,xmm1,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 c8 01
0055h vxorps ymm2,ymm2,ymm2                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ec 57 d2
0059h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
005fh vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0065h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0069h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
006ch vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
006fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> maskmask_d128x8u_index4(ushort src)
; static ReadOnlySpan<byte> maskmask_d128x8u_index4Bytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dx                            ; MOVZX(Movzx_r32_rm16) [EAX,DX]             encoding(3 bytes) = 0f b7 c2
0008h movzx edx,al                            ; MOVZX(Movzx_r32_rm8) [EDX,AL]              encoding(3 bytes) = 0f b6 d0
000bh mov r8,1010101010101010h                ; MOV(Mov_r64_imm64) [R8,1010101010101010h:imm64] encoding(10 bytes) = 49 b8 10 10 10 10 10 10 10 10
0015h pdep rdx,rdx,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]   encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
001ah vmovq xmm0,rdx                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
001fh shr eax,8                               ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]           encoding(3 bytes) = c1 e8 08
0022h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0025h pdep rax,rax,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
002ah vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0030h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0034h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> maskmask_d256x8u_index3(uint src)
; static ReadOnlySpan<byte> maskmask_d256x8u_index3Bytes => new byte[109]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0x49,0xB8,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC0,0x8B,0xC2,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0x8B,0xC2,0xC1,0xE8,0x10,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC8,0xC1,0xEA,0x18,0x0F,0xB6,0xC2,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h mov r8,808080808080808h                 ; MOV(Mov_r64_imm64) [R8,808080808080808h:imm64] encoding(10 bytes) = 49 b8 08 08 08 08 08 08 08 08
0012h pdep rax,rax,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0017h vmovq xmm0,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
001ch mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
001eh shr eax,8                               ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]           encoding(3 bytes) = c1 e8 08
0021h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0024h pdep rax,rax,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0029h vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
002fh mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0031h shr eax,10h                             ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]          encoding(3 bytes) = c1 e8 10
0034h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0037h pdep rax,rax,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
003ch vmovq xmm1,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0041h shr edx,18h                             ; SHR(Shr_rm32_imm8) [EDX,18h:imm8]          encoding(3 bytes) = c1 ea 18
0044h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0047h pdep rax,rax,r8                         ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]   encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
004ch vpinsrq xmm1,xmm1,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 c8 01
0052h vxorps ymm2,ymm2,ymm2                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ec 57 d2
0056h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
005ch vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0062h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0066h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0069h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
006ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> makemask_d128x8u_FCFC()
; static ReadOnlySpan<byte> makemask_d128x8u_FCFCBytes => new byte[54]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0xFC,0x00,0x00,0x00,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE1,0xF9,0x6E,0xC0,0xB8,0xFC,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov eax,0FCh                            ; MOV(Mov_r32_imm32) [EAX,fch:imm32]         encoding(5 bytes) = b8 fc 00 00 00
000ah mov rdx,8080808080808080h               ; MOV(Mov_r64_imm64) [RDX,8080808080808080h:imm64] encoding(10 bytes) = 48 ba 80 80 80 80 80 80 80 80
0014h pdep rax,rax,rdx                        ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]  encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0019h vmovq xmm0,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
001eh mov eax,0FCh                            ; MOV(Mov_r32_imm32) [EAX,fch:imm32]         encoding(5 bytes) = b8 fc 00 00 00
0023h pdep rax,rax,rdx                        ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]  encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0028h vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
002eh vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0035h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> makemask_d256x8u_FAFAFAFA()
; static ReadOnlySpan<byte> makemask_d256x8u_FAFAFAFABytes => new byte[104]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0xFA,0x00,0x00,0x00,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE1,0xF9,0x6E,0xC0,0xB8,0xFA,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xB8,0xFA,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE1,0xF9,0x6E,0xC8,0xB8,0xFA,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h mov eax,0FAh                            ; MOV(Mov_r32_imm32) [EAX,fah:imm32]         encoding(5 bytes) = b8 fa 00 00 00
000ah mov rdx,8080808080808080h               ; MOV(Mov_r64_imm64) [RDX,8080808080808080h:imm64] encoding(10 bytes) = 48 ba 80 80 80 80 80 80 80 80
0014h pdep rax,rax,rdx                        ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]  encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0019h vmovq xmm0,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
001eh mov eax,0FAh                            ; MOV(Mov_r32_imm32) [EAX,fah:imm32]         encoding(5 bytes) = b8 fa 00 00 00
0023h pdep rax,rax,rdx                        ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]  encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0028h vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
002eh mov eax,0FAh                            ; MOV(Mov_r32_imm32) [EAX,fah:imm32]         encoding(5 bytes) = b8 fa 00 00 00
0033h pdep rax,rax,rdx                        ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]  encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0038h vmovq xmm1,rax                          ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]       encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
003dh mov eax,0FAh                            ; MOV(Mov_r32_imm32) [EAX,fah:imm32]         encoding(5 bytes) = b8 fa 00 00 00
0042h pdep rax,rax,rdx                        ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]  encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0047h vpinsrq xmm1,xmm1,rax,1                 ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 c8 01
004dh vxorps ymm2,ymm2,ymm2                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2] encoding(VEX, 4 bytes) = c5 ec 57 d2
0051h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0057h vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
005dh vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0061h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0064h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0067h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
