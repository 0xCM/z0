; 2020-01-13 21:43:21:963
; function: bit check_and_1(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> check_and_1Bytes => new byte[153]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF1,0xDB,0xCB,0xC5,0xF8,0x28,0xD8,0xC5,0xF9,0x7E,0xD8,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0x7E,0xDA,0x23,0xC2,0xC5,0xF8,0x28,0xD8,0xC4,0xE3,0x79,0x16,0xDA,0x01,0xC5,0xF8,0x28,0xDA,0xC4,0xE3,0x79,0x16,0xD9,0x01,0x23,0xD1,0xC5,0xF8,0x28,0xD8,0xC4,0xE3,0x79,0x16,0xD9,0x02,0xC5,0xF8,0x28,0xDA,0xC4,0xC3,0x79,0x16,0xD8,0x02,0x41,0x23,0xC8,0xC4,0xC3,0x79,0x16,0xC0,0x03,0xC4,0xC3,0x79,0x16,0xD1,0x03,0x45,0x23,0xC1,0xC5,0xF9,0x6E,0xC0,0xC4,0xE3,0x79,0x22,0xC2,0x01,0xC4,0xE3,0x79,0x22,0xC1,0x02,0xC4,0xC3,0x79,0x22,0xC0,0x03,0xC5,0xF1,0x76,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xE8,0x57,0xD2,0xC5,0xF1,0x76,0xCA,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovaps xmm1,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 c8
000dh vmovupd xmm2,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 12
0011h vmovaps xmm3,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 da
0015h vpand xmm1,xmm1,xmm3                    ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM3] encoding(VEX, 4 bytes) = c5 f1 db cb
0019h vmovaps xmm3,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d8
001dh vmovd eax,xmm3                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM3]       encoding(VEX, 4 bytes) = c5 f9 7e d8
0021h vmovaps xmm3,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 da
0025h vmovd edx,xmm3                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EDX,XMM3]       encoding(VEX, 4 bytes) = c5 f9 7e da
0029h and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
002bh vmovaps xmm3,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d8
002fh vpextrd edx,xmm3,1                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EDX,XMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 da 01
0035h vmovaps xmm3,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 da
0039h vpextrd ecx,xmm3,1                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [ECX,XMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 d9 01
003fh and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0041h vmovaps xmm3,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d8
0045h vpextrd ecx,xmm3,2                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [ECX,XMM3,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 d9 02
004bh vmovaps xmm3,xmm2                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2] encoding(VEX, 4 bytes) = c5 f8 28 da
004fh vpextrd r8d,xmm3,2                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [R8D,XMM3,2h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 16 d8 02
0055h and ecx,r8d                             ; AND(And_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 23 c8
0058h vpextrd r8d,xmm0,3                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [R8D,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 16 c0 03
005eh vpextrd r9d,xmm2,3                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [R9D,XMM2,3h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 16 d1 03
0064h and r8d,r9d                             ; AND(And_r32_rm32) [R8D,R9D]                encoding(3 bytes) = 45 23 c1
0067h vmovd xmm0,eax                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EAX]       encoding(VEX, 4 bytes) = c5 f9 6e c0
006bh vpinsrd xmm0,xmm0,edx,1                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 01
0071h vpinsrd xmm0,xmm0,ecx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,ECX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c1 02
0077h vpinsrd xmm0,xmm0,r8d,3                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,R8D,3h:imm8] encoding(VEX, 6 bytes) = c4 c3 79 22 c0 03
007dh vpcmpeqd xmm0,xmm1,xmm0                 ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0] encoding(VEX, 4 bytes) = c5 f1 76 c0
0081h vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
0085h vxorps xmm2,xmm2,xmm2                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2] encoding(VEX, 4 bytes) = c5 e8 57 d2
0089h vpcmpeqd xmm1,xmm1,xmm2                 ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f1 76 ca
008dh vptest xmm0,xmm1                        ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 17 c1
0092h setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
0095h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0098h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit check_and_2(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> check_and_2Bytes => new byte[188]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0x33,0xC0,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0x48,0x89,0x44,0x24,0x48,0x48,0x89,0x44,0x24,0x50,0x48,0x8D,0x44,0x24,0x48,0x33,0xC9,0x48,0x63,0xD1,0x48,0x8D,0x14,0x90,0xC5,0xF8,0x28,0xD8,0xC5,0xF9,0x29,0x5C,0x24,0x30,0x83,0xF9,0x04,0x73,0x58,0x4C,0x8D,0x44,0x24,0x30,0x4C,0x63,0xC9,0x47,0x8B,0x04,0x88,0xC5,0xF8,0x28,0xD9,0xC5,0xF9,0x29,0x5C,0x24,0x20,0x83,0xF9,0x04,0x73,0x48,0x4C,0x8D,0x4C,0x24,0x20,0x4C,0x63,0xD1,0x47,0x8B,0x0C,0x91,0x45,0x23,0xC1,0x44,0x89,0x02,0xFF,0xC1,0x83,0xF9,0x04,0x7C,0xB6,0xC5,0xFB,0xF0,0x00,0xC5,0xE9,0x76,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xE8,0x57,0xD2,0xC5,0xF1,0x76,0xCA,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x58,0xC3,0xB9,0x15,0x00,0x00,0x00,0xE8,0x20,0xE8,0x92,0xFF,0xCC,0xB9,0x15,0x00,0x00,0x00,0xE8,0x15,0xE8,0x92,0xFF,0xCC};
0000h sub rsp,58h                             ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]         encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
000bh vmovupd xmm1,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000fh xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0011h mov [rsp+48h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 48
0016h mov [rsp+50h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 50
001bh vmovaps xmm2,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d0
001fh vmovaps xmm3,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 d9
0023h vpand xmm2,xmm2,xmm3                    ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3] encoding(VEX, 4 bytes) = c5 e9 db d3
0027h mov [rsp+48h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 48
002ch mov [rsp+50h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 50
0031h lea rax,[rsp+48h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 48
0036h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
0038h movsxd rdx,ecx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]          encoding(3 bytes) = 48 63 d1
003bh lea rdx,[rax+rdx*4]                     ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 48 8d 14 90
003fh vmovaps xmm3,xmm0                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM0] encoding(VEX, 4 bytes) = c5 f8 28 d8
0043h vmovapd [rsp+30h],xmm3                  ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM3] encoding(VEX, 6 bytes) = c5 f9 29 5c 24 30
0049h cmp ecx,4                               ; CMP(Cmp_rm32_imm8) [ECX,4h:imm32]          encoding(3 bytes) = 83 f9 04
004ch jae short 00a6h                         ; JAE(Jae_rel8_64) [A6h:jmp64]               encoding(2 bytes) = 73 58
004eh lea r8,[rsp+30h]                        ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 4c 8d 44 24 30
0053h movsxd r9,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]           encoding(3 bytes) = 4c 63 c9
0056h mov r8d,[r8+r9*4]                       ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,:sr)] encoding(4 bytes) = 47 8b 04 88
005ah vmovaps xmm3,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 d9
005eh vmovapd [rsp+20h],xmm3                  ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM3] encoding(VEX, 6 bytes) = c5 f9 29 5c 24 20
0064h cmp ecx,4                               ; CMP(Cmp_rm32_imm8) [ECX,4h:imm32]          encoding(3 bytes) = 83 f9 04
0067h jae short 00b1h                         ; JAE(Jae_rel8_64) [B1h:jmp64]               encoding(2 bytes) = 73 48
0069h lea r9,[rsp+20h]                        ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 4c 8d 4c 24 20
006eh movsxd r10,ecx                          ; MOVSXD(Movsxd_r64_rm32) [R10,ECX]          encoding(3 bytes) = 4c 63 d1
0071h mov r9d,[r9+r10*4]                      ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,:sr)] encoding(4 bytes) = 47 8b 0c 91
0075h and r8d,r9d                             ; AND(And_r32_rm32) [R8D,R9D]                encoding(3 bytes) = 45 23 c1
0078h mov [rdx],r8d                           ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),R8D] encoding(3 bytes) = 44 89 02
007bh inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
007dh cmp ecx,4                               ; CMP(Cmp_rm32_imm8) [ECX,4h:imm32]          encoding(3 bytes) = 83 f9 04
0080h jl short 0038h                          ; JL(Jl_rel8_64) [38h:jmp64]                 encoding(2 bytes) = 7c b6
0082h vlddqu xmm0,xmmword ptr [rax]           ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
0086h vpcmpeqd xmm0,xmm2,xmm0                 ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM2,XMM0] encoding(VEX, 4 bytes) = c5 e9 76 c0
008ah vxorps xmm1,xmm1,xmm1                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f0 57 c9
008eh vxorps xmm2,xmm2,xmm2                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2] encoding(VEX, 4 bytes) = c5 e8 57 d2
0092h vpcmpeqd xmm1,xmm1,xmm2                 ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f1 76 ca
0096h vptest xmm0,xmm1                        ; VPTEST(VEX_Vptest_xmm_xmmm128) [XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 17 c1
009bh setb al                                 ; SETB(Setb_rm8) [AL]                        encoding(3 bytes) = 0f 92 c0
009eh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
00a1h add rsp,58h                             ; ADD(Add_rm64_imm8) [RSP,58h:imm64]         encoding(4 bytes) = 48 83 c4 58
00a5h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
00a6h mov ecx,15h                             ; MOV(Mov_r32_imm32) [ECX,15h:imm32]         encoding(5 bytes) = b9 15 00 00 00
00abh call 7FF7C63A96D0h                      ; CALL(Call_rel32_64) [FFFFFFFFFF92E8D0h:jmp64] encoding(5 bytes) = e8 20 e8 92 ff
00b0h int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
00b1h mov ecx,15h                             ; MOV(Mov_r32_imm32) [ECX,15h:imm32]         encoding(5 bytes) = b9 15 00 00 00
00b6h call 7FF7C63A96D0h                      ; CALL(Call_rel32_64) [FFFFFFFFFF92E8D0h:jmp64] encoding(5 bytes) = e8 15 e8 92 ff
00bbh int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> and_classBytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0010h vpand xmm0,xmm0,xmm1                    ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 db c1
0014h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
001bh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
001fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_class_scalar(uint x, uint y)
; static ReadOnlySpan<byte> and_class_scalarBytes => new byte[14]{0x48,0x83,0xEC,0x28,0x90,0x23,0xD1,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
; static ReadOnlySpan<byte> and_class_scalarBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x41,0x23,0xD0,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                           ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)] encoding(2 bytes) = 8b 01
0007h and edx,r8d                             ; AND(And_r32_rm32) [EDX,R8D]                encoding(3 bytes) = 41 23 d0
000ah mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> and_structBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpand xmm0,xmm0,xmm1                    ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 db c1
0012h vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_struct_scalar(uint x, uint y)
; static ReadOnlySpan<byte> and_struct_scalarBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
; static ReadOnlySpan<byte> loop_1Bytes => new byte[50]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1C,0x4D,0x63,0xC8,0x4E,0x8D,0x14,0x89,0x46,0x8B,0x0C,0x88,0x41,0xF7,0xD1,0x41,0xFF,0xC1,0x45,0x89,0x0A,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE4,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 01
0008h mov rcx,[rdx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 0a
000bh mov edx,[rdx+8]                         ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 52 08
000eh xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
0011h test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
0013h jle short 0031h                         ; JLE(Jle_rel8_64) [31h:jmp64]               encoding(2 bytes) = 7e 1c
0015h movsxd r9,r8d                           ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]           encoding(3 bytes) = 4d 63 c8
0018h lea r10,[rcx+r9*4]                      ; LEA(Lea_r64_m) [R10,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 4e 8d 14 89
001ch mov r9d,[rax+r9*4]                      ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,:sr)] encoding(4 bytes) = 46 8b 0c 88
0020h not r9d                                 ; NOT(Not_rm32) [R9D]                        encoding(3 bytes) = 41 f7 d1
0023h inc r9d                                 ; INC(Inc_rm32) [R9D]                        encoding(3 bytes) = 41 ff c1
0026h mov [r10],r9d                           ; MOV(Mov_rm32_r32) [mem(32u,R10:br,:sr),R9D] encoding(3 bytes) = 45 89 0a
0029h inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
002ch cmp r8d,edx                             ; CMP(Cmp_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 3b c2
002fh jl short 0015h                          ; JL(Jl_rel8_64) [15h:jmp64]                 encoding(2 bytes) = 7c e4
0031h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
; static ReadOnlySpan<byte> loop_2Bytes => new byte[80]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x07,0x48,0x8D,0x41,0x10,0x8B,0x49,0x08,0x48,0x85,0xD2,0x75,0x04,0x33,0xC9,0xEB,0x08,0x48,0x8D,0x4A,0x10,0x44,0x8B,0x42,0x08,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1F,0x4D,0x63,0xC8,0x4E,0x8D,0x0C,0x89,0x4D,0x63,0xD0,0x46,0x8B,0x14,0x90,0x41,0xF7,0xD2,0x41,0xFF,0xC2,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0008h jne short 000eh                         ; JNE(Jne_rel8_64) [Eh:jmp64]                encoding(2 bytes) = 75 04
000ah xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ch jmp short 0015h                         ; JMP(Jmp_rel8_64) [15h:jmp64]               encoding(2 bytes) = eb 07
000eh lea rax,[rcx+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 48 8d 41 10
0012h mov ecx,[rcx+8]                         ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,:sr)] encoding(3 bytes) = 8b 49 08
0015h test rdx,rdx                            ; TEST(Test_rm64_r64) [RDX,RDX]              encoding(3 bytes) = 48 85 d2
0018h jne short 001eh                         ; JNE(Jne_rel8_64) [1Eh:jmp64]               encoding(2 bytes) = 75 04
001ah xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
001ch jmp short 0026h                         ; JMP(Jmp_rel8_64) [26h:jmp64]               encoding(2 bytes) = eb 08
001eh lea rcx,[rdx+10h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)] encoding(4 bytes) = 48 8d 4a 10
0022h mov r8d,[rdx+8]                         ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,:sr)] encoding(4 bytes) = 44 8b 42 08
0026h mov edx,[rdx+8]                         ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 52 08
0029h xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
002ch test edx,edx                            ; TEST(Test_rm32_r32) [EDX,EDX]              encoding(2 bytes) = 85 d2
002eh jle short 004fh                         ; JLE(Jle_rel8_64) [4Fh:jmp64]               encoding(2 bytes) = 7e 1f
0030h movsxd r9,r8d                           ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]           encoding(3 bytes) = 4d 63 c8
0033h lea r9,[rcx+r9*4]                       ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,:sr)] encoding(4 bytes) = 4e 8d 0c 89
0037h movsxd r10,r8d                          ; MOVSXD(Movsxd_r64_rm32) [R10,R8D]          encoding(3 bytes) = 4d 63 d0
003ah mov r10d,[rax+r10*4]                    ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)] encoding(4 bytes) = 46 8b 14 90
003eh not r10d                                ; NOT(Not_rm32) [R10D]                       encoding(3 bytes) = 41 f7 d2
0041h inc r10d                                ; INC(Inc_rm32) [R10D]                       encoding(3 bytes) = 41 ff c2
0044h mov [r9],r10d                           ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D] encoding(3 bytes) = 45 89 11
0047h inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
004ah cmp r8d,edx                             ; CMP(Cmp_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 3b c2
004dh jl short 0030h                          ; JL(Jl_rel8_64) [30h:jmp64]                 encoding(2 bytes) = 7c e1
004fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
; static ReadOnlySpan<byte> pipeline_1Bytes => new byte[56]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x42,0x08,0x45,0x33,0xC0,0x85,0xC0,0x7E,0x28,0x4C,0x8B,0x0A,0x4D,0x63,0xD0,0x4F,0x8D,0x0C,0x91,0x4C,0x8B,0x11,0x4D,0x63,0xD8,0x47,0x8B,0x14,0x9A,0x41,0xF7,0xD2,0x41,0xFF,0xC2,0x41,0xF7,0xD2,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC0,0x7C,0xD8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx+8]                         ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 42 08
0008h xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
000bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000dh jle short 0037h                         ; JLE(Jle_rel8_64) [37h:jmp64]               encoding(2 bytes) = 7e 28
000fh mov r9,[rdx]                            ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 4c 8b 0a
0012h movsxd r10,r8d                          ; MOVSXD(Movsxd_r64_rm32) [R10,R8D]          encoding(3 bytes) = 4d 63 d0
0015h lea r9,[r9+r10*4]                       ; LEA(Lea_r64_m) [R9,mem(Unknown,R9:br,:sr)] encoding(4 bytes) = 4f 8d 0c 91
0019h mov r10,[rcx]                           ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 4c 8b 11
001ch movsxd r11,r8d                          ; MOVSXD(Movsxd_r64_rm32) [R11,R8D]          encoding(3 bytes) = 4d 63 d8
001fh mov r10d,[r10+r11*4]                    ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,:sr)] encoding(4 bytes) = 47 8b 14 9a
0023h not r10d                                ; NOT(Not_rm32) [R10D]                       encoding(3 bytes) = 41 f7 d2
0026h inc r10d                                ; INC(Inc_rm32) [R10D]                       encoding(3 bytes) = 41 ff c2
0029h not r10d                                ; NOT(Not_rm32) [R10D]                       encoding(3 bytes) = 41 f7 d2
002ch mov [r9],r10d                           ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D] encoding(3 bytes) = 45 89 11
002fh inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
0032h cmp r8d,eax                             ; CMP(Cmp_r32_rm32) [R8D,EAX]                encoding(3 bytes) = 44 3b c0
0035h jl short 000fh                          ; JL(Jl_rel8_64) [Fh:jmp64]                  encoding(2 bytes) = 7c d8
0037h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
; static ReadOnlySpan<byte> pipeline_2Bytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x42,0x08,0x45,0x33,0xC0,0x85,0xC0,0x7E,0x2B,0x4C,0x8B,0x0A,0x4D,0x63,0xD0,0x4F,0x8D,0x0C,0x91,0x4C,0x8B,0x11,0x4D,0x63,0xD8,0x47,0x8B,0x14,0x9A,0x45,0x8B,0xDA,0x41,0xF7,0xD3,0x41,0xFF,0xC3,0x45,0x23,0xD3,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC0,0x7C,0xD5,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx+8]                         ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 42 08
0008h xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
000bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
000dh jle short 003ah                         ; JLE(Jle_rel8_64) [3Ah:jmp64]               encoding(2 bytes) = 7e 2b
000fh mov r9,[rdx]                            ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 4c 8b 0a
0012h movsxd r10,r8d                          ; MOVSXD(Movsxd_r64_rm32) [R10,R8D]          encoding(3 bytes) = 4d 63 d0
0015h lea r9,[r9+r10*4]                       ; LEA(Lea_r64_m) [R9,mem(Unknown,R9:br,:sr)] encoding(4 bytes) = 4f 8d 0c 91
0019h mov r10,[rcx]                           ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 4c 8b 11
001ch movsxd r11,r8d                          ; MOVSXD(Movsxd_r64_rm32) [R11,R8D]          encoding(3 bytes) = 4d 63 d8
001fh mov r10d,[r10+r11*4]                    ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,:sr)] encoding(4 bytes) = 47 8b 14 9a
0023h mov r11d,r10d                           ; MOV(Mov_r32_rm32) [R11D,R10D]              encoding(3 bytes) = 45 8b da
0026h not r11d                                ; NOT(Not_rm32) [R11D]                       encoding(3 bytes) = 41 f7 d3
0029h inc r11d                                ; INC(Inc_rm32) [R11D]                       encoding(3 bytes) = 41 ff c3
002ch and r10d,r11d                           ; AND(And_r32_rm32) [R10D,R11D]              encoding(3 bytes) = 45 23 d3
002fh mov [r9],r10d                           ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D] encoding(3 bytes) = 45 89 11
0032h inc r8d                                 ; INC(Inc_rm32) [R8D]                        encoding(3 bytes) = 41 ff c0
0035h cmp r8d,eax                             ; CMP(Cmp_r32_rm32) [R8D,EAX]                encoding(3 bytes) = 44 3b c0
0038h jl short 000fh                          ; JL(Jl_rel8_64) [Fh:jmp64]                  encoding(2 bytes) = 7c d5
003ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_negate(uint x)
; static ReadOnlySpan<byte> and_negateBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh and eax,ecx                             ; AND(And_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 23 c1
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_negate_ops(uint x)
; static ReadOnlySpan<byte> and_negate_opsBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh and eax,ecx                             ; AND(And_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 23 c1
000dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vxor_128x32u_1(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> vxor_128x32u_1Bytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0x79,0x16,0xC2,0x03,0x33,0xC2,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rcx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
000bh vmovd eax,xmm0                          ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]       encoding(VEX, 4 bytes) = c5 f9 7e c0
000fh vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0013h vpextrd edx,xmm0,3                      ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EDX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c2 03
0019h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
001bh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
001fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
