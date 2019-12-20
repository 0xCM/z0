; 2019-12-20 15:38:57:276
; function: BitSpan bitspan_64_buffered(Block64<byte> packed, Block64<byte> buffer, Block256<uint> target)
; location: [7FF7C7EA8F50h, 7FF7C7EA904Ah]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,50h                   ; SUB(Sub_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 ec 50
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 20
0012h mov ecx,0Ch                   ; MOV(Mov_r32_imm32) [ECX,ch:imm32]                    encoding(5 bytes) = b9 0c 00 00 00
0017h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0019h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
001bh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001eh mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0021h lea rax,[rsp+40h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 40
0026h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ah vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
002eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0030h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 0a
0033h movsxd r10,eax                ; MOVSXD(Movsxd_r64_rm32) [R10,EAX]                    encoding(3 bytes) = 4c 63 d0
0036h movzx ecx,byte ptr [rcx+r10]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)]        encoding(5 bytes) = 42 0f b6 0c 11
003bh mov r10d,[r8+8]               ; MOV(Mov_r32_rm32) [R10D,mem(32u,R8:br,:sr)]          encoding(4 bytes) = 45 8b 50 08
003fh cmp r10,8                     ; CMP(Cmp_rm64_imm8) [R10,8h:imm64]                    encoding(4 bytes) = 49 83 fa 08
0043h jb near ptr 00f5h             ; JB(Jb_rel32_64) [F5h:jmp64]                          encoding(6 bytes) = 0f 82 ac 00 00 00
0049h mov r10,[r8]                  ; MOV(Mov_r64_rm64) [R10,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 4d 8b 10
004ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004fh mov r11,101010101010101h      ; MOV(Mov_r64_imm64) [R11,101010101010101h:imm64]      encoding(10 bytes) = 49 bb 01 01 01 01 01 01 01 01
0059h pdep rcx,rcx,r11              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R11]            encoding(VEX, 5 bytes) = c4 c2 f3 f5 cb
005eh mov [r10],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,R10:br,:sr),RCX]          encoding(3 bytes) = 49 89 0a
0061h mov rcx,[r8]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 08
0064h vpmovzxbd ymm0,qword ptr [rcx]; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,mem(Packed64_UInt8,RCX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 31 01
0069h mov rcx,[r9]                  ; MOV(Mov_r64_rm64) [RCX,mem(64u,R9:br,:sr)]           encoding(3 bytes) = 49 8b 09
006ch mov r10d,eax                  ; MOV(Mov_r32_rm32) [R10D,EAX]                         encoding(3 bytes) = 44 8b d0
006fh shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0073h movsxd r10,r10d               ; MOVSXD(Movsxd_r64_rm32) [R10,R10D]                   encoding(3 bytes) = 4d 63 d2
0076h lea rcx,[rcx+r10*4]           ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 4a 8d 0c 91
007ah vmovdqu ymmword ptr [rcx],ymm0; VMOVDQU(VEX_Vmovdqu_ymmm256_ymm) [mem(Packed256_Int32,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fe 7f 01
007eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0080h cmp eax,8                     ; CMP(Cmp_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 f8 08
0083h jl short 0030h                ; JL(Jl_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 7c ab
0085h mov rax,[r9]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R9:br,:sr)]           encoding(3 bytes) = 49 8b 01
0088h mov edx,[r9+8]                ; MOV(Mov_r32_rm32) [EDX,mem(32u,R9:br,:sr)]           encoding(4 bytes) = 41 8b 51 08
008ch lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 30
0091h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0095h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0099h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 30
009eh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
00a1h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
00a4h vmovdqu xmm0,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 30
00aah vmovdqu xmmword ptr [rsp+40h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 40
00b0h lea rax,[rsp+40h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 40
00b5h mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 10
00b8h mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 08
00bbh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
00c0h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
00c4h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00c8h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
00cdh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
00d0h mov [rcx+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 08
00d3h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
00d6h lea rsi,[rsp+20h]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 74 24 20
00dbh call 7FF827265E90h            ; CALL(Call_rel32_64) [5F3BCF40h:jmp64]                encoding(5 bytes) = e8 60 ce 3b 5f
00e0h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,:sr)]         encoding(2 bytes) = 48 a5
00e2h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
00e5h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00e8h add rsp,50h                   ; ADD(Add_rm64_imm8) [RSP,50h:imm64]                   encoding(4 bytes) = 48 83 c4 50
00ech pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00edh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00eeh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00efh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00f0h call 7FF82738FC20h            ; CALL(Call_rel32_64) [5F4E6CD0h:jmp64]                encoding(5 bytes) = e8 db 6b 4e 5f
00f5h call 7FF7C775D1A8h            ; CALL(Call_rel32_64) [FFFFFFFFFF8B4258h:jmp64]        encoding(5 bytes) = e8 5e 41 8b ff
00fah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitspan_64_bufferedBytes => new byte[251]{0x57,0x56,0x53,0x48,0x83,0xEC,0x50,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x0C,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xD9,0x48,0x8D,0x44,0x24,0x40,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0x33,0xC0,0x48,0x8B,0x0A,0x4C,0x63,0xD0,0x42,0x0F,0xB6,0x0C,0x11,0x45,0x8B,0x50,0x08,0x49,0x83,0xFA,0x08,0x0F,0x82,0xAC,0x00,0x00,0x00,0x4D,0x8B,0x10,0x0F,0xB6,0xC9,0x49,0xBB,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF3,0xF5,0xCB,0x49,0x89,0x0A,0x49,0x8B,0x08,0xC4,0xE2,0x7D,0x31,0x01,0x49,0x8B,0x09,0x44,0x8B,0xD0,0x41,0xC1,0xE2,0x03,0x4D,0x63,0xD2,0x4A,0x8D,0x0C,0x91,0xC5,0xFE,0x7F,0x01,0xFF,0xC0,0x83,0xF8,0x08,0x7C,0xAB,0x49,0x8B,0x01,0x41,0x8B,0x51,0x08,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x30,0x48,0x89,0x01,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x30,0xC5,0xFA,0x7F,0x44,0x24,0x40,0x48,0x8D,0x44,0x24,0x40,0x48,0x8B,0x10,0x8B,0x40,0x08,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8B,0xFB,0x48,0x8D,0x74,0x24,0x20,0xE8,0x60,0xCE,0x3B,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x50,0x5B,0x5E,0x5F,0xC3,0xE8,0xDB,0x6B,0x4E,0x5F,0xE8,0x5E,0x41,0x8B,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ConstPair<Vector128<ushort>> vconvert_128x8_2x128x16u_tuple(Vector128<byte> src)
; location: [7FF7C7EA9480h, 7FF7C7EA94BBh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpmovzxbw xmm1,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM1,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c8
0010h vmovapd [rsp+10h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 10
0016h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001ch vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0021h vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
0026h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
002bh vmovupd [rcx],xmm1            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM1] encoding(VEX, 4 bytes) = c5 f9 11 09
002fh vmovupd [rcx+10h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 11 41 10
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8_2x128x16u_tupleBytes => new byte[60]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x79,0x30,0xC8,0xC5,0xF9,0x29,0x4C,0x24,0x10,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xF9,0x11,0x09,0xC5,0xF9,0x11,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ConstQuad<Vector128<uint>> vconvert_128x8u_4x128x32u_tuple(Vector128<byte> src)
; location: [7FF7C7EA94E0h, 7FF7C7EA956Bh]
0000h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpmovzxbw xmm1,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM1,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c8
0010h vmovapd [rsp+10h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 10
0016h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001ch vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0021h vpmovzxbw xmm0,xmm0           ; VPMOVZXBW(VEX_Vpmovzxbw_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 30 c0
0026h vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
002bh vpmovzxwd xmm2,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM2,XMM1]      encoding(VEX, 5 bytes) = c4 e2 79 33 d1
0030h vmovapd [rsp+50h],xmm2        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM2] encoding(VEX, 6 bytes) = c5 f9 29 54 24 50
0036h vpextrq rax,xmm1,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c8 01
003ch vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0041h vpmovzxwd xmm1,xmm1           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM1,XMM1]      encoding(VEX, 5 bytes) = c4 e2 79 33 c9
0046h vmovapd [rsp+40h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 40
004ch vpmovzxwd xmm1,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM1,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c8
0051h vmovapd [rsp+30h],xmm1        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM1] encoding(VEX, 6 bytes) = c5 f9 29 4c 24 30
0057h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
005dh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0062h vpmovzxwd xmm0,xmm0           ; VPMOVZXWD(VEX_Vpmovzxwd_xmm_xmmm64) [XMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 79 33 c0
0067h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
006dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0071h vmovupd [rcx],xmm3            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM3] encoding(VEX, 4 bytes) = c5 f9 11 19
0075h vmovupd [rcx+10h],xmm2        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM2] encoding(VEX, 5 bytes) = c5 f9 11 51 10
007ah vmovupd [rcx+20h],xmm1        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM1] encoding(VEX, 5 bytes) = c5 f9 11 49 20
007fh vmovupd [rcx+30h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 11 41 30
0084h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0087h add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
008bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_4x128x32u_tupleBytes => new byte[140]{0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x79,0x30,0xC8,0xC5,0xF9,0x29,0x4C,0x24,0x10,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE2,0x79,0x30,0xC0,0xC5,0xF9,0x29,0x04,0x24,0xC4,0xE2,0x79,0x33,0xD1,0xC5,0xF9,0x29,0x54,0x24,0x50,0xC4,0xE3,0xF9,0x16,0xC8,0x01,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE2,0x79,0x33,0xC9,0xC5,0xF9,0x29,0x4C,0x24,0x40,0xC4,0xE2,0x79,0x33,0xC8,0xC5,0xF9,0x29,0x4C,0x24,0x30,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE2,0x79,0x33,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0x11,0x19,0xC5,0xF9,0x11,0x51,0x10,0xC5,0xF9,0x11,0x49,0x20,0xC5,0xF9,0x11,0x41,0x30,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x68,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void vconvert_128x8u_2x256x32u_out(Vector128<byte> src, out Vector256<uint> lo, out Vector256<uint> hi)
; location: [7FF7C7EA95A0h, 7FF7C7EA95DBh]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
000bh vpmovzxbd ymm1,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM1,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c8
0010h vmovupd [rdx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 0a
0014h vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
001ah vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
0020h vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0025h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
002ah vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
002fh vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
0034h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0037h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_2x256x32u_outBytes => new byte[60]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC4,0xE2,0x7D,0x31,0xC8,0xC5,0xFD,0x11,0x0A,0xC5,0xFD,0x11,0x4C,0x24,0x20,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE2,0x7D,0x31,0xC0,0xC4,0xC1,0x7D,0x11,0x00,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ConstPair<Vector256<uint>> vconvert_128x8u_2x256x32u_tuple(Vector128<byte> src)
; location: [7FF7C7EA9600h, 7FF7C7EA963Eh]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vpmovzxbd ymm1,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM1,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c8
0010h vmovupd [rsp+20h],ymm1        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
0016h vpextrq rax,xmm0,1            ; VPEXTRQ(VEX_Vpextrq_rm64_xmm_imm8) [RAX,XMM0,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 16 c0 01
001ch vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0021h vpmovzxbd ymm0,xmm0           ; VPMOVZXBD(VEX_Vpmovzxbd_ymm_xmmm64) [YMM0,XMM0]      encoding(VEX, 5 bytes) = c4 e2 7d 31 c0
0026h vmovupd [rsp],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 04 24
002bh vmovupd [rcx],ymm1            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM1] encoding(VEX, 4 bytes) = c5 fd 11 09
002fh vmovupd [rcx+20h],ymm0        ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 41 20
0034h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0037h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ah add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_128x8u_2x256x32u_tupleBytes => new byte[63]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x7D,0x31,0xC8,0xC5,0xFD,0x11,0x4C,0x24,0x20,0xC4,0xE3,0xF9,0x16,0xC0,0x01,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE2,0x7D,0x31,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x11,0x09,0xC5,0xFD,0x11,0x41,0x20,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vcompact_128x16x2_128x8_v1(Vector128<ushort> x0, Vector128<ushort> x1)
; location: [7FF7C7EA9A70h, 7FF7C7EA9AADh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw xmm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 54 24 04
0022h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0026h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
002ah vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
002eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0032h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_128x16x2_128x8_v1Bytes => new byte[62]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x54,0x24,0x04,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0xDB,0xC3,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vcompact_256x16x2_256x8_v1(Vector256<ushort> x0, Vector256<ushort> x1)
; location: [7FF7C7EA9AD0h, 7FF7C7EA9B12h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw ymm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 04
0022h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0026h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
002ah vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
002eh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0034h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0038h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_256x16x2_256x8_v1Bytes => new byte[67]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vcompact_128x32x2_128x16_v1(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7EA9B30h, 7FF7C7EA9B6Ah]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd xmm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 54 24 04
0022h vpand xmm0,xmm0,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2]    encoding(VEX, 4 bytes) = c5 f9 db c2
0026h vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
002ah vpackusdw xmm0,xmm0,xmm1      ; VPACKUSDW(VEX_Vpackusdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 5 bytes) = c4 e2 79 2b c1
002fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0033h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0036h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_128x32x2_128x16_v1Bytes => new byte[59]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC4,0xE2,0x79,0x2B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vcompact_128x32x2_128x16_v2(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7EA9B90h, 7FF7C7EA9BCFh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov rax,1E37DAB8519h          ; MOV(Mov_r64_imm64) [RAX,1e37dab8519h:imm64]          encoding(10 bytes) = 48 b8 19 85 ab 7d e3 01 00 00
0018h vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
001ch vpshufb xmm0,xmm0,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 5 bytes) = c4 e2 79 00 c2
0021h mov rax,1E37DAB8809h          ; MOV(Mov_r64_imm64) [RAX,1e37dab8809h:imm64]          encoding(10 bytes) = 48 b8 09 88 ab 7d e3 01 00 00
002bh vlddqu xmm2,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM2,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 10
002fh vpshufb xmm1,xmm1,xmm2        ; VPSHUFB(VEX_Vpshufb_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2] encoding(VEX, 5 bytes) = c4 e2 71 00 ca
0034h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0038h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
003ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_128x32x2_128x16_v2Bytes => new byte[64]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0x48,0xB8,0x19,0x85,0xAB,0x7D,0xE3,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x79,0x00,0xC2,0x48,0xB8,0x09,0x88,0xAB,0x7D,0xE3,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x10,0xC4,0xE2,0x71,0x00,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vcompact_256x32x2_128x16_v1(Vector256<uint> x, Vector256<uint> y)
; location: [7FF7C7EA9BF0h, 7FF7C7EA9C33h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],0FFFFh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffffh:imm32] encoding(8 bytes) = c7 44 24 04 ff ff 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastd ymm2,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM2,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 54 24 04
0022h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0026h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
002ah vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
002fh vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0035h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0039h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ch vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_256x32x2_128x16_v1Bytes => new byte[68]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vcompact_256x32x2_128x16_v2(Vector256<uint> x, Vector256<uint> y)
; location: [7FF7C7EA9C50h, 7FF7C7EA9C98h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov rax,1E37DAB8819h          ; MOV(Mov_r64_imm64) [RAX,1e37dab8819h:imm64]          encoding(10 bytes) = 48 b8 19 88 ab 7d e3 01 00 00
0018h vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
001ch vpshufb ymm0,ymm0,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2] encoding(VEX, 5 bytes) = c4 e2 7d 00 c2
0021h mov rax,1E37DAB8879h          ; MOV(Mov_r64_imm64) [RAX,1e37dab8879h:imm64]          encoding(10 bytes) = 48 b8 79 88 ab 7d e3 01 00 00
002bh vlddqu ymm2,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM2,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 10
002fh vpshufb ymm1,ymm1,ymm2        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2] encoding(VEX, 5 bytes) = c4 e2 75 00 ca
0034h vpor ymm0,ymm0,ymm1           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1]      encoding(VEX, 4 bytes) = c5 fd eb c1
0038h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
003eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0042h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0045h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0048h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vcompact_256x32x2_128x16_v2Bytes => new byte[73]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x19,0x88,0xAB,0x7D,0xE3,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x7D,0x00,0xC2,0x48,0xB8,0x79,0x88,0xAB,0x7D,0xE3,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC4,0xE2,0x75,0x00,0xCA,0xC5,0xFD,0xEB,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vconvert_xspan32u_v256x64u(Block128<uint> src, out Vector256<ulong> dst)
; location: [7FF7C7EAA0C0h, 7FF7C7EAA12Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+18h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 18
000eh mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0013h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0018h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
001dh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0020h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
0023h lea r9,[rsp+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 08
0028h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
002ch vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0031h lea r9,[rsp+8]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 4c 24 08
0036h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RAX]           encoding(3 bytes) = 49 89 01
0039h mov [r9+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),EDX]           encoding(4 bytes) = 41 89 51 08
003dh vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
0043h vmovdqu xmmword ptr [rsp+18h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 18
0049h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
004eh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0051h vpmovsxdq ymm0,xmmword ptr [rax]; VPMOVSXDQ(VEX_Vpmovsxdq_ymm_xmmm128) [YMM0,mem(Packed128_Int32,RAX:br,:sr)] encoding(VEX, 5 bytes) = c4 e2 7d 25 00
0056h vmovupd [r8],ymm0             ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,R8:br,:sr),YMM0] encoding(VEX, 5 bytes) = c4 c1 7d 11 00
005bh vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
0060h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0064h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0067h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
006ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vconvert_xspan32u_v256x64uBytes => new byte[111]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x18,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0x48,0x8B,0x02,0x8B,0x52,0x08,0x4C,0x8D,0x4C,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x4C,0x8D,0x4C,0x24,0x08,0x49,0x89,0x01,0x41,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x44,0x24,0x18,0x48,0x8D,0x44,0x24,0x18,0x48,0x8B,0x00,0xC4,0xE2,0x7D,0x25,0x00,0xC4,0xC1,0x7D,0x11,0x00,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> packus(Vector128<ushort> x, Vector128<ushort> y)
; location: [7FF7C7EAA150h, 7FF7C7EAA18Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw xmm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 54 24 04
0022h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0026h vpand xmm0,xmm0,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM3]    encoding(VEX, 4 bytes) = c5 f9 db c3
002ah vpand xmm1,xmm1,xmm2          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]    encoding(VEX, 4 bytes) = c5 f1 db ca
002eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0032h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packusBytes => new byte[62]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x54,0x24,0x04,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0xDB,0xC3,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> packus(Vector256<ushort> x, Vector256<ushort> y)
; location: [7FF7C7EAA1B0h, 7FF7C7EAA1ECh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh mov dword ptr [rsp+4],0FFh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffh:imm32]  encoding(8 bytes) = c7 44 24 04 ff 00 00 00
0016h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
001bh vpbroadcastw ymm2,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM2,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 54 24 04
0022h vpand ymm0,ymm0,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM0,YMM0,YMM2]    encoding(VEX, 4 bytes) = c5 fd db c2
0026h vpand ymm1,ymm1,ymm2          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM1,YMM2]    encoding(VEX, 4 bytes) = c5 f5 db ca
002ah vpackuswb ymm0,ymm0,ymm1      ; VPACKUSWB(VEX_Vpackuswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 67 c1
002eh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0032h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packusBytes => new byte[61]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x04,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
