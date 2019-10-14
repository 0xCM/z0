; 2019-10-14 04:37:03:572
; function: void cir_fa_8b(Bit x1, Bit x2, Bit x3, out Bit x7, out Bit x8)
; location: [7FFDD0EA6F90h, 7FFDD0EA7007h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov byte ptr [rsp+10h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 10 00
000ah mov byte ptr [rsp+8],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 08 00
000fh mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = c6 04 24 00
0013h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
001bh xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
001dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0020h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0023h mov [rsp+10h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 10
0027h mov ecx,[rsp+10h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 10
002bh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0032h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0035h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0038h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
003bh mov [rsp+8],cl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 08
003fh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0041h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0044h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0047h mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
004ah mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
004eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0051h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0054h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0057h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),AL]             encoding(3 bytes) = 41 88 01
005ah mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
005eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0061h mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
0064h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0067h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0069h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006ch mov rdx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 40
0071h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0073h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0077h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_8bBytes => new byte[120]{0x48,0x83,0xEC,0x18,0x90,0xC6,0x44,0x24,0x10,0x00,0xC6,0x44,0x24,0x08,0x00,0xC6,0x04,0x24,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xC8,0x33,0xCA,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x10,0x8B,0x4C,0x24,0x10,0x0F,0xB6,0xC9,0x45,0x0F,0xB6,0xC0,0x41,0x23,0xC8,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x08,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x04,0x24,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x41,0x33,0xC0,0x0F,0xB6,0xC0,0x41,0x88,0x01,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x48,0x8B,0x54,0x24,0x40,0x88,0x02,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: OutPair<Bit> cir_fa_8b_pair(Bit x1, Bit x2, Bit x3)
; location: [7FFDD0EA7430h, 7FFDD0EA7507h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov byte ptr [rsp+50h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 50 00
000ch mov byte ptr [rsp+48h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 48 00
0011h mov byte ptr [rsp+40h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 40 00
0016h mov byte ptr [rsp+38h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 38 00
001bh mov byte ptr [rsp+30h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 30 00
0020h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0028h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
002ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0030h mov [rsp+50h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 50
0034h mov ecx,[rsp+50h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 50
0038h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
003bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
003fh and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0042h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0045h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0048h mov [rsp+48h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 48
004ch and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
004eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0051h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0054h mov [rsp+40h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 40
0058h mov eax,[rsp+50h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 50
005ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0062h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0065h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0068h mov [rsp+38h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 38
006ch mov eax,[rsp+48h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 48
0070h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0073h mov edx,[rsp+40h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 40
0077h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
007ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
007ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0082h mov [rsp+30h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 30
0086h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
008bh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
008fh vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0093h movzx eax,byte ptr [rsp+38h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 38
0098h movzx edx,byte ptr [rsp+30h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 30
009dh mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
00a1h mov [rsp+28h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(4 bytes) = 88 54 24 28
00a5h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
00abh vmovdqu xmmword ptr [rsp+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 10
00b1h mov byte ptr [rsp+8],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 08 00
00b6h mov byte ptr [rsp+9],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 09 00
00bbh movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
00c0h movzx edx,byte ptr [rsp+18h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 18
00c5h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
00c9h mov [rsp+9],dl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(4 bytes) = 88 54 24 09
00cdh movsx rax,word ptr [rsp+8]    ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 08
00d3h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
00d7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_8b_pairBytes => new byte[216]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC6,0x44,0x24,0x50,0x00,0xC6,0x44,0x24,0x48,0x00,0xC6,0x44,0x24,0x40,0x00,0xC6,0x44,0x24,0x38,0x00,0xC6,0x44,0x24,0x30,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xC8,0x33,0xCA,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x50,0x8B,0x4C,0x24,0x50,0x0F,0xB6,0xC9,0x45,0x0F,0xB6,0xC0,0x41,0x23,0xC8,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x48,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x40,0x8B,0x44,0x24,0x50,0x0F,0xB6,0xC0,0x41,0x33,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x38,0x8B,0x44,0x24,0x48,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x40,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x30,0x48,0x8D,0x44,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0x0F,0xB6,0x44,0x24,0x38,0x0F,0xB6,0x54,0x24,0x30,0x88,0x44,0x24,0x20,0x88,0x54,0x24,0x28,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x10,0xC6,0x44,0x24,0x08,0x00,0xC6,0x44,0x24,0x09,0x00,0x0F,0xB6,0x44,0x24,0x10,0x0F,0xB6,0x54,0x24,0x18,0x88,0x44,0x24,0x08,0x88,0x54,0x24,0x09,0x48,0x0F,0xBF,0x44,0x24,0x08,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_8u(byte x1, byte x2, byte x3, out byte x7, out byte x8)
; location: [7FFDD0EA7520h, 7FFDD0EA7586h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh mov [rsp+18h],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 18
0012h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0017h movzx edx,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 10
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0021h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0024h movzx edx,byte ptr [rsp+18h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 18
0029h movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
002ch and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
002eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0031h movzx ecx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 08
0036h movzx r8d,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(6 bytes) = 44 0f b6 44 24 10
003ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
003fh and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0042h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0045h movzx r8d,byte ptr [rsp+18h]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(6 bytes) = 44 0f b6 44 24 18
004bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004eh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0051h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0054h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),AL]             encoding(3 bytes) = 41 88 01
0057h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
005ah or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
005ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005fh mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 28
0064h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0066h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_8uBytes => new byte[103]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x44,0x89,0x44,0x24,0x18,0x0F,0xB6,0x44,0x24,0x08,0x0F,0xB6,0x54,0x24,0x10,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0x54,0x24,0x18,0x0F,0xB6,0xC8,0x23,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0x4C,0x24,0x08,0x44,0x0F,0xB6,0x44,0x24,0x10,0x0F,0xB6,0xC9,0x41,0x23,0xC8,0x0F,0xB6,0xC9,0x44,0x0F,0xB6,0x44,0x24,0x18,0x0F,0xB6,0xC0,0x41,0x33,0xC0,0x0F,0xB6,0xC0,0x41,0x88,0x01,0x0F,0xB6,0xC2,0x0B,0xC1,0x0F,0xB6,0xC0,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_32u(uint x1, uint x2, uint x3, out uint x7, out uint x8)
; location: [7FFDD0EA75A0h, 7FFDD0EA75C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h mov r10d,eax                  ; MOV(Mov_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 8b d0
000ch and r10d,r8d                  ; AND(And_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 23 d0
000fh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0011h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0014h mov [r9],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 01
0017h or edx,r10d                   ; OR(Or_r32_rm32) [EDX,R10D]                           encoding(3 bytes) = 41 0b d2
001ah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
001fh mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_32uBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0x44,0x8B,0xD0,0x45,0x23,0xD0,0x23,0xD1,0x41,0x33,0xC0,0x41,0x89,0x01,0x41,0x0B,0xD2,0x48,0x8B,0x44,0x24,0x28,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_64u(ulong x1, ulong x2, ulong x3, out ulong x7, out ulong x8)
; location: [7FFDD0EA75E0h, 7FFDD0EA7605h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh mov r10,rax                   ; MOV(Mov_r64_rm64) [R10,RAX]                          encoding(3 bytes) = 4c 8b d0
000eh and r10,r8                    ; AND(And_r64_rm64) [R10,R8]                           encoding(3 bytes) = 4d 23 d0
0011h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0014h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0017h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 01
001ah or rdx,r10                    ; OR(Or_r64_rm64) [RDX,R10]                            encoding(3 bytes) = 49 0b d2
001dh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
0022h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0x4C,0x8B,0xD0,0x4D,0x23,0xD0,0x48,0x23,0xD1,0x49,0x33,0xC0,0x49,0x89,0x01,0x49,0x0B,0xD2,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 cir_fa_bv32x64(BitVector32 x1, BitVector32 x2, BitVector32 x3)
; location: [7FFDD0EA7620h, 7FFDD0EA7640h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
000ch and r9d,r8d                   ; AND(And_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 23 c8
000fh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0011h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0014h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0017h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
001bh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
001dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_bv32x64Bytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0x44,0x8B,0xC8,0x45,0x23,0xC8,0x23,0xD1,0x41,0x33,0xC0,0x41,0x0B,0xD1,0x48,0xC1,0xE2,0x20,0x8B,0xC0,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_128x8u(Vec128<byte> x1, Vec128<byte> x2, Vec128<byte> x3, out Vec128<byte> x7, out Vec128<byte> x8)
; location: [7FFDD0EA7660h, 7FFDD0EA76CDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
0010h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0014h vmovupd [rsp+18h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 18
001ah vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
001eh vmovupd [rsp+8],xmm2          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 08
0024h vpxor xmm2,xmm1,[rcx]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM1,mem(Packed128_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 ef 11
0028h vmovupd [rsp+18h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 18
002eh lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
0033h vmovupd xmm2,[rax]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 10
0037h vpand xmm2,xmm2,xmm0          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM0]    encoding(VEX, 4 bytes) = c5 e9 db d0
003bh vmovupd [rsp+8],xmm2          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 08
0041h vmovupd xmm2,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM2,mem(Packed128_Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 11
0045h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0049h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
004eh vpxor xmm0,xmm0,[rax]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 ef 00
0052h vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
0057h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
005ch vpor xmm0,xmm1,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 eb 00
0060h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
0065h vmovupd [rax],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 00
0069h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_128x8uBytes => new byte[110]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xF9,0x10,0x0A,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x18,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x08,0xC5,0xF1,0xEF,0x11,0xC5,0xF9,0x11,0x54,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0x10,0x10,0xC5,0xE9,0xDB,0xD0,0xC5,0xF9,0x11,0x54,0x24,0x08,0xC5,0xF9,0x10,0x11,0xC5,0xE9,0xDB,0xC9,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0xEF,0x00,0xC4,0xC1,0x79,0x11,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF1,0xEB,0x00,0x48,0x8B,0x44,0x24,0x50,0xC5,0xF9,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_128x32u(Vec128<uint> x1, Vec128<uint> x2, Vec128<uint> x3, out Vec128<uint> x7, out Vec128<uint> x8)
; location: [7FFDD0EA7700h, 7FFDD0EA7765h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
0010h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0014h vmovupd [rsp+18h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 18
001ah vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
001eh vmovupd [rsp+8],xmm2          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 08
0024h vpxor xmm2,xmm1,[rcx]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM1,mem(Packed128_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 ef 11
0028h vmovupd [rsp+18h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 18
002eh lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
0033h vpand xmm2,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 10
0037h vmovupd [rsp+8],xmm2          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 08
003dh vpand xmm1,xmm1,[rcx]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,mem(Packed128_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 db 09
0041h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
0046h vpxor xmm0,xmm0,[rax]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 ef 00
004ah vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
004fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0054h vpor xmm0,xmm1,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 eb 00
0058h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
005dh vmovupd [rax],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 00
0061h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_128x32uBytes => new byte[102]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xF9,0x10,0x0A,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x18,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x08,0xC5,0xF1,0xEF,0x11,0xC5,0xF9,0x11,0x54,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0xDB,0x10,0xC5,0xF9,0x11,0x54,0x24,0x08,0xC5,0xF1,0xDB,0x09,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0xEF,0x00,0xC4,0xC1,0x79,0x11,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF1,0xEB,0x00,0x48,0x8B,0x44,0x24,0x50,0xC5,0xF9,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_128x64u(Vec128<ulong> x1, Vec128<ulong> x2, Vec128<ulong> x3, out Vec128<ulong> x7, out Vec128<ulong> x8)
; location: [7FFDD0EA7790h, 7FFDD0EA77F5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 00
000ch vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
0010h vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
0014h vmovupd [rsp+18h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 18
001ah vxorps xmm2,xmm2,xmm2         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM2,XMM2,XMM2]  encoding(VEX, 4 bytes) = c5 e8 57 d2
001eh vmovupd [rsp+8],xmm2          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 08
0024h vpxor xmm2,xmm1,[rcx]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM1,mem(Packed128_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 ef 11
0028h vmovupd [rsp+18h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 18
002eh lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
0033h vpand xmm2,xmm0,[rax]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 db 10
0037h vmovupd [rsp+8],xmm2          ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 11 54 24 08
003dh vpand xmm1,xmm1,[rcx]         ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,mem(Packed128_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 db 09
0041h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 18
0046h vpxor xmm0,xmm0,[rax]         ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 ef 00
004ah vmovupd [r9],xmm0             ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,R9:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 79 11 01
004fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0054h vpor xmm0,xmm1,[rax]          ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM1,mem(Packed128_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f1 eb 00
0058h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
005dh vmovupd [rax],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 00
0061h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_128x64uBytes => new byte[102]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC4,0xC1,0x79,0x10,0x00,0xC5,0xF9,0x10,0x0A,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x18,0xC5,0xE8,0x57,0xD2,0xC5,0xF9,0x11,0x54,0x24,0x08,0xC5,0xF1,0xEF,0x11,0xC5,0xF9,0x11,0x54,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0xDB,0x10,0xC5,0xF9,0x11,0x54,0x24,0x08,0xC5,0xF1,0xDB,0x09,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF9,0xEF,0x00,0xC4,0xC1,0x79,0x11,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF1,0xEB,0x00,0x48,0x8B,0x44,0x24,0x50,0xC5,0xF9,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_256x8u(Vec256<byte> x1, Vec256<byte> x2, Vec256<byte> x3, out Vec256<byte> x7, out Vec256<byte> x8)
; location: [7FFDD0EA7820h, 7FFDD0EA7888h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ch vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0010h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0014h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
001ah vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001eh vmovupd [rsp+8],ymm2          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 08
0024h vpxor ymm2,ymm1,[rcx]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM1,mem(Packed256_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 ef 11
0028h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
002eh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0033h vpand ymm2,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 10
0037h vmovupd [rsp+8],ymm2          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 08
003dh vpand ymm1,ymm1,[rcx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 db 09
0041h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0046h vpxor ymm0,ymm0,[rax]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd ef 00
004ah vmovupd [r9],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R9:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 01
004fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0054h vpor ymm0,ymm1,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 eb 00
0058h mov rax,[rsp+70h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 70
005dh vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_256x8uBytes => new byte[105]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x10,0x0A,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x08,0xC5,0xF5,0xEF,0x11,0xC5,0xFD,0x11,0x54,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xDB,0x10,0xC5,0xFD,0x11,0x54,0x24,0x08,0xC5,0xF5,0xDB,0x09,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEF,0x00,0xC4,0xC1,0x7D,0x11,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF5,0xEB,0x00,0x48,0x8B,0x44,0x24,0x70,0xC5,0xFD,0x11,0x00,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_256x32u(Vec256<uint> x1, Vec256<uint> x2, Vec256<uint> x3, out Vec256<uint> x7, out Vec256<uint> x8)
; location: [7FFDD0EA78B0h, 7FFDD0EA7918h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ch vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0010h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0014h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
001ah vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001eh vmovupd [rsp+8],ymm2          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 08
0024h vpxor ymm2,ymm1,[rcx]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM1,mem(Packed256_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 ef 11
0028h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
002eh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0033h vpand ymm2,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 10
0037h vmovupd [rsp+8],ymm2          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 08
003dh vpand ymm1,ymm1,[rcx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 db 09
0041h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0046h vpxor ymm0,ymm0,[rax]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd ef 00
004ah vmovupd [r9],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R9:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 01
004fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0054h vpor ymm0,ymm1,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 eb 00
0058h mov rax,[rsp+70h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 70
005dh vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_256x32uBytes => new byte[105]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x10,0x0A,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x08,0xC5,0xF5,0xEF,0x11,0xC5,0xFD,0x11,0x54,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xDB,0x10,0xC5,0xFD,0x11,0x54,0x24,0x08,0xC5,0xF5,0xDB,0x09,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEF,0x00,0xC4,0xC1,0x7D,0x11,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF5,0xEB,0x00,0x48,0x8B,0x44,0x24,0x70,0xC5,0xFD,0x11,0x00,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void cir_fa_256x64u(Vec256<ulong> x1, Vec256<ulong> x2, Vec256<ulong> x3, out Vec256<ulong> x7, out Vec256<ulong> x8)
; location: [7FFDD0EA7940h, 7FFDD0EA79A8h]
0000h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ch vmovupd ymm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 0a
0010h vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
0014h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
001ah vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
001eh vmovupd [rsp+8],ymm2          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 08
0024h vpxor ymm2,ymm1,[rcx]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM1,mem(Packed256_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 ef 11
0028h vmovupd [rsp+28h],ymm2        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 28
002eh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0033h vpand ymm2,ymm0,[rax]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd db 10
0037h vmovupd [rsp+8],ymm2          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,SS:sr),YMM2] encoding(VEX, 6 bytes) = c5 fd 11 54 24 08
003dh vpand ymm1,ymm1,[rcx]         ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,mem(Packed256_UInt64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 db 09
0041h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0046h vpxor ymm0,ymm0,[rax]         ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd ef 00
004ah vmovupd [r9],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R9:br,DS:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 01
004fh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0054h vpor ymm0,ymm1,[rax]          ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM1,mem(Packed256_UInt64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f5 eb 00
0058h mov rax,[rsp+70h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 70
005dh vmovupd [rax],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 00
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> cir_fa_256x64uBytes => new byte[105]{0x48,0x83,0xEC,0x48,0xC5,0xF8,0x77,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x10,0x0A,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x28,0xC5,0xEC,0x57,0xD2,0xC5,0xFD,0x11,0x54,0x24,0x08,0xC5,0xF5,0xEF,0x11,0xC5,0xFD,0x11,0x54,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xDB,0x10,0xC5,0xFD,0x11,0x54,0x24,0x08,0xC5,0xF5,0xDB,0x09,0x48,0x8D,0x44,0x24,0x28,0xC5,0xFD,0xEF,0x00,0xC4,0xC1,0x7D,0x11,0x01,0x48,0x8D,0x44,0x24,0x08,0xC5,0xF5,0xEB,0x00,0x48,0x8B,0x44,0x24,0x70,0xC5,0xFD,0x11,0x00,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x48,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
