; 2019-11-08 02:45:45:793
; function: Vector256<ushort> rotl_g256x16u(Vector256<ushort> src, byte offset)
; location: [7FFDDBA19150h, 7FFDDBA19183h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllw ymm1,ymm0,xmm1         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f1 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlw ymm0,ymm0,xmm2         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d1 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x16uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF1,0xC9,0xF7,0xD8,0x83,0xC0,0x10,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD1,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> rotl_g256x32u(Vector256<uint> src, byte offset)
; location: [7FFDDBA191A0h, 7FFDDBA191D3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpslld ymm1,ymm0,xmm1         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f2 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrld ymm0,ymm0,xmm2         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d2 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x32uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF2,0xC9,0xF7,0xD8,0x83,0xC0,0x20,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD2,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
; location: [7FFDDBA19600h, 7FFDDBA19633h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq ymm1,ymm0,xmm1         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM1,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq ymm0,ymm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd d3 c2
0025h vpor ymm0,ymm1,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]      encoding(VEX, 4 bytes) = c5 f5 eb c0
0029h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x64uBytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xD3,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FFDDBA19650h, 7FFDDBA19668h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
; location: [7FFDDBA19680h, 7FFDDBA19698h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FFDDBA196B0h, 7FFDDBA196C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
; location: [7FFDDBA196E0h, 7FFDDBA196F8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FFDDBA19710h, 7FFDDBA19728h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
; location: [7FFDDBA19B50h, 7FFDDBA19B68h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FFDDBA19B80h, 7FFDDBA19B98h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
; location: [7FFDDBA19BB0h, 7FFDDBA19BC8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FFDDBA19BE0h, 7FFDDBA19BF8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
; location: [7FFDDBA19C10h, 7FFDDBA19C28h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FFDDBA19C40h, 7FFDDBA19C58h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
; location: [7FFDDBA19C70h, 7FFDDBA19C88h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FFDDBA19CA0h, 7FFDDBA19CB8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
; location: [7FFDDBA1A0E0h, 7FFDDBA1A0F8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FFDDBA1A110h, 7FFDDBA1A128h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
; location: [7FFDDBA1A140h, 7FFDDBA1A158h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh vptest xmm0,xmm1              ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1]           encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FFDDBA1A170h, 7FFDDBA1A18Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
; location: [7FFDDBA1A1A0h, 7FFDDBA1A1BBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FFDDBA1A1D0h, 7FFDDBA1A1EBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
; location: [7FFDDBA1A610h, 7FFDDBA1A62Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FFDDBA1A640h, 7FFDDBA1A65Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
; location: [7FFDDBA1A670h, 7FFDDBA1A68Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FFDDBA1A6A0h, 7FFDDBA1A6BBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x16uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
; location: [7FFDDBA1A6D0h, 7FFDDBA1A6EBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x16uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FFDDBA1A700h, 7FFDDBA1A71Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
; location: [7FFDDBA1AB40h, 7FFDDBA1AB5Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FFDDBA1AB70h, 7FFDDBA1AB8Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x32uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
; location: [7FFDDBA1ABA0h, 7FFDDBA1ABBBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x32uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FFDDBA1ABD0h, 7FFDDBA1ABEBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
; location: [7FFDDBA1AC00h, 7FFDDBA1AC1Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64iBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FFDDBA1AC30h, 7FFDDBA1AC4Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_d256x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
; location: [7FFDDBA1AC60h, 7FFDDBA1AC7Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vptest ymm0,ymm1              ; VPTEST(VEX_Vptest_ymm_ymmm256) [YMM0,YMM1]           encoding(VEX, 5 bytes) = c4 e2 7d 17 c1
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtestz_g256x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x7D,0x17,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 clmul(ulong x, ulong y)
; location: [7FFDDBA1B0A0h, 7FFDDBA1B0EEh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
000eh mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0013h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0018h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
001dh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0023h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0028h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
002dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0032h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0036h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
003bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
003eh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0043h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 41 08
0047h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulBytes => new byte[79]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x00,0x48,0x8B,0x44,0x24,0x08,0x48,0x89,0x01,0x48,0x8B,0x44,0x24,0x10,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
; location: [7FFDDBA1B110h, 7FFDDBA1B12Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
000ah vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
000fh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0015h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0018h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001ch mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulBytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x49,0x8B,0xC0,0xC5,0xFA,0x7F,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong clmulr8u(ulong a, ulong b, ulong poly)
; location: [7FFDDBA1B150h, 7FFDDBA1B224h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0013h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0018h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
001dh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0022h vmovq xmm1,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e ca
0027h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
002dh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0032h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0036h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
003bh mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 10
003eh mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 28
0043h shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0047h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
004ah mov [rsp+18h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 18
004fh mov [rsp+20h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 20
0054h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0059h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
005eh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0064h mov [rsp+18h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 18
0069h mov [rsp+20h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 20
006eh lea rcx,[rsp+18h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 18
0073h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0077h mov rcx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 18
007ch xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
007fh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0082h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0087h mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 10
008ah mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 28
008fh shr rcx,8                     ; SHR(Shr_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e9 08
0093h mov [rsp+8],r9                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 08
0098h mov [rsp+10h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 10
009dh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
00a2h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
00a7h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00adh mov [rsp+8],r9                ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 08
00b2h mov [rsp+10h],r9              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R9]         encoding(5 bytes) = 4c 89 4c 24 10
00b7h lea rcx,[rsp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 08
00bch vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00c0h mov rcx,[rsp+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 08
00c5h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
00c8h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
00cbh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
00d0h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00d4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmulr8uBytes => new byte[213]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x00,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x10,0x48,0x8B,0x4C,0x24,0x28,0x48,0xC1,0xE9,0x08,0x45,0x33,0xC9,0x4C,0x89,0x4C,0x24,0x18,0x4C,0x89,0x4C,0x24,0x20,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x4C,0x89,0x4C,0x24,0x18,0x4C,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x18,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x4C,0x24,0x18,0x48,0x33,0xD1,0x48,0x89,0x10,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x10,0x48,0x8B,0x4C,0x24,0x28,0x48,0xC1,0xE9,0x08,0x4C,0x89,0x4C,0x24,0x08,0x4C,0x89,0x4C,0x24,0x10,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0x4C,0x89,0x4C,0x24,0x08,0x4C,0x89,0x4C,0x24,0x10,0x48,0x8D,0x4C,0x24,0x08,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x4C,0x24,0x08,0x48,0x33,0xD1,0x48,0x89,0x10,0x48,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vadd_d128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFDDBA1B240h, 7FFDDBA1B259h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_d128x8iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vadd_g128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
; location: [7FFDDBA1B270h, 7FFDDBA1B289h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x8iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vadd_g128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
; location: [7FFDDBA1B2A0h, 7FFDDBA1B2B9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddb xmm0,xmm0,xmm1         ; VPADDB(VEX_Vpaddb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fc c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x8uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFC,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vadd_g128x16i(Vector128<short> lhs, Vector128<short> rhs)
; location: [7FFDDBA1B2D0h, 7FFDDBA1B2E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddw xmm0,xmm0,xmm1         ; VPADDW(VEX_Vpaddw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fd c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x16iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFD,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vadd_g128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
; location: [7FFDDBA1B710h, 7FFDDBA1B729h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddw xmm0,xmm0,xmm1         ; VPADDW(VEX_Vpaddw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fd c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFD,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vadd_g128x32i(Vector128<int> lhs, Vector128<int> rhs)
; location: [7FFDDBA1B740h, 7FFDDBA1B759h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFE,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vadd_g128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
; location: [7FFDDBA1B770h, 7FFDDBA1B789h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddd xmm0,xmm0,xmm1         ; VPADDD(VEX_Vpaddd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 fe c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xFE,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vadd_g128x64i(Vector128<long> lhs, Vector128<long> rhs)
; location: [7FFDDBA1B7A0h, 7FFDDBA1B7B9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vadd_g128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
; location: [7FFDDBA1B7D0h, 7FFDDBA1B7E9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpaddq xmm0,xmm0,xmm1         ; VPADDQ(VEX_Vpaddq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 d4 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xD4,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<float> vadd_g128x32f(Vector128<float> lhs, Vector128<float> rhs)
; location: [7FFDDBA1C2E0h, 7FFDDBA1C304h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0010h vmovapd [rsp],xmm1            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 29 0c 24
0015h vaddps xmm0,xmm0,xmm0         ; VADDPS(VEX_Vaddps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 58 c0
0019h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0020h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x32fBytes => new byte[37]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x29,0x0C,0x24,0xC5,0xF8,0x58,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<double> vadd_g128x64f(Vector128<double> lhs, Vector128<double> rhs)
; location: [7FFDDBA1C730h, 7FFDDBA1C749h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vaddpd xmm0,xmm0,xmm1         ; VADDPD(VEX_Vaddpd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 58 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vadd_g128x64fBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x58,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBA1C760h, 7FFDDBA1C77Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0     ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 00
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBA1C790h, 7FFDDBA1C7ABh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0FFh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,ffh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 ff
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xFF,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBA1C7C0h, 7FFDDBA1C7DBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0F0h  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,f0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 f0
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LLLLRRRRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xF0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBA1C7F0h, 7FFDDBA1C80Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0Fh   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,fh:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 0f
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RRRRLLLLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x0F,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBA1C820h, 7FFDDBA1C83Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,0AAh  ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,aah:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 aa
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_LRLRLRLRBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0xAA,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
; location: [7FFDDBA1C850h, 7FFDDBA1C86Bh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpblendw xmm0,xmm0,xmm1,55h   ; VPBLENDW(VEX_Vpblendw_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,55h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 0e c1 55
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vblend_128x16u_RLRLRLRLBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE3,0x79,0x0E,0xC1,0x55,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FFDDBA1C880h, 7FFDDBA1C899h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
; location: [7FFDDBA1C8B0h, 7FFDDBA1C8C9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32iBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FFDDBA1C8E0h, 7FFDDBA1C919h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FFDDBA1C940h, 7FFDDBA1C979h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],80000000h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80000000h:imm32] encoding(8 bytes) = c7 44 24 04 00 00 00 80
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpxor xmm0,xmm0,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 ef c2
0026h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
002ah vpcmpgtd xmm0,xmm1,xmm0       ; VPCMPGTD(VEX_Vpcmpgtd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 66 c0
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x32uBytes => new byte[58]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0x00,0x00,0x00,0x80,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xEF,0xC2,0xC5,0xF1,0xEF,0xCA,0xC5,0xF1,0x66,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FFDDBA1C9A0h, 7FFDDBA1C9D7h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0027h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0031h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0034h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64iBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
; location: [7FFDDBA1C9F0h, 7FFDDBA1CA27h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0027h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
002dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0031h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0034h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64iBytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDBA1CE50h, 7FFDDBA1CEABh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
002ch mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0030h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0034h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
003ah vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
003eh vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0042h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0047h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
004dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0051h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0054h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_128x64uBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
; location: [7FFDDBA1CED0h, 7FFDDBA1CF2Bh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0012h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
0018h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ch vinserti128 ymm1,ymm2,xmm1,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 00
0022h mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
002ch mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0030h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0034h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
003ah vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
003eh vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0042h vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0047h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
004dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0051h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0054h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0057h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g128x64uBytes => new byte[92]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC9,0x00,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDBA1CF50h, 7FFDDBA1CF8Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80h:imm32] encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
; location: [7FFDDBA1CFB0h, 7FFDDBA1CFECh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],80h     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),80h:imm32] encoding(8 bytes) = c7 44 24 04 80 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastb ymm2,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM2,mem(8i,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 78 54 24 04
0022h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0026h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002ah vpcmpgtb ymm0,ymm1,ymm0       ; VPCMPGTB(VEX_Vpcmpgtb_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 4 bytes) = c5 f5 64 c0
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x8uBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0x80,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x78,0x54,0x24,0x04,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0x64,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FFDDBA1D010h, 7FFDDBA1D02Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
; location: [7FFDDBA1D040h, 7FFDDBA1D05Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDBA1D070h, 7FFDDBA1D0B1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
; location: [7FFDDBA1D0D0h, 7FFDDBA1D111h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,8000000000000000h     ; MOV(Mov_r64_imm64) [RAX,8000000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 80
0018h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
001ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0020h vpbroadcastq ymm2,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM2,mem(64i,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 14 24
0026h vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
002ah vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002eh vpcmpgtq ymm0,ymm1,ymm0       ; VPCMPGTQ(VEX_Vpcmpgtq_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 37 c0
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcmplt_g256x64uBytes => new byte[66]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x14,0x24,0xC5,0xFD,0xEF,0xC2,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x75,0x37,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<short> vconvert_128x8i_to_128x16i(Vector128<sbyte> src, out Vector128<short> dst)
; location: [7FFDDBA1D130h, 7FFDDBA1D145h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbw xmm0,xmm0           ; VPMOVSXBW(VEX_Vpmovsxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 20 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_128x16iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x20,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x8i_to_128x32i(Vector128<sbyte> src, out Vector128<int> dst)
; location: [7FFDDBA1D160h, 7FFDDBA1D175h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbd xmm0,xmm0           ; VPMOVSXBD(VEX_Vpmovsxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 21 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x21,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x8i_to_128x64i(Vector128<sbyte> src, out Vector128<long> dst)
; location: [7FFDDBA1D190h, 7FFDDBA1D1A5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbq xmm0,xmm0           ; VPMOVSXBQ(VEX_Vpmovsxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 22 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x22,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<short> vconvert_128x8u_to_128x16i(Vector128<byte> src, out Vector128<short> dst)
; location: [7FFDDBA1D1C0h, 7FFDDBA1D1D5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x16iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ushort> vconvert_128x8u_to_128x16u(Vector128<byte> src, out Vector128<ushort> dst)
; location: [7FFDDBA1D1F0h, 7FFDDBA1D205h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x16uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x8u_to_128x32i(Vector128<byte> src, out Vector128<int> dst)
; location: [7FFDDBA1D220h, 7FFDDBA1D235h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<uint> vconvert_128x8u_to_128x32u(Vector128<byte> src, out Vector128<uint> dst)
; location: [7FFDDBA1D250h, 7FFDDBA1D265h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd xmm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 31 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x31,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x8u_to_128x64i(Vector128<byte> src, out Vector128<long> dst)
; location: [7FFDDBA1D280h, 7FFDDBA1D295h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq xmm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 32 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x32,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ulong> vconvert_128x8u_to_128x64u(Vector128<byte> src, out Vector128<ulong> dst)
; location: [7FFDDBA1D2B0h, 7FFDDBA1D2C5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq xmm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_xmm_xmmm16) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 32 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x32,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x16i_to_128x32i(Vector128<short> src, out Vector128<int> dst)
; location: [7FFDDBA1D2E0h, 7FFDDBA1D2F5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwd xmm0,xmm0           ; VPMOVSXWD(VEX_Vpmovsxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 23 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x23,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x16i_to_128x64i(Vector128<short> src, out Vector128<long> dst)
; location: [7FFDDBA1D310h, 7FFDDBA1D325h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwq xmm0,xmm0           ; VPMOVSXWQ(VEX_Vpmovsxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 24 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x24,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<int> vconvert_128x16u_to_128x32i(Vector128<ushort> src, out Vector128<int> dst)
; location: [7FFDDBA1D340h, 7FFDDBA1D355h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd xmm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x32iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x33,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<uint> vconvert_128x16u_to_128x32u(Vector128<ushort> src, out Vector128<uint> dst)
; location: [7FFDDBA1D370h, 7FFDDBA1D385h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd xmm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x33,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x16u_to_128x64i(Vector128<ushort> src, out Vector128<long> dst)
; location: [7FFDDBA1D3A0h, 7FFDDBA1D3B5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq xmm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 34 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x34,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ulong> vconvert_128x16u_to_128x64u(Vector128<ushort> src, out Vector128<ulong> dst)
; location: [7FFDDBA1D3D0h, 7FFDDBA1D3E5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq xmm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_xmm_xmmm32) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 34 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x34,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x32i_to_128x64i(Vector128<int> src, out Vector128<long> dst)
; location: [7FFDDBA1D400h, 7FFDDBA1D415h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxdq xmm0,xmm0           ; VPMOVSXDQ(VEX_Vpmovsxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 25 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32i_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x25,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<long> vconvert_128x32u_to_128x64i(Vector128<uint> src, out Vector128<long> dst)
; location: [7FFDDBA1D430h, 7FFDDBA1D445h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq xmm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 35 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_128x64iBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x35,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector128<ulong> vconvert_128x32u_to_128x64u(Vector128<uint> src, out Vector128<ulong> dst)
; location: [7FFDDBA1D460h, 7FFDDBA1D475h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq xmm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 35 c0
000eh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x79,0x35,0xC0,0xC5,0xF9,0x11,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<short> vconvert_128x8i_to_256x16i(Vector128<sbyte> src, out Vector256<short> dst)
; location: [7FFDDBA1D490h, 7FFDDBA1D4A8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbw ymm0,xmm0           ; VPMOVSXBW(VEX_Vpmovsxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 20 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x20,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x8i_to_256x32i(Vector128<sbyte> src, out Vector256<int> dst)
; location: [7FFDDBA1D4C0h, 7FFDDBA1D4D8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbd ymm0,xmm0           ; VPMOVSXBD(VEX_Vpmovsxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 21 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x21,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x8i_to_256x64i(Vector128<sbyte> src, out Vector256<long> dst)
; location: [7FFDDBA1D4F0h, 7FFDDBA1D508h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxbq ymm0,xmm0           ; VPMOVSXBQ(VEX_Vpmovsxbq_ymm_xmmm32) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 22 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8i_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x22,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<short> vconvert_128x8u_to_256x16i(Vector128<byte> src, out Vector256<short> dst)
; location: [7FFDDBA1D520h, 7FFDDBA1D538h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x16iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ushort> vconvert_128x8u_to_256x16u(Vector128<byte> src, out Vector256<ushort> dst)
; location: [7FFDDBA1D550h, 7FFDDBA1D568h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x8u_to_256x32i(Vector128<byte> src, out Vector256<int> dst)
; location: [7FFDDBA1D580h, 7FFDDBA1D598h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x31,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<uint> vconvert_128x8u_to_256x32u(Vector128<byte> src, out Vector256<uint> dst)
; location: [7FFDDBA1D5B0h, 7FFDDBA1D5C8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x31,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x8u_to_256x64i(Vector128<byte> src, out Vector256<long> dst)
; location: [7FFDDBA1D5E0h, 7FFDDBA1D5F8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq ymm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_ymm_xmmm32) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 32 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x32,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vconvert_128x8u_to_256x64u(Vector128<byte> src, out Vector256<ulong> dst)
; location: [7FFDDBA1D610h, 7FFDDBA1D628h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxbq ymm0,xmm0           ; VPMOVZXBQ(VEX_Vpmovzxbq_ymm_xmmm32) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 32 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_to_256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x32,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x16i_to_256x32i(Vector128<short> src, out Vector256<int> dst)
; location: [7FFDDBA1D640h, 7FFDDBA1D658h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwd ymm0,xmm0           ; VPMOVSXWD(VEX_Vpmovsxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 23 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x23,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x16i_to_256x64i(Vector128<short> src, out Vector256<long> dst)
; location: [7FFDDBA1D670h, 7FFDDBA1D688h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxwq ymm0,xmm0           ; VPMOVSXWQ(VEX_Vpmovsxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 24 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16i_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x24,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<int> vconvert_128x16u_to_256x32i(Vector128<ushort> src, out Vector256<int> dst)
; location: [7FFDDBA1D6A0h, 7FFDDBA1D6B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x32iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<uint> vconvert_128x16u_to_256x32u(Vector128<ushort> src, out Vector256<uint> dst)
; location: [7FFDDBA1D6D0h, 7FFDDBA1D6E8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwd ymm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 33 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x32uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x16u_to_256x64i(Vector128<ushort> src, out Vector256<long> dst)
; location: [7FFDDBA1D700h, 7FFDDBA1D718h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq ymm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x34,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vconvert_128x16u_to_256x64u(Vector128<ushort> src, out Vector256<ulong> dst)
; location: [7FFDDBA1D730h, 7FFDDBA1D748h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxwq ymm0,xmm0           ; VPMOVZXWQ(VEX_Vpmovzxwq_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 34 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x16u_to_256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x34,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x32i_to_256x64i(Vector128<int> src, out Vector256<long> dst)
; location: [7FFDDBA1D760h, 7FFDDBA1D778h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovsxdq ymm0,xmm0           ; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 25 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32i_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x25,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<long> vconvert_128x32u_to_256x64i(Vector128<uint> src, out Vector256<long> dst)
; location: [7FFDDBA1D790h, 7FFDDBA1D7A8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq ymm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 35 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_256x64iBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x35,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Vector256<ulong> vconvert_128x32u_to_256x64u(Vector128<uint> src, out Vector256<ulong> dst)
; location: [7FFDDBA1D7C0h, 7FFDDBA1D7D8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpmovzxdq ymm0,xmm0           ; VPMOVZXDQ(VEX_Vpmovzxdq_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 35 c0
000eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0012h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x32u_to_256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x35,0xC0,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void avxpack(ref uint src, ref uint dst)
; location: [7FFDDBA1DC00h, 7FFDDBA1E200h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,0E8h                  ; SUB(Sub_rm64_imm32) [RSP,e8h:imm64]                  encoding(7 bytes) = 48 81 ec e8 00 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch vmovaps [rsp+0D0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 d0 00 00 00
0015h vmovaps [rsp+0C0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 c0 00 00 00
001eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0021h mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
0024h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0028h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0031h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0034h vlddqu ymm0,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 01
0038h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0041h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
004ah lea rcx,[rsi+4]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 04
004eh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0052h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0057h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
005bh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
005fh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0063h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
006ch vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0075h lea rcx,[rsi+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 08
0079h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
007dh mov ecx,2                     ; MOV(Mov_r32_imm32) [ECX,2h:imm32]                    encoding(5 bytes) = b9 02 00 00 00
0082h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0086h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
008ah vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
008eh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0097h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
00a0h lea rcx,[rsi+0Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 0c
00a4h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
00a8h mov ecx,3                     ; MOV(Mov_r32_imm32) [ECX,3h:imm32]                    encoding(5 bytes) = b9 03 00 00 00
00adh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
00b1h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
00b5h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
00b9h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
00c2h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
00cbh lea rcx,[rsi+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 10
00cfh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
00d3h mov ecx,4                     ; MOV(Mov_r32_imm32) [ECX,4h:imm32]                    encoding(5 bytes) = b9 04 00 00 00
00d8h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
00dch vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
00e0h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
00e4h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
00edh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
00f6h lea rcx,[rsi+14h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 14
00fah vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
00feh mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0103h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0107h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
010bh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
010fh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0118h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0121h lea rcx,[rsi+18h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 18
0125h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0129h mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
012eh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0132h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0136h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
013ah vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0143h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
014ch lea rcx,[rsi+1Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 1c
0150h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0154h mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0159h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
015dh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0161h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0165h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
016eh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0177h lea rcx,[rsi+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 20
017bh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
017fh mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0184h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0188h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
018ch vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0190h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0199h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
01a2h lea rcx,[rsi+24h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 24
01a6h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
01aah mov ecx,9                     ; MOV(Mov_r32_imm32) [ECX,9h:imm32]                    encoding(5 bytes) = b9 09 00 00 00
01afh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
01b3h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
01b7h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
01bbh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
01c4h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
01cdh lea rcx,[rsi+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 28
01d1h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
01d5h mov ecx,0Ah                   ; MOV(Mov_r32_imm32) [ECX,ah:imm32]                    encoding(5 bytes) = b9 0a 00 00 00
01dah vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
01deh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
01e2h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
01e6h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
01efh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
01f8h lea rcx,[rsi+2Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 2c
01fch vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0200h mov ecx,0Bh                   ; MOV(Mov_r32_imm32) [ECX,bh:imm32]                    encoding(5 bytes) = b9 0b 00 00 00
0205h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0209h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
020dh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0211h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
021ah vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0223h lea rcx,[rsi+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 30
0227h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
022bh mov ecx,0Ch                   ; MOV(Mov_r32_imm32) [ECX,ch:imm32]                    encoding(5 bytes) = b9 0c 00 00 00
0230h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0234h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0238h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
023ch vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0245h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
024eh lea rcx,[rsi+34h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 34
0252h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0256h mov ecx,0Dh                   ; MOV(Mov_r32_imm32) [ECX,dh:imm32]                    encoding(5 bytes) = b9 0d 00 00 00
025bh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
025fh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0263h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0267h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0270h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0279h lea rcx,[rsi+38h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 38
027dh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0281h mov ecx,0Eh                   ; MOV(Mov_r32_imm32) [ECX,eh:imm32]                    encoding(5 bytes) = b9 0e 00 00 00
0286h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
028ah vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
028eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0292h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
029bh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
02a4h lea rcx,[rsi+3Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 3c
02a8h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
02ach mov ecx,0Fh                   ; MOV(Mov_r32_imm32) [ECX,fh:imm32]                    encoding(5 bytes) = b9 0f 00 00 00
02b1h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
02b5h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
02b9h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
02bdh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
02c6h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
02cfh lea rcx,[rsi+40h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 40
02d3h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
02d7h mov ecx,10h                   ; MOV(Mov_r32_imm32) [ECX,10h:imm32]                   encoding(5 bytes) = b9 10 00 00 00
02dch vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
02e0h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
02e4h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
02e8h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
02f1h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
02fah lea rcx,[rsi+44h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 44
02feh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0302h mov ecx,11h                   ; MOV(Mov_r32_imm32) [ECX,11h:imm32]                   encoding(5 bytes) = b9 11 00 00 00
0307h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
030bh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
030fh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0313h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
031ch vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0325h lea rcx,[rsi+48h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 48
0329h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
032dh mov ecx,12h                   ; MOV(Mov_r32_imm32) [ECX,12h:imm32]                   encoding(5 bytes) = b9 12 00 00 00
0332h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0336h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
033ah vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
033eh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0347h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0350h lea rcx,[rsi+4Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 4c
0354h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0358h mov ecx,13h                   ; MOV(Mov_r32_imm32) [ECX,13h:imm32]                   encoding(5 bytes) = b9 13 00 00 00
035dh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0361h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0365h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0369h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0372h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
037bh lea rcx,[rsi+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 50
037fh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0383h mov ecx,14h                   ; MOV(Mov_r32_imm32) [ECX,14h:imm32]                   encoding(5 bytes) = b9 14 00 00 00
0388h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
038ch vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0390h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0394h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
039dh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
03a6h lea rcx,[rsi+54h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 54
03aah vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
03aeh mov ecx,15h                   ; MOV(Mov_r32_imm32) [ECX,15h:imm32]                   encoding(5 bytes) = b9 15 00 00 00
03b3h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
03b7h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
03bbh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
03bfh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
03c8h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
03d1h lea rcx,[rsi+58h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 58
03d5h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
03d9h mov ecx,16h                   ; MOV(Mov_r32_imm32) [ECX,16h:imm32]                   encoding(5 bytes) = b9 16 00 00 00
03deh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
03e2h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
03e6h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
03eah vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
03f3h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
03fch lea rcx,[rsi+5Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 5c
0400h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0404h mov ecx,17h                   ; MOV(Mov_r32_imm32) [ECX,17h:imm32]                   encoding(5 bytes) = b9 17 00 00 00
0409h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
040dh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0411h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0415h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
041eh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0427h lea rcx,[rsi+60h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 60
042bh vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
042fh mov ecx,18h                   ; MOV(Mov_r32_imm32) [ECX,18h:imm32]                   encoding(5 bytes) = b9 18 00 00 00
0434h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0438h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
043ch vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0440h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0449h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0452h lea rcx,[rsi+64h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 64
0456h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
045ah mov ecx,19h                   ; MOV(Mov_r32_imm32) [ECX,19h:imm32]                   encoding(5 bytes) = b9 19 00 00 00
045fh vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
0463h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0467h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
046bh vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
0474h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
047dh lea rcx,[rsi+68h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 68
0481h vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
0485h mov ecx,1Ah                   ; MOV(Mov_r32_imm32) [ECX,1ah:imm32]                   encoding(5 bytes) = b9 1a 00 00 00
048ah vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
048eh vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
0492h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0496h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
049fh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
04a8h lea rcx,[rsi+6Ch]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 6c
04ach vlddqu ymm1,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM1,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 09
04b0h mov ecx,1Bh                   ; MOV(Mov_r32_imm32) [ECX,1bh:imm32]                   encoding(5 bytes) = b9 1b 00 00 00
04b5h vmovd xmm2,ecx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,ECX]                 encoding(VEX, 4 bytes) = c5 f9 6e d1
04b9h vpslld ymm1,ymm1,xmm2         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 f2 ca
04bdh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
04c1h vmovupd [rsp+0A0h],ymm0       ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 9 bytes) = c5 fd 11 84 24 a0 00 00 00
04cah vmovupd ymm6,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM6,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 b4 24 a0 00 00 00
04d3h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
04d7h vmovupd [rsp+60h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 60
04ddh lea rcx,[rsi+70h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(4 bytes) = 48 8d 4e 70
04e1h lea rdx,[rsp+60h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 60
04e6h vextractf128 xmm7,ymm6,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM7,YMM6,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 f7 01
04ech call 7FFDDBA1CE20h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF220h:jmp64]        encoding(5 bytes) = e8 2f ed ff ff
04f1h vmovupd ymm0,[rsp+60h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 60
04f7h lea rcx,[rsp+80h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 80 00 00 00
04ffh vmovupd [rsp+40h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
0505h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
050ah mov r8d,1Ch                   ; MOV(Mov_r32_imm32) [R8D,1ch:imm32]                   encoding(6 bytes) = 41 b8 1c 00 00 00
0510h call 7FFDDB41EE08h            ; CALL(Call_rel32_64) [FFFFFFFFFFA01208h:jmp64]        encoding(5 bytes) = e8 f3 0c a0 ff
0515h lea rcx,[rsp+0A0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 a0 00 00 00
051dh vinsertf128 ymm6,ymm6,xmm7,1  ; VINSERTF128(VEX_Vinsertf128_ymm_ymm_xmmm128_imm8) [YMM6,YMM6,XMM7,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 4d 18 f7 01
0523h vmovupd [rsp+40h],ymm6        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM6] encoding(VEX, 6 bytes) = c5 fd 11 74 24 40
0529h vmovupd ymm0,[rsp+80h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 80 00 00 00
0532h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0538h lea rdx,[rsp+40h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 40
053dh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0542h call 7FFDDB41ED88h            ; CALL(Call_rel32_64) [FFFFFFFFFFA01188h:jmp64]        encoding(5 bytes) = e8 41 0c a0 ff
0547h lea rcx,[rsp+0A0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 a0 00 00 00
054fh vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0558h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
055eh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0563h mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
0566h mov r9d,1Dh                   ; MOV(Mov_r32_imm32) [R9D,1dh:imm32]                   encoding(6 bytes) = 41 b9 1d 00 00 00
056ch call 7FFDDBA1CD20h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF120h:jmp64]        encoding(5 bytes) = e8 af eb ff ff
0571h lea rcx,[rsp+0A0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 a0 00 00 00
0579h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
0582h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0588h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
058dh mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
0590h mov r9d,1Eh                   ; MOV(Mov_r32_imm32) [R9D,1eh:imm32]                   encoding(6 bytes) = 41 b9 1e 00 00 00
0596h call 7FFDDBA1CD20h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF120h:jmp64]        encoding(5 bytes) = e8 85 eb ff ff
059bh lea rcx,[rsp+0A0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 a0 00 00 00
05a3h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
05ach vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
05b2h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
05b7h mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
05bah mov r9d,1Fh                   ; MOV(Mov_r32_imm32) [R9D,1fh:imm32]                   encoding(6 bytes) = 41 b9 1f 00 00 00
05c0h call 7FFDDBA1CD20h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF120h:jmp64]        encoding(5 bytes) = e8 5b eb ff ff
05c5h vmovupd ymm0,[rsp+0A0h]       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fd 10 84 24 a0 00 00 00
05ceh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
05d4h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
05d9h mov rdx,rdi                   ; MOV(Mov_r64_rm64) [RDX,RDI]                          encoding(3 bytes) = 48 8b d7
05dch call 7FFDDBA1CD50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF150h:jmp64]        encoding(5 bytes) = e8 6f eb ff ff
05e1h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
05e2h vmovaps xmm6,[rsp+0D0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 d0 00 00 00
05ebh vmovaps xmm7,[rsp+0C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 c0 00 00 00
05f4h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
05f7h add rsp,0E8h                  ; ADD(Add_rm64_imm32) [RSP,e8h:imm64]                  encoding(7 bytes) = 48 81 c4 e8 00 00 00
05feh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
05ffh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0600h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avxpackBytes => new byte[1537]{0x57,0x56,0x48,0x81,0xEC,0xE8,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xC0,0x00,0x00,0x00,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8B,0xCE,0xC5,0xFF,0xF0,0x01,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x04,0xC5,0xFF,0xF0,0x09,0xB9,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x08,0xC5,0xFF,0xF0,0x09,0xB9,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x0C,0xC5,0xFF,0xF0,0x09,0xB9,0x03,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x10,0xC5,0xFF,0xF0,0x09,0xB9,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x14,0xC5,0xFF,0xF0,0x09,0xB9,0x05,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x18,0xC5,0xFF,0xF0,0x09,0xB9,0x06,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x1C,0xC5,0xFF,0xF0,0x09,0xB9,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x20,0xC5,0xFF,0xF0,0x09,0xB9,0x08,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x24,0xC5,0xFF,0xF0,0x09,0xB9,0x09,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x28,0xC5,0xFF,0xF0,0x09,0xB9,0x0A,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x2C,0xC5,0xFF,0xF0,0x09,0xB9,0x0B,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x30,0xC5,0xFF,0xF0,0x09,0xB9,0x0C,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x34,0xC5,0xFF,0xF0,0x09,0xB9,0x0D,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x38,0xC5,0xFF,0xF0,0x09,0xB9,0x0E,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x3C,0xC5,0xFF,0xF0,0x09,0xB9,0x0F,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x40,0xC5,0xFF,0xF0,0x09,0xB9,0x10,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x44,0xC5,0xFF,0xF0,0x09,0xB9,0x11,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x48,0xC5,0xFF,0xF0,0x09,0xB9,0x12,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x4C,0xC5,0xFF,0xF0,0x09,0xB9,0x13,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x50,0xC5,0xFF,0xF0,0x09,0xB9,0x14,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x54,0xC5,0xFF,0xF0,0x09,0xB9,0x15,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x58,0xC5,0xFF,0xF0,0x09,0xB9,0x16,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x5C,0xC5,0xFF,0xF0,0x09,0xB9,0x17,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x60,0xC5,0xFF,0xF0,0x09,0xB9,0x18,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x64,0xC5,0xFF,0xF0,0x09,0xB9,0x19,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x68,0xC5,0xFF,0xF0,0x09,0xB9,0x1A,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8D,0x4E,0x6C,0xC5,0xFF,0xF0,0x09,0xB9,0x1B,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD1,0xC5,0xF5,0xF2,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0xB4,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x60,0x48,0x8D,0x4E,0x70,0x48,0x8D,0x54,0x24,0x60,0xC4,0xE3,0x7D,0x19,0xF7,0x01,0xE8,0x2F,0xED,0xFF,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x60,0x48,0x8D,0x8C,0x24,0x80,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x40,0x41,0xB8,0x1C,0x00,0x00,0x00,0xE8,0xF3,0x0C,0xA0,0xFF,0x48,0x8D,0x8C,0x24,0xA0,0x00,0x00,0x00,0xC4,0xE3,0x4D,0x18,0xF7,0x01,0xC5,0xFD,0x11,0x74,0x24,0x40,0xC5,0xFD,0x10,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x40,0x4C,0x8D,0x44,0x24,0x20,0xE8,0x41,0x0C,0xA0,0xFF,0x48,0x8D,0x8C,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x4C,0x8B,0xC6,0x41,0xB9,0x1D,0x00,0x00,0x00,0xE8,0xAF,0xEB,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x4C,0x8B,0xC6,0x41,0xB9,0x1E,0x00,0x00,0x00,0xE8,0x85,0xEB,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x4C,0x8B,0xC6,0x41,0xB9,0x1F,0x00,0x00,0x00,0xE8,0x5B,0xEB,0xFF,0xFF,0xC5,0xFD,0x10,0x84,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0x48,0x8D,0x4C,0x24,0x20,0x48,0x8B,0xD7,0xE8,0x6F,0xEB,0xFF,0xFF,0x90,0xC5,0xF8,0x28,0xB4,0x24,0xD0,0x00,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xC0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xE8,0x00,0x00,0x00,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum_256x64u(Vector256<ulong> src)
; location: [7FFDDBA1E2E0h, 7FFDDBA1E319h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0016h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
001ch add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
001fh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0025h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
002ah vpextrq rcx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RCX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c1 01
0030h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0033h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0036h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sum_256x64uBytes => new byte[58]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x48,0x03,0xD0,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC1,0x01,0x48,0x03,0xC2,0x48,0x03,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sum_256x64u(Vector128<ulong> src)
; location: [7FFDDBA1E330h, 7FFDDBA1E347h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
0014h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sum_256x64uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong avxpop_csa(in ulong src)
; location: [7FFDDBA1E360h, 7FFDDBA1E3F0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0014h lea rax,[rcx+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 20
0018h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
001ch vmovaps ymm4,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 e0
0020h vmovaps ymm5,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 ea
0024h vpxor ymm4,ymm4,ymm5          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]    encoding(VEX, 4 bytes) = c5 dd ef e5
0028h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
002ch vmovaps ymm2,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 d4
0030h vmovaps ymm5,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM5,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 eb
0034h vpand ymm2,ymm2,ymm5          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM5]    encoding(VEX, 4 bytes) = c5 ed db d5
0038h vpor ymm0,ymm0,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]      encoding(VEX, 4 bytes) = c5 fd eb c2
003ch vpxor ymm2,ymm4,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM4,YMM3]    encoding(VEX, 4 bytes) = c5 dd ef d3
0040h lea rax,[rcx+40h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 40
0044h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0048h add rcx,60h                   ; ADD(Add_rm64_imm8) [RCX,60h:imm64]                   encoding(4 bytes) = 48 83 c1 60
004ch vlddqu ymm4,ymmword ptr [rcx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 21
0050h vpxor ymm0,ymm0,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3]    encoding(VEX, 4 bytes) = c5 fd ef c3
0054h vpxor ymm0,ymm0,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4]    encoding(VEX, 4 bytes) = c5 fd ef c4
0058h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
005ch vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0060h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0064h vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0069h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
006dh vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
0073h add rdx,rax                   ; ADD(Add_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 03 d0
0076h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
007ch vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0081h vpextrq rcx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RCX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c1 01
0087h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
008ah add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
008dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0090h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> avxpop_csaBytes => new byte[145]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0x48,0x8B,0xC1,0xC5,0xFF,0xF0,0x10,0x48,0x8D,0x41,0x20,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE0,0xC5,0xFC,0x28,0xEA,0xC5,0xDD,0xEF,0xE5,0xC5,0xFD,0xDB,0xC2,0xC5,0xFC,0x28,0xD4,0xC5,0xFC,0x28,0xEB,0xC5,0xED,0xDB,0xD5,0xC5,0xFD,0xEB,0xC2,0xC5,0xDD,0xEF,0xD3,0x48,0x8D,0x41,0x40,0xC5,0xFF,0xF0,0x18,0x48,0x83,0xC1,0x60,0xC5,0xFF,0xF0,0x21,0xC5,0xFD,0xEF,0xC3,0xC5,0xFD,0xEF,0xC4,0xC5,0xF5,0xEF,0xCA,0xC5,0xF5,0xEF,0xC0,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x48,0x03,0xD0,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC1,0x01,0x48,0x03,0xC2,0x48,0x03,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pop64_scalar(ulong a, ulong b, ulong c, ulong d)
; location: [7FFDDBA1E420h, 7FFDDBA1E448h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001bh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
001eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0020h popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0025h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop64_scalarBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x48,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x48,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x48,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pop64_vector(Vector256<ulong> x)
; location: [7FFDDBA1E460h, 7FFDDBA1E4B2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0016h vpextrq rdx,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 ca 01
001ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
001eh popcnt rcx,rax                ; POPCNT(Popcnt_r64_rm64) [RCX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c8
0023h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0026h popcnt r8,rdx                 ; POPCNT(Popcnt_r64_rm64) [R8,RDX]                     encoding(5 bytes) = f3 4c 0f b8 c2
002bh add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
002eh vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
0034h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0039h vpextrq rdx,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RDX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c2 01
003fh popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
0044h add rax,rcx                   ; ADD(Add_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 03 c1
0047h popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
004ch add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
004fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop64_vectorBytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0x33,0xC9,0xF3,0x48,0x0F,0xB8,0xC8,0x45,0x33,0xC0,0xF3,0x4C,0x0F,0xB8,0xC2,0x49,0x03,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xF3,0x48,0x0F,0xB8,0xC0,0x48,0x03,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x48,0x03,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vcsa_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, out Vector256<ulong> lo, out Vector256<ulong> hi)
; location: [7FFDDBA1E4D0h, 7FFDDBA1E517h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
000dh vmovupd ymm2,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM2,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 10
0012h vmovaps ymm3,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d8
0016h vmovaps ymm4,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 e1
001ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
001eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0022h vmovaps ymm1,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 cb
0026h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
002ah vpand ymm1,ymm1,ymm4          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4]    encoding(VEX, 4 bytes) = c5 f5 db cc
002eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0032h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
0037h vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
003bh vpxor ymm0,ymm3,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM2]    encoding(VEX, 4 bytes) = c5 e5 ef c2
003fh vmovupd [r9],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R9:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 01
0044h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcsa_256x64uBytes => new byte[72]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC4,0xC1,0x7D,0x10,0x10,0xC5,0xFC,0x28,0xD8,0xC5,0xFC,0x28,0xE1,0xC5,0xE5,0xEF,0xDC,0xC5,0xFD,0xDB,0xC1,0xC5,0xFC,0x28,0xCB,0xC5,0xFC,0x28,0xE2,0xC5,0xF5,0xDB,0xCC,0xC5,0xFD,0xEB,0xC1,0x48,0x8B,0x44,0x24,0x28,0xC5,0xFD,0x11,0x00,0xC5,0xE5,0xEF,0xC2,0xC4,0xC1,0x7D,0x11,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void csa_64u(ulong a, ulong b, ulong c, out ulong lo, out ulong hi)
; location: [7FFDDBA1E940h, 7FFDDBA1E965h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0011h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0014h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0017h mov rcx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 28
001ch mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
001fh xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0022h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 01
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> csa_64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0x48,0x23,0xD1,0x48,0x8B,0xC8,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0x4C,0x24,0x28,0x48,0x89,0x11,0x49,0x33,0xC0,0x49,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
; location: [7FFDDBA1E980h, 7FFDDBA1E9E1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
000dh vmovupd xmm2,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 12
0011h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0015h vshufps xmm1,xmm1,xmm3,44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,44h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb 44
001ah vshufps xmm0,xmm0,xmm2,0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,eeh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 ee
001fh vmovupd xmm2,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 10
0024h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0028h vmovupd xmm4,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM4,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 21
002dh vmovaps xmm5,xmm4             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM5,XMM4]         encoding(VEX, 4 bytes) = c5 f8 28 ec
0031h vshufps xmm3,xmm3,xmm5,44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM3,XMM3,XMM5,44h:imm8] encoding(VEX, 5 bytes) = c5 e0 c6 dd 44
0036h vshufps xmm2,xmm2,xmm4,0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM2,XMM2,XMM4,eeh:imm8] encoding(VEX, 5 bytes) = c5 e8 c6 d4 ee
003bh vshufps xmm4,xmm1,xmm3,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM4,XMM1,XMM3,88h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 e3 88
0040h vmovupd [rcx],xmm4            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM4] encoding(VEX, 4 bytes) = c5 f9 11 21
0044h vshufps xmm1,xmm1,xmm3,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,ddh:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb dd
0049h vmovupd [rdx],xmm1            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 0a
004dh vshufps xmm1,xmm0,xmm2,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM0,XMM2,88h:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 ca 88
0052h vmovupd [r8],xmm1             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R8:br,DS:sr),XMM1] encoding(VEX, 5 bytes) = c4 c1 79 11 08
0057h vshufps xmm0,xmm0,xmm2,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,ddh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 dd
005ch vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtransposeBytes => new byte[98]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF0,0xC6,0xCB,0x44,0xC5,0xF8,0xC6,0xC2,0xEE,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF8,0x28,0xDA,0xC4,0xC1,0x79,0x10,0x21,0xC5,0xF8,0x28,0xEC,0xC5,0xE0,0xC6,0xDD,0x44,0xC5,0xE8,0xC6,0xD4,0xEE,0xC5,0xF0,0xC6,0xE3,0x88,0xC5,0xF9,0x11,0x21,0xC5,0xF0,0xC6,0xCB,0xDD,0xC5,0xF9,0x11,0x0A,0xC5,0xF8,0xC6,0xCA,0x88,0xC4,0xC1,0x79,0x11,0x08,0xC5,0xF8,0xC6,0xC2,0xDD,0xC4,0xC1,0x79,0x11,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vtranspose(ref Vector128<float> row0, ref Vector128<float> row1, ref Vector128<float> row2, ref Vector128<float> row3)
; location: [7FFDDBA1EA10h, 7FFDDBA1EA63h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vshufps xmm0,xmm0,[rdx],44h   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,mem(Packed128_Float32,RDX:br,DS:sr),44h:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 02 44
000eh vmovupd xmm1,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 09
0012h vshufps xmm1,xmm1,[rdx],0EEh  ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,mem(Packed128_Float32,RDX:br,DS:sr),eeh:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 0a ee
0017h vmovupd xmm2,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 10
001ch vshufps xmm2,xmm2,[r9],44h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM2,XMM2,mem(Packed128_Float32,R9:br,DS:sr),44h:imm8] encoding(VEX, 6 bytes) = c4 c1 68 c6 11 44
0022h vmovupd xmm3,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM3,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 18
0027h vshufps xmm3,xmm3,[r9],0EEh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM3,XMM3,mem(Packed128_Float32,R9:br,DS:sr),eeh:imm8] encoding(VEX, 6 bytes) = c4 c1 60 c6 19 ee
002dh vshufps xmm4,xmm0,xmm2,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM4,XMM0,XMM2,88h:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 e2 88
0032h vmovupd [rcx],xmm4            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM4] encoding(VEX, 4 bytes) = c5 f9 11 21
0036h vshufps xmm0,xmm0,xmm2,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,ddh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 dd
003bh vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
003fh vshufps xmm0,xmm1,xmm3,88h    ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM1,XMM3,88h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 c3 88
0044h vmovupd [r8],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 00
0049h vshufps xmm0,xmm1,xmm3,0DDh   ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM1,XMM3,ddh:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 c3 dd
004eh vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vtransposeBytes => new byte[84]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0xC6,0x02,0x44,0xC5,0xF9,0x10,0x09,0xC5,0xF0,0xC6,0x0A,0xEE,0xC4,0xC1,0x79,0x10,0x10,0xC4,0xC1,0x68,0xC6,0x11,0x44,0xC4,0xC1,0x79,0x10,0x18,0xC4,0xC1,0x60,0xC6,0x19,0xEE,0xC5,0xF8,0xC6,0xE2,0x88,0xC5,0xF9,0x11,0x21,0xC5,0xF8,0xC6,0xC2,0xDD,0xC5,0xF9,0x11,0x02,0xC5,0xF0,0xC6,0xC3,0x88,0xC4,0xC1,0x79,0x11,0x00,0xC5,0xF0,0xC6,0xC3,0xDD,0xC4,0xC1,0x79,0x11,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vextract_128x8u_0(Vector128<byte> src)
; location: [7FFDDBA1EA80h, 7FFDDBA1EA8Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrb eax,xmm0,0            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x8u_0Bytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_128x64u_0(Vector128<ulong> src)
; location: [7FFDDBA1EAB0h, 7FFDDBA1EABEh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x64u_0Bytes => new byte[15]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_128x64u_1(Vector128<ulong> src)
; location: [7FFDDBA1EAD0h, 7FFDDBA1EADFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x64u_1Bytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vextract_128x64u_all(Vector128<ulong> src, out ulong x0, out ulong x1)
; location: [7FFDDBA1EB00h, 7FFDDBA1EB1Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0011h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x64u_allBytes => new byte[31]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vextract_128x64u_all_2(Vector128<ulong> src, ref ulong dst)
; location: [7FFDDBA1EB40h, 7FFDDBA1EB62h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0011h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0015h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0019h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x64u_all_2Bytes => new byte[35]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0x48,0x83,0xC2,0x08,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vextract_128x64u_all_3(Vector128<ulong> src, out ulong x0, out ulong x1)
; location: [7FFDDBA1EB80h, 7FFDDBA1EB9Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vpextrq rax,xmm0,0            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 00
000fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0012h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0016h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001ch mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x64u_all_3Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x00,0x48,0x89,0x02,0xC5,0xF9,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vextract_128x64u_all_4(Vector128<ulong> src, ref ulong dst)
; location: [7FFDDBA1EBC0h, 7FFDDBA1EBCDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_128x64u_all_4Bytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vextract_256x8u_0(Vector256<byte> src)
; location: [7FFDDBA1EBE0h, 7FFDDBA1EBF2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrb eax,xmm0,0            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 00
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x8u_0Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vextract_256x8u_1(Vector256<byte> src)
; location: [7FFDDBA1EC10h, 7FFDDBA1EC22h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrb eax,xmm0,1            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x8u_1Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte vextract_256x8u_2(Vector256<byte> src)
; location: [7FFDDBA1EC40h, 7FFDDBA1EC52h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrb eax,xmm0,2            ; VPEXTRB(VEX_Vpextrb_r32m8_xmm_imm8) [EAX,XMM0,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 14 c0 02
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x8u_2Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x14,0xC0,0x02,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vextract_256x32u_0(Vector256<uint> src)
; location: [7FFDDBA1EC70h, 7FFDDBA1EC80h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovd eax,xmm0                ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]                 encoding(VEX, 4 bytes) = c5 f9 7e c0
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x32u_0Bytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vextract_256x32u_1(Vector256<uint> src)
; location: [7FFDDBA1ECA0h, 7FFDDBA1ECB2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,1            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x32u_1Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_256x32u_2(Vector256<uint> src)
; location: [7FFDDBA1ECD0h, 7FFDDBA1ECE4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,2            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 02
000fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0011h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x32u_2Bytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x02,0x8B,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vextract_256x32u_3(Vector256<uint> src)
; location: [7FFDDBA1ED00h, 7FFDDBA1ED12h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrd eax,xmm0,3            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EAX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c0 03
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x32u_3Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x79,0x16,0xC0,0x03,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
; location: [7FFDDBA1ED30h, 7FFDDBA1ED51h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x8u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
; location: [7FFDDBA1ED70h, 7FFDDBA1ED95h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x8u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; location: [7FFDDBA1EDB0h, 7FFDDBA1EDD1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x64u_outBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; location: [7FFDDBA1EDF0h, 7FFDDBA1EE15h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
000dh vmovq rax,xmm1                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM1]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c8
0012h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0015h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001bh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vlo_256x64u_pairBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE1,0xF9,0x7E,0xC8,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
; location: [7FFDDBA1EE30h, 7FFDDBA1EE53h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
0020h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vhi_256x64u_outBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x49,0x89,0x00,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
; location: [7FFDDBA1EE70h, 7FFDDBA1EE97h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0017h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001dh mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 42 08
0021h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0024h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vhi_256x64u_pairBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x89,0x02,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0x48,0x89,0x42,0x08,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_256x64u_0(Vector256<ulong> src)
; location: [7FFDDBA1EEB0h, 7FFDDBA1EEC1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
000eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x64u_0Bytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_256x64u_1(Vector256<ulong> src)
; location: [7FFDDBA1EEE0h, 7FFDDBA1EEF2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
000fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x64u_1Bytes => new byte[19]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_256x64u_2(Vector256<ulong> src)
; location: [7FFDDBA1EF10h, 7FFDDBA1EF27h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
0014h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x64u_2Bytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE1,0xF9,0x7E,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong vextract_256x64u_3(Vector256<ulong> src)
; location: [7FFDDBA1EF40h, 7FFDDBA1EF58h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 01
0009h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
000fh vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vextract_256x64u_3Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x01,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; location: [7FFDDBA1EF70h, 7FFDDBA1EF8Ah]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; location: [7FFDDBA1EFA0h, 7FFDDBA1EFBAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_128x8iBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; location: [7FFDDBA1EFD0h, 7FFDDBA1EFEDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; location: [7FFDDBA1F000h, 7FFDDBA1F01Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vshuffle_256x8iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_8u(int partcount, int partwidth, in byte a, in byte b, ref byte z)
; location: [7FFDDBAA0480h, 7FFDDBAA04F8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 006eh               ; JLE(Jle_rel8_64) [6Eh:jmp64]                         encoding(2 bytes) = 7e 52
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 3c 30
0023h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,DS:sr)]        encoding(4 bytes) = 49 8d 1c 31
0027h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002bh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0031h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0035h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003ah vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
003eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0044h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
0048h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
004dh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0053h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0058h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
005ch add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
005fh vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0063h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0066h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
0069h cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006ch jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c ae
006eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0071h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0075h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0076h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0077h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0078h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_8uBytes => new byte[121]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x52,0x49,0x63,0xF3,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAE,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_16u(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
; location: [7FFDDBAA0520h, 7FFDDBAA059Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0071h               ; JLE(Jle_rel8_64) [71h:jmp64]                         encoding(2 bytes) = 7e 55
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,1                     ; SHL(Shl_rm64_1) [RSI,1h:imm8]                        encoding(3 bytes) = 48 d1 e6
0022h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 3c 30
0026h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,DS:sr)]        encoding(4 bytes) = 49 8d 1c 31
002ah vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002eh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0034h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0038h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003dh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0041h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0047h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004bh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0050h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0056h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
005fh add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0062h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0066h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0069h add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006ch cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
006fh jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c ab
0071h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0074h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0078h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0079h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_16uBytes => new byte[124]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x55,0x49,0x63,0xF3,0x48,0xD1,0xE6,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAB,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_32u(int partcount, int partwidth, in uint a, in uint b, ref uint z)
; location: [7FFDDBAA09D0h, 7FFDDBAA0A4Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0072h               ; JLE(Jle_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 7e 56
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,2                     ; SHL(Shl_rm64_imm8) [RSI,2h:imm8]                     encoding(4 bytes) = 48 c1 e6 02
0023h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 3c 30
0027h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,DS:sr)]        encoding(4 bytes) = 49 8d 1c 31
002bh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002fh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0035h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0039h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003eh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0042h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0048h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004ch vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0051h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0057h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0060h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0063h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0067h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
006ah add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006dh cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0070h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c aa
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0079h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_32uBytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x02,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void gparts_xor_64u(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
; location: [7FFDDBAA0A80h, 7FFDDBAA0AFCh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rax,[rsp+80h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 80 00 00 00
0012h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0015h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0018h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
001ah jle short 0072h               ; JLE(Jle_rel8_64) [72h:jmp64]                         encoding(2 bytes) = 7e 56
001ch movsxd rsi,r11d               ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]                   encoding(3 bytes) = 49 63 f3
001fh shl rsi,3                     ; SHL(Shl_rm64_imm8) [RSI,3h:imm8]                     encoding(4 bytes) = 48 c1 e6 03
0023h lea rdi,[r8+rsi]              ; LEA(Lea_r64_m) [RDI,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 49 8d 3c 30
0027h lea rbx,[r9+rsi]              ; LEA(Lea_r64_m) [RBX,mem(Unknown,R9:br,DS:sr)]        encoding(4 bytes) = 49 8d 1c 31
002bh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
002fh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0035h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0039h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
003eh vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
0042h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0048h vlddqu ymm0,ymmword ptr [rbx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RBX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 03
004ch vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0051h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0057h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
005ch vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0060h add rsi,rax                   ; ADD(Add_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 03 f0
0063h vmovdqu ymmword ptr [rsi],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RSI:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 06
0067h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
006ah add r11d,edx                  ; ADD(Add_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 03 da
006dh cmp r10d,ecx                  ; CMP(Cmp_r32_rm32) [R10D,ECX]                         encoding(3 bytes) = 44 3b d1
0070h jl short 001ch                ; JL(Jl_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 7c aa
0072h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0075h add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0079h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
007bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gparts_xor_64uBytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0x84,0x24,0x80,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x85,0xC9,0x7E,0x56,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x03,0x49,0x8D,0x3C,0x30,0x49,0x8D,0x1C,0x31,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x44,0x03,0xDA,0x44,0x3B,0xD1,0x7C,0xAA,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> ones_128x8u()
; location: [7FFDDBAA0B30h, 7FFDDBAA0B48h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqb xmm0,xmm0,xmm1       ; VPCMPEQB(VEX_Vpcmpeqb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 74 c1
0011h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_128x8uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> ones_128x64u()
; location: [7FFDDBAA0B60h, 7FFDDBAA0B79h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> ones_256x8u()
; location: [7FFDDBAA0B90h, 7FFDDBAA0BABh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqb ymm0,ymm0,ymm1       ; VPCMPEQB(VEX_Vpcmpeqb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 74 c1
0011h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x8uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> ones_256x64u()
; location: [7FFDDBAA0FD0h, 7FFDDBAA0FECh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<double> ones_256x64f()
; location: [7FFDDBAA1000h, 7FFDDBAA101Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vcmpeq_uqpd ymm0,ymm0,ymm1    ; VCMPPD(VEX_Vcmppd_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,8h:imm8] encoding(VEX, 5 bytes) = c5 fd c2 c1 08
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ones_256x64fBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0xC2,0xC1,0x08,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> pattern_lanemerge_256x8u()
; location: [7FFDDBAA1440h, 7FFDDBAA146Ch]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,2DC432C0F73h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0f73h:imm64]          encoding(10 bytes) = 48 b8 73 0f 2c 43 dc 02 00 00
0011h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0015h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0019h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
001eh vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0028h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pattern_lanemerge_256x8uBytes => new byte[45]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0xB8,0x73,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFC,0x28,0xC8,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> pattern_lanemerge_256x16u()
; location: [7FFDDBAA1490h, 7FFDDBAA14BCh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,2DC432C1063h          ; MOV(Mov_r64_imm64) [RAX,2dc432c1063h:imm64]          encoding(10 bytes) = 48 b8 63 10 2c 43 dc 02 00 00
0011h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0015h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
0019h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
001eh vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0028h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pattern_lanemerge_256x16uBytes => new byte[45]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0xB8,0x63,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFC,0x28,0xC8,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<int> spec)
; location: [7FFDDBAA14E0h, 7FFDDBAA14FDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; location: [7FFDDBAA1510h, 7FFDDBAA152Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0         ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]  encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<float> vpermvar8x32_256x32f(Vector256<float> src, Vector256<int> spec)
; location: [7FFDDBAA1540h, 7FFDDBAA155Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermps ymm0,ymm1,ymm0        ; VPERMPS(VEX_Vpermps_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 16 c0
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar8x32_256x32fBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x16,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; location: [7FFDDBAA1570h, 7FFDDBAA15C0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
0018h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpaddb ymm2,ymm1,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2]  encoding(VEX, 4 bytes) = c5 f5 fc d2
0020h vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
0025h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
002bh mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
0035h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0039h vpaddb ymm1,ymm1,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3]  encoding(VEX, 4 bytes) = c5 f5 fc cb
003dh vpshufb ymm0,ymm0,ymm1        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0042h vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0046h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpermvar32x8_256x8uBytes => new byte[81]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
; location: [7FFDDBAA15E0h, 7FFDDBAA1716h]
0000h sub rsp,98h                   ; SUB(Sub_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 ec 98 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000eh vmovaps xmm1,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 c8
0012h vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0017h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001bh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
001fh vpsllw ymm0,ymm0,xmm2         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM2]  encoding(VEX, 4 bytes) = c5 fd f1 c2
0023h mov rax,2DC432C1003h          ; MOV(Mov_r64_imm64) [RAX,2dc432c1003h:imm64]          encoding(10 bytes) = 48 b8 03 10 2c 43 dc 02 00 00
002dh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0031h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0035h vmovupd [rsp+60h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 60
003bh vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
0040h mov rax,2DC432C0F73h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0f73h:imm64]          encoding(10 bytes) = 48 b8 73 0f 2c 43 dc 02 00 00
004ah vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
004eh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0052h vmovupd [rsp+40h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 40
0058h mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
0062h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
0066h vpaddb ymm2,ymm3,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]  encoding(VEX, 4 bytes) = c5 e5 fc d2
006ah vpshufb ymm2,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
006fh vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
0075h mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
007fh vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
0083h vpaddb ymm3,ymm3,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 fc dc
0087h vpshufb ymm0,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 c3
008ch vpor ymm0,ymm2,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0]      encoding(VEX, 4 bytes) = c5 ed eb c0
0090h vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0096h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
009bh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
009fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
00a1h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
00a4h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a7h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
00abh vpsrlw ymm1,ymm1,xmm2         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM1,YMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f5 d1 ca
00afh mov rax,2DC432C1003h          ; MOV(Mov_r64_imm64) [RAX,2dc432c1003h:imm64]          encoding(10 bytes) = 48 b8 03 10 2c 43 dc 02 00 00
00b9h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00bdh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
00c1h vmovupd [rsp+20h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 20
00c7h vpshufb ymm1,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 cb
00cch mov rax,2DC432C0F73h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0f73h:imm64]          encoding(10 bytes) = 48 b8 73 0f 2c 43 dc 02 00 00
00d6h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00dah vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
00deh vmovupd [rsp],ymm2            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 5 bytes) = c5 fd 11 14 24
00e3h mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
00edh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
00f1h vpaddb ymm2,ymm3,ymm2         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM3,YMM2]  encoding(VEX, 4 bytes) = c5 e5 fc d2
00f5h vpshufb ymm2,ymm1,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 00 d2
00fah vperm2i128 ymm1,ymm1,ymm1,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM1,YMM1,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 46 c9 03
0100h mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
010ah vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
010eh vpaddb ymm3,ymm3,ymm4         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]  encoding(VEX, 4 bytes) = c5 e5 fc dc
0112h vpshufb ymm1,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 cb
0117h vpor ymm1,ymm2,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]      encoding(VEX, 4 bytes) = c5 ed eb c9
011bh vextractf128 xmm1,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 00
0121h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0125h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0129h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
012ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
012fh add rsp,98h                   ; ADD(Add_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 c4 98 00 00 00
0136h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x8uBytes => new byte[311]{0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF8,0x28,0xC8,0xC4,0xE2,0x7D,0x30,0xC0,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xFD,0xF1,0xC2,0x48,0xB8,0x03,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x54,0x24,0x60,0xC4,0xE2,0x7D,0x00,0xC3,0x48,0xB8,0x73,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x54,0x24,0x40,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xE5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xE5,0xFC,0xDC,0xC4,0xE2,0x7D,0x00,0xC3,0xC5,0xED,0xEB,0xC0,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC4,0xE2,0x7D,0x30,0xC9,0x41,0x0F,0xB6,0xC0,0xF7,0xD8,0x83,0xC0,0x08,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF5,0xD1,0xCA,0x48,0xB8,0x03,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x54,0x24,0x20,0xC4,0xE2,0x75,0x00,0xCB,0x48,0xB8,0x73,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xFD,0x11,0x14,0x24,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xE5,0xFC,0xD2,0xC4,0xE2,0x75,0x00,0xD2,0xC4,0xE3,0x75,0x46,0xC9,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xC5,0xE5,0xFC,0xDC,0xC4,0xE2,0x75,0x00,0xCB,0xC5,0xED,0xEB,0xC9,0xC4,0xE3,0x7D,0x19,0xC9,0x00,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> rotl_g128x16u(Vector128<ushort> src, byte offset)
; location: [7FFDDBAA1750h, 7FFDDBAA1780h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllw xmm1,xmm0,xmm1         ; VPSLLW(VEX_Vpsllw_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f1 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlw xmm0,xmm0,xmm2         ; VPSRLW(VEX_Vpsrlw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d1 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x16uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF1,0xC9,0xF7,0xD8,0x83,0xC0,0x10,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD1,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> rotl_g128x32u(Vector128<uint> src, byte offset)
; location: [7FFDDBAA17A0h, 7FFDDBAA17D0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpslld xmm1,xmm0,xmm1         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f2 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrld xmm0,xmm0,xmm2         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d2 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x32uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF2,0xC9,0xF7,0xD8,0x83,0xC0,0x20,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD2,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
; location: [7FFDDBAA17F0h, 7FFDDBAA1820h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0011h vpsllq xmm1,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM1,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c9
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0021h vpsrlq xmm0,xmm0,xmm2         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]  encoding(VEX, 4 bytes) = c5 f9 d3 c2
0025h vpor xmm0,xmm1,xmm0           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]      encoding(VEX, 4 bytes) = c5 f1 eb c0
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g128x64uBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC9,0xF7,0xD8,0x83,0xC0,0x40,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD0,0xC5,0xF9,0xD3,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
; location: [7FFDDBAA1840h, 7FFDDBAA1A6Ch]
0000h sub rsp,98h                   ; SUB(Sub_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 ec 98 00 00 00
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah vmovaps [rsp+80h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,SS:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 80 00 00 00
0013h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0017h vmovaps ymm1,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM1,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 c8
001bh vextractf128 xmm2,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c2 00
0021h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
0026h vextractf128 xmm0,ymm0,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 01
002ch vpmovzxbw ymm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM0,XMM0]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c0
0031h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0035h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0039h vpsllw ymm2,ymm2,xmm3         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM2,YMM2,XMM3]  encoding(VEX, 4 bytes) = c5 ed f1 d3
003dh movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0041h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0045h vpsllw ymm0,ymm0,xmm3         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM0,YMM0,XMM3]  encoding(VEX, 4 bytes) = c5 fd f1 c3
0049h mov rax,2DC432C1003h          ; MOV(Mov_r64_imm64) [RAX,2dc432c1003h:imm64]          encoding(10 bytes) = 48 b8 03 10 2c 43 dc 02 00 00
0053h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0057h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
005bh vmovupd [rsp+60h],ymm3        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 6 bytes) = c5 fd 11 5c 24 60
0061h vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
0066h vpshufb ymm0,ymm0,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4] encoding(VEX, 5 bytes) = c4 e2 7d 00 c4
006bh mov rax,2DC432C0F73h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0f73h:imm64]          encoding(10 bytes) = 48 b8 73 0f 2c 43 dc 02 00 00
0075h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0079h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
007dh vmovupd [rsp+40h],ymm3        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 6 bytes) = c5 fd 11 5c 24 40
0083h vmovaps ymm3,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 dc
0087h mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
0091h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0095h vpaddb ymm5,ymm3,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5]  encoding(VEX, 4 bytes) = c5 e5 fc ed
0099h vpshufb ymm5,ymm2,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM2,YMM5] encoding(VEX, 5 bytes) = c4 e2 6d 00 ed
009eh vperm2i128 ymm2,ymm2,ymm2,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d2 03
00a4h mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
00aeh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
00b2h vpaddb ymm3,ymm3,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6]  encoding(VEX, 4 bytes) = c5 e5 fc de
00b6h vpshufb ymm2,ymm2,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 00 d3
00bbh vpor ymm2,ymm5,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM5,YMM2]      encoding(VEX, 4 bytes) = c5 d5 eb d2
00bfh mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
00c9h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
00cdh vpaddb ymm3,ymm4,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3]  encoding(VEX, 4 bytes) = c5 dd fc db
00d1h vpshufb ymm3,ymm0,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM0,YMM3] encoding(VEX, 5 bytes) = c4 e2 7d 00 db
00d6h vperm2i128 ymm0,ymm0,ymm0,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
00dch mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
00e6h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00eah vpaddb ymm4,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc e5
00eeh vpshufb ymm0,ymm0,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM4] encoding(VEX, 5 bytes) = c4 e2 7d 00 c4
00f3h vpor ymm0,ymm3,ymm0           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM3,YMM0]      encoding(VEX, 4 bytes) = c5 e5 eb c0
00f7h vextractf128 xmm2,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 00
00fdh vextractf128 xmm0,ymm0,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM0,YMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c0 00
0103h vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
0107h vinserti128 ymm2,ymm3,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM2,YMM3,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 38 d2 00
010dh vinserti128 ymm0,ymm2,xmm0,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 01
0113h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0117h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0119h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
011ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
011fh vextractf128 xmm2,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ca 00
0125h vpmovzxbw ymm2,xmm2           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM2,XMM2]     encoding(VEX, 5 bytes) = c4 e2 7d 30 d2
012ah vextractf128 xmm1,ymm1,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 01
0130h vpmovzxbw ymm1,xmm1           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM1,XMM1]     encoding(VEX, 5 bytes) = c4 e2 7d 30 c9
0135h vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0139h vpsrlw ymm2,ymm2,xmm3         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM2,YMM2,XMM3]  encoding(VEX, 4 bytes) = c5 ed d1 d3
013dh vmovd xmm3,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM3,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d8
0141h vpsrlw ymm1,ymm1,xmm3         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM1,YMM1,XMM3]  encoding(VEX, 4 bytes) = c5 f5 d1 cb
0145h mov rax,2DC432C1003h          ; MOV(Mov_r64_imm64) [RAX,2dc432c1003h:imm64]          encoding(10 bytes) = 48 b8 03 10 2c 43 dc 02 00 00
014fh vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0153h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
0157h vmovupd [rsp+20h],ymm3        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 6 bytes) = c5 fd 11 5c 24 20
015dh vpshufb ymm2,ymm2,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM4] encoding(VEX, 5 bytes) = c4 e2 6d 00 d4
0162h vpshufb ymm1,ymm1,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4] encoding(VEX, 5 bytes) = c4 e2 75 00 cc
0167h mov rax,2DC432C0F73h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0f73h:imm64]          encoding(10 bytes) = 48 b8 73 0f 2c 43 dc 02 00 00
0171h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0175h vmovaps ymm4,ymm3             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM3]         encoding(VEX, 4 bytes) = c5 fc 28 e3
0179h vmovupd [rsp],ymm3            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM3] encoding(VEX, 5 bytes) = c5 fd 11 1c 24
017eh vmovaps ymm3,ymm4             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM4]         encoding(VEX, 4 bytes) = c5 fc 28 dc
0182h mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
018ch vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0190h vpaddb ymm5,ymm3,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5]  encoding(VEX, 4 bytes) = c5 e5 fc ed
0194h vpshufb ymm5,ymm2,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM2,YMM5] encoding(VEX, 5 bytes) = c4 e2 6d 00 ed
0199h vperm2i128 ymm2,ymm2,ymm2,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d2 03
019fh mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
01a9h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
01adh vpaddb ymm3,ymm3,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM6]  encoding(VEX, 4 bytes) = c5 e5 fc de
01b1h vpshufb ymm2,ymm2,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3] encoding(VEX, 5 bytes) = c4 e2 6d 00 d3
01b6h vpor ymm2,ymm5,ymm2           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM2,YMM5,YMM2]      encoding(VEX, 4 bytes) = c5 d5 eb d2
01bah mov rax,2DC432C0FD3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c0fd3h:imm64]          encoding(10 bytes) = 48 b8 d3 0f 2c 43 dc 02 00 00
01c4h vlddqu ymm3,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
01c8h vpaddb ymm3,ymm4,ymm3         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM3,YMM4,YMM3]  encoding(VEX, 4 bytes) = c5 dd fc db
01cch vpshufb ymm3,ymm1,ymm3        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM1,YMM3] encoding(VEX, 5 bytes) = c4 e2 75 00 db
01d1h vperm2i128 ymm1,ymm1,ymm1,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM1,YMM1,YMM1,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 46 c9 03
01d7h mov rax,2DC432C10E3h          ; MOV(Mov_r64_imm64) [RAX,2dc432c10e3h:imm64]          encoding(10 bytes) = 48 b8 e3 10 2c 43 dc 02 00 00
01e1h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
01e5h vpaddb ymm4,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc e5
01e9h vpshufb ymm1,ymm1,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM4] encoding(VEX, 5 bytes) = c4 e2 75 00 cc
01eeh vpor ymm1,ymm3,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM3,YMM1]      encoding(VEX, 4 bytes) = c5 e5 eb c9
01f2h vextractf128 xmm2,ymm2,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM2,YMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 d2 00
01f8h vextractf128 xmm1,ymm1,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM1,YMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 c9 00
01feh vxorps ymm3,ymm3,ymm3         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM3,YMM3,YMM3]  encoding(VEX, 4 bytes) = c5 e4 57 db
0202h vinserti128 ymm2,ymm3,xmm2,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM2,YMM3,XMM2,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 38 d2 00
0208h vinserti128 ymm1,ymm2,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM2,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c9 01
020eh vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0212h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0216h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0219h vmovaps xmm6,[rsp+80h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 80 00 00 00
0222h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0225h add rsp,98h                   ; ADD(Add_rm64_imm32) [RSP,98h:imm64]                  encoding(7 bytes) = 48 81 c4 98 00 00 00
022ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_g256x8uBytes => new byte[557]{0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0x80,0x00,0x00,0x00,0xC5,0xFD,0x10,0x02,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC4,0xE2,0x7D,0x30,0xC0,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD8,0xC5,0xED,0xF1,0xD3,0x41,0x0F,0xB6,0xC0,0xC5,0xF9,0x6E,0xD8,0xC5,0xFD,0xF1,0xC3,0x48,0xB8,0x03,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x5C,0x24,0x60,0xC4,0xE2,0x6D,0x00,0xD4,0xC4,0xE2,0x7D,0x00,0xC4,0x48,0xB8,0x73,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x5C,0x24,0x40,0xC5,0xFC,0x28,0xDC,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xE5,0xFC,0xED,0xC4,0xE2,0x6D,0x00,0xED,0xC4,0xE3,0x6D,0x46,0xD2,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xE5,0xFC,0xDE,0xC4,0xE2,0x6D,0x00,0xD3,0xC5,0xD5,0xEB,0xD2,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xDD,0xFC,0xDB,0xC4,0xE2,0x7D,0x00,0xDB,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xE5,0xC4,0xE2,0x7D,0x00,0xC4,0xC5,0xE5,0xEB,0xC0,0xC4,0xE3,0x7D,0x19,0xD2,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xE4,0x57,0xDB,0xC4,0xE3,0x65,0x38,0xD2,0x00,0xC4,0xE3,0x6D,0x38,0xC0,0x01,0x41,0x0F,0xB6,0xC0,0xF7,0xD8,0x83,0xC0,0x08,0x0F,0xB6,0xC0,0xC4,0xE3,0x7D,0x19,0xCA,0x00,0xC4,0xE2,0x7D,0x30,0xD2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x30,0xC9,0xC5,0xF9,0x6E,0xD8,0xC5,0xED,0xD1,0xD3,0xC5,0xF9,0x6E,0xD8,0xC5,0xF5,0xD1,0xCB,0x48,0xB8,0x03,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x5C,0x24,0x20,0xC4,0xE2,0x6D,0x00,0xD4,0xC4,0xE2,0x75,0x00,0xCC,0x48,0xB8,0x73,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xFC,0x28,0xE3,0xC5,0xFD,0x11,0x1C,0x24,0xC5,0xFC,0x28,0xDC,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xE5,0xFC,0xED,0xC4,0xE2,0x6D,0x00,0xED,0xC4,0xE3,0x6D,0x46,0xD2,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xE5,0xFC,0xDE,0xC4,0xE2,0x6D,0x00,0xD3,0xC5,0xD5,0xEB,0xD2,0x48,0xB8,0xD3,0x0F,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xDD,0xFC,0xDB,0xC4,0xE2,0x75,0x00,0xDB,0xC4,0xE3,0x75,0x46,0xC9,0x03,0x48,0xB8,0xE3,0x10,0x2C,0x43,0xDC,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xE5,0xC4,0xE2,0x75,0x00,0xCC,0xC5,0xE5,0xEB,0xC9,0xC4,0xE3,0x7D,0x19,0xD2,0x00,0xC4,0xE3,0x7D,0x19,0xC9,0x00,0xC5,0xE4,0x57,0xDB,0xC4,0xE3,0x65,0x38,0xD2,0x00,0xC4,0xE3,0x6D,0x38,0xC9,0x01,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
