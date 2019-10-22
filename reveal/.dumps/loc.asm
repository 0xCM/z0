; 2019-10-21 17:21:44:215
; function: Vector256<ulong> f18_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B6FB10h, 7FFDD9B6FB3Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0017h vpxor ymm1,ymm3,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]    encoding(VEX, 4 bytes) = c5 e5 ef c9
001bh vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
001fh vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
0023h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_256x64uBytes => new byte[46]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFC,0x28,0xD8,0xC5,0xE5,0xEF,0xC9,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f19_bit(bit a, bit b, bit c)
; location: [7FFDD9B6FB60h, 7FFDD9B6FB71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
000ah and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
000dh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x41,0x33,0xC0,0x41,0x23,0xD0,0x23,0xD1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f19_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B6FF90h, 7FFDD9B6FFA7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0011h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0014h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x33,0xC0,0x49,0x23,0xD0,0x48,0x23,0xD1,0x48,0x33,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f19_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B703C0h, 7FFDD9B703F2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0017h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
001bh vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
001fh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0023h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0027h vpxor xmm0,xmm3,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM3,XMM0]    encoding(VEX, 4 bytes) = c5 e1 ef c0
002bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_128x64uBytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF8,0x28,0xD9,0xC5,0xF8,0x28,0xE2,0xC5,0xE1,0xEF,0xDC,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC1,0xC5,0xE1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f19_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B70410h, 7FFDD9B70445h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0017h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
001bh vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
001fh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0023h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0027h vpxor ymm0,ymm3,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0]    encoding(VEX, 4 bytes) = c5 e5 ef c0
002bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0032h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_256x64uBytes => new byte[54]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFC,0x28,0xD9,0xC5,0xFC,0x28,0xE2,0xC5,0xE5,0xEF,0xDC,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0xDB,0xC1,0xC5,0xE5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1a_bit(bit a, bit b, bit c)
; location: [7FFDD9B70460h, 7FFDD9B70473h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000ah and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x41,0x33,0xC8,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1a_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B70490h, 7FFDD9B704A4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0011h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x33,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f1a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B704C0h, 7FFDD9B704F2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0017h vpand xmm1,xmm3,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM3,XMM1]    encoding(VEX, 4 bytes) = c5 e1 db c9
001bh vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
001fh vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
0023h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0027h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
002bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_128x64uBytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF8,0x28,0xD8,0xC5,0xE1,0xDB,0xC9,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f1a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B70510h, 7FFDD9B70546h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0017h vpand ymm1,ymm3,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]    encoding(VEX, 4 bytes) = c5 e5 db c9
001bh vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
001fh vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
0023h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0028h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
002ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0030h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0033h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_256x64uBytes => new byte[55]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFC,0x28,0xD8,0xC5,0xE5,0xDB,0xC9,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xDB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f1b_bit(bit a, bit b, bit c)
; location: [7FFDD9B70560h, 7FFDD9B70580h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000eh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0011h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0014h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0017h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0019h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
001bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_bitBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x23,0xC0,0x41,0x8B,0xC8,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1b_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B705A0h, 7FFDD9B705BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0014h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0017h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_64uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f1b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B709E0h, 7FFDD9B70A22h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0017h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
001bh vpcmpeqd xmm3,xmm1,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f1 76 d9
001fh vpxor xmm1,xmm1,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 ef cb
0023h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0027h vpand xmm0,xmm3,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM3,XMM0]    encoding(VEX, 4 bytes) = c5 e1 db c0
002bh vpcmpeqd xmm3,xmm2,xmm2       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM2,XMM2] encoding(VEX, 4 bytes) = c5 e9 76 da
002fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0033h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0037h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
003bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
003fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_128x64uBytes => new byte[67]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF1,0x76,0xD9,0xC5,0xF1,0xEF,0xCB,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0xDB,0xC0,0xC5,0xE9,0x76,0xDA,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f1b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B70A40h, 7FFDD9B70A88h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0018h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
001ch vpcmpeqq ymm3,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d9
0021h vpxor ymm1,ymm1,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 ef cb
0025h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0029h vpand ymm0,ymm3,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0]    encoding(VEX, 4 bytes) = c5 e5 db c0
002dh vpcmpeqq ymm3,ymm2,ymm2       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM2,YMM2] encoding(VEX, 5 bytes) = c4 e2 6d 29 da
0032h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0036h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
003ah vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
003eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0042h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0045h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0048h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_256x64uBytes => new byte[73]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC4,0xE2,0x75,0x29,0xD9,0xC5,0xF5,0xEF,0xCB,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0xDB,0xC0,0xC4,0xE2,0x6D,0x29,0xDA,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1c_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B70AB0h, 7FFDD9B70AC4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and r8,rcx                    ; AND(And_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 23 c1
0008h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1c_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x23,0xC1,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1d(ulong a, ulong b, ulong c)
; location: [7FFDD9B70AE0h, 7FFDD9B70AFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
000eh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0017h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1dBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xC2,0x48,0xF7,0xD2,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1e(ulong a, ulong b, ulong c)
; location: [7FFDD9B70B10h, 7FFDD9B70B1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1eBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1f(ulong a, ulong b, ulong c)
; location: [7FFDD9B70B30h, 7FFDD9B70B41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1fBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f20(ulong a, ulong b, ulong c)
; location: [7FFDD9B70B60h, 7FFDD9B70B71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f20Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f21(ulong a, ulong b, ulong c)
; location: [7FFDD9B70B90h, 7FFDD9B70BA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f21Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f22(ulong a, ulong b, ulong c)
; location: [7FFDD9B70FC0h, 7FFDD9B70FCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,r8               ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 e8 f2 c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f22Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xC2,0xE8,0xF2,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f23(ulong a, ulong b, ulong c)
; location: [7FFDD9B70FE0h, 7FFDD9B70FF7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f23Bytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x8B,0xD1,0x48,0xF7,0xD2,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f24(ulong a, ulong b, ulong c)
; location: [7FFDD9B71010h, 7FFDD9B71021h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,rdx                   ; XOR(Xor_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 33 ca
0008h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f24Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xCA,0x49,0x33,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f25(ulong a, ulong b, ulong c)
; location: [7FFDD9B71040h, 7FFDD9B7105Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh mov rdx,r8                    ; MOV(Mov_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 8b d0
0011h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0014h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0017h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f25Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x8B,0xD0,0x48,0xF7,0xD2,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f26(ulong a, ulong b, ulong c)
; location: [7FFDD9B71070h, 7FFDD9B71084h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,rdx                   ; AND(And_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 23 ca
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f26Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xCA,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f27(ulong a, ulong b, ulong c)
; location: [7FFDD9B710A0h, 7FFDD9B710C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0014h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0017h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
001ah and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f27Bytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x8B,0xD1,0x48,0xF7,0xD2,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f28(ulong a, ulong b, ulong c)
; location: [7FFDD9B710E0h, 7FFDD9B710EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f28Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f29(ulong a, ulong b, ulong c)
; location: [7FFDD9B71100h, 7FFDD9B71120h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
000bh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0014h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0017h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
001ah and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f29Bytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x33,0xC1,0x48,0x0B,0xD1,0x48,0xF7,0xD2,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2a(ulong a, ulong b, ulong c)
; location: [7FFDD9B71140h, 7FFDD9B71151h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2aBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2b(ulong a, ulong b, ulong c)
; location: [7FFDD9B71170h, 7FFDD9B71193h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0011h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0014h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0017h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
001ah not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
001dh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0020h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2bBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x23,0xC1,0x48,0xF7,0xD0,0x48,0x0B,0xD1,0x48,0xF7,0xD2,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2c(ulong a, ulong b, ulong c)
; location: [7FFDD9B711B0h, 7FFDD9B711C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8,rdx                     ; OR(Or_r64_rm64) [R8,RDX]                             encoding(3 bytes) = 4c 0b c2
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2cBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x0B,0xC2,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2d(ulong a, ulong b, ulong c)
; location: [7FFDD9B711E0h, 7FFDD9B711F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000eh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2dBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x0B,0xC2,0x48,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2e(ulong a, ulong b, ulong c)
; location: [7FFDD9B71210h, 7FFDD9B71221h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8,rdx                     ; OR(Or_r64_rm64) [R8,RDX]                             encoding(3 bytes) = 4c 0b c2
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2eBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x0B,0xC2,0x48,0x23,0xD1,0x49,0x33,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2f(ulong a, ulong b, ulong c)
; location: [7FFDD9B71240h, 7FFDD9B71254h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
000eh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2fBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x49,0x23,0xD0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f30(ulong a, ulong b, ulong c)
; location: [7FFDD9B71270h, 7FFDD9B7127Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,rcx              ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 e8 f2 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f30Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xE8,0xF2,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f31(ulong a, ulong b, ulong c)
; location: [7FFDD9B71290h, 7FFDD9B712A7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rdx,r8                    ; MOV(Mov_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 8b d0
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f31Bytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x8B,0xD0,0x48,0xF7,0xD2,0x48,0x0B,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f32(ulong a, ulong b, ulong c)
; location: [7FFDD9B716C0h, 7FFDD9B716D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f32Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x0B,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f33(ulong a, ulong b, ulong c)
; location: [7FFDD9B716F0h, 7FFDD9B716FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f33Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f34(ulong a, ulong b, ulong c)
; location: [7FFDD9B71710h, 7FFDD9B71724h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and r8,rdx                    ; AND(And_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 23 c2
0008h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f34Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x23,0xC2,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f35(ulong a, ulong b, ulong c)
; location: [7FFDD9B71740h, 7FFDD9B7175Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rdx,r8                    ; MOV(Mov_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 8b d0
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0014h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0017h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f35Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x8B,0xD0,0x48,0xF7,0xD2,0x48,0x23,0xC1,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f36(ulong a, ulong b, ulong c)
; location: [7FFDD9B71770h, 7FFDD9B7177Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f36Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f37(ulong a, ulong b, ulong c)
; location: [7FFDD9B71790h, 7FFDD9B717A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f37Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f38(ulong a, ulong b, ulong c)
; location: [7FFDD9B717C0h, 7FFDD9B717D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8,rcx                     ; OR(Or_r64_rm64) [R8,RCX]                             encoding(3 bytes) = 4c 0b c1
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f38Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x0B,0xC1,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f39(ulong a, ulong b, ulong c)
; location: [7FFDD9B717F0h, 7FFDD9B71801h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
000eh xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f39Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x0B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3a(ulong a, ulong b, ulong c)
; location: [7FFDD9B71820h, 7FFDD9B7183Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
000eh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0011h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0014h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0017h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3aBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0x48,0x8B,0xD1,0x48,0xF7,0xD2,0x49,0x23,0xD0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3b(ulong a, ulong b, ulong c)
; location: [7FFDD9B71850h, 7FFDD9B71864h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3bBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0x48,0xF7,0xD2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3c(ulong a, ulong b, ulong c)
; location: [7FFDD9B71880h, 7FFDD9B7188Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3cBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3d(ulong a, ulong b, ulong c)
; location: [7FFDD9B718A0h, 7FFDD9B718B4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3dBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3e(ulong a, ulong b, ulong c)
; location: [7FFDD9B718D0h, 7FFDD9B718E4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000eh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3eBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0x48,0x33,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3f(ulong a, ulong b, ulong c)
; location: [7FFDD9B71900h, 7FFDD9B7190Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3fBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f40(ulong a, ulong b, ulong c)
; location: [7FFDD9B71920h, 7FFDD9B71931h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f40Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x23,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f41(ulong a, ulong b, ulong c)
; location: [7FFDD9B71950h, 7FFDD9B71961h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f41Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f42(ulong a, ulong b, ulong c)
; location: [7FFDD9B71980h, 7FFDD9B71991h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f42Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x49,0x33,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f43(ulong a, ulong b, ulong c)
; location: [7FFDD9B719B0h, 7FFDD9B719C7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and r8,rcx                    ; AND(And_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 23 c1
0008h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0011h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f43Bytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x23,0xC1,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f44(ulong a, ulong b, ulong c)
; location: [7FFDD9B719E0h, 7FFDD9B719EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,r8,rdx               ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,R8,RDX]             encoding(VEX, 5 bytes) = c4 e2 b8 f2 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f44Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xB8,0xF2,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f45(ulong a, ulong b, ulong c)
; location: [7FFDD9B71E10h, 7FFDD9B71E24h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
000eh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f45Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f46(ulong a, ulong b, ulong c)
; location: [7FFDD9B71E40h, 7FFDD9B71E54h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f46Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f47(ulong a, ulong b, ulong c)
; location: [7FFDD9B71E70h, 7FFDD9B71E8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0014h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0017h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f47Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0xF7,0xD1,0x48,0x23,0xC2,0x48,0xF7,0xD2,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f48(ulong a, ulong b, ulong c)
; location: [7FFDD9B71EA0h, 7FFDD9B71EAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f48Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f49(ulong a, ulong b, ulong c)
; location: [7FFDD9B71EC0h, 7FFDD9B71EDDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
000bh or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
000eh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0017h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f49Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x49,0x33,0xC0,0x49,0x0B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xC2,0x48,0xF7,0xD2,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4a(ulong a, ulong b, ulong c)
; location: [7FFDD9B71EF0h, 7FFDD9B71F01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4aBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4b(ulong a, ulong b, ulong c)
; location: [7FFDD9B71F20h, 7FFDD9B71F31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
000eh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4bBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x0B,0xC0,0x48,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4c(ulong a, ulong b, ulong c)
; location: [7FFDD9B71F50h, 7FFDD9B71F61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4cBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4d(ulong a, ulong b, ulong c)
; location: [7FFDD9B71F80h, 7FFDD9B71FA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0011h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
001ah and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4dBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x49,0x23,0xC0,0x48,0xF7,0xD0,0x49,0x0B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xC2,0x48,0xF7,0xD2,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4e(ulong a, ulong b, ulong c)
; location: [7FFDD9B71FC0h, 7FFDD9B71FDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000eh mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0011h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0014h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0017h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4eBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4f(ulong a, ulong b, ulong c)
; location: [7FFDD9B71FF0h, 7FFDD9B72003h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh andn rdx,r8,rdx               ; ANDN(VEX_Andn_r64_r64_rm64) [RDX,R8,RDX]             encoding(VEX, 5 bytes) = c4 e2 b8 f2 d2
0010h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4fBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC4,0xE2,0xB8,0xF2,0xD2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f97_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B72020h, 7FFDD9B72043h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0011h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0014h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0017h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
001ah not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
001dh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0020h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f97_64uBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x33,0xC0,0x48,0xF7,0xD0,0x49,0x23,0xD0,0x48,0xF7,0xD2,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f97_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B72060h, 7FFDD9B720B2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vmovupd xmm1,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 09
000fh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0013h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0017h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
001bh vpcmpeqd xmm3,xmm2,xmm2       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM2,XMM2] encoding(VEX, 4 bytes) = c5 e9 76 da
001fh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0023h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0027h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
002bh vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
002fh vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
0033h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0037h vpand xmm2,xmm3,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM3,XMM2]    encoding(VEX, 4 bytes) = c5 e1 db d2
003bh vpcmpeqd xmm3,xmm1,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f1 76 d9
003fh vpxor xmm1,xmm1,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 ef cb
0043h vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
0047h vpor xmm0,xmm2,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]      encoding(VEX, 4 bytes) = c5 e9 eb c0
004bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f97_128x64uBytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0x10,0x09,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0x76,0xDA,0xC5,0xE9,0xEF,0xD3,0xC5,0xF8,0x28,0xD9,0xC5,0xF9,0xDB,0xC3,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF8,0x28,0xD9,0xC5,0xE1,0xDB,0xD2,0xC5,0xF1,0x76,0xD9,0xC5,0xF1,0xEF,0xCB,0xC5,0xF1,0xDB,0xC0,0xC5,0xE9,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f97_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B724E0h, 7FFDD9B72538h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovupd ymm1,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 09
000fh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0013h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0017h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
001bh vpcmpeqq ymm3,ymm2,ymm2       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM2,YMM2] encoding(VEX, 5 bytes) = c4 e2 6d 29 da
0020h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0024h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0028h vpand ymm0,ymm0,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd db c3
002ch vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0031h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
0035h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0039h vpand ymm2,ymm3,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]    encoding(VEX, 4 bytes) = c5 e5 db d2
003dh vpcmpeqq ymm3,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d9
0042h vpxor ymm1,ymm1,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 ef cb
0046h vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
004ah vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
004eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0052h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0055h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f97_256x64uBytes => new byte[89]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0x10,0x09,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xEF,0xD3,0xC4,0xE2,0x6D,0x29,0xDA,0xC5,0xED,0xEF,0xD3,0xC5,0xFC,0x28,0xD9,0xC5,0xFD,0xDB,0xC3,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xFC,0x28,0xD9,0xC5,0xE5,0xDB,0xD2,0xC4,0xE2,0x75,0x29,0xD9,0xC5,0xF5,0xEF,0xCB,0xC5,0xF5,0xDB,0xC0,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> zero_v128x64u()
; location: [7FFDD9B72560h, 7FFDD9B72570h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_v128x64uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> zero_v256x64u()
; location: [7FFDD9B72590h, 7FFDD9B725A3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_v256x64uBytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> one_v256x64u()
; location: [7FFDD9B725C0h, 7FFDD9B725DCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_v256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> one_v128x64u()
; location: [7FFDD9B725F0h, 7FFDD9B72609h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_v128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint composition_54(uint v1, uint v2)
; location: [7FFDD9B72620h, 7FFDD9B72633h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000fh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> composition_54Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x23,0xC2,0xF7,0xD0,0x23,0xC1,0x33,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte composition_54(byte v1, byte v2)
; location: [7FFDD9B72650h, 7FFDD9B7268Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0015h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0019h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
001ch not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
001eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0021h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0024h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0028h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
002bh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0031h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0039h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> composition_54Bytes => new byte[63]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0xF7,0xD1,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x44,0x8B,0xC2,0x45,0x0F,0xB6,0xC0,0x41,0x23,0xC8,0xF7,0xD1,0x0F,0xB6,0xC9,0x44,0x8B,0xC0,0x45,0x0F,0xB6,0xC0,0x41,0x23,0xC8,0x0F,0xB6,0xC9,0x0F,0xB6,0xC0,0x33,0xC1,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_64u(ulong a, ulong b)
; location: [7FFDD9B726A0h, 7FFDD9B726ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> and_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B726C0h, 7FFDD9B726D9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_v128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> and_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
; location: [7FFDD9B726F0h, 7FFDD9B7270Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_v256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_64u(ulong a, ulong b)
; location: [7FFDD9B72720h, 7FFDD9B7272Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> or_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B72740h, 7FFDD9B72759h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_v128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> or_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
; location: [7FFDD9B72770h, 7FFDD9B7278Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_v256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_64u(ulong a, ulong b)
; location: [7FFDD9B727A0h, 7FFDD9B727ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> xor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B727C0h, 7FFDD9B727D9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_v128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> xor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
; location: [7FFDD9B727F0h, 7FFDD9B7280Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_v256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong not_64u(ulong a)
; location: [7FFDD9B72820h, 7FFDD9B7282Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> not_v128x64u(Vector128<ulong> a)
; location: [7FFDD9B72840h, 7FFDD9B72858h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000dh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0011h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_v128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> not_v256x64u(Vector256<ulong> a)
; location: [7FFDD9B72870h, 7FFDD9B7288Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_v256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nand_64u(ulong a, ulong b)
; location: [7FFDD9B728A0h, 7FFDD9B728AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> nand_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B728C0h, 7FFDD9B728E1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0012h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0016h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_v128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> nand_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
; location: [7FFDD9B72900h, 7FFDD9B72925h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0012h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0017h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_v256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nor_64u(ulong a, ulong b)
; location: [7FFDD9B72940h, 7FFDD9B7294Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> nor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B72960h, 7FFDD9B72981h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0012h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0016h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_v128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> nor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
; location: [7FFDD9B72DA0h, 7FFDD9B72DC5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0012h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0017h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_v256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xnor_64u(ulong a, ulong b)
; location: [7FFDD9B72DE0h, 7FFDD9B72DEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> xnor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B72E00h, 7FFDD9B72E21h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0012h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0016h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_v128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> xnor_v256x64u(Vector256<ulong> a, Vector256<ulong> b)
; location: [7FFDD9B72E40h, 7FFDD9B72E65h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0017h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_v256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEF,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor1_64u(ulong a)
; location: [7FFDD9B72E80h, 7FFDD9B72E8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> xor1_v128x64u(Vector128<ulong> a)
; location: [7FFDD9B72EA0h, 7FFDD9B72EC1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0011h vpcmpeqq xmm1,xmm1,xmm2       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 29 ca
0016h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_v128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF0,0x57,0xC9,0xC5,0xE8,0x57,0xD2,0xC4,0xE2,0x71,0x29,0xCA,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> xor1_v256x64u(Vector256<ulong> a)
; location: [7FFDD9B72EE0h, 7FFDD9B72F04h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0011h vpcmpeqq ymm1,ymm1,ymm2       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 29 ca
0016h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_v256x64uBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xF4,0x57,0xC9,0xC5,0xEC,0x57,0xD2,0xC4,0xE2,0x75,0x29,0xCA,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B72F20h, 7FFDD9B72F34h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> select_v128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B72F50h, 7FFDD9B72F82h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0017h vpand xmm1,xmm3,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM3,XMM1]    encoding(VEX, 4 bytes) = c5 e1 db c9
001bh vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
001fh vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
0023h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0027h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
002bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_v128x64uBytes => new byte[51]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF8,0x28,0xD8,0xC5,0xE1,0xDB,0xC9,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> select_v256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B72FA0h, 7FFDD9B72FD6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0017h vpand ymm1,ymm3,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]    encoding(VEX, 4 bytes) = c5 e5 db c9
001bh vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0020h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
0024h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0028h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
002ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0030h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0033h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_v256x64uBytes => new byte[55]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFC,0x28,0xD8,0xC5,0xE5,0xDB,0xC9,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f01_bit(bit a, bit b, bit c)
; location: [7FFDD9B72FF0h, 7FFDD9B73001h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f01_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73020h, 7FFDD9B73031h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f01_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73050h, 7FFDD9B7307Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpor xmm1,xmm1,xmm2           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]      encoding(VEX, 4 bytes) = c5 f1 eb ca
0017h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
001bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF1,0xEB,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f01_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B730A0h, 7FFDD9B730CEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpor ymm1,ymm1,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]      encoding(VEX, 4 bytes) = c5 f5 eb ca
0017h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
001bh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0020h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xF5,0xEB,0xCA,0xC5,0xFD,0xEB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f02_bit(bit a, bit b, bit c)
; location: [7FFDD9B730F0h, 7FFDD9B73101h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000eh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f02_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73120h, 7FFDD9B73131h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f02_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73150h, 7FFDD9B7317Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0017h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001fh vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f02_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B731A0h, 7FFDD9B731CEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0017h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
001ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0020h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xF5,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f03_bit(bit a, bit b, bit c)
; location: [7FFDD9B731F0h, 7FFDD9B73203h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f03_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73220h, 7FFDD9B7322Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f03_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73240h, 7FFDD9B73261h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0012h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0016h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f03_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73280h, 7FFDD9B732A5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0012h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0017h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xF5,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f04_bit(bit a, bit b, bit c)
; location: [7FFDD9B732C0h, 7FFDD9B732D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f04_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B732F0h, 7FFDD9B73301h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f04_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73320h, 7FFDD9B7334Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpor xmm0,xmm0,xmm2           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]      encoding(VEX, 4 bytes) = c5 f9 eb c2
0017h vpcmpeqd xmm2,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM2,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d0
001bh vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
001fh vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0xEB,0xC2,0xC5,0xF9,0x76,0xD0,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f04_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73370h, 7FFDD9B7339Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpor ymm0,ymm0,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]      encoding(VEX, 4 bytes) = c5 fd eb c2
0017h vpcmpeqq ymm2,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d0
001ch vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0020h vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFD,0xEB,0xC2,0xC4,0xE2,0x7D,0x29,0xD0,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f05_bit(bit a, bit b, bit c)
; location: [7FFDD9B733C0h, 7FFDD9B733D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x41,0x0B,0xC8,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f05_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B733F0h, 7FFDD9B733FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f05_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73410h, 7FFDD9B73431h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 09
000eh vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0012h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0016h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x09,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f05_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73450h, 7FFDD9B73475h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 09
000eh vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0012h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0017h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x09,0xC5,0xF5,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f06_bit(bit a, bit b, bit c)
; location: [7FFDD9B73490h, 7FFDD9B734A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f06_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B734C0h, 7FFDD9B734D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f06_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B738F0h, 7FFDD9B7391Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0017h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
001bh vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
001fh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f06_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73940h, 7FFDD9B7396Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0018h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
001ch vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0020h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xF5,0xEF,0xCA,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f07_bit(bit a, bit b, bit c)
; location: [7FFDD9B73990h, 7FFDD9B739A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xD0,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f07_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B739C0h, 7FFDD9B739D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f07_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B739F0h, 7FFDD9B73A1Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0017h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
001bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f07_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73A40h, 7FFDD9B73A6Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0017h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
001bh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0020h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0xEB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f08_bit(bit a, bit b, bit c)
; location: [7FFDD9B73A90h, 7FFDD9B73AA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000eh and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f08_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73AC0h, 7FFDD9B73AD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f08_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73AF0h, 7FFDD9B73B1Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0017h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
001bh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
001fh vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0xDB,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f08_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73B40h, 7FFDD9B73B6Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0018h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
001ch vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0020h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0xDB,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f09_bit(bit a, bit b, bit c)
; location: [7FFDD9B73B90h, 7FFDD9B73BA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x33,0xD0,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f09_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73BC0h, 7FFDD9B73BD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f09_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73BF0h, 7FFDD9B73C1Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
0017h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
001bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f09_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73C40h, 7FFDD9B73C6Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0017h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
001bh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0020h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xF5,0xEF,0xCA,0xC5,0xFD,0xEB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0a_bit(bit a, bit b, bit c)
; location: [7FFDD9B73C90h, 7FFDD9B73CA3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000dh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0010h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0a_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73CC0h, 7FFDD9B73CCEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73CE0h, 7FFDD9B73D01h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 09
000eh vpcmpeqd xmm2,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM2,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d0
0012h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0016h vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x09,0xC5,0xF9,0x76,0xD0,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f0a_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73D20h, 7FFDD9B73D45h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 09
000eh vpcmpeqq ymm2,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d0
0013h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0017h vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x09,0xC4,0xE2,0x7D,0x29,0xD0,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0b_bit(bit a, bit b, bit c)
; location: [7FFDD9B73D60h, 7FFDD9B73D74h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor edx,1                     ; XOR(Xor_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 f2 01
000fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0012h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_bitBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x83,0xF2,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0b_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73D90h, 7FFDD9B73DA4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
000eh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0b_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73DC0h, 7FFDD9B73DFBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0017h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
001bh vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
001fh vxorps xmm4,xmm4,xmm4         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM4,XMM4,XMM4]  encoding(VEX, 4 bytes) = c5 d8 57 e4
0023h vpcmpeqq xmm3,xmm3,xmm4       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4] encoding(VEX, 5 bytes) = c4 e2 61 29 dc
0028h vpxor xmm1,xmm1,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 ef cb
002ch vpor xmm1,xmm1,xmm2           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]      encoding(VEX, 4 bytes) = c5 f1 eb ca
0030h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0034h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0038h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_128x64uBytes => new byte[60]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xE0,0x57,0xDB,0xC5,0xD8,0x57,0xE4,0xC4,0xE2,0x61,0x29,0xDC,0xC5,0xF1,0xEF,0xCB,0xC5,0xF1,0xEB,0xCA,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f0b_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B73E20h, 7FFDD9B73E5Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0018h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
001ch vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
0020h vxorps ymm4,ymm4,ymm4         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM4,YMM4,YMM4]  encoding(VEX, 4 bytes) = c5 dc 57 e4
0024h vpcmpeqq ymm3,ymm3,ymm4       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 29 dc
0029h vpxor ymm1,ymm1,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 ef cb
002dh vpor ymm1,ymm1,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]      encoding(VEX, 4 bytes) = c5 f5 eb ca
0031h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0035h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0039h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_256x64uBytes => new byte[64]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xE4,0x57,0xDB,0xC5,0xDC,0x57,0xE4,0xC4,0xE2,0x65,0x29,0xDC,0xC5,0xF5,0xEF,0xCB,0xC5,0xF5,0xEB,0xCA,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0c_bit(bit a, bit b, bit c)
; location: [7FFDD9B73E80h, 7FFDD9B73E93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0c_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B73EB0h, 7FFDD9B73EBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0c_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B73ED0h, 7FFDD9B73EF1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpeqd xmm2,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM2,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d0
0012h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0016h vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
001ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x76,0xD0,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f0c_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B74310h, 7FFDD9B74335h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpeqq ymm2,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d0
0013h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0017h vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
001bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x29,0xD0,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0d_bit(bit a, bit b, bit c)
; location: [7FFDD9B74350h, 7FFDD9B74365h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor r8d,1                     ; XOR(Xor_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f0 01
0010h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0013h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_bitBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x83,0xF0,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0d_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74380h, 7FFDD9B74397h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
000eh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0011h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0d_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B743B0h, 7FFDD9B743EBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0017h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
001bh vxorps xmm3,xmm3,xmm3         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM3,XMM3,XMM3]  encoding(VEX, 4 bytes) = c5 e0 57 db
001fh vxorps xmm4,xmm4,xmm4         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM4,XMM4,XMM4]  encoding(VEX, 4 bytes) = c5 d8 57 e4
0023h vpcmpeqq xmm3,xmm3,xmm4       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4] encoding(VEX, 5 bytes) = c4 e2 61 29 dc
0028h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
002ch vpor xmm1,xmm1,xmm2           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]      encoding(VEX, 4 bytes) = c5 f1 eb ca
0030h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0034h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0038h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_128x64uBytes => new byte[60]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xE0,0x57,0xDB,0xC5,0xD8,0x57,0xE4,0xC4,0xE2,0x61,0x29,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xF1,0xEB,0xCA,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f0d_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B74410h, 7FFDD9B7444Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0018h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
001ch vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
0020h vxorps ymm4,ymm4,ymm4         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM4,YMM4,YMM4]  encoding(VEX, 4 bytes) = c5 dc 57 e4
0024h vpcmpeqq ymm3,ymm3,ymm4       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 29 dc
0029h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
002dh vpor ymm1,ymm1,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]      encoding(VEX, 4 bytes) = c5 f5 eb ca
0031h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0035h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0039h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_256x64uBytes => new byte[64]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xE4,0x57,0xDB,0xC5,0xDC,0x57,0xE4,0xC4,0xE2,0x65,0x29,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xF5,0xEB,0xCA,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0e_bit(bit a, bit b, bit c)
; location: [7FFDD9B74470h, 7FFDD9B74481h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x0B,0xD0,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0e_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B744A0h, 7FFDD9B744B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0e_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B744D0h, 7FFDD9B744FAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0017h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
001bh vpor xmm1,xmm1,xmm2           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]      encoding(VEX, 4 bytes) = c5 f1 eb ca
001fh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF1,0xEB,0xCA,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f0e_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B74520h, 7FFDD9B7454Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0018h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
001ch vpor ymm1,ymm1,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]      encoding(VEX, 4 bytes) = c5 f5 eb ca
0020h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xF5,0xEB,0xCA,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f0f_bit(bit a, bit b, bit c)
; location: [7FFDD9B74570h, 7FFDD9B74585h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0010h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0012h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_bitBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0f_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B745A0h, 7FFDD9B745ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0f_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B745C0h, 7FFDD9B745D8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000dh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0011h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f0f_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B745F0h, 7FFDD9B7460Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f10_bit(bit a, bit b, bit c)
; location: [7FFDD9B74620h, 7FFDD9B74631h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f10_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74650h, 7FFDD9B74661h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f10_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B74680h, 7FFDD9B746AAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpor xmm1,xmm1,xmm2           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]      encoding(VEX, 4 bytes) = c5 f1 eb ca
0017h vpcmpeqd xmm2,xmm1,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM2,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f1 76 d1
001bh vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
001fh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF1,0xEB,0xCA,0xC5,0xF1,0x76,0xD1,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f10_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B746D0h, 7FFDD9B746FEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpor ymm1,ymm1,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]      encoding(VEX, 4 bytes) = c5 f5 eb ca
0017h vpcmpeqq ymm2,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d1
001ch vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0020h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xF5,0xEB,0xCA,0xC4,0xE2,0x75,0x29,0xD1,0xC5,0xF5,0xEF,0xCA,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f11_bit(bit a, bit b, bit c)
; location: [7FFDD9B74720h, 7FFDD9B74733h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f11_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74750h, 7FFDD9B7475Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f11_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B74770h, 7FFDD9B74792h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ah vmovupd xmm1,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 09
000fh vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0013h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0017h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001bh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_128x64uBytes => new byte[35]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0x10,0x09,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f11_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B747B0h, 7FFDD9B747D6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vmovupd ymm1,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 09
000fh vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0013h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0018h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0x10,0x09,0xC5,0xF5,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f12_bit(bit a, bit b, bit c)
; location: [7FFDD9B747F0h, 7FFDD9B74801h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ch xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000fh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xC8,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f12_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74820h, 7FFDD9B74831h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x33,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f12_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B74850h, 7FFDD9B7487Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm1,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f1 76 d9
0017h vpxor xmm1,xmm1,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3]    encoding(VEX, 4 bytes) = c5 f1 ef cb
001bh vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
001fh vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF1,0x76,0xD9,0xC5,0xF1,0xEF,0xCB,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f12_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B748A0h, 7FFDD9B748CEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d9
0018h vpxor ymm1,ymm1,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]    encoding(VEX, 4 bytes) = c5 f5 ef cb
001ch vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0020h vpand ymm0,ymm1,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 db c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x75,0x29,0xD9,0xC5,0xF5,0xEF,0xCB,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f13_bit(bit a, bit b, bit c)
; location: [7FFDD9B748F0h, 7FFDD9B74901h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0008h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x23,0xC8,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f13_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74D20h, 7FFDD9B74D31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f13_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B74D50h, 7FFDD9B74D7Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0017h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
001bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f13_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B74DA0h, 7FFDD9B74DCEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0017h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
001bh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0020h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f14_bit(bit a, bit b, bit c)
; location: [7FFDD9B74DF0h, 7FFDD9B74E01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000dh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
000fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x8B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x33,0xD1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f14_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74E20h, 7FFDD9B74E31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f14_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B74E50h, 7FFDD9B74E7Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpcmpeqd xmm3,xmm2,xmm2       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM2,XMM2] encoding(VEX, 4 bytes) = c5 e9 76 da
0017h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
001bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001fh vpand xmm0,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db c0
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xE9,0x76,0xDA,0xC5,0xE9,0xEF,0xD3,0xC5,0xF9,0xEF,0xC1,0xC5,0xE9,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f14_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B74EA0h, 7FFDD9B74ECEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpcmpeqq ymm3,ymm2,ymm2       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM2,YMM2] encoding(VEX, 5 bytes) = c4 e2 6d 29 da
0018h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
001ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0020h vpand ymm0,ymm2,ymm0          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]    encoding(VEX, 4 bytes) = c5 ed db c0
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC4,0xE2,0x6D,0x29,0xDA,0xC5,0xED,0xEF,0xD3,0xC5,0xFD,0xEF,0xC1,0xC5,0xED,0xDB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f15_bit(bit a, bit b, bit c)
; location: [7FFDD9B74EF0h, 7FFDD9B74F01h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_bitBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x41,0x0B,0xD0,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f15_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B74F20h, 7FFDD9B74F31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f15_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B74F50h, 7FFDD9B74F7Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0017h vpor xmm0,xmm2,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]      encoding(VEX, 4 bytes) = c5 e9 eb c0
001bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF9,0xDB,0xC1,0xC5,0xE9,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f15_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B74FA0h, 7FFDD9B74FCEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0017h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
001bh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0020h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0024h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0028h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_256x64uBytes => new byte[47]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFD,0xDB,0xC1,0xC5,0xED,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f16_bit(bit a, bit b, bit c)
; location: [7FFDD9B74FF0h, 7FFDD9B7500Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
000ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000fh xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
0012h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0014h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0016h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_bitBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x41,0x0B,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0x41,0x33,0xD0,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f16_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B75020h, 7FFDD9B7503Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0011h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0014h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0017h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_64uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x0B,0xC0,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC1,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f16_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B75050h, 7FFDD9B7509Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0017h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
001bh vpor xmm3,xmm3,xmm4           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]      encoding(VEX, 4 bytes) = c5 e1 eb dc
001fh vpcmpeqd xmm4,xmm3,xmm3       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM4,XMM3,XMM3] encoding(VEX, 4 bytes) = c5 e1 76 e3
0023h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0027h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002bh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
002fh vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0033h vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
0037h vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
003bh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
003fh vpor xmm0,xmm2,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]      encoding(VEX, 4 bytes) = c5 e9 eb c0
0043h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0047h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_128x64uBytes => new byte[75]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF8,0x28,0xD9,0xC5,0xF8,0x28,0xE2,0xC5,0xE1,0xEB,0xDC,0xC5,0xE1,0x76,0xE3,0xC5,0xE1,0xEF,0xDC,0xC5,0xF1,0xEF,0xCA,0xC5,0xF8,0x28,0xD0,0xC5,0xE9,0xDB,0xD3,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF9,0xDB,0xC1,0xC5,0xE9,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f16_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B750C0h, 7FFDD9B7510Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0017h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
001bh vpor ymm3,ymm3,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]      encoding(VEX, 4 bytes) = c5 e5 eb dc
001fh vpcmpeqq ymm4,ymm3,ymm3       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM4,YMM3,YMM3] encoding(VEX, 5 bytes) = c4 e2 65 29 e3
0024h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0028h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ch vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0030h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0034h vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0039h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
003dh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0041h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0045h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0049h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_256x64uBytes => new byte[80]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFC,0x28,0xD9,0xC5,0xFC,0x28,0xE2,0xC5,0xE5,0xEB,0xDC,0xC4,0xE2,0x65,0x29,0xE3,0xC5,0xE5,0xEF,0xDC,0xC5,0xF5,0xEF,0xCA,0xC5,0xFC,0x28,0xD0,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xFD,0xDB,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f17_bit(bit a, bit b, bit c)
; location: [7FFDD9B75130h, 7FFDD9B7514Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
000ah and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
000dh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0011h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0013h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0015h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0018h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
001ah and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_bitBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0x41,0x0B,0xC0,0x41,0x23,0xD0,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f17_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B75160h, 7FFDD9B7517Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0014h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0017h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001ah not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_64uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x0B,0xC0,0x49,0x23,0xD0,0x48,0x23,0xC1,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f17_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B75190h, 7FFDD9B751DAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0017h vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
001bh vpor xmm3,xmm3,xmm4           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]      encoding(VEX, 4 bytes) = c5 e1 eb dc
001fh vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
0023h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0027h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002bh vpcmpeqd xmm3,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM3,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 d8
002fh vpxor xmm0,xmm0,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 ef c3
0033h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0037h vpor xmm0,xmm2,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0]      encoding(VEX, 4 bytes) = c5 e9 eb c0
003bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
003fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0043h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0047h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_128x64uBytes => new byte[75]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF8,0x28,0xD9,0xC5,0xF8,0x28,0xE2,0xC5,0xE1,0xEB,0xDC,0xC5,0xF1,0xDB,0xCA,0xC5,0xF8,0x28,0xD0,0xC5,0xE9,0xDB,0xD3,0xC5,0xF9,0x76,0xD8,0xC5,0xF9,0xEF,0xC3,0xC5,0xF9,0xDB,0xC1,0xC5,0xE9,0xEB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> f17_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B75200h, 7FFDD9B7524Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vmovupd ymm2,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 11
0013h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0017h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
001bh vpor ymm3,ymm3,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]      encoding(VEX, 4 bytes) = c5 e5 eb dc
001fh vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
0023h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0027h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002bh vpcmpeqq ymm3,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM3,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d8
0030h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
0034h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0038h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
003ch vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0041h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0045h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0049h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_256x64uBytes => new byte[80]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x7D,0x10,0x11,0xC5,0xFC,0x28,0xD9,0xC5,0xFC,0x28,0xE2,0xC5,0xE5,0xEB,0xDC,0xC5,0xF5,0xDB,0xCA,0xC5,0xFC,0x28,0xD0,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x7D,0x29,0xD8,0xC5,0xFD,0xEF,0xC3,0xC5,0xFD,0xDB,0xC1,0xC5,0xED,0xEB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit f18_bit(bit a, bit b, bit c)
; location: [7FFDD9B75270h, 7FFDD9B7527Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_bitBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x41,0x33,0xC8,0x8B,0xC2,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f18_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B75290h, 7FFDD9B752A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f18_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B752C0h, 7FFDD9B752EAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovupd xmm2,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 11
0013h vmovaps xmm3,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d8
0017h vpxor xmm1,xmm3,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM3,XMM1]    encoding(VEX, 4 bytes) = c5 e1 ef c9
001bh vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
001fh vpand xmm0,xmm1,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 db c0
0023h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0027h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x79,0x10,0x11,0xC5,0xF8,0x28,0xD8,0xC5,0xE1,0xEF,0xC9,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
