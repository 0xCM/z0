; 2019-11-06 08:55:37:709
; function: ref BitMatrix<byte> gbm_and_8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
; location: [7FFDD9F1DED0h, 7FFDD9F1DF25h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
000eh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0013h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0017h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001bh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
001fh vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0025h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
002ah mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
002dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0031h vmovdqu xmmword ptr [rsp+8],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 08
0037h lea rdx,[rsp+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 08
003ch mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
003fh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 08
0042h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0045h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0048h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
004bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
004eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0051h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_8x8Bytes => new byte[86]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x48,0x8B,0x00,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x44,0x24,0x08,0x48,0x8D,0x54,0x24,0x08,0x48,0x8B,0x12,0x49,0x8B,0x08,0x48,0x8B,0x00,0x48,0x8B,0x12,0x48,0x23,0xC2,0x48,0x89,0x01,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<ushort> gbm_and_16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
; location: [7FFDD9F1DF40h, 7FFDD9F1DFC5h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+48h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 48
000eh lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 48
0013h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0017h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001bh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
001fh vmovdqu xmmword ptr [rsp+48h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 48
0025h lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 48
002ah mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
002dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0031h vmovdqu xmmword ptr [rsp+48h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 48
0037h lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 48
003ch mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
003fh mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 08
0042h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0046h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
004ch vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0050h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0055h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0059h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
005fh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
0063h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0068h vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
006eh vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
0073h vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0077h vmovdqu ymmword ptr [rcx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 01
007bh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
007eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0081h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
0085h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_16x16Bytes => new byte[134]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x48,0x48,0x8D,0x44,0x24,0x48,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x48,0x48,0x8D,0x44,0x24,0x48,0x48,0x8B,0x00,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x44,0x24,0x48,0x48,0x8D,0x54,0x24,0x48,0x48,0x8B,0x12,0x49,0x8B,0x08,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0xC5,0xFE,0x7F,0x01,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<uint> gbm_and_32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
; location: [7FFDD9F1DFF0h, 7FFDD9F1E09Fh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 58
0010h lea rax,[rsp+58h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 58
0015h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0019h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001dh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0021h vmovdqu xmmword ptr [rsp+58h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 58
0027h lea rax,[rsp+58h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 58
002ch mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
002fh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0033h vmovdqu xmmword ptr [rsp+58h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 58
0039h lea rdx,[rsp+58h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 58
003eh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0041h mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 08
0044h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0047h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
004ah movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
004dh shl r11,2                     ; SHL(Shl_rm64_imm8) [R11,2h:imm8]                     encoding(4 bytes) = 49 c1 e3 02
0051h lea rsi,[rax+r11]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 34 18
0055h lea rdi,[rdx+r11]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 3c 1a
0059h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
005dh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0063h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0067h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
006ch vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
0070h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0076h vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
007ah vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
007fh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0085h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
008ah vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
008eh add r11,rcx                   ; ADD(Add_r64_rm64) [R11,RCX]                          encoding(3 bytes) = 4c 03 d9
0091h vmovdqu ymmword ptr [r11],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R11:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 03
0096h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0099h add r10d,8                    ; ADD(Add_rm32_imm8) [R10D,8h:imm32]                   encoding(4 bytes) = 41 83 c2 08
009dh cmp r9d,4                     ; CMP(Cmp_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 f9 04
00a1h jl short 004ah                ; JL(Jl_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 7c a7
00a3h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
00a6h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00a9h add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
00adh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00aeh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00afh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_32x32Bytes => new byte[176]{0x57,0x56,0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x58,0x48,0x8D,0x44,0x24,0x58,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x58,0x48,0x8D,0x44,0x24,0x58,0x48,0x8B,0x00,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x44,0x24,0x58,0x48,0x8D,0x54,0x24,0x58,0x48,0x8B,0x12,0x49,0x8B,0x08,0x45,0x33,0xC9,0x45,0x33,0xD2,0x4D,0x63,0xDA,0x49,0xC1,0xE3,0x02,0x4A,0x8D,0x34,0x18,0x4A,0x8D,0x3C,0x1A,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0x4C,0x03,0xD9,0xC4,0xC1,0x7E,0x7F,0x03,0x41,0xFF,0xC1,0x41,0x83,0xC2,0x08,0x41,0x83,0xF9,0x04,0x7C,0xA7,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x68,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<ulong> gbm_and_64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
; location: [7FFDD9F1E0D0h, 7FFDD9F1E17Fh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh mov [rsp+58h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 58
0010h lea rax,[rsp+58h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 58
0015h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0019h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
001dh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0021h vmovdqu xmmword ptr [rsp+58h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 58
0027h lea rax,[rsp+58h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 58
002ch mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
002fh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0033h vmovdqu xmmword ptr [rsp+58h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 58
0039h lea rdx,[rsp+58h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 58
003eh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0041h mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 08
0044h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0047h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
004ah movsxd r11,r10d               ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]                   encoding(3 bytes) = 4d 63 da
004dh shl r11,3                     ; SHL(Shl_rm64_imm8) [R11,3h:imm8]                     encoding(4 bytes) = 49 c1 e3 03
0051h lea rsi,[rax+r11]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 34 18
0055h lea rdi,[rdx+r11]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 4a 8d 3c 1a
0059h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
005dh vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0063h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0067h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
006ch vlddqu ymm0,ymmword ptr [rsi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RSI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 06
0070h vmovupd [rsp+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 20
0076h vlddqu ymm0,ymmword ptr [rdi] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDI:br,DS:sr)] encoding(VEX, 4 bytes) = c5 ff f0 07
007ah vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
007fh vmovupd ymm0,[rsp+20h]        ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 20
0085h vmovupd ymm1,[rsp]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fd 10 0c 24
008ah vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
008eh add r11,rcx                   ; ADD(Add_r64_rm64) [R11,RCX]                          encoding(3 bytes) = 4c 03 d9
0091h vmovdqu ymmword ptr [r11],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,R11:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7e 7f 03
0096h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0099h add r10d,4                    ; ADD(Add_rm32_imm8) [R10D,4h:imm32]                   encoding(4 bytes) = 41 83 c2 04
009dh cmp r9d,10h                   ; CMP(Cmp_rm32_imm8) [R9D,10h:imm32]                   encoding(4 bytes) = 41 83 f9 10
00a1h jl short 004ah                ; JL(Jl_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 7c a7
00a3h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
00a6h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00a9h add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
00adh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00aeh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00afh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gbm_and_64x64Bytes => new byte[176]{0x57,0x56,0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x58,0x48,0x8D,0x44,0x24,0x58,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x44,0x24,0x58,0x48,0x8D,0x44,0x24,0x58,0x48,0x8B,0x00,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x44,0x24,0x58,0x48,0x8D,0x54,0x24,0x58,0x48,0x8B,0x12,0x49,0x8B,0x08,0x45,0x33,0xC9,0x45,0x33,0xD2,0x4D,0x63,0xDA,0x49,0xC1,0xE3,0x03,0x4A,0x8D,0x34,0x18,0x4A,0x8D,0x3C,0x1A,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x07,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xDB,0xC1,0x4C,0x03,0xD9,0xC4,0xC1,0x7E,0x7F,0x03,0x41,0xFF,0xC1,0x41,0x83,0xC2,0x04,0x41,0x83,0xF9,0x10,0x7C,0xA7,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x68,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
