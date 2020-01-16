; 2020-01-15 19:20:39:574
; function: Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> vand_delgate()
; static ReadOnlySpan<byte> vand_delgateBytes => new byte[235]{0x57,0x56,0x53,0x48,0x83,0xEC,0x60,0xC5,0xF8,0x77,0x48,0xB9,0x98,0x27,0xF0,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0x37,0xB3,0x3D,0x5F,0x48,0x8B,0xF0,0x48,0xB9,0x88,0x77,0xEF,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x70,0x31,0x43,0x5F,0x48,0x8B,0xF8,0x48,0xB9,0xF0,0xD7,0x50,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x0E,0xB3,0x3D,0x5F,0x48,0x8B,0xD8,0x4C,0x8B,0xC3,0x48,0x8B,0xCF,0x33,0xD2,0xE8,0x1E,0x22,0x43,0x5F,0x4C,0x8B,0xC3,0x48,0x8B,0xCF,0xBA,0x01,0x00,0x00,0x00,0xE8,0x0E,0x22,0x43,0x5F,0xC7,0x44,0x24,0x20,0x03,0x00,0x00,0x00,0x48,0x89,0x7C,0x24,0x28,0x33,0xD2,0x48,0x89,0x54,0x24,0x30,0x48,0xBA,0x30,0x0A,0x01,0x10,0xED,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x8B,0xCE,0x41,0xB8,0x1C,0x00,0x00,0x00,0x45,0x33,0xC9,0xE8,0x7C,0x91,0x84,0x5D,0x48,0x8B,0xC8,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x40,0xE8,0x05,0xF2,0xFF,0xFF,0x48,0x8B,0xF0,0x48,0xB9,0x40,0xC4,0x75,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x93,0xB2,0x3D,0x5F,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0x8B,0x06,0x48,0x8B,0x40,0x68,0xFF,0x50,0x10,0x48,0x8B,0xD0,0x48,0xB9,0x40,0xC4,0x75,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x81,0xB1,0x37,0x5F,0x90,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x60,0x5B,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0003h sub rsp,60h                             ; SUB(Sub_rm64_imm8) [RSP,60h:imm64]         encoding(4 bytes) = 48 83 ec 60
0007h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rcx,7FF7C7F02798h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c7f02798h:imm64] encoding(10 bytes) = 48 b9 98 27 f0 c7 f7 7f 00 00
0014h call 7FF82793EFF0h                      ; CALL(Call_rel32_64) [5F3DB350h:jmp64]      encoding(5 bytes) = e8 37 b3 3d 5f
0019h mov rsi,rax                             ; MOV(Mov_r64_rm64) [RSI,RAX]                encoding(3 bytes) = 48 8b f0
001ch mov rcx,7FF7C7EF7788h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c7ef7788h:imm64] encoding(10 bytes) = 48 b9 88 77 ef c7 f7 7f 00 00
0026h mov edx,2                               ; MOV(Mov_r32_imm32) [EDX,2h:imm32]          encoding(5 bytes) = ba 02 00 00 00
002bh call 7FF827996E40h                      ; CALL(Call_rel32_64) [5F4331A0h:jmp64]      encoding(5 bytes) = e8 70 31 43 5f
0030h mov rdi,rax                             ; MOV(Mov_r64_rm64) [RDI,RAX]                encoding(3 bytes) = 48 8b f8
0033h mov rcx,7FF7C850D7F0h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c850d7f0h:imm64] encoding(10 bytes) = 48 b9 f0 d7 50 c8 f7 7f 00 00
003dh call 7FF82793EFF0h                      ; CALL(Call_rel32_64) [5F3DB350h:jmp64]      encoding(5 bytes) = e8 0e b3 3d 5f
0042h mov rbx,rax                             ; MOV(Mov_r64_rm64) [RBX,RAX]                encoding(3 bytes) = 48 8b d8
0045h mov r8,rbx                              ; MOV(Mov_r64_rm64) [R8,RBX]                 encoding(3 bytes) = 4c 8b c3
0048h mov rcx,rdi                             ; MOV(Mov_r64_rm64) [RCX,RDI]                encoding(3 bytes) = 48 8b cf
004bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
004dh call 7FF827995F10h                      ; CALL(Call_rel32_64) [5F432270h:jmp64]      encoding(5 bytes) = e8 1e 22 43 5f
0052h mov r8,rbx                              ; MOV(Mov_r64_rm64) [R8,RBX]                 encoding(3 bytes) = 4c 8b c3
0055h mov rcx,rdi                             ; MOV(Mov_r64_rm64) [RCX,RDI]                encoding(3 bytes) = 48 8b cf
0058h mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
005dh call 7FF827995F10h                      ; CALL(Call_rel32_64) [5F432270h:jmp64]      encoding(5 bytes) = e8 0e 22 43 5f
0062h mov dword ptr [rsp+20h],3               ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3h:imm32] encoding(8 bytes) = c7 44 24 20 03 00 00 00
006ah mov [rsp+28h],rdi                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDI] encoding(5 bytes) = 48 89 7c 24 28
006fh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0071h mov [rsp+30h],rdx                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX] encoding(5 bytes) = 48 89 54 24 30
0076h mov rdx,1ED10010A30h                    ; MOV(Mov_r64_imm64) [RDX,1ed10010a30h:imm64] encoding(10 bytes) = 48 ba 30 0a 01 10 ed 01 00 00
0080h mov rdx,[rdx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 12
0083h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0086h mov r8d,1Ch                             ; MOV(Mov_r32_imm32) [R8D,1ch:imm32]         encoding(6 bytes) = 41 b8 1c 00 00 00
008ch xor r9d,r9d                             ; XOR(Xor_r32_rm32) [R9D,R9D]                encoding(3 bytes) = 45 33 c9
008fh call 7FF825DACEB0h                      ; CALL(Call_rel32_64) [5D849210h:jmp64]      encoding(5 bytes) = e8 7c 91 84 5d
0094h mov rcx,rax                             ; MOV(Mov_r64_rm64) [RCX,RAX]                encoding(3 bytes) = 48 8b c8
0097h vxorps ymm0,ymm0,ymm0                   ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0] encoding(VEX, 4 bytes) = c5 fc 57 c0
009bh vmovupd [rsp+40h],ymm0                  ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
00a1h lea rdx,[rsp+40h]                       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 54 24 40
00a6h call 7FF7C8562F50h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFF2B0h:jmp64] encoding(5 bytes) = e8 05 f2 ff ff
00abh mov rsi,rax                             ; MOV(Mov_r64_rm64) [RSI,RAX]                encoding(3 bytes) = 48 8b f0
00aeh mov rcx,7FF7C875C440h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c875c440h:imm64] encoding(10 bytes) = 48 b9 40 c4 75 c8 f7 7f 00 00
00b8h call 7FF82793EFF0h                      ; CALL(Call_rel32_64) [5F3DB350h:jmp64]      encoding(5 bytes) = e8 93 b2 3d 5f
00bdh mov rdx,rax                             ; MOV(Mov_r64_rm64) [RDX,RAX]                encoding(3 bytes) = 48 8b d0
00c0h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
00c3h mov rax,[rsi]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSI:br,:sr)] encoding(3 bytes) = 48 8b 06
00c6h mov rax,[rax+68h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(4 bytes) = 48 8b 40 68
00cah call qword ptr [rax+10h]                ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,:sr)] encoding(3 bytes) = ff 50 10
00cdh mov rdx,rax                             ; MOV(Mov_r64_rm64) [RDX,RAX]                encoding(3 bytes) = 48 8b d0
00d0h mov rcx,7FF7C875C440h                   ; MOV(Mov_r64_imm64) [RCX,7ff7c875c440h:imm64] encoding(10 bytes) = 48 b9 40 c4 75 c8 f7 7f 00 00
00dah call 7FF8278DEF00h                      ; CALL(Call_rel32_64) [5F37B260h:jmp64]      encoding(5 bytes) = e8 81 b1 37 5f
00dfh nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
00e0h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
00e3h add rsp,60h                             ; ADD(Add_rm64_imm8) [RSP,60h:imm64]         encoding(4 bytes) = 48 83 c4 60
00e7h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
00e8h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
00e9h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
00eah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vand_dynamic(Vector256<uint> a, Vector256<uint> b)
; static ReadOnlySpan<byte> vand_dynamicBytes => new byte[48]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xD9,0x48,0x8B,0xF2,0x49,0x8B,0xF8,0xE8,0xDB,0xFE,0xFF,0xFF,0x48,0x8B,0x48,0x08,0x48,0x8B,0xD3,0x4C,0x8B,0xC6,0x4C,0x8B,0xCF,0xFF,0x50,0x18,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0003h sub rsp,20h                             ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 ec 20
0007h mov rbx,rcx                             ; MOV(Mov_r64_rm64) [RBX,RCX]                encoding(3 bytes) = 48 8b d9
000ah mov rsi,rdx                             ; MOV(Mov_r64_rm64) [RSI,RDX]                encoding(3 bytes) = 48 8b f2
000dh mov rdi,r8                              ; MOV(Mov_r64_rm64) [RDI,R8]                 encoding(3 bytes) = 49 8b f8
0010h call 7FF7C8563CA0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEF0h:jmp64] encoding(5 bytes) = e8 db fe ff ff
0015h mov rcx,[rax+8]                         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,:sr)] encoding(4 bytes) = 48 8b 48 08
0019h mov rdx,rbx                             ; MOV(Mov_r64_rm64) [RDX,RBX]                encoding(3 bytes) = 48 8b d3
001ch mov r8,rsi                              ; MOV(Mov_r64_rm64) [R8,RSI]                 encoding(3 bytes) = 4c 8b c6
001fh mov r9,rdi                              ; MOV(Mov_r64_rm64) [R9,RDI]                 encoding(3 bytes) = 4c 8b cf
0022h call qword ptr [rax+18h]                ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,:sr)] encoding(3 bytes) = ff 50 18
0025h mov rax,rbx                             ; MOV(Mov_r64_rm64) [RAX,RBX]                encoding(3 bytes) = 48 8b c3
0028h add rsp,20h                             ; ADD(Add_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 c4 20
002ch pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
002dh pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
002eh pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
002fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector512<ulong> vperm2x128(Vector512<ulong> src)
; static ReadOnlySpan<byte> vperm2x128Bytes => new byte[50]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xFD,0x10,0x4A,0x20,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC4,0xE3,0x6D,0x46,0xD3,0x30,0xC4,0xE3,0x7D,0x46,0xC1,0x21,0xC5,0xFD,0x11,0x11,0xC5,0xFD,0x11,0x41,0x20,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[rdx+20h]                  ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 4a 20
000eh vmovaps ymm2,ymm0                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0] encoding(VEX, 4 bytes) = c5 fc 28 d0
0012h vmovaps ymm3,ymm1                       ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1] encoding(VEX, 4 bytes) = c5 fc 28 d9
0016h vperm2i128 ymm2,ymm2,ymm3,30h           ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM2,YMM2,YMM3,30h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 46 d3 30
001ch vperm2i128 ymm0,ymm0,ymm1,21h           ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM1,21h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c1 21
0022h vmovupd [rcx],ymm2                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM2] encoding(VEX, 4 bytes) = c5 fd 11 11
0026h vmovupd [rcx+20h],ymm0                  ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 41 20
002bh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
002eh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0031h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
; static ReadOnlySpan<byte> vbswap_128x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x75,0x66,0x3C,0x7B,0xED,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,1ED7B3C6675h                    ; MOV(Mov_r64_imm64) [RAX,1ed7b3c6675h:imm64] encoding(10 bytes) = 48 b8 75 66 3c 7b ed 01 00 00
0013h vlddqu xmm1,xmmword ptr [rax]           ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0017h vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
001ch vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0020h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0023h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
; static ReadOnlySpan<byte> vpermvar8x32_256x32iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0                   ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; static ReadOnlySpan<byte> vpermvar8x32_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpermd ymm0,ymm1,ymm0                   ; VPERMD(VEX_Vpermd_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0] encoding(VEX, 5 bytes) = c4 e2 75 36 c0
0013h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; static ReadOnlySpan<byte> vpermvar32x8_256x8uBytes => new byte[81]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0xE5,0x6A,0x3C,0x7B,0xED,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x55,0x66,0x3C,0x7B,0xED,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,1ED7B3C6AE5h                    ; MOV(Mov_r64_imm64) [RAX,1ed7b3c6ae5h:imm64] encoding(10 bytes) = 48 b8 e5 6a 3c 7b ed 01 00 00
0018h vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpaddb ymm2,ymm1,ymm2                   ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM2,YMM1,YMM2] encoding(VEX, 4 bytes) = c5 f5 fc d2
0020h vpshufb ymm2,ymm0,ymm2                  ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM2,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 d2
0025h vperm2i128 ymm0,ymm0,ymm0,3             ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,YMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 46 c0 03
002bh mov rax,1ED7B3C6655h                    ; MOV(Mov_r64_imm64) [RAX,1ed7b3c6655h:imm64] encoding(10 bytes) = 48 b8 55 66 3c 7b ed 01 00 00
0035h vlddqu ymm3,ymmword ptr [rax]           ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM3,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 18
0039h vpaddb ymm1,ymm1,ymm3                   ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM3] encoding(VEX, 4 bytes) = c5 f5 fc cb
003dh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0042h vpor ymm0,ymm2,ymm0                     ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM2,YMM0] encoding(VEX, 4 bytes) = c5 ed eb c0
0046h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
004ah mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
004dh vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0050h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; static ReadOnlySpan<byte> vshuffle_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; static ReadOnlySpan<byte> vshuffle_128x8iBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 00 c1
0013h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; static ReadOnlySpan<byte> vshuffle_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; static ReadOnlySpan<byte> vshuffle_256x8iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 00 c1
0013h vmovupd [rcx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001ah vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
; static ReadOnlySpan<byte> vtransposeBytes => new byte[98]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF0,0xC6,0xCB,0x44,0xC5,0xF8,0xC6,0xC2,0xEE,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF8,0x28,0xDA,0xC4,0xC1,0x79,0x10,0x21,0xC5,0xF8,0x28,0xEC,0xC5,0xE0,0xC6,0xDD,0x44,0xC5,0xE8,0xC6,0xD4,0xEE,0xC5,0xF0,0xC6,0xE3,0x88,0xC5,0xF9,0x11,0x21,0xC5,0xF0,0xC6,0xCB,0xDD,0xC5,0xF9,0x11,0x0A,0xC5,0xF8,0xC6,0xCA,0x88,0xC4,0xC1,0x79,0x11,0x08,0xC5,0xF8,0xC6,0xC2,0xDD,0xC4,0xC1,0x79,0x11,0x01,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
000dh vmovupd xmm2,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 12
0011h vmovaps xmm3,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 da
0015h vshufps xmm1,xmm1,xmm3,44h              ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,44h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb 44
001ah vshufps xmm0,xmm0,xmm2,0EEh             ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,eeh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 ee
001fh vmovupd xmm2,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 10
0024h vmovaps xmm3,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 da
0028h vmovupd xmm4,[r9]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM4,mem(Packed128_Float64,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 21
002dh vmovaps xmm5,xmm4                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM5,XMM4] encoding(VEX, 4 bytes) = c5 f8 28 ec
0031h vshufps xmm3,xmm3,xmm5,44h              ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM3,XMM3,XMM5,44h:imm8] encoding(VEX, 5 bytes) = c5 e0 c6 dd 44
0036h vshufps xmm2,xmm2,xmm4,0EEh             ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM2,XMM2,XMM4,eeh:imm8] encoding(VEX, 5 bytes) = c5 e8 c6 d4 ee
003bh vshufps xmm4,xmm1,xmm3,88h              ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM4,XMM1,XMM3,88h:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 e3 88
0040h vmovupd [rcx],xmm4                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM4] encoding(VEX, 4 bytes) = c5 f9 11 21
0044h vshufps xmm1,xmm1,xmm3,0DDh             ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM1,XMM3,ddh:imm8] encoding(VEX, 5 bytes) = c5 f0 c6 cb dd
0049h vmovupd [rdx],xmm1                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 0a
004dh vshufps xmm1,xmm0,xmm2,88h              ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM1,XMM0,XMM2,88h:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 ca 88
0052h vmovupd [r8],xmm1                       ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R8:br,:sr),XMM1] encoding(VEX, 5 bytes) = c4 c1 79 11 08
0057h vshufps xmm0,xmm0,xmm2,0DDh             ; VSHUFPS(VEX_Vshufps_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM2,ddh:imm8] encoding(VEX, 5 bytes) = c5 f8 c6 c2 dd
005ch vmovupd [r9],xmm0                       ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
0061h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
