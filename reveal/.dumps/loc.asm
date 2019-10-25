; 2019-10-25 06:35:13:109
; function: Vector256<ulong> f19_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B7B030h, 7FFDD9B7B065h]
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
; location: [7FFDD9B7B080h, 7FFDD9B7B093h]
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
; location: [7FFDD9B7B4D0h, 7FFDD9B7B4E4h]
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
; location: [7FFDD9B7BAC0h, 7FFDD9B7BAF2h]
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
; location: [7FFDD9B7BB10h, 7FFDD9B7BB46h]
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
; location: [7FFDD9B7BB60h, 7FFDD9B7BB80h]
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
; location: [7FFDD9B7BBA0h, 7FFDD9B7BBBDh]
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
; location: [7FFDD9B7BBD0h, 7FFDD9B7BC12h]
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
; location: [7FFDD9B7C040h, 7FFDD9B7C088h]
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
; location: [7FFDD9B7C0B0h, 7FFDD9B7C0C4h]
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
; location: [7FFDD9B7C0E0h, 7FFDD9B7C0FDh]
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
; location: [7FFDD9B7C110h, 7FFDD9B7C11Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1eBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1f(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C130h, 7FFDD9B7C141h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1fBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f20(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C160h, 7FFDD9B7C171h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f20Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f21(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C190h, 7FFDD9B7C1A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f21Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f22(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C1C0h, 7FFDD9B7C1CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,r8               ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 e8 f2 c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f22Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xC2,0xE8,0xF2,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f23(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C1E0h, 7FFDD9B7C1F7h]
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
; location: [7FFDD9B7C210h, 7FFDD9B7C221h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,rdx                   ; XOR(Xor_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 33 ca
0008h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f24Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xCA,0x49,0x33,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f25(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C240h, 7FFDD9B7C25Ah]
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
; location: [7FFDD9B7C680h, 7FFDD9B7C694h]
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
; location: [7FFDD9B7C6B0h, 7FFDD9B7C6D0h]
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
; location: [7FFDD9B7C6F0h, 7FFDD9B7C6FEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f28Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f29(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C710h, 7FFDD9B7C730h]
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
; location: [7FFDD9B7C750h, 7FFDD9B7C761h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2aBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2b(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C780h, 7FFDD9B7C7A3h]
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
; location: [7FFDD9B7C7C0h, 7FFDD9B7C7D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8,rdx                     ; OR(Or_r64_rm64) [R8,RDX]                             encoding(3 bytes) = 4c 0b c2
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2cBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x0B,0xC2,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2d(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C7F0h, 7FFDD9B7C801h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000eh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2dBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x0B,0xC2,0x48,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2e(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C820h, 7FFDD9B7C831h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8,rdx                     ; OR(Or_r64_rm64) [R8,RDX]                             encoding(3 bytes) = 4c 0b c2
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f2eBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x0B,0xC2,0x48,0x23,0xD1,0x49,0x33,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f2f(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C850h, 7FFDD9B7C864h]
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
; location: [7FFDD9B7C880h, 7FFDD9B7C88Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,rcx              ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 e8 f2 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f30Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xE8,0xF2,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f31(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C8A0h, 7FFDD9B7C8B7h]
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
; location: [7FFDD9B7C8D0h, 7FFDD9B7C8E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f32Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x0B,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f33(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C900h, 7FFDD9B7C90Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f33Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f34(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C920h, 7FFDD9B7C934h]
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
; location: [7FFDD9B7C950h, 7FFDD9B7C96Dh]
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
; location: [7FFDD9B7C980h, 7FFDD9B7C98Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f36Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f37(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C9A0h, 7FFDD9B7C9B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f37Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f38(ulong a, ulong b, ulong c)
; location: [7FFDD9B7C9D0h, 7FFDD9B7C9E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or r8,rcx                     ; OR(Or_r64_rm64) [R8,RCX]                             encoding(3 bytes) = 4c 0b c1
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f38Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x0B,0xC1,0x48,0x33,0xD1,0x49,0x23,0xD0,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f39(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CE00h, 7FFDD9B7CE11h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
000eh xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f39Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x0B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3a(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CE30h, 7FFDD9B7CE4Ah]
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
; location: [7FFDD9B7CE60h, 7FFDD9B7CE74h]
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
; location: [7FFDD9B7CE90h, 7FFDD9B7CE9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3cBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f3d(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CEB0h, 7FFDD9B7CEC4h]
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
; location: [7FFDD9B7CEE0h, 7FFDD9B7CEF4h]
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
; location: [7FFDD9B7CF10h, 7FFDD9B7CF1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f3fBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f40(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CF30h, 7FFDD9B7CF41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f40Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x23,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f41(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CF60h, 7FFDD9B7CF71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f41Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f42(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CF90h, 7FFDD9B7CFA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f42Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x49,0x33,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f43(ulong a, ulong b, ulong c)
; location: [7FFDD9B7CFC0h, 7FFDD9B7CFD7h]
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
; location: [7FFDD9B7CFF0h, 7FFDD9B7CFFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,r8,rdx               ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,R8,RDX]             encoding(VEX, 5 bytes) = c4 e2 b8 f2 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f44Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xB8,0xF2,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f45(ulong a, ulong b, ulong c)
; location: [7FFDD9B7D010h, 7FFDD9B7D024h]
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
; location: [7FFDD9B7D040h, 7FFDD9B7D054h]
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
; location: [7FFDD9B7D070h, 7FFDD9B7D08Ah]
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
; location: [7FFDD9B7D0A0h, 7FFDD9B7D0AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f48Bytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f49(ulong a, ulong b, ulong c)
; location: [7FFDD9B7D0C0h, 7FFDD9B7D0DDh]
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
; location: [7FFDD9B7D0F0h, 7FFDD9B7D101h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4aBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4b(ulong a, ulong b, ulong c)
; location: [7FFDD9B7D520h, 7FFDD9B7D531h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
000eh xor rax,rcx                   ; XOR(Xor_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 33 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4bBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x0B,0xC0,0x48,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4c(ulong a, ulong b, ulong c)
; location: [7FFDD9B7D550h, 7FFDD9B7D561h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4cBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f4d(ulong a, ulong b, ulong c)
; location: [7FFDD9B7D580h, 7FFDD9B7D5A0h]
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
; location: [7FFDD9B7D5C0h, 7FFDD9B7D5DAh]
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
; location: [7FFDD9B7D5F0h, 7FFDD9B7D603h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh andn rdx,r8,rdx               ; ANDN(VEX_Andn_r64_r64_rm64) [RDX,R8,RDX]             encoding(VEX, 5 bytes) = c4 e2 b8 f2 d2
0010h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f4fBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC4,0xE2,0xB8,0xF2,0xD2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f97_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B7D620h, 7FFDD9B7D643h]
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
; location: [7FFDD9B7D660h, 7FFDD9B7D6B2h]
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
; location: [7FFDD9B7D6E0h, 7FFDD9B7D738h]
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
; function: uint composition_54(uint v1, uint v2)
; location: [7FFDD9B7DB60h, 7FFDD9B7DB73h]
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
; location: [7FFDD9B7DB90h, 7FFDD9B7DBCEh]
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
; location: [7FFDD9B7DBE0h, 7FFDD9B7DBEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> and_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B7DC00h, 7FFDD9B7DC19h]
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
; location: [7FFDD9B7DC30h, 7FFDD9B7DC4Ch]
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
; location: [7FFDD9B7DC60h, 7FFDD9B7DC6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> or_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B7DC80h, 7FFDD9B7DC99h]
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
; location: [7FFDD9B7DCB0h, 7FFDD9B7DCCCh]
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
; location: [7FFDD9B7DCE0h, 7FFDD9B7DCEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> xor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B7DD00h, 7FFDD9B7DD19h]
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
; location: [7FFDD9B7DD30h, 7FFDD9B7DD4Ch]
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
; location: [7FFDD9B7DD60h, 7FFDD9B7DD6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> not_v128x64u(Vector128<ulong> a)
; location: [7FFDD9B7DD80h, 7FFDD9B7DD98h]
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
; location: [7FFDD9B7DDB0h, 7FFDD9B7DDCCh]
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
; location: [7FFDD9B7DDE0h, 7FFDD9B7DDEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> nand_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B7DE00h, 7FFDD9B7DE21h]
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
; location: [7FFDD9B7DE40h, 7FFDD9B7DE65h]
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
; location: [7FFDD9B7DE80h, 7FFDD9B7DE8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> nor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B7DEA0h, 7FFDD9B7DEC1h]
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
; location: [7FFDD9B7DEE0h, 7FFDD9B7DF05h]
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
; location: [7FFDD9B7DF20h, 7FFDD9B7DF2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> xnor_v128x64u(Vector128<ulong> a, Vector128<ulong> b)
; location: [7FFDD9B7DF40h, 7FFDD9B7DF61h]
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
; location: [7FFDD9B7DF80h, 7FFDD9B7DFA5h]
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
; location: [7FFDD9B7DFC0h, 7FFDD9B7DFCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> xor1_v128x64u(Vector128<ulong> a)
; location: [7FFDD9B7DFE0h, 7FFDD9B7E001h]
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
; location: [7FFDD9B7E020h, 7FFDD9B7E044h]
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
; location: [7FFDD9B7E060h, 7FFDD9B7E074h]
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
; location: [7FFDD9B7E090h, 7FFDD9B7E0C2h]
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
; location: [7FFDD9B7E0E0h, 7FFDD9B7E116h]
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
; location: [7FFDD9B7E130h, 7FFDD9B7E141h]
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
; location: [7FFDD9B7E160h, 7FFDD9B7E171h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f01_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7E190h, 7FFDD9B7E1BAh]
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
; location: [7FFDD9B7E1E0h, 7FFDD9B7E20Eh]
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
; location: [7FFDD9B7E230h, 7FFDD9B7E241h]
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
; location: [7FFDD9B7E260h, 7FFDD9B7E271h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f02_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7E290h, 7FFDD9B7E2BAh]
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
; location: [7FFDD9B7E2E0h, 7FFDD9B7E30Eh]
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
; location: [7FFDD9B7E330h, 7FFDD9B7E343h]
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
; location: [7FFDD9B7E360h, 7FFDD9B7E36Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f03_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7E790h, 7FFDD9B7E7B1h]
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
; location: [7FFDD9B7E7D0h, 7FFDD9B7E7F5h]
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
; location: [7FFDD9B7E810h, 7FFDD9B7E821h]
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
; location: [7FFDD9B7E840h, 7FFDD9B7E851h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f04_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7E870h, 7FFDD9B7E89Ah]
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
; location: [7FFDD9B7E8C0h, 7FFDD9B7E8EEh]
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
; location: [7FFDD9B7E910h, 7FFDD9B7E923h]
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
; location: [7FFDD9B7E940h, 7FFDD9B7E94Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f05_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7E960h, 7FFDD9B7E981h]
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
; location: [7FFDD9B7E9A0h, 7FFDD9B7E9C5h]
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
; location: [7FFDD9B7E9E0h, 7FFDD9B7E9F1h]
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
; location: [7FFDD9B7EA10h, 7FFDD9B7EA21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f06_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7EA40h, 7FFDD9B7EA6Ah]
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
; location: [7FFDD9B7EA90h, 7FFDD9B7EABEh]
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
; location: [7FFDD9B7EAE0h, 7FFDD9B7EAF1h]
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
; location: [7FFDD9B7EB10h, 7FFDD9B7EB21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f07_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7EB40h, 7FFDD9B7EB6Ah]
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
; location: [7FFDD9B7EB90h, 7FFDD9B7EBBEh]
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
; location: [7FFDD9B7EBE0h, 7FFDD9B7EBF1h]
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
; location: [7FFDD9B7EC10h, 7FFDD9B7EC21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f08_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7EC40h, 7FFDD9B7EC6Ah]
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
; location: [7FFDD9B7EC90h, 7FFDD9B7ECBEh]
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
; location: [7FFDD9B7ECE0h, 7FFDD9B7ECF1h]
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
; location: [7FFDD9B7ED10h, 7FFDD9B7ED21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f09_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7ED40h, 7FFDD9B7ED6Ah]
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
; location: [7FFDD9B7ED90h, 7FFDD9B7EDBEh]
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
; location: [7FFDD9B7EDE0h, 7FFDD9B7EDF3h]
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
; location: [7FFDD9B7EE10h, 7FFDD9B7EE1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0a_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7EE30h, 7FFDD9B7EE51h]
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
; location: [7FFDD9B7F270h, 7FFDD9B7F295h]
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
; location: [7FFDD9B7F2B0h, 7FFDD9B7F2C4h]
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
; location: [7FFDD9B7F2E0h, 7FFDD9B7F2F4h]
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
; location: [7FFDD9B7F310h, 7FFDD9B7F34Bh]
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
; location: [7FFDD9B7F370h, 7FFDD9B7F3AFh]
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
; location: [7FFDD9B7F3D0h, 7FFDD9B7F3E3h]
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
; location: [7FFDD9B7F400h, 7FFDD9B7F40Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0c_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7F420h, 7FFDD9B7F441h]
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
; location: [7FFDD9B7F460h, 7FFDD9B7F485h]
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
; location: [7FFDD9B7F4A0h, 7FFDD9B7F4B5h]
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
; location: [7FFDD9B7F4D0h, 7FFDD9B7F4E7h]
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
; location: [7FFDD9B7F500h, 7FFDD9B7F53Bh]
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
; location: [7FFDD9B7F560h, 7FFDD9B7F59Fh]
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
; location: [7FFDD9B7F5C0h, 7FFDD9B7F5D1h]
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
; location: [7FFDD9B7F5F0h, 7FFDD9B7F601h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0e_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7F620h, 7FFDD9B7F64Ah]
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
; location: [7FFDD9B7F670h, 7FFDD9B7F69Eh]
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
; location: [7FFDD9B7F6C0h, 7FFDD9B7F6D5h]
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
; location: [7FFDD9B7F6F0h, 7FFDD9B7F6FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f0f_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7F710h, 7FFDD9B7F728h]
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
; location: [7FFDD9B7F740h, 7FFDD9B7F75Ch]
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
; location: [7FFDD9B7F770h, 7FFDD9B7F781h]
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
; location: [7FFDD9B7F7A0h, 7FFDD9B7F7B1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f10_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7FBD0h, 7FFDD9B7FBFAh]
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
; location: [7FFDD9B7FC20h, 7FFDD9B7FC4Eh]
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
; location: [7FFDD9B7FC70h, 7FFDD9B7FC83h]
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
; location: [7FFDD9B7FCA0h, 7FFDD9B7FCAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f11_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7FCC0h, 7FFDD9B7FCE2h]
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
; location: [7FFDD9B7FD00h, 7FFDD9B7FD26h]
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
; location: [7FFDD9B7FD40h, 7FFDD9B7FD51h]
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
; location: [7FFDD9B7FD70h, 7FFDD9B7FD81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x33,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f12_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7FDA0h, 7FFDD9B7FDCAh]
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
; location: [7FFDD9B7FDF0h, 7FFDD9B7FE1Eh]
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
; location: [7FFDD9B7FE40h, 7FFDD9B7FE51h]
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
; location: [7FFDD9B7FE70h, 7FFDD9B7FE81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f13_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7FEA0h, 7FFDD9B7FECAh]
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
; location: [7FFDD9B7FEF0h, 7FFDD9B7FF1Eh]
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
; location: [7FFDD9B7FF40h, 7FFDD9B7FF51h]
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
; location: [7FFDD9B7FF70h, 7FFDD9B7FF81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f14_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B7FFA0h, 7FFDD9B7FFCAh]
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
; location: [7FFDD9B7FFF0h, 7FFDD9B8001Eh]
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
; location: [7FFDD9B80040h, 7FFDD9B80051h]
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
; location: [7FFDD9B80070h, 7FFDD9B80081h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f15_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B800A0h, 7FFDD9B800CAh]
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
; location: [7FFDD9B800F0h, 7FFDD9B8011Eh]
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
; location: [7FFDD9B80140h, 7FFDD9B8015Dh]
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
; location: [7FFDD9B80170h, 7FFDD9B8018Dh]
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
; location: [7FFDD9B801A0h, 7FFDD9B801EAh]
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
; location: [7FFDD9B80210h, 7FFDD9B8025Fh]
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
; location: [7FFDD9B80280h, 7FFDD9B8029Dh]
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
; location: [7FFDD9B806C0h, 7FFDD9B806DDh]
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
; location: [7FFDD9B806F0h, 7FFDD9B8073Ah]
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
; location: [7FFDD9B80760h, 7FFDD9B807AFh]
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
; location: [7FFDD9B807D0h, 7FFDD9B807DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h xor ecx,r8d                   ; XOR(Xor_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 33 c8
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_bitBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x41,0x33,0xC8,0x8B,0xC2,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f18_64u(ulong a, ulong b, ulong c)
; location: [7FFDD9B807F0h, 7FFDD9B80801h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> f18_128x64u(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c)
; location: [7FFDD9B80820h, 7FFDD9B8084Ah]
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
; function: Vector256<ulong> f18_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c)
; location: [7FFDD9B80870h, 7FFDD9B8089Dh]
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
; location: [7FFDD9B808C0h, 7FFDD9B808D1h]
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
; location: [7FFDD9B808F0h, 7FFDD9B80907h]
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
; location: [7FFDD9B80920h, 7FFDD9B80952h]
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
