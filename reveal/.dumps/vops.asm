; 2019-12-24 12:34:02:563
; function: uint vxor_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7E637B0h, 7FF7C7E637CFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
000bh vmovd eax,xmm0                ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]                 encoding(VEX, 4 bytes) = c5 f9 7e c0
000fh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0013h vpextrd edx,xmm0,3            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EDX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c2 03
0019h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vxor_128x32uBytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0x79,0x16,0xC2,0x03,0x33,0xC2,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> op_shift_specific(Vector256<uint> src)
; location: [7FF7C7E63BF0h, 7FF7C7E63C16h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh vpslld ymm0,ymm0,3            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM0,YMM0,3h:imm8]  encoding(VEX, 5 bytes) = c5 fd 72 f0 03
0010h vpsrld ymm0,ymm0,3            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM0,YMM0,3h:imm8]  encoding(VEX, 5 bytes) = c5 fd 72 d0 03
0015h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0017h cmp eax,14h                   ; CMP(Cmp_rm32_imm8) [EAX,14h:imm32]                   encoding(3 bytes) = 83 f8 14
001ah jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c ef
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> op_shift_specificBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x33,0xC0,0xC5,0xFD,0x72,0xF0,0x03,0xC5,0xFD,0x72,0xD0,0x03,0xFF,0xC0,0x83,0xF8,0x14,0x7C,0xEF,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> op_shift(Vector256<uint> src, byte amount)
; location: [7FF7C7E63C30h, 7FF7C7E63C60h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000fh vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
0013h vpslld ymm0,ymm0,xmm1         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f2 c1
0017h vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
001bh vpsrld ymm0,ymm0,xmm1         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd d2 c1
001fh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0021h cmp eax,14h                   ; CMP(Cmp_rm32_imm8) [EAX,14h:imm32]                   encoding(3 bytes) = 83 f8 14
0024h jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c e9
0026h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> op_shiftBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x33,0xC0,0x41,0x0F,0xB6,0xD0,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xF2,0xC1,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xD2,0xC1,0xFF,0xC0,0x83,0xF8,0x14,0x7C,0xE9,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
