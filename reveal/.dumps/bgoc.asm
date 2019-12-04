; 2019-12-03 18:10:51:418
; function: BitGrid64<N8,N8,ulong> bg_fw64_transpose_8x8x64(BitGrid64<N8,N8,ulong> g)
; location: [7FFDDAFEF5C0h, 7FFDDAFEF610h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0013h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0018h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
001dh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 20
0022h movsxd rcx,eax                ; MOVSXD(Movsxd_r64_rm32) [RCX,EAX]                    encoding(3 bytes) = 48 63 c8
0025h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0028h vpmovmskb ecx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [ECX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c8
002ch mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
002eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0033h vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
0037h vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
003bh dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
003dh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
003fh jge short 001dh               ; JGE(Jge_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = 7d dc
0041h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 20
0046h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004bh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F55F790h:jmp64]                encoding(5 bytes) = e8 40 f7 55 5f
0050h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bg_fw64_transpose_8x8x64Bytes => new byte[81]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x20,0xC4,0xE1,0xF9,0x6E,0xC1,0xB8,0x07,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x20,0x48,0x63,0xC8,0x48,0x03,0xD1,0xC5,0xF9,0xD7,0xC8,0x88,0x0A,0xBA,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xCA,0xC5,0xF9,0xF3,0xC1,0xFF,0xC8,0x85,0xC0,0x7D,0xDC,0x48,0x8B,0x44,0x24,0x20,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x40,0xF7,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid64<N8,N8,ulong> bg_fw64_transpose_8x8x64_ur(BitGrid64<N8,N8,ulong> g)
; location: [7FFDDAFEF630h, 7FFDDAFEF727h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0015h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
001ah lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
001fh add rax,7                     ; ADD(Add_rm64_imm8) [RAX,7h:imm64]                    encoding(4 bytes) = 48 83 c0 07
0023h vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
0027h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0029h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
002eh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0032h vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
0036h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
003bh add rax,6                     ; ADD(Add_rm64_imm8) [RAX,6h:imm64]                    encoding(4 bytes) = 48 83 c0 06
003fh vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
0043h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0045h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
004ah vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
004eh vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
0052h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0057h add rax,5                     ; ADD(Add_rm64_imm8) [RAX,5h:imm64]                    encoding(4 bytes) = 48 83 c0 05
005bh vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
005fh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0061h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0066h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
006ah vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
006eh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0073h add rax,4                     ; ADD(Add_rm64_imm8) [RAX,4h:imm64]                    encoding(4 bytes) = 48 83 c0 04
0077h vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
007bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
007dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0082h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
0086h vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
008ah lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
008fh add rax,3                     ; ADD(Add_rm64_imm8) [RAX,3h:imm64]                    encoding(4 bytes) = 48 83 c0 03
0093h vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
0097h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0099h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
009eh vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00a2h vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
00a6h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
00abh add rax,2                     ; ADD(Add_rm64_imm8) [RAX,2h:imm64]                    encoding(4 bytes) = 48 83 c0 02
00afh vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
00b3h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
00b5h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
00bah vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00beh vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
00c2h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
00c7h inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
00cah vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
00ceh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
00d0h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
00d5h vmovd xmm1,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e c8
00d9h vpsllq xmm0,xmm0,xmm1         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]  encoding(VEX, 4 bytes) = c5 f9 f3 c1
00ddh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
00e2h vpmovmskb edx,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EDX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 d0
00e6h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
00e8h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 20
00edh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00f1h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00f2h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F55F720h:jmp64]                encoding(5 bytes) = e8 29 f6 55 5f
00f7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bg_fw64_transpose_8x8x64_urBytes => new byte[248]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0xC4,0xE1,0xF9,0x6E,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0x83,0xC0,0x07,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0x83,0xC0,0x06,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0x83,0xC0,0x05,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0x83,0xC0,0x04,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0x83,0xC0,0x03,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0x83,0xC0,0x02,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0x48,0xFF,0xC0,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0x48,0x8D,0x44,0x24,0x20,0xC5,0xF9,0xD7,0xD0,0x88,0x10,0x48,0x8B,0x44,0x24,0x20,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x29,0xF6,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid64<uint> bg64_and_32(BitGrid64<uint> gx, BitGrid64<uint> gy)
; location: [7FFDDAFEF760h, 7FFDDAFEF76Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg64_and_32Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid64<N16,N4,uint> bg64_and_32(BitGrid64<N16,N4,uint> gx, BitGrid64<N16,N4,uint> gy)
; location: [7FFDDAFEFB90h, 7FFDDAFEFB9Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg64_and_32Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid128<uint> bg_and_128x32(BitGrid128<uint> gx, BitGrid128<uint> gy)
; location: [7FFDDAFEFBB0h, 7FFDDAFEFBC9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_and_128x32Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid128<N16,N4,uint> bg_and_16x4_128x32(BitGrid128<N16,N4,uint> gx, BitGrid128<N16,N4,uint> gy)
; location: [7FFDDAFF0220h, 7FFDDAFF0239h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_and_16x4_128x32Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid256<N32,N8,uint> bg_and_16x4_128x32(BitGrid256<N32,N8,uint> gx, BitGrid256<N32,N8,uint> gy)
; location: [7FFDDAFF0660h, 7FFDDAFF067Ch]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpand ymm0,ymm0,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]    encoding(VEX, 4 bytes) = c5 fd db c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_and_16x4_128x32Bytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit(ref uint src, byte pos, bit state)
; location: [7FFDDAFF0AA0h, 7FFDDAFF0AD3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 44 8b 08
000bh test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
000eh je short 0022h                ; JE(Je_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 74 12
0010h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0013h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0018h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
001ah or r9d,edx                    ; OR(Or_r32_rm32) [R9D,EDX]                            encoding(3 bytes) = 44 0b ca
001dh mov edx,r9d                   ; MOV(Mov_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 8b d1
0020h jmp short 0031h               ; JMP(Jmp_rel8_64) [31h:jmp64]                         encoding(2 bytes) = eb 0f
0022h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0025h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
002ah shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
002ch not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
002eh and edx,r9d                   ; AND(And_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 23 d1
0031h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bitBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x08,0x45,0x85,0xC0,0x74,0x12,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x44,0x0B,0xCA,0x41,0x8B,0xD1,0xEB,0x0F,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x41,0x23,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_on(ref uint src, byte pos)
; location: [7FFDDAFF0AF0h, 7FFDDAFF0B0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 44 8b 00
000bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0013h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0015h or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0018h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
001bh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_onBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x44,0x0B,0xC2,0x41,0x8B,0xD0,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_off(ref uint src, byte pos)
; location: [7FFDDAFF0B20h, 7FFDDAFF0B3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 44 8b 00
000bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0013h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0015h not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0017h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
001ah mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),EDX]          encoding(2 bytes) = 89 10
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_offBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0xF7,0xD2,0x41,0x23,0xD0,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_vector(in BitCells<N23,byte> src)
; location: [7FFDDAFF0F60h, 7FFDDAFF0F76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh test al,8                     ; TEST(Test_AL_imm8) [AL,8h:imm8]                      encoding(2 bytes) = a8 08
0010h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_vectorBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0xA8,0x08,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int segments()
; location: [7FFDDAFF0F90h, 7FFDDAFF0FBFh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov byte ptr [rsp+10h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 10 00
000ah lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
000fh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0012h mov byte ptr [rsp+8],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 08 00
0017h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001ch mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
001fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0024h add eax,2                     ; ADD(Add_rm32_imm8) [EAX,2h:imm32]                    encoding(3 bytes) = 83 c0 02
0027h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0029h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
002bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentsBytes => new byte[48]{0x48,0x83,0xEC,0x18,0x90,0xC6,0x44,0x24,0x10,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0xC6,0x44,0x24,0x08,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x83,0xC0,0x02,0x33,0xD2,0x03,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int count_segs()
; location: [7FFDDAFF0FE0h, 7FFDDAFF1032h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0022h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
0025h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0027h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
002ah and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
002dh add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
002fh sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0032h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0034h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0037h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
003ah add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
003ch and ecx,0FFFFFFFCh            ; AND(And_rm32_imm8) [ECX,fffffffffffffffch:imm32]     encoding(3 bytes) = 83 e1 fc
003fh sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
0041h jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 04
0043h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0045h jmp short 004ch               ; JMP(Jmp_rel8_64) [4Ch:jmp64]                         encoding(2 bytes) = eb 05
0047h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
004ch add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
004eh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> count_segsBytes => new byte[83]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x03,0x03,0xC8,0x83,0xE1,0xFC,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col_2(int n, ulong src, int row, int col)
; location: [7FFDDAFF1050h, 7FFDDAFF1088h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
000ah imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
000eh add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
0011h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0014h shr rax,6                     ; SHR(Shr_rm64_imm8) [RAX,6h:imm8]                     encoding(4 bytes) = 48 c1 e8 06
0018h lea rdx,[rsp+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 10
001dh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0020h mov rax,[rdx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 04 c2
0024h movsxd rdx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RDX,ECX]                    encoding(3 bytes) = 48 63 d1
0027h and rdx,3Fh                   ; AND(And_rm64_imm8) [RDX,3fh:imm64]                   encoding(4 bytes) = 48 83 e2 3f
002bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0032h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0035h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_row_col_2Bytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x41,0x0F,0xAF,0xC8,0x41,0x03,0xC9,0x48,0x63,0xC1,0x48,0xC1,0xE8,0x06,0x48,0x8D,0x54,0x24,0x10,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC2,0x48,0x63,0xD1,0x48,0x83,0xE2,0x3F,0x0F,0xB6,0xD2,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_g_position(in ulong src, int pos)
; location: [7FFDDAFF10A0h, 7FFDDAFF10C7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h shr rax,6                     ; SHR(Shr_rm64_imm8) [RAX,6h:imm8]                     encoding(4 bytes) = 48 c1 e8 06
000ch movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000fh mov rax,[rcx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 04 c1
0013h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0016h and rdx,3Fh                   ; AND(And_rm64_imm8) [RDX,3fh:imm64]                   encoding(4 bytes) = 48 83 e2 3f
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0021h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_g_positionBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0xC1,0xE8,0x06,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC1,0x48,0x63,0xD2,0x48,0x83,0xE2,0x3F,0x0F,0xB6,0xD2,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
