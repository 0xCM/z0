; 2019-10-18 23:21:10:370
; function: Vec256<ulong> perm4x64_256x64(Vec256<ulong> src)
; location: [7FFDDB424290h, 7FFDDB4242C3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vpermq ymm0,[r8],0E4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,mem(Packed256_Int64,R8:br,DS:sr),e4h:imm8] encoding(VEX, 6 bytes) = c4 c3 fd 00 00 e4
000bh vpermq ymm0,ymm0,0B4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,b4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 b4
0011h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0017h vpermq ymm0,ymm0,78h          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,78h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 78
001dh vpermq ymm0,ymm0,9Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,9ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 9c
0023h vpermq ymm0,ymm0,6Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,6ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 6c
0029h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
002dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0030h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> perm4x64_256x64Bytes => new byte[52]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC3,0xFD,0x00,0x00,0xE4,0xC4,0xE3,0xFD,0x00,0xC0,0xB4,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0xFD,0x00,0xC0,0x78,0xC4,0xE3,0xFD,0x00,0xC0,0x9C,0xC4,0xE3,0xFD,0x00,0xC0,0x6C,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> perm4x64_256x64(ulong a, ulong b, ulong c, ulong d)
; location: [7FFDDB4242E0h, 7FFDDB424333h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
000ah vpinsrq xmm0,xmm0,r9,1        ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,R9,1h:imm8] encoding(VEX, 6 bytes) = c4 c3 f9 22 c1 01
0010h vmovq xmm1,qword ptr [rsp+28h]; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,mem(64u,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e1 f9 6e 4c 24 28
0017h vpinsrq xmm1,xmm1,qword ptr [rsp+30h],1; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,mem(64u,RSP:br,SS:sr),1h:imm8] encoding(VEX, 8 bytes) = c4 e3 f1 22 4c 24 30 01
001fh vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0025h vpermq ymm0,ymm0,0E4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,e4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 e4
002bh vpermq ymm0,ymm0,0B4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,b4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 b4
0031h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0037h vpermq ymm0,ymm0,78h          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,78h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 78
003dh vpermq ymm0,ymm0,9Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,9ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 9c
0043h vpermq ymm0,ymm0,6Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,6ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 6c
0049h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
004dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0050h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> perm4x64_256x64Bytes => new byte[84]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0xF9,0x6E,0xC0,0xC4,0xC3,0xF9,0x22,0xC1,0x01,0xC4,0xE1,0xF9,0x6E,0x4C,0x24,0x28,0xC4,0xE3,0xF1,0x22,0x4C,0x24,0x30,0x01,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC4,0xE3,0xFD,0x00,0xC0,0xE4,0xC4,0xE3,0xFD,0x00,0xC0,0xB4,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0xFD,0x00,0xC0,0x78,0xC4,0xE3,0xFD,0x00,0xC0,0x9C,0xC4,0xE3,0xFD,0x00,0xC0,0x6C,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<uint> blend(Vec256<uint> x, Vec256<uint> y)
; location: [7FFDDB424350h, 7FFDDB424369h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vpblendd ymm0,ymm0,[r8],0AAh  ; VPBLENDD(VEX_Vpblendd_ymm_ymm_ymmm256_imm8) [YMM0,YMM0,mem(Packed256_Int32,R8:br,DS:sr),aah:imm8] encoding(VEX, 6 bytes) = c4 c3 7d 02 00 aa
000fh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blendBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC3,0x7D,0x02,0x00,0xAA,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<uint> blend(Vec128<uint> x, Vec128<uint> y)
; location: [7FFDDB424380h, 7FFDDB424396h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vpblendd xmm0,xmm0,[r8],0Ah   ; VPBLENDD(VEX_Vpblendd_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,mem(Packed128_Int32,R8:br,DS:sr),ah:imm8] encoding(VEX, 6 bytes) = c4 c3 79 02 00 0a
000fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blendBytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC3,0x79,0x02,0x00,0x0A,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Switch14(int x)
; location: [7FFDDB4243B0h, 7FFDDB424480h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea ecx,[rdx-1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 4a ff
0008h cmp ecx,0Dh                   ; CMP(Cmp_rm32_imm8) [ECX,dh:imm32]                    encoding(3 bytes) = 83 f9 0d
000bh ja short 0025h                ; JA(Ja_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 77 18
000dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000fh lea rdx,[7FFDDB424488h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,DS:sr)]       encoding(7 bytes) = 48 8d 15 c2 00 00 00
0016h mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 14 82
0019h lea rcx,[7FFDDB4243B5h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,DS:sr)]       encoding(7 bytes) = 48 8d 0d e5 ff ff ff
0020h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0023h jmp rdx                       ; JMP(Jmp_rm64) [RDX]                                  encoding(2 bytes) = ff e2
0025h add edx,0FFFFE4A8h            ; ADD(Add_rm32_imm32) [EDX,ffffe4a8h:imm32]            encoding(6 bytes) = 81 c2 a8 e4 ff ff
002bh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
002eh ja near ptr 00ceh             ; JA(Ja_rel32_64) [CEh:jmp64]                          encoding(6 bytes) = 0f 87 9a 00 00 00
0034h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0036h lea rdx,[7FFDDB4244C0h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,DS:sr)]       encoding(7 bytes) = 48 8d 15 d3 00 00 00
003dh mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 14 82
0040h lea rcx,[7FFDDB4243B5h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,DS:sr)]       encoding(7 bytes) = 48 8d 0d be ff ff ff
0047h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
004ah jmp rdx                       ; JMP(Jmp_rm64) [RDX]                                  encoding(2 bytes) = ff e2
004ch mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0052h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0058h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005eh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0063h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 6b
0065h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
006ah jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 64
006ch mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
0071h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 5d
0073h mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
0078h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 56
007ah mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
007fh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 4f
0081h mov eax,200h                  ; MOV(Mov_r32_imm32) [EAX,200h:imm32]                  encoding(5 bytes) = b8 00 02 00 00
0086h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 48
0088h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
008dh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 41
008fh mov eax,7ECh                  ; MOV(Mov_r32_imm32) [EAX,7ech:imm32]                  encoding(5 bytes) = b8 ec 07 00 00
0094h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 3a
0096h mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
009bh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 33
009dh mov eax,14h                   ; MOV(Mov_r32_imm32) [EAX,14h:imm32]                   encoding(5 bytes) = b8 14 00 00 00
00a2h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 2c
00a4h mov eax,1Eh                   ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]                   encoding(5 bytes) = b8 1e 00 00 00
00a9h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 25
00abh mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
00b0h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 1e
00b2h mov eax,7ECh                  ; MOV(Mov_r32_imm32) [EAX,7ech:imm32]                  encoding(5 bytes) = b8 ec 07 00 00
00b7h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 17
00b9h mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
00beh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 10
00c0h mov eax,14h                   ; MOV(Mov_r32_imm32) [EAX,14h:imm32]                   encoding(5 bytes) = b8 14 00 00 00
00c5h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 09
00c7h mov eax,1Eh                   ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]                   encoding(5 bytes) = b8 1e 00 00 00
00cch jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 02
00ceh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
00d0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> Switch14Bytes => new byte[209]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x4A,0xFF,0x83,0xF9,0x0D,0x77,0x18,0x8B,0xC1,0x48,0x8D,0x15,0xC2,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xE5,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0x81,0xC2,0xA8,0xE4,0xFF,0xFF,0x83,0xFA,0x04,0x0F,0x87,0x9A,0x00,0x00,0x00,0x8B,0xC2,0x48,0x8D,0x15,0xD3,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xBE,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x04,0x00,0x00,0x00,0xC3,0xB8,0x08,0x00,0x00,0x00,0xC3,0xB8,0x10,0x00,0x00,0x00,0xEB,0x6B,0xB8,0x20,0x00,0x00,0x00,0xEB,0x64,0xB8,0x40,0x00,0x00,0x00,0xEB,0x5D,0xB8,0x80,0x00,0x00,0x00,0xEB,0x56,0xB8,0x00,0x01,0x00,0x00,0xEB,0x4F,0xB8,0x00,0x02,0x00,0x00,0xEB,0x48,0xB8,0x00,0x04,0x00,0x00,0xEB,0x41,0xB8,0xEC,0x07,0x00,0x00,0xEB,0x3A,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x33,0xB8,0x14,0x00,0x00,0x00,0xEB,0x2C,0xB8,0x1E,0x00,0x00,0x00,0xEB,0x25,0xB8,0x00,0x04,0x00,0x00,0xEB,0x1E,0xB8,0xEC,0x07,0x00,0x00,0xEB,0x17,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x10,0xB8,0x14,0x00,0x00,0x00,0xEB,0x09,0xB8,0x1E,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int IfElse10(int x)
; location: [7FFDDB4244F0h, 7FFDDB42456Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 06
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0013h jne short 001bh               ; JNE(Jne_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 75 06
0015h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001bh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
001eh jne short 0026h               ; JNE(Jne_rel8_64) [26h:jmp64]                         encoding(2 bytes) = 75 06
0020h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0026h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0029h jne short 0032h               ; JNE(Jne_rel8_64) [32h:jmp64]                         encoding(2 bytes) = 75 07
002bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0030h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 4a
0032h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0035h jne short 003eh               ; JNE(Jne_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = 75 07
0037h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
003ch jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 3e
003eh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0041h jne short 004ah               ; JNE(Jne_rel8_64) [4Ah:jmp64]                         encoding(2 bytes) = 75 07
0043h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
0048h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 32
004ah cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
004dh jne short 0056h               ; JNE(Jne_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 75 07
004fh mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
0054h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 26
0056h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0059h jne short 0062h               ; JNE(Jne_rel8_64) [62h:jmp64]                         encoding(2 bytes) = 75 07
005bh mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
0060h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 1a
0062h cmp edx,9                     ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]                    encoding(3 bytes) = 83 fa 09
0065h jne short 006eh               ; JNE(Jne_rel8_64) [6Eh:jmp64]                         encoding(2 bytes) = 75 07
0067h mov eax,200h                  ; MOV(Mov_r32_imm32) [EAX,200h:imm32]                  encoding(5 bytes) = b8 00 02 00 00
006ch jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 0e
006eh cmp edx,0Ah                   ; CMP(Cmp_rm32_imm8) [EDX,ah:imm32]                    encoding(3 bytes) = 83 fa 0a
0071h jne short 007ah               ; JNE(Jne_rel8_64) [7Ah:jmp64]                         encoding(2 bytes) = 75 07
0073h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
0078h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 02
007ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> IfElse10Bytes => new byte[125]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x4A,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x3E,0x83,0xFA,0x06,0x75,0x07,0xB8,0x40,0x00,0x00,0x00,0xEB,0x32,0x83,0xFA,0x07,0x75,0x07,0xB8,0x80,0x00,0x00,0x00,0xEB,0x26,0x83,0xFA,0x08,0x75,0x07,0xB8,0x00,0x01,0x00,0x00,0xEB,0x1A,0x83,0xFA,0x09,0x75,0x07,0xB8,0x00,0x02,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x0A,0x75,0x07,0xB8,0x00,0x04,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> get_U8Data()
; location: [7FFDDB424990h, 7FFDDB4249ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,1CCA94489B5h          ; MOV(Mov_r64_imm64) [RAX,1cca94489b5h:imm64]          encoding(10 bytes) = 48 b8 b5 89 44 a9 cc 01 00 00
000fh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0012h mov dword ptr [rcx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,DS:sr),40h:imm32] encoding(7 bytes) = c7 41 08 40 00 00 00
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xB5,0x89,0x44,0xA9,0xCC,0x01,0x00,0x00,0x48,0x89,0x01,0xC7,0x41,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> get_U32Data()
; location: [7FFDDB4249C0h, 7FFDDB424A2Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov rcx,7FFDDB5DD190h         ; MOV(Mov_r64_imm64) [RCX,7ffddb5dd190h:imm64]         encoding(10 bytes) = 48 b9 90 d1 5d db fd 7f 00 00
0015h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
001ah call 7FFE3AF245E0h            ; CALL(Call_rel32_64) [5FAFFC20h:jmp64]                encoding(5 bytes) = e8 01 fc af 5f
001fh mov rdx,1CCA9448975h          ; MOV(Mov_r64_imm64) [RDX,1cca9448975h:imm64]          encoding(10 bytes) = 48 ba 75 89 44 a9 cc 01 00 00
0029h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
002dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0031h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0035h vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
003ah vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
003fh vmovdqu xmm0,xmmword ptr [rdx+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 20
0044h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0049h vmovdqu xmm0,xmmword ptr [rdx+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 30
004eh vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
0053h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0057h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
005ch mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
005fh mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0062h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0065h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U32DataBytes => new byte[107]{0x56,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0xB9,0x90,0xD1,0x5D,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0x01,0xFC,0xAF,0x5F,0x48,0xBA,0x75,0x89,0x44,0xA9,0xCC,0x01,0x00,0x00,0x48,0x8D,0x48,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x6F,0x42,0x20,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x6F,0x42,0x30,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x83,0xC0,0x10,0xBA,0x10,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
; location: [7FFDDB424A50h, 7FFDDB424A6Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ah or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
000dh or edx,[rsp+28h]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 28
0011h or edx,[rsp+30h]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 30
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h or eax,[rsp+38h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 38
001bh or eax,[rsp+40h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 40
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> Or8InlineBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x0B,0xD0,0x41,0x0B,0xD1,0x0B,0x54,0x24,0x28,0x0B,0x54,0x24,0x30,0x8B,0xC2,0x0B,0x44,0x24,0x38,0x0B,0x44,0x24,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint RotLU32Inline(uint x, int offset)
; location: [7FFDDB424A80h, 7FFDDB424A8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> RotLU32InlineBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceIfElse5Inline(int x)
; location: [7FFDDB424AA0h, 7FFDDB424AE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 06
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0013h jne short 001bh               ; JNE(Jne_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 75 06
0015h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001bh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
001eh jne short 0026h               ; JNE(Jne_rel8_64) [26h:jmp64]                         encoding(2 bytes) = 75 06
0020h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0026h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0029h jne short 0032h               ; JNE(Jne_rel8_64) [32h:jmp64]                         encoding(2 bytes) = 75 07
002bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0030h jmp short 0040h               ; JMP(Jmp_rel8_64) [40h:jmp64]                         encoding(2 bytes) = eb 0e
0032h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0035h jne short 003eh               ; JNE(Jne_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = 75 07
0037h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
003ch jmp short 0040h               ; JMP(Jmp_rel8_64) [40h:jmp64]                         encoding(2 bytes) = eb 02
003eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ChoiceIfElse5InlineBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CheckMatches()
; location: [7FFDDB425310h, 7FFDDB42531Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3FFh                  ; MOV(Mov_r32_imm32) [EAX,3ffh:imm32]                  encoding(5 bytes) = b8 ff 03 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> CheckMatchesBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x03,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> ReadU8Data(int count)
; location: [7FFDDB425330h, 7FFDDB42534Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,1CCA94489B5h          ; MOV(Mov_r64_imm64) [RAX,1cca94489b5h:imm64]          encoding(10 bytes) = 48 b8 b5 89 44 a9 cc 01 00 00
000fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0012h mov dword ptr [rdx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,DS:sr),40h:imm32] encoding(7 bytes) = c7 42 08 40 00 00 00
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ReadU8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xB5,0x89,0x44,0xA9,0xCC,0x01,0x00,0x00,0x48,0x89,0x02,0xC7,0x42,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> ReadU32Data(int count)
; location: [7FFDDB425360h, 7FFDDB425372h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov rax,7FFDDB4249C0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb4249c0h:imm64]         encoding(10 bytes) = 48 b8 c0 49 42 db fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> ReadU32DataBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x48,0xB8,0xC0,0x49,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidReturn()
; location: [7FFDDB425700h, 7FFDDB42571Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rcx,1CCBAD03060h          ; MOV(Mov_r64_imm64) [RCX,1ccbad03060h:imm64]          encoding(10 bytes) = 48 b9 60 30 d0 ba cc 01 00 00
000fh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0012h call 7FFDDB4256D0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFFD0h:jmp64]        encoding(5 bytes) = e8 b9 ff ff ff
0017h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0018h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> VoidReturnBytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x60,0x30,0xD0,0xBA,0xCC,0x01,0x00,0x00,0x48,0x8B,0x09,0xE8,0xB9,0xFF,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int SizeTest()
; location: [7FFDDB425740h, 7FFDDB42574Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> SizeTestBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls1()
; location: [7FFDDB425760h, 7FFDDB42576Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDB425700h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425700h:imm64]         encoding(10 bytes) = 48 b8 00 57 42 db fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls1Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x57,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls2()
; location: [7FFDDB425790h, 7FFDDB4257B2h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDB425700h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF70h:jmp64]        encoding(5 bytes) = e8 60 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov rax,7FFDDB425700h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425700h:imm64]         encoding(10 bytes) = 48 b8 00 57 42 db fd 7f 00 00
001dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0021h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0022h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls2Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x60,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x00,0x57,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls3()
; location: [7FFDDB4257D0h, 7FFDDB4257FAh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDB425700h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 20 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FFDDB425700h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 18 ff ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh mov rax,7FFDDB425700h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425700h:imm64]         encoding(10 bytes) = 48 b8 00 57 42 db fd 7f 00 00
0025h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0029h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002ah jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls3Bytes => new byte[45]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x20,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0x18,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x00,0x57,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls4()
; location: [7FFDDB425820h, 7FFDDB425852h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDB425700h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 d0 fe ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FFDDB425700h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c8 fe ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh call 7FFDDB425700h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c0 fe ff ff
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDDB425700h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425700h:imm64]         encoding(10 bytes) = 48 b8 00 57 42 db fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls4Bytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0xD0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC8,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x00,0x57,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int InvokeBinOp(Func<int,int,int> f, int x, int y)
; location: [7FFDDB425870h, 7FFDDB42588Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0009h mov rcx,[rdx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 4a 08
000dh mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0010h mov r8d,r9d                   ; MOV(Mov_r32_rm32) [R8D,R9D]                          encoding(3 bytes) = 45 8b c1
0013h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0017h mov rax,[rax+18h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 48 8b 40 18
001bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> InvokeBinOpBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x89,0x14,0x24,0x48,0x8B,0x4A,0x08,0x41,0x8B,0xD0,0x45,0x8B,0xC1,0x48,0x8B,0x04,0x24,0x48,0x8B,0x40,0x18,0x48,0x83,0xC4,0x08,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int AddMulInline(int x, int y)
; location: [7FFDDB4258B0h, 7FFDDB4258C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h imul ecx,eax                  ; IMUL(Imul_r32_rm32) [ECX,EAX]                        encoding(3 bytes) = 0f af c8
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> AddMulInlineBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x0F,0xAF,0xC8,0x0F,0xAF,0xC2,0x03,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallInvokeBinOp(int x, int y)
; location: [7FFDDB4258E0h, 7FFDDB425948h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000dh mov ebx,r8d                   ; MOV(Mov_r32_rm32) [EBX,R8D]                          encoding(3 bytes) = 41 8b d8
0010h mov rcx,7FFDDB6016C8h         ; MOV(Mov_r64_imm64) [RCX,7ffddb6016c8h:imm64]         encoding(10 bytes) = 48 b9 c8 16 60 db fd 7f 00 00
001ah call 7FFE3AF244B0h            ; CALL(Call_rel32_64) [5FAFEBD0h:jmp64]                encoding(5 bytes) = e8 b1 eb af 5f
001fh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0022h lea rcx,[rbp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBP:br,SS:sr)]       encoding(4 bytes) = 48 8d 4d 08
0026h mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0029h call 7FFE3AF235F0h            ; CALL(Call_rel32_64) [5FAFDD10h:jmp64]                encoding(5 bytes) = e8 e2 dc af 5f
002eh mov rcx,7FFDDB2DD0A0h         ; MOV(Mov_r64_imm64) [RCX,7ffddb2dd0a0h:imm64]         encoding(10 bytes) = 48 b9 a0 d0 2d db fd 7f 00 00
0038h mov [rbp+18h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,SS:sr),RCX]        encoding(4 bytes) = 48 89 4d 18
003ch mov rcx,7FFDDB4258B0h         ; MOV(Mov_r64_imm64) [RCX,7ffddb4258b0h:imm64]         encoding(10 bytes) = 48 b9 b0 58 42 db fd 7f 00 00
0046h mov [rbp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,SS:sr),RCX]        encoding(4 bytes) = 48 89 4d 20
004ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004dh mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0050h mov r8d,edi                   ; MOV(Mov_r32_rm32) [R8D,EDI]                          encoding(3 bytes) = 44 8b c7
0053h mov r9d,ebx                   ; MOV(Mov_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 8b cb
0056h mov rax,7FFDDB425870h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425870h:imm64]         encoding(10 bytes) = 48 b8 70 58 42 db fd 7f 00 00
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0065h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0066h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0067h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0068h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> CallInvokeBinOpBytes => new byte[107]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0xC8,0x16,0x60,0xDB,0xFD,0x7F,0x00,0x00,0xE8,0xB1,0xEB,0xAF,0x5F,0x48,0x8B,0xE8,0x48,0x8D,0x4D,0x08,0x48,0x8B,0xD5,0xE8,0xE2,0xDC,0xAF,0x5F,0x48,0xB9,0xA0,0xD0,0x2D,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x89,0x4D,0x18,0x48,0xB9,0xB0,0x58,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x89,0x4D,0x20,0x48,0x8B,0xCE,0x48,0x8B,0xD5,0x44,0x8B,0xC7,0x44,0x8B,0xCB,0x48,0xB8,0x70,0x58,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget1()
; location: [7FFDDB425970h, 7FFDDB42597Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget2()
; location: [7FFDDB425990h, 7FFDDB42599Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget3()
; location: [7FFDDB4259B0h, 7FFDDB4259BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget4()
; location: [7FFDDB4259D0h, 7FFDDB4259DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump(int target)
; location: [7FFDDB4259F0h, 7FFDDB425A35h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h je short 003bh                ; JE(Je_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 74 31
000ah cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
000dh je short 002eh                ; JE(Je_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 74 1f
000fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0012h je short 0021h                ; JE(Je_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 74 0d
0014h mov rax,7FFDDB4259D0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb4259d0h:imm64]         encoding(10 bytes) = 48 b8 d0 59 42 db fd 7f 00 00
001eh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
0021h mov rax,7FFDDB4259B0h         ; MOV(Mov_r64_imm64) [RAX,7ffddb4259b0h:imm64]         encoding(10 bytes) = 48 b8 b0 59 42 db fd 7f 00 00
002bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
002eh mov rax,7FFDDB425990h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425990h:imm64]         encoding(10 bytes) = 48 b8 90 59 42 db fd 7f 00 00
0038h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
003bh mov rax,7FFDDB425970h         ; MOV(Mov_r64_imm64) [RAX,7ffddb425970h:imm64]         encoding(10 bytes) = 48 b8 70 59 42 db fd 7f 00 00
0045h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> JumpBytes => new byte[72]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x74,0x31,0x83,0xFA,0x02,0x74,0x1F,0x83,0xFA,0x03,0x74,0x0D,0x48,0xB8,0xD0,0x59,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0,0x48,0xB8,0xB0,0x59,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0,0x48,0xB8,0x90,0x59,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0,0x48,0xB8,0x70,0x59,0x42,0xDB,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
