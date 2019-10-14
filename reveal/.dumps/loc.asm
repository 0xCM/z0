; 2019-10-14 04:37:01:850
; function: Vec256<ulong> f06_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA02C0h, 7FFDD0CA0305h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000fh vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0015h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
001ah vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001eh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0024h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
0029h vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
002eh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0033h vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0037h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
003bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_256x64uBytes => new byte[70]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xEF,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f07_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0330h, 7FFDD0CA0356h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpand ymm0,ymm0,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 01
000fh vpor ymm0,ymm0,[rdx]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 02
0013h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0018h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xDB,0x01,0xC5,0xFD,0xEB,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f08_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0370h, 7FFDD0CA03CEh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000fh vmovupd [rsp+28h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 28
0015h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0019h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
001fh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0024h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0028h vmovupd [rsp+28h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 28
002eh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0033h vmovupd ymm0,[rax]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 00
0037h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
003ch vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0042h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0047h vmovupd ymm0,[rax]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 00
004bh vpand ymm0,ymm0,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 01
0050h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0054h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0057h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005ah add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_256x64uBytes => new byte[95]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x28,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0x10,0x00,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0x10,0x00,0xC4,0xC1,0x7D,0xDB,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f09_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA03F0h, 7FFDD0CA0416h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
000fh vpor ymm0,ymm0,[rdx]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 02
0013h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0018h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xEF,0x01,0xC5,0xFD,0xEB,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f0a_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0430h, 7FFDD0CA0451h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vpand ymm0,ymm0,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 01
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7D,0xDB,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f0b_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0470h, 7FFDD0CA04DBh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000fh vmovupd [rsp+28h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 28
0015h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0019h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
001fh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0024h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0028h vmovupd [rsp+28h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 28
002eh vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0032h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0036h vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
003bh vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
0040h vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0046h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
004bh vmovupd ymm0,[rax]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 00
004fh vpor ymm0,ymm0,[r9]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 01
0054h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0059h vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
005dh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0061h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0064h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0067h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
006bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_256x64uBytes => new byte[108]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x28,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x28,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC4,0xC1,0x7D,0xEF,0x00,0xC5,0xFD,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0x10,0x00,0xC4,0xC1,0x7D,0xEB,0x01,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f0c_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0500h, 7FFDD0CA0521h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
000eh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0012h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f0d_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0540h, 7FFDD0CA0592h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000fh vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0015h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
001ah vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001eh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0024h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0028h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
002ch vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0031h vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
0036h vpor ymm0,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 00
003bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0040h vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0044h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0048h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_256x64uBytes => new byte[83]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC4,0xC1,0x7D,0xEF,0x01,0xC4,0xC1,0x7D,0xEB,0x00,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f0e_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA05B0h, 7FFDD0CA05F5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
000bh vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000fh vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0015h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
001ah vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001eh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0024h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
0029h vpor ymm0,ymm0,[r9]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 01
002eh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0033h vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0037h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
003bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_256x64uBytes => new byte[70]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFD,0x10,0x02,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xEB,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f0f_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0620h, 7FFDD0CA063Ch]
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
; function: Vec256<ulong> f10_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0650h, 7FFDD0CA0676h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpor ymm0,ymm0,[r9]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 01
000fh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0014h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0018h vpand ymm0,ymm0,[rdx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 02
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xEB,0x01,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0xDB,0x02,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f11_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0690h, 7FFDD0CA06B2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ah vpor ymm0,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 00
000fh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0014h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0018h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001fh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_256x64uBytes => new byte[35]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x01,0xC4,0xC1,0x7D,0xEB,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f12_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0AD0h, 7FFDD0CA0B15h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ch vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0010h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0016h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
001bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001fh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0025h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0029h vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
002eh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0033h vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0037h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
003bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_256x64uBytes => new byte[70]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f13_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0B40h, 7FFDD0CA0B66h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpand ymm0,ymm0,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 01
000eh vpor ymm0,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 00
0013h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0018h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xDB,0x01,0xC4,0xC1,0x7D,0xEB,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f14_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0B80h, 7FFDD0CA0BC5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ch vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0010h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0016h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
001bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001fh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0025h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0029h vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
002eh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0033h vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0037h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
003bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_256x64uBytes => new byte[70]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x00,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f15_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0BF0h, 7FFDD0CA0C16h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
000eh vpor ymm0,ymm0,[r9]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 01
0013h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0018h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xDB,0x00,0xC4,0xC1,0x7D,0xEB,0x01,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f16_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0C30h, 7FFDD0CA0C8Dh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ch vpor ymm1,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 08
0011h vpcmpeqq ymm2,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d1
0016h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
001ah vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
001fh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0023h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
0029h vpand ymm1,ymm1,[rdx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 db 0a
002dh vmovupd [rsp+28h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 28
0033h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0037h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
003dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0042h vpandn ymm0,ymm0,[rax]        ; VPANDN(VEX_Vpandn_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd df 00
0046h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
004bh vpor ymm0,ymm0,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 00
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_256x64uBytes => new byte[94]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x01,0xC4,0xC1,0x7D,0xEB,0x08,0xC4,0xE2,0x75,0x29,0xD1,0xC5,0xF5,0xEF,0xCA,0xC4,0xC1,0x7D,0xEF,0x00,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC5,0xF5,0xDB,0x0A,0xC5,0xFD,0x11,0x4C,0x24,0x28,0xC5,0xFD,0x10,0x0A,0xC5,0xFD,0x11,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDF,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f17_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0CB0h, 7FFDD0CA0D0Dh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ch vpor ymm1,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM1,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 08
0011h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
0016h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001ah vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
0020h vpand ymm1,ymm1,[rdx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 db 0a
0024h vmovupd [rsp+28h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 28
002ah vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
002eh vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0034h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0039h vpandn ymm0,ymm0,[rax]        ; VPANDN(VEX_Vpandn_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd df 00
003dh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0042h vpor ymm0,ymm0,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 00
0046h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
004bh vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
004fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0053h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0056h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_256x64uBytes => new byte[94]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x01,0xC4,0xC1,0x7D,0xEB,0x08,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC5,0xF5,0xDB,0x0A,0xC5,0xFD,0x11,0x4C,0x24,0x28,0xC5,0xFD,0x10,0x0A,0xC5,0xFD,0x11,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDF,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEB,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f18_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0D30h, 7FFDD0CA0D70h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
000bh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0011h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0015h vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
001ah vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0020h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0024h vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
0029h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
002eh vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0032h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_256x64uBytes => new byte[65]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x00,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f19_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0D90h, 7FFDD0CA0DD1h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ch vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
0010h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0016h vpxor ymm1,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 08
001bh vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0021h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
0026h vpand ymm0,ymm0,[rdx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 02
002ah lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
002fh vpxor ymm0,ymm0,[rax]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd ef 00
0033h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_256x64uBytes => new byte[66]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xC1,0x7D,0xEF,0x08,0xC5,0xFD,0x11,0x4C,0x24,0x08,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0xDB,0x02,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xEF,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f1a_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0DF0h, 7FFDD0CA0E39h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
000bh vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0011h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0015h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
001ah vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
0020h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0024h vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
0029h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
002eh vpand ymm0,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 00
0032h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0037h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
003bh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
003fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0042h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0045h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_256x64uBytes => new byte[74]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0x11,0x44,0x24,0x08,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDB,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f1b_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0E60h, 7FFDD0CA0EC2h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ch vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0010h vpcmpeqq ymm2,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d1
0015h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
0019h vpcmpeqq ymm2,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 d0
001eh vpxor ymm0,ymm0,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd ef c2
0022h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0026h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
002ch vpand ymm1,ymm1,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 75 db 09
0031h vmovupd [rsp+28h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 28
0037h vmovupd ymm1,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 09
003ch vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
0042h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0047h vpandn ymm0,ymm0,[rax]        ; VPANDN(VEX_Vpandn_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd df 00
004bh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0050h vpor ymm0,ymm0,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 00
0054h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0058h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_256x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x10,0x0A,0xC4,0xE2,0x75,0x29,0xD1,0xC5,0xF5,0xEF,0xCA,0xC4,0xE2,0x7D,0x29,0xD0,0xC5,0xFD,0xEF,0xC2,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC4,0xC1,0x75,0xDB,0x09,0xC5,0xFD,0x11,0x4C,0x24,0x28,0xC4,0xC1,0x7D,0x10,0x09,0xC5,0xFD,0x11,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDF,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f97_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CA0EF0h, 7FFDD0CA0F5Dh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ch vpxor ymm0,ymm0,[r9]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 01
0011h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0016h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ah vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
001fh vpand ymm1,ymm1,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 75 db 09
0024h vpcmpeqq ymm2,ymm1,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM2,YMM1,YMM1] encoding(VEX, 5 bytes) = c4 e2 75 29 d1
0029h vpxor ymm1,ymm1,ymm2          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 ef ca
002dh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0031h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
0037h vpand ymm0,ymm0,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 01
003ch vmovupd [rsp+28h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 28
0042h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
0047h vmovupd [rsp+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 08
004dh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0052h vpandn ymm0,ymm1,[rax]        ; VPANDN(VEX_Vpandn_ymm_ymm_ymmm256) [YMM0,YMM1,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 df 00
0056h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
005bh vpor ymm0,ymm0,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 00
005fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0063h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0066h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0069h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
006dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f97_256x64uBytes => new byte[110]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xEF,0x01,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xC1,0x75,0xDB,0x09,0xC4,0xE2,0x75,0x29,0xD1,0xC5,0xF5,0xEF,0xCA,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC4,0xC1,0x7D,0xDB,0x01,0xC5,0xFD,0x11,0x44,0x24,0x28,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFD,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF5,0xDF,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong and_64u(ulong a, ulong b)
; location: [7FFDD0CA12B0h, 7FFDD0CA12BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong or_64u(ulong a, ulong b)
; location: [7FFDD0CA12D0h, 7FFDD0CA12DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor_64u(ulong a, ulong b)
; location: [7FFDD0CA12F0h, 7FFDD0CA12FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong not_64u(ulong a)
; location: [7FFDD0CA1720h, 7FFDD0CA172Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nand_64u(ulong a, ulong b)
; location: [7FFDD0CA1740h, 7FFDD0CA174Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nor_64u(ulong a, ulong b)
; location: [7FFDD0CA1760h, 7FFDD0CA176Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xnor_64u(ulong a, ulong b)
; location: [7FFDD0CA1780h, 7FFDD0CA178Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xor1_64u(ulong a)
; location: [7FFDD0CA17A0h, 7FFDD0CA17ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA17C0h, 7FFDD0CA17D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f01_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA17F0h, 7FFDD0CA1801h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f02_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1820h, 7FFDD0CA1831h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f03_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1850h, 7FFDD0CA185Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f04_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1870h, 7FFDD0CA1881h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f05_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA18A0h, 7FFDD0CA18AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f06_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA18C0h, 7FFDD0CA18D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f07_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA18F0h, 7FFDD0CA1901h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f08_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1920h, 7FFDD0CA1931h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f09_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1950h, 7FFDD0CA1961h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0a_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1980h, 7FFDD0CA198Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0b_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA19A0h, 7FFDD0CA19B4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
000eh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0c_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA19D0h, 7FFDD0CA19DEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0d_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1E00h, 7FFDD0CA1E17h]
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
; function: ulong f0e_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1E30h, 7FFDD0CA1E41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f0f_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1E60h, 7FFDD0CA1E6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f10_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1E80h, 7FFDD0CA1E91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f11_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1EB0h, 7FFDD0CA1EBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f12_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1ED0h, 7FFDD0CA1EE1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x33,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f13_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1F00h, 7FFDD0CA1F11h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f14_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1F30h, 7FFDD0CA1F41h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f15_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1F60h, 7FFDD0CA1F71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f16_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1F90h, 7FFDD0CA1FADh]
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
; function: ulong f17_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1FC0h, 7FFDD0CA1FDDh]
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
; function: ulong f18_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA1FF0h, 7FFDD0CA2001h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f19_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2020h, 7FFDD0CA2037h]
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
; function: ulong f1a_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2050h, 7FFDD0CA2064h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0011h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x33,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1b_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2080h, 7FFDD0CA209Dh]
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
; function: ulong f1c_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA20B0h, 7FFDD0CA20C4h]
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
; location: [7FFDD0CA20E0h, 7FFDD0CA20FDh]
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
; location: [7FFDD0CA2110h, 7FFDD0CA211Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1eBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f1f(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2540h, 7FFDD0CA2551h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1fBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f20(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2570h, 7FFDD0CA257Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,rcx              ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 e8 f2 c1
000ah and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f20Bytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xE8,0xF2,0xC1,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f21(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2590h, 7FFDD0CA25A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f21Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f22(ulong a, ulong b, ulong c)
; location: [7FFDD0CA25C0h, 7FFDD0CA25CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,r8               ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 e8 f2 c0
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f22Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xC2,0xE8,0xF2,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f23(ulong a, ulong b, ulong c)
; location: [7FFDD0CA25E0h, 7FFDD0CA25F7h]
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
; location: [7FFDD0CA2610h, 7FFDD0CA2621h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rcx,rdx                   ; XOR(Xor_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 33 ca
0008h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f24Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xCA,0x49,0x33,0xD0,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong f25(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2640h, 7FFDD0CA265Ah]
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
; function: ulong f97_64u(ulong a, ulong b, ulong c)
; location: [7FFDD0CA2670h, 7FFDD0CA2693h]
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
; function: Bit and_bit(Bit a, Bit b)
; location: [7FFDD0CA26B0h, 7FFDD0CA26C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit or_bit(Bit a, Bit b)
; location: [7FFDD0CA26E0h, 7FFDD0CA26F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit xor_bit(Bit a, Bit b)
; location: [7FFDD0CA2710h, 7FFDD0CA2723h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit not_bit(Bit a)
; location: [7FFDD0CA2740h, 7FFDD0CA2750h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_bitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit nand_bit(Bit a, Bit b)
; location: [7FFDD0CA2770h, 7FFDD0CA2783h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh test eax,edx                  ; TEST(Test_rm32_r32) [EDX,EAX]                        encoding(2 bytes) = 85 c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x85,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit nor_bit(Bit a, Bit b)
; location: [7FFDD0CA27A0h, 7FFDD0CA27B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit xnor_bit(Bit a, Bit b)
; location: [7FFDD0CA27D0h, 7FFDD0CA27E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_bitBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool xnor_bool(bool a, bool b)
; location: [7FFDD0CA2800h, 7FFDD0CA2813h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh cmp eax,edx                   ; CMP(Cmp_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 3b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_boolBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit xor1_bit(Bit a)
; location: [7FFDD0CA2830h, 7FFDD0CA2838h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_bitBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit select_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2850h, 7FFDD0CA286Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 0a
0009h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000dh movsx rax,dl                  ; MOVSX(Movsx_r64_rm8) [RAX,DL]                        encoding(4 bytes) = 48 0f be c2
0011h jmp short 001ah               ; JMP(Jmp_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = eb 07
0013h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0016h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_bitBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x84,0xC9,0x75,0x0A,0x41,0x0F,0xB6,0xD0,0x48,0x0F,0xBE,0xC2,0xEB,0x07,0x0F,0xB6,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f01_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2880h, 7FFDD0CA28ACh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC1,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f02_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA28D0h, 7FFDD0CA28FCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0016h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x41,0x0F,0xB6,0xC0,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f03_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2920h, 7FFDD0CA2938h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000ah movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
000dh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_bitBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x89,0x44,0x24,0x18,0x0F,0xB6,0xC2,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f04_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2950h, 7FFDD0CA297Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000ch or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xC8,0x0B,0xC1,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC2,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f05_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA29A0h, 7FFDD0CA29B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_bitBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f06_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA29D0h, 7FFDD0CA2A11h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_bitBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f07_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2A30h, 7FFDD0CA2A5Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC1,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f08_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2A80h, 7FFDD0CA2AC1h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002ah mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
002eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0031h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_bitBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f09_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2AE0h, 7FFDD0CA2B0Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC1,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0a_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2B30h, 7FFDD0CA2B5Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+18h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 18
0009h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000bh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001bh mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_bitBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x89,0x54,0x24,0x18,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x41,0x0F,0xB6,0xC0,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0b_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2B80h, 7FFDD0CA2BE0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
0014h mov byte ptr [rsp+18h],1      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),1h:imm8]     encoding(5 bytes) = c6 44 24 18 01
0019h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
001ch mov edx,[rsp+18h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 18
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
002fh mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
003ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
003ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0042h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0046h mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 20
004ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004dh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0051h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0054h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0056h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0059h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_bitBytes => new byte[97]{0x48,0x83,0xEC,0x28,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0xC6,0x44,0x24,0x18,0x01,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x18,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0c_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2C00h, 7FFDD0CA2C2Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp+20h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 20
000ah test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000ch sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0018h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
001bh mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0021h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_bitBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x44,0x89,0x44,0x24,0x20,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC2,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0d_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2C50h, 7FFDD0CA2CB0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
0014h mov byte ptr [rsp+18h],1      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),1h:imm8]     encoding(5 bytes) = c6 44 24 18 01
0019h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001dh mov ecx,[rsp+18h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 18
0021h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0024h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0026h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0030h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0033h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
0037h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
003ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0042h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0046h mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 20
004ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004dh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0051h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0054h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0056h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0059h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_bitBytes => new byte[97]{0x48,0x83,0xEC,0x28,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0xC6,0x44,0x24,0x18,0x01,0x41,0x0F,0xB6,0xC0,0x8B,0x4C,0x24,0x18,0x0F,0xB6,0xC9,0x33,0xC1,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0e_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2CD0h, 7FFDD0CA2D11h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_bitBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f0f_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2D30h, 7FFDD0CA2D49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
0009h mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
000eh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0010h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_bitBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f10_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2D60h, 7FFDD0CA2D8Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0022h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC1,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f11_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2DB0h, 7FFDD0CA2DC8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_bitBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f12_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2DE0h, 7FFDD0CA2E21h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_bitBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x84,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f13_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2E40h, 7FFDD0CA2E6Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000ch and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0017h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xC8,0x23,0xC1,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x0F,0xB6,0xC2,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f14_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2E90h, 7FFDD0CA2ED1h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
0008h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0015h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_bitBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x45,0x84,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f15_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2EF0h, 7FFDD0CA2F1Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0016h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
001ah mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_bitBytes => new byte[45]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x41,0x0F,0xB6,0xC0,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f16_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2F40h, 7FFDD0CA2F8Dh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000fh or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0012h sete r8b                      ; SETE(Sete_rm8) [R8L]                                 encoding(4 bytes) = 41 0f 94 c0
0016h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ah mov [rsp+10h],r8b             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(5 bytes) = 44 88 44 24 10
001fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002bh movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0030h movzx edx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 08
0035h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0037h jne short 0042h               ; JNE(Jne_rel8_64) [42h:jmp64]                         encoding(2 bytes) = 75 09
0039h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
003ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0040h jmp short 0049h               ; JMP(Jmp_rel8_64) [49h:jmp64]                         encoding(2 bytes) = eb 07
0042h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0045h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0049h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_bitBytes => new byte[78]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x44,0x8B,0xC0,0x44,0x0B,0xC2,0x41,0x0F,0x94,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x44,0x24,0x10,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x0F,0xB6,0x44,0x24,0x10,0x0F,0xB6,0x54,0x24,0x08,0x84,0xC9,0x75,0x09,0x0F,0xB6,0xC2,0x48,0x0F,0xBE,0xC0,0xEB,0x07,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f17_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA2FB0h, 7FFDD0CA300Dh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000fh or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0012h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0016h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ah mov [rsp+10h],r8b             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(5 bytes) = 44 88 44 24 10
001fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002bh movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0030h movzx edx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 08
0035h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0037h jne short 0042h               ; JNE(Jne_rel8_64) [42h:jmp64]                         encoding(2 bytes) = 75 09
0039h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
003ch movsx rdx,al                  ; MOVSX(Movsx_r64_rm8) [RDX,AL]                        encoding(4 bytes) = 48 0f be d0
0040h jmp short 0049h               ; JMP(Jmp_rel8_64) [49h:jmp64]                         encoding(2 bytes) = eb 07
0042h movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
0045h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0049h mov [rsp],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(3 bytes) = 88 14 24
004ch cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
0050h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0053h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0056h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0059h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_bitBytes => new byte[94]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x44,0x8B,0xC0,0x44,0x0B,0xC2,0x45,0x0F,0xB6,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x44,0x24,0x10,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x0F,0xB6,0x44,0x24,0x10,0x0F,0xB6,0x54,0x24,0x08,0x84,0xC9,0x75,0x09,0x0F,0xB6,0xC2,0x48,0x0F,0xBE,0xD0,0xEB,0x07,0x0F,0xB6,0xD0,0x48,0x0F,0xBE,0xD2,0x88,0x14,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f18_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA3030h, 7FFDD0CA3071h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h mov [rsp+10h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(4 bytes) = 88 54 24 10
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_bitBytes => new byte[66]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xD0,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x88,0x54,0x24,0x10,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f19_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA3090h, 7FFDD0CA30E9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000fh xor r8d,edx                   ; XOR(Xor_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 33 c2
0012h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0016h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001ah mov [rsp+10h],r8b             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(5 bytes) = 44 88 44 24 10
001fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
002bh movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0040h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0044h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0047h mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
004ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004dh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
004fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0052h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0055h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0059h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_bitBytes => new byte[90]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x44,0x8B,0xC0,0x44,0x33,0xC2,0x45,0x0F,0xB6,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x44,0x24,0x10,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x0F,0xB6,0xC1,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f1a_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA3100h, 7FFDD0CA3151h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h mov [rsp+10h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(4 bytes) = 88 54 24 10
0017h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
001bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0027h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
002bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002eh mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 08
0032h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0035h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0037h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0040h cmp byte ptr [rsp],0          ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = 80 3c 24 00
0044h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0047h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_bitBytes => new byte[82]{0x48,0x83,0xEC,0x18,0x90,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xD0,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x88,0x54,0x24,0x10,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x80,0x3C,0x24,0x00,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit f1b_bit(Bit a, Bit b, Bit c)
; location: [7FFDD0CA3170h, 7FFDD0CA31B6h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0007h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0014h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0016h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0023h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0028h movzx edx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 08
002dh test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
0030h jne short 003bh               ; JNE(Jne_rel8_64) [3Bh:jmp64]                         encoding(2 bytes) = 75 09
0032h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0035h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0039h jmp short 0042h               ; JMP(Jmp_rel8_64) [42h:jmp64]                         encoding(2 bytes) = eb 07
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0042h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_bitBytes => new byte[71]{0x48,0x83,0xEC,0x18,0x90,0x84,0xC9,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x84,0xD2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x0F,0xB6,0x44,0x24,0x10,0x0F,0xB6,0x54,0x24,0x08,0x45,0x84,0xC0,0x75,0x09,0x0F,0xB6,0xC2,0x48,0x0F,0xBE,0xC0,0xEB,0x07,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 and_bv64u(BitVector64 a, BitVector64 b)
; location: [7FFDD0CA77C0h, 7FFDD0CA77CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 or_bv64u(BitVector64 a, BitVector64 b)
; location: [7FFDD0CA77E0h, 7FFDD0CA77EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 xor_bv64u(BitVector64 a, BitVector64 b)
; location: [7FFDD0CA7800h, 7FFDD0CA780Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 not_bv64u(BitVector64 a)
; location: [7FFDD0CA7820h, 7FFDD0CA782Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_bv64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 nand_bv64u(BitVector64 a, BitVector64 b)
; location: [7FFDD0CA7840h, 7FFDD0CA784Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_bv64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 nor_bv64u(BitVector64 a, BitVector64 b)
; location: [7FFDD0CA7860h, 7FFDD0CA786Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_bv64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 xnor_bv64u(BitVector64 a, BitVector64 b)
; location: [7FFDD0CA7880h, 7FFDD0CA788Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_bv64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 xor1_bv64u(BitVector64 a)
; location: [7FFDD0CA78A0h, 7FFDD0CA78ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_bv64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 select_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA78C0h, 7FFDD0CA78D4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_bv64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f01_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA78F0h, 7FFDD0CA7901h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f02_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7920h, 7FFDD0CA7931h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f03_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7950h, 7FFDD0CA7963h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(5 bytes) = 4c 89 44 24 18
000ah or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_bv64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x44,0x24,0x18,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f04_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7980h, 7FFDD0CA7991h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f05_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA79B0h, 7FFDD0CA79C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_bv64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x49,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f06_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA79E0h, 7FFDD0CA79F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f07_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7A10h, 7FFDD0CA7A21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f08_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7A40h, 7FFDD0CA7A51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000eh and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f09_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7A70h, 7FFDD0CA7A81h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x33,0xD0,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f0a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7AA0h, 7FFDD0CA7AB3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0010h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_bv64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f0b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7AD0h, 7FFDD0CA7AE4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
000eh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0011h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_bv64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f0c_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7B00h, 7FFDD0CA7B13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+18h],r8              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(5 bytes) = 4c 89 44 24 18
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0010h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_bv64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x44,0x24,0x18,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f0d_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7B30h, 7FFDD0CA7B47h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
000eh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0011h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0014h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_bv64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f0e_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7B60h, 7FFDD0CA7B71h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x49,0x0B,0xD0,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f0f_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7B90h, 7FFDD0CA7BA5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 10
000ah mov [rsp+18h],r8              ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(5 bytes) = 4c 89 44 24 18
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_bv64uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x4C,0x89,0x44,0x24,0x18,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f10_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7BC0h, 7FFDD0CA7BD1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f11_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7BF0h, 7FFDD0CA7C03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_bv64uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f12_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7C20h, 7FFDD0CA7C31h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x49,0x33,0xC8,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f13_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7C50h, 7FFDD0CA7C61h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
0008h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x23,0xC8,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f14_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7C80h, 7FFDD0CA7C91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
000eh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x48,0xF7,0xD0,0x48,0x33,0xD1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f15_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7CB0h, 7FFDD0CA7CC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x49,0x0B,0xD0,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f16_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7CE0h, 7FFDD0CA7CFDh]
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
; static ReadOnlySpan<byte> f16_bv64uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x0B,0xC0,0x48,0xF7,0xD0,0x49,0x33,0xD0,0x48,0x23,0xC1,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f17_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7D10h, 7FFDD0CA7D2Dh]
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
; static ReadOnlySpan<byte> f17_bv64uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x0B,0xC0,0x49,0x23,0xD0,0x48,0x23,0xC1,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f18_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7D40h, 7FFDD0CA7D51h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_bv64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x49,0x33,0xC8,0x48,0x8B,0xC2,0x48,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f19_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA7D70h, 7FFDD0CA7D84h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0008h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
000bh and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
000eh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0011h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_bv64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x49,0x33,0xC0,0x49,0x23,0xD0,0x48,0x23,0xD1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f1a_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA81A0h, 7FFDD0CA81B4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h xor rcx,r8                    ; XOR(Xor_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 33 c8
000bh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_bv64uBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x49,0x33,0xC8,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 f1b_bv64u(BitVector64 a, BitVector64 b, BitVector64 c)
; location: [7FFDD0CA81D0h, 7FFDD0CA81EDh]
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
; static ReadOnlySpan<byte> f1b_bv64uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x49,0x23,0xC0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> one_v128x64u(Vec128<ulong> a)
; location: [7FFDD0CA8200h, 7FFDD0CA8218h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqw xmm0,xmm0,xmm1       ; VPCMPEQW(VEX_Vpcmpeqw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 75 c1
0011h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_v128x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x75,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> zero_v128x64u(Vec128<ulong> a)
; location: [7FFDD0CA8230h, 7FFDD0CA8240h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_v128x64uBytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> not_v128x64u(Vec128<ulong> a)
; location: [7FFDD0CA8260h, 7FFDD0CA8294h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0013h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0018h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001dh vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0023h vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> not_v128x64uBytes => new byte[53]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> xor1_v128x64u(Vec128<ulong> a)
; location: [7FFDD0CA82C0h, 7FFDD0CA82DDh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
000dh vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0012h vpxor xmm0,xmm0,[rdx]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 ef 02
0016h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_v128x64uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0xEF,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> and_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
; location: [7FFDD0CA8300h, 7FFDD0CA8315h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_v128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> nand_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
; location: [7FFDD0CA8730h, 7FFDD0CA878Dh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
0010h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0016h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001ch vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0022h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0028h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002eh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0032h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0038h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003ch vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0041h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0046h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004ch vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0052h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0056h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_v128x64uBytes => new byte[94]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> or_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
; location: [7FFDD0CA87B0h, 7FFDD0CA87C5h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpor xmm0,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_v128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> nor_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
; location: [7FFDD0CA87E0h, 7FFDD0CA883Dh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpor xmm0,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 00
0010h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0016h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001ch vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0022h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0028h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002eh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0032h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0038h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003ch vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0041h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0046h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004ch vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0052h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0056h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_v128x64uBytes => new byte[94]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEB,0x00,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> xor_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
; location: [7FFDD0CA8860h, 7FFDD0CA8875h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpxor xmm0,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 00
000eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_v128x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> xnor_v128x64u(Vec128<ulong> a, Vec128<ulong> b)
; location: [7FFDD0CA8890h, 7FFDD0CA88ADh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpxor xmm0,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 00
000eh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0012h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0016h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_v128x64uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x00,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> select_v128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA88D0h, 7FFDD0CA891Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+18h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 18
0011h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0015h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
001ah vmovupd [rsp+18h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 18
0020h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
0025h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
0029h vmovupd [rsp+8],xmm1          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 08
002fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0034h vpandn xmm0,xmm0,[rax]        ; VPANDN(VEX_Vpandn_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 df 00
0038h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
003dh vpor xmm0,xmm0,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 00
0041h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0045h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_v128x64uBytes => new byte[77]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x18,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x44,0x24,0x18,0xC4,0xC1,0x79,0x10,0x01,0xC5,0xF9,0x10,0x0A,0xC5,0xF9,0x11,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF9,0xDF,0x00,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0xEB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f01_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8940h, 7FFDD0CA89A2h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpor xmm0,xmm0,[r9]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 01
0011h vpor xmm0,xmm0,[rdx]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 02
0015h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
001bh vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0021h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0027h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
002dh vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0033h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0037h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
003dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0041h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0046h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
004bh vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
0051h vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xEB,0x01,0xC5,0xF9,0xEB,0x02,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f02_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA89D0h, 7FFDD0CA8A32h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpor xmm0,xmm0,[rdx]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 02
0010h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0016h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001ch vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0022h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0028h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002eh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0032h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0038h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003ch vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0041h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0046h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004ch vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0052h vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xF9,0xEB,0x02,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC4,0xC1,0x79,0xDB,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f03_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8A60h, 7FFDD0CA8ABDh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpor xmm0,xmm0,[rdx]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 02
0010h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0016h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001ch vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0022h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0028h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002eh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0032h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0038h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003ch vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0041h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0046h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004ch vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0052h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0056h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_128x64uBytes => new byte[94]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xF9,0xEB,0x02,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f04_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8AE0h, 7FFDD0CA8B42h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpor xmm0,xmm0,[r9]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 01
0010h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0016h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001ch vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0022h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0028h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002eh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0032h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0038h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003ch vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0041h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0046h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004ch vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0052h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEB,0x01,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f05_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8B70h, 7FFDD0CA8BCDh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
000ch vpor xmm0,xmm0,[rdx]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 02
0010h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0016h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001ch vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0022h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0028h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002eh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0032h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0038h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003ch vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0041h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0046h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004ch vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0052h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0056h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_128x64uBytes => new byte[94]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x01,0xC5,0xF9,0xEB,0x02,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f06_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8BF0h, 7FFDD0CA8C47h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0011h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0015h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0019h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001dh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0022h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0027h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
002dh vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0033h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0039h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
003eh vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
0043h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0048h vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06_128x64uBytes => new byte[88]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xEF,0x01,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f07_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8C70h, 7FFDD0CA8CD2h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
0011h vpor xmm0,xmm0,[rdx]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 02
0015h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
001bh vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0021h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0027h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
002dh vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0033h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0037h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
003dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0041h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0046h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
004bh vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
0051h vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xDB,0x01,0xC5,0xF9,0xEB,0x02,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f08_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8D00h, 7FFDD0CA8D70h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
0011h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0015h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
001bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
001fh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0023h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0027h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
002ch vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0031h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0037h vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
003dh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
0043h lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 38
0048h vmovupd xmm0,[rax]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 00
004ch vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
0051h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0057h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
005ch vmovupd xmm0,[rax]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 00
0060h vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
0065h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0069h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
006ch add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0070h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08_128x64uBytes => new byte[113]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x38,0x48,0x8D,0x44,0x24,0x38,0xC5,0xF9,0x10,0x00,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0x10,0x00,0xC4,0xC1,0x79,0xDB,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f09_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8DA0h, 7FFDD0CA8E02h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
0011h vpor xmm0,xmm0,[rdx]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 02
0015h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
001bh vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0021h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0027h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
002dh vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0033h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0037h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
003dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0041h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0046h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
004bh vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
0051h vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xEF,0x01,0xC5,0xF9,0xEB,0x02,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f0a_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA8E30h, 7FFDD0CA8E69h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0013h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0018h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001dh vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0023h vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0029h vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0a_128x64uBytes => new byte[58]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC4,0xC1,0x79,0xDB,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f0b_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9290h, 7FFDD0CA930Dh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
0011h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0015h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
001bh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
001fh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0023h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0027h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
002ch vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0031h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0037h vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
003dh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
0043h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0047h vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
004bh vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0050h vpxor xmm0,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 00
0055h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
005bh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0060h vmovupd xmm0,[rax]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 00
0064h vpor xmm0,xmm0,[r9]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 01
0069h lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 38
006eh vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
0072h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0076h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0079h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
007dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0b_128x64uBytes => new byte[126]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC4,0xC1,0x79,0xEF,0x00,0xC5,0xF9,0x11,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0x10,0x00,0xC4,0xC1,0x79,0xEB,0x01,0x48,0x8D,0x44,0x24,0x38,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f0c_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9340h, 7FFDD0CA9379h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0013h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0018h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001dh vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0023h vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0029h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
002eh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0c_128x64uBytes => new byte[58]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f0d_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA93A0h, 7FFDD0CA9404h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0011h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0015h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0019h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001dh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0022h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0027h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
002dh vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0033h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0039h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003dh vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0041h vpcmpeqq xmm0,xmm0,xmm1       ; VPCMPEQQ(VEX_Vpcmpeqq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 29 c1
0046h vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
004bh vpor xmm0,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 00
0050h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0055h vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
0059h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0060h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0d_128x64uBytes => new byte[101]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC4,0xC1,0x79,0xEF,0x01,0xC4,0xC1,0x79,0xEB,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f0e_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9430h, 7FFDD0CA9487h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0011h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0015h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0019h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001dh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0022h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0027h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
002dh vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0033h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0039h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
003eh vpor xmm0,xmm0,[r9]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 01
0043h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0048h vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0e_128x64uBytes => new byte[88]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xEB,0x01,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f0f_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA94B0h, 7FFDD0CA94E4h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0013h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0018h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
001dh vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0023h vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0029h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
002dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0030h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0f_128x64uBytes => new byte[53]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f10_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9510h, 7FFDD0CA9572h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpor xmm0,xmm0,[r9]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 01
0011h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0017h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001dh vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0023h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0029h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002fh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0033h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0039h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003dh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0042h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0047h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004dh vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0053h vpand xmm0,xmm0,[rdx]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 02
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xEB,0x01,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0xDB,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f11_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA95A0h, 7FFDD0CA95FEh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
000ch vpor xmm0,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 00
0011h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0017h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001dh vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0023h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
0029h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
002fh vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0033h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0039h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
003dh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0042h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0047h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
004dh vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0053h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0057h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005ah add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11_128x64uBytes => new byte[95]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x01,0xC4,0xC1,0x79,0xEB,0x00,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f12_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9620h, 7FFDD0CA9677h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0011h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
0016h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001ah vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001eh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0023h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0028h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
002eh vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0034h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
003ah vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
003eh vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
0043h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0048h vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12_128x64uBytes => new byte[88]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x01,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f13_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA96A0h, 7FFDD0CA9702h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
0010h vpor xmm0,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 00
0015h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
001bh vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0021h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0027h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
002dh vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0033h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0037h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
003dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0041h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0046h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
004bh vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
0051h vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x01,0xC4,0xC1,0x79,0xEB,0x00,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f14_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9730h, 7FFDD0CA9787h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0011h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
0016h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
001ah vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
001eh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0023h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0028h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
002eh vmovupd xmm0,[rsp+18h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 18
0034h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
003ah vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
003eh vpxor xmm0,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 00
0043h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0048h vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
004ch vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0050h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0053h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14_128x64uBytes => new byte[88]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC4,0xC1,0x79,0x10,0x01,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x18,0xC5,0xF9,0x10,0x44,0x24,0x18,0xC5,0xF9,0x11,0x44,0x24,0x28,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f15_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA97B0h, 7FFDD0CA9812h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
0010h vpor xmm0,xmm0,[r9]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 01
0015h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
001bh vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0021h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0027h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
002dh vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0033h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0037h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
003dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0041h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0046h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
004bh vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
0051h vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0057h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005eh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15_128x64uBytes => new byte[99]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x00,0xC4,0xC1,0x79,0xEB,0x01,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f16_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9840h, 7FFDD0CA98D3h]
0000h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
000ch vpor xmm1,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 08
0011h vmovapd [rsp+10h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 10
0017h vmovdqu xmm1,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 4c 24 10
001dh vmovdqu xmmword ptr [rsp+48h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 48
0023h vmovupd xmm1,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 48
0029h vmovupd xmm2,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 54 24 48
002fh vpcmpeqd xmm1,xmm1,xmm2       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f1 76 ca
0033h vmovupd xmm2,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 54 24 48
0039h vpxor xmm1,xmm2,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 ef c9
003dh vmovapd [rsp],xmm1            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 29 0c 24
0042h vmovdqu xmm1,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 0c 24
0047h vmovdqu xmmword ptr [rsp+58h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 58
004dh vmovupd xmm1,[rsp+58h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 58
0053h vpxor xmm0,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 00
0058h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
005ch vmovupd [rsp+38h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 38
0062h vpand xmm1,xmm1,[rdx]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 db 0a
0066h vmovupd [rsp+38h],xmm1        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 38
006ch vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
0070h vmovupd [rsp+28h],xmm1        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 28
0076h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
007bh vpandn xmm0,xmm0,[rax]        ; VPANDN(VEX_Vpandn_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 df 00
007fh lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 38
0084h vpor xmm0,xmm0,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 00
0088h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
008ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
008fh add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
0093h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16_128x64uBytes => new byte[148]{0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x01,0xC4,0xC1,0x79,0xEB,0x08,0xC5,0xF9,0x29,0x4C,0x24,0x10,0xC5,0xFA,0x6F,0x4C,0x24,0x10,0xC5,0xFA,0x7F,0x4C,0x24,0x48,0xC5,0xF9,0x10,0x4C,0x24,0x48,0xC5,0xF9,0x10,0x54,0x24,0x48,0xC5,0xF1,0x76,0xCA,0xC5,0xF9,0x10,0x54,0x24,0x48,0xC5,0xE9,0xEF,0xC9,0xC5,0xF9,0x29,0x0C,0x24,0xC5,0xFA,0x6F,0x0C,0x24,0xC5,0xFA,0x7F,0x4C,0x24,0x58,0xC5,0xF9,0x10,0x4C,0x24,0x58,0xC4,0xC1,0x79,0xEF,0x00,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x38,0xC5,0xF1,0xDB,0x0A,0xC5,0xF9,0x11,0x4C,0x24,0x38,0xC5,0xF9,0x10,0x0A,0xC5,0xF9,0x11,0x4C,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF9,0xDF,0x00,0x48,0x8D,0x44,0x24,0x38,0xC5,0xF9,0xEB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x68,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f17_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9900h, 7FFDD0CA9993h]
0000h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
000ch vpor xmm1,xmm0,[r8]           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM1,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 eb 08
0011h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
0016h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
001ah vmovupd [rsp+58h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 58
0020h vpand xmm1,xmm1,[rdx]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 db 0a
0024h vmovupd [rsp+58h],xmm1        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 58
002ah vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
002eh vmovupd [rsp+48h],xmm1        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 48
0034h lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 48
0039h vpandn xmm0,xmm0,[rax]        ; VPANDN(VEX_Vpandn_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 df 00
003dh lea rax,[rsp+58h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 58
0042h vpor xmm0,xmm0,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 00
0046h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
004ch vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
0052h vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0058h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
005eh vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0064h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0068h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
006eh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0072h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0077h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
007ch vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
0082h vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0088h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
008ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
008fh add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
0093h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17_128x64uBytes => new byte[148]{0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x01,0xC4,0xC1,0x79,0xEB,0x08,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x58,0xC5,0xF1,0xDB,0x0A,0xC5,0xF9,0x11,0x4C,0x24,0x58,0xC5,0xF9,0x10,0x0A,0xC5,0xF9,0x11,0x4C,0x24,0x48,0x48,0x8D,0x44,0x24,0x48,0xC5,0xF9,0xDF,0x00,0x48,0x8D,0x44,0x24,0x58,0xC5,0xF9,0xEB,0x00,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x68,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f18_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA99C0h, 7FFDD0CA99FDh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+8],xmm0          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 08
0011h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0015h vpxor xmm0,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 00
001ah vmovupd [rsp+8],xmm0          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 08
0020h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0024h vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
0029h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
002eh vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
0032h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18_128x64uBytes => new byte[62]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x08,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x00,0xC5,0xF9,0x11,0x44,0x24,0x08,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f19_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9A20h, 7FFDD0CA9A5Eh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
000ch vxorps xmm1,xmm1,xmm1         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM1,XMM1,XMM1]  encoding(VEX, 4 bytes) = c5 f0 57 c9
0010h vmovupd [rsp+8],xmm1          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 08
0016h vpxor xmm1,xmm0,[r8]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 08
001bh vmovupd [rsp+8],xmm1          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 11 4c 24 08
0021h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
0026h vpand xmm0,xmm0,[rdx]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 02
002ah lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
002fh vpxor xmm0,xmm0,[rax]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 ef 00
0033h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19_128x64uBytes => new byte[63]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x01,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x11,0x4C,0x24,0x08,0xC4,0xC1,0x79,0xEF,0x08,0xC5,0xF9,0x11,0x4C,0x24,0x08,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0xDB,0x02,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF9,0xEF,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f1a_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9A80h, 7FFDD0CA9AFFh]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
000bh vmovupd [rsp+48h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 48
0011h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0015h vpand xmm0,xmm0,[r8]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 00
001ah vmovupd [rsp+48h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 48
0020h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0024h vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
0029h lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 48
002eh vpand xmm0,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 00
0032h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0038h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
003eh vmovdqu xmmword ptr [rsp+28h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 28
0044h vmovupd xmm0,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 28
004ah vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
0050h vpcmpeqd xmm0,xmm0,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 76 c1
0054h vmovupd xmm1,[rsp+28h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 28
005ah vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
005eh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0063h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0068h vmovdqu xmmword ptr [rsp+38h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 38
006eh vmovupd xmm0,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 38
0074h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0078h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
007bh add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
007fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1a_128x64uBytes => new byte[128]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x48,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x44,0x24,0x48,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xEF,0x01,0x48,0x8D,0x44,0x24,0x48,0xC5,0xF9,0xDB,0x00,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x28,0xC5,0xF9,0x10,0x44,0x24,0x28,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF9,0x76,0xC1,0xC5,0xF9,0x10,0x4C,0x24,0x28,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x38,0xC5,0xF9,0x10,0x44,0x24,0x38,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f1b_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9B30h, 7FFDD0CA9BBBh]
0000h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
000fh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0013h vmovapd [rsp+10h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 10
0019h vmovdqu xmm0,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 10
001fh vmovdqu xmmword ptr [rsp+58h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 58
0025h vmovupd xmm0,[rsp+58h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 44 24 58
002bh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0030h vpcmpeqd xmm2,xmm1,xmm1       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM2,XMM1,XMM1] encoding(VEX, 4 bytes) = c5 f1 76 d1
0034h vpxor xmm1,xmm1,xmm2          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 ef ca
0038h vmovapd [rsp],xmm1            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 29 0c 24
003dh vmovdqu xmm1,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 0c 24
0042h vmovdqu xmmword ptr [rsp+48h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 48
0048h vmovupd xmm1,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 48
004eh vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0052h vmovupd [rsp+38h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 38
0058h vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
005dh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
0063h vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
0068h vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
006eh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0073h vpandn xmm0,xmm1,[rax]        ; VPANDN(VEX_Vpandn_xmm_xmm_xmmm128) [XMM0,XMM1,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 df 00
0077h lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 38
007ch vpor xmm0,xmm0,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 00
0080h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0084h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0087h add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
008bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1b_128x64uBytes => new byte[140]{0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x44,0x24,0x10,0xC5,0xFA,0x7F,0x44,0x24,0x58,0xC5,0xF9,0x10,0x44,0x24,0x58,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x76,0xD1,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0x29,0x0C,0x24,0xC5,0xFA,0x6F,0x0C,0x24,0xC5,0xFA,0x7F,0x4C,0x24,0x48,0xC5,0xF9,0x10,0x4C,0x24,0x48,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x38,0xC4,0xC1,0x79,0xDB,0x01,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC4,0xC1,0x79,0x10,0x01,0xC5,0xF9,0x11,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF1,0xDF,0x00,0x48,0x8D,0x44,0x24,0x38,0xC5,0xF9,0xEB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x68,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<ulong> f97_128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
; location: [7FFDD0CA9BF0h, 7FFDD0CA9C92h]
0000h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vpxor xmm0,xmm0,[r9]          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 ef 01
0011h vpcmpeqd xmm1,xmm0,xmm0       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f9 76 c8
0015h vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
0019h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
001eh vpand xmm1,xmm1,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 71 db 09
0023h vmovapd [rsp+10h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 10
0029h vmovdqu xmm1,xmmword ptr [rsp+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 4c 24 10
002fh vmovdqu xmmword ptr [rsp+48h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 48
0035h vmovupd xmm1,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 48
003bh vmovupd xmm2,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 54 24 48
0041h vpcmpeqd xmm1,xmm1,xmm2       ; VPCMPEQD(VEX_Vpcmpeqd_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 4 bytes) = c5 f1 76 ca
0045h vmovupd xmm2,[rsp+48h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 54 24 48
004bh vpxor xmm1,xmm2,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 ef c9
004fh vmovapd [rsp],xmm1            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 29 0c 24
0054h vmovdqu xmm1,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM1,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 0c 24
0059h vmovdqu xmmword ptr [rsp+58h],xmm1; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 7f 4c 24 58
005fh vmovupd xmm1,[rsp+58h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 58
0065h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0069h vmovupd [rsp+38h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 38
006fh vpand xmm0,xmm0,[r9]          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 db 01
0074h vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
007ah vmovupd xmm0,[r9]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 01
007fh vmovupd [rsp+28h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 28
0085h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
008ah vpandn xmm0,xmm1,[rax]        ; VPANDN(VEX_Vpandn_xmm_xmm_xmmm128) [XMM0,XMM1,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 df 00
008eh lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 38
0093h vpor xmm0,xmm0,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 eb 00
0097h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
009bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
009eh add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
00a2h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f97_128x64uBytes => new byte[163]{0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xC1,0x79,0xEF,0x01,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xC1,0x71,0xDB,0x09,0xC5,0xF9,0x29,0x4C,0x24,0x10,0xC5,0xFA,0x6F,0x4C,0x24,0x10,0xC5,0xFA,0x7F,0x4C,0x24,0x48,0xC5,0xF9,0x10,0x4C,0x24,0x48,0xC5,0xF9,0x10,0x54,0x24,0x48,0xC5,0xF1,0x76,0xCA,0xC5,0xF9,0x10,0x54,0x24,0x48,0xC5,0xE9,0xEF,0xC9,0xC5,0xF9,0x29,0x0C,0x24,0xC5,0xFA,0x6F,0x0C,0x24,0xC5,0xFA,0x7F,0x4C,0x24,0x58,0xC5,0xF9,0x10,0x4C,0x24,0x58,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x38,0xC4,0xC1,0x79,0xDB,0x01,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC4,0xC1,0x79,0x10,0x01,0xC5,0xF9,0x11,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xF1,0xDF,0x00,0x48,0x8D,0x44,0x24,0x38,0xC5,0xF9,0xEB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x68,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> one_v256x64u(Vec256<ulong> a)
; location: [7FFDD0CAA0D0h, 7FFDD0CAA0EBh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqw ymm0,ymm0,ymm1       ; VPCMPEQW(VEX_Vpcmpeqw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 75 c1
0011h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> one_v256x64uBytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x75,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> zero_v256x64u(Vec256<ulong> a)
; location: [7FFDD0CAA100h, 7FFDD0CAA115h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0009h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
000dh vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> zero_v256x64uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> not_v256x64u(Vec256<ulong> a)
; location: [7FFDD0CAA130h, 7FFDD0CAA14Ch]
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
; function: Vec256<ulong> xor1_v256x64u(Vec256<ulong> a)
; location: [7FFDD0CAA160h, 7FFDD0CAA180h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
0009h vxorps ymm1,ymm1,ymm1         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM1,YMM1,YMM1]  encoding(VEX, 4 bytes) = c5 f4 57 c9
000dh vpcmpeqq ymm0,ymm0,ymm1       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 29 c1
0012h vpxor ymm0,ymm0,[rdx]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd ef 02
0016h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor1_v256x64uBytes => new byte[33]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0xEF,0x02,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> and_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
; location: [7FFDD0CAA1A0h, 7FFDD0CAA1B8h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_v256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> nand_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
; location: [7FFDD0CAA1D0h, 7FFDD0CAA1F1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nand_v256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xDB,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> or_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
; location: [7FFDD0CAA210h, 7FFDD0CAA228h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpor ymm0,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_v256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> nor_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
; location: [7FFDD0CAA240h, 7FFDD0CAA261h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpor ymm0,ymm0,[r8]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 00
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nor_v256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEB,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> xor_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
; location: [7FFDD0CAA280h, 7FFDD0CAA298h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
000eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_v256x64uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> xnor_v256x64u(Vec256<ulong> a, Vec256<ulong> b)
; location: [7FFDD0CAA2B0h, 7FFDD0CAA2D1h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpxor ymm0,ymm0,[r8]          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d ef 00
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_v256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEF,0x00,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> select_v256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CAA2F0h, 7FFDD0CAA33Fh]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vxorps ymm0,ymm0,ymm0         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM0,YMM0,YMM0]  encoding(VEX, 4 bytes) = c5 fc 57 c0
000bh vmovupd [rsp+28h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 28
0011h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0015h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
001ah vmovupd [rsp+28h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 28
0020h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
0025h vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0029h vmovupd [rsp+8],ymm1          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 08
002fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0034h vpandn ymm0,ymm0,[rax]        ; VPANDN(VEX_Vpandn_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd df 00
0038h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
003dh vpor ymm0,ymm0,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 00
0041h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0045h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0048h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
004bh add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> select_v256x64uBytes => new byte[80]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x28,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0x11,0x44,0x24,0x28,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFD,0x10,0x0A,0xC5,0xFD,0x11,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0xC5,0xFD,0xDF,0x00,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f01_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CAA360h, 7FFDD0CAA386h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpor ymm0,ymm0,[r9]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 01
000fh vpor ymm0,ymm0,[rdx]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 02
0013h vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0018h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xEB,0x01,0xC5,0xFD,0xEB,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f02_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CAA3A0h, 7FFDD0CAA3C6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpor ymm0,ymm0,[rdx]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 02
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vpand ymm0,ymm0,[r9]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 01
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0xEB,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7D,0xDB,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f03_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CAA3E0h, 7FFDD0CAA401h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpor ymm0,ymm0,[rdx]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 02
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03_256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0xEB,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f04_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CAA420h, 7FFDD0CAA446h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpor ymm0,ymm0,[r9]           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d eb 01
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vpand ymm0,ymm0,[r8]          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d db 00
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04_256x64uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xEB,0x01,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7D,0xDB,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> f05_256x64u(Vec256<ulong> a, Vec256<ulong> b, Vec256<ulong> c)
; location: [7FFDD0CAA460h, 7FFDD0CAA481h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r9]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R9:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 01
000ah vpor ymm0,ymm0,[rdx]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd eb 02
000eh vpcmpeqq ymm1,ymm0,ymm0       ; VPCMPEQQ(VEX_Vpcmpeqq_ymm_ymm_ymmm256) [YMM1,YMM0,YMM0] encoding(VEX, 5 bytes) = c4 e2 7d 29 c8
0013h vpxor ymm0,ymm0,ymm1          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd ef c1
0017h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05_256x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFD,0xEB,0x02,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
