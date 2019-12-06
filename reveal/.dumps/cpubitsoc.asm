; 2019-12-05 18:50:57:895
; function: Vector128<byte> makemask_128x8u(BitVector16 src)
; location: [7FFDDAFD6F50h, 7FFDDAFD6FA3h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000ah movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
000dh mov [rsp+10h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 10
0011h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 10
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0022h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0027h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 08
0031h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
0035h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0038h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
003dh vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0042h vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0048h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004fh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_128x8uBytes => new byte[84]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x88,0x54,0x24,0x10,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> makemask_128x8u_literal()
; location: [7FFDDAFD6FC0h, 7FFDDAFD702Dh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov word ptr [rsp+10h],0FCFCh ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),fcfch:imm16] encoding(7 bytes) = 66 c7 44 24 10 fc fc
000eh mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
0012h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 08
001ch mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov rdx,8080808080808080h     ; MOV(Mov_r64_imm64) [RDX,8080808080808080h:imm64]     encoding(10 bytes) = 48 ba 80 80 80 80 80 80 80 80
002dh pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0032h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 10
0036h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0039h sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
003ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003fh mov [rsp],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(3 bytes) = 88 14 24
0042h mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(3 bytes) = 8b 14 24
0045h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0048h mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0052h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0057h vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
005ch vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0062h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0066h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0069h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
006dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_128x8u_literalBytes => new byte[110]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x66,0xC7,0x44,0x24,0x10,0xFC,0xFC,0x8B,0x44,0x24,0x10,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0x8B,0x54,0x24,0x10,0x0F,0xB7,0xD2,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x88,0x14,0x24,0x8B,0x14,0x24,0x0F,0xB6,0xD2,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> makemask_256x8u(BitVector32 src)
; location: [7FFDDAFD7050h, 7FFDDAFD712Dh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh mov [rsp+30h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX]           encoding(5 bytes) = 66 89 44 24 30
0012h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 20
0020h mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 20
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0031h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0036h mov r8d,[rsp+30h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 30
003bh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
003fh sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
0043h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0047h mov [rsp+18h],r8b             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),R8L]             encoding(5 bytes) = 44 88 44 24 18
004ch mov r8d,[rsp+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 18
0051h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0055h mov r9,8080808080808080h      ; MOV(Mov_r64_imm64) [R9,8080808080808080h:imm64]      encoding(10 bytes) = 49 b9 80 80 80 80 80 80 80 80
005fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0064h vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0069h vpinsrq xmm0,xmm0,r8,1        ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,R8,1h:imm8] encoding(VEX, 6 bytes) = c4 c3 f9 22 c0 01
006fh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0072h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0075h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0078h mov [rsp+28h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX]           encoding(5 bytes) = 66 89 44 24 28
007dh mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 28
0081h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0084h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0087h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 10
008bh mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
008fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0092h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
0097h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 28
009bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
009eh sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
00a1h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00a4h mov [rsp+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 08
00a8h mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 08
00ach movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00afh pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
00b4h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
00b9h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
00bfh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
00c3h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
00c9h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
00cfh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
00d3h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00d6h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00d9h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00ddh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_256x8uBytes => new byte[222]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x0F,0xB7,0xC2,0x0F,0xB7,0xC0,0x66,0x89,0x44,0x24,0x30,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xFB,0xF5,0xC0,0x44,0x8B,0x44,0x24,0x30,0x45,0x0F,0xB7,0xC0,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x44,0x24,0x18,0x44,0x8B,0x44,0x24,0x18,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0x42,0xBB,0xF5,0xC1,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xC3,0xF9,0x22,0xC0,0x01,0xC1,0xEA,0x10,0x0F,0xB7,0xC2,0x0F,0xB7,0xC0,0x66,0x89,0x44,0x24,0x28,0x8B,0x44,0x24,0x28,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0x8B,0x54,0x24,0x28,0x0F,0xB7,0xD2,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x88,0x54,0x24,0x08,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD1,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> makemask_256x8u_literal()
; location: [7FFDDAFD7150h, 7FFDDAFD721Bh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov word ptr [rsp+30h],0F0C0h ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),f0c0h:imm16] encoding(7 bytes) = 66 c7 44 24 30 c0 f0
000eh mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
0012h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 20
001ch mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 20
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h mov rdx,8080808080808080h     ; MOV(Mov_r64_imm64) [RDX,8080808080808080h:imm64]     encoding(10 bytes) = 48 ba 80 80 80 80 80 80 80 80
002dh pdep rax,rax,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fb f5 c2
0032h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 30
0036h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0039h sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
003ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003fh mov [rsp+18h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 18
0043h mov edx,[rsp+18h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 18
0047h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004ah mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0054h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0059h vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
005eh vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0064h mov word ptr [rsp+28h],0F0F0h ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),f0f0h:imm16] encoding(7 bytes) = 66 c7 44 24 28 f0 f0
006bh mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 28
006fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0072h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0075h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 10
0079h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
007dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0080h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0085h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 28
0089h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
008ch sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
008fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0092h mov [rsp+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 08
0096h mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 08
009ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
009dh pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
00a2h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
00a7h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
00adh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
00b1h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
00b7h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
00bdh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
00c1h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00c4h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00c7h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00cbh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_256x8u_literalBytes => new byte[204]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x66,0xC7,0x44,0x24,0x30,0xC0,0xF0,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB7,0xD2,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x88,0x54,0x24,0x18,0x8B,0x54,0x24,0x18,0x0F,0xB6,0xD2,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x66,0xC7,0x44,0x24,0x28,0xF0,0xF0,0x8B,0x44,0x24,0x28,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB7,0xD2,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x88,0x54,0x24,0x08,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> makemask_g128x8u(BitVector16 src)
; location: [7FFDDAFD7240h, 7FFDDAFD7293h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000ah movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
000dh mov [rsp+10h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 10
0011h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 10
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0022h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0027h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 08
0031h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
0035h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0038h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
003dh vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0042h vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0048h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004fh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_g128x8uBytes => new byte[84]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x88,0x54,0x24,0x10,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> makemask_g128x16u(BitVector16 src)
; location: [7FFDDAFD72B0h, 7FFDDAFD7303h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000ah movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
000dh mov [rsp+10h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 10
0011h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 10
0015h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0018h mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0022h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0027h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 08
0031h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
0035h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0038h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
003dh vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0042h vpinsrq xmm0,xmm0,rax,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RAX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c0 01
0048h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
004ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
004fh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_g128x16uBytes => new byte[84]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x88,0x54,0x24,0x10,0x8B,0x54,0x24,0x10,0x0F,0xB6,0xD2,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> makemask_g256x32u(BitVector32 src)
; location: [7FFDDAFD7730h, 7FFDDAFD780Dh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh mov [rsp+30h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX]           encoding(5 bytes) = 66 89 44 24 30
0012h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 30
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 20
0020h mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 20
0024h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0027h mov r8,8080808080808080h      ; MOV(Mov_r64_imm64) [R8,8080808080808080h:imm64]      encoding(10 bytes) = 49 b8 80 80 80 80 80 80 80 80
0031h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0036h mov r8d,[rsp+30h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 30
003bh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
003fh sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
0043h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0047h mov [rsp+18h],r8b             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),R8L]             encoding(5 bytes) = 44 88 44 24 18
004ch mov r8d,[rsp+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)]          encoding(5 bytes) = 44 8b 44 24 18
0051h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0055h mov r9,8080808080808080h      ; MOV(Mov_r64_imm64) [R9,8080808080808080h:imm64]      encoding(10 bytes) = 49 b9 80 80 80 80 80 80 80 80
005fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0064h vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0069h vpinsrq xmm0,xmm0,r8,1        ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,R8,1h:imm8] encoding(VEX, 6 bytes) = c4 c3 f9 22 c0 01
006fh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0072h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0075h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0078h mov [rsp+28h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX]           encoding(5 bytes) = 66 89 44 24 28
007dh mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 28
0081h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0084h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0087h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 10
008bh mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
008fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0092h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
0097h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 28
009bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
009eh sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
00a1h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00a4h mov [rsp+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),DL]              encoding(4 bytes) = 88 54 24 08
00a8h mov edx,[rsp+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 54 24 08
00ach movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00afh pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
00b4h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
00b9h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
00bfh vxorps ymm2,ymm2,ymm2         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM2,YMM2,YMM2]  encoding(VEX, 4 bytes) = c5 ec 57 d2
00c3h vinserti128 ymm0,ymm2,xmm0,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM2,XMM0,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 6d 38 c0 00
00c9h vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
00cfh vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
00d3h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00d6h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
00d9h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00ddh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> makemask_g256x32uBytes => new byte[222]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x0F,0xB7,0xC2,0x0F,0xB7,0xC0,0x66,0x89,0x44,0x24,0x30,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xFB,0xF5,0xC0,0x44,0x8B,0x44,0x24,0x30,0x45,0x0F,0xB7,0xC0,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x44,0x24,0x18,0x44,0x8B,0x44,0x24,0x18,0x45,0x0F,0xB6,0xC0,0x49,0xB9,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0x42,0xBB,0xF5,0xC1,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xC3,0xF9,0x22,0xC0,0x01,0xC1,0xEA,0x10,0x0F,0xB7,0xC2,0x0F,0xB7,0xC0,0x66,0x89,0x44,0x24,0x28,0x8B,0x44,0x24,0x28,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0x8B,0x54,0x24,0x28,0x0F,0xB7,0xD2,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x88,0x54,0x24,0x08,0x8B,0x54,0x24,0x08,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD1,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte butterfly_8x1(byte x)
; location: [7FFDDAFD7830h, 7FFDDAFD7858h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,66h                   ; AND(And_rm32_imm8) [EDX,66h:imm32]                   encoding(3 bytes) = 83 e2 66
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0011h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0013h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0015h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0017h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh and edx,66h                   ; AND(And_rm32_imm8) [EDX,66h:imm32]                   encoding(3 bytes) = 83 e2 66
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_8x1Bytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0x83,0xE2,0x66,0x8B,0xCA,0xD1,0xE1,0x33,0xCA,0xD1,0xEA,0x33,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x83,0xE2,0x66,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vbutterfly_128x8x1(Vector128<byte> x)
; location: [7FFDDAFD8080h, 7FFDDAFD81D1h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps [rsp+40h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f8 29 74 24 40
000dh vmovaps [rsp+30h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 f8 29 7c 24 30
0013h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0017h mov dword ptr [rsp+2Ch],66h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(8 bytes) = c7 44 24 2c 66 00 00 00
001fh lea rax,[rsp+2Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 2c
0024h vpbroadcastb xmm1,byte ptr [rsp+2Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 4c 24 2c
002bh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
002fh vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0033h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0037h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
003bh vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0040h mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
004ah vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
004eh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0053h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0057h vpsllw ymm3,ymm3,xmm5         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM5]  encoding(VEX, 4 bytes) = c5 e5 f1 dd
005bh vpshufb ymm3,ymm3,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 00 dc
0060h mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
006ah vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
006eh mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
0078h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
007ch vpaddb ymm5,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc ed
0080h vpshufb ymm5,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 ed
0085h vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
008bh mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
0095h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0099h vpaddb ymm4,ymm4,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6]  encoding(VEX, 4 bytes) = c5 dd fc e6
009dh vpshufb ymm3,ymm3,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 00 dc
00a2h vpor ymm3,ymm5,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM5,YMM3]      encoding(VEX, 4 bytes) = c5 d5 eb db
00a6h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
00ach vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
00b0h vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
00b5h mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
00bfh vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00c3h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
00c8h vmovd xmm6,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM6,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f0
00cch vpsrlw ymm4,ymm4,xmm6         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM6]  encoding(VEX, 4 bytes) = c5 dd d1 e6
00d0h vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
00d5h mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
00dfh vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00e3h mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
00edh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
00f1h vpaddb ymm6,ymm5,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM5,YMM6]  encoding(VEX, 4 bytes) = c5 d5 fc f6
00f5h vpshufb ymm6,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM6,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 f6
00fah vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
0100h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
010ah vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
010eh vpaddb ymm5,ymm5,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7]  encoding(VEX, 4 bytes) = c5 d5 fc ef
0112h vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
0117h vpor ymm4,ymm6,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM6,YMM4]      encoding(VEX, 4 bytes) = c5 cd eb e4
011bh vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0121h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0125h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0129h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
012dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0131h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0135h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0138h vmovaps xmm6,[rsp+40h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 74 24 40
013eh vmovaps xmm7,[rsp+30h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 7c 24 30
0144h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0147h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
014bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
014ch call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F576CD0h:jmp64]                encoding(5 bytes) = e8 7f 6b 57 5f
0151h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vbutterfly_128x8x1Bytes => new byte[338]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0x74,0x24,0x40,0xC5,0xF8,0x29,0x7C,0x24,0x30,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x2C,0x66,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x79,0x78,0x4C,0x24,0x2C,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC4,0xE2,0x7D,0x30,0xDB,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE8,0xC5,0xE5,0xF1,0xDD,0xC4,0xE2,0x65,0x00,0xDC,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xED,0xC4,0xE2,0x65,0x00,0xED,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xDD,0xFC,0xE6,0xC4,0xE2,0x65,0x00,0xDC,0xC5,0xD5,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xF8,0x28,0xE2,0xC4,0xE2,0x7D,0x30,0xE4,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xF0,0xC5,0xDD,0xD1,0xE6,0xC4,0xE2,0x5D,0x00,0xE5,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xD5,0xFC,0xF6,0xC4,0xE2,0x5D,0x00,0xF6,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xD5,0xFC,0xEF,0xC4,0xE2,0x5D,0x00,0xE5,0xC5,0xCD,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0x74,0x24,0x40,0xC5,0xF8,0x28,0x7C,0x24,0x30,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3,0xE8,0x7F,0x6B,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vbutterfly_256x8x1(Vector256<byte> x)
; location: [7FFDDAFD8620h, 7FFDDAFD8B00h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,1F8h                  ; SUB(Sub_rm64_imm32) [RSP,1f8h:imm64]                 encoding(7 bytes) = 48 81 ec f8 01 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch vmovaps [rsp+1E0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 e0 01 00 00
0015h vmovaps [rsp+1D0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 d0 01 00 00
001eh vmovaps [rsp+1C0h],xmm8       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 78 29 84 24 c0 01 00 00
0027h vmovaps [rsp+1B0h],xmm9       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 78 29 8c 24 b0 01 00 00
0030h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0033h lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 20
0038h mov ecx,62h                   ; MOV(Mov_r32_imm32) [ECX,62h:imm32]                   encoding(5 bytes) = b9 62 00 00 00
003dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
003fh rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0041h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0044h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0048h mov dword ptr [rsp+1ACh],66h  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66h:imm32]  encoding(11 bytes) = c7 84 24 ac 01 00 00 66 00 00 00
0053h lea rax,[rsp+1ACh]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 ac 01 00 00
005bh vpbroadcastb ymm1,byte ptr [rsp+1ACh]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 7d 78 8c 24 ac 01 00 00
0065h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0069h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
006dh vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0071h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0075h vextractf128 xmm4,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 dc 00
007bh vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
0080h vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
0086h vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
008bh mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
0095h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0099h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
009eh vmovd xmm6,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM6,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f0
00a2h vpsllw ymm4,ymm4,xmm6         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM6]  encoding(VEX, 4 bytes) = c5 dd f1 e6
00a6h vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
00abh vmovd xmm6,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM6,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f0
00afh vpsllw ymm3,ymm3,xmm6         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM6]  encoding(VEX, 4 bytes) = c5 e5 f1 de
00b3h vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
00b8h mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
00c2h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00c6h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
00cah mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
00d4h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
00d8h vpaddb ymm7,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc ff
00dch vpshufb ymm7,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM7,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 ff
00e1h vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
00e7h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
00f1h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
00f5h vpaddb ymm6,ymm6,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM8]  encoding(VEX, 5 bytes) = c4 c1 4d fc f0
00fah vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
00ffh vpor ymm4,ymm7,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM7,YMM4]      encoding(VEX, 4 bytes) = c5 c5 eb e4
0103h vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0109h mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
0113h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0117h vpaddb ymm6,ymm5,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM5,YMM6]  encoding(VEX, 4 bytes) = c5 d5 fc f6
011bh vpshufb ymm6,ymm3,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM6,YMM3,YMM6] encoding(VEX, 5 bytes) = c4 e2 65 00 f6
0120h vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
0126h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
0130h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0134h vpaddb ymm5,ymm5,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7]  encoding(VEX, 4 bytes) = c5 d5 fc ef
0138h vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
013dh vpor ymm3,ymm6,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM6,YMM3]      encoding(VEX, 4 bytes) = c5 cd eb db
0141h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
0147h vxorps ymm5,ymm5,ymm5         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM5,YMM5,YMM5]  encoding(VEX, 4 bytes) = c5 d4 57 ed
014bh vinserti128 ymm4,ymm5,xmm4,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 00
0151h vinserti128 ymm3,ymm4,xmm3,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM3,YMM4,XMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 38 db 01
0157h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
015bh vextractf128 xmm5,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e5 00
0161h vpmovzxbw ymm5,xmm5           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 30 ed
0166h vextractf128 xmm4,ymm4,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 01
016ch vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
0171h mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
017bh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
017fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0184h vmovd xmm7,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM7,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f8
0188h vpsrlw ymm5,ymm5,xmm7         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM5,YMM5,XMM7]  encoding(VEX, 4 bytes) = c5 d5 d1 ef
018ch vpshufb ymm5,ymm5,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM6] encoding(VEX, 5 bytes) = c4 e2 55 00 ee
0191h vmovd xmm7,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM7,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f8
0195h vpsrlw ymm4,ymm4,xmm7         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM7]  encoding(VEX, 4 bytes) = c5 dd d1 e7
0199h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
019eh mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
01a8h mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
01adh lea r8,[rsp+198h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 98 01 00 00
01b5h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
01b8h mov [r8+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EDX]           encoding(4 bytes) = 41 89 50 08
01bch mov eax,[rsp+1A0h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(7 bytes) = 8b 84 24 a0 01 00 00
01c3h vmovdqu xmm6,xmmword ptr [rsp+198h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f b4 24 98 01 00 00
01cch vmovdqu xmmword ptr [rsp+178h],xmm6; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 fa 7f b4 24 78 01 00 00
01d5h mov rdx,[rsp+178h]            ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 94 24 78 01 00 00
01ddh lea r8,[rsp+188h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 88 01 00 00
01e5h vxorps xmm6,xmm6,xmm6         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM6,XMM6,XMM6]  encoding(VEX, 4 bytes) = c5 c8 57 f6
01e9h vmovdqu xmmword ptr [r8],xmm6 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM6] encoding(VEX, 5 bytes) = c4 c1 7a 7f 30
01eeh mov [rsp+170h],rdx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(8 bytes) = 48 89 94 24 70 01 00 00
01f6h mov rdx,[rsp+170h]            ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 94 24 70 01 00 00
01feh lea r8,[rsp+188h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 88 01 00 00
0206h mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RDX]           encoding(3 bytes) = 49 89 10
0209h mov [rsp+190h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(7 bytes) = 89 84 24 90 01 00 00
0210h lea rax,[rsp+188h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 88 01 00 00
0218h mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 10
021bh mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 08
021eh lea r8,[rsp+160h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 60 01 00 00
0226h mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RDX]           encoding(3 bytes) = 49 89 10
0229h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(4 bytes) = 41 89 40 08
022dh vmovdqu xmm6,xmmword ptr [rsp+160h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f b4 24 60 01 00 00
0236h vmovdqu xmmword ptr [rsp+150h],xmm6; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 fa 7f b4 24 50 01 00 00
023fh vmovdqu xmm6,xmmword ptr [rsp+150h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f b4 24 50 01 00 00
0248h vmovdqu xmmword ptr [rsp+140h],xmm6; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 fa 7f b4 24 40 01 00 00
0251h mov rax,[rsp+140h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 40 01 00 00
0259h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
025dh vmovaps ymm7,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM7,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 fe
0261h lea rax,[rsp+120h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 20 01 00 00
0269h vxorps xmm8,xmm8,xmm8         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM8,XMM8,XMM8]  encoding(VEX, 5 bytes) = c4 41 38 57 c0
026eh vmovdqu xmmword ptr [rax],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM8] encoding(VEX, 4 bytes) = c5 7a 7f 00
0272h mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
027ch mov [rsp+118h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(8 bytes) = 48 89 84 24 18 01 00 00
0284h mov rax,[rsp+118h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 18 01 00 00
028ch lea rdx,[rsp+120h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 94 24 20 01 00 00
0294h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0297h mov dword ptr [rsp+128h],20h  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(11 bytes) = c7 84 24 28 01 00 00 20 00 00 00
02a2h vmovdqu xmm8,xmmword ptr [rsp+120h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 84 24 20 01 00 00
02abh vmovdqu xmmword ptr [rsp+130h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 7a 7f 84 24 30 01 00 00
02b4h vmovdqu xmm8,xmmword ptr [rsp+130h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 84 24 30 01 00 00
02bdh vmovdqu xmmword ptr [rsp+108h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 7a 7f 84 24 08 01 00 00
02c6h vmovdqu xmm8,xmmword ptr [rsp+108h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 84 24 08 01 00 00
02cfh vmovdqu xmmword ptr [rsp+0F8h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 7a 7f 84 24 f8 00 00 00
02d8h mov rax,[rsp+0F8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 f8 00 00 00
02e0h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
02e4h vpaddb ymm8,ymm7,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM8,YMM7,YMM8]  encoding(VEX, 5 bytes) = c4 41 45 fc c0
02e9h vpshufb ymm8,ymm5,ymm8        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM8,YMM5,YMM8] encoding(VEX, 5 bytes) = c4 42 55 00 c0
02eeh vperm2i128 ymm5,ymm5,ymm5,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM5,YMM5,YMM5,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 46 ed 03
02f4h lea rax,[rsp+0D8h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 d8 00 00 00
02fch vxorps xmm9,xmm9,xmm9         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM9,XMM9,XMM9]  encoding(VEX, 5 bytes) = c4 41 30 57 c9
0301h vmovdqu xmmword ptr [rax],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM9] encoding(VEX, 4 bytes) = c5 7a 7f 08
0305h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
030fh mov [rsp+0D0h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(8 bytes) = 48 89 84 24 d0 00 00 00
0317h mov rax,[rsp+0D0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 d0 00 00 00
031fh lea rdx,[rsp+0D8h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 94 24 d8 00 00 00
0327h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
032ah mov dword ptr [rsp+0E0h],20h  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(11 bytes) = c7 84 24 e0 00 00 00 20 00 00 00
0335h vmovdqu xmm9,xmmword ptr [rsp+0D8h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 8c 24 d8 00 00 00
033eh vmovdqu xmmword ptr [rsp+0E8h],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 7a 7f 8c 24 e8 00 00 00
0347h vmovdqu xmm9,xmmword ptr [rsp+0E8h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 8c 24 e8 00 00 00
0350h vmovdqu xmmword ptr [rsp+0C0h],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 7a 7f 8c 24 c0 00 00 00
0359h vmovdqu xmm9,xmmword ptr [rsp+0C0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 8c 24 c0 00 00 00
0362h vmovdqu xmmword ptr [rsp+0B0h],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 7a 7f 8c 24 b0 00 00 00
036bh mov rax,[rsp+0B0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 b0 00 00 00
0373h vlddqu ymm9,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM9,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 08
0377h vpaddb ymm7,ymm7,ymm9         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM7,YMM9]  encoding(VEX, 5 bytes) = c4 c1 45 fc f9
037ch vpshufb ymm5,ymm5,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7] encoding(VEX, 5 bytes) = c4 e2 55 00 ef
0381h vpor ymm5,ymm8,ymm5           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM5,YMM8,YMM5]      encoding(VEX, 4 bytes) = c5 bd eb ed
0385h vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
038bh lea rax,[rsp+90h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 90 00 00 00
0393h vxorps xmm7,xmm7,xmm7         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM7,XMM7,XMM7]  encoding(VEX, 4 bytes) = c5 c0 57 ff
0397h vmovdqu xmmword ptr [rax],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM7] encoding(VEX, 4 bytes) = c5 fa 7f 38
039bh mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
03a5h mov [rsp+88h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(8 bytes) = 48 89 84 24 88 00 00 00
03adh mov rax,[rsp+88h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 88 00 00 00
03b5h lea rdx,[rsp+90h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 94 24 90 00 00 00
03bdh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
03c0h mov dword ptr [rsp+98h],20h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(11 bytes) = c7 84 24 98 00 00 00 20 00 00 00
03cbh vmovdqu xmm7,xmmword ptr [rsp+90h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f bc 24 90 00 00 00
03d4h vmovdqu xmmword ptr [rsp+0A0h],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 fa 7f bc 24 a0 00 00 00
03ddh vmovdqu xmm7,xmmword ptr [rsp+0A0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f bc 24 a0 00 00 00
03e6h vmovdqu xmmword ptr [rsp+78h],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 fa 7f 7c 24 78
03ech vmovdqu xmm7,xmmword ptr [rsp+78h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 7c 24 78
03f2h vmovdqu xmmword ptr [rsp+68h],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 fa 7f 7c 24 68
03f8h mov rax,[rsp+68h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 68
03fdh vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0401h vpaddb ymm7,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc ff
0405h vpshufb ymm7,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM7,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 ff
040ah vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
0410h lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 48
0415h vxorps xmm8,xmm8,xmm8         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM8,XMM8,XMM8]  encoding(VEX, 5 bytes) = c4 41 38 57 c0
041ah vmovdqu xmmword ptr [rax],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM8] encoding(VEX, 4 bytes) = c5 7a 7f 00
041eh mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
0428h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 40
042dh mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
0432h lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 48
0437h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
043ah mov dword ptr [rsp+50h],20h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(8 bytes) = c7 44 24 50 20 00 00 00
0442h vmovdqu xmm8,xmmword ptr [rsp+48h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 7a 6f 44 24 48
0448h vmovdqu xmmword ptr [rsp+58h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 6 bytes) = c5 7a 7f 44 24 58
044eh vmovdqu xmm8,xmmword ptr [rsp+58h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 7a 6f 44 24 58
0454h vmovdqu xmmword ptr [rsp+30h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 6 bytes) = c5 7a 7f 44 24 30
045ah vmovdqu xmm8,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 7a 6f 44 24 30
0460h vmovdqu xmmword ptr [rsp+20h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 6 bytes) = c5 7a 7f 44 24 20
0466h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 20
046bh vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
046fh vpaddb ymm6,ymm6,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM8]  encoding(VEX, 5 bytes) = c4 c1 4d fc f0
0474h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
0479h vpor ymm4,ymm7,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM7,YMM4]      encoding(VEX, 4 bytes) = c5 c5 eb e4
047dh vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0483h vxorps ymm6,ymm6,ymm6         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM6,YMM6,YMM6]  encoding(VEX, 4 bytes) = c5 cc 57 f6
0487h vinserti128 ymm5,ymm6,xmm5,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM5,YMM6,XMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 4d 38 ed 00
048dh vinserti128 ymm4,ymm5,xmm4,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 01
0493h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0497h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
049bh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
049fh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
04a3h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
04a7h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
04aah vmovaps xmm6,[rsp+1E0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 e0 01 00 00
04b3h vmovaps xmm7,[rsp+1D0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 d0 01 00 00
04bch vmovaps xmm8,[rsp+1C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM8,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 84 24 c0 01 00 00
04c5h vmovaps xmm9,[rsp+1B0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM9,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 8c 24 b0 01 00 00
04ceh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
04d1h add rsp,1F8h                  ; ADD(Add_rm64_imm32) [RSP,1f8h:imm64]                 encoding(7 bytes) = 48 81 c4 f8 01 00 00
04d8h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
04d9h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
04dah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
04dbh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F576730h:jmp64]                encoding(5 bytes) = e8 50 62 57 5f
04e0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vbutterfly_256x8x1Bytes => new byte[1249]{0x57,0x56,0x48,0x81,0xEC,0xF8,0x01,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xE0,0x01,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xD0,0x01,0x00,0x00,0xC5,0x78,0x29,0x84,0x24,0xC0,0x01,0x00,0x00,0xC5,0x78,0x29,0x8C,0x24,0xB0,0x01,0x00,0x00,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x62,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0xC5,0xFD,0x10,0x02,0xC7,0x84,0x24,0xAC,0x01,0x00,0x00,0x66,0x00,0x00,0x00,0x48,0x8D,0x84,0x24,0xAC,0x01,0x00,0x00,0xC4,0xE2,0x7D,0x78,0x8C,0x24,0xAC,0x01,0x00,0x00,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC4,0xE3,0x7D,0x19,0xDC,0x00,0xC4,0xE2,0x7D,0x30,0xE4,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x30,0xDB,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xF0,0xC5,0xDD,0xF1,0xE6,0xC4,0xE2,0x5D,0x00,0xE5,0xC5,0xF9,0x6E,0xF0,0xC5,0xE5,0xF1,0xDE,0xC4,0xE2,0x65,0x00,0xDD,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xFF,0xC4,0xE2,0x5D,0x00,0xFF,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x4D,0xFC,0xF0,0xC4,0xE2,0x5D,0x00,0xE6,0xC5,0xC5,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xD5,0xFC,0xF6,0xC4,0xE2,0x65,0x00,0xF6,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xD5,0xFC,0xEF,0xC4,0xE2,0x65,0x00,0xDD,0xC5,0xCD,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xD4,0x57,0xED,0xC4,0xE3,0x55,0x38,0xE4,0x00,0xC4,0xE3,0x5D,0x38,0xDB,0x01,0xC5,0xFC,0x28,0xE2,0xC4,0xE3,0x7D,0x19,0xE5,0x00,0xC4,0xE2,0x7D,0x30,0xED,0xC4,0xE3,0x7D,0x19,0xE4,0x01,0xC4,0xE2,0x7D,0x30,0xE4,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xF8,0xC5,0xD5,0xD1,0xEF,0xC4,0xE2,0x55,0x00,0xEE,0xC5,0xF9,0x6E,0xF8,0xC5,0xDD,0xD1,0xE7,0xC4,0xE2,0x5D,0x00,0xE6,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0x4C,0x8D,0x84,0x24,0x98,0x01,0x00,0x00,0x49,0x89,0x00,0x41,0x89,0x50,0x08,0x8B,0x84,0x24,0xA0,0x01,0x00,0x00,0xC5,0xFA,0x6F,0xB4,0x24,0x98,0x01,0x00,0x00,0xC5,0xFA,0x7F,0xB4,0x24,0x78,0x01,0x00,0x00,0x48,0x8B,0x94,0x24,0x78,0x01,0x00,0x00,0x4C,0x8D,0x84,0x24,0x88,0x01,0x00,0x00,0xC5,0xC8,0x57,0xF6,0xC4,0xC1,0x7A,0x7F,0x30,0x48,0x89,0x94,0x24,0x70,0x01,0x00,0x00,0x48,0x8B,0x94,0x24,0x70,0x01,0x00,0x00,0x4C,0x8D,0x84,0x24,0x88,0x01,0x00,0x00,0x49,0x89,0x10,0x89,0x84,0x24,0x90,0x01,0x00,0x00,0x48,0x8D,0x84,0x24,0x88,0x01,0x00,0x00,0x48,0x8B,0x10,0x8B,0x40,0x08,0x4C,0x8D,0x84,0x24,0x60,0x01,0x00,0x00,0x49,0x89,0x10,0x41,0x89,0x40,0x08,0xC5,0xFA,0x6F,0xB4,0x24,0x60,0x01,0x00,0x00,0xC5,0xFA,0x7F,0xB4,0x24,0x50,0x01,0x00,0x00,0xC5,0xFA,0x6F,0xB4,0x24,0x50,0x01,0x00,0x00,0xC5,0xFA,0x7F,0xB4,0x24,0x40,0x01,0x00,0x00,0x48,0x8B,0x84,0x24,0x40,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xFC,0x28,0xFE,0x48,0x8D,0x84,0x24,0x20,0x01,0x00,0x00,0xC4,0x41,0x38,0x57,0xC0,0xC5,0x7A,0x7F,0x00,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0x18,0x01,0x00,0x00,0x48,0x8B,0x84,0x24,0x18,0x01,0x00,0x00,0x48,0x8D,0x94,0x24,0x20,0x01,0x00,0x00,0x48,0x89,0x02,0xC7,0x84,0x24,0x28,0x01,0x00,0x00,0x20,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x84,0x24,0x20,0x01,0x00,0x00,0xC5,0x7A,0x7F,0x84,0x24,0x30,0x01,0x00,0x00,0xC5,0x7A,0x6F,0x84,0x24,0x30,0x01,0x00,0x00,0xC5,0x7A,0x7F,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0x7A,0x6F,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0x7A,0x7F,0x84,0x24,0xF8,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0x41,0x45,0xFC,0xC0,0xC4,0x42,0x55,0x00,0xC0,0xC4,0xE3,0x55,0x46,0xED,0x03,0x48,0x8D,0x84,0x24,0xD8,0x00,0x00,0x00,0xC4,0x41,0x30,0x57,0xC9,0xC5,0x7A,0x7F,0x08,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0xD0,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xD0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xD8,0x00,0x00,0x00,0x48,0x89,0x02,0xC7,0x84,0x24,0xE0,0x00,0x00,0x00,0x20,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x8C,0x24,0xD8,0x00,0x00,0x00,0xC5,0x7A,0x7F,0x8C,0x24,0xE8,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x8C,0x24,0xE8,0x00,0x00,0x00,0xC5,0x7A,0x7F,0x8C,0x24,0xC0,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x8C,0x24,0xC0,0x00,0x00,0x00,0xC5,0x7A,0x7F,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0x7F,0xF0,0x08,0xC4,0xC1,0x45,0xFC,0xF9,0xC4,0xE2,0x55,0x00,0xEF,0xC5,0xBD,0xEB,0xED,0xC4,0xE3,0x7D,0x19,0xED,0x00,0x48,0x8D,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xC0,0x57,0xFF,0xC5,0xFA,0x7F,0x38,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x02,0xC7,0x84,0x24,0x98,0x00,0x00,0x00,0x20,0x00,0x00,0x00,0xC5,0xFA,0x6F,0xBC,0x24,0x90,0x00,0x00,0x00,0xC5,0xFA,0x7F,0xBC,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0xBC,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x7C,0x24,0x78,0xC5,0xFA,0x6F,0x7C,0x24,0x78,0xC5,0xFA,0x7F,0x7C,0x24,0x68,0x48,0x8B,0x44,0x24,0x68,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xFF,0xC4,0xE2,0x5D,0x00,0xFF,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0x8D,0x44,0x24,0x48,0xC4,0x41,0x38,0x57,0xC0,0xC5,0x7A,0x7F,0x00,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x44,0x24,0x40,0x48,0x8B,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x48,0x48,0x89,0x02,0xC7,0x44,0x24,0x50,0x20,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x44,0x24,0x48,0xC5,0x7A,0x7F,0x44,0x24,0x58,0xC5,0x7A,0x6F,0x44,0x24,0x58,0xC5,0x7A,0x7F,0x44,0x24,0x30,0xC5,0x7A,0x6F,0x44,0x24,0x30,0xC5,0x7A,0x7F,0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x20,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x4D,0xFC,0xF0,0xC4,0xE2,0x5D,0x00,0xE6,0xC5,0xC5,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xCC,0x57,0xF6,0xC4,0xE3,0x4D,0x38,0xED,0x00,0xC4,0xE3,0x55,0x38,0xE4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xE0,0x01,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xD0,0x01,0x00,0x00,0xC5,0x78,0x28,0x84,0x24,0xC0,0x01,0x00,0x00,0xC5,0x78,0x28,0x8C,0x24,0xB0,0x01,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xF8,0x01,0x00,0x00,0x5E,0x5F,0xC3,0xE8,0x50,0x62,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly_16x1(ushort x)
; location: [7FFDDAFD8B90h, 7FFDDAFD8BBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,6666h                 ; AND(And_rm32_imm32) [EDX,6666h:imm32]                encoding(6 bytes) = 81 e2 66 66 00 00
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0014h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0016h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0018h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0020h and edx,6666h                 ; AND(And_rm32_imm32) [EDX,6666h:imm32]                encoding(6 bytes) = 81 e2 66 66 00 00
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
002bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_16x1Bytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0x81,0xE2,0x66,0x66,0x00,0x00,0x8B,0xCA,0xD1,0xE1,0x33,0xCA,0xD1,0xEA,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0x66,0x66,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly_128x16x1(Vector128<ushort> x)
; location: [7FFDDAFD8FE0h, 7FFDDAFD9041h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw xmm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpsllw xmm3,xmm3,xmm4         ; VPSLLW(VEX_Vpsllw_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f1 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrlw xmm4,xmm4,xmm5         ; VPSRLW(VEX_Vpsrlw_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d1 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x16x1Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF1,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD1,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly_256x16x1(Vector256<ushort> x)
; location: [7FFDDAFD9070h, 7FFDDAFD90D4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],6666h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),6666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw ymm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpsllw ymm3,ymm3,xmm4         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f1 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrlw ymm4,ymm4,xmm5         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d1 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x16x1Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF1,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD1,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly_32x1(uint x)
; location: [7FFDDAFD9100h, 7FFDDAFD911Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,66666666h             ; AND(And_EAX_imm32) [EAX,66666666h:imm32]             encoding(5 bytes) = 25 66 66 66 66
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0010h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0012h shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h and eax,66666666h             ; AND(And_EAX_imm32) [EAX,66666666h:imm32]             encoding(5 bytes) = 25 66 66 66 66
001bh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x1Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x66,0x66,0x66,0x66,0x8B,0xD0,0xD1,0xE2,0x33,0xD0,0xD1,0xE8,0x33,0xC2,0x25,0x66,0x66,0x66,0x66,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x1(Vector128<uint> x)
; location: [7FFDDAFD9540h, 7FFDDAFD95A1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld xmm3,xmm3,xmm4         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f2 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld xmm4,xmm4,xmm5         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d2 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x1Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF2,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD2,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x1(Vector256<uint> x)
; location: [7FFDDAFD95D0h, 7FFDDAFD9634h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],66666666h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),66666666h:imm32] encoding(8 bytes) = c7 44 24 04 66 66 66 66
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld ymm3,ymm3,xmm4         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f2 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld ymm4,ymm4,xmm5         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d2 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x1Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x66,0x66,0x66,0x66,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF2,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD2,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x1(ulong x)
; location: [7FFDDAFD9660h, 7FFDDAFD9694h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,1                     ; SHL(Shl_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 e2
0018h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001bh shr rax,1                     ; SHR(Shr_rm64_1) [RAX,1h:imm8]                        encoding(3 bytes) = 48 d1 e8
001eh xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0021h mov rdx,6666666666666666h     ; MOV(Mov_r64_imm64) [RDX,6666666666666666h:imm64]     encoding(10 bytes) = 48 ba 66 66 66 66 66 66 66 66
002bh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
002eh xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0031h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x1Bytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xD1,0xE2,0x48,0x33,0xD0,0x48,0xD1,0xE8,0x48,0x33,0xC2,0x48,0xBA,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x1(Vector128<ulong> x)
; location: [7FFDDAFD9AB0h, 7FFDDAFD9B15h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq xmm3,xmm3,xmm4         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f3 dc
003eh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq xmm4,xmm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d3 e5
004ah vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004eh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0052h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0056h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
005ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x1Bytes => new byte[102]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF3,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD3,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x1(Vector256<ulong> x)
; location: [7FFDDAFD9B40h, 7FFDDAFD9BA8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,6666666666666666h     ; MOV(Mov_r64_imm64) [RAX,6666666666666666h:imm64]     encoding(10 bytes) = 48 b8 66 66 66 66 66 66 66 66
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq ymm3,ymm3,xmm4         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f3 dc
003eh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq ymm4,ymm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d3 e5
004ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004eh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0052h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0056h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
005ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x1Bytes => new byte[105]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x66,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x01,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF3,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD3,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte butterfly_8x2(byte x)
; location: [7FFDDAFD9BD0h, 7FFDDAFD9BFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,3Ch                   ; AND(And_rm32_imm8) [EDX,3ch:imm32]                   encoding(3 bytes) = 83 e2 3c
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0012h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0014h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
0017h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001fh and edx,3Ch                   ; AND(And_rm32_imm8) [EDX,3ch:imm32]                   encoding(3 bytes) = 83 e2 3c
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_8x2Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0x83,0xE2,0x3C,0x8B,0xCA,0xC1,0xE1,0x02,0x33,0xCA,0xC1,0xEA,0x02,0x33,0xD1,0x0F,0xB6,0xD2,0x0F,0xB6,0xD2,0x83,0xE2,0x3C,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<byte> vbutterfly_128x8x2(Vector128<byte> x)
; location: [7FFDDAFD9C10h, 7FFDDAFD9D61h]
0000h sub rsp,58h                   ; SUB(Sub_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 ec 58
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovaps [rsp+40h],xmm6        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 6 bytes) = c5 f8 29 74 24 40
000dh vmovaps [rsp+30h],xmm7        ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 f8 29 7c 24 30
0013h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0017h mov dword ptr [rsp+2Ch],3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(8 bytes) = c7 44 24 2c 3c 00 00 00
001fh lea rax,[rsp+2Ch]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 2c
0024h vpbroadcastb xmm1,byte ptr [rsp+2Ch]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 4c 24 2c
002bh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
002fh vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0033h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0037h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
003bh vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
0040h mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
004ah vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
004eh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0053h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0057h vpsllw ymm3,ymm3,xmm5         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM5]  encoding(VEX, 4 bytes) = c5 e5 f1 dd
005bh vpshufb ymm3,ymm3,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 00 dc
0060h mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
006ah vlddqu ymm4,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM4,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 20
006eh mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
0078h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
007ch vpaddb ymm5,ymm4,ymm5         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM4,YMM5]  encoding(VEX, 4 bytes) = c5 dd fc ed
0080h vpshufb ymm5,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 ed
0085h vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
008bh mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
0095h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0099h vpaddb ymm4,ymm4,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6]  encoding(VEX, 4 bytes) = c5 dd fc e6
009dh vpshufb ymm3,ymm3,ymm4        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4] encoding(VEX, 5 bytes) = c4 e2 65 00 dc
00a2h vpor ymm3,ymm5,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM5,YMM3]      encoding(VEX, 4 bytes) = c5 d5 eb db
00a6h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
00ach vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
00b0h vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
00b5h mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
00bfh vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00c3h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
00c8h vmovd xmm6,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM6,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f0
00cch vpsrlw ymm4,ymm4,xmm6         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM6]  encoding(VEX, 4 bytes) = c5 dd d1 e6
00d0h vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
00d5h mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
00dfh vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00e3h mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
00edh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
00f1h vpaddb ymm6,ymm5,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM5,YMM6]  encoding(VEX, 4 bytes) = c5 d5 fc f6
00f5h vpshufb ymm6,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM6,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 f6
00fah vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
0100h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
010ah vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
010eh vpaddb ymm5,ymm5,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7]  encoding(VEX, 4 bytes) = c5 d5 fc ef
0112h vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
0117h vpor ymm4,ymm6,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM6,YMM4]      encoding(VEX, 4 bytes) = c5 cd eb e4
011bh vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0121h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
0125h vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0129h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
012dh vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0131h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0135h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0138h vmovaps xmm6,[rsp+40h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 74 24 40
013eh vmovaps xmm7,[rsp+30h]        ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 f8 28 7c 24 30
0144h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0147h add rsp,58h                   ; ADD(Add_rm64_imm8) [RSP,58h:imm64]                   encoding(4 bytes) = 48 83 c4 58
014bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
014ch call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F575140h:jmp64]                encoding(5 bytes) = e8 ef 4f 57 5f
0151h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vbutterfly_128x8x2Bytes => new byte[338]{0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0x74,0x24,0x40,0xC5,0xF8,0x29,0x7C,0x24,0x30,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x2C,0x3C,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x79,0x78,0x4C,0x24,0x2C,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xC4,0xE2,0x7D,0x30,0xDB,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE8,0xC5,0xE5,0xF1,0xDD,0xC4,0xE2,0x65,0x00,0xDC,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x20,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xDD,0xFC,0xED,0xC4,0xE2,0x65,0x00,0xED,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xDD,0xFC,0xE6,0xC4,0xE2,0x65,0x00,0xDC,0xC5,0xD5,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xF8,0x28,0xE2,0xC4,0xE2,0x7D,0x30,0xE4,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xF0,0xC5,0xDD,0xD1,0xE6,0xC4,0xE2,0x5D,0x00,0xE5,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xD5,0xFC,0xF6,0xC4,0xE2,0x5D,0x00,0xF6,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xD5,0xFC,0xEF,0xC4,0xE2,0x5D,0x00,0xE5,0xC5,0xCD,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0x74,0x24,0x40,0xC5,0xF8,0x28,0x7C,0x24,0x30,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0xC3,0xE8,0xEF,0x4F,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<byte> vbutterfly_256x8x2(Vector256<byte> x)
; location: [7FFDDAFD9DB0h, 7FFDDAFDA290h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,1F8h                  ; SUB(Sub_rm64_imm32) [RSP,1f8h:imm64]                 encoding(7 bytes) = 48 81 ec f8 01 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch vmovaps [rsp+1E0h],xmm6       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 f8 29 b4 24 e0 01 00 00
0015h vmovaps [rsp+1D0h],xmm7       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 f8 29 bc 24 d0 01 00 00
001eh vmovaps [rsp+1C0h],xmm8       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 78 29 84 24 c0 01 00 00
0027h vmovaps [rsp+1B0h],xmm9       ; VMOVAPS(VEX_Vmovaps_xmmm128_xmm) [mem(Packed128_Float32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 78 29 8c 24 b0 01 00 00
0030h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0033h lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 20
0038h mov ecx,62h                   ; MOV(Mov_r32_imm32) [ECX,62h:imm32]                   encoding(5 bytes) = b9 62 00 00 00
003dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
003fh rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0041h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0044h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0048h mov dword ptr [rsp+1ACh],3Ch  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3ch:imm32]  encoding(11 bytes) = c7 84 24 ac 01 00 00 3c 00 00 00
0053h lea rax,[rsp+1ACh]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 ac 01 00 00
005bh vpbroadcastb ymm1,byte ptr [rsp+1ACh]; VPBROADCASTB(VEX_Vpbroadcastb_ymm_xmmm8) [YMM1,mem(8i,RSP:br,:sr)] encoding(VEX, 10 bytes) = c4 e2 7d 78 8c 24 ac 01 00 00
0065h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0069h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
006dh vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0071h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0075h vextractf128 xmm4,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 dc 00
007bh vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
0080h vextractf128 xmm3,ymm3,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 01
0086h vpmovzxbw ymm3,xmm3           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM3,XMM3]     encoding(VEX, 5 bytes) = c4 e2 7d 30 db
008bh mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
0095h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
0099h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
009eh vmovd xmm6,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM6,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f0
00a2h vpsllw ymm4,ymm4,xmm6         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM6]  encoding(VEX, 4 bytes) = c5 dd f1 e6
00a6h vpshufb ymm4,ymm4,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM5] encoding(VEX, 5 bytes) = c4 e2 5d 00 e5
00abh vmovd xmm6,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM6,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f0
00afh vpsllw ymm3,ymm3,xmm6         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM6]  encoding(VEX, 4 bytes) = c5 e5 f1 de
00b3h vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
00b8h mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
00c2h vlddqu ymm5,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM5,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 28
00c6h vmovaps ymm6,ymm5             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM6,YMM5]         encoding(VEX, 4 bytes) = c5 fc 28 f5
00cah mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
00d4h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
00d8h vpaddb ymm7,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc ff
00dch vpshufb ymm7,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM7,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 ff
00e1h vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
00e7h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
00f1h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
00f5h vpaddb ymm6,ymm6,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM8]  encoding(VEX, 5 bytes) = c4 c1 4d fc f0
00fah vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
00ffh vpor ymm4,ymm7,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM7,YMM4]      encoding(VEX, 4 bytes) = c5 c5 eb e4
0103h vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0109h mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
0113h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
0117h vpaddb ymm6,ymm5,ymm6         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM5,YMM6]  encoding(VEX, 4 bytes) = c5 d5 fc f6
011bh vpshufb ymm6,ymm3,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM6,YMM3,YMM6] encoding(VEX, 5 bytes) = c4 e2 65 00 f6
0120h vperm2i128 ymm3,ymm3,ymm3,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM3,YMM3,YMM3,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 65 46 db 03
0126h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
0130h vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0134h vpaddb ymm5,ymm5,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7]  encoding(VEX, 4 bytes) = c5 d5 fc ef
0138h vpshufb ymm3,ymm3,ymm5        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM3,YMM3,YMM5] encoding(VEX, 5 bytes) = c4 e2 65 00 dd
013dh vpor ymm3,ymm6,ymm3           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM3,YMM6,YMM3]      encoding(VEX, 4 bytes) = c5 cd eb db
0141h vextractf128 xmm3,ymm3,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM3,YMM3,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 db 00
0147h vxorps ymm5,ymm5,ymm5         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM5,YMM5,YMM5]  encoding(VEX, 4 bytes) = c5 d4 57 ed
014bh vinserti128 ymm4,ymm5,xmm4,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 00
0151h vinserti128 ymm3,ymm4,xmm3,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM3,YMM4,XMM3,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 38 db 01
0157h vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
015bh vextractf128 xmm5,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e5 00
0161h vpmovzxbw ymm5,xmm5           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM5,XMM5]     encoding(VEX, 5 bytes) = c4 e2 7d 30 ed
0166h vextractf128 xmm4,ymm4,1      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 01
016ch vpmovzxbw ymm4,xmm4           ; VPMOVZXBW(VEX_Vpmovzxbw_ymm_xmmm128) [YMM4,XMM4]     encoding(VEX, 5 bytes) = c4 e2 7d 30 e4
0171h mov rax,2A514C48AF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48af9h:imm64]          encoding(10 bytes) = 48 b8 f9 8a c4 14 a5 02 00 00
017bh vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
017fh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0184h vmovd xmm7,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM7,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f8
0188h vpsrlw ymm5,ymm5,xmm7         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM5,YMM5,XMM7]  encoding(VEX, 4 bytes) = c5 d5 d1 ef
018ch vpshufb ymm5,ymm5,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM6] encoding(VEX, 5 bytes) = c4 e2 55 00 ee
0191h vmovd xmm7,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM7,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e f8
0195h vpsrlw ymm4,ymm4,xmm7         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM7]  encoding(VEX, 4 bytes) = c5 dd d1 e7
0199h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
019eh mov rax,2A514C48989h          ; MOV(Mov_r64_imm64) [RAX,2a514c48989h:imm64]          encoding(10 bytes) = 48 b8 89 89 c4 14 a5 02 00 00
01a8h mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
01adh lea r8,[rsp+198h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 98 01 00 00
01b5h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
01b8h mov [r8+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EDX]           encoding(4 bytes) = 41 89 50 08
01bch mov eax,[rsp+1A0h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(7 bytes) = 8b 84 24 a0 01 00 00
01c3h vmovdqu xmm6,xmmword ptr [rsp+198h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f b4 24 98 01 00 00
01cch vmovdqu xmmword ptr [rsp+178h],xmm6; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 fa 7f b4 24 78 01 00 00
01d5h mov rdx,[rsp+178h]            ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 94 24 78 01 00 00
01ddh lea r8,[rsp+188h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 88 01 00 00
01e5h vxorps xmm6,xmm6,xmm6         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM6,XMM6,XMM6]  encoding(VEX, 4 bytes) = c5 c8 57 f6
01e9h vmovdqu xmmword ptr [r8],xmm6 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM6] encoding(VEX, 5 bytes) = c4 c1 7a 7f 30
01eeh mov [rsp+170h],rdx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(8 bytes) = 48 89 94 24 70 01 00 00
01f6h mov rdx,[rsp+170h]            ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 94 24 70 01 00 00
01feh lea r8,[rsp+188h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 88 01 00 00
0206h mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RDX]           encoding(3 bytes) = 49 89 10
0209h mov [rsp+190h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(7 bytes) = 89 84 24 90 01 00 00
0210h lea rax,[rsp+188h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 88 01 00 00
0218h mov rdx,[rax]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 10
021bh mov eax,[rax+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(3 bytes) = 8b 40 08
021eh lea r8,[rsp+160h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(8 bytes) = 4c 8d 84 24 60 01 00 00
0226h mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RDX]           encoding(3 bytes) = 49 89 10
0229h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EAX]           encoding(4 bytes) = 41 89 40 08
022dh vmovdqu xmm6,xmmword ptr [rsp+160h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f b4 24 60 01 00 00
0236h vmovdqu xmmword ptr [rsp+150h],xmm6; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 fa 7f b4 24 50 01 00 00
023fh vmovdqu xmm6,xmmword ptr [rsp+150h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM6,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f b4 24 50 01 00 00
0248h vmovdqu xmmword ptr [rsp+140h],xmm6; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM6] encoding(VEX, 9 bytes) = c5 fa 7f b4 24 40 01 00 00
0251h mov rax,[rsp+140h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 40 01 00 00
0259h vlddqu ymm6,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM6,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 30
025dh vmovaps ymm7,ymm6             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM7,YMM6]         encoding(VEX, 4 bytes) = c5 fc 28 fe
0261h lea rax,[rsp+120h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 20 01 00 00
0269h vxorps xmm8,xmm8,xmm8         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM8,XMM8,XMM8]  encoding(VEX, 5 bytes) = c4 41 38 57 c0
026eh vmovdqu xmmword ptr [rax],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM8] encoding(VEX, 4 bytes) = c5 7a 7f 00
0272h mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
027ch mov [rsp+118h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(8 bytes) = 48 89 84 24 18 01 00 00
0284h mov rax,[rsp+118h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 18 01 00 00
028ch lea rdx,[rsp+120h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 94 24 20 01 00 00
0294h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0297h mov dword ptr [rsp+128h],20h  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(11 bytes) = c7 84 24 28 01 00 00 20 00 00 00
02a2h vmovdqu xmm8,xmmword ptr [rsp+120h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 84 24 20 01 00 00
02abh vmovdqu xmmword ptr [rsp+130h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 7a 7f 84 24 30 01 00 00
02b4h vmovdqu xmm8,xmmword ptr [rsp+130h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 84 24 30 01 00 00
02bdh vmovdqu xmmword ptr [rsp+108h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 7a 7f 84 24 08 01 00 00
02c6h vmovdqu xmm8,xmmword ptr [rsp+108h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 84 24 08 01 00 00
02cfh vmovdqu xmmword ptr [rsp+0F8h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 9 bytes) = c5 7a 7f 84 24 f8 00 00 00
02d8h mov rax,[rsp+0F8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 f8 00 00 00
02e0h vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
02e4h vpaddb ymm8,ymm7,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM8,YMM7,YMM8]  encoding(VEX, 5 bytes) = c4 41 45 fc c0
02e9h vpshufb ymm8,ymm5,ymm8        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM8,YMM5,YMM8] encoding(VEX, 5 bytes) = c4 42 55 00 c0
02eeh vperm2i128 ymm5,ymm5,ymm5,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM5,YMM5,YMM5,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 46 ed 03
02f4h lea rax,[rsp+0D8h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 d8 00 00 00
02fch vxorps xmm9,xmm9,xmm9         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM9,XMM9,XMM9]  encoding(VEX, 5 bytes) = c4 41 30 57 c9
0301h vmovdqu xmmword ptr [rax],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM9] encoding(VEX, 4 bytes) = c5 7a 7f 08
0305h mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
030fh mov [rsp+0D0h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(8 bytes) = 48 89 84 24 d0 00 00 00
0317h mov rax,[rsp+0D0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 d0 00 00 00
031fh lea rdx,[rsp+0D8h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 94 24 d8 00 00 00
0327h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
032ah mov dword ptr [rsp+0E0h],20h  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(11 bytes) = c7 84 24 e0 00 00 00 20 00 00 00
0335h vmovdqu xmm9,xmmword ptr [rsp+0D8h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 8c 24 d8 00 00 00
033eh vmovdqu xmmword ptr [rsp+0E8h],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 7a 7f 8c 24 e8 00 00 00
0347h vmovdqu xmm9,xmmword ptr [rsp+0E8h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 8c 24 e8 00 00 00
0350h vmovdqu xmmword ptr [rsp+0C0h],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 7a 7f 8c 24 c0 00 00 00
0359h vmovdqu xmm9,xmmword ptr [rsp+0C0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM9,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 7a 6f 8c 24 c0 00 00 00
0362h vmovdqu xmmword ptr [rsp+0B0h],xmm9; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM9] encoding(VEX, 9 bytes) = c5 7a 7f 8c 24 b0 00 00 00
036bh mov rax,[rsp+0B0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 b0 00 00 00
0373h vlddqu ymm9,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM9,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 08
0377h vpaddb ymm7,ymm7,ymm9         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM7,YMM9]  encoding(VEX, 5 bytes) = c4 c1 45 fc f9
037ch vpshufb ymm5,ymm5,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM5,YMM5,YMM7] encoding(VEX, 5 bytes) = c4 e2 55 00 ef
0381h vpor ymm5,ymm8,ymm5           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM5,YMM8,YMM5]      encoding(VEX, 4 bytes) = c5 bd eb ed
0385h vextractf128 xmm5,ymm5,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM5,YMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 ed 00
038bh lea rax,[rsp+90h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 84 24 90 00 00 00
0393h vxorps xmm7,xmm7,xmm7         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM7,XMM7,XMM7]  encoding(VEX, 4 bytes) = c5 c0 57 ff
0397h vmovdqu xmmword ptr [rax],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM7] encoding(VEX, 4 bytes) = c5 fa 7f 38
039bh mov rax,2A514C48A99h          ; MOV(Mov_r64_imm64) [RAX,2a514c48a99h:imm64]          encoding(10 bytes) = 48 b8 99 8a c4 14 a5 02 00 00
03a5h mov [rsp+88h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(8 bytes) = 48 89 84 24 88 00 00 00
03adh mov rax,[rsp+88h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(8 bytes) = 48 8b 84 24 88 00 00 00
03b5h lea rdx,[rsp+90h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(8 bytes) = 48 8d 94 24 90 00 00 00
03bdh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
03c0h mov dword ptr [rsp+98h],20h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(11 bytes) = c7 84 24 98 00 00 00 20 00 00 00
03cbh vmovdqu xmm7,xmmword ptr [rsp+90h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f bc 24 90 00 00 00
03d4h vmovdqu xmmword ptr [rsp+0A0h],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM7] encoding(VEX, 9 bytes) = c5 fa 7f bc 24 a0 00 00 00
03ddh vmovdqu xmm7,xmmword ptr [rsp+0A0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f bc 24 a0 00 00 00
03e6h vmovdqu xmmword ptr [rsp+78h],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 fa 7f 7c 24 78
03ech vmovdqu xmm7,xmmword ptr [rsp+78h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM7,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 7c 24 78
03f2h vmovdqu xmmword ptr [rsp+68h],xmm7; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM7] encoding(VEX, 6 bytes) = c5 fa 7f 7c 24 68
03f8h mov rax,[rsp+68h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 68
03fdh vlddqu ymm7,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM7,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 38
0401h vpaddb ymm7,ymm6,ymm7         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM7,YMM6,YMM7]  encoding(VEX, 4 bytes) = c5 cd fc ff
0405h vpshufb ymm7,ymm4,ymm7        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM7,YMM4,YMM7] encoding(VEX, 5 bytes) = c4 e2 5d 00 ff
040ah vperm2i128 ymm4,ymm4,ymm4,3   ; VPERM2I128(VEX_Vperm2i128_ymm_ymm_ymmm256_imm8) [YMM4,YMM4,YMM4,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 5d 46 e4 03
0410h lea rax,[rsp+48h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 48
0415h vxorps xmm8,xmm8,xmm8         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM8,XMM8,XMM8]  encoding(VEX, 5 bytes) = c4 41 38 57 c0
041ah vmovdqu xmmword ptr [rax],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM8] encoding(VEX, 4 bytes) = c5 7a 7f 00
041eh mov rax,2A514C48CF9h          ; MOV(Mov_r64_imm64) [RAX,2a514c48cf9h:imm64]          encoding(10 bytes) = 48 b8 f9 8c c4 14 a5 02 00 00
0428h mov [rsp+40h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 40
042dh mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
0432h lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 48
0437h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
043ah mov dword ptr [rsp+50h],20h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32]  encoding(8 bytes) = c7 44 24 50 20 00 00 00
0442h vmovdqu xmm8,xmmword ptr [rsp+48h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 7a 6f 44 24 48
0448h vmovdqu xmmword ptr [rsp+58h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 6 bytes) = c5 7a 7f 44 24 58
044eh vmovdqu xmm8,xmmword ptr [rsp+58h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 7a 6f 44 24 58
0454h vmovdqu xmmword ptr [rsp+30h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 6 bytes) = c5 7a 7f 44 24 30
045ah vmovdqu xmm8,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM8,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 7a 6f 44 24 30
0460h vmovdqu xmmword ptr [rsp+20h],xmm8; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM8] encoding(VEX, 6 bytes) = c5 7a 7f 44 24 20
0466h mov rax,[rsp+20h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 20
046bh vlddqu ymm8,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM8,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 7f f0 00
046fh vpaddb ymm6,ymm6,ymm8         ; VPADDB(VEX_Vpaddb_ymm_ymm_ymmm256) [YMM6,YMM6,YMM8]  encoding(VEX, 5 bytes) = c4 c1 4d fc f0
0474h vpshufb ymm4,ymm4,ymm6        ; VPSHUFB(VEX_Vpshufb_ymm_ymm_ymmm256) [YMM4,YMM4,YMM6] encoding(VEX, 5 bytes) = c4 e2 5d 00 e6
0479h vpor ymm4,ymm7,ymm4           ; VPOR(VEX_Vpor_ymm_ymm_ymmm256) [YMM4,YMM7,YMM4]      encoding(VEX, 4 bytes) = c5 c5 eb e4
047dh vextractf128 xmm4,ymm4,0      ; VEXTRACTF128(VEX_Vextractf128_xmmm128_ymm_imm8) [XMM4,YMM4,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 19 e4 00
0483h vxorps ymm6,ymm6,ymm6         ; VXORPS(VEX_Vxorps_ymm_ymm_ymmm256) [YMM6,YMM6,YMM6]  encoding(VEX, 4 bytes) = c5 cc 57 f6
0487h vinserti128 ymm5,ymm6,xmm5,0  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM5,YMM6,XMM5,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 4d 38 ed 00
048dh vinserti128 ymm4,ymm5,xmm4,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM4,YMM5,XMM4,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 55 38 e4 01
0493h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
0497h vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
049bh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
049fh vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
04a3h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
04a7h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
04aah vmovaps xmm6,[rsp+1E0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM6,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 b4 24 e0 01 00 00
04b3h vmovaps xmm7,[rsp+1D0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM7,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 f8 28 bc 24 d0 01 00 00
04bch vmovaps xmm8,[rsp+1C0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM8,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 84 24 c0 01 00 00
04c5h vmovaps xmm9,[rsp+1B0h]       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM9,mem(Packed128_Float32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 78 28 8c 24 b0 01 00 00
04ceh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
04d1h add rsp,1F8h                  ; ADD(Add_rm64_imm32) [RSP,1f8h:imm64]                 encoding(7 bytes) = 48 81 c4 f8 01 00 00
04d8h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
04d9h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
04dah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
04dbh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F574FA0h:jmp64]                encoding(5 bytes) = e8 c0 4a 57 5f
04e0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> vbutterfly_256x8x2Bytes => new byte[1249]{0x57,0x56,0x48,0x81,0xEC,0xF8,0x01,0x00,0x00,0xC5,0xF8,0x77,0xC5,0xF8,0x29,0xB4,0x24,0xE0,0x01,0x00,0x00,0xC5,0xF8,0x29,0xBC,0x24,0xD0,0x01,0x00,0x00,0xC5,0x78,0x29,0x84,0x24,0xC0,0x01,0x00,0x00,0xC5,0x78,0x29,0x8C,0x24,0xB0,0x01,0x00,0x00,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x62,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0xC5,0xFD,0x10,0x02,0xC7,0x84,0x24,0xAC,0x01,0x00,0x00,0x3C,0x00,0x00,0x00,0x48,0x8D,0x84,0x24,0xAC,0x01,0x00,0x00,0xC4,0xE2,0x7D,0x78,0x8C,0x24,0xAC,0x01,0x00,0x00,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xC4,0xE3,0x7D,0x19,0xDC,0x00,0xC4,0xE2,0x7D,0x30,0xE4,0xC4,0xE3,0x7D,0x19,0xDB,0x01,0xC4,0xE2,0x7D,0x30,0xDB,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xF0,0xC5,0xDD,0xF1,0xE6,0xC4,0xE2,0x5D,0x00,0xE5,0xC5,0xF9,0x6E,0xF0,0xC5,0xE5,0xF1,0xDE,0xC4,0xE2,0x65,0x00,0xDD,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x28,0xC5,0xFC,0x28,0xF5,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xFF,0xC4,0xE2,0x5D,0x00,0xFF,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x4D,0xFC,0xF0,0xC4,0xE2,0x5D,0x00,0xE6,0xC5,0xC5,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xD5,0xFC,0xF6,0xC4,0xE2,0x65,0x00,0xF6,0xC4,0xE3,0x65,0x46,0xDB,0x03,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x38,0xC5,0xD5,0xFC,0xEF,0xC4,0xE2,0x65,0x00,0xDD,0xC5,0xCD,0xEB,0xDB,0xC4,0xE3,0x7D,0x19,0xDB,0x00,0xC5,0xD4,0x57,0xED,0xC4,0xE3,0x55,0x38,0xE4,0x00,0xC4,0xE3,0x5D,0x38,0xDB,0x01,0xC5,0xFC,0x28,0xE2,0xC4,0xE3,0x7D,0x19,0xE5,0x00,0xC4,0xE2,0x7D,0x30,0xED,0xC4,0xE3,0x7D,0x19,0xE4,0x01,0xC4,0xE2,0x7D,0x30,0xE4,0x48,0xB8,0xF9,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xF8,0xC5,0xD5,0xD1,0xEF,0xC4,0xE2,0x55,0x00,0xEE,0xC5,0xF9,0x6E,0xF8,0xC5,0xDD,0xD1,0xE7,0xC4,0xE2,0x5D,0x00,0xE6,0x48,0xB8,0x89,0x89,0xC4,0x14,0xA5,0x02,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0x4C,0x8D,0x84,0x24,0x98,0x01,0x00,0x00,0x49,0x89,0x00,0x41,0x89,0x50,0x08,0x8B,0x84,0x24,0xA0,0x01,0x00,0x00,0xC5,0xFA,0x6F,0xB4,0x24,0x98,0x01,0x00,0x00,0xC5,0xFA,0x7F,0xB4,0x24,0x78,0x01,0x00,0x00,0x48,0x8B,0x94,0x24,0x78,0x01,0x00,0x00,0x4C,0x8D,0x84,0x24,0x88,0x01,0x00,0x00,0xC5,0xC8,0x57,0xF6,0xC4,0xC1,0x7A,0x7F,0x30,0x48,0x89,0x94,0x24,0x70,0x01,0x00,0x00,0x48,0x8B,0x94,0x24,0x70,0x01,0x00,0x00,0x4C,0x8D,0x84,0x24,0x88,0x01,0x00,0x00,0x49,0x89,0x10,0x89,0x84,0x24,0x90,0x01,0x00,0x00,0x48,0x8D,0x84,0x24,0x88,0x01,0x00,0x00,0x48,0x8B,0x10,0x8B,0x40,0x08,0x4C,0x8D,0x84,0x24,0x60,0x01,0x00,0x00,0x49,0x89,0x10,0x41,0x89,0x40,0x08,0xC5,0xFA,0x6F,0xB4,0x24,0x60,0x01,0x00,0x00,0xC5,0xFA,0x7F,0xB4,0x24,0x50,0x01,0x00,0x00,0xC5,0xFA,0x6F,0xB4,0x24,0x50,0x01,0x00,0x00,0xC5,0xFA,0x7F,0xB4,0x24,0x40,0x01,0x00,0x00,0x48,0x8B,0x84,0x24,0x40,0x01,0x00,0x00,0xC5,0xFF,0xF0,0x30,0xC5,0xFC,0x28,0xFE,0x48,0x8D,0x84,0x24,0x20,0x01,0x00,0x00,0xC4,0x41,0x38,0x57,0xC0,0xC5,0x7A,0x7F,0x00,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0x18,0x01,0x00,0x00,0x48,0x8B,0x84,0x24,0x18,0x01,0x00,0x00,0x48,0x8D,0x94,0x24,0x20,0x01,0x00,0x00,0x48,0x89,0x02,0xC7,0x84,0x24,0x28,0x01,0x00,0x00,0x20,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x84,0x24,0x20,0x01,0x00,0x00,0xC5,0x7A,0x7F,0x84,0x24,0x30,0x01,0x00,0x00,0xC5,0x7A,0x6F,0x84,0x24,0x30,0x01,0x00,0x00,0xC5,0x7A,0x7F,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0x7A,0x6F,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0x7A,0x7F,0x84,0x24,0xF8,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0x7F,0xF0,0x00,0xC4,0x41,0x45,0xFC,0xC0,0xC4,0x42,0x55,0x00,0xC0,0xC4,0xE3,0x55,0x46,0xED,0x03,0x48,0x8D,0x84,0x24,0xD8,0x00,0x00,0x00,0xC4,0x41,0x30,0x57,0xC9,0xC5,0x7A,0x7F,0x08,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0xD0,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xD0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xD8,0x00,0x00,0x00,0x48,0x89,0x02,0xC7,0x84,0x24,0xE0,0x00,0x00,0x00,0x20,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x8C,0x24,0xD8,0x00,0x00,0x00,0xC5,0x7A,0x7F,0x8C,0x24,0xE8,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x8C,0x24,0xE8,0x00,0x00,0x00,0xC5,0x7A,0x7F,0x8C,0x24,0xC0,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x8C,0x24,0xC0,0x00,0x00,0x00,0xC5,0x7A,0x7F,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0x7F,0xF0,0x08,0xC4,0xC1,0x45,0xFC,0xF9,0xC4,0xE2,0x55,0x00,0xEF,0xC5,0xBD,0xEB,0xED,0xC4,0xE3,0x7D,0x19,0xED,0x00,0x48,0x8D,0x84,0x24,0x90,0x00,0x00,0x00,0xC5,0xC0,0x57,0xFF,0xC5,0xFA,0x7F,0x38,0x48,0xB8,0x99,0x8A,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x02,0xC7,0x84,0x24,0x98,0x00,0x00,0x00,0x20,0x00,0x00,0x00,0xC5,0xFA,0x6F,0xBC,0x24,0x90,0x00,0x00,0x00,0xC5,0xFA,0x7F,0xBC,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0xBC,0x24,0xA0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x7C,0x24,0x78,0xC5,0xFA,0x6F,0x7C,0x24,0x78,0xC5,0xFA,0x7F,0x7C,0x24,0x68,0x48,0x8B,0x44,0x24,0x68,0xC5,0xFF,0xF0,0x38,0xC5,0xCD,0xFC,0xFF,0xC4,0xE2,0x5D,0x00,0xFF,0xC4,0xE3,0x5D,0x46,0xE4,0x03,0x48,0x8D,0x44,0x24,0x48,0xC4,0x41,0x38,0x57,0xC0,0xC5,0x7A,0x7F,0x00,0x48,0xB8,0xF9,0x8C,0xC4,0x14,0xA5,0x02,0x00,0x00,0x48,0x89,0x44,0x24,0x40,0x48,0x8B,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x48,0x48,0x89,0x02,0xC7,0x44,0x24,0x50,0x20,0x00,0x00,0x00,0xC5,0x7A,0x6F,0x44,0x24,0x48,0xC5,0x7A,0x7F,0x44,0x24,0x58,0xC5,0x7A,0x6F,0x44,0x24,0x58,0xC5,0x7A,0x7F,0x44,0x24,0x30,0xC5,0x7A,0x6F,0x44,0x24,0x30,0xC5,0x7A,0x7F,0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x20,0xC5,0x7F,0xF0,0x00,0xC4,0xC1,0x4D,0xFC,0xF0,0xC4,0xE2,0x5D,0x00,0xE6,0xC5,0xC5,0xEB,0xE4,0xC4,0xE3,0x7D,0x19,0xE4,0x00,0xC5,0xCC,0x57,0xF6,0xC4,0xE3,0x4D,0x38,0xED,0x00,0xC4,0xE3,0x55,0x38,0xE4,0x01,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x28,0xB4,0x24,0xE0,0x01,0x00,0x00,0xC5,0xF8,0x28,0xBC,0x24,0xD0,0x01,0x00,0x00,0xC5,0x78,0x28,0x84,0x24,0xC0,0x01,0x00,0x00,0xC5,0x78,0x28,0x8C,0x24,0xB0,0x01,0x00,0x00,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xF8,0x01,0x00,0x00,0x5E,0x5F,0xC3,0xE8,0xC0,0x4A,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly_16x2(ushort x)
; location: [7FFDDAFDA320h, 7FFDDAFDA350h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah and edx,3C3Ch                 ; AND(And_rm32_imm32) [EDX,3c3ch:imm32]                encoding(6 bytes) = 81 e2 3c 3c 00 00
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
0015h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0017h shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
001ah xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h and edx,3C3Ch                 ; AND(And_rm32_imm32) [EDX,3c3ch:imm32]                encoding(6 bytes) = 81 e2 3c 3c 00 00
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
002dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_16x2Bytes => new byte[49]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0x81,0xE2,0x3C,0x3C,0x00,0x00,0x8B,0xCA,0xC1,0xE1,0x02,0x33,0xCA,0xC1,0xEA,0x02,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0x3C,0x3C,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly_128x16x2(Vector128<ushort> x)
; location: [7FFDDAFDA370h, 7FFDDAFDA3D1h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw xmm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpsllw xmm3,xmm3,xmm4         ; VPSLLW(VEX_Vpsllw_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f1 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrlw xmm4,xmm4,xmm5         ; VPSRLW(VEX_Vpsrlw_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d1 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x16x2Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF1,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD1,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly_256x16x2(Vector256<ushort> x)
; location: [7FFDDAFDA400h, 7FFDDAFDA464h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],3C3Ch   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw ymm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpsllw ymm3,ymm3,xmm4         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f1 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrlw ymm4,ymm4,xmm5         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d1 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x16x2Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF1,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD1,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint butterfly_32x2(uint x)
; location: [7FFDDAFDA490h, 7FFDDAFDA4AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,3C3C3C3Ch             ; AND(And_EAX_imm32) [EAX,3c3c3c3ch:imm32]             encoding(5 bytes) = 25 3c 3c 3c 3c
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,2                     ; SHL(Shl_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 e2 02
0011h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0013h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h and eax,3C3C3C3Ch             ; AND(And_EAX_imm32) [EAX,3c3c3c3ch:imm32]             encoding(5 bytes) = 25 3c 3c 3c 3c
001dh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x2Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x3C,0x3C,0x3C,0x3C,0x8B,0xD0,0xC1,0xE2,0x02,0x33,0xD0,0xC1,0xE8,0x02,0x33,0xC2,0x25,0x3C,0x3C,0x3C,0x3C,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x2(Vector128<uint> x)
; location: [7FFDDAFDA4C0h, 7FFDDAFDA521h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld xmm3,xmm3,xmm4         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f2 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld xmm4,xmm4,xmm5         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d2 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x2Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF2,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD2,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x2(Vector256<uint> x)
; location: [7FFDDAFDA550h, 7FFDDAFDA5B4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],3C3C3C3Ch; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3c3c3c3ch:imm32] encoding(8 bytes) = c7 44 24 04 3c 3c 3c 3c
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld ymm3,ymm3,xmm4         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f2 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld ymm4,ymm4,xmm5         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d2 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x2Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x3C,0x3C,0x3C,0x3C,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF2,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD2,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x2(ulong x)
; location: [7FFDDAFDA5E0h, 7FFDDAFDA616h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,2                     ; SHL(Shl_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 e2 02
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,2                     ; SHR(Shr_rm64_imm8) [RAX,2h:imm8]                     encoding(4 bytes) = 48 c1 e8 02
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RDX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 ba 3c 3c 3c 3c 3c 3c 3c 3c
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x2Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x02,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x02,0x48,0x33,0xC2,0x48,0xBA,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x2(Vector128<ulong> x)
; location: [7FFDDAFDA630h, 7FFDDAFDA695h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq xmm3,xmm3,xmm4         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f3 dc
003eh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq xmm4,xmm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d3 e5
004ah vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004eh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0052h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0056h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
005ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x2Bytes => new byte[102]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF3,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD3,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x2(Vector256<ulong> x)
; location: [7FFDDAFDA6C0h, 7FFDDAFDA728h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,3C3C3C3C3C3C3C3Ch     ; MOV(Mov_r64_imm64) [RAX,3c3c3c3c3c3c3c3ch:imm64]     encoding(10 bytes) = 48 b8 3c 3c 3c 3c 3c 3c 3c 3c
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq ymm3,ymm3,xmm4         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f3 dc
003eh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq ymm4,ymm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d3 e5
004ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004eh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0052h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0056h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
005ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x2Bytes => new byte[105]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x3C,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x02,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF3,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD3,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort butterfly_16x4(ushort x)
; location: [7FFDDAFDA750h, 7FFDDAFDA783h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000dh and edx,0FF0h                 ; AND(And_rm32_imm32) [EDX,ff0h:imm32]                 encoding(6 bytes) = 81 e2 f0 0f 00 00
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0018h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
001ah shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
001dh xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h and edx,0FF0h                 ; AND(And_rm32_imm32) [EDX,ff0h:imm32]                 encoding(6 bytes) = 81 e2 f0 0f 00 00
002bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002eh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0030h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_16x4Bytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0x0F,0xB7,0xD2,0x81,0xE2,0xF0,0x0F,0x00,0x00,0x8B,0xCA,0xC1,0xE1,0x04,0x33,0xCA,0xC1,0xEA,0x04,0x33,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xD2,0x81,0xE2,0xF0,0x0F,0x00,0x00,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ushort> vbutterfly_128x16x4(Vector128<ushort> x)
; location: [7FFDDAFDABA0h, 7FFDDAFDAC01h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw xmm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_xmm_xmmm16) [XMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 79 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpsllw xmm3,xmm3,xmm4         ; VPSLLW(VEX_Vpsllw_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f1 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrlw xmm4,xmm4,xmm5         ; VPSRLW(VEX_Vpsrlw_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d1 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x16x4Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x79,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF1,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD1,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ushort> vbutterfly_256x16x4(Vector256<ushort> x)
; location: [7FFDDAFDAC30h, 7FFDDAFDAC94h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],0FF0h   ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f 00 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastw ymm1,word ptr [rsp+4]; VPBROADCASTW(VEX_Vpbroadcastw_ymm_xmmm16) [YMM1,mem(16i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 79 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpsllw ymm3,ymm3,xmm4         ; VPSLLW(VEX_Vpsllw_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f1 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrlw ymm4,ymm4,xmm5         ; VPSRLW(VEX_Vpsrlw_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d1 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x16x4Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x79,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF1,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD1,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_32x4(uint x)
; location: [7FFDDAFDACC0h, 7FFDDAFDACDFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0FF00FF0h             ; AND(And_EAX_imm32) [EAX,ff00ff0h:imm32]              encoding(5 bytes) = 25 f0 0f f0 0f
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
0011h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0013h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h and eax,0FF00FF0h             ; AND(And_EAX_imm32) [EAX,ff00ff0h:imm32]              encoding(5 bytes) = 25 f0 0f f0 0f
001dh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x4Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xF0,0x0F,0xF0,0x0F,0x8B,0xD0,0xC1,0xE2,0x04,0x33,0xD0,0xC1,0xE8,0x04,0x33,0xC2,0x25,0xF0,0x0F,0xF0,0x0F,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x4(Vector128<uint> x)
; location: [7FFDDAFDACF0h, 7FFDDAFDAD51h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld xmm3,xmm3,xmm4         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f2 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld xmm4,xmm4,xmm5         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d2 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x4Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF2,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD2,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x4(Vector256<uint> x)
; location: [7FFDDAFDAD80h, 7FFDDAFDADE4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],0FF00FF0h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ff00ff0h:imm32] encoding(8 bytes) = c7 44 24 04 f0 0f f0 0f
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld ymm3,ymm3,xmm4         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f2 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld ymm4,ymm4,xmm5         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d2 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x4Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0xF0,0x0F,0xF0,0x0F,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF2,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD2,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x4(ulong x)
; location: [7FFDDAFDAE10h, 7FFDDAFDAE46h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,4                     ; SHL(Shl_rm64_imm8) [RDX,4h:imm8]                     encoding(4 bytes) = 48 c1 e2 04
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,4                     ; SHR(Shr_rm64_imm8) [RAX,4h:imm8]                     encoding(4 bytes) = 48 c1 e8 04
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RDX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 ba f0 0f f0 0f f0 0f f0 0f
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x4Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x04,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x04,0x48,0x33,0xC2,0x48,0xBA,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x4(Vector128<ulong> x)
; location: [7FFDDAFDAE60h, 7FFDDAFDAEC5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq xmm3,xmm3,xmm4         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f3 dc
003eh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq xmm4,xmm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d3 e5
004ah vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004eh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0052h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0056h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
005ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x4Bytes => new byte[102]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF3,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD3,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x4(Vector256<ulong> x)
; location: [7FFDDAFDAEF0h, 7FFDDAFDAF58h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,0FF00FF00FF00FF0h     ; MOV(Mov_r64_imm64) [RAX,ff00ff00ff00ff0h:imm64]      encoding(10 bytes) = 48 b8 f0 0f f0 0f f0 0f f0 0f
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq ymm3,ymm3,xmm4         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f3 dc
003eh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq ymm4,ymm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d3 e5
004ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004eh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0052h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0056h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
005ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x4Bytes => new byte[105]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0xF0,0x0F,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF3,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD3,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_32x8(uint x)
; location: [7FFDDAFDAF80h, 7FFDDAFDAF9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0FFFF00h              ; AND(And_EAX_imm32) [EAX,ffff00h:imm32]               encoding(5 bytes) = 25 00 ff ff 00
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0011h xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
0013h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
0016h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0018h and eax,0FFFF00h              ; AND(And_EAX_imm32) [EAX,ffff00h:imm32]               encoding(5 bytes) = 25 00 ff ff 00
001dh xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_32x8Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0x00,0xFF,0xFF,0x00,0x8B,0xD0,0xC1,0xE2,0x08,0x33,0xD0,0xC1,0xE8,0x08,0x33,0xC2,0x25,0x00,0xFF,0xFF,0x00,0x33,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vbutterfly_128x32x8(Vector128<uint> x)
; location: [7FFDDAFDAFB0h, 7FFDDAFDB011h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd xmm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_xmm_xmmm32) [XMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 58 4c 24 04
001dh vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0021h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0025h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
0029h vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
002dh mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld xmm3,xmm3,xmm4         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f2 dc
003ah vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld xmm4,xmm4,xmm5         ; VPSRLD(VEX_Vpsrld_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d2 e5
0046h vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004ah vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
004eh vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0052h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
0056h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x32x8Bytes => new byte[98]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x4C,0x24,0x04,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x08,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF2,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD2,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> vbutterfly_256x32x8(Vector256<uint> x)
; location: [7FFDDAFDB040h, 7FFDDAFDB0A4h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov dword ptr [rsp+4],0FFFF00h; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),ffff00h:imm32] encoding(8 bytes) = c7 44 24 04 00 ff ff 00
0011h lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0016h vpbroadcastd ymm1,dword ptr [rsp+4]; VPBROADCASTD(VEX_Vpbroadcastd_ymm_xmmm32) [YMM1,mem(32i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 7d 58 4c 24 04
001dh vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0021h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0025h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
0029h vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
002dh mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0032h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
0036h vpslld ymm3,ymm3,xmm4         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f2 dc
003ah vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
003eh vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0042h vpsrld ymm4,ymm4,xmm5         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d2 e5
0046h vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004ah vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
004eh vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0052h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
0056h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
005dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0060h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0064h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x32x8Bytes => new byte[101]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0xC7,0x44,0x24,0x04,0x00,0xFF,0xFF,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x04,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x08,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF2,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD2,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x8(ulong x)
; location: [7FFDDAFDB0D0h, 7FFDDAFDB106h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RDX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 ba 00 ff ff 00 00 ff ff 00
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x8Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x08,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x08,0x48,0x33,0xC2,0x48,0xBA,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x8(Vector128<ulong> x)
; location: [7FFDDAFDB120h, 7FFDDAFDB185h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq xmm3,xmm3,xmm4         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f3 dc
003eh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq xmm4,xmm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d3 e5
004ah vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004eh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0052h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0056h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
005ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x8Bytes => new byte[102]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x08,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF3,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD3,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x8(Vector256<ulong> x)
; location: [7FFDDAFDB1B0h, 7FFDDAFDB218h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,0FFFF0000FFFF00h      ; MOV(Mov_r64_imm64) [RAX,ffff0000ffff00h:imm64]       encoding(10 bytes) = 48 b8 00 ff ff 00 00 ff ff 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq ymm3,ymm3,xmm4         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f3 dc
003eh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq ymm4,ymm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d3 e5
004ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004eh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0052h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0056h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
005ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x8Bytes => new byte[105]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x00,0xFF,0xFF,0x00,0x00,0xFF,0xFF,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x08,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF3,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD3,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong butterfly_64x16(ulong x)
; location: [7FFDDAFDB240h, 7FFDDAFDB276h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
000fh and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0012h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0015h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
0019h xor rdx,rax                   ; XOR(Xor_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 33 d0
001ch shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
0020h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
0023h mov rdx,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RDX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 ba 00 00 ff ff ff ff 00 00
002dh and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
0030h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0033h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> butterfly_64x16Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x23,0xC1,0x48,0x8B,0xD0,0x48,0xC1,0xE2,0x10,0x48,0x33,0xD0,0x48,0xC1,0xE8,0x10,0x48,0x33,0xC2,0x48,0xBA,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x23,0xD0,0x48,0x33,0xD1,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<ulong> vbutterfly_128x64x16(Vector128<ulong> x)
; location: [7FFDDAFDB290h, 7FFDDAFDB2F5h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq xmm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_xmm_xmmm64) [XMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 79 59 0c 24
0021h vmovaps xmm2,xmm0             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM0]         encoding(VEX, 4 bytes) = c5 f8 28 d0
0025h vmovaps xmm3,xmm1             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM1]         encoding(VEX, 4 bytes) = c5 f8 28 d9
0029h vpand xmm2,xmm2,xmm3          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 db d3
002dh vmovaps xmm3,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM3,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 da
0031h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq xmm3,xmm3,xmm4         ; VPSLLQ(VEX_Vpsllq_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e1 f3 dc
003eh vmovaps xmm4,xmm2             ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM4,XMM2]         encoding(VEX, 4 bytes) = c5 f8 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq xmm4,xmm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_xmm_xmm_xmmm128) [XMM4,XMM4,XMM5]  encoding(VEX, 4 bytes) = c5 d9 d3 e5
004ah vpxor xmm3,xmm3,xmm4          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM3,XMM3,XMM4]    encoding(VEX, 4 bytes) = c5 e1 ef dc
004eh vpxor xmm2,xmm2,xmm3          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM2,XMM2,XMM3]    encoding(VEX, 4 bytes) = c5 e9 ef d3
0052h vpand xmm1,xmm2,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM1,XMM2,XMM1]    encoding(VEX, 4 bytes) = c5 e9 db c9
0056h vpxor xmm0,xmm1,xmm0          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM1,XMM0]    encoding(VEX, 4 bytes) = c5 f1 ef c0
005ah vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_128x64x16Bytes => new byte[102]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x59,0x0C,0x24,0xC5,0xF8,0x28,0xD0,0xC5,0xF8,0x28,0xD9,0xC5,0xE9,0xDB,0xD3,0xC5,0xF8,0x28,0xDA,0xB8,0x10,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE1,0xF3,0xDC,0xC5,0xF8,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xD9,0xD3,0xE5,0xC5,0xE1,0xEF,0xDC,0xC5,0xE9,0xEF,0xD3,0xC5,0xE9,0xDB,0xC9,0xC5,0xF1,0xEF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<ulong> vbutterfly_256x64x16(Vector256<ulong> x)
; location: [7FFDDAFDB320h, 7FFDDAFDB388h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h mov rax,0FFFFFFFF0000h        ; MOV(Mov_r64_imm64) [RAX,ffffffff0000h:imm64]         encoding(10 bytes) = 48 b8 00 00 ff ff ff ff 00 00
0013h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0017h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
001bh vpbroadcastq ymm1,qword ptr [rsp]; VPBROADCASTQ(VEX_Vpbroadcastq_ymm_xmmm64) [YMM1,mem(64i,RSP:br,:sr)] encoding(VEX, 6 bytes) = c4 e2 7d 59 0c 24
0021h vmovaps ymm2,ymm0             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM2,YMM0]         encoding(VEX, 4 bytes) = c5 fc 28 d0
0025h vmovaps ymm3,ymm1             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM1]         encoding(VEX, 4 bytes) = c5 fc 28 d9
0029h vpand ymm2,ymm2,ymm3          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed db d3
002dh vmovaps ymm3,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM3,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 da
0031h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0036h vmovd xmm4,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM4,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e0
003ah vpsllq ymm3,ymm3,xmm4         ; VPSLLQ(VEX_Vpsllq_ymm_ymm_xmmm128) [YMM3,YMM3,XMM4]  encoding(VEX, 4 bytes) = c5 e5 f3 dc
003eh vmovaps ymm4,ymm2             ; VMOVAPS(VEX_Vmovaps_ymm_ymmm256) [YMM4,YMM2]         encoding(VEX, 4 bytes) = c5 fc 28 e2
0042h vmovd xmm5,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM5,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e e8
0046h vpsrlq ymm4,ymm4,xmm5         ; VPSRLQ(VEX_Vpsrlq_ymm_ymm_xmmm128) [YMM4,YMM4,XMM5]  encoding(VEX, 4 bytes) = c5 dd d3 e5
004ah vpxor ymm3,ymm3,ymm4          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM3,YMM3,YMM4]    encoding(VEX, 4 bytes) = c5 e5 ef dc
004eh vpxor ymm2,ymm2,ymm3          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM2,YMM2,YMM3]    encoding(VEX, 4 bytes) = c5 ed ef d3
0052h vpand ymm1,ymm2,ymm1          ; VPAND(VEX_Vpand_ymm_ymm_ymmm256) [YMM1,YMM2,YMM1]    encoding(VEX, 4 bytes) = c5 ed db c9
0056h vpxor ymm0,ymm1,ymm0          ; VPXOR(VEX_Vpxor_ymm_ymm_ymmm256) [YMM0,YMM1,YMM0]    encoding(VEX, 4 bytes) = c5 f5 ef c0
005ah vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
005eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0061h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0064h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vbutterfly_256x64x16Bytes => new byte[105]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFD,0x10,0x02,0x48,0xB8,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0x00,0x00,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x7D,0x59,0x0C,0x24,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC5,0xED,0xDB,0xD3,0xC5,0xFC,0x28,0xDA,0xB8,0x10,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xE0,0xC5,0xE5,0xF3,0xDC,0xC5,0xFC,0x28,0xE2,0xC5,0xF9,0x6E,0xE8,0xC5,0xDD,0xD3,0xE5,0xC5,0xE5,0xEF,0xDC,0xC5,0xED,0xEF,0xD3,0xC5,0xED,0xDB,0xC9,0xC5,0xF5,0xEF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 alt_32()
; location: [7FFDDAFDB3B0h, 7FFDDAFDB3BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0AAAAAAAAh            ; MOV(Mov_r32_imm32) [EAX,aaaaaaaah:imm32]             encoding(5 bytes) = b8 aa aa aa aa
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> alt_32Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xAA,0xAA,0xAA,0xAA,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
; location: [7FFDDAFDC4A0h, 7FFDDAFDC521h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0011h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0014h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
0016h mov edi,r8d                   ; MOV(Mov_r32_rm32) [EDI,R8D]                          encoding(3 bytes) = 41 8b f8
0019h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
001eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0022h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0026h lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
002bh call 7FFDDAFDB870h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF3D0h:jmp64]        encoding(5 bytes) = e8 a0 f3 ff ff
0030h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0035h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0038h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
003ah movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
003dh lea rcx,[rax+rcx*4]           ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 0c 88
0041h movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0045h bt esi,r8d                    ; BT(Bt_rm32_r32) [ESI,R8D]                            encoding(4 bytes) = 44 0f a3 c6
0049h setb r8b                      ; SETB(Setb_rm8) [R8L]                                 encoding(4 bytes) = 41 0f 92 c0
004dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0051h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
0054h jne short 005bh               ; JNE(Jne_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 75 05
0056h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0059h jmp short 005eh               ; JMP(Jmp_rel8_64) [5Eh:jmp64]                         encoding(2 bytes) = eb 03
005bh mov r8d,edi                   ; MOV(Mov_r32_rm32) [R8D,EDI]                          encoding(3 bytes) = 44 8b c7
005eh mov [rcx],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R8D]          encoding(3 bytes) = 44 89 01
0061h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0063h cmp edx,20h                   ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]                   encoding(3 bytes) = 83 fa 20
0066h jl short 003ah                ; JL(Jl_rel8_64) [3Ah:jmp64]                           encoding(2 bytes) = 7c d2
0068h lea rsi,[rsp+20h]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 74 24 20
006dh mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
0070h call 7FFE3A423690h            ; CALL(Call_rel32_64) [5F4471F0h:jmp64]                encoding(5 bytes) = e8 7b 71 44 5f
0075h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,:sr)]         encoding(2 bytes) = 48 a5
0077h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
007ah add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
007eh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
007fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0080h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0081h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> oprod_2Bytes => new byte[130]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xD9,0x8B,0xF2,0x41,0x8B,0xF8,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0xE8,0xA0,0xF3,0xFF,0xFF,0x48,0x8D,0x44,0x24,0x20,0x48,0x8B,0x00,0x33,0xD2,0x48,0x63,0xCA,0x48,0x8D,0x0C,0x88,0x44,0x0F,0xB6,0xC2,0x44,0x0F,0xA3,0xC6,0x41,0x0F,0x92,0xC0,0x45,0x0F,0xB6,0xC0,0x45,0x85,0xC0,0x75,0x05,0x45,0x33,0xC0,0xEB,0x03,0x44,0x8B,0xC7,0x44,0x89,0x01,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD2,0x48,0x8D,0x74,0x24,0x20,0x48,0x8B,0xFB,0xE8,0x7B,0x71,0x44,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
; location: [7FFDDAFDC540h, 7FFDDAFDC57Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 8b 00
0008h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
000bh movsxd r10,r9d                ; MOVSXD(Movsxd_r64_rm32) [R10,R9D]                    encoding(3 bytes) = 4d 63 d1
000eh lea r10,[rax+r10*4]           ; LEA(Lea_r64_m) [R10,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 4e 8d 14 90
0012h movzx r11d,r9b                ; MOVZX(Movzx_r32_rm8) [R11D,R9L]                      encoding(4 bytes) = 45 0f b6 d9
0016h bt ecx,r11d                   ; BT(Bt_rm32_r32) [ECX,R11D]                           encoding(4 bytes) = 44 0f a3 d9
001ah setb r11b                     ; SETB(Setb_rm8) [R11L]                                encoding(4 bytes) = 41 0f 92 c3
001eh movzx r11d,r11b               ; MOVZX(Movzx_r32_rm8) [R11D,R11L]                     encoding(4 bytes) = 45 0f b6 db
0022h test r11d,r11d                ; TEST(Test_rm32_r32) [R11D,R11D]                      encoding(3 bytes) = 45 85 db
0025h jne short 002ch               ; JNE(Jne_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = 75 05
0027h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
002ah jmp short 002fh               ; JMP(Jmp_rel8_64) [2Fh:jmp64]                         encoding(2 bytes) = eb 03
002ch mov r11d,edx                  ; MOV(Mov_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 8b da
002fh mov [r10],r11d                ; MOV(Mov_rm32_r32) [mem(32u,R10:br,:sr),R11D]         encoding(3 bytes) = 45 89 1a
0032h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0035h cmp r9d,20h                   ; CMP(Cmp_rm32_imm8) [R9D,20h:imm32]                   encoding(4 bytes) = 41 83 f9 20
0039h jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c d0
003bh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> oprod_3Bytes => new byte[63]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0x00,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x4E,0x8D,0x14,0x90,0x45,0x0F,0xB6,0xD9,0x44,0x0F,0xA3,0xD9,0x41,0x0F,0x92,0xC3,0x45,0x0F,0xB6,0xDB,0x45,0x85,0xDB,0x75,0x05,0x45,0x33,0xDB,0xEB,0x03,0x44,0x8B,0xDA,0x45,0x89,0x1A,0x41,0xFF,0xC1,0x41,0x83,0xF9,0x20,0x7C,0xD0,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
; location: [7FFE3925D1D0h, 7FFE3925D1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE38E7F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,:sr)]        encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> oprod_4Bytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> bitchars_8u(byte value)
; location: [7FFDDAFDC5E0h, 7FFDDAFDC613h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
000bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
000eh mov rdx,2A52EA4CD35h          ; MOV(Mov_r64_imm64) [RDX,2a52ea4cd35h:imm64]          encoding(10 bytes) = 48 ba 35 cd a4 2e a5 02 00 00
0018h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
001bh mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0020h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0023h mov [rcx+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EDX]          encoding(3 bytes) = 89 51 08
0026h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0029h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002eh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F572770h:jmp64]                encoding(5 bytes) = e8 3d 27 57 5f
0033h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitchars_8uBytes => new byte[52]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x04,0x48,0x63,0xC0,0x48,0xBA,0x35,0xCD,0xA4,0x2E,0xA5,0x02,0x00,0x00,0x48,0x03,0xC2,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x3D,0x27,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_8u(byte value, Span<Char> dst)
; location: [7FFDDAFDCA30h, 7FFDDAFDCA56h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
000eh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0011h mov rcx,2A52EA4CD35h          ; MOV(Mov_r64_imm64) [RCX,2a52ea4cd35h:imm64]          encoding(10 bytes) = 48 b9 35 cd a4 2e a5 02 00 00
001bh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
001eh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0022h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitchars_8uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0xC1,0xE2,0x04,0x48,0x63,0xD2,0x48,0xB9,0x35,0xCD,0xA4,0x2E,0xA5,0x02,0x00,0x00,0x48,0x03,0xD1,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_16u(ushort value, Span<Char> dst)
; location: [7FFDDAFDCA70h, 7FFDDAFDCAC2h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
000bh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
000eh shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0011h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0014h mov r8,2A52EA4CD35h           ; MOV(Mov_r64_imm64) [R8,2a52ea4cd35h:imm64]           encoding(10 bytes) = 49 b8 35 cd a4 2e a5 02 00 00
001eh add rcx,r8                    ; ADD(Add_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 03 c8
0021h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0024h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0028h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
002dh sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
0030h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0033h shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
0036h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0039h mov rcx,2A52EA4CD35h          ; MOV(Mov_r64_imm64) [RCX,2a52ea4cd35h:imm64]          encoding(10 bytes) = 48 b9 35 cd a4 2e a5 02 00 00
0043h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0046h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
004ah vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
004eh vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0052h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitchars_16uBytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xB8,0x35,0xCD,0xA4,0x2E,0xA5,0x02,0x00,0x00,0x49,0x03,0xC8,0x4C,0x8B,0xC0,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC1,0xE2,0x04,0x48,0x63,0xD2,0x48,0xB9,0x35,0xCD,0xA4,0x2E,0xA5,0x02,0x00,0x00,0x48,0x03,0xD1,0x48,0x83,0xC0,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_32u(uint value, Span<Char> dst)
; location: [7FFDDAFDCAE0h, 7FFDDAFDCB2Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0014h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0017h mov r10d,edx                  ; MOV(Mov_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 8b d2
001ah shr r10d,cl                   ; SHR(Shr_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 ea
001dh movzx ecx,r10b                ; MOVZX(Movzx_r32_rm8) [ECX,R10L]                      encoding(4 bytes) = 41 0f b6 ca
0021h shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0024h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0027h mov r10,2A52EA4CD35h          ; MOV(Mov_r64_imm64) [R10,2a52ea4cd35h:imm64]          encoding(10 bytes) = 49 ba 35 cd a4 2e a5 02 00 00
0031h add rcx,r10                   ; ADD(Add_r64_rm64) [RCX,R10]                          encoding(3 bytes) = 49 03 ca
0034h movsxd r9,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]                     encoding(3 bytes) = 4d 63 c9
0037h lea r9,[rax+r9*2]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4e 8d 0c 48
003bh vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
003fh vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0044h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0047h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
004bh jl short 000dh                ; JL(Jl_rel8_64) [Dh:jmp64]                            encoding(2 bytes) = 7c c0
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitchars_32uBytes => new byte[78]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x45,0x33,0xC0,0x45,0x8B,0xC8,0x41,0xC1,0xE1,0x03,0x41,0x8B,0xC9,0x44,0x8B,0xD2,0x41,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xBA,0x35,0xCD,0xA4,0x2E,0xA5,0x02,0x00,0x00,0x49,0x03,0xCA,0x4D,0x63,0xC9,0x4E,0x8D,0x0C,0x48,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x01,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x04,0x7C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitchars_64u(ulong value, Span<Char> dst)
; location: [7FFDDAFDCB40h, 7FFDDAFDCB8Eh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
000bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0015h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0018h mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
001bh shr r10,cl                    ; SHR(Shr_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 ea
001eh movzx ecx,r10b                ; MOVZX(Movzx_r32_rm8) [ECX,R10L]                      encoding(4 bytes) = 41 0f b6 ca
0022h shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0025h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0028h mov r10,2A52EA4CD35h          ; MOV(Mov_r64_imm64) [R10,2a52ea4cd35h:imm64]          encoding(10 bytes) = 49 ba 35 cd a4 2e a5 02 00 00
0032h add rcx,r10                   ; ADD(Add_r64_rm64) [RCX,R10]                          encoding(3 bytes) = 49 03 ca
0035h movsxd r9,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]                     encoding(3 bytes) = 4d 63 c9
0038h lea r9,[rax+r9*2]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4e 8d 0c 48
003ch vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0040h vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0045h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0048h cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
004ch jl short 000eh                ; JL(Jl_rel8_64) [Eh:jmp64]                            encoding(2 bytes) = 7c c0
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitchars_64uBytes => new byte[79]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x48,0x8B,0xD1,0x45,0x33,0xC0,0x45,0x8B,0xC8,0x41,0xC1,0xE1,0x03,0x41,0x8B,0xC9,0x4C,0x8B,0xD2,0x49,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xBA,0x35,0xCD,0xA4,0x2E,0xA5,0x02,0x00,0x00,0x49,0x03,0xCA,0x4D,0x63,0xC9,0x4E,0x8D,0x0C,0x48,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x01,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x08,0x7C,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDDAFDCBA0h, 7FFDDAFDCBA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bv_o32u(BitVector32 x, BitVector32 y)
; location: [7FFDDAFDCBC0h, 7FFDDAFDCBC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDDAFDCBE0h, 7FFDDAFDCBE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_o32u(BitVector32 x, BitVector32 y)
; location: [7FFDDAFDCC00h, 7FFDDAFDCC09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDDAFDCC20h, 7FFDDAFDCC29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_o32u(BitVector32 x, BitVector32 y)
; location: [7FFDDAFDCC40h, 7FFDDAFDCC49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_32u(BitVector32 x, int offset)
; location: [7FFDDAFDCC60h, 7FFDDAFDCC6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_o32u(BitVector32 x, int offset)
; location: [7FFDDAFDCC80h, 7FFDDAFDCC8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_32u(BitVector32 x, int offset)
; location: [7FFDDAFDCCA0h, 7FFDDAFDCCABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_o32u(BitVector32 x, int offset)
; location: [7FFDDAFDCCC0h, 7FFDDAFDCCCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_32u(BitVector32 x)
; location: [7FFDDAFDCCE0h, 7FFDDAFDCCE9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_o32u(BitVector32 x)
; location: [7FFDDAFDCD00h, 7FFDDAFDCD09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_32u(BitVector32 x)
; location: [7FFDDAFDCD20h, 7FFDDAFDCD2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_o32u(BitVector32 x)
; location: [7FFDDAFDCD40h, 7FFDDAFDCD4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_32u(BitVector32 x)
; location: [7FFDDAFDCD60h, 7FFDDAFDCD69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_o32u(BitVector32 x)
; location: [7FFDDAFDCD80h, 7FFDDAFDCD89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_32u(BitVector32 x)
; location: [7FFDDAFDCDA0h, 7FFDDAFDCDA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_o32u(BitVector32 x)
; location: [7FFDDAFDCDC0h, 7FFDDAFDCDC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl_bv_32u(BitVector32 x, int offset)
; location: [7FFDDAFDCDE0h, 7FFDDAFDCDEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr_bv_32u(BitVector32 x, int offset)
; location: [7FFDDAFDCE00h, 7FFDDAFDCE0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitset_2(ref ulong src, int pos, bit state)
; location: [7FFDDAFDCE20h, 7FFDDAFDCE4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and edx,3Fh                   ; AND(And_rm32_imm8) [EDX,3fh:imm32]                   encoding(3 bytes) = 83 e2 3f
000bh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0011h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0013h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0016h not r9                        ; NOT(Not_rm64) [R9]                                   encoding(3 bytes) = 49 f7 d1
0019h and r9,[rax]                  ; AND(And_r64_rm64) [R9,mem(64u,RAX:br,:sr)]           encoding(3 bytes) = 4c 23 08
001ch mov r8d,r8d                   ; MOV(Mov_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 8b c0
001fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0021h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0024h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0027h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitset_2Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x83,0xE2,0x3F,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x49,0xF7,0xD1,0x4C,0x23,0x08,0x45,0x8B,0xC0,0x8B,0xCA,0x49,0xD3,0xE0,0x4D,0x0B,0xC1,0x4C,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmask_set(ref ulong src, byte pos, bit state)
; location: [7FFDDAFDCE60h, 7FFDDAFDCE9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h test r8d,r8d                  ; TEST(Test_rm32_r32) [R8D,R8D]                        encoding(3 bytes) = 45 85 c0
000bh je short 0023h                ; JE(Je_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 74 16
000dh mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,:sr)]           encoding(3 bytes) = 4c 8b 00
0010h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0013h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0018h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
001bh or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
001eh mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0021h jmp short 003ah               ; JMP(Jmp_rel8_64) [3Ah:jmp64]                         encoding(2 bytes) = eb 17
0023h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,:sr)]           encoding(3 bytes) = 4c 8b 00
0026h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0029h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
002eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0031h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0034h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmask_setBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x45,0x85,0xC0,0x74,0x16,0x4C,0x8B,0x00,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x49,0x0B,0xD0,0x48,0x89,0x10,0xEB,0x17,0x4C,0x8B,0x00,0x0F,0xB6,0xCA,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0xF7,0xD2,0x49,0x23,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk_d8u(byte src)
; location: [7FFDDAFDCEB0h, 7FFDDAFDCEC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk_g8u(byte src)
; location: [7FFDDAFDCEE0h, 7FFDDAFDCEF0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk_d32u(uint src)
; location: [7FFDDAFDCF10h, 7FFDDAFDCF1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk_g32u(uint src)
; location: [7FFDDAFDCF30h, 7FFDDAFDCF3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
